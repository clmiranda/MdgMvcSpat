#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\AsignarRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c793c3fc685096ace7af419ebe45c01ff3812ef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionCuentas_Views_Cuenta_AsignarRoles), @"mvc.1.0.view", @"/Areas/AdministracionCuentas/Views/Cuenta/AsignarRoles.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\_ViewImports.cshtml"
using ModalidadGradoSpat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\_ViewImports.cshtml"
using DATA.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c793c3fc685096ace7af419ebe45c01ff3812ef7", @"/Areas/AdministracionCuentas/Views/Cuenta/AsignarRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionCuentas/_ViewImports.cshtml")]
    public class Areas_AdministracionCuentas_Views_Cuenta_AsignarRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AsignarRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxPost(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\AsignarRoles.cshtml"
Write(await Html.PartialAsync("~/Views/RenderSweetAlert.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c793c3fc685096ace7af419ebe45c01ff3812ef75901", async() => {
                WriteLiteral(@"
    <div class=""custom-control custom-checkbox mb-3"">
        <input name=""RolesUser[]"" value=""Administrador"" class=""custom-control-input"" type=""checkbox"" id=""idAdmin"">
        <label class=""custom-control-label"" for=""idAdmin"">
            Administrador
        </label>
    </div>
    <div class=""custom-control custom-checkbox mb-3"">
        <input name=""RolesUser[]"" value=""Voluntario"" class=""custom-control-input"" type=""checkbox"" id=""idVoluntario"">
        <label class=""custom-control-label"" for=""idVoluntario"">
            Voluntario
        </label>
    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
        <button type=""submit"" class=""btn btn-primary"" disabled>Guardar</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\" language=javascript>\r\n    $.validator.unobtrusive.parse(document);\r\n");
#nullable restore
#line 23 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\AsignarRoles.cshtml"
     foreach (var item in Model)
    {
        if (item.Equals("Administrador"))
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("$(\"#idAdmin\").prop(\'checked\', true);");
#nullable restore
#line 26 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\AsignarRoles.cshtml"
                                                            }
        else if (item.Equals("Voluntario"))
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("$(\"#idVoluntario\").prop(\'checked\', true);");
#nullable restore
#line 28 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\AsignarRoles.cshtml"
                                                                 }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    var _0x5571 = ['2JCazDd', 'prop', 'form\x20[class=\x22custom-control-input\x22]', '583873okKowJ', '928591vfLtTv', '3662064anOFON', '1259138YhKkYo', '1464447VOSmNz', '199lVrBYO', '1dZcVCt', '579248AFrBfn', '8198zNIwKx', 'change\x20input', 'disabled']; function _0x4584(_0x4cc0c4, _0x3a2f75) { return _0x4584 = function (_0x55719b, _0x45846b) { _0x55719b = _0x55719b - 0x11d; var _0xd0e42e = _0x5571[_0x55719b]; return _0xd0e42e; }, _0x4584(_0x4cc0c4, _0x3a2f75); } var _0xb10d57 = _0x4584; (function (_0x52deb8, _0x3a3e57) { var _0x3f88ce = _0x4584; while (!![]) { try { var _0x54b4b9 = -parseInt(_0x3f88ce(0x11e)) * -parseInt(_0x3f88ce(0x127)) + -parseInt(_0x3f88ce(0x126)) * -parseInt(_0x3f88ce(0x123)) + -parseInt(_0x3f88ce(0x12a)) + -parseInt(_0x3f88ce(0x129)) + parseInt(_0x3f88ce(0x120)) * -parseInt(_0x3f88ce(0x11d)) + -parseInt(_0x3f88ce(0x11f)) + parseInt(_0x3f88ce(0x128)); if (_0x54b4b9 === _0x3a3e57) break; else _0x52deb8['push'](_0x52deb8['shift']()); } catch (_0x34c782) { _0x52deb8['push'](_0x52deb8['shif");
            WriteLiteral("t\']()); } } }(_0x5571, 0xc9366), $(_0xb10d57(0x125))[\'on\'](_0xb10d57(0x121), function () { var _0x5d1098 = _0xb10d57; $(\'form\\x20button[type=\\x22submit\\x22]\')[_0x5d1098(0x124)](_0x5d1098(0x122), ![]); }));\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
