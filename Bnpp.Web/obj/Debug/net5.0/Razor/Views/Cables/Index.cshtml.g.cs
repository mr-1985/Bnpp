#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9534e15512dd2f565db6690684ae02c556bda144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cables_Index), @"mvc.1.0.view", @"/Views/Cables/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9534e15512dd2f565db6690684ae02c556bda144", @"/Views/Cables/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Cables_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.Core.ViewModels.CableListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dcontent"">
    <div style=""margin-top: 10px; background-color: #6b8d9e; padding-top: 5px; padding-bottom: 5px; padding-right: 10px; border-radius: 5px; border: solid 1px #cccccc; background: repeating-linear-gradient(-45deg, #7fa1b3, #6b8d9e 1px, #6b8d9e 1px, #6b8d9e 20px);"">
        &nbsp;
    </div>
    <div style=""border-radius: 5px; margin-top: 5px; margin-bottom: 5px; padding: 15px; border: solid 1px #cea001; background-color: #ffe100;"">
        <table cellpadding=""3"" cellspacing=""0"">
            <tbody>
                <tr>
                    <td");
            BeginWriteAttribute("style", " style=\"", 730, "\"", 738, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b>\r\n                            <a class=\"breadcumb2-link\" href=\"/DataEntry\">Main</a>\r\n                        </b>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 934, "\"", 942, 0);
            EndWriteAttribute();
            WriteLiteral(@"> » <b style=""color: #ff0000;""><a class=""breadcumb2-link"" href=""/Electrical"">Electrical Equipments</a></b></td>
                </tr>
            </tbody>
        </table><a id=""iHelp"" style=""float: right; position: relative; top: -32px;"" href=""javascript:;"" onclick=""showHelp();""><img src=""/images/help.png"" style=""width: 48px;"" class=""imgHelp""></a>
    </div>

    <h1>Cables</h1>

    <a class=""btn-new-equip"" href=""/Cables/CreateNewCables"">New</a>
    <input type=""button"" value=""Back"" onclick=""location='/Electrical'"" class=""butn-cancel"" style=""direction: ltr; text-align: left;"">
    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
    <br />
");
#nullable restore
#line 32 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
      
        int rowCount = 1;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table id=""myTable"" cellpadding=""3"" cellspacing=""0"" class=""show-table"">
        <thead>
            <tr role=""row"">
                <th>
                    <input type=""checkbox"" id=""checkAll"" />
                </th>
                <th></th>
                <th style=""width: 150px"">
                    <b>Date</b>
                </th>
                <th style=""width: 250px"">
                    <b>Cable Name</b>
                </th>
                <th style=""width: 120px"">
                    <b>AKZ Serial</b>
                </th>
                <th style=""width: 120px"">
                    <b>Instalation Position</b>
                </th>
                <th style=""width: 120px"">
                    <b>Actions</b>
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 60 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr role=\"row\">\r\n                    <td>\r\n                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2687, "\"", 2708, 1);
#nullable restore
#line 64 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
WriteAttributeValue("", 2695, item.CableId, 2695, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
                   Write(item.CreateDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
                   Write(item.Azk);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
                   Write(item.InstalationPosition);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("href", " href=\"", 3303, "\"", 3342, 2);
            WriteAttributeValue("", 3310, "/Cables/EditCables/", 3310, 19, true);
#nullable restore
#line 82 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
WriteAttributeValue("", 3329, item.CableId, 3329, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 86 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Cables\Index.cshtml"
                rowCount++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <br>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script src=""/js/jquery.min.js""></script>

    <script src=""/js/datatables.min.js""></script>

</script>

<script>
    $(document).ready(function() {
        $(""#myTable"").DataTable();
    });
</script>

<script>
    $(""#checkAll"").click(function() {
        $("".checkBox"").prop('checked',
            $(this).prop('checked'));
    });

    $(""#delete"").click(function() {
        var selectedIDs = new Array();

        $('input:checkbox.checkBox').each(function() {
            if ($(this).prop('checked')) {
                selectedIDs.push($(this).val());
            }
        });

         var result = confirm(""are you sure you want to delete?"");
        if (result) {

        $.ajax({
            type: ""POST"",
            url: ""/Cables/DeleteCable"",
            data: { ""cableId"": selectedIDs },



            success: function(response) {
                window.location.href =""/Cables"";
            },
            failure: function(response) {
                ale");
                WriteLiteral("rt(response.responseText);\r\n            },\r\n            error: function(response) {\r\n                alert(response.responseText);\r\n            }\r\n\r\n        });\r\n        }\r\n\r\n    });\r\n</script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.Core.ViewModels.CableListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
