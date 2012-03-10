//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.VBIDEApi
{
	///<summary>
	/// DispatchInterface Property SupportByLibraryAttribute VBIDE, 5.3,11,12
	///</summary>
	[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Property : COMObject
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
                    _type = typeof(Property);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Property(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Property(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Property(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Property() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Property(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
		public object Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get/Set
		/// </summary>
		/// <param name="Index1">object Index1</param>
		/// <param name="Index2">optional object Index2</param>
		/// <param name="Index3">optional object Index3</param>
		/// <param name="Index4">optional object Index4</param>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
		public object get_IndexedValue(object index1, object index2, object index3, object index4)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index1, index2, index3, index4);
			object returnItem = Invoker.PropertyGet(this, "IndexedValue", paramsArray);
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
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get/Set
		/// </summary>
		/// <param name="Index1">object Index1</param>
		/// <param name="Index2">optional object Index2</param>
		/// <param name="Index3">optional object Index3</param>
		/// <param name="Index4">optional object Index4</param>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
		public void set_IndexedValue(object index1, object index2, object index3, object index4, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index1, index2, index3, index4);
			Invoker.PropertySet(this, "IndexedValue", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 11, 12, 5.3, 11, 12
		/// Get/Set
		/// </summary>
		/// <param name="Index1">object Index1</param>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12,5.3,11,12)]
		public object get_IndexedValue(object index1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index1);
			object returnItem = Invoker.PropertyGet(this, "IndexedValue", paramsArray);
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
		/// SupportByLibrary VBIDE 5.3, 11, 12, 5.3, 11, 12
		/// Get/Set
		/// </summary>
		/// <param name="Index1">object Index1</param>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12,5.3,11,12)]
		public void set_IndexedValue(object index1, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index1);
			Invoker.PropertySet(this, "IndexedValue", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
		public Int16 NumIndices
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumIndices", paramsArray);
				return (Int16)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
		public NetOffice.VBIDEApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.VBIDEApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
		public NetOffice.VBIDEApi.Properties Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.VBIDEApi.Properties newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.Properties.LateBindingApiWrapperType) as NetOffice.VBIDEApi.Properties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
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
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
		public NetOffice.VBIDEApi.VBE VBE
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VBE", paramsArray);
				NetOffice.VBIDEApi.VBE newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.VBE.LateBindingApiWrapperType) as NetOffice.VBIDEApi.VBE;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
		public NetOffice.VBIDEApi.Properties Collection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Collection", paramsArray);
				NetOffice.VBIDEApi.Properties newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.Properties.LateBindingApiWrapperType) as NetOffice.VBIDEApi.Properties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 11, 12
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("VBIDE", 5.3,11,12)]
		public COMObject Object
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Object", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Object", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}