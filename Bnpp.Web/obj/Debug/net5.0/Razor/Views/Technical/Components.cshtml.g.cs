#pragma checksum "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7835ace692baaa41225acbe71f52d647a9b6e418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Technical_Components), @"mvc.1.0.view", @"/Views/Technical/Components.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7835ace692baaa41225acbe71f52d647a9b6e418", @"/Views/Technical/Components.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Technical_Components : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bnpp.DataLayer.Entities.BasicData.Components>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
  
    ViewData["Title"] = "Components";
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
            BeginWriteAttribute("style", " style=\"", 715, "\"", 723, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b><a class=\"breadcumb2-link\" href=\"#\">Mechanical Equipments</a></b>\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 871, "\"", 879, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        » <b id=""subTitle22a""></b>
                    </td>
                    <td>
                        » Basic Data<b style=""color: #ff0000;"" id=""subTitle22"">
                            » Components
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
        Basic Data
    </h1>
    <div id=""iContent"">

        <div class=""tab-buttons"">
            <ul>
                <li id=""tab-button1"" class=""tab-buttons-li"" ");
            WriteLiteral(" ");
            WriteLiteral(@">
                    <a id=""tab-button-a1""
                       onclick=""showPage1()"" style=""cursor:pointer;color: rgb(0, 113, 158);"">
                        General Data
                    </a>
                </li>
                <li id=""tab-button2"" ");
            WriteLiteral(@" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-buttona2"" onclick=""showPage2()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Design Data
                    </a>

                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage3()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Documents

                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage4()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Safety class & Seismic category

              ");
            WriteLiteral(@"      </a>
                </li>

                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage5()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Components

                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage6()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Chemical Norms
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage7()"" style=""cursor:pointer;colo");
            WriteLiteral(@"r: rgb(110, 110, 255);"">
                        Technical Programs
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage8()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Sensors
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
                    <a id=""tab-button-a3"" onclick=""showPage9()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        Control Points
                    </a>
                </li>
                <li id=""tab-button3"" class=""tab-buttons-li"" style=""background-color: rgb(240, 240, 240); border-color: rgb(192, 192, 192); font-weight: normal;"">
             ");
            WriteLiteral(@"       <a id=""tab-button-a3"" onclick=""showPage10()"" style=""cursor:pointer;color: rgb(110, 110, 255);"">
                        H-Forms
                    </a>
                </li>
            </ul>

            <div style=""clear:both;""></div>
        </div>

        <div id=""tab1"" class=""tab-item"" style=""display: block;"">

            <h1 id=""iH1"">Components</h1>

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
            WriteLiteral("            </div>\r\n\r\n            <div id=\"newPage\">\r\n                <div>\r\n\r\n                    <div id=\"iLoading22\" style=\"display: none;\">\r\n                        <img src=\"/images/loading.gif\">\r\n                    </div>\r\n\r\n\r\n");
            WriteLiteral("                    <br />\r\n");
#nullable restore
#line 181 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                      
                        int rowCount = 1;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table id=""myTable"" class=""show-table"">
                        <thead>
                            <tr role=""row"">
                                <th></th>
                                <th>
                                    <b>Element Name</b>
                                </th>
                                <th>
                                    <b>Designation</b>
                                </th>

                                <th>
                                    <b>Serial No.	 </b>
                                </th>

                                <th>
                                    <b>	 Diameter</b>
                                </th>
                                <th>
                                    <b>	Thickness</b>
                                </th>
                                <th>
                                    <b>	Length</b>
                                </th>
                                <th>
      ");
            WriteLiteral(@"                              <b>	Material Grade</b>
                                </th>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
                                <th></th>
");
            WriteLiteral("\r\n");
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 236 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr role=\"row\">\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 240 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                                   Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 243 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                                   Write(item.Item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 246 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                                   Write(item.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 249 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                                   Write(item.Serial);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 252 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                                   Write(item.Diameter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 255 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                                   Write(item.Thickness);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 258 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                                   Write(item.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 261 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
                                   Write(item.MaterialGrade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
            WriteLiteral("                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 13750, "\"", 13803, 3);
            WriteAttributeValue("", 13760, "ShowMechanicalProperties(", 13760, 25, true);
#nullable restore
#line 281 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
WriteAttributeValue("", 13785, item.ComponentId, 13785, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 13802, ")", 13802, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Mechanical Properties\r\n                                        </a>\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 14047, "\"", 14098, 3);
            WriteAttributeValue("", 14057, "ShowPhysicalProperties(", 14057, 23, true);
#nullable restore
#line 286 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
WriteAttributeValue("", 14080, item.ComponentId, 14080, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 14097, ")", 14097, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Physical Properties\r\n                                        </a>\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 14340, "\"", 14393, 3);
            WriteAttributeValue("", 14350, "ShowChemicalCompositions(", 14350, 25, true);
#nullable restore
#line 291 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
WriteAttributeValue("", 14375, item.ComponentId, 14375, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 14392, ")", 14392, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Chemical Compositions\r\n                                        </a>\r\n                                    </td>\r\n");
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 306 "C:\Users\mohsen\source\New folder\Bnpp.Web\Views\Technical\Components.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 15516, "\"", 15522, 0);
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
          $(""#newPage"").load(""/Technical/EditNormalOperations/""+id);
      }


      function ShowMechanicalProperties(id) {
        $(""#newPage"").load(""/Technical/MechanicalProperties/"" + id);
        }

    function ShowPhysicalProperties(id) {
        $(""#newPage"").load(""/Technical/PhysicalProperties/"" + id);
    }

    function ShowChemicalCompositions(id) {
        $(""#newPage"").load(""/Technical/ChemicalComponent/"" + id);
    }

    

    function showPage1() {
          $(""#Tabs"").load(""/Technical");
            WriteLiteral(@"/GeneralData/"");
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

       function showPage6() {
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
");
            WriteLiteral(@"
      $(""#delete"").click(function () {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bnpp.DataLayer.Entities.BasicData.Components>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
