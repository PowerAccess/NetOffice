//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface List SupportByLibraryAttribute Word, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class List : COMObject
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
                    _type = typeof(List);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public List(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public List(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public List(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public List() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public List(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Range.LateBindingApiWrapperType) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.ListParagraphs ListParagraphs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListParagraphs", paramsArray);
				NetOffice.WordApi.ListParagraphs newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.ListParagraphs.LateBindingApiWrapperType) as NetOffice.WordApi.ListParagraphs;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public bool SingleListTemplate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SingleListTemplate", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public string StyleName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StyleName", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="NumberType">optional object NumberType</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void ConvertNumbersToText(object numberType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numberType);
			Invoker.Method(this, "ConvertNumbersToText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void ConvertNumbersToText()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ConvertNumbersToText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="NumberType">optional object NumberType</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void RemoveNumbers(object numberType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numberType);
			Invoker.Method(this, "RemoveNumbers", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void RemoveNumbers()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemoveNumbers", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="NumberType">optional object NumberType</param>
		/// <param name="Level">optional object Level</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public Int32 CountNumberedItems(object numberType, object level)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numberType, level);
			object returnItem = Invoker.MethodReturn(this, "CountNumberedItems", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public Int32 CountNumberedItems()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CountNumberedItems", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="NumberType">optional object NumberType</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public Int32 CountNumberedItems(object numberType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numberType);
			object returnItem = Invoker.MethodReturn(this, "CountNumberedItems", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="ContinuePreviousList">optional object ContinuePreviousList</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplateOld(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList);
			Invoker.Method(this, "ApplyListTemplateOld", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplateOld(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			Invoker.Method(this, "ApplyListTemplateOld", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdContinue CanContinuePreviousList(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			object returnItem = Invoker.MethodReturn(this, "CanContinuePreviousList", paramsArray);
			return (NetOffice.WordApi.Enums.WdContinue)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="ContinuePreviousList">optional object ContinuePreviousList</param>
		/// <param name="DefaultListBehavior">optional object DefaultListBehavior</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplate(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList, object defaultListBehavior)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, defaultListBehavior);
			Invoker.Method(this, "ApplyListTemplate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplate(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			Invoker.Method(this, "ApplyListTemplate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="ContinuePreviousList">optional object ContinuePreviousList</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplate(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList);
			Invoker.Method(this, "ApplyListTemplate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="ContinuePreviousList">optional object ContinuePreviousList</param>
		/// <param name="DefaultListBehavior">optional object DefaultListBehavior</param>
		/// <param name="ApplyLevel">optional object ApplyLevel</param>
		[SupportByLibraryAttribute("Word", 12,14)]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList, object defaultListBehavior, object applyLevel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, defaultListBehavior, applyLevel);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 12,14)]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="ContinuePreviousList">optional object ContinuePreviousList</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 12,14)]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="ContinuePreviousList">optional object ContinuePreviousList</param>
		/// <param name="DefaultListBehavior">optional object DefaultListBehavior</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 12,14)]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList, object defaultListBehavior)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, defaultListBehavior);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}