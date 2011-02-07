using System.Collections.Generic;
using System.Linq;
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
            var product = new ProductEntity(productId);

            using (var adapter = new DataAccessAdapter())
            {
                adapter.FetchEntity(product);
            }

            return product;
        }

        public static List<ProductEntity> SearchForProductsByName(string name)
        {
            var bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(PredicateFactory.Like(ProductFieldIndex.Name, string.Format("%{0}%", name)));

            var productEntities = new EntityCollection(new ProductEntityFactory());

            using (var adapter = new DataAccessAdapter())
            {
                adapter.FetchEntityCollection(productEntities, bucket);
            }

            var products = new List<ProductEntity>(productEntities.Count);
            products.AddRange(productEntities.Cast<ProductEntity>());

            return products;
        }

        public void Save()
        {
            using (var adapter = new DataAccessAdapter())
            {
                adapter.SaveEntity(this);
            }
        }

        public void Delete()
        {
            using (var adapter = new DataAccessAdapter())
            {
                adapter.DeleteEntity(this);
            }
        }
    }
}
