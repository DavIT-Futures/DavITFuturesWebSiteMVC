using System.Collections.Specialized;
using System.Web;
using davIT.Models;
using Xunit;

namespace davIT.Tests
{
    public class ExtensionMethodsTests
    {
        private sealed class FakeHttpRequest : HttpRequestBase
        {
            private readonly NameValueCollection _serverVariables;

            public FakeHttpRequest(NameValueCollection serverVariables)
            {
                _serverVariables = serverVariables;
            }

            public override NameValueCollection ServerVariables => _serverVariables;
        }

        [Fact]
        public void Contains_MatchesExactServerVariableKey()
        {
            var variables = new NameValueCollection
            {
                ["REMOTE_ADDR"] = "127.0.0.1",
                ["HTTP_USER_AGENT"] = "UnitTest"
            };
            var request = new FakeHttpRequest(variables);

            Assert.True(request.Contains("REMOTE_ADDR"));
            Assert.False(request.Contains("HTTP_X_FORWARDED_FOR"));
        }
    }
}
