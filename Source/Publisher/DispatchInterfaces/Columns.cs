﻿using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.PublisherApi
{
	///<summary>
	/// DispatchInterface Columns 
	/// SupportByVersion Publisher, 14,15,16
	///</summary>
	[SupportByVersionAttribute("Publisher", 14,15,16)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Columns : COMObject ,IEnumerable<NetOffice.PublisherApi.Column>
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
                    _type = typeof(Columns);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Columns(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public NetOffice.PublisherApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PublisherApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PublisherApi.Application.LateBindingApiWrapperType) as NetOffice.PublisherApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				ICOMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// 
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PublisherApi.Column this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PublisherApi.Column newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PublisherApi.Column.LateBindingApiWrapperType) as NetOffice.PublisherApi.Column;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// 
		/// </summary>
		/// <param name="beforeColumn">optional Int32 BeforeColumn = -1</param>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public NetOffice.PublisherApi.Column Add(object beforeColumn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(beforeColumn);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PublisherApi.Column newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PublisherApi.Column.LateBindingApiWrapperType) as NetOffice.PublisherApi.Column;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// 
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public NetOffice.PublisherApi.Column Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PublisherApi.Column newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PublisherApi.Column.LateBindingApiWrapperType) as NetOffice.PublisherApi.Column;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.PublisherApi.Column> Member
        
        /// <summary>
		/// SupportByVersionAttribute Publisher, 14,15,16
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
       public IEnumerator<NetOffice.PublisherApi.Column> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.PublisherApi.Column item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Publisher, 14,15,16
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}