using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace micro_service_consumer.Pages
{
    public class PrivacyModel : PageModel
    {
        public string MSResponse { get; set; }
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(IHttpClientFactory httpClientFactory, ILogger<PrivacyModel> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<IActionResult> OnGet()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("http://micro-service");
            var response = await client.GetStringAsync("/api/environment");
            _logger.LogCritical($"Response is: {response}");
            MSResponse = response;
            return Page();
        }
    }
}