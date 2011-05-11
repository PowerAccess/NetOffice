//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Research SupportByLibrary WD12 WD14 
	///</summary>
	[SupportByLibrary("WD12","WD14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Research : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public string FavoriteService
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FavoriteService", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FavoriteService", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="ServiceID">string ServiceID</param>
		/// <param name="QueryString">string QueryString</param>
		/// <param name="QueryLanguage">NetOffice.WordApi.Enums.WdLanguageID QueryLanguage</param>
		/// <param name="UseSelection">bool UseSelection</param>
		/// <param name="LaunchQuery">bool LaunchQuery</param>
		[SupportByLibrary("WD12","WD14")]
		public object Query(string serviceID, string queryString, NetOffice.WordApi.Enums.WdLanguageID queryLanguage, bool useSelection, bool launchQuery)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(serviceID, queryString, queryLanguage, useSelection, launchQuery);
			object returnItem = Invoker.MethodReturn(this, "Query", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="LanguageFrom">NetOffice.WordApi.Enums.WdLanguageID LanguageFrom</param>
		/// <param name="LanguageTo">NetOffice.WordApi.Enums.WdLanguageID LanguageTo</param>
		[SupportByLibrary("WD12","WD14")]
		public object SetLanguagePair(NetOffice.WordApi.Enums.WdLanguageID languageFrom, NetOffice.WordApi.Enums.WdLanguageID languageTo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(languageFrom, languageTo);
			object returnItem = Invoker.MethodReturn(this, "SetLanguagePair", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="ServiceID">string ServiceID</param>
		[SupportByLibrary("WD12","WD14")]
		public bool IsResearchService(string serviceID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(serviceID);
			object returnItem = Invoker.MethodReturn(this, "IsResearchService", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}