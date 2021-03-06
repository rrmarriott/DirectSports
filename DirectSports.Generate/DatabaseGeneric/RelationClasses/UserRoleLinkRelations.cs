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
	/// Implements the static Relations variant for the entity: UserRoleLink.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class UserRoleLinkRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public UserRoleLinkRelations()
		{
		}

		#region Class Property Declarations

	
	
		/// <summary>Returns a new IEntityRelation object, between UserRoleLinkEntity and RoleEntity over the m:1 relation they have, using the relation between the fields:
		/// UserRoleLink.RoleName - Role.Name
		/// </summary>
		public virtual IEntityRelation RoleEntityUsingRoleName
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RoleFieldIndex.Name), EntityFieldFactory.Create(UserRoleLinkFieldIndex.RoleName));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RoleEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserRoleLinkEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between UserRoleLinkEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// UserRoleLink.UserId - User.UserId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingUserId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UserFieldIndex.UserId), EntityFieldFactory.Create(UserRoleLinkFieldIndex.UserId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserRoleLinkEntity", true);
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
