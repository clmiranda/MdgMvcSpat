#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3af5416a5cd556b9bbe9da9254fe21b4acd69928"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionSeguimientos_Views_Seguimiento_Lista), @"mvc.1.0.view", @"/Areas/AdministracionSeguimientos/Views/Seguimiento/Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af5416a5cd556b9bbe9da9254fe21b4acd69928", @"/Areas/AdministracionSeguimientos/Views/Seguimiento/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionSeguimientos/_ViewImports.cshtml")]
    public class Areas_AdministracionSeguimientos_Views_Seguimiento_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Seguimiento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Lista.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid py-3"">
    <h3>
        Vista Listado de Seguimientos
    </h3>
    <p class=""mb-3"">
        En esta vista se muestra el listado de los seguimientos de las adopciones
        que se realizan a las mascotas adoptadas.
    </p>
    <div class=""d-md-flex mb-3"">
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-primary""><i class=""fa fa-user"" aria-hidden=""true""></i></button> -> Acciones de Asignaci&oacute;n de Seguimiento.
        </p>
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-warning""><i class=""fa fa-eye"" aria-hidden=""true""></i></button> -> Lista de Reportes de Seguimiento.
        </p>
        <p class=""shadow p-3 bg-white rounded"">
            <button class=""btn btn-success""><i class=""fas fa-list"" aria-hidden=""true""></i></button> -> Informaci&oacute;n de adoptante y mascota.
        </p>
    </div>
    <div id=""view-all"">
        ");
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionSeguimientos\Views\Seguimiento\Lista.cshtml"
   Write(await Html.PartialAsync("PartialView/_Lista", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Seguimiento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
