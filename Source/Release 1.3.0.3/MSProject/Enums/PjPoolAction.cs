//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary MSProject 12, 14
	 /// </summary>
	[SupportByLibraryAttribute("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjPoolAction
	{
		 /// <summary>
		 /// SupportByLibrary MSProject 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByLibraryAttribute("MSProject", 12,14)]
		 pjPoolTakesPrecedence = 1,

		 /// <summary>
		 /// SupportByLibrary MSProject 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByLibraryAttribute("MSProject", 12,14)]
		 pjSharersTakePrecedence = 2,

		 /// <summary>
		 /// SupportByLibrary MSProject 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByLibraryAttribute("MSProject", 12,14)]
		 pjOpenSharer = 3,

		 /// <summary>
		 /// SupportByLibrary MSProject 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByLibraryAttribute("MSProject", 12,14)]
		 pjOpenAllSharers = 4,

		 /// <summary>
		 /// SupportByLibrary MSProject 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByLibraryAttribute("MSProject", 12,14)]
		 pjUnlinkSharer = 5
	}
}