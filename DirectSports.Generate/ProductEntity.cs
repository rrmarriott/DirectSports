using System;
using System.Collections.Generic;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using DirectSports.BL.DatabaseSpecific;
using DirectSports.BL.HelperClasses;
using DirectSports.BL.FactoryClasses;

namespace DirectSports.BL.EntityClasses
{
    public partial class ProductEntity
    {
        public static ProductEntity LoadProductById(int productId)
        {
            ProductEntity product = new ProductEntity(productId);

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntity(product);
            }

            return product;
        }

        public static List<ProductEntity> SearchForProductsByName(string name)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(PredicateFactory.Like(ProductFieldIndex.Name, string.Format("%{0}%", name)));

            EntityCollection productEntities = new EntityCollection(new ProductEntityFactory());

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntityCollection(productEntities, bucket);
            }

            List<ProductEntity> products = new List<ProductEntity>(productEntities.Count);

            foreach (ProductEntity pe in productEntities)
            {
                products.Add(pe);
            }

            return products;
        }

        public void Save()
        {
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.SaveEntity(this);
            }
        }
    }
}
