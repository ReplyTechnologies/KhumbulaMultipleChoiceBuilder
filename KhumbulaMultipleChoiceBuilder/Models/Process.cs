namespace KhumbulaMultipleChoiceBuilder.Models
{
    public class Process
    {
        public string Id { get; set; }

        public string Title { get; set; } = "";

        public string? Description { get; set; }

        public List<ProcessGroup> Groups { get; set; } = new();
    }
}
