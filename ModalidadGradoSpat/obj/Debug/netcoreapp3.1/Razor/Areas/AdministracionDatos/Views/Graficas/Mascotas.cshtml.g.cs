#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionDatos\Views\Graficas\Mascotas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9d13adfae7d44c36423dbe5f127cf81011651d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionDatos_Views_Graficas_Mascotas), @"mvc.1.0.view", @"/Areas/AdministracionDatos/Views/Graficas/Mascotas.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionDatos\_ViewImports.cshtml"
using ModalidadGradoSpat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionDatos\_ViewImports.cshtml"
using DATA.DTOs.Graficas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionDatos\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionDatos\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9d13adfae7d44c36423dbe5f127cf81011651d1", @"/Areas/AdministracionDatos/Views/Graficas/Mascotas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c19fb2ecfea0cc5652cb2eb1970f23dbfb96bb9d", @"/Areas/AdministracionDatos/_ViewImports.cshtml")]
    public class Areas_AdministracionDatos_Views_Graficas_Mascotas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DataGraficaDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionDatos\Views\Graficas\Mascotas.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    ");
            WriteLiteral("@media (min-width: 576px) {\r\n        .doughnut {\r\n            height: 50vh;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (min-width: 768px) {\r\n        .doughnut {\r\n            height: 80vh;\r\n        }\r\n    }\r\n</style>\r\n<div class=\"container-fluid py-3\">\r\n    <h3>Gr&aacute;ficas de Mascotas Registradas</h3>\r\n    <div id=\"viewMascotas\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionDatos\Views\Graficas\Mascotas.cshtml"
   Write(await Html.PartialAsync("PartialView/_Mascotas", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DataGraficaDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
