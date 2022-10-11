#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46865c9f8b81bc63b61a8e05ec6029afd98d7242"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maintenance_Defections), @"mvc.1.0.view", @"/Views/Maintenance/Defections.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46865c9f8b81bc63b61a8e05ec6029afd98d7242", @"/Views/Maintenance/Defections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Maintenance_Defections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.Maintenance.DefectList>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
  
    ViewData["Title"] = "Defections";
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
            BeginWriteAttribute("style", " style=\"", 718, "\"", 726, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b><a class=\"breadcumb2-link\" href=\"#\">Mechanical Equipments</a></b>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 874, "\"", 882, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        »  Maintenance <b id=""subTitle22a""></b>
                    </td>
                    <td>
                        » <b style=""color: #ff0000;"" id=""subTitle22"">List of Defections
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
    Maintenance
</h1>
    <div id=""iContent"">

        <div class=""tab-buttons"">
            <ul>
                <li id=""tab-button1"" class=""tab-buttons-li"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
                    <a id=""tab-button-a1""
                       onclick=""showPage1()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                        Maintenance Programs
                    </a>
                </li>
                <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-buttona2"" onclick=""showPage2()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        List of Defections
                    </a>

                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage3()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Spare Parts List
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage4()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Maintenance Forms
                  ");
            WriteLiteral(@"  </a>
                </li>
                
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage5()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Controls & Measurements before & after Maintenance
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage6()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Defection Reports
                    </a>
                </li>
                
            </ul>

            <div style=""clear:both;""></div>
        </div>

        <div id=""tab1"" class=""tab-item"" style=""display: block;"">

            <h1 id=""iH1"">List ");
            WriteLiteral("of Defections\r\n            </h1>\r\n\r\n            <div class=\"bevel-box\">\r\n                <table cellpadding=\"3\" cellspacing=\"0\">\r\n                    <tbody>\r\n                        <tr>\r\n");
            WriteLiteral(@"                            <td>
                                <input type=""file"" name=""uploadedFile"" id=""uploadedFile"" style=""direction: ltr; text-align: left;"">
                                <input onclick=""__doPostBack('upload','')"" name=""upload"" type=""button"" id=""upload"" value=""Import Excel"" style=""direction: ltr; text-align: left;"">
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
");
            WriteLiteral(@"            </div>

            <div  id=""newPage"">
                <div>

                    <div id=""iLoading22"" style=""display: none;"">
                        <img src=""/images/loading.gif"">
                    </div>


                    <a class=""btn-new-equip"" style=""cursor:pointer"" onclick=""Create()"">New</a>
                    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
                    <br />
");
#nullable restore
#line 159 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                      
                        int rowCount = 1;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table id=""myTable"" cellpadding=""3"" cellspacing=""0"" class=""show-table"">
                        <thead>
                            <tr role=""row"">
                                <th>
                                    <input type=""checkbox"" id=""checkAll"" />
                                </th>
                                <th></th>
                                <th >
                                    <b>Instruction No. after Correction</b>
                                </th>
                                <th >
                                    <b>Control Result after Correction</b>
                                </th>
                                <th >
                                    <b>Correction Date</b>
                                </th>
                                
                                <th >
                                    <b>Correction Method</b>
                                </th>
                                
 ");
            WriteLiteral(@"                               <th >
                                    <b>	Control Instruction No.</b>
                                </th>
                                <th >
                                    <b>	Control Result</b>
                                </th>
                                <th >
                                    <b>	Control Method</b>
                                </th>
                                <th >
                                    <b>	Part or Equipment</b>
                                </th>
                                <th >
                                    <b>	Detection Date</b>
                                </th>
                                <th >
                                    <b>	Journal No.</b>
                                </th>
                                <th >
                                    <b>	Name of Defect</b>
                                </th>
                                <th >
           ");
            WriteLiteral("                         <b>Actions</b>\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 210 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr role=\"row\">\r\n                                    <td>\r\n                                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 10397, "\"", 10423, 1);
#nullable restore
#line 214 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
WriteAttributeValue("", 10405, item.DefectListId, 10405, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 217 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 220 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.InstructionCorrection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 223 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.ControlCorrection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 226 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.CorrectionDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 229 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.CorrectionMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 232 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.ControlInstructionNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 235 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.ControlResult);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 238 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.ControlMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 241 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.PartorEquipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 244 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.DetectionDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 247 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.JournalNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 250 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                   Write(item.NameofDefect);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 12387, "\"", 12421, 3);
            WriteAttributeValue("", 12397, "Edit(", 12397, 5, true);
#nullable restore
#line 253 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
WriteAttributeValue("", 12402, item.DefectListId, 12402, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 12420, ")", 12420, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Edit\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 258 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Maintenance\Defections.cshtml"
                                rowCount++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>


                    <br>
                    <div style=""clear: both;"">
                    </div>
                    <br>
                    <br>
                    <iframe style=""display: none"" id=""if_-2_119""");
            BeginWriteAttribute("src", " src=\"", 12965, "\"", 12971, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>

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
        $(""#newPage"").load(""/Maintenance/CreateDefections/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/Maintenance/EditDefections/"" + id);
    }

    
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
        $(""#Tabs"").load(""/Maintenanc");
            WriteLiteral(@"e/Measurements/"");
    }
    
     function showPage6() {
        $(""#Tabs"").load(""/Maintenance/DefectsReport"");
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
            url: ""/Maintenance/DeleteDefections"",
            data: { ""defectionId"": selectedIDs },

            success: function (response) {
                $(""#Tabs"").load(""/Maintenance/Defections/"");
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (res");
            WriteLiteral("ponse) {\r\n                alert(response.responseText);\r\n            }\r\n\r\n        });\r\n        }\r\n\r\n    });\r\n\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.Maintenance.DefectList>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
