#pragma checksum "D:\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56bd837d38eba3c7975d64a125b3260ac188bb02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastrar), @"mvc.1.0.view", @"/Views/Usuario/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastrar.cshtml", typeof(AspNetCore.Views_Usuario_Cadastrar))]
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
#line 1 "D:\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _03_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "D:\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _03_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56bd837d38eba3c7975d64a125b3260ac188bb02", @"/Views/Usuario/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c6b2faf4af2b11edff1dd927194cae734b1dc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/usuario/cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
            BeginContext(47, 24, true);
            WriteLiteral("\r\n<h1>Cadastrar</h1>\r\n\r\n");
            EndContext();
            BeginContext(71, 637, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56bd837d38eba3c7975d64a125b3260ac188bb024283", async() => {
                BeginContext(119, 582, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""idNome"">Nome</label>
        <input type=""text"" name=""nome"" id=""idNome"" class=""form-control"">
    </div>
    <div class=""form-group"">
        <label for=""idEmail"">E-mail</label>
        <input type=""email"" name=""email"" id=""idEmail"" class=""form-control"">
    </div>
    <div class=""form-group"">
        <label for=""idDataNasc"">Data de Nascimento</label>
        <input type=""date"" name=""dataNascimento"" id=""idDataNasc"" class=""form-control"">
    </div>
    <input type=""submit"" class=""btn btn-primary"" value=""Enviar"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(708, 8, true);
            WriteLiteral("\r\n\r\n<h2>");
            EndContext();
            BeginContext(717, 15, false);
#line 24 "D:\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Cadastrar.cshtml"
Write(ViewBag.sucesso);

#line default
#line hidden
            EndContext();
            BeginContext(732, 10, true);
            WriteLiteral("</h2>\r\n<p>");
            EndContext();
            BeginContext(743, 15, false);
#line 25 "D:\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Cadastrar.cshtml"
Write(ViewBag.cliente);

#line default
#line hidden
            EndContext();
            BeginContext(758, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(761, 12, false);
#line 25 "D:\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Cadastrar.cshtml"
                Write(ViewBag.nome);

#line default
#line hidden
            EndContext();
            BeginContext(773, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(776, 13, false);
#line 25 "D:\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Cadastrar.cshtml"
                               Write(ViewBag.email);

#line default
#line hidden
            EndContext();
            BeginContext(789, 10, true);
            WriteLiteral("</p>\r\n\r\n\r\n");
            EndContext();
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
