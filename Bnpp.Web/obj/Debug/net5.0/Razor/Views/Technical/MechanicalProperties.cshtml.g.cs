#pragma checksum "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df35482908efd7356c7c91c46daee09761bb64bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Technical_MechanicalProperties), @"mvc.1.0.view", @"/Views/Technical/MechanicalProperties.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df35482908efd7356c7c91c46daee09761bb64bf", @"/Views/Technical/MechanicalProperties.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Technical_MechanicalProperties : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.BasicData.MechanicalProperties>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
  
    ViewData["Title"] = "MechanicalProperties";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""newPage"">
    <div>

        <div id=""iLoading22"" style=""display: none;"">
            <img src=""/images/loading.gif"">
        </div>


        <a class=""btn-new-equip"" style=""cursor: pointer"" onclick=""Create()"">New</a>
        <input type=""button"" id=""delete"" class=""btn-delete-equip"" value=""Delete"">
        <br />
");
#nullable restore
#line 20 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
          
            int rowCount = 1;
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table id=""myTable"" cellpadding=""3"" cellspacing=""0"" class=""show-table"">
            <thead>
                <tr role=""row"">
                    <th>
                        <input type=""checkbox"" id=""checkAll"" />
                    </th>
                    <th></th>
                    <th>
                        <b>Temperature</b>
                    </th>
                    <th>
                        <b>Young Module</b>
                    </th>

                    <th>
                        <b>Yield Strength</b>
                    </th>

                    <th>
                        <b>Ultimate Strength</b>
                    </th>
                    <th>
                        <b>Specific Elongation</b>
                    </th>
                    <th>
                        <b>	Reduction Area</b>
                    </th>
                    <th>
                        <b>	Impact Toughness j/cm2</b>
                    </th>
                    <th");
            WriteLiteral(">\r\n                        <b>\tHardness</b>\r\n                    </th>\r\n                    <th>\r\n                        <b>Actions</b>\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 62 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr role=\"row\">\r\n                        <td>\r\n                            <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2002, "\"", 2027, 1);
#nullable restore
#line 66 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
WriteAttributeValue("", 2010, item.ComponentId, 2010, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                       Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                       Write(item.Temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                       Write(item.YoungModule);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                       Write(item.YieldStrength);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 81 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                       Write(item.UltimateStrength);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                       Write(item.SpecificElongation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 87 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                       Write(item.ReductionArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 90 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                       Write(item.ImpactToughness);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 93 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                       Write(item.Hardness);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn-edit-equip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3128, "\"", 3161, 3);
            WriteAttributeValue("", 3138, "Edit(", 3138, 5, true);
#nullable restore
#line 96 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
WriteAttributeValue("", 3143, item.ComponentId, 3143, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3160, ")", 3160, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Edit\r\n                            </a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 101 "C:\Users\payetakht\source\repos\Bnpp\Bnpp.Web\Views\Technical\MechanicalProperties.cshtml"
                    rowCount++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n        <br>\r\n        <div style=\"clear: both;\">\r\n        </div>\r\n        <br>\r\n        <br>\r\n        <iframe style=\"display: none\" id=\"if_-2_119\"");
            BeginWriteAttribute("src", " src=\"", 3537, "\"", 3543, 0);
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
         $(""#newPage"").load(""/Technical/CreateComponents/"");
     }

     function Edit(id) {
         $(""#newPage"").load(""/Technical/EditComponents/""+id);
     }



    function showPage1() {
         $(""#Tabs"").load(""/Technical/GeneralData/"");
     }

     function showPage2() {
         $(""#Tabs"").load(""/Technical/DesignData/"");
     }

     function showPage3() {
         $(""#Tabs"").load(""/Technical/Documents/"");
     }

     function showPage4() {
         $(""#Tabs"").load(""/Technical/Safety/"");
     }

     function showPage5() {
         $(""#Tabs"").load(""/Technical/Components/"");
     }

      function showPage");
            WriteLiteral(@"6() {
         $(""#Tabs"").load(""/Technical/ChemicalNorms"");
     }

     function showPage7() {
         $(""#Tabs"").load(""/Technical/TechnicalPrograms/"");
     }

     function showPage8() {
         $(""#Tabs"").load(""/Technical/Sensors"");
     }

     function showPage9() {
         $(""#Tabs"").load(""/Technical/ControlPoints/"");
     }

     function showPage10() {
         $(""#Tabs"").load(""/Technical/HForms/"");
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
             url: ""/Technical/DeleteComponents"",
             data: { ""componentsId"": selectedIDs },

             success: fun");
            WriteLiteral(@"ction (response) {
                 $(""#Tabs"").load(""/Technical/Safety/"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.BasicData.MechanicalProperties>> Html { get; private set; }
    }
}
#pragma warning restore 1591
