#pragma checksum "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb8a04b52d6be6137c5e3f6616e8cd184ac5ec99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Listar), @"mvc.1.0.view", @"/Views/Cadastro/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/Listar.cshtml", typeof(AspNetCore.Views_Cadastro_Listar))]
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
#line 1 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8a04b52d6be6137c5e3f6616e8cd184ac5ec99", @"/Views/Cadastro/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1826cf1fdf4410ebf7e4b6a25f6e0003506f662", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Zoo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(64, 21, true);
            WriteLiteral("\r\n<h1>Listar</h1>\r\n\r\n");
            EndContext();
#line 9 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml"
 if(TempData["msg"] != null)
{

#line default
#line hidden
            BeginContext(118, 38, true);
            WriteLiteral("    <div class=\"alert-danger\"></div>\r\n");
            EndContext();
#line 12 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml"
}

#line default
#line hidden
            BeginContext(159, 135, true);
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Jaulas</th>\r\n        <th>Tipo</th>\r\n        <th>Data Abertura</th>\r\n    </tr>\r\n");
            EndContext();
#line 21 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
            BeginContext(334, 14, true);
            WriteLiteral("<tr>\r\n    <th>");
            EndContext();
            BeginContext(349, 9, false);
#line 24 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml"
   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(358, 15, true);
            WriteLiteral("</th>\r\n    <th>");
            EndContext();
            BeginContext(374, 11, false);
#line 25 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml"
   Write(item.Jaulas);

#line default
#line hidden
            EndContext();
            BeginContext(385, 15, true);
            WriteLiteral("</th>\r\n    <th>");
            EndContext();
            BeginContext(401, 27, false);
#line 26 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml"
   Write(item.EntidadeAdministradora);

#line default
#line hidden
            EndContext();
            BeginContext(428, 15, true);
            WriteLiteral("</th>\r\n    <th>");
            EndContext();
            BeginContext(444, 37, false);
#line 27 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml"
   Write(item.DataAbertura.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(481, 14, true);
            WriteLiteral("</th>\r\n</tr>\r\n");
            EndContext();
#line 29 "D:\repos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Cadastro\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(502, 16, true);
            WriteLiteral("    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Zoo>> Html { get; private set; }
    }
}
#pragma warning restore 1591