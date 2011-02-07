///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: 06 January 2008 14:12:33
// Code is generated using templates: C# template set for MS Access (2000/XP/2003) (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.111705
//////////////////////////////////////////////////////////////
using System;

using DirectSports.BL;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.FactoryClasses
{
	/// <summary>Class which eases the creation of sort clauses used in a SortExpression, to sort resultsets on specified fields.</summary>
	public partial class SortClauseFactory
	{
		/// <summary>Static class, no CTor</summary>
		private SortClauseFactory()
		{
		}

		/// <summary>Creates a new sort clause for the ProductEntity field specified.</summary>
		public static ISortClause Create(ProductFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse);
		}

		/// <summary>Creates a new sort clause for the ProductEntity field specified.</summary>
		public static ISortClause Create(ProductFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the ProductSectionEntity field specified.</summary>
		public static ISortClause Create(ProductSectionFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse);
		}

		/// <summary>Creates a new sort clause for the ProductSectionEntity field specified.</summary>
		public static ISortClause Create(ProductSectionFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the ProductVariationEntity field specified.</summary>
		public static ISortClause Create(ProductVariationFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse);
		}

		/// <summary>Creates a new sort clause for the ProductVariationEntity field specified.</summary>
		public static ISortClause Create(ProductVariationFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the RoleEntity field specified.</summary>
		public static ISortClause Create(RoleFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse);
		}

		/// <summary>Creates a new sort clause for the RoleEntity field specified.</summary>
		public static ISortClause Create(RoleFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the SpecialOfferEntity field specified.</summary>
		public static ISortClause Create(SpecialOfferFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse);
		}

		/// <summary>Creates a new sort clause for the SpecialOfferEntity field specified.</summary>
		public static ISortClause Create(SpecialOfferFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the UserEntity field specified.</summary>
		public static ISortClause Create(UserFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse);
		}

		/// <summary>Creates a new sort clause for the UserEntity field specified.</summary>
		public static ISortClause Create(UserFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the UserRoleLinkEntity field specified.</summary>
		public static ISortClause Create(UserRoleLinkFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse);
		}

		/// <summary>Creates a new sort clause for the UserRoleLinkEntity field specified.</summary>
		public static ISortClause Create(UserRoleLinkFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), null, operatorToUse, objectAlias);
		}


		#region Included Code

		#endregion
	}
}
