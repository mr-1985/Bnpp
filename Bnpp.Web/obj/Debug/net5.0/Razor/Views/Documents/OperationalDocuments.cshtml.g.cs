#pragma checksum "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f1e90a90fc822537a98c013d400caa8f1af79ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Documents_OperationalDocuments), @"mvc.1.0.view", @"/Views/Documents/OperationalDocuments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f1e90a90fc822537a98c013d400caa8f1af79ef", @"/Views/Documents/OperationalDocuments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Documents_OperationalDocuments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.AgeingDocuments.OperationalDocuments>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
  
    ViewData["Title"] = "OperationalDocuments";
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
            BeginWriteAttribute("style", " style=\"", 742, "\"", 750, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b><a class=\"breadcumb2-link\" href=\"#\">Mechanical Equipments</a></b>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 898, "\"", 906, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        »  Ageing Document <b id=""subTitle22a""></b>
                    </td>
                    <td>
                        » <b style=""color: #ff0000;"" id=""subTitle22"">Operational Documents
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
    Ageing Document
</h1>
    <div id=""iContent"">

        <div class=""tab-buttons"">
            <ul>
                <li id=""tab-button1"" class=""tab-buttons-li"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
                    <a id=""tab-button-a1""
                       onclick=""showPage1()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                        Operational Documents
                    </a>
                </li>
                <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-buttona2"" onclick=""showPage2()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Drawing
                    </a>

                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage3()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Standards

                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage4()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Manufacturer Documents
                    </a>
   ");
            WriteLiteral(@"             </li>
                
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage5()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Installation Documents
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage6()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Maintenance Documents
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage7()"" style=""c");
            WriteLiteral(@"ursor:pointer;color: rgb(110, 110, 255);"">
                        Ageing Documents
                    </a>
                </li>
               
            </ul>

            <div style=""clear:both;""></div>
        </div>

        <div id=""tab1"" class=""tab-item"" style=""display: block;"">

            <h1 id=""iH1"">Operational Documents
            </h1>

            <div class=""bevel-box"">
                <table cellpadding=""3"" cellspacing=""0"">
                    <tbody>
                        <tr>
");
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


                    <a class=""btn-new-equip"" style=""cursor: pointer"" onclick=""Create()"">New</a>
                    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
                    <br />
");
#nullable restore
#line 165 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
                      
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
                                <th style=""width: 150px"">
                                    <b>Code</b>
                                </th>
                                <th style=""width: 250px"">
                                    <b>File Name</b>
                                </th>
                                <th style=""width: 120px"">
                                    <b>Doc. Name</b>
                                </th>
                                
                               
                                <th style=""width: 120px"">
                                    <b>Actions</b>
                           ");
            WriteLiteral("     </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 192 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr role=\"row\">\r\n                                <td>\r\n                                    <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 9659, "\"", 9686, 1);
#nullable restore
#line 196 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
WriteAttributeValue("", 9667, item.OperationalId, 9667, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 199 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
                               Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 202 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
                               Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 205 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
                               Write(item.Filename);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 208 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
                               Write(item.DocumentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 10341, "\"", 10376, 3);
            WriteAttributeValue("", 10351, "Edit(", 10351, 5, true);
#nullable restore
#line 211 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
WriteAttributeValue("", 10356, item.OperationalId, 10356, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10375, ")", 10375, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        Edit\r\n                                    </a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 216 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Documents\OperationalDocuments.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 10896, "\"", 10902, 0);
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
        $(""#newPage"").load(""/Documents/CreateOperationalDocuments/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/Documents/EditOperationalDocuments/""+id);
    }

    
    function showPage1() {
        $(""#Tabs"").load(""/Documents/OperationalDocuments/"");
    }

    function showPage2() {
        $(""#Tabs"").load(""/Documents/Drawing/"");
    }

    function showPage3() {
        $(""#Tabs"").load(""/Documents/Standards/"");
    }
    
    function showPage4() {
        $(""#Tabs"").load(""/Documents/ManufacturerDocuments/"");
    }
    
    function showPage5() {
        $(""#Tabs"").load(""/Doc");
            WriteLiteral(@"uments/InstallationDocuments/"");
    }
    
     function showPage6() {
        $(""#Tabs"").load(""/Documents/MaintenanceDocuments"");
    }

    function showPage7() {
        $(""#Tabs"").load(""/Documents/AgeingDocuments/"");
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
            url: ""/Documents/DeleteOperationalDocument"",
            data: { ""operationalId"": selectedIDs },

            success: function (response) {
                $(""#Tabs"").load(""/Documents/OperationalDocuments/"");
            },
            failure: function (response) {
                alert(response.responseText);
    ");
            WriteLiteral("        },\r\n            error: function (response) {\r\n                alert(response.responseText);\r\n            }\r\n\r\n        });\r\n\r\n    });\r\n\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.AgeingDocuments.OperationalDocuments>> Html { get; private set; }
    }
}
#pragma warning restore 1591
