#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26632e726c0ca67079e758708b3738b670304e53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionSeguimientos_Views_ReporteSeguimiento_PartialView__Lista), @"mvc.1.0.view", @"/Areas/AdministracionSeguimientos/Views/ReporteSeguimiento/PartialView/_Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26632e726c0ca67079e758708b3738b670304e53", @"/Areas/AdministracionSeguimientos/Views/ReporteSeguimiento/PartialView/_Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionSeguimientos/_ViewImports.cshtml")]
    public class Areas_AdministracionSeguimientos_Views_ReporteSeguimiento_PartialView__Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seguimiento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReporte", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxPostList(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateFechaReporte", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteReporte", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
Write(await Html.PartialAsync("~/Views/RenderSweetAlert.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://cdn.jsdelivr.net/momentjs/latest/moment.min.js""></script>
<script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.min.js""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.css"" />
<div class=""d-lg-flex justify-content-between my-3"">
    <div class=""my-2"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26632e726c0ca67079e758708b3738b670304e537497", async() => {
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary\"><i class=\"fa fa-plus-circle\" aria-hidden=\"true\"></i></button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"my-2\">\r\n");
#nullable restore
#line 13 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
         if (Model.User == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"shadow px-3 py-1 bg-white rounded\">A&uacute;n no tiene un Voluntario asignado.</p>\r\n");
#nullable restore
#line 16 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"shadow px-3 py-1 bg-white rounded\">Voluntario Asignado: ");
#nullable restore
#line 19 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                                                                         Write(Model.User.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                                                                                             Write(Model.User.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"my-2\">\r\n        <p class=\"shadow px-3 py-1 bg-white rounded\">Rango de Fechas: ");
#nullable restore
#line 23 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                                                                 Write(Model.FechaInicio.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 23 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                                                                                                          Write(Model.FechaConclusion.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"my-2\">\r\n        <button class=\"btn btn-primary\" type=\"button\"");
            BeginWriteAttribute("onclick", "\r\n                onclick=\"", 1397, "\"", 1573, 5);
            WriteAttributeValue("", 1424, "showInPopup(\'", 1424, 13, true);
#nullable restore
#line 27 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
WriteAttributeValue("", 1437, Url.Action("EditSeguimiento","ReporteSeguimiento", new { id=Model.Id, area="AdministracionSeguimientos" }), 1437, 107, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1544, "\',", 1544, 2, true);
            WriteAttributeValue(" ", 1546, "\'Actualizar", 1547, 12, true);
            WriteAttributeValue(" ", 1558, "Seguimiento\');", 1559, 15, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                data-toggle=\"modal\" data-target=\"#form-modal\">\r\n            <i class=\"fa fa-calendar\" aria-hidden=\"true\"></i>\r\n        </button>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
 if (Model.ReporteSeguimientos.Any(x => x.Fecha.Date < Model.FechaInicio.Date || x.Fecha.Date > Model.FechaConclusion.Date))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-warning alert-dismissible fade show"" role=""alert"">
        <strong>
            Existen fechas que no estan en el rango establecido, debe establecerlas
            para que los reportes puedan realizarse.
        </strong>
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
");
#nullable restore
#line 44 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""table-responsive"">
    <table id=""example"" class=""table table-bordered table-hover"" style=""width:100%"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Observaciones</th>
                <th>Fecha Reporte</th>
                <th>Estado</th>
                <th>Ver Imagen</th>
                <th>Eliminar</th>
            </tr>
        </thead>
        <tbody id=""tbodyReporteSeguimiento"">
");
#nullable restore
#line 58 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
             foreach (var item in Model.ReporteSeguimientos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"5%\">\r\n                        ");
#nullable restore
#line 62 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 65 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                         if (item.Estado.Equals("Activo") || item.Estado.Equals("Asignado"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p><strong>A&uacute;n no se realiz&oacute; el reporte.</strong></p>\r\n");
#nullable restore
#line 68 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                       Write(item.Observaciones);

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                                               
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"width:20%\">\r\n");
#nullable restore
#line 75 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                         if (item.Estado.Equals("Enviado"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"input-group\">\r\n                                <input");
            BeginWriteAttribute("id", " id=\"", 3603, "\"", 3624, 2);
            WriteAttributeValue("", 3608, "idFecha-", 3608, 8, true);
#nullable restore
#line 78 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
WriteAttributeValue("", 3616, item.Id, 3616, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Fecha\"");
            BeginWriteAttribute("value", " value=\"", 3638, "\"", 3682, 1);
#nullable restore
#line 78 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
WriteAttributeValue("", 3646, item.Fecha.Date.ToShortDateString(), 3646, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"form-control\" readonly>\r\n                            </div>\r\n");
#nullable restore
#line 80 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26632e726c0ca67079e758708b3738b670304e5320124", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 4011, "\"", 4027, 1);
#nullable restore
#line 84 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
WriteAttributeValue("", 4019, item.Id, 4019, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"SeguimientoId\"");
                BeginWriteAttribute("value", " value=\"", 4106, "\"", 4133, 1);
#nullable restore
#line 85 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
WriteAttributeValue("", 4114, item.SeguimientoId, 4114, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <div class=\"input-group\">\r\n                                    <input");
                BeginWriteAttribute("id", " id=\"", 4240, "\"", 4261, 2);
                WriteAttributeValue("", 4245, "idFecha-", 4245, 8, true);
#nullable restore
#line 87 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
WriteAttributeValue("", 4253, item.Id, 4253, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Fecha\"");
                BeginWriteAttribute("value", " value=\"", 4275, "\"", 4319, 1);
#nullable restore
#line 87 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
WriteAttributeValue("", 4283, item.Fecha.Date.ToShortDateString(), 4283, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" data-toggle=\"datepicker\" readonly>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td width=\"5%\">\r\n");
#nullable restore
#line 93 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                         if (item.Estado.Equals("Activo"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5>\r\n                                <span class=\"badge badge-pill p-2 badge-warning\">\r\n                                    ");
#nullable restore
#line 97 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </h5>\r\n");
#nullable restore
#line 100 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                        }
                        else if (item.Estado.Equals("Asignado"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5>\r\n                                <span class=\"badge badge-pill p-2 badge-info\">\r\n                                    ");
#nullable restore
#line 105 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </h5>\r\n");
#nullable restore
#line 108 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5>\r\n                                <span class=\"badge badge-pill p-2 badge-primary\">\r\n                                    ");
#nullable restore
#line 113 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </h5>\r\n");
#nullable restore
#line 116 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td width=\"10%\" class=\"text-center\">\r\n");
#nullable restore
#line 119 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                         if (item.Foto != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5812, "\"", 5981, 5);
            WriteAttributeValue("", 5822, "showInPopup(\'", 5822, 13, true);
#nullable restore
#line 121 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
WriteAttributeValue("", 5835, Url.Action("GetFotoReporteSeguimiento","ReporteSeguimiento", new { url=item.Foto.Url, area="AdministracionSeguimientos"}), 5835, 122, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5957, "\',\'Imagen", 5957, 9, true);
            WriteAttributeValue(" ", 5966, "del", 5967, 4, true);
            WriteAttributeValue(" ", 5970, "Reporte\');", 5971, 11, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                    data-toggle=\"modal\" data-target=\"#form-modal\"\r\n                                    class=\"btn btn-success\">\r\n                                <i class=\"fas fa-images\"></i>\r\n                            </button>\r\n");
#nullable restore
#line 126 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Sin Imagen.</p>\r\n");
#nullable restore
#line 130 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td width=\"5%\">\r\n                        <div class=\"d-flex flex-row\">\r\n");
#nullable restore
#line 134 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                             if (item.Estado.Equals("Enviado"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-danger\" disabled><i class=\"fa fa-trash\" aria-hidden=\"true\"></i></button>\r\n");
#nullable restore
#line 137 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26632e726c0ca67079e758708b3738b670304e5330891", async() => {
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn btn-danger\">\r\n                                        <i class=\"fa fa-trash\"></i>\r\n                                    </button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 140 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 140 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                                                                                              WriteLiteral(item.SeguimientoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idseg"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idseg", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idseg"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 145 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 149 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\PartialView\_Lista.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <th>Id</th>
                <th>Descripcion</th>
                <th>Fecha Reporte</th>
                <th>Estado</th>
                <th>Ver Imagen</th>
                <th>Eliminar</th>
            </tr>
        </tfoot>
    </table>
</div>
<script>
    $(document).ready(function () {
        var url = ""/archivos/js/daterangepicker.js"";
        $.getScript(url);
        $('#example').DataTable({
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
            WriteLiteral(@"               ""sInfoFiltered"": ""(filtrado de un total de _MAX_ registros)"",
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
    var _0x348b = ['form', '982688hxuies', '3067LHAMSU', 'fail', '475836mDmlwk', '1114735DQJLMN', 'POST', '3191sDcG");
            WriteLiteral(@"ky', 'location', 'change', 'status', '471610ifpBbE', '174BBIsDK', '66763aWctuf', '/Error/', 'ajax', 'href', '353bSkgOp', 'html']; function _0x4f1f(_0x52e421, _0x35d253) { return _0x4f1f = function (_0x348b0a, _0x4f1f35) { _0x348b0a = _0x348b0a - 0x10e; var _0x3df4a8 = _0x348b[_0x348b0a]; return _0x3df4a8; }, _0x4f1f(_0x52e421, _0x35d253); } var _0xe7cc8f = _0x4f1f; (function (_0x3c4c7e, _0x2bc1e8) { var _0x551e71 = _0x4f1f; while (!![]) { try { var _0x32c9db = -parseInt(_0x551e71(0x110)) + -parseInt(_0x551e71(0x10f)) + parseInt(_0x551e71(0x118)) + -parseInt(_0x551e71(0x116)) + parseInt(_0x551e71(0x117)) * parseInt(_0x551e71(0x120)) + parseInt(_0x551e71(0x11f)) + parseInt(_0x551e71(0x11c)) * parseInt(_0x551e71(0x112)); if (_0x32c9db === _0x2bc1e8) break; else _0x3c4c7e['push'](_0x3c4c7e['shift']()); } catch (_0x484ee0) { _0x3c4c7e['push'](_0x3c4c7e['shift']()); } } }(_0x348b, 0x9e0b7), $('[data-toggle=\x22datepicker\x22]')['on'](_0xe7cc8f(0x114), function () { var _0x3ba887 = _0xe7cc8f; return $[_0x3ba887(0x11");
            WriteLiteral(@"a)]({ 'type': _0x3ba887(0x111), 'url': this[_0x3ba887(0x11e)]['action'], 'data': new FormData(this['form']), 'contentType': ![], 'processData': ![], 'success': function (_0x56b50a) { var _0x36558b = _0x3ba887; $('#view-all')[_0x36558b(0x11d)](_0x56b50a[_0x36558b(0x11d)]); } })[_0x3ba887(0x10e)](function (_0x2f079, _0x2dae44, _0x478c44) { var _0xa452e5 = _0x3ba887; window[_0xa452e5(0x113)][_0xa452e5(0x11b)] = _0xa452e5(0x119) + _0x2f079[_0xa452e5(0x115)]; }), ![]; }));
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Seguimiento> Html { get; private set; }
    }
}
#pragma warning restore 1591
