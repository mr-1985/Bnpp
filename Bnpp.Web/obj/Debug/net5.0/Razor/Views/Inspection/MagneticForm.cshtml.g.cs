#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa37d4536863f1484b0917895f20cd095ca9edad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inspection_MagneticForm), @"mvc.1.0.view", @"/Views/Inspection/MagneticForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa37d4536863f1484b0917895f20cd095ca9edad", @"/Views/Inspection/MagneticForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Inspection_MagneticForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.InspectionDocument>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
  
    ViewData["Title"] = "MagneticForm";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>

    <div id=""iLoading22"" style=""display: none;"">
        <img src=""/images/loading.gif"">
    </div>

    <h1>Magnetic Powder Test Form</h1>

    <a class=""btn-new-equip"" style=""cursor:pointer"" onclick=""Create()"">New</a>
    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
    <br />
");
#nullable restore
#line 18 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
      
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
                    <b>Form No</b>
                </th>
                <th style=""width: 250px"">
                    <b>	Form Name</b>
                </th>
                <th style=""width: 250px"">
                    <b>File Name</b>
                </th>
                <th style=""width: 120px"">
                    <b>Date</b>
                </th>
                <th style=""width: 120px"">
                    <b>		Remarks</b>
                </th>


                <th style=""width: 120px"">
                    <b>Actions</b>
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 51 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr role=\"row\">\r\n                    <td>\r\n                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 1627, "\"", 1653, 1);
#nullable restore
#line 55 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
WriteAttributeValue("", 1635, item.InspectionId, 1635, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
                   Write(item.FormName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
                   Write(item.FormNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
                   Write(item.Filename);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
                   Write(item.InspectionDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2346, "\"", 2380, 3);
            WriteAttributeValue("", 2356, "Edit(", 2356, 5, true);
#nullable restore
#line 77 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
WriteAttributeValue("", 2361, item.InspectionId, 2361, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2379, ")", 2379, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            Edit\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\MagneticForm.cshtml"
                rowCount++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <br>\r\n    <div style=\"clear: both;\">\r\n    </div>\r\n    <br>\r\n    <br>\r\n    <iframe style=\"display: none\" id=\"if_-2_119\"");
            BeginWriteAttribute("src", " src=\"", 2700, "\"", 2706, 0);
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
        $(""#newPage"").load(""/Inspection/CreateMagneticForm/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/Inspection/EditMagneticForm/"" + id);
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
        $(""#Tabs");
            WriteLiteral(@""").load(""/Inspection/InspectionResults/"");
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
        $(""#newPage"").load(""/Inspection/M");
            WriteLiteral(@"agneticForm/"");
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
            url: ""/Inspection/DeleteMagneticForm"",
            data: { ""magnetId"": selectedIDs },

            success: function (response) {
                $(""#newPage"").load(""/Inspection/MagneticForm/"");
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }

        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.InspectionDocument>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
