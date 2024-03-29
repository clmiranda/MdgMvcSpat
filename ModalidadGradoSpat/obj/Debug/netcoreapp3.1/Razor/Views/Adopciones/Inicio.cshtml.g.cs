#pragma checksum "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Adopciones\Inicio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf9cc8bc8050d3899fa0be7342882ed78eb96f14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adopciones_Inicio), @"mvc.1.0.view", @"/Views/Adopciones/Inicio.cshtml")]
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
using DATA.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using DATA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\_ViewImports.cshtml"
using ModalidadGradoSpat.Areas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9cc8bc8050d3899fa0be7342882ed78eb96f14", @"/Views/Adopciones/Inicio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b887823c7989354ce31038c2062fde22dd578145", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Adopciones_Inicio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mascota>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Adopciones\Inicio.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .carousel-item {
        height: 400px;
    }

    .carousel-inner img {
        display: inline-block !important;
    }

    .carousel-item .img-fluid {
        height: 100%;
        width: 100%;
    }

    .carousel-inner {
        background-color: #036917;
    }

    .card {
        transition: transform 0.2s ease-in-out;
    }

        .card:hover {
            transform: translateY(-0.5rem);
            box-shadow: 0 0.5em 3rem -1rem rgba(0,0,0,0.5);
        }
</style>
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner text-center"">
        <div class=""carousel-item active"">
            <img class=""d-block img-fluid"" src=""https://res.cloudinary.com/dfgd6kc8v/image/uplo");
            WriteLiteral(@"ad/v1643849629/slide1_eefng7.jpg"" alt=""Informacion"" style=""width:100vh;"">
            <b class=""carousel-caption text-center""><i>Somos una asociaci&oacute;n sin fines de lucro.</i></b>
        </div>
        <div class=""carousel-item"">
            <img class=""d-block img-fluid"" src=""https://res.cloudinary.com/dfgd6kc8v/image/upload/v1643849629/slide2_norbgn.jpg"" alt=""Compromiso"" style=""width:100vh;"">
            <b class=""carousel-caption text-center"">
                <i>
                    ""Tenemos un compromiso con el bienestar de los animales que tenemos a nuestro cargo y brindar
                    ayuda a todos los que podemos sean silvestres o mascotas, haciendo cumplir sus derechos.""
                </i>
            </b>
        </div>
        <div class=""carousel-item"">
            <img class=""d-block img-fluid"" src=""https://res.cloudinary.com/dfgd6kc8v/image/upload/v1643849629/slide3_n6albw.jpg"" alt=""Lema"" style=""width: 100vh;"">
            <b class=""carousel-caption text-center""><i>""S");
            WriteLiteral(@"I TU PENA SOLO HIZO RECOGER UN ANIMAL O VERLO EN DESGRACIA... QUE TU PENA TAMBIÉN SIRVA PARA AYUDARLO! .... Y NO DESHACERTE DEL ANIMAL!""</i></b>
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>
<div class=""container"">
    <hr class=""my-5"">
    <p class=""lead font-italic text-center"">
        ""S.P.A.T. es una organización de voluntarios sin fines de lucro, que ayudan al bienestar de los animales accidentados y en estado de emergencia.""
    </p>
    <hr class=""my-4"">
    <div class=""row featurette"">
        <div class=""col-xl-8"">
            <h2 class=""featurette-heading"">Rifas y");
            WriteLiteral(@" sorteos solidarios</h2>
            <p class=""lead mt-3 text-justify"">
                Realizamos rifas y sorteos solidarias con el fin de cubrir ciertas necesidades econ&oacute;micas
                de la asociaci&oacute;n con las veterinarias para poder seguir con nuestra labor como asociaci&oacute;n.
            </p>
        </div>
        <div class=""col-xl-4 text-center"">
            <img class=""featurette-image img-fluid rounded"" alt=""Sorteos y Rifas"" src=""https://res.cloudinary.com/dfgd6kc8v/image/upload/v1645820128/rifas_xyvwnc.jpg"" style=""width: 400px; height: 350px;"">
        </div>
    </div>
    <hr class=""my-4"">
    <div class=""row featurette"">
        <div class=""col-xl-8 order-xl-2"">
            <h2 class=""featurette-heading"">Mascotas extraviadas y encontradas</h2>
            <p class=""lead mt-3 text-justify"">
                Puedes comunicarte con nosotros a trav&eacute;s de nuestra p&aacute;gina de facebook:
                <a href=""https://www.facebook.com/sociedadprotector");
            WriteLiteral(@"adeanimalestarija/"" class=""alert-link"">Spat Tarija</a>
                proporcion&aacute;ndonos informaci&oacute;n de tu mascota extraviada incluida una fotograf&iacute;a, la cu&aacute;l
                ser&aacute; compartida desde nuestra p&aacute;gina, tambi&eacute;n publicamos las fotos de las mascotas que
                son encontradas en la calle por nuestros voluntarios.
            </p>
        </div>
        <div class=""col-xl-4 order-xl-1 text-center"">
            <img class=""featurette-image img-fluid rounded"" alt=""Mascota Extraviada"" src=""https://res.cloudinary.com/dfgd6kc8v/image/upload/v1643849629/mascotaextraviada_f44i8e.jpg"" style=""width: 400px; height: 300px;"">
        </div>
    </div>
    <hr class=""my-4"" />
    <div class=""row featurette"">
        <div class=""col-xl-8"">
            <h2 class=""featurette-heading"">Apadrinar Mascotas</h2>
            <p class=""lead mt-3 text-justify"">
                Si quieres apadrinar el tratamiento o las vacunas de las mascotas de la asocia");
            WriteLiteral(@"ci&oacute;n, puedes comunicarte con
                nosotros a trav&eacute;s de nuestra <a href=""https://www.facebook.com/sociedadprotectoradeanimalestarija/"" class=""alert-link"">p&aacute;gina de facebook</a>
                para brindarte m&aacute;s informaci&oacute;n al respecto.
            </p>
        </div>
        <div class=""col-xl-4 text-center"">
            <img class=""featurette-image img-fluid rounded"" alt=""Sorteos y Rifas"" src=""https://res.cloudinary.com/dfgd6kc8v/image/upload/v1645819999/apadrinar_mbuvsi.jpg"" style=""width: 400px; height: 350px;"">
        </div>
    </div>
    <hr class=""my-4"" />
    <div id=""view-all"">
        <h3>
            Lista de Mascotas
        </h3>
        <p class=""mb-4"">
            Aqu&iacute; se visualizan las mascotas de los albergues de la asociaci&oacute;n,
            solo puedes aplicar a la adopci&oacute;n para aquellas mascotas que ya est&eacute;n
            listas para ser adoptadas, adem&aacute;s debes responder una serie de preguntas
   ");
            WriteLiteral("         y esperar que nos pongamos en contacto contigo en caso de ser apto para la adopci&oacute;n,\r\n            tambi&eacute;n llevaremos un seguimiento del cuidado de la mascota que adoptes.\r\n        </p>\r\n        ");
#nullable restore
#line 126 "C:\Users\Usuario\source\repos\ModalidadGradoSpat\ModalidadGradoSpat\Views\Adopciones\Inicio.cshtml"
   Write(await Html.PartialAsync("PartialView/_Inicio", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<script>\r\n    $(\'.carousel\').carousel();\r\n</script>");
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
