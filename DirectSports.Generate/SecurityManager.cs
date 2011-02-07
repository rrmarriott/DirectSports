using System;
using System.Collections.Generic;
using System.Text;
using DirectSports.BL.EntityClasses;
using DirectSports.BL.HelperClasses;
using DirectSports.BL.FactoryClasses;
using DirectSports.BL.DatabaseSpecific;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL
{
    public static class SecurityManager
    {
        public static bool Login(string username, string password)
        {
            int userCount = 0;
            EntityCollection users = new EntityCollection(new UserEntityFactory());
            IRelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(PredicateFactory.CompareValue(UserFieldIndex.UserId, ComparisonOperator.Equal, username));
            filter.PredicateExpression.AddWithAnd(PredicateFactory.CompareValue(UserFieldIndex.Password, ComparisonOperator.Equal, password));

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                userCount = adapter.GetDbCount(users, filter);
            }

            return (userCount == 1);
        }

        public static string[] FindRolesForUser(string username)
        {
            EntityCollection roles = new EntityCollection(new UserRoleLinkEntityFactory());
            IRelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(PredicateFactory.CompareValue(UserRoleLinkFieldIndex.UserId, ComparisonOperator.Equal, username));

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntityCollection(roles, filter);
            }

            List<string> returnRoles = new List<string>(roles.Items.Count);

            foreach (UserRoleLinkEntity urle in roles)
            {
                returnRoles.Add(urle.RoleName);
            }

            return returnRoles.ToArray();
        }
    }
}
