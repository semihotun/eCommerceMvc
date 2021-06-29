#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProductAttr\ProductAttributeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7746dab29e948b9d2668ef21ca83d3869528aa87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProductAttr_ProductAttributeList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProductAttr/ProductAttributeList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7746dab29e948b9d2668ef21ca83d3869528aa87", @"/Areas/Admin/Views/AdminProductAttr/ProductAttributeList.cshtml")]
    public class Areas_Admin_Views_AdminProductAttr_ProductAttributeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.ProductAttributeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\AdminProductAttr\ProductAttributeList.cshtml"
  
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
                    <div class=""col-md-4"" style=""float:left;"">
                        <h2 class=""card-title"">Özellik Ekle</h2>
                    </div>
                    <div class=""col-md-8"" style=""float:right;"">
                        <ul class=""nav"" style=""float:right;"">
                            <a class=""btn btn-outline-default pd10-50"" href=""/Admin/AdminProductAttr/AttrCreate"">Ekle</a>
                        </ul>
                    </div>
                </div>
                <div class=""card-body"">


                    <div class=""table-responsive"">

                        <div class=""table-responsive ps ps--active-x"">


                            <table id=""ProductAttrList"" class=""table tablesorter table-hover dt-responsive nowrapr"" width=""100%"" cellspacing=""0"">
                                <thead>
        ");
            WriteLiteral(@"                            <tr>
                                        <th>Id</th>
                                        <th>Açıklama</th>
                                        <th>İsim</th>
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
                                if ($.fn.DataTable.isDataTable(""#ProductAttrList"")) {
                                    ProductListTableo.draw();

                                }
                                else {

                                    ProductListTableo = $(""#ProductAttrList"").DataTable({
                                        ""sAjaxSour");
            WriteLiteral(@"ce"": ""/Admin/AdminProductAttr/ProductAttributeListJson"",
                                        ""bServerSide"": true,
                                        ""bProcessing"": true,
                                        ""bSearchable"": true,
                                        ""bLengthChange"": false,
                                        ""searching"": false,

                                        ""columns"": [
                                            { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true },
                                            { ""data"": ""Description"", ""name"": ""Description"", ""autoWidth"": true },
                                            { ""data"": ""Name"", ""name"": ""Name"", ""autoWidth"": true },
                                            {
                                                data: null,
                                                render: function (data, type, row) {
                                                    return ""<a href='/Admin/AdminProductAttr/A");
            WriteLiteral(@"ttrEdit?Id="" + row.Id + ""'><i class='fa fa-edit datatableduzenle' style='font-size:20px;'></i></a>"" +
                                                        ""<a href='/Admin/AdminProductAttr/AttrDelete?Id="" + row.Id + ""' ><i class='fa fa-trash-o datatablesil ' style='font-size:20px;' ></i></a>"";
                                                }, ""orderable"": false
                                            },


                                        ],
                                        oLanguage: {
                                            oPaginate: {
                                                sPrevious: '<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-arrow-left""><line x1=""19"" y1=""12"" x2=""5"" y2=""12""></line><polyline points=""12 19 5 12 12 5""></polyline></svg>',
                                                sNext: '<svg xmlns=""h");
            WriteLiteral(@"ttp://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-arrow-right""><line x1=""5"" y1=""12"" x2=""19"" y2=""12""></line><polyline points=""12 5 19 12 12 19""></polyline></svg>'

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
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.ProductAttributeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
