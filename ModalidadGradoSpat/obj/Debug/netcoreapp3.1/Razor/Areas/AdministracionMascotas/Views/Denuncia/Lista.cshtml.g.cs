#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Denuncia\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd2199ac6aea664c339ab8317bb8fb051fb537a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionMascotas_Views_Denuncia_Lista), @"mvc.1.0.view", @"/Areas/AdministracionMascotas/Views/Denuncia/Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd2199ac6aea664c339ab8317bb8fb051fb537a6", @"/Areas/AdministracionMascotas/Views/Denuncia/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionMascotas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdministracionMascotas_Views_Denuncia_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Denuncia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Denuncia\Lista.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid py-3"">
    <h3>
        Lista de Denuncias
    </h3>
    <p class=""mb-3"">
        Esta vista est&aacute; dise&ntilde;ada para administrar las denuncias que se realizan de las mascotas,
        para realizar un posterior registro de las mismas.
    </p>
    <div class=""d-md-flex mb-3"">
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-success""><i class=""fas fa-dog fa-2""></i></button> -> Editar Informaci&oacute;n Mascota.
        </p>
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-info""><i class=""fa fa-edit fa-2"" aria-hidden=""true""></i></button> -> Editar la Denuncia.
        </p>
        <p class=""shadow p-3 bg-white rounded"">
            <button class=""btn btn-danger""><i class=""fa fa-trash fa-2"" aria-hidden=""true""></i></button> -> Eliminar la Denuncia.
        </p>
    </div>
    <div id=""view-all"">
        ");
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Denuncia\Lista.cshtml"
   Write(await Html.PartialAsync("PartialView/_Lista", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Denuncia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
