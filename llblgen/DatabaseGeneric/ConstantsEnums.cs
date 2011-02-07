///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: 05 September 2006 21:59:50
// Code is generated using templates: C# template set for MS Access (2000/XP/2003) (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.111705
//////////////////////////////////////////////////////////////
using System;

namespace DirectSports.BL
{

	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Product.
	/// </summary>
	public enum ProductFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>Description. </summary>
		Description,
		///<summary>Price. </summary>
		Price,
		///<summary>PriceIncludesVat. </summary>
		PriceIncludesVat,
		///<summary>ImageName. </summary>
		ImageName,
		///<summary>SectionId. </summary>
		SectionId,
		///<summary>ExtraInformation. </summary>
		ExtraInformation,
		///<summary>DeliveryPrice. </summary>
		DeliveryPrice,
		///<summary>PriceIsFrom. </summary>
		PriceIsFrom,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductSection.
	/// </summary>
	public enum ProductSectionFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>ParentSectionId. </summary>
		ParentSectionId,
		///<summary>Uri. </summary>
		Uri,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Role.
	/// </summary>
	public enum RoleFieldIndex:int
	{
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SpecialOffer.
	/// </summary>
	public enum SpecialOfferFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Number. </summary>
		Number,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: User.
	/// </summary>
	public enum UserFieldIndex:int
	{
		///<summary>UserId. </summary>
		UserId,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>LastName. </summary>
		LastName,
		///<summary>Password. </summary>
		Password,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UserRoleLink.
	/// </summary>
	public enum UserRoleLinkFieldIndex:int
	{
		///<summary>UserId. </summary>
		UserId,
		///<summary>RoleName. </summary>
		RoleName,
		/// <summary></summary>
		AmountOfFields
	}





	/// <summary>
	/// Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.
	/// </summary>
	public enum EntityType:int
	{
		///<summary>Product</summary>
		ProductEntity,
		///<summary>ProductSection</summary>
		ProductSectionEntity,
		///<summary>Role</summary>
		RoleEntity,
		///<summary>SpecialOffer</summary>
		SpecialOfferEntity,
		///<summary>User</summary>
		UserEntity,
		///<summary>UserRoleLink</summary>
		UserRoleLinkEntity
	}




	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	#endregion

	#region Included code

	#endregion
}


