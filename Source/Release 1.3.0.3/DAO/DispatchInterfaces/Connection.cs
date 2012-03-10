//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface Connection SupportByLibraryAttribute DAO, 6,12
	///</summary>
	[SupportByLibraryAttribute("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Connection : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Connection);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public string Connect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connect", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Database Database
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Database", paramsArray);
				NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Database.LateBindingApiWrapperType) as NetOffice.DAOApi.Database;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public Int32 hDbc
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "hDbc", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public Int16 QueryTimeout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "QueryTimeout", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "QueryTimeout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public bool Transactions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Transactions", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public Int32 RecordsAffected
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordsAffected", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public bool StillExecuting
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StillExecuting", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public bool Updatable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Updatable", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDefs QueryDefs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "QueryDefs", paramsArray);
				NetOffice.DAOApi.QueryDefs newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.QueryDefs.LateBindingApiWrapperType) as NetOffice.DAOApi.QueryDefs;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Recordsets Recordsets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Recordsets", paramsArray);
				NetOffice.DAOApi.Recordsets newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Recordsets.LateBindingApiWrapperType) as NetOffice.DAOApi.Recordsets;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public void Cancel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cancel", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="SQLText">optional object SQLText</param>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDef CreateQueryDef(object name, object sQLText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, sQLText);
			object returnItem = Invoker.MethodReturn(this, "CreateQueryDef", paramsArray);
			NetOffice.DAOApi.QueryDef newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.QueryDef.LateBindingApiWrapperType) as NetOffice.DAOApi.QueryDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDef CreateQueryDef()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateQueryDef", paramsArray);
			NetOffice.DAOApi.QueryDef newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.QueryDef.LateBindingApiWrapperType) as NetOffice.DAOApi.QueryDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDef CreateQueryDef(object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "CreateQueryDef", paramsArray);
			NetOffice.DAOApi.QueryDef newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.QueryDef.LateBindingApiWrapperType) as NetOffice.DAOApi.QueryDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Query">string Query</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public void Execute(string query, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(query, options);
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Query">string Query</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public void Execute(string query)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(query);
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="LockEdit">optional object LockEdit</param>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset(string name, object type, object options, object lockEdit)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, options, lockEdit);
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">optional object Type</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset(string name, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type);
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset(string name, object type, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, options);
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}