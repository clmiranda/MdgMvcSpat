#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adeefdf8d7161f3318980c3f7db59d9a4d30cf03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionCuentas_Views_Cuenta_PartialView__ListaUsuarios), @"mvc.1.0.view", @"/Areas/AdministracionCuentas/Views/Cuenta/PartialView/_ListaUsuarios.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adeefdf8d7161f3318980c3f7db59d9a4d30cf03", @"/Areas/AdministracionCuentas/Views/Cuenta/PartialView/_ListaUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionCuentas/_ViewImports.cshtml")]
    public class Areas_AdministracionCuentas_Views_Cuenta_PartialView__ListaUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CambiarEstado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return changeEstado(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return eliminarUsuario(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
Write(await Html.PartialAsync("~/Views/RenderSweetAlert.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://cdn.jsdelivr.net/momentjs/latest/moment.min.js""></script>
<script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.min.js""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.css"" />
<div class=""d-flex justify-content-between my-3"">
    <button type=""button"" data-toggle=""modal""");
            BeginWriteAttribute("onclick", " onclick=\"", 517, "\"", 636, 5);
            WriteAttributeValue("", 527, "showInPopup(\'", 527, 13, true);
#nullable restore
#line 7 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
WriteAttributeValue("", 540, Url.Action("CreateUsuario","Cuenta", new { area="AdministracionCuentas"}), 540, 74, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 614, "\',", 614, 2, true);
            WriteAttributeValue(" ", 616, "\'Agregar", 617, 9, true);
            WriteAttributeValue(" ", 625, "Usuario\');", 626, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">\r\n        <i class=\"fas fa-plus-square fa-lg mr-2\"></i>Agregar Usuario\r\n    </button>\r\n    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 760, "\"", 860, 3);
            WriteAttributeValue("", 770, "location.href=\'", 770, 15, true);
#nullable restore
#line 10 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
WriteAttributeValue("", 785, Url.Action("ExcelUsuario", "Cuenta", new { area="AdministracionCuentas"}), 785, 74, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 859, "\'", 859, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-primary"">
        <i class=""fas fa-file-excel fa-lg mr-2""></i>Excel Usuarios
    </button>
    <button type=""button"" class=""btn btn-success"" onclick=""generatePDF()"">
        <i class=""fas fa-file-pdf fa-lg mr-2""></i>Ver PDF
    </button>
</div>
<div class=""table-responsive"">
    <table id=""example"" class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nombre Completo</th>
                <th>Domicilio</th>
                <th>Nombre de Usuario</th>
                <th>Correo</th>
                <th>Fecha de Nacimiento</th>
                <th>Edad</th>
                <th>Roles</th>
                <th>Estado</th>
                <th>Acciones</th>
            </tr>
        </thead>
        <tbody id=""tbodyCuentas"">
");
#nullable restore
#line 34 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                 if (!item.Roles.Contains("SuperAdministrador"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                       Write(item.Persona.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 40 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                             Write(item.Persona.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                       Write(item.Persona.Domicilio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                       Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                       Write(item.Persona.FechaNacimiento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                       Write(item.Persona.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" a&ntilde;os</td>\r\n                        <td>\r\n");
#nullable restore
#line 47 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                             if (item.Roles == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"text-center\">No tiene roles asignados.</p>\r\n");
#nullable restore
#line 50 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                 foreach (var rol in item.Roles)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-center\">\r\n                                        ");
#nullable restore
#line 56 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                   Write(rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n");
#nullable restore
#line 58 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 62 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                             if (item.Estado.Equals("Activo"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5><span class=\"badge badge-pill p-2 badge-primary\">");
#nullable restore
#line 64 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                                                Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n");
#nullable restore
#line 65 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5><span class=\"badge badge-pill p-2 badge-danger\">");
#nullable restore
#line 68 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n");
#nullable restore
#line 69 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            <div class=\"d-flex flex-row\">\r\n");
#nullable restore
#line 73 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                 if (item.Roles.Contains("SuperAdministrador"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" class=\"btn btn-primary\" disabled>Asignar Roles</button>\r\n");
#nullable restore
#line 76 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\"");
            BeginWriteAttribute("onclick", " \r\n                                     onclick=\"", 3980, "\"", 4165, 5);
            WriteAttributeValue("", 4029, "showInPopup(\'", 4029, 13, true);
#nullable restore
#line 80 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
WriteAttributeValue("", 4042, Url.Action("AsignarRoles","Cuenta", new {id=item.Id, roles=item.Roles, area="AdministracionCuentas" }), 4042, 103, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4145, "\',", 4145, 2, true);
            WriteAttributeValue(" ", 4147, "\'Asignar", 4148, 9, true);
            WriteAttributeValue(" ", 4156, "Roles\');", 4157, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        Asignar Roles\r\n                                    </button>\r\n");
#nullable restore
#line 83 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adeefdf8d7161f3318980c3f7db59d9a4d30cf0318514", async() => {
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn btn-warning\">Cambiar Estado</button>\r\n                                ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idUser", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUser"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idUser", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUser"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adeefdf8d7161f3318980c3f7db59d9a4d30cf0321303", async() => {
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn btn-danger\">Eliminar Usuario</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idUser", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUser"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idUser", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUser"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <th>Id</th>
                <th>Nombre Completo</th>
                <th>Domicilio</th>
                <th>Nombre de Usuario</th>
                <th>Correo</th>
                <th>Fecha de Nacimiento</th>
                <th>Edad</th>
                <th>Roles</th>
                <th>Estado</th>
                <th>Acciones</th>
            </tr>
        </tfoot>
    </table>
</div>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf/1.3.4/jspdf.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/3.5.14/jspdf.plugin.autotable.min.js""></script>
<script type=""text/javascript"">
    function generatePDF() {
        const doc = new jsPDF('l', 'mm', [350, 200])
        doc.autoTable({
            head: [['Id', 'Email', 'Username', 'Nombres', 'Apellidos', 'Domicilio', 'Numero Telefono/Celular','Roles','Fecha Nacimiento','Estado','Sexo']],
            body: [
");
#nullable restore
#line 120 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                [\'");
#nullable restore
#line 123 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 123 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                         Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 123 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                        Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 123 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                          Write(item.Persona.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 123 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                                                   Write(item.Persona.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 123 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                                                                              Write(item.Persona.Domicilio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 123 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                                                                                                         Write(item.Persona.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 123 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                                                                                                                                   Write(String.Join(',',item.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 123 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                                                                                                                                                                                   Write(item.Persona.FechaNacimiento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    \'");
#nullable restore
#line 124 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 124 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                                Write(item.Persona.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'],\r\n            ");
#nullable restore
#line 125 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionCuentas\Views\Cuenta\PartialView\_ListaUsuarios.cshtml"
                   
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            ],
            columnStyles: {
                7: { cellWidth: 50 },
                8: { cellWidth: 30 }
            },
            theme: 'grid'
        });
        window.open(URL.createObjectURL(doc.output(""blob"")))
    }
    var _0x52e7 = ['POST', '8033JTJYoy', 'ajax', 'Último', 'Aceptar', 'action', '412464vgfvIo', '/Error/', 'then', '325988JXxKzS', '1FbGAQG', '#3085d6', '270650jzUuos', '#view-all', 'El\x20usuario\x20actual\x20se\x20eliminará\x20por\x20completo.', 'Mostrar\x20_MENU_\x20registros', 'Copiar', 'Mostrando\x20registros\x20del\x200\x20al\x200\x20de\x20un\x20total\x20de\x200\x20registros', 'Mostrando\x20registros\x20del\x20_START_\x20al\x20_END_\x20de\x20un\x20total\x20de\x20_TOTAL_\x20registros', 'location', '(filtrado\x20de\x20un\x20total\x20de\x20_MAX_\x20registros)', '1wMSvOW', 'href', 'value', 'Cargando...', 'status', '103965OTihmt', '¿Estás\x20seguro\x20de\x20eliminar\x20este\x20usuario?', 'Ningún\x20dato\x20disponible\x20en\x20esta\x20tabla\x20=(', 'warning', 'Visibi");
            WriteLiteral(@"lidad', 'fail', 'isValid', '208006LVGtGy', 'Procesando...', 'Anterior', '14447gRSKvD', '29VJWEML', '#d33', 'html', '49VkEvmo', 'Cancelar']; function _0x1aab(_0x5522be, _0x33fd69) { return _0x1aab = function (_0x52e7d5, _0x1aab65) { _0x52e7d5 = _0x52e7d5 - 0x96; var _0x285568 = _0x52e7[_0x52e7d5]; return _0x285568; }, _0x1aab(_0x5522be, _0x33fd69); } var _0x16fbe7 = _0x1aab; (function (_0x3b56ad, _0x12b8bb) { var _0x2d484f = _0x1aab; while (!![]) { try { var _0x2b4764 = -parseInt(_0x2d484f(0xae)) * parseInt(_0x2d484f(0x97)) + -parseInt(_0x2d484f(0xb2)) * parseInt(_0x2d484f(0xb1)) + parseInt(_0x2d484f(0xbd)) + parseInt(_0x2d484f(0xa7)) + parseInt(_0x2d484f(0x99)) + -parseInt(_0x2d484f(0xb5)) * -parseInt(_0x2d484f(0xb8)) + -parseInt(_0x2d484f(0x96)) * parseInt(_0x2d484f(0xa2)); if (_0x2b4764 === _0x12b8bb) break; else _0x3b56ad['push'](_0x3b56ad['shift']()); } catch (_0x5083a) { _0x3b56ad['push'](_0x3b56ad['shift']()); } } }(_0x52e7, 0x3799b), $('#example')['DataTable']({ 'processing': !![], 'language': { 'sProc");
            WriteLiteral(@"essing': _0x16fbe7(0xaf), 'sLengthMenu': _0x16fbe7(0x9c), 'sZeroRecords': 'No\x20se\x20encontraron\x20resultados', 'sEmptyTable': _0x16fbe7(0xa9), 'sInfo': _0x16fbe7(0x9f), 'sInfoEmpty': _0x16fbe7(0x9e), 'sInfoFiltered': _0x16fbe7(0xa1), 'sInfoPostFix': '', 'sSearch': 'Buscar:', 'sUrl': '', 'sInfoThousands': ',', 'sLoadingRecords': _0x16fbe7(0xa5), 'oPaginate': { 'sFirst': 'Primero', 'sLast': _0x16fbe7(0xba), 'sNext': 'Siguiente', 'sPrevious': _0x16fbe7(0xb0) }, 'oAria': { 'sSortAscending': ':\x20Activar\x20para\x20ordenar\x20la\x20columna\x20de\x20manera\x20ascendente', 'sSortDescending': ':\x20Activar\x20para\x20ordenar\x20la\x20columna\x20de\x20manera\x20descendente' }, 'buttons': { 'copy': _0x16fbe7(0x9d), 'colvis': _0x16fbe7(0xab) } } }), eliminarUsuario = _0xfd2e7 => { var _0x2d9bb9 = _0x16fbe7; event['preventDefault'](), Swal['fire']({ 'title': _0x2d9bb9(0xa8), 'text': _0x2d9bb9(0x9b), 'icon': _0x2d9bb9(0xaa), 'showCancelButton': !![], 'confirmButtonColor': _0x2d9bb9(0x98), 'cancelButtonColor': _0x2d9b");
            WriteLiteral(@"b9(0xb3), 'confirmButtonText': _0x2d9bb9(0xbb), 'cancelButtonText': _0x2d9bb9(0xb6) })[_0x2d9bb9(0xbf)](_0x297bd5 => { var _0x45449e = _0x2d9bb9; if (_0x297bd5[_0x45449e(0xa4)]) return $[_0x45449e(0xb9)]({ 'type': _0x45449e(0xb7), 'url': _0xfd2e7[_0x45449e(0xbc)], 'data': new FormData(_0xfd2e7), 'contentType': ![], 'processData': ![], 'success': function (_0x248695) { var _0x46fe86 = _0x45449e; $(_0x46fe86(0x9a))[_0x46fe86(0xb4)](_0x248695[_0x46fe86(0xb4)]); } })['fail'](function (_0x22c56b, _0x1bab8f, _0x925a02) { var _0x3d7e6a = _0x45449e; window[_0x3d7e6a(0xa0)][_0x3d7e6a(0xa3)] = _0x3d7e6a(0xbe) + _0x22c56b[_0x3d7e6a(0xa6)]; }), ![]; }); }, changeEstado = _0x840eb8 => { var _0x304a42 = _0x16fbe7; return $[_0x304a42(0xb9)]({ 'type': _0x304a42(0xb7), 'url': _0x840eb8['action'], 'data': new FormData(_0x840eb8), 'contentType': ![], 'processData': ![], 'success': function (_0x12f5c7) { var _0x4e68e6 = _0x304a42; _0x12f5c7[_0x4e68e6(0xad)] && $('#view-all')[_0x4e68e6(0xb4)](_0x12f5c7[_0x4e68e6(0xb4)]); } })[_0x");
            WriteLiteral("304a42(0xac)](function (_0x5b3266, _0x370499, _0x5f3cf3) { var _0x4ed7f6 = _0x304a42; window[_0x4ed7f6(0xa0)][_0x4ed7f6(0xa3)] = _0x4ed7f6(0xbe) + _0x5b3266[_0x4ed7f6(0xa6)]; }), ![]; });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
