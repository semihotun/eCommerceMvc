#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e568df23566e51a5880e941dad5e1e5c3edcce56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SpeficationAttribute_SpeficationAttributeList), @"mvc.1.0.view", @"/Areas/Admin/Views/SpeficationAttribute/SpeficationAttributeList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e568df23566e51a5880e941dad5e1e5c3edcce56", @"/Areas/Admin/Views/SpeficationAttribute/SpeficationAttributeList.cshtml")]
    public class Areas_Admin_Views_SpeficationAttribute_SpeficationAttributeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.SpecificationAttributeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeList.cshtml"
  
    ViewBag.Title = "ShowcaseCreate";
    Layout = "~/Views/Shared/_AdminLayoutPage1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card "">
                <div class=""card-header"">
                    <div class=""col-md-5"" style=""float:left;"">
                        <h2 class=""card-title"">Ürün Özellik Seçeneği Ekle</h2>
                    </div>
                    <div class=""col-md-7"" style=""float:right;"">
                        <ul class=""nav"" style=""float:right;"">

                            <a class=""btn btn-outline-default pd10-50"" href=""/Admin/SpeficationAttribute/SpeficationAttributeCreate"">Ekle</a>
                        </ul>
                    </div>
                </div>
                <div class=""card-body"">


                    <div class=""table-responsive"">

                        <div class=""table-responsive ps ps--active-x"">


                            <table id=""SpeficationList"" class=""table tablesorter table-hover dt-responsive nowrapr"" width=""100%"" cellspacing=""0"">
             ");
            WriteLiteral(@"                   <thead>
                                    <tr>
                                        <th>Id</th>
                                        <th>Name</th>
                                        <th>Sıra</th>
                                        <th> </th>
                                    </tr>
                                </thead>
                                <tbody>
                                </tbody>
                            </table>
                        </div>

                 
                        <script>
                            var ProductListTableo;
                            var BindProductList = function (response) {
                                if ($.fn.DataTable.isDataTable(""#SpeficationList"")) {
                                    ProductListTableo.draw();

                                }
                                else {

                                    ProductListTableo = $(""#SpeficationList"").DataTable({
 ");
            WriteLiteral(@"                                       ""sAjaxSource"": ""/Admin/SpeficationAttribute/SpeficationAttributeListJson"",
                                        ""bServerSide"": true,
                                        ""bProcessing"": true,
                                        ""bSearchable"": true,
                                        ""bLengthChange"": false,
                                        ""searching"": false,

                                        ""columns"": [
                                            { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true },
                                            { ""data"": ""Name"", ""name"": ""Name"", ""autoWidth"": true },
                                            { ""data"": ""DisplayOrder"", ""name"": ""DisplayOrder"", ""autoWidth"": true },
                                            {
                                                data: null,
                                                render: function (data, type, row) {
                                   ");
            WriteLiteral(@"                 return ""<a href='/Admin/SpeficationAttribute/SpeficationAttributeDelete?Id="" + row.Id + ""'><i class='fa fa-trash-o datatablesil ' style='font-size:20px;' ></i></a>"" +
                                                        "" <a href='/Admin/SpeficationAttribute/SpeficationAttributeEdit?Id="" + row.Id + ""' ><i class='fa fa-edit datatableduzenle' style='font-size:20px;'></i></a>"";
                                                }, ""orderable"": false
                                            },


                                        ],
                                        oLanguage: {
                                            oPaginate: {
                                                sPrevious: '<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-arrow-left""><line x1=""19"" y1=""12"" x2=""5"" y2=""12""></line><polyline points=""12 19 5");
            WriteLiteral(@" 12 12 5""></polyline></svg>',
                                                sNext: '<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-arrow-right""><line x1=""5"" y1=""12"" x2=""19"" y2=""12""></line><polyline points=""12 5 19 12 12 19""></polyline></svg>'

                                            }
                                        }

                                    });

                                }

                            }


                            var FilterRecord = function () {
                                BindProductList();
                            }
                            $(document).ready(function () {
                                BindProductList();

                            });
                        </script>



                    </div>

                </div>
            </div>
   ");
            WriteLiteral("     </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.SpecificationAttributeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591