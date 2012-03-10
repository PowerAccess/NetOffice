//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// Interface IEnumOleUndoUnits SupportByLibraryAttribute OWC10, 1
	///</summary>
	[SupportByLibraryAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IEnumOleUndoUnits : COMObject
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
                    _type = typeof(IEnumOleUndoUnits);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumOleUndoUnits(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumOleUndoUnits(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumOleUndoUnits(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumOleUndoUnits() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumOleUndoUnits(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		/// <param name="rgElt">NetOffice.OWC10Api.IOleUndoUnit rgElt</param>
		/// <param name="pcEltFetched">Int32 pcEltFetched</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 RemoteNext(Int32 cElt, out NetOffice.OWC10Api.IOleUndoUnit rgElt, out Int32 pcEltFetched)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			rgElt = null;
			pcEltFetched = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(cElt, rgElt, pcEltFetched);
			object returnItem = Invoker.MethodReturn(this, "RemoteNext", paramsArray);
			rgElt = (NetOffice.OWC10Api.IOleUndoUnit)paramsArray[1];
			pcEltFetched = (Int32)paramsArray[2];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 Skip(Int32 cElt)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cElt);
			object returnItem = Invoker.MethodReturn(this, "Skip", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 Reset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Reset", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="ppEnum">NetOffice.OWC10Api.IEnumOleUndoUnits ppEnum</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 Clone(out NetOffice.OWC10Api.IEnumOleUndoUnits ppEnum)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			ppEnum = null;
			object[] paramsArray = Invoker.ValidateParamsArray(ppEnum);
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			ppEnum = (NetOffice.OWC10Api.IEnumOleUndoUnits)paramsArray[0];
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}