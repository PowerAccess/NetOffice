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
	/// DispatchInterface CalculatedMembers SupportByLibraryAttribute Excel, 10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CalculatedMembers : COMObject ,IEnumerable<NetOffice.ExcelApi.CalculatedMember>
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
                    _type = typeof(CalculatedMembers);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
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
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
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
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
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
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
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
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.CalculatedMember this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.CalculatedMember get__Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Formula">string Formula</param>
		/// <param name="SolveOrder">optional object SolveOrder</param>
		/// <param name="Type">optional object Type</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, string formula, object solveOrder, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Formula">object Formula</param>
		/// <param name="SolveOrder">optional object SolveOrder</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Dynamic">optional object Dynamic</param>
		/// <param name="DisplayFolder">optional object DisplayFolder</param>
		/// <param name="HierarchizeDistinct">optional object HierarchizeDistinct</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, object formula, object solveOrder, object type, object dynamic, object displayFolder, object hierarchizeDistinct)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type, dynamic, displayFolder, hierarchizeDistinct);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Formula">string Formula</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, string formula)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Formula">string Formula</param>
		/// <param name="SolveOrder">optional object SolveOrder</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, string formula, object solveOrder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Formula">object Formula</param>
		/// <param name="SolveOrder">optional object SolveOrder</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Dynamic">optional object Dynamic</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, object formula, object solveOrder, object type, object dynamic)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type, dynamic);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Formula">object Formula</param>
		/// <param name="SolveOrder">optional object SolveOrder</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Dynamic">optional object Dynamic</param>
		/// <param name="DisplayFolder">optional object DisplayFolder</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, object formula, object solveOrder, object type, object dynamic, object displayFolder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type, dynamic, displayFolder);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Formula">string Formula</param>
		/// <param name="SolveOrder">optional object SolveOrder</param>
		/// <param name="Type">optional object Type</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember _Add(string name, string formula, object solveOrder, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Formula">string Formula</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember _Add(string name, string formula)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Formula">string Formula</param>
		/// <param name="SolveOrder">optional object SolveOrder</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember _Add(string name, string formula, object solveOrder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		#endregion

        #region IEnumerable<NetOffice.ExcelApi.CalculatedMember> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Excel, 10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
        public IEnumerator<NetOffice.ExcelApi.CalculatedMember> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.CalculatedMember item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Excel, 10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
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