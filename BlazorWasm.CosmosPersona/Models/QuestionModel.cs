namespace BlazorWasm.CosmosPersona.Models
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public string Image { get; set; }
        public List<AnswerModel> Answers { get; set; }
    }

    public class AnswerModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
