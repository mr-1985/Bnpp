#pragma checksum "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Maintenance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84c4f7702b41eaeca0e318a576ea2ade4bcf0773"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maintenance_Index), @"mvc.1.0.view", @"/Views/Maintenance/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c4f7702b41eaeca0e318a576ea2ade4bcf0773", @"/Views/Maintenance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Maintenance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Maintenance\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"Tabs\">\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/js/jquery.unobtrusive-ajax.min.js""></script>
    <script>

    $( document ).ready(function() {
        $(""#Tabs"").load(""/Maintenance/MaintenancePrograms/"");
    });

     function showPage1() {
        $(""#Tabs"").load(""/Maintenance/MaintenancePrograms/"");
    }

    function showPage2() {
        $(""#Tabs"").load(""/Maintenance/Defections/"");
    }

    function showPage3() {
        $(""#Tabs"").load(""/Maintenance/SpareParts/"");
    }
    
    function showPage4() {
        $(""#Tabs"").load(""/Maintenance/MaintenanceForms/"");
    }
    
    function showPage5() {
        $(""#Tabs"").load(""/Maintenance/Measurements/"");
    }
    
     function showPage6() {
        $(""#Tabs"").load(""/Maintenance/DefectsReport"");
    }

    
</script>

");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
