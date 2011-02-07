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
using SD.LLBLGen.Pro.ORMSupportClasses;
using DirectSports.BL.FactoryClasses;
using DirectSports.BL;

namespace DirectSports.BL.HelperClasses
{
	/// <summary>Field Creation Class for entity ProductEntity</summary>
	public partial class ProductFields
	{
		/// <summary>Creates a new ProductEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.Id);}
		}
		/// <summary>Creates a new ProductEntity.Name field instance</summary>
		public static EntityField2 Name
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.Name);}
		}
		/// <summary>Creates a new ProductEntity.Description field instance</summary>
		public static EntityField2 Description
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.Description);}
		}
		/// <summary>Creates a new ProductEntity.Price field instance</summary>
		public static EntityField2 Price
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.Price);}
		}
		/// <summary>Creates a new ProductEntity.PriceIncludesVat field instance</summary>
		public static EntityField2 PriceIncludesVat
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.PriceIncludesVat);}
		}
		/// <summary>Creates a new ProductEntity.ImageName field instance</summary>
		public static EntityField2 ImageName
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.ImageName);}
		}
		/// <summary>Creates a new ProductEntity.SectionId field instance</summary>
		public static EntityField2 SectionId
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.SectionId);}
		}
		/// <summary>Creates a new ProductEntity.ExtraInformation field instance</summary>
		public static EntityField2 ExtraInformation
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.ExtraInformation);}
		}
		/// <summary>Creates a new ProductEntity.DeliveryPrice field instance</summary>
		public static EntityField2 DeliveryPrice
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.DeliveryPrice);}
		}
		/// <summary>Creates a new ProductEntity.PriceIsFrom field instance</summary>
		public static EntityField2 PriceIsFrom
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductFieldIndex.PriceIsFrom);}
		}
	}

	/// <summary>Field Creation Class for entity ProductSectionEntity</summary>
	public partial class ProductSectionFields
	{
		/// <summary>Creates a new ProductSectionEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductSectionFieldIndex.Id);}
		}
		/// <summary>Creates a new ProductSectionEntity.ParentSectionId field instance</summary>
		public static EntityField2 ParentSectionId
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductSectionFieldIndex.ParentSectionId);}
		}
		/// <summary>Creates a new ProductSectionEntity.Uri field instance</summary>
		public static EntityField2 Uri
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductSectionFieldIndex.Uri);}
		}
		/// <summary>Creates a new ProductSectionEntity.Name field instance</summary>
		public static EntityField2 Name
		{
			get { return (EntityField2)EntityFieldFactory.Create(ProductSectionFieldIndex.Name);}
		}
	}

	/// <summary>Field Creation Class for entity RoleEntity</summary>
	public partial class RoleFields
	{
		/// <summary>Creates a new RoleEntity.Name field instance</summary>
		public static EntityField2 Name
		{
			get { return (EntityField2)EntityFieldFactory.Create(RoleFieldIndex.Name);}
		}
	}

	/// <summary>Field Creation Class for entity SpecialOfferEntity</summary>
	public partial class SpecialOfferFields
	{
		/// <summary>Creates a new SpecialOfferEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecialOfferFieldIndex.Id);}
		}
		/// <summary>Creates a new SpecialOfferEntity.ProductId field instance</summary>
		public static EntityField2 ProductId
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecialOfferFieldIndex.ProductId);}
		}
		/// <summary>Creates a new SpecialOfferEntity.Number field instance</summary>
		public static EntityField2 Number
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecialOfferFieldIndex.Number);}
		}
	}

	/// <summary>Field Creation Class for entity UserEntity</summary>
	public partial class UserFields
	{
		/// <summary>Creates a new UserEntity.UserId field instance</summary>
		public static EntityField2 UserId
		{
			get { return (EntityField2)EntityFieldFactory.Create(UserFieldIndex.UserId);}
		}
		/// <summary>Creates a new UserEntity.FirstName field instance</summary>
		public static EntityField2 FirstName
		{
			get { return (EntityField2)EntityFieldFactory.Create(UserFieldIndex.FirstName);}
		}
		/// <summary>Creates a new UserEntity.LastName field instance</summary>
		public static EntityField2 LastName
		{
			get { return (EntityField2)EntityFieldFactory.Create(UserFieldIndex.LastName);}
		}
		/// <summary>Creates a new UserEntity.Password field instance</summary>
		public static EntityField2 Password
		{
			get { return (EntityField2)EntityFieldFactory.Create(UserFieldIndex.Password);}
		}
	}

	/// <summary>Field Creation Class for entity UserRoleLinkEntity</summary>
	public partial class UserRoleLinkFields
	{
		/// <summary>Creates a new UserRoleLinkEntity.UserId field instance</summary>
		public static EntityField2 UserId
		{
			get { return (EntityField2)EntityFieldFactory.Create(UserRoleLinkFieldIndex.UserId);}
		}
		/// <summary>Creates a new UserRoleLinkEntity.RoleName field instance</summary>
		public static EntityField2 RoleName
		{
			get { return (EntityField2)EntityFieldFactory.Create(UserRoleLinkFieldIndex.RoleName);}
		}
	}
	

}