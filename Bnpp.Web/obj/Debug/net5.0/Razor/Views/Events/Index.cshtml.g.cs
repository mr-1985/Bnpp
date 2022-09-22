#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be78409eb71f20e5fbbe60d6ba6816bb2d2da894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be78409eb71f20e5fbbe60d6ba6816bb2d2da894", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.Events>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout1.cshtml";

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
            BeginWriteAttribute("style", " style=\"", 724, "\"", 732, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b><a class=\"breadcumb2-link\" href=\"#\">Mechanical Equipments</a></b>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 880, "\"", 888, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        » Events<b id=""subTitle22a""></b>
                    </td>
                    <td>
                        <b style=""color: #ff0000;"" id=""subTitle22""></b>
                    </td>
                </tr>
            </tbody>
        </table>
        <a id=""iHelp"" style=""float: right; position: relative; top: -32px;"" href=""javascript:;"" onclick=""showHelp();"">
            <img src=""/images/help.png"" style=""width: 48px;"" class=""imgHelp"">
        </a>
    </div>

<h1 id=""iH1"">
    Events
</h1>
    <div id=""iContent"">

       

        <div id=""tab1"" class=""tab-item"" style=""display: block;"">

            

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


                    <a class=""btn-new-equip"" style=""cursor:pointer"" onclick=""Create()"">New</a>
                    <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
                    <br />
");
#nullable restore
#line 118 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                      
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
                                    <b>Event Name</b>
                                </th>
                                <th >
                                    <b>Event Level</b>
                                </th>
                                <th >
                                    <b>Event Date</b>
                                </th>
");
            WriteLiteral(@"                                <th >
                                    <b>Report Date</b>
                                </th>
                                <th >
                                    <b>Report No.</b>
                                </th>
                                <th >
                                    <b>Responsible Unit</b>
                                </th>
                                <th >
                                    <b>Event Location</b>
                                </th>
                                <th >
                                    <b>Operational Organization</b>
                                </th>
                                <th></th>
                                <th></th>
                                <th style=""width: 120px"">
                                    <b>Actions</b>
                                </th>
                            </tr>
                        </thead>
                        <tbod");
            WriteLiteral("y>\r\n");
#nullable restore
#line 163 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr role=\"row\">\r\n                                    <td>\r\n                                        <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 7440, "\"", 7462, 1);
#nullable restore
#line 167 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
WriteAttributeValue("", 7448, item.EventsId, 7448, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 170 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                   \r\n                                    <td>\r\n                                        ");
#nullable restore
#line 174 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                                   Write(item.EventName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 177 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                                   Write(item.EventLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 180 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                                   Write(item.EventDate.ToString("yyyy/MM/dd HH:MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 183 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                                   Write(item.ReportDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 186 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                                   Write(item.ReportNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 189 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                                   Write(item.ResponsibleUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 192 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                                   Write(item.EventLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 195 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
                                   Write(item.OperationalOrganization);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 8981, "\"", 9028, 3);
            WriteAttributeValue("", 8991, "ShowStatusbeforeEvent(", 8991, 22, true);
#nullable restore
#line 198 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
WriteAttributeValue("", 9013, item.EventsId, 9013, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9027, ")", 9027, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Status before Event\r\n                                        </a>\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 9270, "\"", 9315, 3);
            WriteAttributeValue("", 9280, "ShowStatusFterEvent(", 9280, 20, true);
#nullable restore
#line 203 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
WriteAttributeValue("", 9300, item.EventsId, 9300, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9314, ")", 9314, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                            Status after Event
                                        </a>
                                    </td>
                                    <td>
                                        <a class=""btn-edit-equip""");
            BeginWriteAttribute("onclick", " onclick=\"", 9579, "\"", 9609, 3);
            WriteAttributeValue("", 9589, "Edit(", 9589, 5, true);
#nullable restore
#line 208 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
WriteAttributeValue("", 9594, item.EventsId, 9594, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9608, ")", 9608, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Edit\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 213 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Events\Index.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 10153, "\"", 10159, 0);
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
        $(""#newPage"").load(""/Events/CraeteEvents/"");
    }

    function Edit(id) {
        $(""#newPage"").load(""/ManagementDocuments/EditNormalOperations/""+id);
    }

    
    function ShowStatusbeforeEvent(id) {
        $(""#newPage"").load(""/Events/BeforeStatus/"" + id);
    }


    function ShowStatusFterEvent(id) {
        $(""#newPage"").load(""/Events/AfterStatus/"" + id);
    }

    

    $(""#checkAll"").click(function () {
        $("".checkBox"").prop('checked',
            $(this).prop('checked'));
    });

    $(""#delete"").click(function () {
        var selectedIDs = new Array();

        $('i");
            WriteLiteral(@"nput:checkbox.checkBox').each(function () {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.Events>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
