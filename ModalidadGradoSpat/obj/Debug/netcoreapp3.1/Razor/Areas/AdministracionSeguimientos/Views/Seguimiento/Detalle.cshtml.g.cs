#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee7eb3bbf96f67a61736bfa66b17bbcb38ad3029"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionSeguimientos_Views_Seguimiento_Detalle), @"mvc.1.0.view", @"/Areas/AdministracionSeguimientos/Views/Seguimiento/Detalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee7eb3bbf96f67a61736bfa66b17bbcb38ad3029", @"/Areas/AdministracionSeguimientos/Views/Seguimiento/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionSeguimientos/_ViewImports.cshtml")]
    public class Areas_AdministracionSeguimientos_Views_Seguimiento_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SolicitudAdopcion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid py-3\">\r\n    <h3>\r\n        Vista Detalle Seguimiento Asignado\r\n    </h3>\r\n    <p class=\"mb-5\">\r\n        En esta vista se detalla la informaci&oacute;n del\r\n        seguimiento al cual has sido asignado.\r\n    </p>\r\n");
#nullable restore
#line 13 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-lg-6 mx-auto"">
                <div class=""shadow-lg border p-5 bg-white rounded text-center"">
                    No se puede mostrar los datos, id de seguimiento incorrecto.
                </div>
            </div>
        </div>
");
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
    }
    else
    {
        if (Model.Mascota != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row text-justify"">
                <div class=""col-lg-6"">
                    <div class=""shadow-lg border p-5 bg-white rounded"">
                        <h4 class=""pb-3 text-primary"">Informaci&oacute;n del Adoptante</h4>
                        <p class=""card-text"">
                            <strong>Nombre Completo del Adoptante: </strong>");
#nullable restore
#line 32 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                                       Write(Model.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n                            <strong>Domicilio: </strong>");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                   Write(Model.Domicilio);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n                            <strong>N&uacute;mero de Tel&eacute;fono/Celular: </strong>");
#nullable restore
#line 34 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                                                  Write(Model.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n                            <strong>Fecha de Solicitud de Adopci&oacute;n: </strong>");
#nullable restore
#line 35 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                                               Write(Model.FechaSolicitudAdopcion.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""shadow-lg border p-5 bg-white rounded"">
                        <h4 class=""pb-3 text-primary"">Informaci&oacute;n de la Mascota</h4>
                        <p class=""card-text"">
                            <strong>Nombre de la Mascota: </strong>");
#nullable restore
#line 43 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                              Write(Model.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n");
#nullable restore
#line 44 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                             if (Model.Mascota.Esterilizado)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <strong>Esterilizada: </strong>");
            WriteLiteral("La Mascota se encuentra esterilizada.<br /><br />\r\n");
#nullable restore
#line 47 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <strong>Esterilizada: </strong>");
            WriteLiteral("La Mascota no se encuentra esterilizada.<br /><br />\r\n");
#nullable restore
#line 51 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <strong>Especie: </strong>");
#nullable restore
#line 52 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                 Write(Model.Mascota.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n                            <strong>Sexo de la Mascota: </strong>");
#nullable restore
#line 53 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                            Write(Model.Mascota.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n                            <strong>Edad: </strong>");
#nullable restore
#line 54 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                              Write(Model.Mascota.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n                            <strong>Tama&ntilde;o de la Mascota: </strong>");
#nullable restore
#line 55 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                                     Write(Model.Mascota.Tamano);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n                            <strong>Caracteristicas de la Mascota: </strong>");
#nullable restore
#line 56 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                                       Write(Model.Mascota.Caracteristicas);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n                            <strong>Rasgos Particulares: </strong>");
#nullable restore
#line 57 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
                                                             Write(Model.Mascota.RasgosParticulares);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 62 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-lg-6 mx-auto"">
                    <div class=""shadow-lg border p-5 bg-white rounded text-center"">
                        La adopci&oacute;n a la que pertenece este seguimiento ha sido cancelada!
                    </div>
                </div>
            </div>
");
#nullable restore
#line 72 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Detalle.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SolicitudAdopcion> Html { get; private set; }
    }
}
#pragma warning restore 1591
