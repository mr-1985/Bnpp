#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Electrical\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd3a3485d4a096db526d0e228d4b50c8ff8fe85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Electrical_Index), @"mvc.1.0.view", @"/Views/Electrical/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd3a3485d4a096db526d0e228d4b50c8ff8fe85", @"/Views/Electrical/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Electrical_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Electrical\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dcontent"">

    <h1>Bushehr Nuclear Power Plant<br>Aging Management Data Bank</h1>
    <table cellpadding=""3"" cellspacing=""0"" class=""icon-table"">
        <tbody>
            <tr>
                <td style=""width: 300px;"">
                    <a href=""Cables"">Cabels</a>
                </td>
            </tr>
            <tr style=""background-color: #f7f7f7;"">
                <td>
                    <a href=""Electromotors"">
                        Electromotors
                    </a>
                </td>
            </tr>
            <tr>
                <td>
                    <a href=""Generator"">
                        Generators
                    </a>
                </td>
            </tr>
            <tr style=""background-color: #f7f7f7;"">
                <td>
                    <a href=""Transformer"">
                        Transformers
                    </a>
                </td>
            </tr>
            <tr>
                <td>
           ");
            WriteLiteral(@"         <a href=""Valves"">
                        Electrovalves
                    </a>
                </td>
            </tr>
            <tr style=""background-color: #f7f7f7;"">
                <td>
                    <a href=""Diesel"">
                        Diesel Generators
                    </a>
                </td>
            </tr>
        </tbody>
    </table>
    <br>
    <input type=""button"" value=""New""");
            BeginWriteAttribute("onclick", " onclick=\"", 1550, "\"", 1560, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"butn-new\" style=\"direction: ltr; text-align: left;\">\r\n    &nbsp;\r\n    <input type=\"button\" value=\"Back\" onclick=\"location=\'/DataEntry\'\" class=\"butn-cancel\" style=\"direction: ltr; text-align: left;\">\r\n    &nbsp;\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
