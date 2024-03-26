namespace BlazorWasm.CosmosPersona.Models;

public class KeyValueModel
{
    public string Key { get; set; }
    public int Score { get; set; }

    public KeyValueModel(string key, int score = 0)
    {
        Key = key;
        Score = score;
    }
}