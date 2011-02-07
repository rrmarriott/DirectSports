using System;
using System.Collections.Generic;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using DirectSports.BL.DatabaseSpecific;
using DirectSports.BL.HelperClasses;
using DirectSports.BL.FactoryClasses;

namespace DirectSports.BL.EntityClasses
{
    public partial class ProductSectionEntity
    {
        private static readonly int RootSectionId = 0; 
        
        public static List<ProductSectionEntity> GetTopLevelSections()
        {
            return GetChildSections(RootSectionId);
        }

        public static List<ProductSectionEntity> GetChildSections(int parentId)
        {
            EntityCollection sections = new EntityCollection(new ProductSectionEntityFactory());
            IRelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(PredicateFactory.CompareValue(ProductSectionFieldIndex.ParentSectionId, ComparisonOperator.Equal, parentId));

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntityCollection(sections, filter);
            }

            List<ProductSectionEntity> sectionList = new List<ProductSectionEntity>(sections.Count);
            foreach (ProductSectionEntity pse in sections)
            {
                sectionList.Add(pse);
            }

            return sectionList;
        }

        public static ProductSectionEntity LoadRootSection(string name)
        {
            ProductSectionEntity rootSection = new ProductSectionEntity(RootSectionId);
            rootSection.Name = name;
            return rootSection;
        }

        public static List<ProductEntity> LoadProductsForSection(int sectionId)
        {
            IRelationPredicateBucket filter = new RelationPredicateBucket();
            filter.Relations.Add(ProductSectionEntity.Relations.ProductEntityUsingSectionId);
            filter.PredicateExpression.Add(PredicateFactory.CompareValue(ProductSectionFieldIndex.Id, ComparisonOperator.Equal, sectionId));
            filter.PredicateExpression.AddWithAnd(PredicateFactory.CompareValue(ProductFieldIndex.Enabled, ComparisonOperator.Equal, true));

            EntityCollection products = LoadProductsForSection(filter);

            List<ProductEntity> productList = new List<ProductEntity>(products.Count);
            foreach (ProductEntity pe in products)
            {
                productList.Add(pe);
            }

            return productList;
        }

        public static List<ProductEntity> LoadAllProductsForSection(int sectionId)
        {
            IRelationPredicateBucket filter = new RelationPredicateBucket();
            filter.Relations.Add(ProductSectionEntity.Relations.ProductEntityUsingSectionId);
            filter.PredicateExpression.Add(PredicateFactory.CompareValue(ProductSectionFieldIndex.Id, ComparisonOperator.Equal, sectionId));

            EntityCollection products = LoadProductsForSection(filter);

            List<ProductEntity> productList = new List<ProductEntity>(products.Count);
            foreach (ProductEntity pe in products)
            {
                productList.Add(pe);
            }

            return productList;
        }

        private static EntityCollection LoadProductsForSection(IRelationPredicateBucket filter)
        {
            EntityCollection products = new EntityCollection(new ProductEntityFactory());
            ISortExpression sorter  = new SortExpression();
            sorter.Add(SortClauseFactory.Create(ProductFieldIndex.SortIndex, SortOperator.Ascending));

            IPrefetchPath2 pfVariations = new PrefetchPath2((int)EntityType.ProductEntity);
            pfVariations.Add(ProductEntity.PrefetchPathProductVariation);

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntityCollection(products, filter, 0, sorter, pfVariations);
            }

            return products;
        }
    }
}
