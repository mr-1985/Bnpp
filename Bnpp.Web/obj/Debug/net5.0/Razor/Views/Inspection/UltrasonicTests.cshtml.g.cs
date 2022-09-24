#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74301d9aafc0e929fee6192cd4c1eb6d7eb203f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inspection_UltrasonicTests), @"mvc.1.0.view", @"/Views/Inspection/UltrasonicTests.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74301d9aafc0e929fee6192cd4c1eb6d7eb203f6", @"/Views/Inspection/UltrasonicTests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Inspection_UltrasonicTests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.TestResults>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
  
    ViewData["Title"] = "UltrasonicTests";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>

    <div id=""iLoading22"" style=""display: none;"">
        <img src=""/images/loading.gif"">
    </div>

    <h1>Ultrasonic Tests</h1>

    <a class=""btn-new-equip"" style=""cursor:pointer"" onclick=""Create()"">New</a>
    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
    <br />
");
#nullable restore
#line 18 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
      
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
                    <b>No</b>
                </th>
                <th style=""width: 250px"">
                    <b>Date</b>
                </th>
                <th style=""width: 120px"">
                    <b>Unit description</b>
                </th>
                <th style=""width: 250px"">
                    <b>Weld No</b>
                </th>

                <th style=""width: 250px"">
                    <b>Dimensions of unit</b>
                </th>
                
                <th style=""width: 120px"">
                    <b>	Test Scope</b>
                </th>
                <th style=""width: 120px"">
                    <b>Maximum allowed</b>
                </th>
          ");
            WriteLiteral(@"      <th style=""width: 120px"">
                    <b>Found defect description</b>
                </th>
                
                <th style=""width: 120px"">
                    <b>	Quality assessment</b>
                </th>
                

                <th style=""width: 120px"">
                    <b>	No. of log book</b>
                </th>
                <th style=""width: 120px"">
                    <b>	Notes</b>
                </th>

                <th style=""width: 120px"">
                    <b>Actions</b>
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 73 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr role=\"row\">\r\n                    <td>\r\n                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2339, "\"", 2366, 1);
#nullable restore
#line 77 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
WriteAttributeValue("", 2347, item.TestResultsId, 2347, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                   Write(item.NO);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 86 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                   Write(item.TestingDate.ToString("yy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 89 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                   Write(item.UnitDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 92 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                   Write(item.WeldNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 95 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                   Write(item.DimensionsofUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 99 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                   Write(item.TestScope);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td> ");
#nullable restore
#line 101 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                    Write(item.MaximumAllowed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 102 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                    Write(item.FoundDefectDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td> ");
#nullable restore
#line 104 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                    Write(item.QualityAssessment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                    <td> ");
#nullable restore
#line 106 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                    Write(item.NooflogBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 107 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                    Write(item.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n                        <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3439, "\"", 3474, 3);
            WriteAttributeValue("", 3449, "Edit(", 3449, 5, true);
#nullable restore
#line 110 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
WriteAttributeValue("", 3454, item.TestResultsId, 3454, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3473, ")", 3473, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            Edit\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 115 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\UltrasonicTests.cshtml"
                rowCount++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <br>\r\n    <div style=\"clear: both;\">\r\n    </div>\r\n    <br>\r\n    <br>\r\n    <iframe style=\"display: none\" id=\"if_-2_119\"");
            BeginWriteAttribute("src", " src=\"", 3794, "\"", 3800, 0);
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
        $(""#newPage"").load(""/Inspection/CreateUltrasonicTests/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/Inspection/EditUltrasonicTests/"" + id);
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
        $(""#Tabs"").load(""/Inspection/InspectionResults/"");
    }


    //SUB MENU

    function showsubPage1() {
        //$(""#newPage"").load(""/Inspection/WorkingPrograms/"");
      ");
            WriteLiteral(@"  $(""#Tabs"").load(""/Inspection/InspectionResults/"");
    }

    function showsubPage2() {
        $(""#newPage"").load(""/Inspection/LeakageTest/"");
    }

    function showsubPage3() {
        $(""#newPage"").load(""/Inspection/LiquidPenetrated/"");
    }

    function showsubPage4() {
        $(""#newPage"").load(""/Inspection/MagneticPowder/"");
    }

    function showsubPage5() {
        $(""#newPage"").load(""/Inspection/RadiographicsTest/"");
    }

    function showsubPage6() {
        $(""#newPage"").load(""/Inspection/UltrasonicTests/"");
    }

    function showsubPage7() {
        $(""#newPage"").load(""/Inspection/MetalThickness/"");
    }

    function showsubPage8() {
        $(""#newPage"").load(""/Inspection/VisualForm/"");
    }

    function showsubPage9() {
        $(""#newPage"").load(""/Inspection/LeakageForm/"");
    }

    function showsubPage10() {
        $(""#newPage"").load(""/Inspection/PenetrationForm/"");
    }

    function showsubPage11() {
        $(""#newPage"").load(""/In");
            WriteLiteral(@"spection/MagneticForm/"");
    }

    function showsubPage12() {
        $(""#newPage"").load(""/Inspection/RadiographicsForm/"");
    }

    function showsubPage13() {
        $(""#newPage"").load(""/Inspection/UltrasonicForm/"");
    }

    function showsubPage14() {
        $(""#newPage"").load(""/Inspection/MetalForm/"");
    }



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

        $.ajax({
            type: ""POST"",
            url: ""/Inspection/DeleteUltrasonicTests"",
            data: { ""sonicId"": selectedIDs },

            success: function (response) {
                $(""#newPage"").load(""/Inspection/UltrasonicTests/"");
            },
            fa");
            WriteLiteral("ilure: function (response) {\r\n                alert(response.responseText);\r\n            },\r\n            error: function (response) {\r\n                alert(response.responseText);\r\n            }\r\n\r\n        });\r\n\r\n    });\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.TestResults>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
