//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.MSProjectApi
{
	///<summary>
	/// DispatchInterface Window SupportByLibraryAttribute MSProject, 12,14
	///</summary>
	[SupportByLibraryAttribute("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Window : COMObject
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
                    _type = typeof(Window);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Enums.PjWindowState WindowState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WindowState", paramsArray);
				return (NetOffice.MSProjectApi.Enums.PjWindowState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WindowState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public Int32 Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public Int32 Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.MSProjectApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Application.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
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
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public object Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Pane ActivePane
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActivePane", paramsArray);
				NetOffice.MSProjectApi.Pane newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Pane.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Pane;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Pane TopPane
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TopPane", paramsArray);
				NetOffice.MSProjectApi.Pane newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Pane.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Pane;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Pane BottomPane
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BottomPane", paramsArray);
				NetOffice.MSProjectApi.Pane newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Pane.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Pane;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public void Activate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Activate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSHTMLApi.IHTMLDocument2 WebBrowserControlWindow()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "WebBrowserControlWindow", paramsArray);
			NetOffice.MSHTMLApi.IHTMLDocument2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSHTMLApi.IHTMLDocument2.LateBindingApiWrapperType) as NetOffice.MSHTMLApi.IHTMLDocument2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		/// <param name="FrameName">object FrameName</param>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public NetOffice.MSHTMLApi.IHTMLDocument2 WebBrowserControlFrame(object frameName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(frameName);
			object returnItem = Invoker.MethodReturn(this, "WebBrowserControlFrame", paramsArray);
			NetOffice.MSHTMLApi.IHTMLDocument2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSHTMLApi.IHTMLDocument2.LateBindingApiWrapperType) as NetOffice.MSHTMLApi.IHTMLDocument2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}