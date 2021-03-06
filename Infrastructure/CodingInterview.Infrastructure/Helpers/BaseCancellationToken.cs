using System.Threading;

namespace CodingInterview.Infrastructure.Helpers
{
    public abstract class BaseCancellationToken
    {
        public abstract CancellationToken Token { get; }

        public static implicit operator CancellationToken(BaseCancellationToken baseCancellationToken) =>
            baseCancellationToken.Token;
    }
}