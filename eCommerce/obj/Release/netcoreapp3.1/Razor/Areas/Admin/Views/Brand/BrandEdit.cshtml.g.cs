#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "201dd114646a9489d4fd5a7617fea845dab86415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Brand_BrandEdit), @"mvc.1.0.view", @"/Areas/Admin/Views/Brand/BrandEdit.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"201dd114646a9489d4fd5a7617fea845dab86415", @"/Areas/Admin/Views/Brand/BrandEdit.cshtml")]
    public class Areas_Admin_Views_Brand_BrandEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Concrete.Brand>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
  
    ViewBag.Title = "BrandCreate";
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
                        <h1 class=""card-title"" style=""margin-top: 8px;"">

                            BrandBilgisi

                        </h1>
                    </div>

                </div>


                <div class=""card-body"">

");
#nullable restore
#line 29 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                     using (Html.BeginForm("BrandEdit", "Brand", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div style=\"display:flex\">\r\n\r\n\r\n                            <div class=\"col-md-10\">\r\n\r\n");
#nullable restore
#line 36 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                                 if (ViewBag.Message != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <script>\r\n                                pushalert(\"");
#nullable restore
#line 39 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                                      Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\"");
#nullable restore
#line 39 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                                                         Write(ViewBag.AlertType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n\r\n                                    </script>\r\n");
#nullable restore
#line 42 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                ");
#nullable restore
#line 45 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"form-horizontal\">\r\n                                    <hr />\r\n                                    ");
#nullable restore
#line 49 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 50 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                               Write(Html.HiddenFor(model => model.Id, new { htmlAttributes = new { @class = "form-control col-md-6" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"form-group\">\r\n                                        <div class=\"col-md-2\"> Sıra</div>\r\n\r\n                                        <div class=\"col-md-10\">\r\n                                            ");
#nullable restore
#line 55 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                                       Write(Html.EditorFor(model => model.BrandName, new { htmlAttributes = new { @class = "form-control col-md-6" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 56 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.BrandName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>


                                    <div class=""form-group"">
                                        <div class=""col-md-offset-2 col-md-10"">
                                            <input type=""submit"" value=""Kaydet"" class=""btn btn-default"" id=""kaydet"" name=""kaydet"" />
                                        </div>
                                    </div>
                                </div>

                                <br /> <br />
                                <div>

                                    ");
#nullable restore
#line 71 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                               Write(Html.ActionLink("Geri Dön", "BrandList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n\r\n\r\n\r\n\r\n                        </div>\r\n");
#nullable restore
#line 81 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Brand\BrandEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Concrete.Brand> Html { get; private set; }
    }
}
#pragma warning restore 1591