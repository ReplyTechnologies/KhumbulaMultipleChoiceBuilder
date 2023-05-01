namespace KhumbulaMultipleChoiceBuilder.Models
{
    public class ProcessGroup
    {
        public int Index { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public List<ProcessStep> Steps { get; set; } = new();
    }
}
