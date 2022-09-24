#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "538916b109658873a33aaca4746a6653da8a80fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inspection_InspectionResults), @"mvc.1.0.view", @"/Views/Inspection/InspectionResults.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"538916b109658873a33aaca4746a6653da8a80fe", @"/Views/Inspection/InspectionResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Inspection_InspectionResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.InspectionData.TestResults>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
  
    ViewData["Title"] = "InspectionResults";
    Layout = null;

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
            BeginWriteAttribute("style", " style=\"", 728, "\"", 736, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b><a class=\"breadcumb2-link\" href=\"#\">Mechanical Equipments</a></b>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 884, "\"", 892, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        » <b id=""subTitle22a"">Test & Inspection Data</b>
                    </td>
                    <td>
                        » <b style=""color: #ff0000;"" id=""subTitle22"">
                            Inspection Programs
                        </b>
                    </td>
                </tr>
            </tbody>
        </table>
        <a id=""iHelp"" style=""float: right; position: relative; top: -32px;"" href=""javascript:;"" onclick=""showHelp();"">
            <img src=""/images/help.png"" style=""width: 48px;"" class=""imgHelp"">
        </a>
    </div>

    <h1 id=""iH1"">
        Test & Inspection Data
    </h1>
    <div id=""iContent"">

        <div class=""tab-buttons"">
            <ul>
                <li id=""tab-button1"" class=""tab-buttons-li"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
                    <a id=""tab-button-a1""
                       onclick=""showPage1()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                        Inspection Reports
                    </a>
                </li>
                <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-buttona2"" onclick=""showPage2()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Inspection Instructions
                    </a>

                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage3()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Inspection Programs
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage4()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Inspection Results
         ");
            WriteLiteral(@"           </a>
                </li>
            </ul>

            <div style=""clear:both;""></div>
        </div>

        <div id=""tab1"" class=""tab-item"" style=""display: block;"">

            <h1 id=""iH1"">Inspection Results</h1>


            <div class=""tab-buttons"">
                <ul>
                    <li id=""tab-button1"" class=""tab-buttons-li"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
                        <a id=""tab-button-a1""
                           onclick=""showsubPage1()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                            Visual Control
                        </a>
                    </li>
                    <li id=""tab-button2"" ");
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

                    <li id=""tab-button1"" class=""tab-buttons-li"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
                        <a id=""tab-button-a1""
                           onclick=""showsubPage8()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                            Visual Inspection Form
                        </a>
                    </li>
                    <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                        <a id=""tab-buttona2"" onclick=""showsubPage9()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                            Leakage Test Form
                        </a>
                    </li>
                    <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
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
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                        <a id=""tab-buttona2"" onclick=""showsubPage14()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                            Metal thickness ultrasonic Test Form
                        </a>
                    </li>
                </ul>

                <div style=""clear:both;""></div>
            </div>

            <div id=""submenu"">
                <div class=""bevel-box"">
                    <table cellpadding=""3"" cellspacing=""0"">
                        <tbody>
                            <tr>

                                <td>
                                    <input type=""file"" name=""uploadedFile"" id=""uploadedFile"" style=""direction: ltr; text-align: left;"">
                                    <input onclick=""__doPostBack('upload','')"" name=""upload"" type=""button"" id=""upload"" value=""Import Excel"" style=""direction: ltr; text-align: left;"">
                ");
            WriteLiteral(@"                </td>
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

                <div id=""newPage"">
                    <div>

                        <div id=""iLoading22"" style=""display: none;"">
                            <img src=""/images/loading.gif"">
                        </div>


                        <a class=""btn-new-equip"" style=""cursor:pointer"" onclick=""Create()"">New</a>
                        <input type=""button"" id=""delete"" class=");
            WriteLiteral("\"btn-delete-equip\" value=\"Delete\">\r\n                        <br />\r\n");
#nullable restore
#line 190 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                          
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
                                        <b>No</b>
                                    </th>
                                    <th style=""width: 250px"">
                                        <b>Date</b>
                                    </th>
                                    <th style=""width: 120px"">
                                        <b>Weld No</b>
                                    </th>
                                    <th style=""width: 120px"">
                                        <b>Weld Size</b>
                             ");
            WriteLiteral(@"       </th>

                                    <th style=""width: 120px"">
                                        <b>	Test Scope</b>
                                    </th>
                                    <th style=""width: 120px"">
                                        <b>	Found defect description</b>
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
                                   ");
            WriteLiteral(" </th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 235 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr role=\"row\">\r\n                                        <td>\r\n                                            <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 13751, "\"", 13778, 1);
#nullable restore
#line 239 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
WriteAttributeValue("", 13759, item.TestResultsId, 13759, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 242 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                       Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 245 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                       Write(item.NO);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 248 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                       Write(item.TestingDate.ToString("yy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 251 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                       Write(item.WeldNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 254 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                       Write(item.WeldSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 257 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                       Write(item.TestScope);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td> ");
#nullable restore
#line 260 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                        Write(item.FoundDefectDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 261 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                        Write(item.QualityAssessment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 262 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                        Write(item.NooflogBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 263 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                        Write(item.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n\r\n                                            <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 15167, "\"", 15202, 3);
            WriteAttributeValue("", 15177, "Edit(", 15177, 5, true);
#nullable restore
#line 266 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
WriteAttributeValue("", 15182, item.TestResultsId, 15182, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 15201, ")", 15201, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                Edit\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 271 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Inspection\InspectionResults.cshtml"
                                    rowCount++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>


                        <br>
                        <div style=""clear: both;"">
                        </div>
                        <br>
                        <br>
                        <iframe style=""display: none"" id=""if_-2_119""");
            BeginWriteAttribute("src", " src=\"", 15802, "\"", 15808, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>

                    </div>
                </div>
            </div>
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
        $(""#newPage"").load(""/Inspection/CraeteVisualControl/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/Inspection/EditVisualControl/"" + id);
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


    function showsubPage1(");
            WriteLiteral(@") {
        //$(""#newPage"").load(""/Inspection/WorkingPrograms/"");
        $(""#Tabs"").load(""/Inspection/InspectionResults/"");
    }

    function showsubPage2() {
        $(""#newPage"").load(""/Inspection/WorkingPrograms/"");
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
            url: ""/Inspection/DeleteVisualControl"",
            data: { ""visualId"": selectedIDs },

            success: function (response) {
                $(""#Tabs"").load(""/Inspection/InspectionResults/"");
            },
            failure: function (response) {
                alert(response.responseText);
            },
          ");
            WriteLiteral("  error: function (response) {\r\n                alert(response.responseText);\r\n            }\r\n\r\n        });\r\n\r\n    });\r\n\r\n\r\n</script>\r\n");
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
