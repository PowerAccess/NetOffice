//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Effect SupportByLibraryAttribute PowerPoint, 10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Effect : COMObject
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
                    _type = typeof(Effect);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Effect(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Effect(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Effect(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Effect() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Effect(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
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
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Shape Shape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shape", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Shape", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Timing Timing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Timing", paramsArray);
				NetOffice.PowerPointApi.Timing newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Timing.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Timing;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.MsoAnimEffect EffectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EffectType", paramsArray);
				return (NetOffice.PowerPointApi.Enums.MsoAnimEffect)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EffectType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.EffectParameters EffectParameters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EffectParameters", paramsArray);
				NetOffice.PowerPointApi.EffectParameters newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.EffectParameters.LateBindingApiWrapperType) as NetOffice.PowerPointApi.EffectParameters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public Int32 TextRangeStart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextRangeStart", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public Int32 TextRangeLength
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextRangeLength", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public Int32 Paragraph
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Paragraph", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Paragraph", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public string DisplayName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Exit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Exit", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Exit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.AnimationBehaviors Behaviors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Behaviors", paramsArray);
				NetOffice.PowerPointApi.AnimationBehaviors newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.AnimationBehaviors.LateBindingApiWrapperType) as NetOffice.PowerPointApi.AnimationBehaviors;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.EffectInformation EffectInformation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EffectInformation", paramsArray);
				NetOffice.PowerPointApi.EffectInformation newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.EffectInformation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.EffectInformation;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="toPos">Int32 toPos</param>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public void MoveTo(Int32 toPos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(toPos);
			Invoker.Method(this, "MoveTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Effect">NetOffice.PowerPointApi.Effect Effect</param>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public void MoveBefore(NetOffice.PowerPointApi.Effect effect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effect);
			Invoker.Method(this, "MoveBefore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Effect">NetOffice.PowerPointApi.Effect Effect</param>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public void MoveAfter(NetOffice.PowerPointApi.Effect effect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effect);
			Invoker.Method(this, "MoveAfter", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}