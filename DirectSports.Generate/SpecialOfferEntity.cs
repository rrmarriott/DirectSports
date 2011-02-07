using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SD.LLBLGen.Pro.ORMSupportClasses;
using DirectSports.BL.DatabaseSpecific;
using DirectSports.BL.HelperClasses;
using DirectSports.BL.FactoryClasses;


namespace DirectSports.BL.EntityClasses
{
    public partial class SpecialOfferEntity
    {
        private static short m_NumberOfOffers;

        public static short NumberOfOffers
        {
            get { return m_NumberOfOffers; }
        }

        public static List<SpecialOfferEntity> GetSpecialOffers(short numberToReturn)
        {
            EntityCollection offers = new EntityCollection(new SpecialOfferEntityFactory());
            IPrefetchPath2 pf = new PrefetchPath2((int)EntityType.SpecialOfferEntity);
            pf.Add(SpecialOfferEntity.PrefetchPathProduct).SubPath.Add(ProductEntity.PrefetchPathProductSection);

            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntityCollection(offers, null, numberToReturn, null, pf);
            }

            offers.SupportsSorting = true;
            offers.Sort((int) SpecialOfferFieldIndex.Number, ListSortDirection.Ascending);

            SpecialOfferEntity [] specialOffers = new SpecialOfferEntity[numberToReturn];
            
            foreach (SpecialOfferEntity sof in offers)
            {
                specialOffers[sof.Number - 1] = sof;
            }

            return FillMissingOffers(specialOffers);
        }

        private static List<SpecialOfferEntity> FillMissingOffers(SpecialOfferEntity[] collectionToFill)
        {
            if (collectionToFill.Length > short.MaxValue)
            {
                throw new ArgumentException("The length of the collection (amount of special offers) must not exceed a short data type.");
            }
            
            for (int i = 0; i < collectionToFill.Length; i++)
            {
                SpecialOfferEntity placeholderSof = new SpecialOfferEntity();
                placeholderSof.Number = (short) (i + 1);
                ProductEntity placeholderProduct = new ProductEntity();
                placeholderProduct.Name = "Please Choose Product";
                placeholderProduct.Id = -1;

                placeholderSof.Product = placeholderProduct;
                
                if (collectionToFill[i] == null)
                {
                    collectionToFill[i] = placeholderSof;
                }
            }

            return new List<SpecialOfferEntity>(collectionToFill);
        }
    }
}
