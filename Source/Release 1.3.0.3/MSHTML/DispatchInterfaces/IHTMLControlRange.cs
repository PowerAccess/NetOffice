//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IHTMLControlRange SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IHTMLControlRange : COMObject
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
                    _type = typeof(IHTMLControlRange);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLControlRange(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLControlRange(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLControlRange(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLControlRange() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLControlRange(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 length
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "length", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="item">NetOffice.MSHTMLApi.IHTMLControlElement item</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void add(NetOffice.MSHTMLApi.IHTMLControlElement item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			Invoker.Method(this, "add", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void remove(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "remove", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLElement item(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "item", paramsArray);
			NetOffice.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLElement;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="varargStart">optional object varargStart</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void scrollIntoView(object varargStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varargStart);
			Invoker.Method(this, "scrollIntoView", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void scrollIntoView()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "scrollIntoView", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool queryCommandSupported(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandSupported", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool queryCommandEnabled(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandEnabled", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool queryCommandState(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandState", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool queryCommandIndeterm(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandIndeterm", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string queryCommandText(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandText", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object queryCommandValue(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandValue", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		/// <param name="showUI">bool showUI</param>
		/// <param name="value">optional object value</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool execCommand(string cmdID, bool showUI, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID, showUI, value);
			object returnItem = Invoker.MethodReturn(this, "execCommand", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		/// <param name="showUI">bool showUI</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool execCommand(string cmdID, bool showUI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID, showUI);
			object returnItem = Invoker.MethodReturn(this, "execCommand", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool execCommandShowHelp(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "execCommandShowHelp", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLElement commonParentElement()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "commonParentElement", paramsArray);
			NetOffice.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLElement;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}