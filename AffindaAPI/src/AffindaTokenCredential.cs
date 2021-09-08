using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Affinda.API
{
    public class AffindaTokenCredential : TokenCredential
    {
        public AffindaTokenCredential(string token)
        {
            Token = new AccessToken(token, DateTimeOffset.MaxValue);
        }

        public override ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override AccessToken GetToken(TokenRequestContext requestContext,
            CancellationToken cancellationToken)
        {
            return Token;
        }

        public AccessToken Token { get; set; }
    }
}
