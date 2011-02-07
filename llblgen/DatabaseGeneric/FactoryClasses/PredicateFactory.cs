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

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.FactoryClasses
{
	/// <summary>
	/// Class which eases the creation of the different predicate clauses defined in the ORM support classes. 
	/// Use these methods to create predicate clauses for filters without a lot of code.
	/// </summary>
	public partial class PredicateFactory
	{
		/// <summary>
		/// Static class, no CTor
		/// </summary>
		private PredicateFactory()
		{
		}

		#region FieldCompareValuePredicate creators (4 per entity type)
	
		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias, negate);
		}
	

		/// <summary>FieldCompareValuePredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductSectionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductSectionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductSectionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductSectionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias, negate);
		}
	

		/// <summary>FieldCompareValuePredicate factory for RoleEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(RoleFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for RoleEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(RoleFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for RoleEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(RoleFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for RoleEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(RoleFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias, negate);
		}
	

		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias, negate);
		}
	

		/// <summary>FieldCompareValuePredicate factory for UserEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(UserFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for UserEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(UserFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for UserEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(UserFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for UserEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(UserFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias, negate);
		}
	

		/// <summary>FieldCompareValuePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(UserRoleLinkFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(UserRoleLinkFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(UserRoleLinkFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(UserRoleLinkFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, value, objectAlias, negate);
		}
	
		#endregion

		#region FieldCompareValuePredicate creators (4 per typed view type)
	
		#endregion

		#region FieldCompareNullPredicate creators (4 per entity type)
	
		/// <summary>FieldCompareNullPredicate factory for ProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null);
		}

		/// <summary>FieldCompareNullPredicate factory for ProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, negate);
		}

		/// <summary>FieldCompareNullPredicate factory for ProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for ProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate);
		}
	

		/// <summary>FieldCompareNullPredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductSectionFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null);
		}

		/// <summary>FieldCompareNullPredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductSectionFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, negate);
		}

		/// <summary>FieldCompareNullPredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductSectionFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductSectionFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate);
		}
	

		/// <summary>FieldCompareNullPredicate factory for RoleEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(RoleFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null);
		}

		/// <summary>FieldCompareNullPredicate factory for RoleEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(RoleFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, negate);
		}

		/// <summary>FieldCompareNullPredicate factory for RoleEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(RoleFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for RoleEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(RoleFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate);
		}
	

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null);
		}

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, negate);
		}

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate);
		}
	

		/// <summary>FieldCompareNullPredicate factory for UserEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(UserFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null);
		}

		/// <summary>FieldCompareNullPredicate factory for UserEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(UserFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, negate);
		}

		/// <summary>FieldCompareNullPredicate factory for UserEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(UserFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for UserEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(UserFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate);
		}
	

		/// <summary>FieldCompareNullPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(UserRoleLinkFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null);
		}

		/// <summary>FieldCompareNullPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(UserRoleLinkFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, negate);
		}

		/// <summary>FieldCompareNullPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(UserRoleLinkFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(UserRoleLinkFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate);
		}
	
		#endregion

		#region FieldCompareNullPredicate creators (4 per typed view type)
	
		#endregion

		#region FieldBetweenPredicate creators (4 per entity type)
	
		/// <summary>FieldBetweenPredicate factory for ProductEntity.</summary>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for ProductEntity.</summary>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for ProductEntity.</summary>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for ProductEntity.</summary>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias, negate);
		}
	

		/// <summary>FieldBetweenPredicate factory for ProductSectionEntity.</summary>
		public static FieldBetweenPredicate Between(ProductSectionFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for ProductSectionEntity.</summary>
		public static FieldBetweenPredicate Between(ProductSectionFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for ProductSectionEntity.</summary>
		public static FieldBetweenPredicate Between(ProductSectionFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for ProductSectionEntity.</summary>
		public static FieldBetweenPredicate Between(ProductSectionFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias, negate);
		}
	

		/// <summary>FieldBetweenPredicate factory for RoleEntity.</summary>
		public static FieldBetweenPredicate Between(RoleFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for RoleEntity.</summary>
		public static FieldBetweenPredicate Between(RoleFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for RoleEntity.</summary>
		public static FieldBetweenPredicate Between(RoleFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for RoleEntity.</summary>
		public static FieldBetweenPredicate Between(RoleFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias, negate);
		}
	

		/// <summary>FieldBetweenPredicate factory for SpecialOfferEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for SpecialOfferEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for SpecialOfferEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for SpecialOfferEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias, negate);
		}
	

		/// <summary>FieldBetweenPredicate factory for UserEntity.</summary>
		public static FieldBetweenPredicate Between(UserFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for UserEntity.</summary>
		public static FieldBetweenPredicate Between(UserFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for UserEntity.</summary>
		public static FieldBetweenPredicate Between(UserFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for UserEntity.</summary>
		public static FieldBetweenPredicate Between(UserFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias, negate);
		}
	

		/// <summary>FieldBetweenPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldBetweenPredicate Between(UserRoleLinkFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldBetweenPredicate Between(UserRoleLinkFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldBetweenPredicate Between(UserRoleLinkFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldBetweenPredicate Between(UserRoleLinkFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), null, valueBegin, valueEnd, objectAlias, negate);
		}
	
		#endregion

		#region FieldBetweenPredicate creators (4 per typed view type)
	
		#endregion

		#region FieldLikePredicate creators (4 per entity type)
	
		/// <summary>FieldLikePredicate factory for ProductEntity.</summary>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern);
		}

		/// <summary>FieldLikePredicate factory for ProductEntity.</summary>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for ProductEntity.</summary>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for ProductEntity.</summary>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern, negate);
		}
	

		/// <summary>FieldLikePredicate factory for ProductSectionEntity.</summary>
		public static FieldLikePredicate Like(ProductSectionFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern);
		}

		/// <summary>FieldLikePredicate factory for ProductSectionEntity.</summary>
		public static FieldLikePredicate Like(ProductSectionFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for ProductSectionEntity.</summary>
		public static FieldLikePredicate Like(ProductSectionFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for ProductSectionEntity.</summary>
		public static FieldLikePredicate Like(ProductSectionFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern, negate);
		}
	

		/// <summary>FieldLikePredicate factory for RoleEntity.</summary>
		public static FieldLikePredicate Like(RoleFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern);
		}

		/// <summary>FieldLikePredicate factory for RoleEntity.</summary>
		public static FieldLikePredicate Like(RoleFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for RoleEntity.</summary>
		public static FieldLikePredicate Like(RoleFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for RoleEntity.</summary>
		public static FieldLikePredicate Like(RoleFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern, negate);
		}
	

		/// <summary>FieldLikePredicate factory for SpecialOfferEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern);
		}

		/// <summary>FieldLikePredicate factory for SpecialOfferEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for SpecialOfferEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for SpecialOfferEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern, negate);
		}
	

		/// <summary>FieldLikePredicate factory for UserEntity.</summary>
		public static FieldLikePredicate Like(UserFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern);
		}

		/// <summary>FieldLikePredicate factory for UserEntity.</summary>
		public static FieldLikePredicate Like(UserFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for UserEntity.</summary>
		public static FieldLikePredicate Like(UserFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for UserEntity.</summary>
		public static FieldLikePredicate Like(UserFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern, negate);
		}
	

		/// <summary>FieldLikePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldLikePredicate Like(UserRoleLinkFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern);
		}

		/// <summary>FieldLikePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldLikePredicate Like(UserRoleLinkFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldLikePredicate Like(UserRoleLinkFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldLikePredicate Like(UserRoleLinkFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, pattern, negate);
		}
	
		#endregion

		#region FieldLikePredicate creators (4 per typed view type)
	
		#endregion

		#region FieldCompareRangePredicate creators (4 per entity type)
	
		/// <summary>FieldCompareRangePredicate factory for ProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for ProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for ProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for ProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate, values);
		}
	

		/// <summary>FieldCompareRangePredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductSectionFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductSectionFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductSectionFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductSectionFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate, values);
		}
	

		/// <summary>FieldCompareRangePredicate factory for RoleEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(RoleFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for RoleEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(RoleFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for RoleEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(RoleFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for RoleEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(RoleFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate, values);
		}
	

		/// <summary>FieldCompareRangePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate, values);
		}
	

		/// <summary>FieldCompareRangePredicate factory for UserEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(UserFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for UserEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(UserFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for UserEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(UserFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for UserEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(UserFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate, values);
		}
	

		/// <summary>FieldCompareRangePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(UserRoleLinkFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(UserRoleLinkFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(UserRoleLinkFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(UserRoleLinkFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), null, objectAlias, negate, values);
		}
	
		#endregion

		#region FieldCompareRangePredicate creators (4 per typed view type)
	
		#endregion

		#region FieldCompareExpressionPredicate creators (4 per entity type)
	
		/// <summary>FieldCompareExpressionPredicate factory for ProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith );
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for ProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
	

		/// <summary>FieldCompareExpressionPredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductSectionFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith );
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductSectionFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductSectionFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ProductSectionEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductSectionFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
	

		/// <summary>FieldCompareExpressionPredicate factory for RoleEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(RoleFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith );
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for RoleEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(RoleFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for RoleEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(RoleFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for RoleEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(RoleFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
	

		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith );
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
	

		/// <summary>FieldCompareExpressionPredicate factory for UserEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(UserFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith );
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for UserEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(UserFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for UserEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(UserFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for UserEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(UserFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
	

		/// <summary>FieldCompareExpressionPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(UserRoleLinkFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith );
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(UserRoleLinkFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(UserRoleLinkFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for UserRoleLinkEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(UserRoleLinkFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), null, operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
	
		#endregion

		#region FieldCompareExpressionPredicate creators (4 per typed view type)
	
		#endregion

		#region Included Code

		#endregion
	}
}
