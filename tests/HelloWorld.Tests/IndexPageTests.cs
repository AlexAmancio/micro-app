using Xunit;
using HelloWorld.Pages;
using Microsoft.Extensions.Logging;
using Moq;

namespace HelloWorld.Tests
{
    public class IndexPageTests
    {
        [Fact]
        public void OnGet_ShouldNotThrow()
        {
            var loggerMock = new Mock<ILogger<IndexModel>>();
            var pageModel = new IndexModel(loggerMock.Object);

            var ex = Record.Exception(() => pageModel.OnGet());

            Assert.Null(ex);
        }

        [Fact]
        public void OnGet_SetsMensajeCorrectamente()
        {
            var loggerMock = new Mock<ILogger<IndexModel>>();
            var pageModel = new IndexModel(loggerMock.Object);

            pageModel.OnGet();

            Assert.Equal(" Hola Mundo", pageModel.Mensaje);
        }
    }
}
