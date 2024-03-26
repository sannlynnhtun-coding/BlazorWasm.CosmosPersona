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
            var result = await GetData<List<QuestionModel>>("data/cosmos.json");
            var result2 = await GetData<List<AnswerModel>>("data/cosmos-images.json");
            return new CosmosQuestionAndAnswerModel
            {
                questions = result!,
                images = result2!,
            };
        }
        private async Task<T?> GetData<T>(string filePath)
        {
            return await _httpClient.GetFromJsonAsync<T>(filePath);
        }
    }
}
