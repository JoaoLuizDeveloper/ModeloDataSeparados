#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c62141c0332ea86a94314f8bc9407191e4b49efe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cliente_Relatorios), @"mvc.1.0.view", @"/Areas/Admin/Views/Cliente/Relatorios.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\_ViewImports.cshtml"
using ProjetoTempus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\_ViewImports.cshtml"
using ProjetoTempus.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c62141c0332ea86a94314f8bc9407191e4b49efe", @"/Areas/Admin/Views/Cliente/Relatorios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8c61762e3c91b604d0ed246c181c919e375a07", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cliente_Relatorios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info form-control btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml"
  
    ViewData["Title"] = "Relatorios";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""card"">
        <div class=""card-header bg-dark text-light ml-0 row container"">
            <div class=""col-12 d-none d-md-block col-md-6 pb-1"">
            </div>
            <div class=""col-12 col-md-4 offset-md-2 text-right"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c62141c0332ea86a94314f8bc9407191e4b49efe5122", async() => {
                WriteLiteral("Voltar a Listagem");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <div class=""card-body"">
            <div class=""container rounded p-2"">
                <div class=""row"">
                    <div class=""col-12 col-lg-6 pb-4"">
                        <div class=""row"">
                            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                                <span class=""text-primary"">Relatorios</span>
                            </h4>
                        </div>
");
#nullable restore
#line 24 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml"
                         if (ViewBag.Relatorio1 != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div style=""border: 2px solid black; border-radius: 10px; padding:10px"">
                                <div class=""row my-1"">
                                    <div class=""col-lg-9"">
                                        <label>Quantidade de Clientes maiores de 18 anos com Renda maior que a media:</label>
                                    </div>
                                    <div class=""col-3"">
                                        <input");
            BeginWriteAttribute("value", " value=\"", 1569, "\"", 1596, 1);
#nullable restore
#line 32 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml"
WriteAttributeValue("", 1577, ViewBag.Relatorio1, 1577, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly type=\"text\" class=\"form-control\" />\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 36 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br /><br />\r\n");
#nullable restore
#line 38 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml"
                         if (ViewBag.Relatorio2 != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div style=""border: 2px solid black; border-radius: 10px; padding:10px"">
                                <div class=""row my-1"">
                                    <div class=""col-lg-9"">
                                        <label>Quantidade de Clientes Classe A:</label>
                                    </div>
                                    <div class=""col-3"">
                                        <input");
            BeginWriteAttribute("value", " value=\"", 2369, "\"", 2399, 1);
#nullable restore
#line 46 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml"
WriteAttributeValue("", 2377, ViewBag.Relatorio2[0], 2377, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly type=""text"" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-lg-9"">
                                        <label>Quantidade de Clientes Classe B:</label>
                                    </div>
                                    <div class=""col-3"">
                                        <input");
            BeginWriteAttribute("value", " value=\"", 2883, "\"", 2913, 1);
#nullable restore
#line 54 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml"
WriteAttributeValue("", 2891, ViewBag.Relatorio2[1], 2891, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly type=""text"" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-lg-9"">
                                        <label>Quantidade de Clientes Classe C:</label>
                                    </div>
                                    <div class=""col-3"">
                                        <input");
            BeginWriteAttribute("value", " value=\"", 3397, "\"", 3427, 1);
#nullable restore
#line 62 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml"
WriteAttributeValue("", 3405, ViewBag.Relatorio2[2], 3405, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly type=\"text\" class=\"form-control\" />\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 66 "C:\Users\JuninhoDRZ\source\ProjetoTempus\ProjetoTempus\ProjetoTempus\Areas\Admin\Views\Cliente\Relatorios.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
