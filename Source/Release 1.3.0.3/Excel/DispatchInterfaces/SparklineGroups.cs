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
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface SparklineGroups SupportByLibraryAttribute Excel, 14
	///</summary>
	[SupportByLibraryAttribute("Excel", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SparklineGroups : COMObject ,IEnumerable<NetOffice.ExcelApi.SparklineGroup>
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
                    _type = typeof(SparklineGroups);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
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
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
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
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.SparklineGroup this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ExcelApi.SparklineGroup newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SparklineGroup.LateBindingApiWrapperType) as NetOffice.ExcelApi.SparklineGroup;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.SparklineGroup get__Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.SparklineGroup newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SparklineGroup.LateBindingApiWrapperType) as NetOffice.ExcelApi.SparklineGroup;
			return newObject;
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Type">NetOffice.ExcelApi.Enums.XlSparkType Type</param>
		/// <param name="SourceData">string SourceData</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.SparklineGroup Add(NetOffice.ExcelApi.Enums.XlSparkType type, string sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, sourceData);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.SparklineGroup newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.SparklineGroup.LateBindingApiWrapperType) as NetOffice.ExcelApi.SparklineGroup;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
		public void ClearGroups()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearGroups", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Location">NetOffice.ExcelApi.Range Location</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public void Group(NetOffice.ExcelApi.Range location)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(location);
			Invoker.Method(this, "Group", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
		public void Ungroup()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Ungroup", paramsArray);
		}

		#endregion

        #region IEnumerable<NetOffice.ExcelApi.SparklineGroup> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Excel, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
        public IEnumerator<NetOffice.ExcelApi.SparklineGroup> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.SparklineGroup item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Excel, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
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