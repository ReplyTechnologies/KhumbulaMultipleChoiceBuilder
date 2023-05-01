namespace KhumbulaMultipleChoiceBuilder.Models
{
    public class ProcessStep
    {
        public int Index { get; set; }

        public string Title { get; set; } = "";

        public string? Description { get; set; }

        public string? ValidationExpression { get; set; }

        public List<ProcessProperty> Properties { get; set; } = new();
    }
}
