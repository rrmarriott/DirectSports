﻿///////////////////////////////////////////////////////////////
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
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using DirectSports.BL;
using DirectSports.BL.HelperClasses;
using DirectSports.BL.FactoryClasses;
using DirectSports.BL.RelationClasses;
using DirectSports.BL.ValidatorClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'User'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class UserEntity : EntityBase2, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection _userRoleLink;
		private EntityCollection _roleCollectionViaUserRoleLink;


		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region DataBinding Change Event Handler Declarations
		/// <summary> Event which is thrown when UserId changes value. Databinding related.</summary>
		public event EventHandler UserIdChanged;
		/// <summary> Event which is thrown when FirstName changes value. Databinding related.</summary>
		public event EventHandler FirstNameChanged;
		/// <summary> Event which is thrown when LastName changes value. Databinding related.</summary>
		public event EventHandler LastNameChanged;
		/// <summary> Event which is thrown when Password changes value. Databinding related.</summary>
		public event EventHandler PasswordChanged;

		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UserEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public UserEntity():base("UserEntity")
		{
			InitClassEmpty(CreateValidator(), CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UserEntity(IEntityFields2 fields):base("UserEntity")
		{
			InitClassEmpty(CreateValidator(), fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(UserValidator validator):base("UserEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UserEntity(System.String userId):base("UserEntity")
		{
			InitClassEmpty(CreateValidator(), CreateFields());
			this.UserId = userId;
		}

		/// <summary> CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UserEntity(System.String userId, UserValidator validator):base("UserEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.UserId = userId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected UserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_userRoleLink = (EntityCollection)info.GetValue("_userRoleLink", typeof(EntityCollection));
			_roleCollectionViaUserRoleLink = (EntityCollection)info.GetValue("_roleCollectionViaUserRoleLink", typeof(EntityCollection));


			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		/// <summary>Sets the field on index fieldIndex to the new value value. Marks also the fields object as dirty.</summary>
		/// <param name="fieldIndex">Index of field to set the new value of</param>
		/// <param name="value">Value to set</param>
		/// <returns>true if the value is actually set, false otherwise.</returns>
		/// <remarks>Dereferences a related object in an 1:1/m:1 relation if the field is an FK field and responsible for the reference of that particular related object.</remarks>
		/// <exception cref="ArgumentOutOfRangeException">When fieldIndex is smaller than 0 or bigger than the number of fields in the fields collection.</exception>
		public override bool SetNewFieldValue(int fieldIndex, object value)
		{
			bool toReturn = base.SetNewFieldValue (fieldIndex, value, false);
			if(toReturn && Enum.IsDefined(typeof(UserFieldIndex), fieldIndex))
			{
				switch((UserFieldIndex)fieldIndex)
				{
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn);
				switch((UserFieldIndex)fieldIndex)
				{
					case UserFieldIndex.UserId:
						OnUserIdChanged();
						break;
					case UserFieldIndex.FirstName:
						OnFirstNameChanged();
						break;
					case UserFieldIndex.LastName:
						OnLastNameChanged();
						break;
					case UserFieldIndex.Password:
						OnPasswordChanged();
						break;
					default:
						break;
				}
			}
			return toReturn;
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{

				case "UserRoleLink":
					this.UserRoleLink.Add((UserRoleLinkEntity)entity);
					break;
				case "RoleCollectionViaUserRoleLink":
					this.RoleCollectionViaUserRoleLink.IsReadOnly = false;
					this.RoleCollectionViaUserRoleLink.Add((RoleEntity)entity);
					this.RoleCollectionViaUserRoleLink.IsReadOnly = true;
					break;

				default:
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{

				case "UserRoleLink":
					this.UserRoleLink.Add(relatedEntity);
					break;

				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{

				case "UserRoleLink":
					this.UserRoleLink.Remove(relatedEntity);
					break;

				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override IEntityCollection2 GetDependingRelatedEntities()
		{
			EntityCollection toReturn = new EntityCollection();

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override IEntityCollection2 GetDependentRelatedEntities()
		{
			EntityCollection toReturn = new EntityCollection();


			return toReturn;
		}
		
		/// <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override ArrayList GetMemberEntityCollections()
		{
			ArrayList toReturn = new ArrayList();
			toReturn.Add(this.UserRoleLink);

			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_userRoleLink", _userRoleLink);
			info.AddValue("_roleCollectionViaUserRoleLink", _roleCollectionViaUserRoleLink);


			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(UserFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(UserFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}
		
		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("UserEntity", ((DirectSports.BL.EntityType)typeOfEntity).ToString());
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'UserRoleLink' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserRoleLink()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(UserRoleLinkFieldIndex.UserId), null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Role' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRoleCollectionViaUserRoleLink()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.Add(UserEntity.Relations.UserRoleLinkEntityUsingUserId, "UserRoleLink_");
			bucket.Relations.Add(UserRoleLinkEntity.Relations.RoleEntityUsingRoleName, "UserRoleLink_", string.Empty, JoinHint.None);
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(UserFieldIndex.UserId), null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}


	
		#region Data binding change event raising methods

		/// <summary> Event thrower for the UserIdChanged event, which is thrown when UserId changes value. Databinding related.</summary>
		protected virtual void OnUserIdChanged()
		{
			if(UserIdChanged!=null)
			{
				UserIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the FirstNameChanged event, which is thrown when FirstName changes value. Databinding related.</summary>
		protected virtual void OnFirstNameChanged()
		{
			if(FirstNameChanged!=null)
			{
				FirstNameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the LastNameChanged event, which is thrown when LastName changes value. Databinding related.</summary>
		protected virtual void OnLastNameChanged()
		{
			if(LastNameChanged!=null)
			{
				LastNameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the PasswordChanged event, which is thrown when Password changes value. Databinding related.</summary>
		protected virtual void OnPasswordChanged()
		{
			if(PasswordChanged!=null)
			{
				PasswordChanged(this, new EventArgs());
			}
		}

		#endregion

		/// <summary> A method which calls all OnFieldnameChanged methods to signal that the field has been changed to bound controls. This is required after a RollbackFields() call.</summary>
		protected override void FlagAllFieldsAsChanged()
		{
			OnUserIdChanged();
			OnFirstNameChanged();
			OnLastNameChanged();
			OnPasswordChanged();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.UserEntity);
		}

		/// <summary>Creates field validator object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IValidator CreateValidator()
		{
			return new UserValidator();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new UserEntityFactory();
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_userRoleLink!=null)
			{
				_userRoleLink.ActiveContext = base.ActiveContext;
			}
			if(_roleCollectionViaUserRoleLink!=null)
			{
				_roleCollectionViaUserRoleLink.ActiveContext = base.ActiveContext;
			}


		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_userRoleLink = null;
			_roleCollectionViaUserRoleLink = null;


			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();

			Hashtable fieldHashtable = null;
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Password", fieldHashtable);
		}
		#endregion



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this UserEntity</param>
		/// <param name="fields">Fields of this entity</param>
		protected virtual void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			InitClassMembers();
			base.Fields = fields;
			base.IsNew=true;
			base.Validator = validator;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static UserRelations Relations
		{
			get	{ return new UserRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserRoleLink' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserRoleLink
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection(new UserRoleLinkEntityFactory()),
					UserEntity.Relations.UserRoleLinkEntityUsingUserId, 
					(int)DirectSports.BL.EntityType.UserEntity, (int)DirectSports.BL.EntityType.UserRoleLinkEntity, 0, null, null, null, null, "UserRoleLink", RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Role' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRoleCollectionViaUserRoleLink
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				IEntityRelation intermediateRelation = UserEntity.Relations.UserRoleLinkEntityUsingUserId;
				intermediateRelation.SetAliases(string.Empty, "UserRoleLink_");
				relations.Add(UserEntity.Relations.UserRoleLinkEntityUsingUserId, "UserRoleLink_");
				relations.Add(UserRoleLinkEntity.Relations.RoleEntityUsingRoleName, "UserRoleLink_", string.Empty, JoinHint.None);
				return new PrefetchPathElement2(new EntityCollection(new RoleEntityFactory()),	intermediateRelation,
					(int)DirectSports.BL.EntityType.UserEntity, (int)DirectSports.BL.EntityType.RoleEntity, 0, null, null, relations, null, "RoleCollectionViaUserRoleLink", RelationType.ManyToMany);
			}
		}



		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return UserEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return UserEntity.FieldsCustomProperties;}
		}

		/// <summary> The UserId property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, true, false</remarks>
		public virtual System.String UserId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserFieldIndex.UserId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)UserFieldIndex.UserId, value); }
		}

		/// <summary> The FirstName property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String FirstName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserFieldIndex.FirstName);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)UserFieldIndex.FirstName, value); }
		}

		/// <summary> The LastName property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String LastName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserFieldIndex.LastName);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)UserFieldIndex.LastName, value); }
		}

		/// <summary> The Password property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): LongVarWChar, 0, 0, 536870911<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Password
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserFieldIndex.Password);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)UserFieldIndex.Password, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserRoleLinkEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserRoleLinkEntity))]
		public virtual EntityCollection UserRoleLink
		{
			get
			{
				if(_userRoleLink==null)
				{
					_userRoleLink = new EntityCollection(new UserRoleLinkEntityFactory());
					_userRoleLink.SetContainingEntityInfo(this, "User");
				}
				return _userRoleLink;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RoleEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RoleEntity))]
		public virtual EntityCollection RoleCollectionViaUserRoleLink
		{
			get
			{
				if(_roleCollectionViaUserRoleLink==null)
				{
					_roleCollectionViaUserRoleLink = new EntityCollection(new RoleEntityFactory());
					_roleCollectionViaUserRoleLink.IsReadOnly=true;
				}
				return _roleCollectionViaUserRoleLink;
			}
		}


	
		
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)DirectSports.BL.EntityType.UserEntity; }
		}
		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
