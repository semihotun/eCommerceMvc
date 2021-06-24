#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "315d426701b37f3d2dea2974e93c95628197417d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllCommentProduct), @"mvc.1.0.view", @"/Views/Home/AllCommentProduct.cshtml")]
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
#line 1 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\_ViewImports.cshtml"
using eCommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\_ViewImports.cshtml"
using Entities.ViewModels.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"315d426701b37f3d2dea2974e93c95628197417d", @"/Views/Home/AllCommentProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d30ff6fdd824442f6f381f94596e08d04456b7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllCommentProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Web.AllCommentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
  
    ViewBag.Title = "ProductDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!-- BREADCRUMB -->\r\n<div id=\"breadcrumb\">\r\n    <div class=\"container\">\r\n        <ul class=\"breadcrumb\">\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 300, "\"", 372, 2);
            WriteAttributeValue("", 307, "/Home/ProductDetail?productId=", 307, 30, true);
#nullable restore
#line 14 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
WriteAttributeValue("", 337, Model.ProductCommentDTO.Product.Id, 337, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ürüne geri Dön</a></li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<!-- /BREADCRUMB -->\r\n\r\n<div class=\"container\">\r\n    <div class=\"col-md-12 \">\r\n        <div class=\"product-reviews\">\r\n");
#nullable restore
#line 23 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
             if (Model.ProductCommentDTO.CommentList != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3 style=\"margin-top:50px;font-weight:100;\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
               Write(Model.ProductCommentDTO.Product?.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3><br />\r\n                <div class=\"single-review\" style=\"display:flex;border:1px solid #efecec;padding:20px;border-radius:10px;\">\r\n                    <div class=\"col-md-3\">\r\n\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 987, "\"", 1047, 1);
#nullable restore
#line 31 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
WriteAttributeValue("", 993, Model.ProductCommentDTO.ProductPhoto.ProductPhotoName, 993, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                             width=""225"" height=""225"" />

                    </div>


                    <div class=""single-review col-md-8"" style=""padding:20px;font-size:14px;padding-top:30px;"">
                        <div class=""review-heading"">
");
#nullable restore
#line 39 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                              var groupByComment = Model.ProductCommentDTO.CommentList.GroupBy(x => x.Rating); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                             for (int i = 1; i <=5; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-md-12\" style=\"display:flex\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <div class=\"review-rating pull-left \">\r\n");
#nullable restore
#line 46 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                             for (int j = 0; j < i; j++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 49 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>                                   \r\n");
#nullable restore
#line 51 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                           var ratingCount = groupByComment?.Where(x => x.Key == i).Count() != 0
                                                ? groupByComment.Where(x => x.Key == i).First().Count()
                                                : 0 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span style=\"padding-left:10px;\">(");
#nullable restore
#line 54 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                                                 Write(ratingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <div class=\"progress \">\r\n");
#nullable restore
#line 58 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                              var ratingPercent =ratingCount != 0 ? 100 / ((Model.ProductCommentDTO.CommentList.Count()) / ratingCount) : 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"progress-bar bg-warning\" role=\"progressbar\"\r\n                                                 aria-valuenow=\"0\" aria-valuemin=\"50\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", "\r\n                                                 style=\'", 2960, "\'", 3040, 3);
            WriteAttributeValue("", 3018, "width:", 3018, 6, true);
#nullable restore
#line 61 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
WriteAttributeValue("", 3024, ratingPercent, 3024, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3038, "%;", 3038, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>&nbsp;");
#nullable restore
#line 61 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                                                                       Write(ratingPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 65 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        </div>

                        <div class=""ortalama col-md-2 text-center"" style=""border:1px solid #FFB656;
                        padding:20px;box-sizing:border-box;border-radius:8px;height: 225px;
                        padding-top:50px;"">
                            <h4 style=""font-weight:100;color:#7f807e;"">  Ortalama Puan   </h4>
                            <div class=""review-rating pull-left"" style=""color:#FFB656;font-size:22px;"">
");
#nullable restore
#line 74 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                 for (int i = 1; i <= 5; i++)
                                {
                                    if (@Model.Averagecount >= i)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 79 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-star-o empty\"></i>\r\n");
#nullable restore
#line 83 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <br />\r\n                            <h2");
            BeginWriteAttribute("class", " class=\"", 4402, "\"", 4410, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-weight:100;margin:30px;color:#7f807e;\">");
#nullable restore
#line 87 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                                                                       Write(Model.Averagecount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n");
#nullable restore
#line 92 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div style=\"padding:20px;border-radius:10px;border:1px solid #efecec;\">\r\n");
#nullable restore
#line 97 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                 foreach (var item in Model.ProductCommentDTO.CommentList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-review\">\r\n                        <div class=\"review-heading\">\r\n");
            WriteLiteral("                            <div style=\"display:flex;align-items:baseline;\">\r\n                                <i class=\"fa fa-clock-o\"></i>\r\n                                <div class=\"ml-5\">");
#nullable restore
#line 104 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                             Write(item.CreatedOnUtc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"review-rating pull-right\">\r\n");
#nullable restore
#line 107 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                 for (int i = 1; i <= 5; i++)
                                {
                                    if (item.Rating >= i)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 112 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-star-o empty\"></i>\r\n");
#nullable restore
#line 116 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <div class=\"review-body\">\r\n                            <h4>");
#nullable restore
#line 121 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                           Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>\r\n                                ");
#nullable restore
#line 123 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
                           Write(item.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div><br /><br />\r\n");
#nullable restore
#line 127 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            ");
#nullable restore
#line 130 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Views\Home\AllCommentProduct.cshtml"
       Write(Html.PagedListPager(Model.ProductCommentDTO.CommentList, pageindex => Url.Action("AllCommentProduct", "Home",
           new { pageindex = pageindex })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<style>\r\n    .progress-bar {\r\n        background-color: #ffb656;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Web.AllCommentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591