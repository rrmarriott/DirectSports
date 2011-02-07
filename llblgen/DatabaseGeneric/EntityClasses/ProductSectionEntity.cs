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
	/// Entity class which represents the entity 'ProductSection'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ProductSectionEntity : EntityBase2, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection _product;
		private EntityCollection _productSection_;

		private ProductSectionEntity _productSection;

		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region DataBinding Change Event Handler Declarations
		/// <summary> Event which is thrown when Id changes value. Databinding related.</summary>
		public event EventHandler IdChanged;
		/// <summary> Event which is thrown when ParentSectionId changes value. Databinding related.</summary>
		public event EventHandler ParentSectionIdChanged;
		/// <summary> Event which is thrown when Uri changes value. Databinding related.</summary>
		public event EventHandler UriChanged;
		/// <summary> Event which is thrown when Name changes value. Databinding related.</summary>
		public event EventHandler NameChanged;

		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductSectionEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public ProductSectionEntity():base("ProductSectionEntity")
		{
			InitClassEmpty(CreateValidator(), CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductSectionEntity(IEntityFields2 fields):base("ProductSectionEntity")
		{
			InitClassEmpty(CreateValidator(), fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductSectionEntity</param>
		public ProductSectionEntity(ProductSectionValidator validator):base("ProductSectionEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for ProductSection which data should be fetched into this ProductSection object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductSectionEntity(System.Int32 id):base("ProductSectionEntity")
		{
			InitClassEmpty(CreateValidator(), CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for ProductSection which data should be fetched into this ProductSection object</param>
		/// <param name="validator">The custom validator object for this ProductSectionEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductSectionEntity(System.Int32 id, ProductSectionValidator validator):base("ProductSectionEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ProductSectionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_product = (EntityCollection)info.GetValue("_product", typeof(EntityCollection));
			_productSection_ = (EntityCollection)info.GetValue("_productSection_", typeof(EntityCollection));

			_productSection = (ProductSectionEntity)info.GetValue("_productSection", typeof(ProductSectionEntity));
			if(_productSection!=null)
			{
				_productSection.AfterSave+=new EventHandler(OnEntityAfterSave);
			}

			
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
			if(toReturn && Enum.IsDefined(typeof(ProductSectionFieldIndex), fieldIndex))
			{
				switch((ProductSectionFieldIndex)fieldIndex)
				{
					case ProductSectionFieldIndex.ParentSectionId:
						DecoupleEventsProductSection();
						_productSection = null;
						break;
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn);
				switch((ProductSectionFieldIndex)fieldIndex)
				{
					case ProductSectionFieldIndex.Id:
						OnIdChanged();
						break;
					case ProductSectionFieldIndex.ParentSectionId:
						OnParentSectionIdChanged();
						break;
					case ProductSectionFieldIndex.Uri:
						OnUriChanged();
						break;
					case ProductSectionFieldIndex.Name:
						OnNameChanged();
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
				case "ProductSection":
					this.ProductSection = (ProductSectionEntity)entity;
					break;
				case "Product":
					this.Product.Add((ProductEntity)entity);
					break;
				case "ProductSection_":
					this.ProductSection_.Add((ProductSectionEntity)entity);
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
				case "ProductSection":
					SetupSyncProductSection(relatedEntity);
					break;
				case "Product":
					this.Product.Add(relatedEntity);
					break;
				case "ProductSection_":
					this.ProductSection_.Add(relatedEntity);
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
				case "ProductSection":
					DesetupSyncProductSection(false);
					break;
				case "Product":
					this.Product.Remove(relatedEntity);
					break;
				case "ProductSection_":
					this.ProductSection_.Remove(relatedEntity);
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
			if(_productSection!=null)
			{
				toReturn.Add(_productSection);
			}

			return toReturn;
		}
		
		/// <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override ArrayList GetMemberEntityCollections()
		{
			ArrayList toReturn = new ArrayList();
			toReturn.Add(this.Product);
			toReturn.Add(this.ProductSection_);

			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_product", _product);
			info.AddValue("_productSection_", _productSection_);

			info.AddValue("_productSection", _productSection);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ProductSectionFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ProductSectionFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}
		
		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("ProductSectionEntity", ((DirectSports.BL.EntityType)typeOfEntity).ToString());
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Product' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ProductFieldIndex.SectionId), null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ProductSection' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductSection_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ProductSectionFieldIndex.ParentSectionId), null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}


		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'ProductSection' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductSection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ProductSectionFieldIndex.Id), null, ComparisonOperator.Equal, this.ParentSectionId));
			return bucket;
		}

	
		#region Data binding change event raising methods

		/// <summary> Event thrower for the IdChanged event, which is thrown when Id changes value. Databinding related.</summary>
		protected virtual void OnIdChanged()
		{
			if(IdChanged!=null)
			{
				IdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ParentSectionIdChanged event, which is thrown when ParentSectionId changes value. Databinding related.</summary>
		protected virtual void OnParentSectionIdChanged()
		{
			if(ParentSectionIdChanged!=null)
			{
				ParentSectionIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the UriChanged event, which is thrown when Uri changes value. Databinding related.</summary>
		protected virtual void OnUriChanged()
		{
			if(UriChanged!=null)
			{
				UriChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the NameChanged event, which is thrown when Name changes value. Databinding related.</summary>
		protected virtual void OnNameChanged()
		{
			if(NameChanged!=null)
			{
				NameChanged(this, new EventArgs());
			}
		}

		#endregion

		/// <summary> A method which calls all OnFieldnameChanged methods to signal that the field has been changed to bound controls. This is required after a RollbackFields() call.</summary>
		protected override void FlagAllFieldsAsChanged()
		{
			OnIdChanged();
			OnParentSectionIdChanged();
			OnUriChanged();
			OnNameChanged();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.ProductSectionEntity);
		}

		/// <summary>Creates field validator object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IValidator CreateValidator()
		{
			return new ProductSectionValidator();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new ProductSectionEntityFactory();
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_product!=null)
			{
				_product.ActiveContext = base.ActiveContext;
			}
			if(_productSection_!=null)
			{
				_productSection_.ActiveContext = base.ActiveContext;
			}

			if(_productSection!=null)
			{
				_productSection.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_product = null;
			_productSection_ = null;

			_productSection = null;

			
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

			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ParentSectionId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Uri", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _productSection</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncProductSection(bool signalRelatedEntity)
		{
			if(_productSection != null)
			{

				_productSection.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("ProductSection", _productSection, ProductSectionEntity.Relations.ProductSectionEntityUsingParentSectionId);
				if(signalRelatedEntity)
				{
					_productSection.UnsetRelatedEntity(this, "ProductSection_");
				}
				SetNewFieldValue((int)ProductSectionFieldIndex.ParentSectionId, null);
				_productSection = null;
			}
		}
		
		/// <summary> Decouples events from member _productSection</summary>
		private void DecoupleEventsProductSection()
		{
			if(_productSection != null)
			{

				_productSection.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("ProductSection", _productSection, ProductSectionEntity.Relations.ProductSectionEntityUsingParentSectionId);
			}
		}
		
		/// <summary> setups the sync logic for member _productSection</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductSection(IEntity2 relatedEntity)
		{
			DesetupSyncProductSection(true);
			if(relatedEntity!=null)
			{
				_productSection = (ProductSectionEntity)relatedEntity;
				_productSection.ActiveContext = base.ActiveContext;
				_productSection.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("ProductSection", _productSection, ProductSectionEntity.Relations.ProductSectionEntityUsingParentSectionId);

			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProductSectionEntity</param>
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
		public  static ProductSectionRelations Relations
		{
			get	{ return new ProductSectionRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection(new ProductEntityFactory()),
					ProductSectionEntity.Relations.ProductEntityUsingSectionId, 
					(int)DirectSports.BL.EntityType.ProductSectionEntity, (int)DirectSports.BL.EntityType.ProductEntity, 0, null, null, null, null, "Product", RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductSection' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductSection_
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection(new ProductSectionEntityFactory()),
					ProductSectionEntity.Relations.ProductSectionEntityUsingParentSectionId, 
					(int)DirectSports.BL.EntityType.ProductSectionEntity, (int)DirectSports.BL.EntityType.ProductSectionEntity, 0, null, null, null, null, "ProductSection_", RelationType.OneToMany);
			}
		}


		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductSection' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductSection
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(new ProductSectionEntityFactory()),
					ProductSectionEntity.Relations.ProductSectionEntityUsingIdParentSectionId, 
					(int)DirectSports.BL.EntityType.ProductSectionEntity, (int)DirectSports.BL.EntityType.ProductSectionEntity, 0, null, null, null, null, "ProductSection", RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return ProductSectionEntity.CustomProperties;}
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
			get { return ProductSectionEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity ProductSection<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ProductSection"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductSectionFieldIndex.Id);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductSectionFieldIndex.Id, value); }
		}

		/// <summary> The ParentSectionId property of the Entity ProductSection<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ProductSection"."ParentSectionId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Int32 ParentSectionId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductSectionFieldIndex.ParentSectionId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductSectionFieldIndex.ParentSectionId, value); }
		}

		/// <summary> The Uri property of the Entity ProductSection<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ProductSection"."Uri"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Uri
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductSectionFieldIndex.Uri);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductSectionFieldIndex.Uri, value); }
		}

		/// <summary> The Name property of the Entity ProductSection<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ProductSection"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductSectionFieldIndex.Name);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductSectionFieldIndex.Name, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection Product
		{
			get
			{
				if(_product==null)
				{
					_product = new EntityCollection(new ProductEntityFactory());
					_product.SetContainingEntityInfo(this, "ProductSection");
				}
				return _product;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductSectionEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ProductSectionEntity))]
		public virtual EntityCollection ProductSection_
		{
			get
			{
				if(_productSection_==null)
				{
					_productSection_ = new EntityCollection(new ProductSectionEntityFactory());
					_productSection_.SetContainingEntityInfo(this, "ProductSection");
				}
				return _productSection_;
			}
		}


		/// <summary> Gets / sets related entity of type 'ProductSectionEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual ProductSectionEntity ProductSection
		{
			get
			{
				return _productSection;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductSection(value);
				}
				else
				{
					if(value==null)
					{
						if(_productSection != null)
						{
							_productSection.UnsetRelatedEntity(this, "ProductSection_");
						}
					}
					else
					{
						((IEntity2)value).SetRelatedEntity(this, "ProductSection_");
					}
				}
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
			get { return (int)DirectSports.BL.EntityType.ProductSectionEntity; }
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
