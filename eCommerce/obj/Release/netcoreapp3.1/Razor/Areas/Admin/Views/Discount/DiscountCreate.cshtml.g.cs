#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b1716012e7972c89746bd7555c371dcabbc655"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Discount_DiscountCreate), @"mvc.1.0.view", @"/Areas/Admin/Views/Discount/DiscountCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b1716012e7972c89746bd7555c371dcabbc655", @"/Areas/Admin/Views/Discount/DiscountCreate.cshtml")]
    public class Areas_Admin_Views_Discount_DiscountCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.DiscountModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
  
    ViewData["Title"] = "DiscountCreate";
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
                        <h2 class=""card-title"">İndirim Ekle</h2>
                    </div>

                </div>
                <div class=""card-body"">

");
#nullable restore
#line 20 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                     using (Html.BeginForm("DiscountCreate", "Discount", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"display:flex;flex-wrap:wrap;\">\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.Name, "İsmi", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 27 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control  col-md-7" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 33 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.AdminComment, "Admin Açıklaması", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 36 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.TextBoxFor(x => x.AdminComment, new { @class = "form-control  col-md-7" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.DiscountTypeId, "Discount Tipi", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 44 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.DropDownList("DiscountTypeId", Model.DiscountTypeList, new { @class = "form-control col-md-7" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-12\" id=\"subcategoryshowhide\">\r\n                            ");
#nullable restore
#line 50 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.AppliedToSubCategories, "Alt Kategorilere Uygula", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 53 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.CheckBoxFor(x => x.AppliedToSubCategories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group col-md-12\" id=\"MaximumDiscountedQuantityshowhide\">\r\n                            ");
#nullable restore
#line 59 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.MaximumDiscountedQuantity, "Maximum indirim adeti", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 62 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.TextBoxFor(x => x.MaximumDiscountedQuantity, new { @class = "form-control  col-md-7" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n\r\n\r\n                        <div class=\"form-group col-md-12\" id=\"DiscountAmountshowhide\">\r\n                            ");
#nullable restore
#line 71 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.DiscountAmount, "İndirim Miktarı", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 74 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.TextBoxFor(x => x.DiscountAmount, new { @class = "form-control  col-md-7", @type = "number", @min = "0", @step = "0.01", @value = "0.00" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n\r\n\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 83 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.UsePercentage, "Kullanım Yüzdesi", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 86 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.CheckBoxFor(x => x.UsePercentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div id=\"percentagetruefalse\" class=\"col-md-12\">\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 93 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.LabelFor(x => x.DiscountPercentage, "İndirim Yüzdesi", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 96 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                               Write(Html.TextBoxFor(x => x.DiscountPercentage, new { @class = "form-control  col-md-7", @type = "number", @min = "0", @step = "0.01", @value = "0.00" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-12\">\r\n                                ");
#nullable restore
#line 101 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.LabelFor(x => x.MaximumDiscountAmount, "Maximum İndirim miktarı", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 104 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                               Write(Html.TextBoxFor(x => x.MaximumDiscountAmount, new { @class = "form-control  col-md-7", @type = "number", @min = "0", @step = "0.01", @value = "0.00" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 119 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.StartDateUtc, "Başlangıç tarihi", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 122 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.TextBoxFor(x => x.StartDateUtc, new { @class = "form-control  col-md-7", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 127 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.EndDateUtc, "Bitiş tarihi", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 130 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.TextBoxFor(x => x.EndDateUtc, new { @class = "form-control  col-md-7", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 137 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.RequiresCouponCode, "Kupon Kodu kullanılsınmı", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 140 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.CheckBoxFor(x => x.RequiresCouponCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group col-md-12\" id=\"Kuponkodushowhide\">\r\n\r\n                            ");
#nullable restore
#line 146 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.CouponCode, "Kupon Kodu ", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 149 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.TextBoxFor(x => x.CouponCode, new { @class = "form-control  col-md-7" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n\r\n\r\n                        <div class=\"form-group col-md-12\">\r\n                            ");
#nullable restore
#line 158 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.DiscountLimitationId, "İndirim limit", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 161 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.DropDownList("DiscountLimitationId", Model.DiscountLimitationList, new { @class = "form-control col-md-7" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group col-md-12\" id=\"LimitationTimesshowhide\">\r\n                            ");
#nullable restore
#line 166 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                       Write(Html.LabelFor(x => x.LimitationTimes, "LimitationTimes", new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 169 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                           Write(Html.TextBoxFor(x => x.LimitationTimes, new { @class = "form-control  col-md-7" }));

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
#line 189 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Discount\DiscountCreate.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {

        if ($(""#UsePercentage"").is("":checked"") == false) 
            $(""#percentagetruefalse"").hide();
        if ($(""#UsePercentage"").is("":checked"") == true) 
            $(""#DiscountAmountshowhide"").hide();
        if ($(""#RequiresCouponCode"").is("":checked"") == false)
            $(""#Kuponkodushowhide"").hide();
        if ($(""#DiscountLimitationId"").val() == 0)
            $(""#LimitationTimesshowhide"").hide();
        if ($(""#DiscountTypeId"").val() != 5)
            $(""#subcategoryshowhide"").hide();
        if ($(""#DiscountTypeId"").val() != 5 || (""#DiscountTypeId"").val() !=6  || (""#DiscountTypeId"").val() != 2)
            $(""#MaximumDiscountedQuantityshowhide"").hide();
        

    })  

    $(""#UsePercentage"").change(function () {
        
        if ($(this).is("":checked"")) {

            $(""#percentagetruefalse"").show();
            $(""#DiscountAmountsh");
            WriteLiteral(@"owhide"").hide();
        }
        else {

            $(""#percentagetruefalse"").hide();
            $(""#DiscountAmountshowhide"").show();
        }         
    });

    $(""#RequiresCouponCode"").change(function () {
        if ($(this).is("":checked"")) {
           
            $(""#Kuponkodushowhide"").show();
        }
        else {
            $(""#RequiresCouponCode"").val(""true"");
            $(""#Kuponkodushowhide"").hide();
        }
    });

    $(""#DiscountLimitationId"").change(function () {
        if ($(this).val() != 0) {
            $(""#LimitationTimesshowhide"").show();
        }
        else {
            $(""#LimitationTimesshowhide"").hide();
        }
    });


    $(""#DiscountTypeId"").change(function () {
        if ($(this).val() == 5) {
          
            $(""#subcategoryshowhide"").show();
        }
        else {
          
            $(""#subcategoryshowhide"").hide();
        }


        if ($(""#DiscountTypeId"").val() == 5 || (""#DiscountTypeId"").val() ");
            WriteLiteral("== 6 || (\"#DiscountTypeId\").val() == 2) {\r\n            $(\"#MaximumDiscountedQuantityshowhide\").show();\r\n        }\r\n        else {\r\n            $(\"#MaximumDiscountedQuantityshowhide\").hide();\r\n        }\r\n\r\n\r\n\r\n\r\n    });\r\n\r\n\r\n    \r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.DiscountModel> Html { get; private set; }
    }
}
#pragma warning restore 1591