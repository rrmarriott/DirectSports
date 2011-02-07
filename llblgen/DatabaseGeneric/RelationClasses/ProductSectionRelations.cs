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
using DirectSports.BL.FactoryClasses;
using DirectSports.BL.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.RelationClasses
{
	/// <summary>
	/// Implements the static Relations variant for the entity: ProductSection.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class ProductSectionRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public ProductSectionRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductSectionEntity and ProductEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductSection.Id - Product.SectionId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingSectionId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductSectionFieldIndex.Id), EntityFieldFactory.Create(ProductFieldIndex.SectionId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSectionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between ProductSectionEntity and ProductSectionEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductSection.Id - ProductSection.ParentSectionId
		/// </summary>
		public virtual IEntityRelation ProductSectionEntityUsingParentSectionId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductSectionFieldIndex.Id), EntityFieldFactory.Create(ProductSectionFieldIndex.ParentSectionId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSectionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSectionEntity", false);
				return relation;
			}
		}
	
	
	
		/// <summary>Returns a new IEntityRelation object, between ProductSectionEntity and ProductSectionEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductSection.ParentSectionId - ProductSection.Id
		/// </summary>
		public virtual IEntityRelation ProductSectionEntityUsingIdParentSectionId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductSectionFieldIndex.Id), EntityFieldFactory.Create(ProductSectionFieldIndex.ParentSectionId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSectionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSectionEntity", true);
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
