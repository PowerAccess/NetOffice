//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary Excel 11, 12, 14
	 /// </summary>
	[SupportByLibraryAttribute("Excel", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlListObjectSourceType
	{
		 /// <summary>
		 /// SupportByLibrary Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByLibraryAttribute("Excel", 11,12,14)]
		 xlSrcExternal = 0,

		 /// <summary>
		 /// SupportByLibrary Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByLibraryAttribute("Excel", 11,12,14)]
		 xlSrcRange = 1,

		 /// <summary>
		 /// SupportByLibrary Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByLibraryAttribute("Excel", 11,12,14)]
		 xlSrcXml = 2,

		 /// <summary>
		 /// SupportByLibrary Excel 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByLibraryAttribute("Excel", 12,14)]
		 xlSrcQuery = 3
	}
}