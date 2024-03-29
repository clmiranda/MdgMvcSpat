#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Mascota\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993d324fed2d9125a2380a9127f8ddf70ed8059a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministracionMascotas_Views_Mascota_Lista), @"mvc.1.0.view", @"/Areas/AdministracionMascotas/Views/Mascota/Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993d324fed2d9125a2380a9127f8ddf70ed8059a", @"/Areas/AdministracionMascotas/Views/Mascota/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Areas/AdministracionMascotas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdministracionMascotas_Views_Mascota_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mascota>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Mascota\Lista.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid py-3"">
    <h3>
        Lista de Mascotas
    </h3>
    <p class=""mb-3"">
        En esta vista se puede administrar la situaci&oacute;n actual de cada una de las
        mascotas registradas en la asociaci&oacute;n, el estado activo indica que esta mascota
        ya puede ser adoptada, el estado inactivo indica que la mascota a&uacute;n sigue en un
        tratamiento o no es apta para ser adoptada.
    </p>
    <div class=""d-md-flex mb-3"">
        <p class=""shadow mr-md-5 p-3 bg-white rounded"">
            <button class=""btn btn-success""><i class=""fas fa-dog fa-2""></i></button> -> Editar Datos Mascota
        </p>
        <p class=""shadow p-3 bg-white rounded"">
            <button class=""btn btn-primary""><i class=""fas fa-list""></i></button> -> Reporte Tratamiento Mascota
        </p>
    </div>
        <div id=""view-all"">
            ");
#nullable restore
#line 24 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Areas\AdministracionMascotas\Views\Mascota\Lista.cshtml"
       Write(await Html.PartialAsync("PartialView/_Lista", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mascota>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
