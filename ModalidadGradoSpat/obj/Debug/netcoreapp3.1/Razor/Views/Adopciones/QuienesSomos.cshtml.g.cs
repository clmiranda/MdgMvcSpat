#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Adopciones\QuienesSomos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50dd9b1a2284688fedf515e5d77095e54730eb63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adopciones_QuienesSomos), @"mvc.1.0.view", @"/Views/Adopciones/QuienesSomos.cshtml")]
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
using ModalidadGradoSpat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using DATA.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50dd9b1a2284688fedf515e5d77095e54730eb63", @"/Views/Adopciones/QuienesSomos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8f1a948d8581be59cf7c803f0c525d3d30e1da", @"/Views/_ViewImports.cshtml")]
    public class Views_Adopciones_QuienesSomos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Adopciones\QuienesSomos.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container my-5"">
    <p class=""text-justify lead"">
        Los Miembros de SPAT tenemos un compromiso con el bienestar de los animales que tenemos a nuestro cargo y brindar ayuda a todos los que podemos sean silvestres o mascotas, haciendo cumplir sus derechos. 
        Al ser una organización de voluntariado contamos con pocas personas que son miembros activos ya que no es tarea fácil y muchas veces es triste el estado de los animales por la cantidad de personas 
        inconscientes e ignorantes con el trato animal. Todas las persona mayores de 15 años pueden ser miembros de SPAT y colaborar en sus posibilidades. Con la pena no conseguimos nada!! Es necesario actuar 
        ante el abandono y crueldad con la que tratan a los animales... SI TU PENA SOLO HIZO RECOGER UN ANIMAL O VERLO EN DESGRACIA... QUE TU PENA TAMBIÉN SIRVA PARA AYUDARLO! .... Y NO DESHACERTE DEL ANIMAL!
        No esperemos que terceros hagan lo que nuestra conciencia nos grita como deber!!
    </p>
    <div class=""mt");
            WriteLiteral(@"-5"">
        <p class=""lead"">Nuestras Redes Sociales:</p>
        <a id=""facebook"" class=""btn btn-lg mt-2"" style=""color: dodgerblue;"" href=""https://www.facebook.com/sociedadprotectoradeanimalestarija/"">
            <i class=""fab fa-3x fa-facebook""></i>
            P&aacute;gina de Facebook
        </a>
        <a id=""instagram"" class=""btn btn-lg mt-2"" href=""https://www.instagram.com/sociedadprotectoradeanimalestj/"">
            <i class=""fab fa-3x fa-instagram""></i>
            P&aacute;gina de Instagram
        </a>
    </div>
    <div class=""mt-5"">
        <p class=""lead"">
            Si quieres conocer sobre la Ley de Protecci&oacute;n, Control y Cuidado
            de Animales Domesticos de Compa&ntilde;&iacute;a, aqu&iacute; tienes el codumento:
        </p>
        <a class=""btn btn-lg mt-2""");
            BeginWriteAttribute("href", " href=\"", 1902, "\"", 1965, 1);
#nullable restore
#line 28 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Adopciones\QuienesSomos.cshtml"
WriteAttributeValue("", 1909, Url.Action("LeyMunicipal","Adopciones", new { area=""}), 1909, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fas fa-3x fa-file-download\"></i>\r\n            Ley Municipal N° 217\r\n        </a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
