using System.Threading;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Http;

namespace Core.Web.Helpers
{
    public class RequestCancellationToken : BaseCancellationToken
    {
        private readonly IHttpContextAccessor _context;

        public RequestCancellationToken(IHttpContextAccessor context)
        {
            _context = context;
        }

        public override CancellationToken Token => _context.HttpContext?.RequestAborted ?? new CancellationToken();
    }
}