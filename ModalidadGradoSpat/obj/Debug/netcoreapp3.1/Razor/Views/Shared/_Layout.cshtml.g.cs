#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "536fce25064e11f8c1a592ab01bbef62f5f520a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using ModalidadGradoSpat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using ModalidadGradoSpat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using DATA.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536fce25064e11f8c1a592ab01bbef62f5f520a7", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8f1a948d8581be59cf7c803f0c525d3d30e1da", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/archivos/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/archivos/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/archivos/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/archivos/css/sidebar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/archivos/css/estilos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/archivos/js/jquery.easing.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/archivos/js/sidebar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/archivos/js/crud.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html5 lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "536fce25064e11f8c1a592ab01bbef62f5f520a77786", async() => {
                WriteLiteral("\r\n        <meta charset=\"utf-8\">\r\n        <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 271, "\"", 281, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 312, "\"", 322, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n        <title>Asociacion Protectora de Animales Tarija</title>\r\n        <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "536fce25064e11f8c1a592ab01bbef62f5f520a78817", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "536fce25064e11f8c1a592ab01bbef62f5f520a79920", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "536fce25064e11f8c1a592ab01bbef62f5f520a711023", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"" integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN"" crossorigin=""anonymous""></script>
        <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.1/js/bootstrap.min.js"" integrity=""sha384-XEerZL0cuoUbHE4nZReLT7nx9gQrQreJekYhJD9WNWhH8nEW+0c5qq7aIo2Wl30J"" crossorigin=""anonymous""></script>
        <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@9""></script>
        <script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
        <script src=""https://cdn.datatables.net/1.10.21/js/dataTables.bootstrap4.min.js""></script>

        <script src=""https://kit.fontawesome.com/0eb65ed4d3.js"" crossorigin=""anonymous""></script>
        <link href=""https://cdn.datatables.net/1.10.21/css/dataTables.bootstrap4.min.css"" rel=""stylesheet"">
        <link href=""https://cdn.datatables.net/select/1.3.1/css/select.bootstrap4.min.css"" rel=""stylesheet"">
");
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "536fce25064e11f8c1a592ab01bbef62f5f520a713523", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "536fce25064e11f8c1a592ab01bbef62f5f520a714929", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <style>\r\n        html {\r\n            position: relative;\r\n            min-height: 100%;\r\n        }\r\n    </style>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "536fce25064e11f8c1a592ab01bbef62f5f520a716951", async() => {
                WriteLiteral("\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-dark static-top\">\r\n");
#nullable restore
#line 39 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <button class=""btn btn-link btn-lg text-white"" id=""sidebarToggle"" href=""#"">
                    <i class=""fas fa-bars""></i>
                </button>
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item dropdown no-arrow"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-lg fa-user-circle fa-fw""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                            <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 3002, "\"", 3081, 1);
#nullable restore
#line 50 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3009, Url.Action("EditarPerfil","Perfil",new { area="AdministracionCuentas"}), 3009, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Ver mi Perfil</a>\r\n                            <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 3154, "\"", 3234, 1);
#nullable restore
#line 51 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3161, Url.Action("ResetPassword","Perfil",new { area="AdministracionCuentas"}), 3161, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Resetear Password</a>\r\n                            <div class=\"dropdown-divider\"></div>\r\n                            <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 3377, "\"", 3429, 1);
#nullable restore
#line 53 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3384, Url.Action("LogOut","Cuenta",new { area=""}), 3384, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Cerrar Sesi&oacute;n</a>\r\n                        </div>\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 57 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a class=\"btn btn-primary text-white ml-auto\"");
                BeginWriteAttribute("href", " href=\"", 3648, "\"", 3711, 1);
#nullable restore
#line 60 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3655, Url.Action("QuienesSomos","Adopciones", new { area=""}), 3655, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    Qui&eacute;nes Somos\r\n                </a>\r\n                <a class=\"btn btn-primary text-white ml-3\"");
                BeginWriteAttribute("href", " href=\"", 3837, "\"", 3900, 1);
#nullable restore
#line 63 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3844, Url.Action("LeyMunicipal","Adopciones", new { area=""}), 3844, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    Ley Municipal N° 217\r\n                </a>\r\n                <a class=\"btn btn-primary text-white ml-3\"");
                BeginWriteAttribute("href", " href=\"", 4026, "\"", 4078, 1);
#nullable restore
#line 66 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4033, Url.Action("Login","Cuenta", new { area=""}), 4033, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    Iniciar Sesi&oacute;n\r\n                </a>\r\n");
#nullable restore
#line 69 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </nav>\r\n        <div id=\"wrapper\">\r\n");
#nullable restore
#line 72 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <ul class=""sidebar navbar-nav"">
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" id=""mascotasDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-paw""></i>
                        <span>Mascotas</span>
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""mascotasDropdown"">
                        <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 4780, "\"", 4855, 1);
