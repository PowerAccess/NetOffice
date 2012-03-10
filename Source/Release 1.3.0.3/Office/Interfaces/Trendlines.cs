//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// Interface Trendlines SupportByLibraryAttribute Office, 12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class Trendlines : COMObject ,IEnumerable<NetOffice.OfficeApi.IMsoTrendline>
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
                    _type = typeof(Trendlines);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
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
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
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
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
		public COMObject Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
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
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.IMsoTrendline get__Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 14, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 14,14)]
		public NetOffice.OfficeApi.IMsoTrendline _Default
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
				NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlTrendlineType Type</param>
		/// <param name="Order">optional object Order</param>
		/// <param name="Period">optional object Period</param>
		/// <param name="Forward">optional object Forward</param>
		/// <param name="Backward">optional object Backward</param>
		/// <param name="Intercept">optional object Intercept</param>
		/// <param name="DisplayEquation">optional object DisplayEquation</param>
		/// <param name="DisplayRSquared">optional object DisplayRSquared</param>
		/// <param name="Name">optional object Name</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTrendline Add(NetOffice.OfficeApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward, object intercept, object displayEquation, object displayRSquared, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward, intercept, displayEquation, displayRSquared, name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlTrendlineType Type</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTrendline Add(NetOffice.OfficeApi.Enums.XlTrendlineType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlTrendlineType Type</param>
		/// <param name="Order">optional object Order</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTrendline Add(NetOffice.OfficeApi.Enums.XlTrendlineType type, object order)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlTrendlineType Type</param>
		/// <param name="Order">optional object Order</param>
		/// <param name="Period">optional object Period</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTrendline Add(NetOffice.OfficeApi.Enums.XlTrendlineType type, object order, object period)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlTrendlineType Type</param>
		/// <param name="Order">optional object Order</param>
		/// <param name="Period">optional object Period</param>
		/// <param name="Forward">optional object Forward</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTrendline Add(NetOffice.OfficeApi.Enums.XlTrendlineType type, object order, object period, object forward)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlTrendlineType Type</param>
		/// <param name="Order">optional object Order</param>
		/// <param name="Period">optional object Period</param>
		/// <param name="Forward">optional object Forward</param>
		/// <param name="Backward">optional object Backward</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTrendline Add(NetOffice.OfficeApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlTrendlineType Type</param>
		/// <param name="Order">optional object Order</param>
		/// <param name="Period">optional object Period</param>
		/// <param name="Forward">optional object Forward</param>
		/// <param name="Backward">optional object Backward</param>
		/// <param name="Intercept">optional object Intercept</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTrendline Add(NetOffice.OfficeApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward, object intercept)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward, intercept);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlTrendlineType Type</param>
		/// <param name="Order">optional object Order</param>
		/// <param name="Period">optional object Period</param>
		/// <param name="Forward">optional object Forward</param>
		/// <param name="Backward">optional object Backward</param>
		/// <param name="Intercept">optional object Intercept</param>
		/// <param name="DisplayEquation">optional object DisplayEquation</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTrendline Add(NetOffice.OfficeApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward, object intercept, object displayEquation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward, intercept, displayEquation);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlTrendlineType Type</param>
		/// <param name="Order">optional object Order</param>
		/// <param name="Period">optional object Period</param>
		/// <param name="Forward">optional object Forward</param>
		/// <param name="Backward">optional object Backward</param>
		/// <param name="Intercept">optional object Intercept</param>
		/// <param name="DisplayEquation">optional object DisplayEquation</param>
		/// <param name="DisplayRSquared">optional object DisplayRSquared</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTrendline Add(NetOffice.OfficeApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward, object intercept, object displayEquation, object displayRSquared)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward, intercept, displayEquation, displayRSquared);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.IMsoTrendline this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OfficeApi.IMsoTrendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.IMsoTrendline.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTrendline;
				return newObject;
			}
		}

		#endregion

        #region IEnumerable<NetOffice.OfficeApi.IMsoTrendline> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Office, 12,14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
        public IEnumerator<NetOffice.OfficeApi.IMsoTrendline> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.IMsoTrendline item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Office, 12,14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}