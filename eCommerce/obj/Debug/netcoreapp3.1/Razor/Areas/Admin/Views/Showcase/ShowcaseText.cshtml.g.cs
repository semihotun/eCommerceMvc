#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseText.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbc1d36026b00c4c18a763759c52f99d34cddef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Showcase_ShowcaseText), @"mvc.1.0.view", @"/Areas/Admin/Views/Showcase/ShowcaseText.cshtml")]
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
#line 1 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseText.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseText.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbc1d36026b00c4c18a763759c52f99d34cddef0", @"/Areas/Admin/Views/Showcase/ShowcaseText.cshtml")]
    public class Areas_Admin_Views_Showcase_ShowcaseText : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.ShowCaseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseText.cshtml"
 using (Html.BeginForm("ShowcaseProduct", "Showcase", FormMethod.Post))
{

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseText.cshtml"
   Write(Html.HiddenFor(x => x.ShowCaseType, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <textarea id=\"ShowCaseText\" name=\"ShowCaseDto.ShowCaseText\">");
#nullable restore
#line 12 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseText.cshtml"
                                                               Write(Html.Raw(@Model.ShowCaseDto.ShowCaseText));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
        <script>
            tinymce.init({
                selector: 'textarea#ShowCaseText',
                plugins: 'print preview paste importcss searchreplace autolink autosave save directionality code visualblocks visualchars fullscreen image link media template codesample table charmap hr pagebreak nonbreaking anchor toc insertdatetime advlist lists wordcount imagetools textpattern noneditable help charmap quickbars emoticons',
                imagetools_cors_hosts: ['picsum.photos'],
                menubar: 'file edit view insert format tools table help',
                toolbar: 'undo redo | bold italic underline strikethrough | fontselect fontsizeselect formatselect | alignleft aligncenter alignright alignjustify | outdent indent |  numlist bullist | forecolor backcolor removeformat | pagebreak | charmap emoticons | fullscreen  preview save print | insertfile image media template link anchor codesample | ltr rtl',
                toolbar_sticky: true,
                language:");
            WriteLiteral(@" 'tr',
                autosave_ask_before_unload: true,
                autosave_interval: ""30s"",
                autosave_prefix: ""{path}{query}-{id}-"",
                autosave_restore_when_empty: false,
                autosave_retention: ""2m"",
                image_advtab: true,
                content_css: '//www.tiny.cloud/css/codepen.min.css',
                importcss_append: true,
                height: 400,
                file_picker_callback: function (callback, value, meta) {
                    /* Provide file and text for the link dialog */
                    if (meta.filetype === 'file') {
                        callback('https://www.google.com/logos/google.jpg', { text: 'My text' });
                    }

                    /* Provide image and alt text for the image dialog */
                    if (meta.filetype === 'image') {
                        callback('https://www.google.com/logos/google.jpg', { alt: 'My alt text' });
                    }

               ");
            WriteLiteral(@"     /* Provide alternative source and posted for the media dialog */
                    if (meta.filetype === 'media') {
                        callback('movie.mp4', { source2: 'alt.ogg', poster: 'https://www.google.com/logos/google.jpg' });
                    }
                },
                entity_encoding: ""raw"",
                template_cdate_format: '[Date Created (CDATE): %m/%d/%Y : %H:%M:%S]',
                template_mdate_format: '[Date Modified (MDATE): %m/%d/%Y : %H:%M:%S]',
                height: 600,
                image_caption: true,
                quickbars_selection_toolbar: 'bold italic | quicklink h2 h3 blockquote quickimage quicktable',
                noneditable_noneditable_class: ""mceNonEditable"",
                toolbar_mode: 'sliding',
                contextmenu: ""link image imagetools table"",
            });

        </script>
");
            WriteLiteral("        <br />\r\n        <input type=\"submit\" class=\"btn btn-default\">\r\n");
#nullable restore
#line 62 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\Showcase\ShowcaseText.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.ShowCaseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591