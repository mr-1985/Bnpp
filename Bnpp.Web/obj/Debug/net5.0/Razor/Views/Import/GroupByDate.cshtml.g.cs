#pragma checksum "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95b617070826177875f51c9441641e328a5835d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Import_GroupByDate), @"mvc.1.0.view", @"/Views/Import/GroupByDate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b617070826177875f51c9441641e328a5835d1", @"/Views/Import/GroupByDate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Import_GroupByDate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.DamageabilityReport>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = null;
    //Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 14 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
  
    int rowCount = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table id=\"myTable\" ");
            WriteLiteral(@" aria-describedby=""example_info"" class=""display dataTable"">
    <br />
    <div id=""myTable_filter"" class=""dataTables_filter"">
        <label>
            Search Date: <input name=""searchDate"" id=""searchDate"" onchange=""GetDate();"" style=""direction: ltr; text-align: left;"">
        </label>
    </div>
    <br />
    <thead>
        <tr role=""row"">
            <th>
                <input type=""checkbox"" id=""checkAll"" />
            </th>
            <th></th>
            <th onclick=""GroupByAkz()"">
                <b>AKZ</b>
            </th>
            <th>
                <b>Date</b>
            </th>
            <th>
                <b>Location of the checkpoint</b>
            </th>
            <th>
                <b>Action period of equipment (years)</b>
            </th>
            <th>
                <b>Life time of equipment in design (years)</b>
            </th>
            <th>
                <b>
                    Life time of equipment per RALDS (years)
       ");
            WriteLiteral(@"         </b>
            </th>
            <th>
                <b>
                    Damageability per coiled cycles
                </b>
            </th>
            <th>
                <b>
                    Damageability per uncoiled cycles
                </b>
            </th>
            <th>
                <b>
                    Total damageability of equipment
                </b>
            </th>
            <th>
                <b>
                    Allowable CUF
                </b>
            </th>
            <th>
                <b>
                    Allowable Remaining Life Time
                </b>
            </th>
            <th>
                <b>
                    Changing Ratio
                </b>
            </th>
            <th>
                <b>
                    Allowable Changing Ratio
                </b>
            </th>
            <th>
                <b>
                    File Date
                </b>
        ");
            WriteLiteral("    </th>\r\n            <th>\r\n                <b>\r\n\r\n                </b>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 100 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr role=\"row\">\r\n                <td>\r\n                    <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2625, "\"", 2641, 1);
#nullable restore
#line 104 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
WriteAttributeValue("", 2633, item.ID, 2633, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 107 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 110 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.Akz);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 113 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.ReportDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 116 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.Locationofthecheckpoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 119 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.Actionperiodofequipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 122 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.Lifetimeofequipmentindesign);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 124 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                 if ((Convert.ToDecimal(item.LifetimeofequipmentperRALDS)) <= (Convert.ToDecimal(item.AllowableLifeTime)))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"background-color:red;\">\r\n                        ");
#nullable restore
#line 127 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                   Write(item.LifetimeofequipmentperRALDS);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 129 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 133 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                   Write(item.LifetimeofequipmentperRALDS);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 135 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 137 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.Damageabilitypercoiledcycles);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 140 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.Damageabilityperuncoiledcycles);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 142 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                 if ((Convert.ToDecimal(item.Totaldamageabilityofequipment)) >= (Convert.ToDecimal(item.AllowableCUF)))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"background-color:red;\">\r\n                        ");
#nullable restore
#line 145 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                   Write(item.Totaldamageabilityofequipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 147 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 151 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                   Write(item.Totaldamageabilityofequipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 153 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>\r\n                    ");
#nullable restore
#line 156 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.AllowableCUF);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 159 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.AllowableLifeTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 161 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                 if ((Convert.ToDecimal(item.AllowableChangingRatio)) <= (Convert.ToDecimal(item.ChangingRatio)))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"background-color:red;\">\r\n                        ");
#nullable restore
#line 164 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                   Write(item.ChangingRatio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 166 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 170 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                   Write(item.ChangingRatio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 172 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>\r\n                    ");
#nullable restore
#line 175 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.AllowableChangingRatio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 181 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
               Write(item.CreateDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("href", " href=\"", 5361, "\"", 5408, 2);
            WriteAttributeValue("", 5368, "/Import/EditDamageabilityReport/", 5368, 32, true);
#nullable restore
#line 184 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
WriteAttributeValue("", 5400, item.ID, 5400, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        Edit\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 189 "C:\Users\taban\source\repos\Bnpp\Bnpp.Web\Views\Import\GroupByDate.cshtml"
            rowCount++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<link href=\"/css/kendo.common.min.css\" rel=\"stylesheet\" />\r\n<link href=\"/css/kendo.default.min.css\" rel=\"stylesheet\" />\r\n<link href=\"/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n\r\n");
            WriteLiteral("\r\n<script src=\"/js/jquery.min.js\"></script>\r\n<script src=\"/js/kendo.all.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95b617070826177875f51c9441641e328a5835d116646", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95b617070826177875f51c9441641e328a5835d117686", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<script>
    // create DatePicker from input HTML element
    $(""#reportDate"").kendoDatePicker();
    $(""#searchDate"").kendoDatePicker();
    $(""#searchfileDate"").kendoDatePicker(
        {
            format: ""yyyy/MM/dd""
        });

    $(""#schDate"").kendoDatePicker(
        {
            format: ""yyyy/MM/dd""
        });


</script>

<script src=""/js/jquery.min.js""></script>

<script src=""/js/datatables.min.js""></script>

<script>
    //$(document).ready(function () {
    //    $(""#myTable"").DataTable();
    //});
</script>


<script>

    function Edit(id) {
        $(""#newPage"").load(""/Import/EditDamageabilityReport/"" + id);
    }


    //<------- GROUPING BY HEADERS  ------->
    function GetGroupByDate() {
        $(""#GroupBy"").load(""/Import/GroupByDatessss/"");
    }

    function GroupByAkz() {
        window.location = ""/Import/GroupByDatessss/"";
    }



    //<------- END GROUPING BY HEADERS  ------->

    function refreshPage() {
        // Your del");
            WriteLiteral(@"ay in milliseconds
        var delay = 3000;
        setTimeout(function () { window.location = ""/SACOR-446""; }, delay);
    }

    $('input:checkbox.checkBox').change(function () {
        var selectedIDs = new Array();
        $('input:checkbox.checkBox').each(function () {
            if ($(this).prop('checked')) {
                selectedIDs.push($(this).val());
            }
        });

        $('#exportSelectedData').val(selectedIDs);


        //alert(selectedIDs);
    });

    // $('input:checkbox.checkBox').prop('checked',function () {
    //        var selectedIDs = new Array();
    //           $('input:checkbox.checkBox').each(function () {
    //               if ($(this).prop('checked')) {
    //                   selectedIDs.push($(this).val());
    //               }
    //           });

    //           $('#exportSelectedData').val(selectedIDs);


    //   alert(selectedIDs);
    //});
    $(""#checkAll"").click(function () {
        $("".checkBox"").prop('chec");
            WriteLiteral(@"ked',
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
                url: ""/Import/DeleteDamageabilityReport"",
                data: { ""damagingId"": selectedIDs },
                success: function (response) {
                    window.location.href = ""/SACOR-446"";
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


    function GetDate() {
        var date = $('#sea");
            WriteLiteral(@"rchDate').val();

        $('input[type=search]').val(date);

        $('input[type=search]').focus();

        //$('searchDate').on('change', function () {
        //table.draw();


        $('#searchDate').val("""");

    };

    function GetSearchhDate() {
        var date = $('#searchfileDate').val();

        $('#schfileDate').val(date);

        $('#searchfileDate').val("""");

    };

    function GetSearchfromDate() {
        var date = $('#schDate').val();

        $('#srchDate').val(date);

        $('#schDate').val("""");

    };

    $(document).ready(function () {
        $('tbody tr[role=""row""]').hide();
    });

    //Group By Date


    //group
    $(document).ready(function () {
        var groupColumn = 3;
        var table = $('#myTable').DataTable({
            columnDefs: [{ visible: false, targets: groupColumn }],
            order: [[groupColumn, 'asc']],
            displayLength: 25,
            drawCallback: function (settings) {
             ");
            WriteLiteral(@"   var api = this.api();
                var rows = api.rows({ page: 'current' }).nodes();

                var last = null;

                api
                    .column(groupColumn, { page: 'current' })
                    .data()
                    .each(function (group, i) {
                        if (last !== group) {
                            $(rows)
                                .eq(i)
                                .before('<tr class=""group"" id=""group_' + i + '"" style=""background-color: rgba(0, 0, 0, 0.15);""><td class=""dt-control""></td><td colspan=""16"">' + group + '</td></tr>');

                            last = group;

                        }
                    });
            },
        });


        //Add parameter to class  class=""group'+i+'""
        // Order by the grouping
        $('#myTable tbody').on('click', 'tr.group', function () {



            $($(this)).nextUntil("".group"").filter('tr[role=""row""]').toggle();

        });

    });

</scrip");
            WriteLiteral("t>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.DamageabilityReport>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
