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
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface Fields SupportByLibraryAttribute ADODB, 2.1,2.5
	///</summary>
	[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Fields : Fields20 ,IEnumerable<NetOffice.ADODBApi.Field>
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
                    _type = typeof(Fields);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Fields(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Fields(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Fields(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Fields() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Fields(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
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
		/// SupportByLibrary ADODB 2.5
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ADODBApi.Field this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ADODBApi.Field newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ADODBApi.Field.LateBindingApiWrapperType) as NetOffice.ADODBApi.Field;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.ADODBApi.Enums.DataTypeEnum Type</param>
		/// <param name="DefinedSize">Int32 DefinedSize</param>
		/// <param name="Attrib">NetOffice.ADODBApi.Enums.FieldAttributeEnum Attrib</param>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
		public void Append(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, Int32 definedSize, NetOffice.ADODBApi.Enums.FieldAttributeEnum attrib)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, definedSize, attrib);
			Invoker.Method(this, "Append", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.ADODBApi.Enums.DataTypeEnum Type</param>
		/// <param name="DefinedSize">Int32 DefinedSize</param>
		/// <param name="Attrib">NetOffice.ADODBApi.Enums.FieldAttributeEnum Attrib</param>
		/// <param name="FieldValue">optional object FieldValue</param>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public void Append(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, Int32 definedSize, NetOffice.ADODBApi.Enums.FieldAttributeEnum attrib, object fieldValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, definedSize, attrib, fieldValue);
			Invoker.Method(this, "Append", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("ADODB", 2.1)]
		public void Delete(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="ResyncValues">NetOffice.ADODBApi.Enums.ResyncEnum ResyncValues</param>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public void Resync(NetOffice.ADODBApi.Enums.ResyncEnum resyncValues)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(resyncValues);
			Invoker.Method(this, "Resync", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public void CancelUpdate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CancelUpdate", paramsArray);
		}

		#endregion

        #region IEnumerable<NetOffice.ADODBApi.Field> Member
		
		/// <summary>
		/// SupportByLibraryAttribute ADODB, 2.1,2.5
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
        public IEnumerator<NetOffice.ADODBApi.Field> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ADODBApi.Field item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute ADODB, 2.1,2.5
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
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