using Microsoft.AspNetCore.Builder;

namespace EntityInterface.Core;

#pragma warning disable ASP0014 // Suggest using top level route registrations
public static class WebApplicationExtensions
{
    public static WebApplication MapEntityInterfacePages(this WebApplication app)
    {
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute("accounts", "/accounts", new { controller = "DynamicCrudPages", action = "Index", entity="account" });
            endpoints.MapControllerRoute("accounts", "/accounts/{id}", new { controller = "DynamicCrudPages", action = "Show", entity = "account" });
        });

        return app;
    }
}
#pragma warning restore ASP0014 // Suggest using top level route registrations