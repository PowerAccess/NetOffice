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
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface PageFields SupportByLibraryAttribute OWC10, 1
	///</summary>
	[SupportByLibraryAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PageFields : COMObject ,IEnumerable<NetOffice.OWC10Api.PageField>
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
                    _type = typeof(PageFields);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PageFields(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PageFields(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PageFields(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PageFields() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PageFields(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OWC10Api.PageField this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OWC10Api.PageField newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PageField.LateBindingApiWrapperType) as NetOffice.OWC10Api.PageField;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public void Delete(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="FieldType">object FieldType</param>
		/// <param name="Name">object Name</param>
		/// <param name="TotalType">NetOffice.OWC10Api.Enums.DscTotalTypeEnum TotalType</param>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PageField Add(object source, object fieldType, object name, NetOffice.OWC10Api.Enums.DscTotalTypeEnum totalType, object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, fieldType, name, totalType, index);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OWC10Api.PageField newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.PageField.LateBindingApiWrapperType) as NetOffice.OWC10Api.PageField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="FieldType">object FieldType</param>
		/// <param name="Name">object Name</param>
		/// <param name="TotalType">NetOffice.OWC10Api.Enums.DscTotalTypeEnum TotalType</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PageField Add(object source, object fieldType, object name, NetOffice.OWC10Api.Enums.DscTotalTypeEnum totalType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, fieldType, name, totalType);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OWC10Api.PageField newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.PageField.LateBindingApiWrapperType) as NetOffice.OWC10Api.PageField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="FieldType">object FieldType</param>
		/// <param name="Name">object Name</param>
		/// <param name="TotalType">NetOffice.OWC10Api.Enums.DscTotalTypeEnum TotalType</param>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PageField AddBroken(object source, object fieldType, object name, NetOffice.OWC10Api.Enums.DscTotalTypeEnum totalType, object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, fieldType, name, totalType, index);
			object returnItem = Invoker.MethodReturn(this, "AddBroken", paramsArray);
			NetOffice.OWC10Api.PageField newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.PageField.LateBindingApiWrapperType) as NetOffice.OWC10Api.PageField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="FieldType">object FieldType</param>
		/// <param name="Name">object Name</param>
		/// <param name="TotalType">NetOffice.OWC10Api.Enums.DscTotalTypeEnum TotalType</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PageField AddBroken(object source, object fieldType, object name, NetOffice.OWC10Api.Enums.DscTotalTypeEnum totalType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, fieldType, name, totalType);
			object returnItem = Invoker.MethodReturn(this, "AddBroken", paramsArray);
			NetOffice.OWC10Api.PageField newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.PageField.LateBindingApiWrapperType) as NetOffice.OWC10Api.PageField;
			return newObject;
		}

		#endregion

        #region IEnumerable<NetOffice.OWC10Api.PageField> Member
		
		/// <summary>
		/// SupportByLibraryAttribute OWC10, 1
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
        public IEnumerator<NetOffice.OWC10Api.PageField> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OWC10Api.PageField item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute OWC10, 1
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
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