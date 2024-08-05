using System.Net;
using AFSTest.Models;
using AFSTest.Repositories.Interfaces;
using AFSTest.Services;
using Moq;
using Newtonsoft.Json;

namespace AFSTest.Tests.TranslationTests
{
    public class LeetSpeakTranslateTest
    {
        private readonly Mock<ITranslationRepository> _translationRepositoryMock;

        public LeetSpeakTranslateTest()
        {
            _translationRepositoryMock = new Mock<ITranslationRepository>();
        }

        private HttpClient CreateMockHttpClient(HttpResponseMessage? responseMessage)
        {
            var mockHandler = new MockHttpMessageHandler(responseMessage ?? new HttpResponseMessage(HttpStatusCode.OK));
            return new HttpClient(mockHandler);
        }

        [Fact]
        public async Task TranslateToLeetSpeakAsync_ReturnsTranslation_WhenResponseIsSuccessful()
        {
            var originalText = "Hello";
            var expectedTranslatedText = "H3ll0";

            var responseContent = new TranslationResponse
            {
                Contents = new Contents
                {
                    TranslatedText = expectedTranslatedText
                }
            };

            var responseMessage = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(JsonConvert.SerializeObject(responseContent))
            };

            var httpClient = CreateMockHttpClient(responseMessage);
            var translationService = new TranslationService(httpClient, _translationRepositoryMock.Object);

            var result = await translationService.TranslateToLeetSpeakAsync(originalText);

            Assert.NotNull(result);
            Assert.Equal(expectedTranslatedText, result.Contents.TranslatedText);

            _translationRepositoryMock.Verify(repo => repo.SaveTranslationAsync(It.Is<TranslationRecord>(record =>
                record.OriginalText == originalText &&
                record.TranslatedText == expectedTranslatedText &&
                record.Timestamp != default
            )), Times.Once);
        }
    }
}