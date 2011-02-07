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
using System.Data;
using System.Data.OleDb;
using System.Threading;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DirectSports.BL.DatabaseSpecific
{
	/// <summary>
	/// General persistence info factory. It has self-caching code which delivers IFieldPersistenceInfo objects. 
	/// The code caches previous created persistenceinfo objects. 
	/// If caching should be disabled, specify NOCACHE as compiler parameter. Cached objecs are not threadsafe, however
	/// normal usage doesn't require alterning of the IFieldPersistenceInfo objects.
	/// For .NET 1.1 and multi-CPU systems, specify MULTICPU as compiler option to make the code flush cache memory when 
	/// a new bucket is added to the hashtable.
	/// Access specific.
	/// </summary>
	internal class PersistenceInfoFactory
	{
		#region Class Member Declarations
		private static Hashtable	_fieldPInfosCache;
		private static object		_mutex;
		#endregion

		/// <summary>
		/// Static CTor, just a single instance.
		/// </summary>
		static PersistenceInfoFactory()
		{
			// Create the persistence info cache. Per entity / typed view a PersistenceInfoBucket object is stored.  
			_fieldPInfosCache = new Hashtable();
			_mutex = new Object();
		}


		/// <summary>
		/// Creates for each field of entity / typed view with the name passed in an IFieldPersistenceInfo instance.
		/// The order of these IFieldPersistenceInfo objects is the same as the corresponding fields in an 
		/// entity / typed view with the name objectName.
		/// </summary>
		/// <param name="objectName">Name of the entity / typed view to create FieldPersistenceInfo objects for. Example: CustomerEntity</param>
		/// <returns>Array of IFieldPersistenceInfo objects</returns>
		public static IFieldPersistenceInfo[] GetAllFieldPersistenceInfos(string objectName)
		{
			PersistenceInfoBucket bucket = GetBucket(objectName);

			// return info
			return bucket.GetAllFieldPersistenceInfoObjects();
		}


		/// <summary>
		/// Creates for each field of the entity instance passed in an IFieldPersistenceInfo instance.
		/// </summary>
		/// <param name="entity">Entity instance to return the IFieldPersistenceInfo objects for.</param>
		/// <returns>Array of IFieldPersistenceInfo objects</returns>
		public static IFieldPersistenceInfo[] GetAllFieldPersistenceInfos(IEntity2 entity)
		{
			PersistenceInfoBucket bucket = GetBucket(entity.LLBLGenProEntityName);

			// return info
			return bucket.GetAllFieldPersistenceInfoObjects();
		}


		/// <summary>
		/// Creates for the field with name fieldName of entity / typed view with the name passed in the IFieldPersistenceInfo instance.
		/// </summary>
		/// <param name="objectName">Name of the entity / typed view the field belongs to. Example: CustomerEntity</param>
		/// <param name="fieldName">Name of the field which fieldpersistenceinfo should be returned. Example: CustomerID</param>
		/// <returns>Requested IFieldPersistenceInfo object</returns>
		public static IFieldPersistenceInfo GetFieldPersistenceInfo(string objectName, string fieldName)
		{
			PersistenceInfoBucket bucket = GetBucket(objectName);

			// return info
			return bucket.GetFieldPersistenceInfo(fieldName);
		}


		/// <summary>
		/// Gets the PersistenceInfoBucket for the entity / typed view with the name specified. Handles caching as well.
		/// </summary>
		/// <param name="objectName">Name of entity / typed view which bucket should be retrieved</param>
		/// <returns>requested object</returns>
		private static PersistenceInfoBucket GetBucket(string objectName)
		{
			PersistenceInfoBucket bucket = null;
			object mutex = new object();

			try
			{
				Monitor.Enter(_mutex);
				// get the bucket
				if(_fieldPInfosCache.ContainsKey(objectName))
				{
					bucket = (PersistenceInfoBucket)_fieldPInfosCache[objectName];
				}
				else
				{
					// not yet present
					bucket = CreatePersistenceInfoBucket(objectName);
#if !NOCACHE
					// cache bucket
					_fieldPInfosCache.Add(objectName, bucket);
#if MULTICPU
					System.Threading.Thread.MemoryBarrier();
#endif // MULTICPU
#endif
				}
			}
			finally
			{
				Monitor.Exit(_mutex);
			}

			return bucket;
		}


		/// <summary>
		/// Creates the PersistenceInfoBucket for the entity / typed view with the name passed in.
		/// </summary>
		/// <param name="objectName">Name of entity which bucket has to be created. Example: CustomerEntity</param>
		/// <returns>Requested persistenceInfoBucket</returns>
		private static PersistenceInfoBucket CreatePersistenceInfoBucket(string objectName)
		{
			PersistenceInfoBucket toReturn = null;

			switch(objectName)
			{
				case "ProductEntity":
					toReturn = CreateProductEntityBucket();
					break;
				case "ProductSectionEntity":
					toReturn = CreateProductSectionEntityBucket();
					break;
				case "RoleEntity":
					toReturn = CreateRoleEntityBucket();
					break;
				case "SpecialOfferEntity":
					toReturn = CreateSpecialOfferEntityBucket();
					break;
				case "UserEntity":
					toReturn = CreateUserEntityBucket();
					break;
				case "UserRoleLinkEntity":
					toReturn = CreateUserRoleLinkEntityBucket();
					break;

				default:
					toReturn = null;
					break;
			}

			return toReturn;
		}

	
		#region PersistenceInfoBucket construction methods
	
		/// <summary>
		/// Generates the PersistenceInfoBucket for the entity 'Product'.
		/// </summary>
		/// <returns>The requested, populated PersistenceInfoBucket for the entity 'Product'</returns>
		private static PersistenceInfoBucket CreateProductEntityBucket()
		{
			PersistenceInfoBucket toReturn = new PersistenceInfoBucket();
			toReturn.AddFieldPersistenceInfo("Id", new FieldPersistenceInfo(@"Default", "Product", "Id", false, (int)OleDbType.Integer, 0, 0, 10, true, "@@IDENTITY", null, typeof(System.Int32)));
			toReturn.AddFieldPersistenceInfo("Name", new FieldPersistenceInfo(@"Default", "Product", "Name", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String)));
			toReturn.AddFieldPersistenceInfo("Description", new FieldPersistenceInfo(@"Default", "Product", "Description", true, (int)OleDbType.LongVarWChar, 536870911, 0, 0, false, "", null, typeof(System.String)));
			toReturn.AddFieldPersistenceInfo("Price", new FieldPersistenceInfo(@"Default", "Product", "Price", true, (int)OleDbType.Currency, 0, 0, 19, false, "", null, typeof(System.Decimal)));
			toReturn.AddFieldPersistenceInfo("PriceIncludesVat", new FieldPersistenceInfo(@"Default", "Product", "PriceIncludesVAT", false, (int)OleDbType.Boolean, 2, 0, 0, false, "", null, typeof(System.Boolean)));
			toReturn.AddFieldPersistenceInfo("ImageName", new FieldPersistenceInfo(@"Default", "Product", "ImageName", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String)));
			toReturn.AddFieldPersistenceInfo("SectionId", new FieldPersistenceInfo(@"Default", "Product", "SectionId", true, (int)OleDbType.Integer, 0, 0, 10, false, "", null, typeof(System.Int32)));
			toReturn.AddFieldPersistenceInfo("ExtraInformation", new FieldPersistenceInfo(@"Default", "Product", "ExtraInformation", true, (int)OleDbType.LongVarWChar, 536870911, 0, 0, false, "", null, typeof(System.String)));
			toReturn.AddFieldPersistenceInfo("DeliveryPrice", new FieldPersistenceInfo(@"Default", "Product", "DeliveryPrice", true, (int)OleDbType.Currency, 0, 0, 19, false, "", null, typeof(System.Decimal)));
			toReturn.AddFieldPersistenceInfo("PriceIsFrom", new FieldPersistenceInfo(@"Default", "Product", "PriceIsFrom", false, (int)OleDbType.Boolean, 2, 0, 0, false, "", null, typeof(System.Boolean)));

			return toReturn;
		}
	
		/// <summary>
		/// Generates the PersistenceInfoBucket for the entity 'ProductSection'.
		/// </summary>
		/// <returns>The requested, populated PersistenceInfoBucket for the entity 'ProductSection'</returns>
		private static PersistenceInfoBucket CreateProductSectionEntityBucket()
		{
			PersistenceInfoBucket toReturn = new PersistenceInfoBucket();
			toReturn.AddFieldPersistenceInfo("Id", new FieldPersistenceInfo(@"Default", "ProductSection", "Id", false, (int)OleDbType.Integer, 0, 0, 10, true, "@@IDENTITY", null, typeof(System.Int32)));
			toReturn.AddFieldPersistenceInfo("ParentSectionId", new FieldPersistenceInfo(@"Default", "ProductSection", "ParentSectionId", true, (int)OleDbType.Integer, 0, 0, 10, false, "", null, typeof(System.Int32)));
			toReturn.AddFieldPersistenceInfo("Uri", new FieldPersistenceInfo(@"Default", "ProductSection", "Uri", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String)));
			toReturn.AddFieldPersistenceInfo("Name", new FieldPersistenceInfo(@"Default", "ProductSection", "Name", true, (int)OleDbType.VarWChar, 100, 0, 0, false, "", null, typeof(System.String)));

			return toReturn;
		}
	
		/// <summary>
		/// Generates the PersistenceInfoBucket for the entity 'Role'.
		/// </summary>
		/// <returns>The requested, populated PersistenceInfoBucket for the entity 'Role'</returns>
		private static PersistenceInfoBucket CreateRoleEntityBucket()
		{
			PersistenceInfoBucket toReturn = new PersistenceInfoBucket();
			toReturn.AddFieldPersistenceInfo("Name", new FieldPersistenceInfo(@"Default", "Role", "Name", true, (int)OleDbType.VarWChar, 100, 0, 0, false, "", null, typeof(System.String)));

			return toReturn;
		}
	
		/// <summary>
		/// Generates the PersistenceInfoBucket for the entity 'SpecialOffer'.
		/// </summary>
		/// <returns>The requested, populated PersistenceInfoBucket for the entity 'SpecialOffer'</returns>
		private static PersistenceInfoBucket CreateSpecialOfferEntityBucket()
		{
			PersistenceInfoBucket toReturn = new PersistenceInfoBucket();
			toReturn.AddFieldPersistenceInfo("Id", new FieldPersistenceInfo(@"Default", "SpecialOffer", "Id", false, (int)OleDbType.Integer, 0, 0, 10, true, "@@IDENTITY", null, typeof(System.Int32)));
			toReturn.AddFieldPersistenceInfo("ProductId", new FieldPersistenceInfo(@"Default", "SpecialOffer", "ProductId", true, (int)OleDbType.Integer, 0, 0, 10, false, "", null, typeof(System.Int32)));
			toReturn.AddFieldPersistenceInfo("Number", new FieldPersistenceInfo(@"Default", "SpecialOffer", "Number", true, (int)OleDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16)));

			return toReturn;
		}
	
		/// <summary>
		/// Generates the PersistenceInfoBucket for the entity 'User'.
		/// </summary>
		/// <returns>The requested, populated PersistenceInfoBucket for the entity 'User'</returns>
		private static PersistenceInfoBucket CreateUserEntityBucket()
		{
			PersistenceInfoBucket toReturn = new PersistenceInfoBucket();
			toReturn.AddFieldPersistenceInfo("UserId", new FieldPersistenceInfo(@"Default", "User", "UserId", true, (int)OleDbType.VarWChar, 50, 0, 0, false, "", null, typeof(System.String)));
			toReturn.AddFieldPersistenceInfo("FirstName", new FieldPersistenceInfo(@"Default", "User", "FirstName", true, (int)OleDbType.VarWChar, 50, 0, 0, false, "", null, typeof(System.String)));
			toReturn.AddFieldPersistenceInfo("LastName", new FieldPersistenceInfo(@"Default", "User", "LastName", true, (int)OleDbType.VarWChar, 50, 0, 0, false, "", null, typeof(System.String)));
			toReturn.AddFieldPersistenceInfo("Password", new FieldPersistenceInfo(@"Default", "User", "Password", true, (int)OleDbType.LongVarWChar, 536870911, 0, 0, false, "", null, typeof(System.String)));

			return toReturn;
		}
	
		/// <summary>
		/// Generates the PersistenceInfoBucket for the entity 'UserRoleLink'.
		/// </summary>
		/// <returns>The requested, populated PersistenceInfoBucket for the entity 'UserRoleLink'</returns>
		private static PersistenceInfoBucket CreateUserRoleLinkEntityBucket()
		{
			PersistenceInfoBucket toReturn = new PersistenceInfoBucket();
			toReturn.AddFieldPersistenceInfo("UserId", new FieldPersistenceInfo(@"Default", "UserRoleLink", "UserId", true, (int)OleDbType.VarWChar, 50, 0, 0, false, "", null, typeof(System.String)));
			toReturn.AddFieldPersistenceInfo("RoleName", new FieldPersistenceInfo(@"Default", "UserRoleLink", "RoleName", true, (int)OleDbType.VarWChar, 50, 0, 0, false, "", null, typeof(System.String)));

			return toReturn;
		}
	

	
		#endregion


		/// <summary>
		/// Bucket class which contains for an entity or typed view per field the IFieldPersistenceInfo object.
		/// </summary>
		private class PersistenceInfoBucket
		{
			#region Class Member Declarations
			private Hashtable		_fieldPersistenceInfos;
			private SortedList		_fieldPersistenceInfosPerIndex;
			#endregion

			/// <summary>
			/// CTor
			/// </summary>
			public PersistenceInfoBucket()
			{
				_fieldPersistenceInfos = new Hashtable();
				_fieldPersistenceInfosPerIndex = new SortedList();
			}


			/// <summary>
			/// Adds the passed in fieldpersistenceinfo object to the list of persistence info objects already in the bucket, with the passed in
			/// fieldname as key.
			/// </summary>
			/// <param name="fieldName">name of field the persistenceinfo object is for</param>
			/// <param name="persistenceInfo">persistenceinfo object to store</param>
			public void AddFieldPersistenceInfo(string fieldName, IFieldPersistenceInfo persistenceInfo)
			{
				_fieldPersistenceInfos.Add(fieldName, persistenceInfo);
				// add to sorted list with the count as the key
				_fieldPersistenceInfosPerIndex.Add(_fieldPersistenceInfosPerIndex.Count, persistenceInfo);
			}


			/// <summary>
			/// Returns the IFieldPersistenceInfo object for the field with the name passed in
			/// </summary>
			/// <param name="fieldName">Name of field</param>
			/// <returns>requested IFieldPersistenceInfo object or null if not found</returns>
			public IFieldPersistenceInfo GetFieldPersistenceInfo(string fieldName)
			{
				IFieldPersistenceInfo toReturn = null;

				if(_fieldPersistenceInfos.ContainsKey(fieldName))
				{
					toReturn = (IFieldPersistenceInfo)_fieldPersistenceInfos[fieldName];
				}

				return toReturn;
			}


			/// <summary>
			/// Returns all IFieldPersistenceInfo objects in the bucket, in the order in which they are initially stored in the bucket
			/// </summary>
			/// <returns>requested objects in an array</returns>
			public IFieldPersistenceInfo[] GetAllFieldPersistenceInfoObjects()
			{
				IFieldPersistenceInfo[] toReturn = new FieldPersistenceInfo[_fieldPersistenceInfos.Count];

				for (int i = 0; i < _fieldPersistenceInfosPerIndex.Count; i++)
				{
					toReturn[i] = (IFieldPersistenceInfo)_fieldPersistenceInfosPerIndex.GetByIndex(i);
				}

				return toReturn;
			}
		}


		#region Included Code

		#endregion
	}
}
