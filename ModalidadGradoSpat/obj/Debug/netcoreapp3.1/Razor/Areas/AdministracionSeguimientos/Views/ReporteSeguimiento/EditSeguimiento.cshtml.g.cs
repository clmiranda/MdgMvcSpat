#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\EditSeguimiento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f88a64cd120c44f926e8b6fbb0da86fc0d45acaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionSeguimientos_Views_ReporteSeguimiento_EditSeguimiento), @"mvc.1.0.view", @"/Areas/AdministracionSeguimientos/Views/ReporteSeguimiento/EditSeguimiento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88a64cd120c44f926e8b6fbb0da86fc0d45acaa", @"/Areas/AdministracionSeguimientos/Views/ReporteSeguimiento/EditSeguimiento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionSeguimientos/_ViewImports.cshtml")]
    public class Areas_AdministracionSeguimientos_Views_ReporteSeguimiento_EditSeguimiento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seguimiento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateFechaSeguimiento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxPost(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\EditSeguimiento.cshtml"
Write(await Html.PartialAsync("~/Views/RenderSweetAlert.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f88a64cd120c44f926e8b6fbb0da86fc0d45acaa6133", async() => {
                WriteLiteral("\r\n    <div class=\"form-row\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f88a64cd120c44f926e8b6fbb0da86fc0d45acaa6431", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\EditSeguimiento.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 5 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\EditSeguimiento.cshtml"
                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input id=\"inicial\"");
                BeginWriteAttribute("value", " value=\"", 324, "\"", 370, 1);
#nullable restore
#line 6 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\EditSeguimiento.cshtml"
WriteAttributeValue("", 332, Model.FechaInicio.ToShortDateString(), 332, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" name=\"RangoFechas[]\" />\r\n        <input id=\"final\"");
                BeginWriteAttribute("value", " value=\"", 436, "\"", 479, 1);
#nullable restore
#line 7 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\EditSeguimiento.cshtml"
WriteAttributeValue("", 444, Model.FechaFin.ToShortDateString(), 444, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""hidden"" name=""RangoFechas[]"" />
        <div class=""form-group mb-5 col-md-6"">
            <label for=""idDateRange"">Ingrese el rango de fechas del seguimiento:</label>
            <input id=""idDateRange"" type=""text"" placeholder=""Rangos de Fecha"" aria-label=""Rangos de Fecha"" class=""form-control"" readonly>
        </div>
    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
        <button type=""submit"" class=""btn btn-primary"">Guardar</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script type=""text/javascript"" language=javascript>
    $.validator.unobtrusive.parse(document);

    $('#idDateRange').daterangepicker({
        ""autoApply"": true,
        ""showDropdowns"": true,
        ""minYear"": 2020,
        ""locale"": {
            ""format"": ""DD/MM/YYYY"",
            ""separator"": "" "",
            ""applyLabel"": ""Apply"",
            ""cancelLabel"": ""Cancel"",
            ""fromLabel"": ""From"",
            ""toLabel"": ""To"",
            ""customRangeLabel"": ""Custom"",
            ""weekLabel"": ""W"",
            ""daysOfWeek"": [
                ""Dom"",
                ""Lun"",
                ""Mar"",
                ""Mie"",
                ""Jue"",
                ""Vie"",
                ""Sab""
            ],
            ""monthNames"": [
                ""Enero"",
                ""Febrero"",
                ""Marzo"",
                ""Abril"",
                ""Mayo"",
                ""Junio"",
                ""Julio"",
                ""Agosto"",
                ""Septiembre"",
         ");
            WriteLiteral("       \"Octubre\",\r\n                \"Noviembre\",\r\n                \"Diciembre\"\r\n            ],\r\n            \"firstDay\": 1\r\n        },\r\n        \"startDate\": \"");
#nullable restore
#line 60 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\EditSeguimiento.cshtml"
                 Write(Model.FechaInicio.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"endDate\": \"");
#nullable restore
#line 61 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\ReporteSeguimiento\EditSeguimiento.cshtml"
               Write(Model.FechaFin.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
        ""opens"": ""center""
    });
    var _0x58d1 = ['1398299mKaWKK', '1116393QUHdZB', '1eLdSBO', '39681FleHww', 'val', '1732cvqrLa', '227177PDNCfz', '1008628OESBXf', '1023803ECWFmL', '#final', '1JSWXpz', 'change', '#idDateRange', '1pEMUcH', 'split', '11LPmBzs', '438VWxYQd']; var _0x438109 = _0x3cb3; function _0x3cb3(_0x3b4494, _0x166e86) { return _0x3cb3 = function (_0x58d1ef, _0x3cb3c7) { _0x58d1ef = _0x58d1ef - 0x15d; var _0x2987df = _0x58d1[_0x58d1ef]; return _0x2987df; }, _0x3cb3(_0x3b4494, _0x166e86); } (function (_0x2edf23, _0x2f7ad4) { var _0x141eab = _0x3cb3; while (!![]) { try { var _0xaffe7c = parseInt(_0x141eab(0x160)) * parseInt(_0x141eab(0x16b)) + parseInt(_0x141eab(0x165)) * -parseInt(_0x141eab(0x163)) + parseInt(_0x141eab(0x16c)) * parseInt(_0x141eab(0x15d)) + parseInt(_0x141eab(0x162)) + -parseInt(_0x141eab(0x16d)) + -parseInt(_0x141eab(0x15e)) * parseInt(_0x141eab(0x16a)) + -parseInt(_0x141eab(0x168)) * -parseInt(_0x141eab(0x161)); if (_0xaffe7c === _0x2f7ad4) break; else _0x2edf23['pu");
            WriteLiteral(@"sh'](_0x2edf23['shift']()); } catch (_0x3b127c) { _0x2edf23['push'](_0x2edf23['shift']()); } } }(_0x58d1, 0xc73a1), $(_0x438109(0x167))['on'](_0x438109(0x166), function (_0xac0af4) { var _0x88ee6a = _0x438109, _0x14a4f7 = []; _0x14a4f7 = this['value'][_0x88ee6a(0x169)]('\x20'), $('#inicial')[_0x88ee6a(0x15f)](_0x14a4f7[0x0]), $(_0x88ee6a(0x164))[_0x88ee6a(0x15f)](_0x14a4f7[0x1]); }));
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
