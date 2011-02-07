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
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml;

using DirectSports.BL.EntityClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Generic Collection class for storing collections of entities of the same type.
	/// </summary>
	[Serializable]
	public partial class EntityCollection : EntityCollectionBase2
	{
		/// <summary>
		/// CTor
		/// </summary>
		public EntityCollection():base()
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="entityFactoryToUse">The entity factory object to use when this collection has to construct new objects.
		/// This is the case when the collection is bound to a grid-like control for example.</param>
		public EntityCollection(IEntityFactory2 entityFactoryToUse):base(entityFactoryToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="entityFactoryToUse">The entity factory object to use when this collection has to construct new objects.
		/// This is the case when the collection is bound to a grid-like control for example.</param>
		/// <param name="validatorToUse">The validator object to use for new entities constructed using the entity factory. Ignored when null</param>
		public EntityCollection(IEntityFactory2 entityFactoryToUse, IValidator validatorToUse):base(entityFactoryToUse, validatorToUse)
		{
		}


		/// <summary>
		/// Protected CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EntityCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
		

		/// <summary>
		/// ITypedList.GetItemProperties implementation. Necessary for Complex databinding. 
		/// </summary>
		/// <param name="listAccessors">Data to determine which property descriptor set to create</param>
		/// <returns>collection of property descriptors which will be used to create property related objects, like columns in a bound grid.</returns>
		public override PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			// determine the type of the entity to return the properties of.
			if((listAccessors==null)||listAccessors.Length==0)
			{
				// this collection is bound to the control, simply call the base class routine to create property descriptors.
				return base.GetItemProperties(listAccessors);
			}
			
			// use the last entry in the listAccessors, grab its TypeContainedAttribute and instantiate an instance of the type in that attribute,
			// use that entity instance to produce properties.
#if CF
			object[] customAttributes = listAccessors[listAccessors.Length-1].ComponentType.GetCustomAttributes(typeof(TypeContainedAttribute), false);
			TypeContainedAttribute typeAttribute = null;
			if(customAttributes.Length>0)
			{
				typeAttribute = (TypeContainedAttribute)customAttributes[0];
			}
#else
			TypeContainedAttribute typeAttribute = (TypeContainedAttribute) listAccessors[listAccessors.Length-1].Attributes[typeof(TypeContainedAttribute)];
#endif
			if(typeAttribute==null)
			{
				// not found, not specified, can't determine property descriptors.
				return new PropertyDescriptorCollection(null);
			}
			
			// create instance
			IEntity2 newInstance = (IEntity2)Activator.CreateInstance(typeAttribute.TypeContainedInCollection);
			
			// create property descriptors.
			if(base.Site==null)
			{
				return base.GetPropertyDescriptors(newInstance, typeAttribute.TypeContainedInCollection);
			}
			else
			{
				// in design mode. Because we ended up here, listAccessors is at least of length 1. Don't include collection properties.
				return base.GetPropertyDescriptors(newInstance, typeAttribute.TypeContainedInCollection, true);
			}
		}
		
		#region Custom EntityCollection code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCollectionCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Included Code

		#endregion
	}
}
