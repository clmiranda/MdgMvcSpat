#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2993cde7c9199d5d938836ffec3ea0417c758155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionAdopciones_Views_Adopcion_Lista), @"mvc.1.0.view", @"/Areas/AdministracionAdopciones/Views/Adopcion/Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2993cde7c9199d5d938836ffec3ea0417c758155", @"/Areas/AdministracionAdopciones/Views/Adopcion/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionAdopciones/_ViewImports.cshtml")]
    public class Areas_AdministracionAdopciones_Views_Adopcion_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SolicitudAdopcion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Lista.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    tr.hiddentablerow td {
        padding: 0;
    }
</style>
<div class=""container-fluid py-3"">
    <h3>
        Lista de Solicitudes de Adopci&oacute;n
    </h3>
    <p class=""mb-3"">
        Vista para la administraci&oacute;n de las solicitudes de adopci&oacute;n
        seg&uacute;n su estado.
    </p>
    <div class=""d-md-flex mb-3"">
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-primary""><i class=""far fa-eye"" aria-hidden=""true""></i></button> -> Acciones/Detalle de la Adopci&oacute;n.
        </p>
    </div>
    <div id=""view-all"">
        ");
#nullable restore
#line 24 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionAdopciones\Views\Adopcion\Lista.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SolicitudAdopcion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
