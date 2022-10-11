#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5743c683d3ce443fb9aa84f9815a5202907f2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inspection_WorkingPrograms), @"mvc.1.0.view", @"/Views/Inspection/WorkingPrograms.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5743c683d3ce443fb9aa84f9815a5202907f2a", @"/Views/Inspection/WorkingPrograms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Inspection_WorkingPrograms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.WorkingPrograms>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
  
    ViewData["Title"] = "WorkingPrograms";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>

    <div id=""iLoading22"" style=""display: none;"">
        <img src=""/images/loading.gif"">
    </div>

    <h1>Working Programs</h1>

    <a class=""btn-new-equip"" style=""cursor:pointer"" onclick=""Create()"">New</a>
    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
    <br />
");
#nullable restore
#line 18 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
      
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
                    <b>No. of W.P</b>
                </th>
                <th style=""width: 150px"">
                    <b>No. of T.P</b>
                </th>
                <th style=""width: 250px"">
                    <b>equip. Code</b>
                </th>
                <th style=""width: 120px"">
                    <b>Equip. Name</b>
                </th>
                <th style=""width: 120px"">
                    <b>Measuring Type</b>
                </th>

                <th style=""width: 120px"">
                    <b>	Material Compositions</b>
                </th>
                <th style=""width: 120px"">
                    <b>	Weld No.</b>
                </th>
              ");
            WriteLiteral(@"  <th style=""width: 120px"">
                    <b>	Control Method</b>
                </th>
                <th style=""width: 120px"">
                    <b>	Control Percent</b>
                </th>
                <th style=""width: 120px"">
                    <b>	Control Standard</b>
                </th>
                <th style=""width: 120px"">
                    <b>	QC Standard</b>
                </th>
                <th style=""width: 120px"">
                    <b>	Control Results</b>
                </th>
                <th style=""width: 120px"">
                    <b>	Remarks</b>
                </th>

                <th style=""width: 120px"">
                    <b>Actions</b>
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 75 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr role=\"row\">\r\n                    <td>\r\n                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2510, "\"", 2533, 1);
#nullable restore
#line 79 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
WriteAttributeValue("", 2518, item.WorkingId, 2518, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                     <td>\r\n                        ");
#nullable restore
#line 85 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                   Write(item.WP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 88 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                   Write(item.TP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 91 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                   Write(item.EquipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 94 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                   Write(item.EquipName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 97 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                   Write(item.MeasuringType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 100 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                   Write(item.MaterialCompositions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td> ");
#nullable restore
#line 103 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                    Write(item.WeldNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 104 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                    Write(item.ControlMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 105 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                    Write(item.ControlPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 106 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                    Write(item.ControlStandard);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 107 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                    Write(item.QCStandard);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 108 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                    Write(item.ControlResults);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 109 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                    Write(item.Remarks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n                        <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3644, "\"", 3675, 3);
            WriteAttributeValue("", 3654, "Edit(", 3654, 5, true);
#nullable restore
#line 112 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
WriteAttributeValue("", 3659, item.WorkingId, 3659, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3674, ")", 3674, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            Edit\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 117 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\WorkingPrograms.cshtml"
                rowCount++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <br>\r\n    <div style=\"clear: both;\">\r\n    </div>\r\n    <br>\r\n    <br>\r\n    <iframe style=\"display: none\" id=\"if_-2_119\"");
            BeginWriteAttribute("src", " src=\"", 3995, "\"", 4001, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>

</div>

<script src=""/js/jquery.min.js""></script>
<script src=""/js/jquery.unobtrusive-ajax.min.js""></script>


<script src=""/js/datatables.min.js""></script>




<script>
    $(document).ready(function () {
        $(""#myTable"").DataTable();
    });
</script>
<script>

    function Create() {
        $(""#newPage"").load(""/Inspection/CraeteWorkingPrograms/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/Inspection/EditWorkingPrograms/"" + id);
    }



    function showPage1() {
        $(""#Tabs"").load(""/Inspection/InspectionReports/"");
    }

    function showPage2() {
        $(""#Tabs"").load(""/Inspection/InspectionInstructions/"");
    }

    function showPage3() {
        $(""#Tabs"").load(""/Inspection/InspectionPrograms/"");
    }

    function showPage4() {
        $(""#Tabs"").load(""/Inspection/ManagementReviews/"");
    }

    function showsubPage1() {
        //$(""#newPage"").load(""/Inspection/WorkingPrograms/"");
        $(""#Tabs"").load(""/");
            WriteLiteral(@"Inspection/InspectionPrograms/"");
    }

    function showsubPage2() {
        $(""#newPage"").load(""/Inspection/WorkingPrograms/"");
    }
    showsubPage1

    $(""#checkAll"").click(function () {
        $("".checkBox"").prop('checked',
            $(this).prop('checked'));
    });

    $(""#delete"").click(function () {
        var selectedIDs = new Array();

        $('input:checkbox.checkBox').each(function () {
            if ($(this).prop('checked')) {
                selectedIDs.push($(this).val());
            }
        });


        var result = confirm(""are you sure you want to delete?"");
        if (result) {
        $.ajax({
            type: ""POST"",
            url: ""/Inspection/DeletWorkingPrograms"",
            data: { ""workingId"": selectedIDs },

            success: function (response) {
                $(""#newPage"").load(""/Inspection/WorkingPrograms/"");
            },
            failure: function (response) {
                alert(response.responseText);
        ");
            WriteLiteral("    },\r\n            error: function (response) {\r\n                alert(response.responseText);\r\n            }\r\n\r\n        });\r\n        }\r\n\r\n    });\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.WorkingPrograms>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
