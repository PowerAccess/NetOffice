//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary Outlook 9, 10, 11, 12, 14
	 /// </summary>
	[SupportByLibraryAttribute("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum OlMeetingStatus
	{
		 /// <summary>
		 /// SupportByLibrary Outlook 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByLibraryAttribute("Outlook", 9,10,11,12,14)]
		 olNonMeeting = 0,

		 /// <summary>
		 /// SupportByLibrary Outlook 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByLibraryAttribute("Outlook", 9,10,11,12,14)]
		 olMeeting = 1,

		 /// <summary>
		 /// SupportByLibrary Outlook 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByLibraryAttribute("Outlook", 9,10,11,12,14)]
		 olMeetingReceived = 3,

		 /// <summary>
		 /// SupportByLibrary Outlook 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByLibraryAttribute("Outlook", 9,10,11,12,14)]
		 olMeetingCanceled = 5,

		 /// <summary>
		 /// SupportByLibrary Outlook 12, 14
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByLibraryAttribute("Outlook", 12,14)]
		 olMeetingReceivedAndCanceled = 7
	}
}