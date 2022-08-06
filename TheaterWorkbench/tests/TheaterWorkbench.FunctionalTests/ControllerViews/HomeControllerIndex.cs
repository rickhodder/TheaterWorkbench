﻿using TheaterWorkbench.Web;
using Xunit;

namespace TheaterWorkbench.FunctionalTests.ControllerViews
{
    [Collection("Sequential")]
    public class HomeControllerIndex : IClassFixture<CustomWebApplicationFactory<WebMarker>>
    {
        private readonly HttpClient _client;

        public HomeControllerIndex(CustomWebApplicationFactory<WebMarker> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsViewWithCorrectMessage()
        {
            HttpResponseMessage response = await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            string stringResponse = await response.Content.ReadAsStringAsync();

            Assert.Contains("TheaterWorkbench.Web", stringResponse);
        }
    }
}