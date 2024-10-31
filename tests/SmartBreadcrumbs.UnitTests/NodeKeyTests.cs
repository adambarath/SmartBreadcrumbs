using Brupper.AspNetCore.Breadcrumbs.Nodes;
using System.Collections.Generic;
using Xunit;

namespace Brupper.AspNetCore.Breadcrumbs.UnitTests
{
    public class NodeKeyTests
    {
        [Fact]
        public void Ctor_ShouldNotThrow_WhenKeyIsMissing()
        {
            var routeValues = new Dictionary<string, string>
            {
                { "controller", "Home" },
                { "action", "Index" }
            };

            var ex = Record.Exception(() => new NodeKey(routeValues, "GET"));

            Assert.Null(ex);
        }
    }
}
