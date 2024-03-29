#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70f7cdcd7deaf5426a8f35a113fa9cc0467340e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionAdopciones_Views_Adopcion_PartialView__InformeSolicitudAdopcion), @"mvc.1.0.view", @"/Areas/AdministracionAdopciones/Views/Adopcion/PartialView/_InformeSolicitudAdopcion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f7cdcd7deaf5426a8f35a113fa9cc0467340e9", @"/Areas/AdministracionAdopciones/Views/Adopcion/PartialView/_InformeSolicitudAdopcion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionAdopciones/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdministracionAdopciones_Views_Adopcion_PartialView__InformeSolicitudAdopcion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SolicitudAdopcion>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
 if (Model.AdopcionRechazada != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
        <div class=""col-lg-6 mb-5 mx-auto"">
            <div class=""shadow-lg border p-5 bg-white rounded text-justify"">
                <h4 class=""text-primary"">Raz&oacute;n del Rechazo de Solicitud de Adopci&oacute;n</h4>
                <p class=""card-text"">");
#nullable restore
#line 7 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                Write(Model.AdopcionRechazada.Razon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
}
else if (Model.AdopcionCancelada != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
        <div class=""col-lg-6 mb-5 mx-auto"">
            <div class=""shadow-lg border p-5 bg-white rounded text-justify"">
                <h4 class=""text-primary"">Raz&oacute;n de la Cancelaci&oacute;n de Adopci&oacute;n</h4>
                <p class=""card-text"">");
#nullable restore
#line 17 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                Write(Model.AdopcionCancelada.Razon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
 if (Model.Mascota != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-lg-6 mb-5"">
            <div class=""shadow-lg border p-5 bg-white rounded text-justify"">
                <h4 class=""text-primary"">Informaci&oacute;n del Adoptante</h4>
                <div class=""card-text"">
                    <p>
                        <b>Nombre Completo del Adoptante: </b>");
#nullable restore
#line 30 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                                         Write(Model.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Domicilio: </b>");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                     Write(Model.Domicilio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>N&uacute;mero de Tel&eacute;fono/Celular: </b>");
#nullable restore
#line 36 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                                                    Write(Model.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p><b>Fecha de Solicitud de Adopci&oacute;n: </b>");
#nullable restore
#line 38 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                                                Write(Model.FechaSolicitudAdopcion.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 mb-5"">
            <div class=""shadow-lg border p-5 bg-white rounded text-justify"">
                <h4 class=""text-primary"">Informaci&oacute;n de la Mascota</h4>
                <div class=""card-text"">
                    <p><b>Nombre de la Mascota: </b>");
#nullable restore
#line 46 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                               Write(Model.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 47 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                     if (Model.Mascota.Esterilizado)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n                            <b>Esterilizada: </b>La Mascota se encuentra esterilizada.\r\n                        </p>\r\n");
#nullable restore
#line 51 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>\r\n                            <b>Esterilizada: </b>La Mascota no se encuentra esterilizada.\r\n                        </p>\r\n");
#nullable restore
#line 56 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        <b>Sexo de la Mascota: </b>");
#nullable restore
#line 58 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                              Write(Model.Mascota.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Edad aproximada: </b>");
#nullable restore
#line 61 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                           Write(Model.Mascota.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Especie: </b>");
#nullable restore
#line 64 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                   Write(Model.Mascota.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Tama&ntilde;o: </b>");
#nullable restore
#line 67 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                         Write(Model.Mascota.Tamano);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Rasgos Particulares: </b>");
#nullable restore
#line 70 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                               Write(Model.Mascota.RasgosParticulares);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Caracteristicas: </b>");
#nullable restore
#line 73 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                           Write(Model.Mascota.Caracteristicas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 79 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-lg-6 mb-5 mx-auto"">
            <div class=""shadow-lg border p-5 bg-white rounded text-justify"">
                <h4 class=""text-primary"">Informaci&oacute;n del Adoptante</h4>
                <div class=""card-text"">
                    <p>
                        <b>Nombre Completo del Adoptante: </b>");
#nullable restore
#line 88 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                                         Write(Model.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Domicilio: </b>");
#nullable restore
#line 91 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                     Write(Model.Domicilio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>N&uacute;mero de Tel&eacute;fono/Celular: </b>");
#nullable restore
#line 94 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                                                    Write(Model.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p><b>Fecha de Solicitud de Adopci&oacute;n: </b>");
#nullable restore
#line 96 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
                                                                Write(Model.FechaSolicitudAdopcion.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 101 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\PartialView\_InformeSolicitudAdopcion.cshtml"
}

#line default
#line hidden
#nullable disable
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
