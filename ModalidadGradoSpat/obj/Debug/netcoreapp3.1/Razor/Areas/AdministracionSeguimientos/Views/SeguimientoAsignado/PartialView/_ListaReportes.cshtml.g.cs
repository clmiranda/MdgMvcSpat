#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01f2b243e1c891834ea8ae32c08b5db71797792"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionSeguimientos_Views_SeguimientoAsignado_PartialView__ListaReportes), @"mvc.1.0.view", @"/Areas/AdministracionSeguimientos/Views/SeguimientoAsignado/PartialView/_ListaReportes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01f2b243e1c891834ea8ae32c08b5db71797792", @"/Areas/AdministracionSeguimientos/Views/SeguimientoAsignado/PartialView/_ListaReportes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionSeguimientos/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdministracionSeguimientos_Views_SeguimientoAsignado_PartialView__ListaReportes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seguimiento>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditReporte", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar reporte para envío"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
Write(await Html.PartialAsync("~/Views/RenderSweetAlert.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
  
    int id = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-lg-6 mx-auto"">
            <div class=""shadow-lg border p-5 bg-white rounded text-center"">
                No se puede mostrar el listado de reportes, id de seguimiento incorrecto.
            </div>
        </div>
    </div>
");
#nullable restore
#line 15 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
}
else if (Model.ReporteSeguimientos.Any(x => x.FechaReporte.ToShortDateString().Equals(DateTime.Now.ToShortDateString()) && !x.Estado.Equals("Enviado")))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-info text-center alert-dismissible fade show my-3 col-8 mx-auto"" role=""alert"">
        <strong>Hay un reporte pendiente por realizar el d&Iacute;a de hoy!</strong>
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
");
#nullable restore
#line 24 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
 if (Model != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-lg-flex justify-content-between my-3\">\r\n    <div class=\"my-2\">\r\n        <p class=\"shadow-lg border px-2 py-2 rounded\">\r\n            Rango de Fechas del Seguimiento: ");
#nullable restore
#line 29 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                                        Write(Model.FechaInicio.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 29 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                                                                                 Write(Model.FechaFin.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div class=\"my-2\">\r\n        <p class=\"shadow-lg border px-2 py-2 rounded\">\r\n            Nombre mascota: ");
#nullable restore
#line 34 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                       Write(Model.SolicitudAdopcion.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            Edad aprox: ");
#nullable restore
#line 35 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                   Write(Model.SolicitudAdopcion.Mascota.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            Tama&ntilde;o: ");
#nullable restore
#line 36 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                      Write(Model.SolicitudAdopcion.Mascota.Tamano);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div class=\"my-2\">\r\n        <a type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("href", "\r\n           href=\"", 1623, "\"", 1761, 1);
#nullable restore
#line 41 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
WriteAttributeValue("", 1642, Url.Action("Detalle", "SeguimientoAsignado", new { id=Model.SolicitudAdopcion.Id, area="AdministracionSeguimientos" }), 1642, 119, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n           data-toggle=\"tooltip\" data-placement=\"left\" title=\"Ver detalle\">\r\n            <i class=\"fas fa-list\" aria-hidden=\"true\"></i>\r\n        </a>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<div class=""table-responsive"">
    <table id=""example"" class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Descripcion</th>
                <th>Fecha</th>
                <th>Estado</th>
                <th>Acciones</th>
            </tr>
        </thead>
        <tbody id=""tbodyDetalleSeguimiento"">
");
#nullable restore
#line 60 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
             foreach (var item in Model.ReporteSeguimientos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                    Write(id++);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 67 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                         if (item.Observaciones == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>El reporte a&uacute;n no fue realizado.</p>\r\n");
#nullable restore
#line 70 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>\r\n                                ");
#nullable restore
#line 74 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                           Write(item.Observaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n");
#nullable restore
#line 76 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td width=\"15%\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 80 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                       Write(item.FechaReporte.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </td>\r\n                    <td width=\"10%\">\r\n                        <div class=\"d-flex justify-content-center align-items-center\">\r\n");
#nullable restore
#line 85 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                             if (item.Estado.Equals("Enviado"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5><span class=\"badge badge-pill p-2 badge-danger\">");
#nullable restore
#line 87 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                                                                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n");
#nullable restore
#line 88 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5><span class=\"badge badge-pill p-2 badge-primary\">");
#nullable restore
#line 91 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                                                                                Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n");
#nullable restore
#line 92 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </td>\r\n                    <td width=\"5%\">\r\n                        <div class=\"d-flex justify-content-center align-items-center\">\r\n");
#nullable restore
#line 97 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                             if (!item.FechaReporte.Date.ToShortDateString().Equals(DateTime.Now.ToShortDateString()) || item.Estado.Equals("Enviado"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-primary\" disabled><i class=\"fa fa-edit fa-2\" aria-hidden=\"true\"></i></button>\r\n");
#nullable restore
#line 100 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f01f2b243e1c891834ea8ae32c08b5db7179779218319", async() => {
                WriteLiteral("\r\n                                    <span data-toggle=\"modal\" data-target=\"#form-modal\"><i class=\"fa fa-edit fa-2\" aria-hidden=\"true\"></i></span>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4451, "showInPopup(\'", 4451, 13, true);
#nullable restore
#line 104 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
AddHtmlAttributeValue("", 4464, Url.Action("EditReporte","SeguimientoAsignado",new { id=item.Id,area="AdministracionSeguimientos"}), 4464, 100, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4564, "\',\'Editar", 4564, 9, true);
            AddHtmlAttributeValue(" ", 4573, "Reporte\');", 4574, 11, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 112 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <th>Id</th>
                <th>Descripcion</th>
                <th>Fecha</th>
                <th>Estado</th>
                <th>Acciones</th>
            </tr>
        </tfoot>
    </table>
</div>
<script>
    $(function () {
        $('[data-toggle=""tooltip""]').tooltip({ trigger: ""hover"" });
    });
    $(document).ready(function () {
        $('#example').DataTable({
            ""order"": [],
            ""processing"": true,
            ""ordering"": false,
            ""language"": {
                ""sProcessing"": ""Procesando..."",
                ""sLengthMenu"": ""Mostrar _MENU_ registros"",
                ""sZeroRecords"": ""No se encontraron resultados"",
                ""sEmptyTable"": ""Ningún dato disponible en esta tabla =("",
                ""sInfo"": ""Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros"",
                ""sInfoEmpty"": ""Mostrando registros del 0 al 0 de un total de 0 registros"",
  ");
            WriteLiteral(@"              ""sInfoFiltered"": ""(filtrado de un total de _MAX_ registros)"",
                ""sInfoPostFix"": """",
                ""sSearch"": ""Buscar:"",
                ""sUrl"": """",
                ""sInfoThousands"": "","",
                ""sLoadingRecords"": ""Cargando..."",
                ""oPaginate"": {
                    ""sFirst"": ""Primero"",
                    ""sLast"": ""Último"",
                    ""sNext"": ""Siguiente"",
                    ""sPrevious"": ""Anterior""
                },
                ""oAria"": {
                    ""sSortAscending"": "": Activar para ordenar la columna de manera ascendente"",
                    ""sSortDescending"": "": Activar para ordenar la columna de manera descendente""
                },
                ""buttons"": {
                    ""copy"": ""Copiar"",
                    ""colvis"": ""Visibilidad""
                }
            }
        });
    });
</script>
");
#nullable restore
#line 165 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\SeguimientoAsignado\PartialView\_ListaReportes.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Seguimiento> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
