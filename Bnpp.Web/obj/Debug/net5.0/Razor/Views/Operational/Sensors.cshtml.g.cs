#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\Sensors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a5430292fd937b340c5fa0731bb79ce6d511ea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operational_Sensors), @"mvc.1.0.view", @"/Views/Operational/Sensors.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5430292fd937b340c5fa0731bb79ce6d511ea1", @"/Views/Operational/Sensors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Operational_Sensors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\Sensors.cshtml"
  
    ViewData["Title"] = "Sensors";
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
            BeginWriteAttribute("style", " style=\"", 646, "\"", 654, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b><a class=\"breadcumb2-link\" href=\"#\">Mechanical Equipments</a></b>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 802, "\"", 810, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        »  Operational Data <b id=""subTitle22a""></b>
                    </td>
                    <td>
                        » <b style=""color: #ff0000;"" id=""subTitle22"">
                            Sensors Data
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
        Operational Data
    </h1>
    <div id=""iContent"">

        <div class=""tab-buttons"">
            <ul>
                <li id=""tab-button1"" class=""tab-buttons-li"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
                    <a id=""tab-button-a1""
                       onclick=""showPage1()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                        Sensors Data
                    </a>
                </li>
                <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-buttona2"" onclick=""showPage2()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Water Chemical Data
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage3()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Environmental Data
                    </a>
                </li>
            </ul>

            <div style=""clear:both;""></div>
        </div>

        <div id=""tab1"" class=""tab-item"" style=""display: block;"">

            <h1 id=""iH1"">
                Sensors Data
            </h1>

            <div class=""bevel-box"">
                <table cellpadding=""3"" cellspacing=""0"">
               ");
            WriteLiteral("     <tbody>\r\n                        <tr>\r\n");
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

            <div id=""newPage"">
                <div>

                    <div id=""iLoading22"" style=""display: none;"">
                        <img src=""/images/loading.gif"">
                    </div>


                    <a class=""btn-new-equip"" onclick=""Create()"">New</a>
                    <input type=""button"" ");
            WriteLiteral(" class=\"btn-delete-equip\" value=\"Delete\">\r\n                    <br />\r\n");
#nullable restore
#line 142 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Operational\Sensors.cshtml"
                      
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
                                    <b>Sensor Name</b>
                                </th>
                                <th style=""width: 250px"">
                                    <b>AKZ</b>
                                </th>
                                <th style=""width: 120px"">
                                    <b>Unit</b>
                                </th>

                                <th style=""width: 120px"">
                                    <b>Minimum</b>
                                </th>

                                <th style=""width: 120px");
            WriteLiteral(@""">
                                    <b>	Maximum</b>
                                </th>
                                <th style=""width: 120px"">
                                    <b>	Normal Value</b>
                                </th>

                                <th style=""width: 120px"">
                                    <b>Actions</b>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
            WriteLiteral(@"                        </tbody>
                    </table>


                    <br>
                    <div style=""clear: both;"">
                    </div>
                    <br>
                    <br>
                    <iframe style=""display: none"" id=""if_-2_119""");
            BeginWriteAttribute("src", " src=\"", 9858, "\"", 9864, 0);
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
        $(""#newPage"").load(""/ManagementDocuments/CreateNormalOperations/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/ManagementDocuments/EditNormalOperations/""+id);
    }


    function showPage1() {
        $(""#Tabs"").load(""/Operational/Sensors/"");
    }

    function showPage2() {
        $(""#Tabs"").load(""/Operational/ChemicalWater/"");
    }

    function showPage3() {
        $(""#Tabs"").load(""/Operational/Environmental/"");
    }


    $(""#checkAll"").click(function () {
        $("".checkBox"").prop('checked',
            $(this).prop('checked'));
    });

    $(""#delete"").click");
            WriteLiteral(@"(function () {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
