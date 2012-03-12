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
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface TextRange2 
	/// SupportByLibrary Office, 12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TextRange2 : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.TextRange2>
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
                    _type = typeof(TextRange2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
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
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
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
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		/// <param name="Start">optional Int32 Start</param>
		/// <param name="Length">optional Int32 Length</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 get_Paragraphs(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Paragraphs", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Paragraphs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Paragraphs", paramsArray);
				NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		/// <param name="Start">optional Int32 Start</param>
		/// <param name="Length">optional Int32 Length</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 get_Sentences(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Sentences", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Sentences
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sentences", paramsArray);
				NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		/// <param name="Start">optional Int32 Start</param>
		/// <param name="Length">optional Int32 Length</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 get_Words(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Words", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Words
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Words", paramsArray);
				NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		/// <param name="Start">optional Int32 Start</param>
		/// <param name="Length">optional Int32 Length</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 get_Characters(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Characters", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Characters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Characters", paramsArray);
				NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		/// <param name="Start">optional Int32 Start</param>
		/// <param name="Length">optional Int32 Length</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 get_Lines(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Lines", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Lines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Lines", paramsArray);
				NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		/// <param name="Start">optional Int32 Start</param>
		/// <param name="Length">optional Int32 Length</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 get_Runs(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "Runs", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Runs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Runs", paramsArray);
				NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.ParagraphFormat2 ParagraphFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParagraphFormat", paramsArray);
				NetOffice.OfficeApi.ParagraphFormat2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ParagraphFormat2.LateBindingApiWrapperType) as NetOffice.OfficeApi.ParagraphFormat2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Font2 Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				NetOffice.OfficeApi.Font2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.Font2.LateBindingApiWrapperType) as NetOffice.OfficeApi.Font2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public Int32 Length
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Length", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public Int32 Start
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Start", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public Single BoundLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public Single BoundTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundTop", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public Single BoundWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundWidth", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public Single BoundHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundHeight", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoLanguageID LanguageID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageID", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoLanguageID)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LanguageID", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		/// <param name="Start">optional Int32 Start</param>
		/// <param name="Length">optional Int32 Length</param>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.TextRange2 get_MathZones(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.PropertyGet(this, "MathZones", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.TextRange2 MathZones
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MathZones", paramsArray);
				NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.TextRange2 this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 TrimText()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "TrimText", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="newText">optional string NewText = </param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 InsertAfter(string newText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newText);
			object returnItem = Invoker.MethodReturn(this, "InsertAfter", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 InsertAfter()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "InsertAfter", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="newText">optional string NewText = </param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 InsertBefore(string newText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newText);
			object returnItem = Invoker.MethodReturn(this, "InsertBefore", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 InsertBefore()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "InsertBefore", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="fontName">string FontName</param>
		/// <param name="charNumber">Int32 CharNumber</param>
		/// <param name="unicode">optional NetOffice.OfficeApi.Enums.MsoTriState Unicode = 0</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 InsertSymbol(string fontName, Int32 charNumber, NetOffice.OfficeApi.Enums.MsoTriState unicode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fontName, charNumber, unicode);
			object returnItem = Invoker.MethodReturn(this, "InsertSymbol", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="fontName">string FontName</param>
		/// <param name="charNumber">Int32 CharNumber</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 InsertSymbol(string fontName, Int32 charNumber)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fontName, charNumber);
			object returnItem = Invoker.MethodReturn(this, "InsertSymbol", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Paste()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="format">NetOffice.OfficeApi.Enums.MsoClipboardFormat Format</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 PasteSpecial(NetOffice.OfficeApi.Enums.MsoClipboardFormat format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(format);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoTextChangeCase Type</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void ChangeCase(NetOffice.OfficeApi.Enums.MsoTextChangeCase type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			Invoker.Method(this, "ChangeCase", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void AddPeriods()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddPeriods", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void RemovePeriods()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemovePeriods", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="findWhat">string FindWhat</param>
		/// <param name="after">optional Int32 After = 0</param>
		/// <param name="matchCase">optional NetOffice.OfficeApi.Enums.MsoTriState MatchCase = 0</param>
		/// <param name="wholeWords">optional NetOffice.OfficeApi.Enums.MsoTriState WholeWords = 0</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Find(string findWhat, Int32 after, NetOffice.OfficeApi.Enums.MsoTriState matchCase, NetOffice.OfficeApi.Enums.MsoTriState wholeWords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, after, matchCase, wholeWords);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="findWhat">string FindWhat</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Find(string findWhat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="findWhat">string FindWhat</param>
		/// <param name="after">optional Int32 After = 0</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Find(string findWhat, Int32 after)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, after);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="findWhat">string FindWhat</param>
		/// <param name="after">optional Int32 After = 0</param>
		/// <param name="matchCase">optional NetOffice.OfficeApi.Enums.MsoTriState MatchCase = 0</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Find(string findWhat, Int32 after, NetOffice.OfficeApi.Enums.MsoTriState matchCase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, after, matchCase);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="findWhat">string FindWhat</param>
		/// <param name="replaceWhat">string ReplaceWhat</param>
		/// <param name="after">optional Int32 After = 0</param>
		/// <param name="matchCase">optional NetOffice.OfficeApi.Enums.MsoTriState MatchCase = 0</param>
		/// <param name="wholeWords">optional NetOffice.OfficeApi.Enums.MsoTriState WholeWords = 0</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Replace(string findWhat, string replaceWhat, Int32 after, NetOffice.OfficeApi.Enums.MsoTriState matchCase, NetOffice.OfficeApi.Enums.MsoTriState wholeWords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, replaceWhat, after, matchCase, wholeWords);
			object returnItem = Invoker.MethodReturn(this, "Replace", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="findWhat">string FindWhat</param>
		/// <param name="replaceWhat">string ReplaceWhat</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Replace(string findWhat, string replaceWhat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, replaceWhat);
			object returnItem = Invoker.MethodReturn(this, "Replace", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="findWhat">string FindWhat</param>
		/// <param name="replaceWhat">string ReplaceWhat</param>
		/// <param name="after">optional Int32 After = 0</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Replace(string findWhat, string replaceWhat, Int32 after)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, replaceWhat, after);
			object returnItem = Invoker.MethodReturn(this, "Replace", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="findWhat">string FindWhat</param>
		/// <param name="replaceWhat">string ReplaceWhat</param>
		/// <param name="after">optional Int32 After = 0</param>
		/// <param name="matchCase">optional NetOffice.OfficeApi.Enums.MsoTriState MatchCase = 0</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextRange2 Replace(string findWhat, string replaceWhat, Int32 after, NetOffice.OfficeApi.Enums.MsoTriState matchCase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, replaceWhat, after, matchCase);
			object returnItem = Invoker.MethodReturn(this, "Replace", paramsArray);
			NetOffice.OfficeApi.TextRange2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		/// <param name="x2">Single X2</param>
		/// <param name="y2">Single Y2</param>
		/// <param name="x3">Single X3</param>
		/// <param name="y3">Single Y3</param>
		/// <param name="x4">Single x4</param>
		/// <param name="y4">Single y4</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void RotatedBounds(out Single x1, out Single y1, out Single x2, out Single y2, out Single x3, out Single y3, out Single x4, out Single y4)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true);
			x1 = 0;
			y1 = 0;
			x2 = 0;
			y2 = 0;
			x3 = 0;
			y3 = 0;
			x4 = 0;
			y4 = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(x1, y1, x2, y2, x3, y3, x4, y4);
			Invoker.Method(this, "RotatedBounds", paramsArray, modifiers);
			x1 = (Single)paramsArray[0];
			y1 = (Single)paramsArray[1];
			x2 = (Single)paramsArray[2];
			y2 = (Single)paramsArray[3];
			x3 = (Single)paramsArray[4];
			y3 = (Single)paramsArray[5];
			x4 = (Single)paramsArray[6];
			y4 = (Single)paramsArray[7];
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void RtlRun()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RtlRun", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void LtrRun()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "LtrRun", paramsArray);
		}

		#endregion

        #region IEnumerable<NetOffice.OfficeApi.TextRange2> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Office, 12,14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
        public IEnumerator<NetOffice.OfficeApi.TextRange2> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.TextRange2 item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Office, 12,14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
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