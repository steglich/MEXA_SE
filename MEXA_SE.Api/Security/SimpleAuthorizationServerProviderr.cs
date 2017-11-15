using MEXA_SE.Domain.Services;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MEXA_SE.Api.Security
{
    public class SimpleAuthorizationServerProviderr : OAuthAuthorizationServerProvider
    {
        IUsuarioApplicationService _userService;

        public SimpleAuthorizationServerProviderr(IUsuarioApplicationService userService)
        {
            this._userService = userService;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            var user = _userService.GetAuthenticateUsuario(context.UserName, context.Password);
            if (user == null)
            {
                context.SetError("invalid_grant", "Usuário ou senha inválidos");
                return;
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            identity.AddClaim(new Claim(ClaimTypes.Name, user.Email));
            //identity.AddClaim(new Claim(ClaimTypes.Role, value: user.Email ? "admin" : ""));

            //GenericPrincipal principal = new GenericPrincipal(identity, new string[] { user.Authentica ? "email" : "" });
            //Thread.CurrentPrincipal = principal;

            context.Validated(identity);
        }
    }
}