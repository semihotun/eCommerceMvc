#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4f9d8c1d0de234433104995050430b6f9962637"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SpeficationAttribute_SpeficationAttributeCreate), @"mvc.1.0.view", @"/Areas/Admin/Views/SpeficationAttribute/SpeficationAttributeCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4f9d8c1d0de234433104995050430b6f9962637", @"/Areas/Admin/Views/SpeficationAttribute/SpeficationAttributeCreate.cshtml")]
    public class Areas_Admin_Views_SpeficationAttribute_SpeficationAttributeCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.SpecificationAttributeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeCreate.cshtml"
  
    ViewData["Title"] = "SpeficationAttributeCreate";
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

                </div>
                <div class=""card-body"">

");
#nullable restore
#line 21 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeCreate.cshtml"
                     using (Html.BeginForm("SpeficationAttributeCreate", "SpeficationAttribute", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div style=\"display:flex;flex-wrap:wrap;\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeCreate.cshtml"
                       Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 26 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeCreate.cshtml"
                           Write(Html.LabelFor(x => x.Name, "İsmi", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 29 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeCreate.cshtml"
                               Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control  col-md-8" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 35 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeCreate.cshtml"
                           Write(Html.LabelFor(x => x.DisplayOrder, "Sıra", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 38 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeCreate.cshtml"
                               Write(Html.TextBoxFor(x => x.DisplayOrder, new { @class = "form-control  col-md-8" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>

                            <div class=""form-group col-md-12"">


                                <div class=""col-md-10"">
                                    <input type=""submit"" class=""btn btn-default"" />
                                </div>
                            </div>


                        </div>
");
#nullable restore
#line 52 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\SpeficationAttribute\SpeficationAttributeCreate.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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