//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface SharedWorkspaceFile SupportByLibraryAttribute Office, 11,12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SharedWorkspaceFile : _IMsoDispObj
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
                    _type = typeof(SharedWorkspaceFile);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFile(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFile(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFile(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFile() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFile(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public string URL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "URL", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public string CreatedBy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CreatedBy", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public object CreatedDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CreatedDate", paramsArray);
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
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public string ModifiedBy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ModifiedBy", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public object ModifiedDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ModifiedDate", paramsArray);
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
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}