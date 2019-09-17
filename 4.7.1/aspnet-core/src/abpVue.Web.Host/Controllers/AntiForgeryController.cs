using Microsoft.AspNetCore.Antiforgery;
using abpVue.Controllers;

namespace abpVue.Web.Host.Controllers
{
    public class AntiForgeryController : abpVueControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
