#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f65019602045d2d79e79a5b304f9f8aa91342e79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inspection_PenetrationForm), @"mvc.1.0.view", @"/Views/Inspection/PenetrationForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65019602045d2d79e79a5b304f9f8aa91342e79", @"/Views/Inspection/PenetrationForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Inspection_PenetrationForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.InspectionDocument>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Inspection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportPenetrationForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
  
    ViewData["Title"] = "PenetrationForm";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""tab1"" class=""tab-item"" style=""display: block;"">
<h1 id=""iH1"">Inspection Results</h1>

<div class=""tab-buttons"">
    <ul>
        <li id=""tab-button1"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"" ");
            WriteLiteral(">\r\n            <a id=\"tab-button-a1\"\r\n               onclick=\"showsubPage1()\" style=\"cursor:pointer;color: rgb(0, 113, 158);\">\r\n                Visual Control\r\n            </a>\r\n        </li>\r\n        <li id=\"tab-button2\" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-buttona2"" onclick=""showsubPage2()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Leakage Test of Weld
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-buttona2"" onclick=""showsubPage3()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Liquid Penetrated Test
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-buttona2"" onclick=""showsubPage4()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Magnetic Powder test
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-buttona2"" onclick=""showsubPage5()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Radiographics Test
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-buttona2"" onclick=""showsubPage6()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Ultrasonic Tests
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-buttona2"" onclick=""showsubPage7()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Metal thickness ultrasonic measurement
            </a>
        </li>

        <li id=""tab-button1"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-button-a1""
               onclick=""showsubPage8()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                Visual Inspection Form
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"" >
            <a id=""tab-buttona2"" onclick=""showsubPage9()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Leakage Test Form
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(208, 208, 208); border-color: rgb(128, 128, 128); font-weight: bold;"">
            <a id=""tab-buttona2"" onclick=""showsubPage10()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Liquid Penetration Test Form
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-buttona2"" onclick=""showsubPage11()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Magnetic Powder Test Form
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-buttona2"" onclick=""showsubPage12()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Radiographics Test Form
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
            <a id=""tab-buttona2"" onclick=""showsubPage13()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Ultrasonic Test Form
            </a>
        </li>
        <li id=""tab-button2"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
            <a id=""tab-buttona2"" onclick=""showsubPage14()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                Metal thickness ultrasonic Test Form
            </a>
        </li>
    </ul>

    <div style=""clear:both;""></div>
</div>

<div>
    <div id=""newPage"">
    <div class=""bevel-box"">
        <table cellpadding=""3"" cellspacing=""0"">
            <tbody>
                <tr>

                     <td>
                    <input type=""file"" name=""uploadedFile"" id=""uploadedFile"" style=""direction: ltr; text-align: left;"">
");
            WriteLiteral("                    </td>\r\n\r\n\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f65019602045d2d79e79a5b304f9f8aa91342e799795", async() => {
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Export Excel\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </td>

                    <td style=""width: 200px;"">
                        <span id=""message"">
                        </span>
                    </td>
                    <td>
                        <a href=""#"" target=""_blank"">
                            <img src=""/images/print_printer.png"" title=""Print"">
                        </a>
                    </td>
                </tr>
            </tbody>
        </table>

    </div>

    <div id=""iLoading22"" style=""display: none;"">
        <img src=""/images/loading.gif"">
    </div>

    <h1>Liquid Penetration Test Form</h1>

    <a class=""btn-new-equip"" style=""cursor:pointer"" onclick=""Create()"">New</a>
    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
    <br />
");
#nullable restore
#line 135 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
      
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
#line 168 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr role=\"row\">\r\n                    <td>\r\n                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 7981, "\"", 8007, 1);
#nullable restore
#line 172 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
WriteAttributeValue("", 7989, item.InspectionId, 7989, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 175 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 179 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
                   Write(item.FormName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 182 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
                   Write(item.FormNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 185 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
                   Write(item.Filename);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 188 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
                   Write(item.InspectionDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 191 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8700, "\"", 8734, 3);
            WriteAttributeValue("", 8710, "Edit(", 8710, 5, true);
#nullable restore
#line 194 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
WriteAttributeValue("", 8715, item.InspectionId, 8715, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8733, ")", 8733, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            Edit\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 199 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\PenetrationForm.cshtml"
                rowCount++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <br>\r\n    <div style=\"clear: both;\">\r\n    </div>\r\n    <br>\r\n    <br>\r\n    <iframe style=\"display: none\" id=\"if_-2_119\"");
            BeginWriteAttribute("src", " src=\"", 9054, "\"", 9060, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>

</div>
</div>
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
        $(""#newPage"").load(""/Inspection/CreatePenetrationForm/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/Inspection/EditPenetrationForm/"" + id);
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
        //$(""#newPage"").load(""/Inspection/WorkingProg");
            WriteLiteral(@"rams/"");
        $(""#Tabs"").load(""/Inspection/InspectionResults/"");
    }

    function showsubPage2() {
        $(""#submenu"").load(""/Inspection/LeakageTest/"");
    }

    function showsubPage3() {
        $(""#submenu"").load(""/Inspection/LiquidPenetrated/"");
    }

    function showsubPage4() {
        $(""#submenu"").load(""/Inspection/MagneticPowder/"");
    }

    function showsubPage5() {
        $(""#submenu"").load(""/Inspection/RadiographicsTest/"");
    }

    function showsubPage6() {
        $(""#submenu"").load(""/Inspection/UltrasonicTests/"");
    }

    function showsubPage7() {
        $(""#submenu"").load(""/Inspection/MetalThickness/"");
    }

    function showsubPage8() {
        $(""#submenu"").load(""/Inspection/VisualForm/"");
    }

    function showsubPage9() {
        $(""#submenu"").load(""/Inspection/LeakageForm/"");
    }

    function showsubPage10() {
        $(""#submenu"").load(""/Inspection/PenetrationForm/"");
    }

    function showsubPage11() {
        $(""#sub");
            WriteLiteral(@"menu"").load(""/Inspection/MagneticForm/"");
    }

    function showsubPage12() {
        $(""#submenu"").load(""/Inspection/RadiographicsForm/"");
    }

    function showsubPage13() {
        $(""#submenu"").load(""/Inspection/UltrasonicForm/"");
    }

    function showsubPage14() {
        $(""#submenu"").load(""/Inspection/MetalForm/"");
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
            url: ""/Inspection/DeletePenetrationForm"",
            data: { ""liquidId"": selectedIDs },

            success: function (respons");
            WriteLiteral(@"e) {
                    $(""#submenu"").load(""/Inspection/PenetrationForm/"");
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.InspectionDocument>> Html { get; private set; }
    }
}
#pragma warning restore 1591
