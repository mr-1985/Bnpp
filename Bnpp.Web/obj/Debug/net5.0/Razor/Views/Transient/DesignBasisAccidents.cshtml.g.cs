#pragma checksum "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "260c69cb77fd4e1679c6918b1ec6a8b77345465b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transient_DesignBasisAccidents), @"mvc.1.0.view", @"/Views/Transient/DesignBasisAccidents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"260c69cb77fd4e1679c6918b1ec6a8b77345465b", @"/Views/Transient/DesignBasisAccidents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Transient_DesignBasisAccidents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.Core.ViewModels.DesignBasisListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
  
    ViewData["Title"] = "OperationalOccurence";
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
            BeginWriteAttribute("style", " style=\"", 726, "\"", 734, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b><a class=\"breadcumb2-link\" href=\"#\">Mechanical Equipments</a></b>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 882, "\"", 890, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        » <b id=""subTitle22a"">Transients</b>
                    </td>
                    <td>
                        » <b style=""color: #ff0000;"" id=""subTitle22"">Design Basis accidents</b>
                    </td>
                </tr>
            </tbody>
        </table>
        <a id=""iHelp"" style=""float: right; position: relative; top: -32px;"" href=""javascript:;"" onclick=""showHelp();"">
            <img src=""/images/help.png"" style=""width: 48px;"" class=""imgHelp"">
        </a>
    </div>

    <h1 id=""iH1"">Operational Data</h1>
    <div id=""iContent"">

        <div class=""tab-buttons"">
            <ul>
                <li id=""tab-button1"" class=""tab-buttons-li"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
                    <a id=""tab-button-a1""
                       onclick=""showPage1()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                        Normal Operations
                    </a>
                </li>
                <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-buttona2"" onclick=""showPage2()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Operational Occurances
                    </a>

                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage3()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Design Basis accidents
                    </a>
                </li>
            </ul>

            <div style=""clear:both;""></div>
        </div>

        <div id=""tab1"" class=""tab-item"" style=""display: block;"">

            <h1 id=""iH1"">Design Basis accidents</h1>

            <div class=""bevel-box"">
                <table cellpadding=""3"" cellspacing=""0"">
                    <tbody>");
            WriteLiteral(@"
                        <tr>
                           
                            <td>
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
               
            </div>

            <");
            WriteLiteral(@"div  id=""newPage"">
                <div>

                    <div id=""iLoading22"" style=""display: none;"">
                        <img src=""/images/loading.gif"">
                    </div>


                    <a class=""btn-new-equip"" onclick=""Create()"">New</a>
                    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
                    <br />
");
#nullable restore
#line 99 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
                      
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
                                    <b>Date</b>
                                </th>
                                <th style=""width: 250px"">
                                    <b>Name of Conditions</b>
                                </th>
                                <th style=""width: 120px"">
                                    <b>Allowable Num.</b>
                                </th>
                                <th style=""width: 120px"">
                                    <b>Occurrances</b>
                                </th>
                                <th s");
            WriteLiteral("tyle=\"width: 120px\">\r\n                                    <b>Actions</b>\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 127 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr role=\"row\">\r\n                                    <td>\r\n                                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 6138, "\"", 6161, 1);
#nullable restore
#line 131 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
WriteAttributeValue("", 6146, item.DesigneId, 6146, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 134 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
                                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 137 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
                                   Write(item.CreateDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 140 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
                                   Write(item.NameOfCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 143 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
                                   Write(item.AllowableNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 146 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
                                   Write(item.Occurrances);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7059, "\"", 7090, 3);
            WriteAttributeValue("", 7069, "Edit(", 7069, 5, true);
#nullable restore
#line 149 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
WriteAttributeValue("", 7074, item.DesigneId, 7074, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7089, ")", 7089, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Edit\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 154 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Transient\DesignBasisAccidents.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 7634, "\"", 7640, 0);
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
        $(""#newPage"").load(""/Transient/CreateDesignBasisAccidents/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/Transient/EditNormalOperations/""+id);
    }

    function showPage1() {
        $(""#Tabs"").load(""/Transient/NormalOperations/"");
    }

    function showPage2() {
        $(""#Tabs"").load(""/Transient/OperationalOccurence/"");
    }

    function showPage3() {
        $(""#Tabs"").load(""/Transient/DesignBasisAccidents/"");
    }

    

    $(""#checkAll"").click(function () {
        $("".checkBox"").prop('checked',
            $(this).prop('checked'));
    });

    $(""#delete"").");
            WriteLiteral(@"click(function () {
        var selectedIDs = new Array();

        $('input:checkbox.checkBox').each(function () {
            if ($(this).prop('checked')) {
                selectedIDs.push($(this).val());
            }
        });

        $.ajax({
            type: ""POST"",
            url: ""/Transient/DeleteNormalOperations"",
            data: { ""operationalId"": selectedIDs },

            success: function (response) {
                $(""#Tabs"").load(""/Transient/NormalOperations/"");
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }

        });

    });


</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.Core.ViewModels.DesignBasisListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
