#pragma checksum "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\CategoryTree\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4b407332885fb7265e18393bb29b787390b1f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CategoryTree_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CategoryTree/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b407332885fb7265e18393bb29b787390b1f0d", @"/Areas/Admin/Views/CategoryTree/Index.cshtml")]
    public class Areas_Admin_Views_CategoryTree_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModels.Admin.CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/gijgo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/gijgo.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\CategoryTree\Index.cshtml"
  
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
                        <h2 class=""card-title"">Kategori Listesi</h2>
                    </div>
                </div>
                <div class=""card-body"">

                    <div class=""col-md-12"">
                        <div class=""modal fade in"" id=""modalAddNode"" role=""dialog"" aria-hidden=""true"">
                            ");
#nullable restore
#line 19 "C:\Users\Semih\source\repos\eCommerce\eCommerce\Areas\Admin\Views\CategoryTree\Index.cshtml"
                       Write(Html.Partial("_AddNode"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                        <div class=""col-md-5"">
                            <div class=""panel panel-primary"">


                                <div class=""panel-body"">
                                    <div id=""tree""></div>

                                    <div class=""clearfix"">
                                    </div>

                                    <br />
                                    <div>
                                        <button id=""btnDeleteNode"" data-toggle=""modal"" class='btn btn-danger'> Satır Sil <span class=""glyphicon glyphicon-trash""></span> </button>
                                        <button id=""btnpopoverAddNode"" data-toggle=""modal"" class='btn btn-warning'> Satır Ekle <span class=""glyphicon glyphicon-plus""></span>  </button>
                                        <button id=""btnEditNode"" data-toggle=""modal"" class='btn btn-danger'> Düzenle <span class=""glyphicon glyphicon-trash""></span> </button>
                   ");
            WriteLiteral(@"                 </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

    </div>
</div>


<style type=""text/css"">
    li.gj-tree-item [data-role=""display""]{
    padding:9px 7px !important;
    font-size:15px;
    }
    input[type=""radio""], input[type=""checkbox""] {
        width:15px;
        height:15px;
        margin-top:6px;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4b407332885fb7265e18393bb29b787390b1f0d6442", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4b407332885fb7265e18393bb29b787390b1f0d7556", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script type=""text/javascript"">
    //'Hierarchy/GetHierarchy'
    $(document).ready(function () {
        $('.petenddiv').attr(""class"", ""petenddiv d-none"");
        $(""#NodeTypeRbtn"").prop(""checked"", true);
        var Usertree = """";
        var tree = """";
        $.ajax({
            type: 'get',
            dataType: 'json',
            cache: false,
            url: '/Admin/CategoryTree/GetHierarchy',
            success: function (records, textStatus, jqXHR) {
                tree = $('#tree').tree({
                    primaryKey: 'Id',
                    dataSource: records,
                    dragAndDrop: true,
                    checkboxes: true,
                    iconsLibrary: '>',
                    
                });
                Usertree = $('#Usertree').tree({
                    primaryKey: 'Id',
                    dataSource: records,
                    dragAndDrop: false,
                    checkboxes: true,
                    iconsLibrary: '>',
 ");
            WriteLiteral(@"               });
         
                tree.on('nodeDrop', function (e, Id, PerentId) {
                    currentNode = Id ? tree.getDataById(Id) : {};
                    console.log(""current Node = "" + currentNode);
                    parentNode = PerentId ? tree.getDataById(PerentId) : {};
                    console.log(""parent Node = "" + parentNode);
             
                    var params = { id: Id, parentId: PerentId };
                    $.ajax({
                        type: ""POST"",
                        url: ""/Admin/CategoryTree/ChangeNodePosition"",
                        data: params,
                        dataType: ""json"",
                        success: function (data) {
                            $.ajax({
                                type: ""Get"",
                                url: ""/Admin/CategoryTree/GetHierarchy"",
                                dataType: ""json"",
                                success: function (records) {
                      ");
            WriteLiteral(@"              Usertree.destroy();
                                    Usertree = $('#Usertree').tree({
                                        primaryKey: 'Id',
                                        dataSource: records,
                                        dragAndDrop: false,
                                        checkboxes: true,
                                        iconsLibrary: 'glyphicons',
                                    });
                                }
                            });
                            toastr.success(""Yer değiştirme işlemi başarılı"");

                        }
                    });

                });

                $('#btnDeleteNode').click(function (e) {
                    e.preventDefault();
                    var result = tree.getCheckedNodes();
                    if (result != """") {
                        $.ajax({
                            type: ""POST"",
                            url: ""/Admin/CategoryTree/DeleteNode"",
            WriteLiteral(@"
                            data: { values: result.toString() },
                            dataType: ""json"",
                            success: function (data) {
                                toastr.success(""Başrıyla Silindi"");
                                window.location.reload();
                            },
                            error: function (jqXHR, textStatus, errorThrown) {
                                toastr.warning(""Silerken Bir hatayla karşılaşıldı"");
                            },
                        });
                    }
                    else {
                        toastr.warning(""Lütfen Silinecek Kategorileri Seçiniz"");
                    }
                });

                $('#btnEditNode').click(function (e) {
                    e.preventDefault();
                    var result = tree.getCheckedNodes();
                    //Buraya Edit Location Gelicek
                    window.location.assign('/Admin/CategoryTree/CategoryEdit?id='");
            WriteLiteral(@" + result.toString());

                });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert('Error - ' + errorThrown);
            }
        });

        $('#btnpopoverAddNode').click(function (e) {
            e.preventDefault();
            $(""#modalAddNode"").modal(""show"");
        });

        $(document).on(""click"", ""#savenode"", function (event) {
            event.preventDefault();

            $('#formaddNode').validate();
            if ($('#formaddNode').valid()) {
                var formdata = $('#formaddNode').serialize();
                $.ajax({
                    type: ""POST"",
                    url: ""/Admin/CategoryTree/AddNewNode"",
                    dataType: ""json"",
                    data: formdata,
                    success: function (response) {
                        window.location.reload();
                        toastr.success(""Başrıyla Eklendi"");
                    },
                    error: ");
            WriteLiteral(@"function (response) {
                        toastr.success(""Eklerken bir hatayla karşılaşıldı"");
                        window.location.reload();
                    },
                    complete: function () {
                    }
                });
            }

        });

        $(document).on(""click"", ""#closePopup"", function (e) {
            e.preventDefault();
            $(""#modalAddNode"").modal(""hide"");
        });

        $('.rbtnnodetype').click(function (e) {
            if ($(this).val() == ""Pn"") {
                $('.petenddiv').attr(""class"", ""petenddiv d-none"");
                $(""#ParentName"").val("""");
            }
            else {
                $('.petenddiv').attr(""class"", ""petenddiv"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModels.Admin.CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591