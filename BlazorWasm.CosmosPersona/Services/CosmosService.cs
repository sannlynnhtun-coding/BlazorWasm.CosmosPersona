using BlazorWasm.CosmosPersona.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorWasm.CosmosPersona.Services
{
    public class CosmosService
    {
        private readonly HttpClient _httpClient;

        public CosmosService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CosmosQuestionAndAnswerModel> GetData()
        {
            var result = await GetData<CosmosQuestionAndAnswerModel>("data/cosmos-question-and-answer.json");
            return result;
        }
        private async Task<T?> GetData<T>(string filePath)
        {
            return await _httpClient.GetFromJsonAsync<T>(filePath);
        }
    }
}
