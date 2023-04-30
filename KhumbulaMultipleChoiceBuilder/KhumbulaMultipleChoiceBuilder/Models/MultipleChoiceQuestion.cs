namespace KhumbulaMultipleChoiceBuilder.Models
{
    public class MultipleChoiceQuestion
    {
        public List<string> RawLines { get; set; } = new();

        public string? Title { get; set; }

        public string? Description { get; set; }

        public List<OptionItem> Options { get; set; } = new();

        public object? Answer { get; set; }

        public string? AnswerDescription { get; set; }

        public override string ToString()
        {
            return Title ?? "[no title]";
        }
    }
}
