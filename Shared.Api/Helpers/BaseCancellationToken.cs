using System.Threading;

namespace Shared.Api.Helpers
{
    public abstract class BaseCancellationToken
    {
        public abstract CancellationToken Token { get; }

        public static implicit operator CancellationToken(BaseCancellationToken baseCancellationToken) =>
            baseCancellationToken.Token;
    }
}