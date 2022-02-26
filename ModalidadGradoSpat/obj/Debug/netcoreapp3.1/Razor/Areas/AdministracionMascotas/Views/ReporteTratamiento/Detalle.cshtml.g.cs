#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "159985297b66f1c606cf3c2b016228b66b8ce036"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionMascotas_Views_ReporteTratamiento_Detalle), @"mvc.1.0.view", @"/Areas/AdministracionMascotas/Views/ReporteTratamiento/Detalle.cshtml")]
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
using DATA.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"159985297b66f1c606cf3c2b016228b66b8ce036", @"/Areas/AdministracionMascotas/Views/ReporteTratamiento/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionMascotas/_ViewImports.cshtml")]
    public class Areas_AdministracionMascotas_Views_ReporteTratamiento_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mascota>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid my-5"">
    <h3>
        Vista Detalle de Reportes de Evoluci&oacute;n de Mascota.
    </h3>
    <p class=""mb-4"">
        En esta vista se puede ver el listado de reportes creados de la evoluci&oacute;n
        de la mascota desde su llegada a la asociaci&oacute;n hasta su adopci&oacute;n.
    </p>
");
#nullable restore
#line 13 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"shadow-lg border p-5 bg-white rounded text-center\">\r\n            <p class=\"card-text\">\r\n                La mascota no existe, no se puede listar.\r\n            </p>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
         if (Model.Estado.Equals("Inactivo"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
             if (Model.ReporteTratamientos.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <style>
                    ul.timeline {
                        list-style-type: none;
                        position: relative;
                    }

                        ul.timeline:before {
                            content: ' ';
                            background: #d4d9df;
                            display: inline-block;
                            position: absolute;
                            left: 29px;
                            width: 2px;
                            height: 100%;
                            z-index: 0;
                        }

                        ul.timeline > li {
                            margin: 20px 0;
                            padding-left: 20px;
                        }

                            ul.timeline > li:before {
                                content: ' ';
                                background: white;
                                display: inline-block;
                                po");
            WriteLiteral(@"sition: absolute;
                                border-radius: 50%;
                                border: 3px solid #22c0e8;
                                left: 20px;
                                width: 20px;
                                height: 20px;
                                z-index: 0;
                            }

                    .timeline li:nth-child(n+3) {
                        display: none;
                    }
                </style>
                <div class=""shadow-lg border-1 py-5 px-3 bg-white rounded col-md-10 mx-auto"">
                    <h3>Evoluci&oacute;n de la mascota desde su rescate.</h3>
                    <ul class=""timeline"">
");
#nullable restore
#line 69 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
                         foreach (var item in Model.ReporteTratamientos)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"bg-white rounded ml-3 p-3 shadow\">\r\n                                <div class=\"d-flex justify-content-between\">\r\n                                    <p class=\"text-primary\">");
#nullable restore
#line 73 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
                                                       Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"text-primary\">");
#nullable restore
#line 74 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
                                                       Write(item.FechaCreacion.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                ");
#nullable restore
#line 76 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 78 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                    <button id=""loadMore"" type=""button"" class=""btn btn-primary"">Mostrar m&aacute;s</button>
                </div>
                <script>
                    $(document).ready(function () {
                        $('#loadMore').click(function () {
                            $('.timeline li:hidden').slice(0, 2).slideDown();
                            if ($('.timeline li').length == $('.timeline li:visible').length) {
                                $('#loadMore').hide();
                            }
                        });
                    });
                </script>
");
#nullable restore
#line 93 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""shadow-lg border p-5 bg-white rounded text-text"">
                    <p class=""card-text"">
                        No existen reportes de tratamiento creados para esta mascota.
                    </p>
                </div>
");
#nullable restore
#line 101 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"shadow-lg border p-5 bg-white rounded text-center\">\r\n                <p class=\"card-text\">\r\n                    El estado de la mascota debe ser \"Inactivo\" para poder visualizar.\r\n                </p>\r\n            </div>\r\n");
#nullable restore
#line 110 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\ReporteTratamiento\Detalle.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
