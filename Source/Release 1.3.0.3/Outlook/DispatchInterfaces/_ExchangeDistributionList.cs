//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _ExchangeDistributionList SupportByLibraryAttribute Outlook, 12,14
	///</summary>
	[SupportByLibraryAttribute("Outlook", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _ExchangeDistributionList : COMObject
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
                    _type = typeof(_ExchangeDistributionList);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
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
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public string Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Address", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Address", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlDisplayType DisplayType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayType", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlDisplayType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public string ID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.AddressEntry Manager
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Manager", paramsArray);
				NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public COMObject MAPIOBJECT
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MAPIOBJECT", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MAPIOBJECT", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.AddressEntries Members
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Members", paramsArray);
				NetOffice.OutlookApi.AddressEntries newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.AddressEntries.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public string Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlAddressEntryUserType AddressEntryUserType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressEntryUserType", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlAddressEntryUserType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.PropertyAccessor PropertyAccessor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyAccessor", paramsArray);
				NetOffice.OutlookApi.PropertyAccessor newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.PropertyAccessor.LateBindingApiWrapperType) as NetOffice.OutlookApi.PropertyAccessor;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public string Alias
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Alias", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public string Comments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Comments", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Comments", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public string PrimarySmtpAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrimarySmtpAddress", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="HWnd">optional object HWnd</param>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public void Details(object hWnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hWnd);
			Invoker.Method(this, "Details", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public void Details()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Details", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Start">DateTime Start</param>
		/// <param name="MinPerChar">Int32 MinPerChar</param>
		/// <param name="CompleteFormat">optional object CompleteFormat</param>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public string GetFreeBusy(DateTime start, Int32 minPerChar, object completeFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, minPerChar, completeFormat);
			object returnItem = Invoker.MethodReturn(this, "GetFreeBusy", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Start">DateTime Start</param>
		/// <param name="MinPerChar">Int32 MinPerChar</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public string GetFreeBusy(DateTime start, Int32 minPerChar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, minPerChar);
			object returnItem = Invoker.MethodReturn(this, "GetFreeBusy", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="MakePermanent">optional object MakePermanent</param>
		/// <param name="Refresh">optional object Refresh</param>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public void Update(object makePermanent, object refresh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(makePermanent, refresh);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="MakePermanent">optional object MakePermanent</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public void Update(object makePermanent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(makePermanent);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public void UpdateFreeBusy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateFreeBusy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi._ContactItem GetContact()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetContact", paramsArray);
			NetOffice.OutlookApi._ContactItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._ContactItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.ExchangeUser GetExchangeUser()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeUser", paramsArray);
			NetOffice.OutlookApi.ExchangeUser newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ExchangeUser.LateBindingApiWrapperType) as NetOffice.OutlookApi.ExchangeUser;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.ExchangeDistributionList GetExchangeDistributionList()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeDistributionList", paramsArray);
			NetOffice.OutlookApi.ExchangeDistributionList newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ExchangeDistributionList.LateBindingApiWrapperType) as NetOffice.OutlookApi.ExchangeDistributionList;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.AddressEntries GetMemberOfList()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetMemberOfList", paramsArray);
			NetOffice.OutlookApi.AddressEntries newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntries.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntries;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.AddressEntries GetExchangeDistributionListMembers()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeDistributionListMembers", paramsArray);
			NetOffice.OutlookApi.AddressEntries newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntries.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntries;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.AddressEntries GetOwners()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetOwners", paramsArray);
			NetOffice.OutlookApi.AddressEntries newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntries.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntries;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}