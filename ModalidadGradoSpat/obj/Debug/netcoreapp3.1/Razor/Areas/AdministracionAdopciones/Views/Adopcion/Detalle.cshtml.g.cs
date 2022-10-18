#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e33e173294e52c4b6cf3660698abe2960d1bf14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionAdopciones_Views_Adopcion_Detalle), @"mvc.1.0.view", @"/Areas/AdministracionAdopciones/Views/Adopcion/Detalle.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\_ViewImports.cshtml"
using ModalidadGradoSpat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\_ViewImports.cshtml"
using DATA.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e33e173294e52c4b6cf3660698abe2960d1bf14", @"/Areas/AdministracionAdopciones/Views/Adopcion/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionAdopciones/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdministracionAdopciones_Views_Adopcion_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SolicitudAdopcion>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid py-3\">\r\n");
#nullable restore
#line 6 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h3>
            Vista de Acciones y Detalle de la Solicitud de Adopci&oacute;n.
        </h3>
        <p class=""mb-4"">
            La vista est&aacute; centrada en la gesti&oacute;n de las solicitudes de adopci&oacute;n enviadas,
            para decidir si son aprobadas, rechazadas o canceladas.
        </p>
        <div class=""row"">
            <div class=""col-lg-6 mx-auto"">
                <div class=""shadow-lg border p-5 bg-white rounded text-center"">
                    La adopci&oacute;n no existe, id incorrecto.
                </div>
            </div>
        </div>
");
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
         if (Model.Estado.Equals("Pendiente") || Model.Estado.Equals("Aprobado"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h3>
                Vista de Acciones y Detalle de la Solicitud de Adopci&oacute;n.
            </h3>
            <p class=""mb-4"">
                La vista est&aacute; centrada en la gesti&oacute;n de las solicitudes de adopci&oacute;n enviadas,
                para decidir si son aprobadas, rechazadas o canceladas.
            </p>
            <div class=""nav nav-tabs mb-3"" id=""nav-tab"" role=""tablist"">
                <button class=""nav-item nav-link active"" id=""nav-solicitud"" data-toggle=""tab"" href=""#tab-solicitud"" type=""button"" aria-controls=""tab-crud-mascota"">Acciones</button>
                <button class=""nav-item nav-link"" id=""nav-informe"" data-toggle=""tab"" href=""#tab-informe"" type=""button"" aria-controls=""tab-view-mascota"">Detalle Solicitud de Adopci&oacute;n</button>
            </div>
            <div class=""tab-content"">
                <div class=""tab-pane fade show active"" id=""tab-solicitud"" role=""tabpanel"" aria-labelledby=""nav-solicitud"">
                    <div id=""bod");
            WriteLiteral("y-content-action\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
                   Write(await Html.PartialAsync("PartialView/_AdministrarSolicitudAdopcion", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"tab-pane fade\" id=\"tab-informe\" role=\"tabpanel\" aria-labelledby=\"nav-informe\">\r\n                    <div id=\"body-content-view\">\r\n                        ");
#nullable restore
#line 46 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
                   Write(await Html.PartialAsync("PartialView/_InformeSolicitudAdopcion", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h3>
                Vista de Detalle de la Solicitud de Adopci&oacute;n.
            </h3>
            <p class=""mb-4"">
                La vista contiene la informaci&oacute;n de la Solicitud de Adopci&oacute;n.
            </p>
            <div id=""body-content-view"">
                ");
#nullable restore
#line 60 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
           Write(await Html.PartialAsync("PartialView/_InformeSolicitudAdopcion", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 62 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Detalle.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SolicitudAdopcion> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
