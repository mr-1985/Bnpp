#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d8de2a6da48be66e822f47bed3d884d04e9af89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inspection_LeakageTest), @"mvc.1.0.view", @"/Views/Inspection/LeakageTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8de2a6da48be66e822f47bed3d884d04e9af89", @"/Views/Inspection/LeakageTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Inspection_LeakageTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.TestResults>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
  
    ViewData["Title"] = "LeakageTest";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>

    <div id=""iLoading22"" style=""display: none;"">
        <img src=""/images/loading.gif"">
    </div>

    <h1>Leakage Test of Weld</h1>

    <a class=""btn-new-equip"" style=""cursor:pointer"" onclick=""Create()"">New</a>
    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
    <br />
");
#nullable restore
#line 18 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
      
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
                <th style=""width: 250px"">
                    <b>Code</b>
                </th>
                <th style=""width: 120px"">
                    <b>No Weld Joints</b>
                </th>
                <th style=""width: 120px"">
                    <b>Dimension of Weld</b>
                </th>

                <th style=""width: 120px"">
                    <b>	Scope of Testing</b>
                </th>
                <th style=""width: 120px"">
                    <b>	Defect description</b>
                </th>
                <th styl");
            WriteLiteral(@"e=""width: 120px"">
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
#line 66 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr role=\"row\">\r\n                    <td>\r\n                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2168, "\"", 2195, 1);
#nullable restore
#line 70 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
WriteAttributeValue("", 2176, item.TestResultsId, 2176, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                   Write(item.NO);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                   Write(item.TestingDate.ToString("yy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                   Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                   Write(item.WeldNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 88 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                   Write(item.DimensionofWeld);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 91 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                   Write(item.TestScope);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td> ");
#nullable restore
#line 94 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                    Write(item.FoundDefectDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 95 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                    Write(item.QualityAssessment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 96 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                    Write(item.NooflogBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 97 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                    Write(item.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n                        <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3180, "\"", 3215, 3);
            WriteAttributeValue("", 3190, "Edit(", 3190, 5, true);
#nullable restore
#line 100 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
WriteAttributeValue("", 3195, item.TestResultsId, 3195, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3214, ")", 3214, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            Edit\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 105 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\LeakageTest.cshtml"
                rowCount++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <br>\r\n    <div style=\"clear: both;\">\r\n    </div>\r\n    <br>\r\n    <br>\r\n    <iframe style=\"display: none\" id=\"if_-2_119\"");
            BeginWriteAttribute("src", " src=\"", 3535, "\"", 3541, 0);
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
        $(""#newPage"").load(""/Inspection/CreateLeakageTest/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/Inspection/EditLeakageTest/"" + id);
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
        $(""#Ta");
            WriteLiteral(@"bs"").load(""/Inspection/InspectionResults/"");
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
        $(""#newPage"").load(""/Inspection");
            WriteLiteral(@"/MagneticForm/"");
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


        var result = confirm(""are you sure you want to delete?"");
        if (result) {
        $.ajax({
            type: ""POST"",
            url: ""/Inspection/DeleteLeakageTest"",
            data: { ""leakageId"": selectedIDs },

            success: function (response) {
                $(""");
            WriteLiteral(@"#newPage"").load(""/Inspection/LeakageTest/"");
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


</script>");
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
