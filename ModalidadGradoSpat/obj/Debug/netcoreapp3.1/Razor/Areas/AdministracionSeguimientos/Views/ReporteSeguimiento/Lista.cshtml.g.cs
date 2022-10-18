#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff1d0594ef19dc4b4b09ea3db33083392d619bff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionSeguimientos_Views_ReporteSeguimiento_Lista), @"mvc.1.0.view", @"/Areas/AdministracionSeguimientos/Views/ReporteSeguimiento/Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff1d0594ef19dc4b4b09ea3db33083392d619bff", @"/Areas/AdministracionSeguimientos/Views/ReporteSeguimiento/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionSeguimientos/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdministracionSeguimientos_Views_ReporteSeguimiento_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seguimiento>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\Lista.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid py-3"">
    <h3>
        Lista de Reportes de Seguimiento Actual
    </h3>
    <p class=""mb-3"">
        En esta vista se muestran los reportes asignados para el
        seguimiento actual, desde aqu&iacute; se puede establecer el
        rango de fechas y asignar la fecha de cada reporte o eliminar.
    </p>
    <div class=""d-md-flex mb-3"">
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-primary""><i class=""fa fa-plus-circle"" aria-hidden=""true""></i></button> -> Agregar Reporte.
        </p>
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-primary""><i class=""fa fa-calendar"" aria-hidden=""true""></i></button> -> Actualizar Rango de Fechas.
        </p>
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-success""><i class=""fas fa-images"" aria-hidden=""true""></i></button> -> Ver Imagen Reporte.
        </p>
        <p class=""shadow p-3 bg-white round");
            WriteLiteral("ed\">\r\n            <button class=\"btn btn-danger\"><i class=\"fas fa-trash\" aria-hidden=\"true\"></i></button> -> Eliminar Reporte.\r\n        </p>\r\n    </div>\r\n    <div id=\"view-all\">\r\n        ");
#nullable restore
#line 29 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\Lista.cshtml"
   Write(await Html.PartialAsync("PartialView/_Lista", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
