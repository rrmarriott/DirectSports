///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: 05 September 2006 21:59:49
// Code is generated using templates: C# template set for MS Access (2000/XP/2003) (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.111705
//////////////////////////////////////////////////////////////
using System;

using DirectSports.BL;
using DirectSports.BL.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.FactoryClasses
{
	/// <summary>
	/// Factory class for IEntityField2 instances, used in IEntityFields2 instances.
	/// </summary>
	public partial class EntityFieldFactory
	{
		/// <summary> Private CTor, no instantiation possible.</summary>
		private EntityFieldFactory()
		{
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ProductEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ProductFieldIndex fieldIndex)
		{
			IEntityField2 fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductFieldIndex.Id:
					fieldToReturn = new EntityField2("Id", "ProductEntity", typeof(System.Int32), TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), true, (int)fieldIndex, 0, 0, 10, false, true, false);
					break;
				case ProductFieldIndex.Name:
					fieldToReturn = new EntityField2("Name", "ProductEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), false, (int)fieldIndex, 255, 0, 0, false, false, true);
					break;
				case ProductFieldIndex.Description:
					fieldToReturn = new EntityField2("Description", "ProductEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), false, (int)fieldIndex, 536870911, 0, 0, false, false, true);
					break;
				case ProductFieldIndex.Price:
					fieldToReturn = new EntityField2("Price", "ProductEntity", typeof(System.Decimal), TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), false, (int)fieldIndex, 0, 0, 19, false, false, true);
					break;
				case ProductFieldIndex.PriceIncludesVat:
					fieldToReturn = new EntityField2("PriceIncludesVat", "ProductEntity", typeof(System.Boolean), TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), false, (int)fieldIndex, 2, 0, 0, false, false, false);
					break;
				case ProductFieldIndex.ImageName:
					fieldToReturn = new EntityField2("ImageName", "ProductEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), false, (int)fieldIndex, 255, 0, 0, false, false, true);
					break;
				case ProductFieldIndex.SectionId:
					fieldToReturn = new EntityField2("SectionId", "ProductEntity", typeof(System.Int32), TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), false, (int)fieldIndex, 0, 0, 10, true, false, true);
					break;
				case ProductFieldIndex.ExtraInformation:
					fieldToReturn = new EntityField2("ExtraInformation", "ProductEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), false, (int)fieldIndex, 536870911, 0, 0, false, false, true);
					break;
				case ProductFieldIndex.DeliveryPrice:
					fieldToReturn = new EntityField2("DeliveryPrice", "ProductEntity", typeof(System.Decimal), TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), false, (int)fieldIndex, 0, 0, 19, false, false, true);
					break;
				case ProductFieldIndex.PriceIsFrom:
					fieldToReturn = new EntityField2("PriceIsFrom", "ProductEntity", typeof(System.Boolean), TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), false, (int)fieldIndex, 2, 0, 0, false, false, false);
					break;

			}
			return fieldToReturn;
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ProductSectionEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ProductSectionFieldIndex fieldIndex)
		{
			IEntityField2 fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductSectionFieldIndex.Id:
					fieldToReturn = new EntityField2("Id", "ProductSectionEntity", typeof(System.Int32), TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), true, (int)fieldIndex, 0, 0, 10, false, true, false);
					break;
				case ProductSectionFieldIndex.ParentSectionId:
					fieldToReturn = new EntityField2("ParentSectionId", "ProductSectionEntity", typeof(System.Int32), TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), false, (int)fieldIndex, 0, 0, 10, true, false, true);
					break;
				case ProductSectionFieldIndex.Uri:
					fieldToReturn = new EntityField2("Uri", "ProductSectionEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), false, (int)fieldIndex, 255, 0, 0, false, false, true);
					break;
				case ProductSectionFieldIndex.Name:
					fieldToReturn = new EntityField2("Name", "ProductSectionEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), false, (int)fieldIndex, 100, 0, 0, false, false, true);
					break;

			}
			return fieldToReturn;
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RoleEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RoleFieldIndex fieldIndex)
		{
			IEntityField2 fieldToReturn = null;
			switch(fieldIndex)
			{
				case RoleFieldIndex.Name:
					fieldToReturn = new EntityField2("Name", "RoleEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), true, (int)fieldIndex, 100, 0, 0, false, false, true);
					break;

			}
			return fieldToReturn;
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the SpecialOfferEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(SpecialOfferFieldIndex fieldIndex)
		{
			IEntityField2 fieldToReturn = null;
			switch(fieldIndex)
			{
				case SpecialOfferFieldIndex.Id:
					fieldToReturn = new EntityField2("Id", "SpecialOfferEntity", typeof(System.Int32), TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), true, (int)fieldIndex, 0, 0, 10, false, true, false);
					break;
				case SpecialOfferFieldIndex.ProductId:
					fieldToReturn = new EntityField2("ProductId", "SpecialOfferEntity", typeof(System.Int32), TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), false, (int)fieldIndex, 0, 0, 10, true, false, true);
					break;
				case SpecialOfferFieldIndex.Number:
					fieldToReturn = new EntityField2("Number", "SpecialOfferEntity", typeof(System.Int16), TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), false, (int)fieldIndex, 0, 0, 5, false, false, true);
					break;

			}
			return fieldToReturn;
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the UserEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(UserFieldIndex fieldIndex)
		{
			IEntityField2 fieldToReturn = null;
			switch(fieldIndex)
			{
				case UserFieldIndex.UserId:
					fieldToReturn = new EntityField2("UserId", "UserEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), true, (int)fieldIndex, 50, 0, 0, false, false, true);
					break;
				case UserFieldIndex.FirstName:
					fieldToReturn = new EntityField2("FirstName", "UserEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), false, (int)fieldIndex, 50, 0, 0, false, false, true);
					break;
				case UserFieldIndex.LastName:
					fieldToReturn = new EntityField2("LastName", "UserEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), false, (int)fieldIndex, 50, 0, 0, false, false, true);
					break;
				case UserFieldIndex.Password:
					fieldToReturn = new EntityField2("Password", "UserEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), false, (int)fieldIndex, 536870911, 0, 0, false, false, true);
					break;

			}
			return fieldToReturn;
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the UserRoleLinkEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(UserRoleLinkFieldIndex fieldIndex)
		{
			IEntityField2 fieldToReturn = null;
			switch(fieldIndex)
			{
				case UserRoleLinkFieldIndex.UserId:
					fieldToReturn = new EntityField2("UserId", "UserRoleLinkEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), true, (int)fieldIndex, 50, 0, 0, true, false, true);
					break;
				case UserRoleLinkFieldIndex.RoleName:
					fieldToReturn = new EntityField2("RoleName", "UserRoleLinkEntity", typeof(System.String), TypeDefaultValue.GetDefaultValue(typeof(System.String)), true, (int)fieldIndex, 50, 0, 0, true, false, true);
					break;

			}
			return fieldToReturn;
		}


		#region Included Code

		#endregion
	}
}
