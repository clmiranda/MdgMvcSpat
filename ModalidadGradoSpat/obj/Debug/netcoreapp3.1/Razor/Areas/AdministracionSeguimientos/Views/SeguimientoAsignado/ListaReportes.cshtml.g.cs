#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\ListaReportes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d45a16ad85e6325cb4577a18298611b3ea059d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionSeguimientos_Views_SeguimientoAsignado_ListaReportes), @"mvc.1.0.view", @"/Areas/AdministracionSeguimientos/Views/SeguimientoAsignado/ListaReportes.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\_ViewImports.cshtml"
using ModalidadGradoSpat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\_ViewImports.cshtml"
using DATA.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d45a16ad85e6325cb4577a18298611b3ea059d6", @"/Areas/AdministracionSeguimientos/Views/SeguimientoAsignado/ListaReportes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionSeguimientos/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdministracionSeguimientos_Views_SeguimientoAsignado_ListaReportes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seguimiento>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\ListaReportes.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid py-3"">
    <h3>
        Vista Listado de Reportes
    </h3>
    <p class=""mb-3"">
        En esta vista se detallan los reportes disponibles
        para el seguimiento actual, el env&iacute;o del reporte se habilita
        el d&iacute;a al que fue asignado.
    </p>
    <div class=""d-md-flex mb-3"">
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-success""><i class=""fas fa-list"" aria-hidden=""true""></i></button> -> Detalle de la Adopci&oacute;n Asignada.
        </p>
        <p class=""shadow p-3 bg-white rounded"">
            <button class=""btn btn-primary""><i class=""fa fa-edit"" aria-hidden=""true""></i></button> -> Editar Reporte para Enviar.
        </p>
    </div>
    <div id=""view-all"">
        ");
#nullable restore
#line 23 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\ListaReportes.cshtml"
   Write(await Html.PartialAsync("PartialView/_ListaReportes", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Seguimiento> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
