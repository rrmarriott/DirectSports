///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: 06 January 2008 14:12:31
// Code is generated using templates: C# template set for MS Access (2000/XP/2003) (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.111705
//////////////////////////////////////////////////////////////
using System;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.EnterpriseServices;
using System.Data.OleDb;

using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.Access;

namespace DirectSports.BL.DatabaseSpecific
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END


	/// <summary>
	/// Data access adapter class, which controls the complete database interaction with the database for all objects.
	/// Access specific.
	/// </summary>
	/// <remarks>
	/// Use a DataAccessAdapter object solely per thread, and per connection. A DataAccessAdapter object contains 1 active connection 
	/// and no thread-access scheduling code. This means that you need to create a new DataAccessAdapter object if you want to utilize
	/// in another thread a new connection and a new transaction or want to open a new connection.
	/// </remarks>
	public partial class DataAccessAdapter : DataAccessAdapterBase
	{
		#region Public static members
		/// <summary>
		/// The name of the key in the *.config file of the executing application which contains the connection string.
		/// </summary>
		/// <remarks>Default: the value set in the LLBLGen Pro project properties</remarks>
		public static string ConnectionStringKeyName="Main.ConnectionString";
		#endregion
		
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public DataAccessAdapter()
		{
			InitClass(ReadConnectionStringFromConfig(), false);
		}



		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="comPlusContextHost">the COM+ context host for this adapter instance.</param>
		/// <remarks>do not call this from your code</remarks>
		public DataAccessAdapter(IComPlusAdapterContext comPlusContextHost) : base(comPlusContextHost)
		{
			InitClass(ReadConnectionStringFromConfig(), false);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="comPlusContextHost">the COM+ context host for this adapter instance.</param>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <remarks>do not call this from your code</remarks>
		public DataAccessAdapter(IComPlusAdapterContext comPlusContextHost, string connectionString) : base(comPlusContextHost)
		{
			InitClass(connectionString, false);
		}
		

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		public DataAccessAdapter(bool keepConnectionOpen)
		{
			InitClass(ReadConnectionStringFromConfig(), keepConnectionOpen);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		public DataAccessAdapter(string connectionString)
		{
			InitClass(connectionString, false);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		public DataAccessAdapter(string connectionString, bool keepConnectionOpen)
		{
			InitClass(connectionString, keepConnectionOpen);
		}
		#endregion


		/// <summary>
		/// Retrieves the persistence info for the field passed in. 
		/// </summary>
		/// <param name="field">Field which fieldpersistence info has to be retrieved</param>
		/// <returns>the requested persistence information</returns>
		protected override IFieldPersistenceInfo GetFieldPersistenceInfo(IEntityField2 field)
		{
			IFieldPersistenceInfo persistenceInfo = PersistenceInfoFactory.GetFieldPersistenceInfo(field.ContainingObjectName, field.Name);
			InsertPersistenceInfoObjects(field.ExpressionToApply);
			return persistenceInfo;
		}


		/// <summary>
		/// Retrieves the persistence info objects for the fields of the entity passed in.
		/// </summary>
		/// <param name="entity">Entity object which fields the persistence information should be retrieved for</param>
		/// <returns>the requested persistence information</returns>
		protected override IFieldPersistenceInfo[] GetFieldPersistenceInfos(IEntity2 entity)
		{
			for (int i = 0; i < entity.Fields.Count; i++)
			{
				InsertPersistenceInfoObjects(entity.Fields[i].ExpressionToApply);
			}

			return GetFieldPersistenceInfos(entity.LLBLGenProEntityName);
		}


		/// <summary>
		/// Retrieves the persistence info objects for the fields of the entity passed in.
		/// </summary>
		/// <param name="entityName">Entity name for entity type which fields the persistence information should be retrieved for</param>
		/// <returns>the requested persistence information</returns>
		protected override IFieldPersistenceInfo[] GetFieldPersistenceInfos(string entityName)
		{
			IFieldPersistenceInfo[] persistenceInfoObjects = PersistenceInfoFactory.GetAllFieldPersistenceInfos(entityName);
			return persistenceInfoObjects;
		}


		/// <summary>
		/// Inserts in each predicate expression element the persistence info object for the field used. If there is already a fieldpersistenceinfo 
		/// element for a given field, it is skipped. 
		/// </summary>
		/// <param name="expression">IPredicateExpression object which has predicate elements whose persistence info objects have to be
		/// set to a value.</param>
		protected override void InsertPersistenceInfoObjects(IPredicateExpression expression)
		{
			if(expression == null)
			{
				return;
			}

			for (int i = 0; i < expression.Count; i++)
			{
				if(expression[i].Type!=PredicateExpressionElementType.Predicate)
				{
					continue;
				}

				IPredicate currentPredicate = (IPredicate)expression[i].Contents;
				switch((PredicateType)currentPredicate.InstanceType)
				{
					case PredicateType.Undefined:
						continue;
					case PredicateType.PredicateExpression:
						// recurse
						InsertPersistenceInfoObjects((IPredicateExpression)expression[i].Contents);
						break;
					case PredicateType.FieldBetweenPredicate:
						FieldBetweenPredicate betweenPredicate = (FieldBetweenPredicate)currentPredicate;
						if(betweenPredicate.PersistenceInfo==null)
						{
							betweenPredicate.PersistenceInfo = GetFieldPersistenceInfo((IEntityField2)betweenPredicate.FieldCore);
						}
						if(betweenPredicate.BeginIsField && (betweenPredicate.PersistenceInfoBegin==null))
						{
							betweenPredicate.PersistenceInfoBegin = GetFieldPersistenceInfo((IEntityField2)betweenPredicate.FieldBeginCore);
						}
						if(betweenPredicate.EndIsField && (betweenPredicate.PersistenceInfoEnd==null))
						{
							betweenPredicate.PersistenceInfoEnd = GetFieldPersistenceInfo((IEntityField2)betweenPredicate.FieldEndCore);
						}
						break;
					case PredicateType.FieldCompareNullPredicate:
						FieldCompareNullPredicate compareNullPredicate = (FieldCompareNullPredicate)currentPredicate;
						if(compareNullPredicate.PersistenceInfo==null)
						{
							compareNullPredicate.PersistenceInfo = GetFieldPersistenceInfo((IEntityField2)compareNullPredicate.FieldCore);
						}
						break;
					case PredicateType.FieldCompareValuePredicate:
						FieldCompareValuePredicate compareValuePredicate = (FieldCompareValuePredicate)currentPredicate;
						if(compareValuePredicate.PersistenceInfo==null)
						{
							compareValuePredicate.PersistenceInfo = GetFieldPersistenceInfo((IEntityField2)compareValuePredicate.FieldCore);
						}
						break;
					case PredicateType.FieldLikePredicate:
						FieldLikePredicate likePredicate = (FieldLikePredicate)currentPredicate;
						if(likePredicate.PersistenceInfo==null)
						{
							likePredicate.PersistenceInfo = GetFieldPersistenceInfo((IEntityField2)likePredicate.FieldCore);
						}
						break;
					case PredicateType.FieldCompareRangePredicate:
						FieldCompareRangePredicate compareRangePredicate = (FieldCompareRangePredicate)currentPredicate;
						if(compareRangePredicate.PersistenceInfo==null)
						{
							compareRangePredicate.PersistenceInfo = GetFieldPersistenceInfo((IEntityField2)compareRangePredicate.FieldCore);
						}
						break;
					case PredicateType.FieldCompareExpressionPredicate:
						FieldCompareExpressionPredicate expressionPredicate = (FieldCompareExpressionPredicate)currentPredicate;
						if(expressionPredicate.PersistenceInfo==null)
						{
							expressionPredicate.PersistenceInfo = GetFieldPersistenceInfo((IEntityField2)expressionPredicate.FieldCore);
						}
						if(expressionPredicate.ExpressionToCompareWith!=null)
						{
							InsertPersistenceInfoObjects(expressionPredicate.ExpressionToCompareWith);
						}
						break;
					case PredicateType.FieldFullTextSearchPredicate:
						FieldFullTextSearchPredicate fullTextSearchPredicate = (FieldFullTextSearchPredicate)currentPredicate;
						if(fullTextSearchPredicate.PersistenceInfo==null)
						{
							fullTextSearchPredicate.PersistenceInfo = GetFieldPersistenceInfo((IEntityField2)fullTextSearchPredicate.FieldCore);
						}
						break;
					case PredicateType.FieldCompareSetPredicate:
						FieldCompareSetPredicate compareSetPredicate = (FieldCompareSetPredicate)currentPredicate;
						if((compareSetPredicate.PersistenceInfoField==null)&&(compareSetPredicate.FieldCore!=null))
						{
							compareSetPredicate.PersistenceInfoField = GetFieldPersistenceInfo((IEntityField2)compareSetPredicate.FieldCore);
						}
						if(compareSetPredicate.PersistenceInfoSetField==null)
						{
							compareSetPredicate.PersistenceInfoSetField = GetFieldPersistenceInfo((IEntityField2)compareSetPredicate.SetFieldCore);
						}
						InsertPersistenceInfoObjects(compareSetPredicate.SetFilterAsPredicateExpression);
						InsertPersistenceInfoObjects(compareSetPredicate.SetRelations);
						InsertPersistenceInfoObjects(compareSetPredicate.SetSorter);
						InsertPersistenceInfoObjects(compareSetPredicate.GroupByClause);
						break;
					default:
					
					// __LLBLGENPRO_USER_CODE_REGION_START InsertPersistenceInfoObjectsPredicate
					// __LLBLGENPRO_USER_CODE_REGION_END
						break;
				}
			}
		}


		/// <summary>
		/// Creates a new Dynamic Query engine object and passes in the defined catalog/schema overwrite hashtables.
		/// </summary>
		protected override DynamicQueryEngineBase CreateDynamicQueryEngine()
		{
			DynamicQueryEngine toReturn = new DynamicQueryEngine();
			return (DynamicQueryEngineBase)toReturn;
		}
		
		
		/// <summary>
		/// Creates a new physical connection object.
		/// </summary>
		/// <param name="connectionString">Connectionstring to use for the new connection object</param>
		/// <returns>IDbConnection implementing connection object.</returns>
		protected override IDbConnection CreateNewPhysicalConnection(string connectionString)
		{
			return new OleDbConnection(connectionString);
		}


		/// <summary>
		/// Creates a new physical transaction object over the created connection. The connection is assumed to be open.
		/// </summary>
		/// <returns>a physical transaction object, like an instance of OleDbTransaction.</returns>
		protected override IDbTransaction CreateNewPhysicalTransaction()
		{
			return ((OleDbConnection)base.GetActiveConnection()).BeginTransaction(base.TransactionIsolationLevel);
		}


		/// <summary>
		/// Creates a new .NET DataAdapter for the database system this DataAccessAdapter object is targeting. 
		/// </summary>
		/// <returns>New .NET DataAdapter object</returns>
		protected override DbDataAdapter CreateNewPhysicalDataAdapter()
		{
			return new OleDbDataAdapter();
		}


		/// <summary>
		/// Initializes the class.
		/// </summary>
		/// <param name="connectionString"></param>
		/// <param name="keepConnectionOpen"></param>
		private void InitClass(string connectionString, bool keepConnectionOpen)
		{
			base.ConnectionString = connectionString;
			base.KeepConnectionOpen = keepConnectionOpen;
			base.TypeDefaultValueSupplier = new TypeDefaultValue();
			base.CommandTimeOut = -1;
		}


		/// <summary>
		/// Reads the value of the setting with the key ConnectionStringKeyName from the *.config file and stores that value as the
		/// active connection string to use for this object.
		/// </summary>
		/// <returns>connection string read</returns>
		private string ReadConnectionStringFromConfig()
		{
			// read the connection string from the *.config file.
			AppSettingsReader configReader = new AppSettingsReader();
			return configReader.GetValue(DataAccessAdapter.ConnectionStringKeyName, typeof(string)).ToString();
		}


		#region Custom DataAccessAdapter code.
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDataAccessAdapterCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}


	/// <summary>
	/// ComPlusAdapterContext class which is used in Adapter for hosting a COM+ aware DataAccessAdapter class. 
	/// Use the hosted DataAccessAdapter class to start a new COM+ transaction.
	/// </summary>
	public partial class ComPlusAdapterContext : ComPlusAdapterContextBase
	{
		/// <summary>
		/// CTor
		/// </summary>
		public ComPlusAdapterContext()
		{
			base.SetAdapter(new DataAccessAdapter(this));
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="connectionString">the connection string to use with the hosted adapter.</param>
		public ComPlusAdapterContext(string connectionString)
		{
			base.SetAdapter(new DataAccessAdapter(this, connectionString));
		}


		/// <summary>
		/// Creates the physical connection object
		/// </summary>
		/// <param name="connectionString">connection string to use</param>
		/// <returns>Usable connection object (closed)</returns>
		protected override IDbConnection CreateDatabaseConnection(string connectionString)
		{
			return new OleDbConnection(connectionString);
		}
	}
}
