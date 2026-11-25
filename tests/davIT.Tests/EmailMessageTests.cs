using davIT.Models;
using Xunit;

namespace davIT.Tests
{
    public class EmailMessageTests
    {
        [Fact]
        public void Constructor_PopulatesContactPayloadProperties()
        {
            var message = new EmailMessage("client@example.com", "Project inquiry", "+48123456789", null);

            Assert.Equal("client@example.com", message.Sender);
            Assert.Equal("Project inquiry", message.Message);
            Assert.Equal("+48123456789", message.PhoneNumber);
            Assert.Null(message.Request);
        }
    }
}
