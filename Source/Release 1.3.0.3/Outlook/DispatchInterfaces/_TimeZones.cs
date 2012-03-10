//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _TimeZones SupportByLibraryAttribute Outlook, 12,14
	///</summary>
	[SupportByLibraryAttribute("Outlook", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _TimeZones : COMObject ,IEnumerable<NetOffice.OutlookApi._TimeZone>
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
                    _type = typeof(_TimeZones);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TimeZones(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TimeZones(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TimeZones(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TimeZones() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TimeZones(string progId) : base(progId)
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
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi._TimeZone CurrentTimeZone
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentTimeZone", paramsArray);
				NetOffice.OutlookApi._TimeZone newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._TimeZone;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OutlookApi._TimeZone this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OutlookApi._TimeZone newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._TimeZone;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="SourceDateTime">DateTime SourceDateTime</param>
		/// <param name="SourceTimeZone">NetOffice.OutlookApi._TimeZone SourceTimeZone</param>
		/// <param name="DestinationTimeZone">NetOffice.OutlookApi._TimeZone DestinationTimeZone</param>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		public DateTime ConvertTime(DateTime sourceDateTime, NetOffice.OutlookApi._TimeZone sourceTimeZone, NetOffice.OutlookApi._TimeZone destinationTimeZone)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceDateTime, sourceTimeZone, destinationTimeZone);
			object returnItem = Invoker.MethodReturn(this, "ConvertTime", paramsArray);
			return (DateTime)returnItem;
		}

		#endregion

        #region IEnumerable<NetOffice.OutlookApi._TimeZone> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Outlook, 12,14
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		[CustomEnumerator]
        public IEnumerator<NetOffice.OutlookApi._TimeZone> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OutlookApi._TimeZone item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
		
        /// <summary>
		/// SupportByLibraryAttribute Outlook, 12,14
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByLibraryAttribute("Outlook", 12,14)]
		[CustomEnumerator]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
        {
			int count = Count;
			COMObject[] enumeratorObjects = new COMObject[count];
			for (int i = 0; i < count; i++)
				enumeratorObjects[i] = this[i+1];

			foreach (COMObject item in enumeratorObjects)
				yield return item;
        }

        #endregion
        


		#pragma warning restore
	}
}