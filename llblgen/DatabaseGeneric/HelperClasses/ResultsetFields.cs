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
using System.Runtime.Serialization;
using System.Collections;

using DirectSports.BL.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.HelperClasses
{
	/// <summary>
	/// Helper class which will eases the creation of custom made resultsets. Usable in typed lists
	/// and dynamic lists created using the dynamic query engine.
	/// </summary>
	[Serializable]
	public partial class ResultsetFields : EntityFields2, ISerializable
	{
		/// <summary>CTor</summary>
		public ResultsetFields(int amountFields) : base(amountFields, InheritanceInfoProviderSingleton.GetInstance())
		{
		}

		/// <summary>Deserialization constructor</summary>
		/// <param name="info">Info.</param>
		/// <param name="context">Context.</param>
		protected ResultsetFields(SerializationInfo info, StreamingContext context) : base((int)info.GetInt32("_amountFields"), InheritanceInfoProviderSingleton.GetInstance())
		{
			ArrayList fields = (ArrayList)info.GetValue("_fields", typeof(ArrayList));
			for (int i = 0; i < fields.Count; i++)
			{
				this[i] = (IEntityField2)fields[i];
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo"/>with the data needed to serialize the target object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> to populate with data.</param>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"/>) for this serialization.</param>
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_amountFields", this.Count);
			ArrayList fields = new ArrayList(this.Count);
			for (int i = 0; i < this.Count; i++)
			{
				fields.Add(this[i]);
			}
			info.AddValue("_fields", fields, typeof(ArrayList));
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(ProductFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(ProductFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			IEntityField2 fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Alias = alias;
			fieldToAdd.ObjectAlias = entityAlias;
			fieldToAdd.AggregateFunctionToApply = aggregateFunctionToApply;
			base[indexInResultset] = fieldToAdd;
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductSectionFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(ProductSectionFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(ProductSectionFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			IEntityField2 fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Alias = alias;
			fieldToAdd.ObjectAlias = entityAlias;
			fieldToAdd.AggregateFunctionToApply = aggregateFunctionToApply;
			base[indexInResultset] = fieldToAdd;
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(RoleFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(RoleFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(RoleFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			IEntityField2 fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Alias = alias;
			fieldToAdd.ObjectAlias = entityAlias;
			fieldToAdd.AggregateFunctionToApply = aggregateFunctionToApply;
			base[indexInResultset] = fieldToAdd;
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SpecialOfferFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(SpecialOfferFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(SpecialOfferFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			IEntityField2 fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Alias = alias;
			fieldToAdd.ObjectAlias = entityAlias;
			fieldToAdd.AggregateFunctionToApply = aggregateFunctionToApply;
			base[indexInResultset] = fieldToAdd;
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(UserFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(UserFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(UserFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			IEntityField2 fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Alias = alias;
			fieldToAdd.ObjectAlias = entityAlias;
			fieldToAdd.AggregateFunctionToApply = aggregateFunctionToApply;
			base[indexInResultset] = fieldToAdd;
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(UserRoleLinkFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(UserRoleLinkFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(UserRoleLinkFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			IEntityField2 fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Alias = alias;
			fieldToAdd.ObjectAlias = entityAlias;
			fieldToAdd.AggregateFunctionToApply = aggregateFunctionToApply;
			base[indexInResultset] = fieldToAdd;
		}



		#region Included Code

		#endregion
	}
}
