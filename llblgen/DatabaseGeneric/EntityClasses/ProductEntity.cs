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
	/// Entity class which represents the entity 'Product'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ProductEntity : EntityBase2, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection _specialOffer;

		private ProductSectionEntity _productSection;

		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region DataBinding Change Event Handler Declarations
		/// <summary> Event which is thrown when Id changes value. Databinding related.</summary>
		public event EventHandler IdChanged;
		/// <summary> Event which is thrown when Name changes value. Databinding related.</summary>
		public event EventHandler NameChanged;
		/// <summary> Event which is thrown when Description changes value. Databinding related.</summary>
		public event EventHandler DescriptionChanged;
		/// <summary> Event which is thrown when Price changes value. Databinding related.</summary>
		public event EventHandler PriceChanged;
		/// <summary> Event which is thrown when PriceIncludesVat changes value. Databinding related.</summary>
		public event EventHandler PriceIncludesVatChanged;
		/// <summary> Event which is thrown when ImageName changes value. Databinding related.</summary>
		public event EventHandler ImageNameChanged;
		/// <summary> Event which is thrown when SectionId changes value. Databinding related.</summary>
		public event EventHandler SectionIdChanged;
		/// <summary> Event which is thrown when ExtraInformation changes value. Databinding related.</summary>
		public event EventHandler ExtraInformationChanged;
		/// <summary> Event which is thrown when DeliveryPrice changes value. Databinding related.</summary>
		public event EventHandler DeliveryPriceChanged;
		/// <summary> Event which is thrown when PriceIsFrom changes value. Databinding related.</summary>
		public event EventHandler PriceIsFromChanged;

		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public ProductEntity():base("ProductEntity")
		{
			InitClassEmpty(CreateValidator(), CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductEntity(IEntityFields2 fields):base("ProductEntity")
		{
			InitClassEmpty(CreateValidator(), fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(ProductValidator validator):base("ProductEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductEntity(System.Int32 id):base("ProductEntity")
		{
			InitClassEmpty(CreateValidator(), CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductEntity(System.Int32 id, ProductValidator validator):base("ProductEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_specialOffer = (EntityCollection)info.GetValue("_specialOffer", typeof(EntityCollection));

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
			if(toReturn && Enum.IsDefined(typeof(ProductFieldIndex), fieldIndex))
			{
				switch((ProductFieldIndex)fieldIndex)
				{
					case ProductFieldIndex.SectionId:
						DecoupleEventsProductSection();
						_productSection = null;
						break;
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn);
				switch((ProductFieldIndex)fieldIndex)
				{
					case ProductFieldIndex.Id:
						OnIdChanged();
						break;
					case ProductFieldIndex.Name:
						OnNameChanged();
						break;
					case ProductFieldIndex.Description:
						OnDescriptionChanged();
						break;
					case ProductFieldIndex.Price:
						OnPriceChanged();
						break;
					case ProductFieldIndex.PriceIncludesVat:
						OnPriceIncludesVatChanged();
						break;
					case ProductFieldIndex.ImageName:
						OnImageNameChanged();
						break;
					case ProductFieldIndex.SectionId:
						OnSectionIdChanged();
						break;
					case ProductFieldIndex.ExtraInformation:
						OnExtraInformationChanged();
						break;
					case ProductFieldIndex.DeliveryPrice:
						OnDeliveryPriceChanged();
						break;
					case ProductFieldIndex.PriceIsFrom:
						OnPriceIsFromChanged();
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
				case "SpecialOffer":
					this.SpecialOffer.Add((SpecialOfferEntity)entity);
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
				case "SpecialOffer":
					this.SpecialOffer.Add(relatedEntity);
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
				case "SpecialOffer":
					this.SpecialOffer.Remove(relatedEntity);
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
			toReturn.Add(this.SpecialOffer);

			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_specialOffer", _specialOffer);

			info.AddValue("_productSection", _productSection);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ProductFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ProductFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}
		
		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("ProductEntity", ((DirectSports.BL.EntityType)typeOfEntity).ToString());
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'SpecialOffer' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSpecialOffer()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(SpecialOfferFieldIndex.ProductId), null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}


		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'ProductSection' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductSection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ProductSectionFieldIndex.Id), null, ComparisonOperator.Equal, this.SectionId));
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

		/// <summary> Event thrower for the NameChanged event, which is thrown when Name changes value. Databinding related.</summary>
		protected virtual void OnNameChanged()
		{
			if(NameChanged!=null)
			{
				NameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the DescriptionChanged event, which is thrown when Description changes value. Databinding related.</summary>
		protected virtual void OnDescriptionChanged()
		{
			if(DescriptionChanged!=null)
			{
				DescriptionChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the PriceChanged event, which is thrown when Price changes value. Databinding related.</summary>
		protected virtual void OnPriceChanged()
		{
			if(PriceChanged!=null)
			{
				PriceChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the PriceIncludesVatChanged event, which is thrown when PriceIncludesVat changes value. Databinding related.</summary>
		protected virtual void OnPriceIncludesVatChanged()
		{
			if(PriceIncludesVatChanged!=null)
			{
				PriceIncludesVatChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ImageNameChanged event, which is thrown when ImageName changes value. Databinding related.</summary>
		protected virtual void OnImageNameChanged()
		{
			if(ImageNameChanged!=null)
			{
				ImageNameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SectionIdChanged event, which is thrown when SectionId changes value. Databinding related.</summary>
		protected virtual void OnSectionIdChanged()
		{
			if(SectionIdChanged!=null)
			{
				SectionIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ExtraInformationChanged event, which is thrown when ExtraInformation changes value. Databinding related.</summary>
		protected virtual void OnExtraInformationChanged()
		{
			if(ExtraInformationChanged!=null)
			{
				ExtraInformationChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the DeliveryPriceChanged event, which is thrown when DeliveryPrice changes value. Databinding related.</summary>
		protected virtual void OnDeliveryPriceChanged()
		{
			if(DeliveryPriceChanged!=null)
			{
				DeliveryPriceChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the PriceIsFromChanged event, which is thrown when PriceIsFrom changes value. Databinding related.</summary>
		protected virtual void OnPriceIsFromChanged()
		{
			if(PriceIsFromChanged!=null)
			{
				PriceIsFromChanged(this, new EventArgs());
			}
		}

		#endregion

		/// <summary> A method which calls all OnFieldnameChanged methods to signal that the field has been changed to bound controls. This is required after a RollbackFields() call.</summary>
		protected override void FlagAllFieldsAsChanged()
		{
			OnIdChanged();
			OnNameChanged();
			OnDescriptionChanged();
			OnPriceChanged();
			OnPriceIncludesVatChanged();
			OnImageNameChanged();
			OnSectionIdChanged();
			OnExtraInformationChanged();
			OnDeliveryPriceChanged();
			OnPriceIsFromChanged();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(DirectSports.BL.EntityType.ProductEntity);
		}

		/// <summary>Creates field validator object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IValidator CreateValidator()
		{
			return new ProductValidator();
		}
		
		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return new ProductEntityFactory();
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_specialOffer!=null)
			{
				_specialOffer.ActiveContext = base.ActiveContext;
			}

			if(_productSection!=null)
			{
				_productSection.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_specialOffer = null;

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

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Price", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("PriceIncludesVat", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ImageName", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SectionId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ExtraInformation", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("DeliveryPrice", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("PriceIsFrom", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _productSection</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncProductSection(bool signalRelatedEntity)
		{
			if(_productSection != null)
			{

				_productSection.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("ProductSection", _productSection, ProductEntity.Relations.ProductSectionEntityUsingSectionId);
				if(signalRelatedEntity)
				{
					_productSection.UnsetRelatedEntity(this, "Product");
				}
				SetNewFieldValue((int)ProductFieldIndex.SectionId, null);
				_productSection = null;
			}
		}
		
		/// <summary> Decouples events from member _productSection</summary>
		private void DecoupleEventsProductSection()
		{
			if(_productSection != null)
			{

				_productSection.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("ProductSection", _productSection, ProductEntity.Relations.ProductSectionEntityUsingSectionId);
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
				base.SetEntitySyncInformation("ProductSection", _productSection, ProductEntity.Relations.ProductSectionEntityUsingSectionId);

			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProductEntity</param>
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
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SpecialOffer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSpecialOffer
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection(new SpecialOfferEntityFactory()),
					ProductEntity.Relations.SpecialOfferEntityUsingProductId, 
					(int)DirectSports.BL.EntityType.ProductEntity, (int)DirectSports.BL.EntityType.SpecialOfferEntity, 0, null, null, null, null, "SpecialOffer", RelationType.OneToMany);
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
					ProductEntity.Relations.ProductSectionEntityUsingSectionId, 
					(int)DirectSports.BL.EntityType.ProductEntity, (int)DirectSports.BL.EntityType.ProductSectionEntity, 0, null, null, null, null, "ProductSection", RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return ProductEntity.CustomProperties;}
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
			get { return ProductEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Id);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Id, value); }
		}

		/// <summary> The Name property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Name);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Name, value); }
		}

		/// <summary> The Description property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): LongVarWChar, 0, 0, 536870911<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Description);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Description, value); }
		}

		/// <summary> The Price property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Price"<br/>
		/// Table field type characteristics (type, precision, scale, length): Currency, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Decimal Price
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Price);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Decimal));
				}
				return (System.Decimal)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Price, value); }
		}

		/// <summary> The PriceIncludesVat property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."PriceIncludesVAT"<br/>
		/// Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean PriceIncludesVat
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.PriceIncludesVat);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Boolean));
				}
				return (System.Boolean)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.PriceIncludesVat, value); }
		}

		/// <summary> The ImageName property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ImageName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ImageName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ImageName);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ImageName, value); }
		}

		/// <summary> The SectionId property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."SectionId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Int32 SectionId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.SectionId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.SectionId, value); }
		}

		/// <summary> The ExtraInformation property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ExtraInformation"<br/>
		/// Table field type characteristics (type, precision, scale, length): LongVarWChar, 0, 0, 536870911<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ExtraInformation
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ExtraInformation);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ExtraInformation, value); }
		}

		/// <summary> The DeliveryPrice property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."DeliveryPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Currency, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Decimal DeliveryPrice
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.DeliveryPrice);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Decimal));
				}
				return (System.Decimal)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.DeliveryPrice, value); }
		}

		/// <summary> The PriceIsFrom property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."PriceIsFrom"<br/>
		/// Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean PriceIsFrom
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.PriceIsFrom);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Boolean));
				}
				return (System.Boolean)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.PriceIsFrom, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SpecialOfferEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(SpecialOfferEntity))]
		public virtual EntityCollection SpecialOffer
		{
			get
			{
				if(_specialOffer==null)
				{
					_specialOffer = new EntityCollection(new SpecialOfferEntityFactory());
					_specialOffer.SetContainingEntityInfo(this, "Product");
				}
				return _specialOffer;
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
							_productSection.UnsetRelatedEntity(this, "Product");
						}
					}
					else
					{
						((IEntity2)value).SetRelatedEntity(this, "Product");
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
			get { return (int)DirectSports.BL.EntityType.ProductEntity; }
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
