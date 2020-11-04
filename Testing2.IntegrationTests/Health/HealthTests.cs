using System;
using System.Net;
using System.Net.Http;
using FluentAssertions;
using testing2.IntegrationTests.Configuration;
using Xunit;

namespace testing2.IntegrationTests.Health
{
    public class HealthTests
    {
        [Fact]
        public void Should_get_successful_service_health()
        {
            // Arrange
            var client = new HttpClient();

            // Act
            var response = client.GetAsync(new Uri(new Uri(Config.BaseUrl), "health")).Result;

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}