using DATA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace ModalidadGradoSpat.Tests.Data;

/// <summary>
/// DATA tiene <c>Nullable</c> activo y sus tipos se enlazan desde formularios. MVC trata como
/// <c>[Required]</c> implícito toda propiedad de referencia no anulable sin atributo, lo que dejaría
/// inválidos formularios que antes eran válidos. Estos tests fijan que no ocurre: la validación de un
/// objeto vacío es la misma con y sin ese comportamiento, es decir, solo fallan los <c>[Required]</c> explícitos.
/// Si falla, la propiedad nueva debe ser <c>?</c> (opcional) o llevar <c>[Required]</c> (obligatoria).
/// </summary>
public class NulabilidadModelosTests
{
    private static HashSet<string> ErroresDeUnObjetoVacio(Type tipo, bool suprimirRequeridoImplicito)
    {
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddControllersWithViews(options =>
            options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = suprimirRequeridoImplicito);
        using var provider = services.BuildServiceProvider();

        var modelState = new ModelStateDictionary();
        var contexto = new ActionContext(
            new DefaultHttpContext { RequestServices = provider }, new RouteData(), new ActionDescriptor(), modelState);
        provider.GetRequiredService<IObjectModelValidator>()
            .Validate(contexto, validationState: null, prefix: "", model: Activator.CreateInstance(tipo));

        return [.. modelState.Where(e => e.Value!.Errors.Count > 0).Select(e => e.Key)];
    }

    public static TheoryData<Type> TiposDeData()
    {
        var tipos = typeof(Mascota).Assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsPublic && t.GetConstructor(Type.EmptyTypes) != null)
            .Where(t => t.Namespace!.StartsWith("DATA", StringComparison.Ordinal))
            .OrderBy(t => t.Name);

        var data = new TheoryData<Type>();
        foreach (var tipo in tipos)
        {
            data.Add(tipo);
        }
        return data;
    }

    [Theory]
    [MemberData(nameof(TiposDeData))]
    public void La_nulabilidad_no_agrega_Required_implicito(Type tipo)
    {
        var conComportamientoPorDefecto = ErroresDeUnObjetoVacio(tipo, suprimirRequeridoImplicito: false);
        var soloAtributosExplicitos = ErroresDeUnObjetoVacio(tipo, suprimirRequeridoImplicito: true);

        Assert.Equal(soloAtributosExplicitos.Order(), conComportamientoPorDefecto.Order());
    }
}