#nullable restore
#line 81 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4787, Url.Action("Index","Denuncia",new { area="AdministracionMascotas"}), 4787, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Administrar Denuncias</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4932, "\"", 5006, 1);
#nullable restore
#line 82 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4939, Url.Action("Lista","Mascota",new { area="AdministracionMascotas"}), 4939, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Administrar Mascotas</a>
                    </div>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" id=""accountDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-user-circle""></i>
                        <span>Cuentas</span>
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""accountDropdown"">
                        <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 5555, "\"", 5627, 1);
#nullable restore
#line 91 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5562, Url.Action("Lista","Cuenta",new { area="AdministracionCuentas"}), 5562, 65, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Administrar Usuarios</a>
                    </div>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" id=""adopcionDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-file-signature""></i>
                        <span>Adopciones</span>
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""adopcionDropdown"">
                        <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 6184, "\"", 6261, 1);
#nullable restore
#line 100 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6191, Url.Action("Lista","Adopcion",new { area="AdministracionAdopciones"}), 6191, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Administrar Adopciones</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 6339, "\"", 6421, 1);
#nullable restore
#line 101 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6346, Url.Action("Lista","Seguimiento",new { area="AdministracionSeguimientos"}), 6346, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Administrar Seguimientos</a>
                    </div>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" id=""reportesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fal fa-file-chart-line""></i>
                        <span>Reportes</span>
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""reportesDropdown"">
                        <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 6981, "\"", 7061, 1);
#nullable restore
#line 110 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6988, Url.Action("Adopciones","Graficas",new { area="AdministracionReportes"}), 6988, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Reportes Adopciones</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 7136, "\"", 7214, 1);
#nullable restore
#line 111 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7143, Url.Action("Mascotas","Graficas",new { area="AdministracionReportes"}), 7143, 71, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Reportes Mascotas</a>\r\n                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 7287, "\"", 7376, 1);
#nullable restore
#line 112 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7294, Url.Action("ReporteSeguimientos","Graficas",new { area="AdministracionReportes"}), 7294, 82, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Reportes Seguimientos</a>\r\n                    </div>\r\n                </li>\r\n            </ul>\r\n");
#nullable restore
#line 116 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div id=\"content-wrapper\">\r\n                <main role=\"main\">\r\n                    ");
#nullable restore
#line 119 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 120 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
               Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </main>
                <div class=""modal fade"" id=""form-modal"" tabindex=""-1"" role=""dialog"" data-backdrop=""static"" data-keyboard=""false"">
                    <div class=""modal-dialog modal-lg"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title""></h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"">
                            </div>
                        </div>
                    </div>
                </div>
                <footer class=""sticky-footer"">
                    <div class=""container my-5"">
                        <hr class=""my-3"">
                        <div class=""copy");
                WriteLiteral("right text-center\">\r\n                            <span class=\"lead\">Copyright © S.P.A.T. 2021</span>\r\n                        </div>\r\n                    </div>\r\n                </footer>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 146 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a class=\"scroll-to-top rounded\" href=\"#page-top\">\r\n                <i class=\"fas fa-angle-up\"></i>\r\n            </a>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "536fce25064e11f8c1a592ab01bbef62f5f520a731438", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "536fce25064e11f8c1a592ab01bbef62f5f520a732546", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 153 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Shared\_Layout.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "536fce25064e11f8c1a592ab01bbef62f5f520a733874", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html5>\r\n");
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
