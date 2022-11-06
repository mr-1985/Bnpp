#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00df06228d406bc57dd84479e4b026a640592ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operational_SensorDocument), @"mvc.1.0.view", @"/Views/Operational/SensorDocument.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00df06228d406bc57dd84479e4b026a640592ec9", @"/Views/Operational/SensorDocument.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Operational_SensorDocument : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.InspectionDocument>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
  
    ViewData["Title"] = "SensorDocument";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""tab1"" class=""tab-item"" style=""display: block;"">

    <h1 id=""iH1"">Operational Data - Sensors - Sensor Positions</h1>

    <div>

        <div id=""iLoading22"" style=""display: none;"">
            <img src=""/images/loading.gif"">
        </div>


        <a class=""btn-new-equip"" style=""cursor: pointer"" onclick=""CreateSensorDocuments()"">New</a>
        <input type=""button"" id=""deleteProgram"" class=""btn-delete-equip"" value=""Delete"">
        <input type=""button"" onclick=""showPage1()"" value=""Back"" id=""Button2"" class=""butn-cancel"" style=""direction: ltr; text-align: left;"">
        <br />
");
#nullable restore
#line 23 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
          
            int rowCount = 1;
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table id=""myTableDocument"" cellpadding=""3"" cellspacing=""0"" class=""show-table"">
            <thead>
                <tr role=""row"">
                    <th>
                        <input type=""checkbox"" id=""checkAllPrograms"" />
                    </th>
                    <th></th>
                    <th style=""width: 150px"">
                        <b>Code</b>
                    </th>
                    <th style=""width: 250px"">
                        <b>File Name</b>
                    </th>

                    <th style=""width: 120px"">
                        <b> Name </b>
                    </th>

");
            WriteLiteral("\r\n                    <th style=\"width: 120px\">\r\n                        <b>Actions</b>\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 57 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr role=\"row\">\r\n                        <td>\r\n                            <input type=\"checkbox\" class=\"checkBoxProgram\"");
            BeginWriteAttribute("value", " value=\"", 2086, "\"", 2112, 1);
#nullable restore
#line 61 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
WriteAttributeValue("", 2094, item.InspectionId, 2094, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 64 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
                       Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 68 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
                       Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
                       Write(item.Filename);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
                       Write(item.DocumentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2649, "\"", 2698, 3);
            WriteAttributeValue("", 2659, "EditSensorDocuments(", 2659, 20, true);
#nullable restore
#line 77 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
WriteAttributeValue("", 2679, item.InspectionId, 2679, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2697, ")", 2697, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Edit\r\n                            </a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\SensorDocument.cshtml"
                    rowCount++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n        <br>\r\n        <div style=\"clear: both;\">\r\n        </div>\r\n        <br>\r\n        <br>\r\n        <iframe style=\"display: none\" id=\"if_-2_119\"");
            BeginWriteAttribute("src", " src=\"", 3074, "\"", 3080, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>

    </div>

</div>

<script src=""/js/jquery.min.js""></script>
<script src=""/js/jquery.unobtrusive-ajax.min.js""></script>


<script src=""/js/datatables.min.js""></script>


<script>
    $(document).ready(function () {
        $(""#myTableDocument"").DataTable();
    });
</script>
<script>
    function CreateSensorDocuments() {
        $(""#newPage"").load(""/Operational/CreateSensorDocument/"");
    }

    function EditSensorDocuments(id) {
        $(""#newPage"").load(""/Operational/EditSensorDocument/"" + id);
    }

    $(""#checkAllPrograms"").click(function () {
        $("".checkBoxProgram"").prop('checked',
            $(this).prop('checked'));
    });

    $(""#deleteProgram"").click(function () {
        var selectedIDs = new Array();

        $('input:checkbox.checkBoxProgram').each(function () {
            if ($(this).prop('checked')) {
                selectedIDs.push($(this).val());
            }
        });

        var result = confirm(""are you sure you want ");
            WriteLiteral(@"to delete?"");
        if (result) {
            $.ajax({
                type: ""POST"",
                url: ""/Operational/DeleteSensorDocument"",
                data: { ""sensorId"": selectedIDs },

                success: function (response) {
                    $(""#newPage"").load(""/Operational/SensorDocument/"");
                },
                failure: function (response) {
                    alert(response.responseText);
                },
                error: function (response) {
                    alert(response.responseText);
                }

            });
        }

    });
</script>
                         ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.InspectionDocument>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
