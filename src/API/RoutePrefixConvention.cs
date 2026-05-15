using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace API;


/// <summary>
/// Configuracion para establecer como convencion de todos los endpoints el prefijo api/s
/// </summary>
public class RoutePrefixConvention : IApplicationModelConvention
{
    public void Apply(ApplicationModel application)
    {
        foreach (var controller in application.Controllers)
        {
            foreach (var selector in controller.Selectors)
            {
                if (selector.AttributeRouteModel != null)
                {
                    selector.AttributeRouteModel = new AttributeRouteModel
                    {
                        Template = AttributeRouteModel.CombineTemplates("api", selector.AttributeRouteModel.Template)
                    };
                }
            }
        }
    }
}
