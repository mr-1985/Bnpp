#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b30f1b8f3c0feae4a06066922caf345845526e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AgeingMechanism_Mechanism), @"mvc.1.0.view", @"/Views/AgeingMechanism/Mechanism.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b30f1b8f3c0feae4a06066922caf345845526e", @"/Views/AgeingMechanism/Mechanism.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AgeingMechanism_Mechanism : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.AgeingMechanism.Mechanism>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
  
    ViewData["Title"] = "Mechanism";
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
            BeginWriteAttribute("style", " style=\"", 720, "\"", 728, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b><a class=\"breadcumb2-link\" href=\"#\">Mechanical Equipments</a></b>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 876, "\"", 884, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        » Ageing Mechanism<b id=""subTitle22a""></b>
                    </td>
                    <td>
                        » <b style=""color: #ff0000;"" id=""subTitle22"">Ageing Mechanism</b>
                    </td>
                </tr>
            </tbody>
        </table>
        <a id=""iHelp"" style=""float: right; position: relative; top: -32px;"" href=""javascript:;"" onclick=""showHelp();"">
            <img src=""/images/help.png"" style=""width: 48px;"" class=""imgHelp"">
        </a>
    </div>

    <h1 id=""iH1"">
        Ageing Mechanism
    </h1>
    <div id=""iContent"">

        <div class=""tab-buttons"">
            <ul>
                <li id=""tab-button1"" class=""tab-buttons-li"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
                    <a id=""tab-button-a1""
                       onclick=""showPage1()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                        Ageing Mechanism
                    </a>
                </li>
                <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-buttona2"" onclick=""showPage2()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                         Documents
                    </a>

                </li>
               
            </ul>

            <div style=""clear:both;""></div>
        </div>

        <div id=""tab1"" class=""tab-item"" style=""display: block;"">

            <h1 id=""iH1"">Ageing Mechanism</h1>

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
#line 136 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
                      
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
                                    <b>Degradation Mechanism</b>
                                </th>
                                <th >
                                    <b>Component</b>
                                </th>
                                <th >
                                    <b>Region</b>
                                </th>
                                <th >
                                    <b>Critical point</b>
                                </th>
                                <th >
                                    <b>Consequences</b>
                  ");
            WriteLiteral("              </th>\r\n                                <th >\r\n                                    <b>Actions</b>\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 167 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr role=\"row\">\r\n                                    <td>\r\n                                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 7876, "\"", 7901, 1);
#nullable restore
#line 171 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
WriteAttributeValue("", 7884, item.MechanismId, 7884, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 174 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
                                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 177 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
                                   Write(item.DegradationMechanism);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 180 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
                                   Write(item.Component);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 183 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
                                   Write(item.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 186 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
                                   Write(item.CriticalPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 189 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
                                   Write(item.Consequences);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8918, "\"", 8951, 3);
            WriteAttributeValue("", 8928, "Edit(", 8928, 5, true);
#nullable restore
#line 192 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
WriteAttributeValue("", 8933, item.MechanismId, 8933, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8950, ")", 8950, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Edit\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 197 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\AgeingMechanism\Mechanism.cshtml"
                                rowCount++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>


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
        $(""#newPage"").load(""/AgeingMechanism/CreateMechanism/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/AgeingMechanism/EditMechanism/""+id);
    }

    

    function showPage1() {
        $(""#Tabs"").load(""/AgeingMechanism/Mechanism/"");
    }

    function showPage2() {
        $(""#Tabs"").load(""/AgeingMechanism/Documents/"");
       
    }

    

    

    $(""#checkAll"").click(function () {
        $("".checkBox"").prop('checked',
            $(this).prop('checked'));
    });

    $(""#delete"").click(function () {
        var");
            WriteLiteral(@" selectedIDs = new Array();

        $('input:checkbox.checkBox').each(function () {
            if ($(this).prop('checked')) {
                selectedIDs.push($(this).val());
            }
        });

        $.ajax({
            type: ""POST"",
            url: ""/AgeingMechanism/DleteMechanism"",
            data: { ""mechanismId"": selectedIDs },

            success: function (response) {
                $(""#Tabs"").load(""/AgeingMechanism/Mechanism/"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.AgeingMechanism.Mechanism>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
