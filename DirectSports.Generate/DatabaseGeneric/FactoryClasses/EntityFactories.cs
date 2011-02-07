///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: 06 January 2008 14:12:32
// Code is generated using templates: C# template set for MS Access (2000/XP/2003) (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.111705
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using DirectSports.BL.EntityClasses;
using DirectSports.BL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	
	/// <summary>Factory to create new, empty ProductEntity objects.</summary>
	[Serializable]
	public partial class ProductEntityFactory : IEntityFactory2
	{
		/// <summary>CTor</summary>
		public ProductEntityFactory()
		{
		}

		/// <summary>Creates a new, empty ProductEntity object.</summary>
		/// <returns>A new, empty ProductEntity object.</returns>
		public virtual IEntity2 Create()
		{
			IEntity2 toReturn = new ProductEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProduct
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new ProductEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public virtual IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new ProductEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create. This method is used by internal code to create the fields object to store fetched data.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.ProductEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields2 CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory2 GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public virtual IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, negate);
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ProductEntity"; }
		}

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ProductSectionEntity objects.</summary>
	[Serializable]
	public partial class ProductSectionEntityFactory : IEntityFactory2
	{
		/// <summary>CTor</summary>
		public ProductSectionEntityFactory()
		{
		}

		/// <summary>Creates a new, empty ProductSectionEntity object.</summary>
		/// <returns>A new, empty ProductSectionEntity object.</returns>
		public virtual IEntity2 Create()
		{
			IEntity2 toReturn = new ProductSectionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductSection
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new ProductSectionEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public virtual IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new ProductSectionEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductSectionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create. This method is used by internal code to create the fields object to store fetched data.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.ProductSectionEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields2 CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory2 GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public virtual IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, negate);
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ProductSectionEntity"; }
		}

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ProductVariationEntity objects.</summary>
	[Serializable]
	public partial class ProductVariationEntityFactory : IEntityFactory2
	{
		/// <summary>CTor</summary>
		public ProductVariationEntityFactory()
		{
		}

		/// <summary>Creates a new, empty ProductVariationEntity object.</summary>
		/// <returns>A new, empty ProductVariationEntity object.</returns>
		public virtual IEntity2 Create()
		{
			IEntity2 toReturn = new ProductVariationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductVariation
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new ProductVariationEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public virtual IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new ProductVariationEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductVariationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create. This method is used by internal code to create the fields object to store fetched data.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.ProductVariationEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields2 CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory2 GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public virtual IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, negate);
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ProductVariationEntity"; }
		}

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RoleEntity objects.</summary>
	[Serializable]
	public partial class RoleEntityFactory : IEntityFactory2
	{
		/// <summary>CTor</summary>
		public RoleEntityFactory()
		{
		}

		/// <summary>Creates a new, empty RoleEntity object.</summary>
		/// <returns>A new, empty RoleEntity object.</returns>
		public virtual IEntity2 Create()
		{
			IEntity2 toReturn = new RoleEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRole
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new RoleEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public virtual IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new RoleEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRoleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create. This method is used by internal code to create the fields object to store fetched data.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.RoleEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields2 CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory2 GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public virtual IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, negate);
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "RoleEntity"; }
		}

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty SpecialOfferEntity objects.</summary>
	[Serializable]
	public partial class SpecialOfferEntityFactory : IEntityFactory2
	{
		/// <summary>CTor</summary>
		public SpecialOfferEntityFactory()
		{
		}

		/// <summary>Creates a new, empty SpecialOfferEntity object.</summary>
		/// <returns>A new, empty SpecialOfferEntity object.</returns>
		public virtual IEntity2 Create()
		{
			IEntity2 toReturn = new SpecialOfferEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOffer
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SpecialOfferEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public virtual IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new SpecialOfferEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOfferUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create. This method is used by internal code to create the fields object to store fetched data.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.SpecialOfferEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields2 CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory2 GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public virtual IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, negate);
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "SpecialOfferEntity"; }
		}

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty UserEntity objects.</summary>
	[Serializable]
	public partial class UserEntityFactory : IEntityFactory2
	{
		/// <summary>CTor</summary>
		public UserEntityFactory()
		{
		}

		/// <summary>Creates a new, empty UserEntity object.</summary>
		/// <returns>A new, empty UserEntity object.</returns>
		public virtual IEntity2 Create()
		{
			IEntity2 toReturn = new UserEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUser
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new UserEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public virtual IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new UserEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create. This method is used by internal code to create the fields object to store fetched data.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.UserEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields2 CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory2 GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public virtual IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, negate);
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "UserEntity"; }
		}

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty UserRoleLinkEntity objects.</summary>
	[Serializable]
	public partial class UserRoleLinkEntityFactory : IEntityFactory2
	{
		/// <summary>CTor</summary>
		public UserRoleLinkEntityFactory()
		{
		}

		/// <summary>Creates a new, empty UserRoleLinkEntity object.</summary>
		/// <returns>A new, empty UserRoleLinkEntity object.</returns>
		public virtual IEntity2 Create()
		{
			IEntity2 toReturn = new UserRoleLinkEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserRoleLink
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new UserRoleLinkEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity2 instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public virtual IEntity2 Create(IEntityFields2 fields)
		{
			IEntity2 toReturn = new UserRoleLinkEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserRoleLinkUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create. This method is used by internal code to create the fields object to store fetched data.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.UserRoleLinkEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields2 CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory2 GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public virtual IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, negate);
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "UserRoleLinkEntity"; }
		}

		#region Included Code

		#endregion
	}
	

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case DirectSports.BL.EntityType.ProductEntity:
					factoryToUse = new ProductEntityFactory();
					break;
				case DirectSports.BL.EntityType.ProductSectionEntity:
					factoryToUse = new ProductSectionEntityFactory();
					break;
				case DirectSports.BL.EntityType.ProductVariationEntity:
					factoryToUse = new ProductVariationEntityFactory();
					break;
				case DirectSports.BL.EntityType.RoleEntity:
					factoryToUse = new RoleEntityFactory();
					break;
				case DirectSports.BL.EntityType.SpecialOfferEntity:
					factoryToUse = new SpecialOfferEntityFactory();
					break;
				case DirectSports.BL.EntityType.UserEntity:
					factoryToUse = new UserEntityFactory();
					break;
				case DirectSports.BL.EntityType.UserRoleLinkEntity:
					factoryToUse = new UserRoleLinkEntityFactory();
					break;
			}
			return factoryToUse.Create();
		}		
	}
}
