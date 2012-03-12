//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{

	#region Delegates

	#pragma warning disable
	public delegate void ImageCombo_ChangeEventHandler();
	public delegate void ImageCombo_DropdownEventHandler();
	public delegate void ImageCombo_ClickEventHandler();
	public delegate void ImageCombo_KeyDownEventHandler(Int16 KeyCode, Int16 Shift);
	public delegate void ImageCombo_KeyUpEventHandler(Int16 KeyCode, Int16 Shift);
	public delegate void ImageCombo_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void ImageCombo_OLEStartDragEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 AllowedEffects);
	public delegate void ImageCombo_OLEGiveFeedbackEventHandler(ref Int32 Effect, ref bool DefaultCursors);
	public delegate void ImageCombo_OLESetDataEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int16 DataFormat);
	public delegate void ImageCombo_OLECompleteDragEventHandler(ref Int32 Effect);
	public delegate void ImageCombo_OLEDragOverEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y, ref Int16 State);
	public delegate void ImageCombo_OLEDragDropEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass ImageCombo 
	/// SupportByLibrary MSComctlLib, 2
	///</summary>
	[SupportByLibraryAttribute("MSComctlLib", 2)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class ImageCombo : IImageCombo, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		DImageComboEvents_SinkHelper _dImageComboEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ImageCombo);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public ImageCombo(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ImageCombo(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ImageCombo(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of ImageCombo 
        /// </summary>		
		public ImageCombo():base("MSComctlLib.ImageCombo")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of ImageCombo
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public ImageCombo(string progId):base(progId)
		{
			
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, DImageComboEvents_SinkHelper.Id);


			if(DImageComboEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dImageComboEvents_SinkHelper = new DImageComboEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_ChangeEventHandler ChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ChangeEvent += value;
			}
			remove
			{
				_ChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_DropdownEventHandler _DropdownEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_DropdownEventHandler DropdownEvent
		{
			add
			{
				CreateEventBridge();
				_DropdownEvent += value;
			}
			remove
			{
				_DropdownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_OLEStartDragEventHandler _OLEStartDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_OLEStartDragEventHandler OLEStartDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLEStartDragEvent += value;
			}
			remove
			{
				_OLEStartDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_OLEGiveFeedbackEventHandler _OLEGiveFeedbackEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_OLEGiveFeedbackEventHandler OLEGiveFeedbackEvent
		{
			add
			{
				CreateEventBridge();
				_OLEGiveFeedbackEvent += value;
			}
			remove
			{
				_OLEGiveFeedbackEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_OLESetDataEventHandler _OLESetDataEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_OLESetDataEventHandler OLESetDataEvent
		{
			add
			{
				CreateEventBridge();
				_OLESetDataEvent += value;
			}
			remove
			{
				_OLESetDataEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_OLECompleteDragEventHandler _OLECompleteDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_OLECompleteDragEventHandler OLECompleteDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLECompleteDragEvent += value;
			}
			remove
			{
				_OLECompleteDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_OLEDragOverEventHandler _OLEDragOverEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_OLEDragOverEventHandler OLEDragOverEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragOverEvent += value;
			}
			remove
			{
				_OLEDragOverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ImageCombo_OLEDragDropEventHandler _OLEDragDropEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ImageCombo_OLEDragDropEventHandler OLEDragDropEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragDropEvent += value;
			}
			remove
			{
				_OLEDragDropEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _dImageComboEvents_SinkHelper)
			{
				_dImageComboEvents_SinkHelper.Dispose();
				_dImageComboEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}