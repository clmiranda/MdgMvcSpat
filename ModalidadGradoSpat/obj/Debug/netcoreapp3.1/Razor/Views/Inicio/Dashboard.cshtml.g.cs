#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "667668e0e518089ecc330eea808ac4b4b5632d88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inicio_Dashboard), @"mvc.1.0.view", @"/Views/Inicio/Dashboard.cshtml")]
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
using DATA.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"667668e0e518089ecc330eea808ac4b4b5632d88", @"/Views/Inicio/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Views/_ViewImports.cshtml")]
    public class Views_Inicio_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataForDashboardDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    var labelsMascota = Newtonsoft.Json.JsonConvert.SerializeObject(Model.DataGraficaMascota.Select(x => x.Nombre).ToList());
    var valuesMascota = Newtonsoft.Json.JsonConvert.SerializeObject(Model.DataGraficaMascota.Select(x => x.Cantidad.ToString()).ToList());

    var labelsSeguimiento = Newtonsoft.Json.JsonConvert.SerializeObject(Model.DataGraficaSeguimiento.Select(x => x.Nombre).ToList());
    var valuesSeguimiento = Newtonsoft.Json.JsonConvert.SerializeObject(Model.DataGraficaSeguimiento.Select(x => x.Cantidad.ToString()).ToList());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .rounded {
        border-radius: .55rem !important
    }

    .card-body i {
        font-size: 5em;
        opacity: 0.4;
    }

    .card-body .count-numbers {
        position: absolute;
        right: 35px;
        top: 20px;
        font-size: 32px;
        display: block;
    }

    .card-body .count-name {
        position: absolute;
        right: 35px;
        top: 65px;
        text-transform: capitalize;
        opacity: 0.8;
        display: block;
        font-size: 18px;
    }
</style>
<div class=""container mt-5"">
    <p class=""my-3 lead"">
        Aqu&iacute; se muestran las gr&aacute;ficas de los registros
        m&aacute;s importantes en la asociaci&oacute;n.
    </p>
    <div class=""row"">
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow text-white bg-success"">
                <div class=""card-body"">
                    <i class=""fas fa-check-square""></i>
                    <span class=""count-numbers"">");
#nullable restore
#line 48 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                                           Write(Model.ContadorAdopcionesAprobadas);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    <span class=""count-name"">Adopciones Aprobadas</span>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow text-white bg-warning"">
                <div class=""card-body"">
                    <i class=""fas fa-window-close""></i>
                    <span class=""count-numbers"">");
#nullable restore
#line 57 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                                           Write(Model.ContadorAdopcionesCanceladas);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    <span class=""count-name"">Adopciones Canceladas</span>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow text-white bg-danger"">
                <div class=""card-body"">
                    <i class=""fas fa-ban""></i>
                    <span class=""count-numbers"">");
#nullable restore
#line 66 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                                           Write(Model.ContadorAdopcionesRechazadas);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    <span class=""count-name"">Adopciones Rechazadas</span>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow text-white bg-danger"">
                <div class=""card-body"">
                    <i class=""fas fa-book-open""></i>
                    <span class=""count-numbers"">");
#nullable restore
#line 75 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                                           Write(Model.ContadorReportesSemana);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    <span class=""count-name"">Reportes realizados esta semana</span>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow text-white bg-primary"">
                <div class=""card-body"">
                    <i class=""fas fa-paw""></i>
                    <span class=""count-numbers"">");
#nullable restore
#line 84 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                                           Write(Model.ContadorMascotasRegistradas);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    <span class=""count-name"">Mascotas Registradas</span>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow text-white bg-warning"">
                <div class=""card-body"">
                    <i class=""fas fa-gavel""></i>
                    <span class=""count-numbers"">");
#nullable restore
#line 93 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                                           Write(Model.ContadorDenunciasRegistradas);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    <span class=""count-name"">Denuncias Registradas</span>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow text-white bg-info"">
                <div class=""card-body"">
                    <i class=""fas fa-search""></i>
                    <span class=""count-numbers"">");
#nullable restore
#line 102 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                                           Write(Model.ContadorSeguimientosActuales);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    <span class=""count-name"">Seguimientos Actuales</span>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow text-white bg-success"">
                <div class=""card-body"">
                    <i class=""fas fa-users""></i>
                    <span class=""count-numbers"">");
#nullable restore
#line 111 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                                           Write(Model.ContadorVoluntariosRegistrados);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    <span class=""count-name"">Voluntarios Registrados</span>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow"">
                <div class=""card-body"">
                    <canvas id=""chartMascota"" style=""width:100%;""></canvas>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 my-3"">
            <div class=""card rounded shadow"">
                <div class=""card-body"">
                    <canvas id=""chartSeguimiento"" style=""width:100%;""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>
<script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
<script>
    $(function () {
        var chartName = ""chartMascota"";
        var ctx = document.getElementById(chartName).getContext('2d');
        var speedData = {
            labels: ");
#nullable restore
#line 138 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
               Write(Html.Raw(labelsMascota));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            datasets: [{\r\n                data: ");
#nullable restore
#line 140 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                 Write(Html.Raw(valuesMascota));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                borderWidth: 2,
                fill: false,
                backgroundColor: [
                    'rgb(255, 99, 132)',
                    'rgb(54, 162, 235)',
                    'rgb(255, 205, 86)',
                    'rgb(11, 217, 80)'
                ],
                hoverOffset: 4
            }]
        };
        var lineChart = new Chart(ctx, {
            type: 'doughnut',
            data: speedData,
            options: {
                responsive: true,
                plugins: {
                    legend: {
                        position: 'top',
                    },
                    title: {
                        display: true,
                        text: 'Lista de Mascotas Registradas por Estado'
                    }
                }
            }
        });
    });

        $(function () {
            var chartName = ""chartSeguimiento"";
        var ctx = document.getElementById(chartName).getContext('2d');
        var speedD");
            WriteLiteral("ata = {\r\n            labels: ");
#nullable restore
#line 174 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
               Write(Html.Raw(labelsSeguimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            datasets: [{\r\n                data: ");
#nullable restore
#line 176 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Inicio\Dashboard.cshtml"
                 Write(Html.Raw(valuesSeguimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                borderWidth: 2,
                fill: false,
                backgroundColor: [
                    'rgb(255, 99, 132)',
                    'rgb(54, 162, 235)',
                    'rgb(255, 205, 86)',
                    'rgb(11, 217, 80)'
                ],
                hoverOffset: 4
            }]
        };
        var lineChart = new Chart(ctx, {
            type: 'doughnut',
            data: speedData,
            options: {
                responsive: true,
                plugins: {
                    legend: {
                        position: 'top',
                    },
                    title: {
                        display: true,
                        text: 'Lista de Seguimientos Registrados por Estado'
                    }
                }
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataForDashboardDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
