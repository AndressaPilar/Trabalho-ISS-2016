using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Api
{
    public void Configuration(IAppBuilder app)
    {
        var config = new HttpConfiguration();

        //Resolução de depêndencia
        var container = new UnityContainer();
        DependencyResolver.Resolve(container);
        config.DependencyResolver = new UnityResolver(container);

        ConfigureWebApi(config);
        ConfigureOAuth(app, container.Resolve<IAutenticacao>());

        //Deixa o serviço publico sem restrições
        app.UseCors(CorsOptions.AllowAll);
        app.UseWebApi(config);

        //Incluir os mapeamento de classe
        AutoMapperConfig.RegisterMappings();
    }

    public void ConfigureWebApi(HttpConfiguration config)
    {
        config.MapHttpAttributeRoutes();

        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/id",
            defaults: new { id = RouteParameter.Optional }
            );
    }

    public void ConfigureOAuth(IAppBuilder app, IAutenticacao serviceAutenticacao)
    {
        var oAuthServerOptions = new OAuthAuthorizationServerOptions()
        {
            AllowInsecureHttp = true,
            TokenEndpointPath = new PathString("/api/security/token"),
            AccessTokenExpireTimeSpan = TimeSpan.FromHours(2),
            Provider = new AuthorizationServerProvider(serviceAutenticacao)
        };

        app.UseOAuthAuthorizationServer(oAuthServerOptions);
        app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
    }
}
}
