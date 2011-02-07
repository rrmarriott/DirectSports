﻿///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: 06 January 2008 14:12:34
// Code is generated using templates: C# template set for MS Access (2000/XP/2003) (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.111705
//////////////////////////////////////////////////////////////
using System;

using DirectSports.BL;
using DirectSports.BL.EntityClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.ValidatorClasses
{
	/// <summary>
	/// Implementation of the ProductVariation Validator class. This class formulates validation rules for the
	/// ProductVariationEntity class. It is plugged into an instance of the ProductVariationEntity class using the Strategy
	/// Pattern [GoF]. This class is generated. 
	/// </summary>
	/// <remarks>
	/// If you want to add additional business logic to this class, derive from this
	/// class, override the validate method and pass an instance of that class to the
	/// ProductVariationEntity class instead of an instance of this class. The ProductVariationEntity code will then call your
	/// override methods when available and will use the method in this class.
	/// You can also adjust this class with validator rules. Be sure to add the rules between the user region start/end markers.
	/// You can also add your rules to the template bound to the template ID SD_EntityValidatorIncludeTemplate or bind that
	/// template ID to a different template.
	/// </remarks>
	[Serializable]
	public partial class ProductVariationValidator : IValidator
	{
		/// <summary>
		/// CTor
		/// </summary>
		public ProductVariationValidator()
		{
		}

		
		/// <summary>
		/// Validation method which is called when a field value changes. When a value fails the test, this method will return false
		/// and the field will keep its current value. When true is returned, the field will receive value as its new value.
		/// </summary>
		/// <param name="fieldIndex">Index of the field which value is changed</param>
		/// <param name="value">new value of the field. This value should be validated</param>
		/// <returns>true, if value is a valid value for the field with index fieldIndex, false otherwise.</returns>
		public virtual bool Validate(int fieldIndex, object value)
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START ValidationLogic
			// TODO:  Add ProductVariationValidator.Validate implementation
			return true ;

			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		#region Included Code

		#endregion
	}
}
