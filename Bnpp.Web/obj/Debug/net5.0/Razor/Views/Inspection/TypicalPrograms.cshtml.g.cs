#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\TypicalPrograms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22808f72eecb1b2c0284ec80341dd07be61704fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inspection_TypicalPrograms), @"mvc.1.0.view", @"/Views/Inspection/TypicalPrograms.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22808f72eecb1b2c0284ec80341dd07be61704fd", @"/Views/Inspection/TypicalPrograms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Inspection_TypicalPrograms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\TypicalPrograms.cshtml"
  
    ViewData["Title"] = "TypicalPrograms";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""bevel-box"">
                <div id=""newPage"">
                    <div>

                        <div id=""iLoading22"" style=""display: none;"">
                            <img src=""/images/loading.gif"">
                        </div>

            <h1>Typical Programs</h1>

                        <a class=""btn-new-equip"" onclick=""Create()"">New</a>
                        <input type=""button"" ");
            WriteLiteral(" class=\"btn-delete-equip\" value=\"Delete\">\r\n                        <br />\r\n");
#nullable restore
#line 20 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\TypicalPrograms.cshtml"
                          
                            int rowCount = 1;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table id=""myTable"" cellpadding=""3"" cellspacing=""0"" class=""show-table"">
                            <thead>
                            <tr role=""row"">
                                <th>
                                    <input type=""checkbox"" id=""checkAll"" />
                                </th>
                                <th></th>
                                <th style=""width: 150px"">
                                    <b>Type</b>
                                </th>
                                <th style=""width: 250px"">
                                    <b>Date</b>
                                </th>
                                <th style=""width: 120px"">
                                    <b>Frequency</b>
                                </th>
                                <th style=""width: 120px"">
                                    <b>Prepaired by</b>
                                </th>

                                <th style=""wi");
            WriteLiteral(@"dth: 120px"">
                                    <b>	Approved</b>
                                </th>
                                <th style=""width: 120px"">
                                    <b>	Authorized</b>
                                </th>

                                <th style=""width: 120px"">
                                    <b>Actions</b>
                                </th>
                            </tr>
                            </thead>
                            <tbody>
");
            WriteLiteral(@"                            </tbody>
                        </table>


                        <br>
                        <div style=""clear: both;"">
                        </div>
                        <br>
                        <br>
                        <iframe style=""display: none"" id=""if_-2_119""");
            BeginWriteAttribute("src", " src=\"", 3908, "\"", 3914, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
