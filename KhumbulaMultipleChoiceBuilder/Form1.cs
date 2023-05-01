using KhumbulaMultipleChoiceBuilder.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace KhumbulaMultipleChoiceBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadQuestions_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text Files | *.txt";
            ofd.DefaultExt = "txt";

            var result = ofd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            OpenRawQuestions(ofd.FileName);
        }

        private List<MultipleChoiceQuestion> _questions { get; set; } = new();
        private MultipleChoiceQuestion? _selectedQuestion { get; set; }

        private string _sourceFile = "";

        public void OpenRawQuestions(string fileName)
        {
            _sourceFile = fileName;
            lblQuestionsPath.Text = _sourceFile;

            _questions.Clear();

            var lines = File.ReadAllLines(fileName);

            var index = 0;

            MultipleChoiceQuestion currentQuestion = null;

            while (index < lines.Length)
            {
                var currentLine = lines.ElementAt(index++);
                if (String.IsNullOrWhiteSpace(currentLine))
                {
                    currentQuestion = null;
                    continue;
                }

                if (currentQuestion == null)
                {
                    currentQuestion = new MultipleChoiceQuestion();
                    _questions.Add(currentQuestion);
                }

                currentQuestion.RawLines.Add(currentLine);
            }

            foreach (var question in _questions)
            {
                for (var i = 0; i < question.RawLines.Count; i++)
                {
                    var line = question.RawLines
                        .ElementAt(i)
                        .Replace('\t', ' ')
                        .Trim();

                    var trimRegex = new Regex("^([ABCD]?([0-9]*(\\.[0-9]*)*)?)\\s+");
                    line = trimRegex.Replace(line, "");

                    var answerRegex = new Regex("^\\[[ABCD]?\\]");

                    if (i < question.RawLines.Count - 4)
                    {
                        if (answerRegex.IsMatch(line))
                        {
                            var answer = line.TrimStart('[').TrimEnd(']');
                            question.Answer = answer;
                        }
                        else
                        {
                            question.Title += ((String.IsNullOrEmpty(question.Title)) ? "" : Environment.NewLine) + line;
                        }
                    }
                    else
                    {
                        var answerIndex = 4 - (question.RawLines.Count - i);
                        question.Options.Add(new OptionItem()
                        {
                            Index = answerIndex,
                            Value = (new string[] { "A", "B", "C", "D" }).ElementAt(answerIndex),
                            Label = line,
                        });
                    }
                }
            }

            lbxQuestions.Items.Clear();
            lbxQuestions.Items.AddRange(_questions.ToArray());

            _selectedQuestion = null;

            ShowSelectedQuestionAnswer();
        }

        private void lbxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxQuestions.SelectedIndex == -1)
            {
                _selectedQuestion = null;
            }
            else
            {
                _selectedQuestion = _questions.ElementAt(lbxQuestions.SelectedIndex);
            }

            ShowSelectedQuestionAnswer();
        }

        private void ShowSelectedQuestionAnswer()
        {
            tbxQuestion.Text = _selectedQuestion?.Title;
            tbxQuestionA.Text = _selectedQuestion?.Options.ElementAt(0).Label;
            tbxQuestionB.Text = _selectedQuestion?.Options.ElementAt(1).Label;
            tbxQuestionC.Text = _selectedQuestion?.Options.ElementAt(2).Label;
            tbxQuestionD.Text = _selectedQuestion?.Options.ElementAt(3).Label;

            bool isA = _selectedQuestion?.Answer?.Equals("A") ?? false;
            bool isB = _selectedQuestion?.Answer?.Equals("B") ?? false;
            bool isC = _selectedQuestion?.Answer?.Equals("C") ?? false;
            bool isD = _selectedQuestion?.Answer?.Equals("D") ?? false;

            gbxAnswerA.Text = "A" + (isA ? " (selected)" : "");
            gbxAnswerB.Text = "B" + (isB ? " (selected)" : "");
            gbxAnswerC.Text = "C" + (isC ? " (selected)" : "");
            gbxAnswerD.Text = "D" + (isD ? " (selected)" : "");

            btnSetAnswerA.BackColor = isA ? Color.Blue : Color.White;
            btnSetAnswerB.BackColor = isB ? Color.Blue : Color.White;
            btnSetAnswerC.BackColor = isC ? Color.Blue : Color.White;
            btnSetAnswerD.BackColor = isD ? Color.Blue : Color.White;
        }

        private void SetSelectedQuestionAnswer(object value)
        {
            if (_selectedQuestion == null)
            {
                return;
            }

            _selectedQuestion.Answer = value;
            ShowSelectedQuestionAnswer();
            lbxQuestions.Focus();
        }

        private void btnSetAnswerA_Click(object sender, EventArgs e)
        {
            SetSelectedQuestionAnswer("A");
        }

        private void btnSetAnswerB_Click(object sender, EventArgs e)
        {
            SetSelectedQuestionAnswer("B");
        }

        private void btnSetAnswerC_Click(object sender, EventArgs e)
        {
            SetSelectedQuestionAnswer("C");
        }

        private void btnSetAnswerD_Click(object sender, EventArgs e)
        {
            SetSelectedQuestionAnswer("D");
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text Files | *.txt";
            sfd.DefaultExt = "txt";

            var result = sfd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var lines = new List<string>();

            foreach (var question in _questions)
            {
                lines.Add(question.Title);
                lines.Add($"[{question.Answer}]");
                lines.AddRange(question.Options.Select((option) => $"{option.Value}. {option.Label}"));
                lines.Add("");
            }

            File.WriteAllLines(sfd.FileName, lines);
        }

        private void tbxQuestion_KeyUp(object sender, KeyEventArgs e)
        {
            if (_selectedQuestion == null)
            {
                return;
            }

            _selectedQuestion.Title = tbxQuestion.Text;
            _selectedQuestion.Options[0].Label = tbxQuestionA.Text;
            _selectedQuestion.Options[1].Label = tbxQuestionB.Text;
            _selectedQuestion.Options[2].Label = tbxQuestionC.Text;
            _selectedQuestion.Options[3].Label = tbxQuestionD.Text;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "JSON Files | *.json";
            sfd.DefaultExt = "json";

            var result = sfd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var process = new Process()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "[[Process title]]",
                Description = "[[Process description]]"
            };

            var processGroup = new ProcessGroup()
            {
                Title = "[[Group title]]",
                Description = "[[Group description]]",
            };
            process.Groups.Add(processGroup);

            foreach (var question in _questions)
            {
                var processStep = new ProcessStep();
                processGroup.Steps.Add(processStep);

                var processProperty = new ProcessProperty()
                {
                    Key = Guid.NewGuid().ToString(),
                    Type = "MultipleChoice",
                    RequiredExpression = "true",
                    VisibilityExpression = "true",
                    Configuration = new Dictionary<string, object>()
                    {
                        { "title", question.Title },
                        { "options", question.Options },
                        { "answer", question.Answer },
                    }
                };
                processStep.Properties.Add(processProperty);
            }

            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var json = JsonConvert.SerializeObject(process, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });

            File.WriteAllText(sfd.FileName, json);
        }
    }
}