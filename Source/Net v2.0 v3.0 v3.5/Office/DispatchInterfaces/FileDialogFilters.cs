//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface FileDialogFilters SupportByLibrary OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF10","OF11","OF12","OF14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FileDialogFilters : _IMsoDispObj ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialogFilters(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialogFilters(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialogFilters(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialogFilters()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
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
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
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
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.FileDialogFilter Item(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			NetOffice.OfficeApi.FileDialogFilter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.FileDialogFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="filter">optional object filter</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void Delete(object filter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filter);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Description">string Description</param>
		/// <param name="Extensions">string Extensions</param>
		/// <param name="Position">optional object Position</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.FileDialogFilter Add(string description, string extensions, object position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(description, extensions, position);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.FileDialogFilter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.FileDialogFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Description">string Description</param>
		/// <param name="Extensions">string Extensions</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.FileDialogFilter Add(string description, string extensions)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(description, extensions);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.FileDialogFilter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.FileDialogFilter;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("OF10","OF11","OF12","OF14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
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