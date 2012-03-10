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
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface IImages SupportByLibraryAttribute MSComctlLib, 2
	///</summary>
	[SupportByLibraryAttribute("MSComctlLib", 2)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IImages : COMObject ,IEnumerable<NetOffice.MSComctlLibApi.IImage>
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
                    _type = typeof(IImages);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImages(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImages(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImages(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImages() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImages(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public Int16 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Count", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.IImage get_ControlDefault(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ControlDefault", paramsArray);
			NetOffice.MSComctlLibApi.IImage newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IImage;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public void set_ControlDefault(object index, NetOffice.MSComctlLibApi.IImage value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.PropertySet(this, "ControlDefault", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.MSComctlLibApi.IImage this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.MSComctlLibApi.IImage newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IImage;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="Key">optional object Key</param>
		/// <param name="Picture">optional object Picture</param>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.IImage Add(object index, object key, object picture)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, key, picture);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IImage newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IImage;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.IImage Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IImage newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IImage;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.IImage Add(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IImage newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IImage;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="Key">optional object Key</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.IImage Add(object index, object key)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, key);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IImage newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IImage;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public void Remove(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion

        #region IEnumerable<NetOffice.MSComctlLibApi.IImage> Member
		
		/// <summary>
		/// SupportByLibraryAttribute MSComctlLib, 2
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
        public IEnumerator<NetOffice.MSComctlLibApi.IImage> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.MSComctlLibApi.IImage item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute MSComctlLib, 2
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
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