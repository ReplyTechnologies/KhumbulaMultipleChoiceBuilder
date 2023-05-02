namespace KhumbulaMultipleChoiceBuilder.Models
{
    public class ProcessProperty
    {
        public int Index { get; set; }

        public string Type { get; set; } = "";

        public string? Key { get; set; }

        public string? VisibilityExpression { get; set; }

        public bool Required { get; set; }

        public string? RequiredExpression { get; set; }

        public Dictionary<string, object> Configuration { get; set; } = new();
    }
}
