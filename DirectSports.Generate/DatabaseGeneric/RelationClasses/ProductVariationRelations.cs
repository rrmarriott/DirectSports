﻿///////////////////////////////////////////////////////////////
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
using DirectSports.BL.FactoryClasses;
using DirectSports.BL.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.RelationClasses
{
	/// <summary>
	/// Implements the static Relations variant for the entity: ProductVariation.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class ProductVariationRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public ProductVariationRelations()
		{
		}

		#region Class Property Declarations

	
	
		/// <summary>Returns a new IEntityRelation object, between ProductVariationEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductVariation.ProductId - Product.Id
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.Id), EntityFieldFactory.Create(ProductVariationFieldIndex.ProductId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVariationEntity", true);
				return relation;
			}
		}
	

		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
