#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Mascota\MascotaView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e88a5165d46ea2be794c07b659e5e3ad3329cb21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionMascotas_Views_Mascota_MascotaView), @"mvc.1.0.view", @"/Areas/AdministracionMascotas/Views/Mascota/MascotaView.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\_ViewImports.cshtml"
using ModalidadGradoSpat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\_ViewImports.cshtml"
using ModalidadGradoSpat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\_ViewImports.cshtml"
using DATA.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e88a5165d46ea2be794c07b659e5e3ad3329cb21", @"/Areas/AdministracionMascotas/Views/Mascota/MascotaView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8f1a948d8581be59cf7c803f0c525d3d30e1da", @"/Areas/AdministracionMascotas/_ViewImports.cshtml")]
    public class Areas_AdministracionMascotas_Views_Mascota_MascotaView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mascota>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Mascota\MascotaView.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    button[disabled] {
        cursor: not-allowed;
    }
</style>
<div class=""row"">
    <div class=""col-sm-12 col-lg-8 mx-auto"">
        <nav>
            <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                <a class=""nav-item nav-link active"" id=""nav-mascota"" data-toggle=""tab"" href=""#mascota"" role=""button"" aria-controls=""mascota"" aria-selected=""true"">Actualizar Mascota</a>
");
            WriteLiteral("                <a class=\"nav-item nav-link\" id=\"nav-fotos\" data-toggle=\"tab\" href=\"#fotos\" role=\"button\" aria-controls=\"fotos\" aria-selected=\"false\">Fotos</a>\r\n");
            WriteLiteral(@"            </div>
        </nav>
        <div class=""tab-content"" id=""nav-tabContent"">
            <div class=""tab-pane fade show active"" id=""mascota"" role=""tabpanel"" aria-labelledby=""nav-mascota"">
                <div id=""body-content-view"">
                    ");
#nullable restore
#line 28 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Mascota\MascotaView.cshtml"
               Write(await Html.PartialAsync("PartialView/_Mascota.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"tab-pane fade\" id=\"fotos\" role=\"tabpanel\" aria-labelledby=\"nav-fotos\">\r\n                <div id=\"body-content-action\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Mascota\MascotaView.cshtml"
               Write(await Html.PartialAsync("PartialView/_Fotos.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mascota> Html { get; private set; }
    }
}
#pragma warning restore 1591
