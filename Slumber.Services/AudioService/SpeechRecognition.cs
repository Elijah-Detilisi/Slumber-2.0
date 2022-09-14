
#pragma warning disable CA1416 // Validate platform compatibility

namespace Slumber.Services.AudioService
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Speech.Recognition;

    public class SpeechRecognition
    {
        #region Instances
        private string _textResult;
        private Action<string> _customAction;
        private CultureInfo _recognizerDialact;
        private readonly SpeechRecognitionEngine _recognizer;
        
        #endregion

        public SpeechRecognition()
        {
            _textResult = "";
            _customAction = Console.WriteLine;
            _recognizerDialact = new CultureInfo("en-GB");
            _recognizer = new SpeechRecognitionEngine(_recognizerDialact);

            initializeRecognizer();
        }

        #region Setter methods
        public void SetCustomAction(Action<string> action)
        {
            _customAction = action; 
        }
        #endregion

        #region Recognizer Launching
        public void StartDictating()
        {
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }
        #endregion

        #region Recognizer Results
        public string GetRecognizedText()
        {
            var result = _textResult;
            _textResult = "";

            return result;
        }
        #endregion

        #region Recognizer Initialization
        private void LoadSystemVocabulary()
        {
            //Get commands
            var numberCommands = Vocabulary.GetCommands("Power: Numbers");
            var powerCommands = Vocabulary.GetCommands("Power: Off").Concat(
                                Vocabulary.GetCommands("Power: Restart").Concat(
                                Vocabulary.GetCommands("Power: Lock")));

            //Get choices
            var powerChoices = new Choices(powerCommands.ToArray<string>());
            var minutesChoices = new Choices(new string[] { "minute", "minutes" });
            var secondsChoices = new Choices(new string[] { "second", "seconds" });
            var numberChoices = new Choices(numberCommands);
            
            //Get grammar builder
            var commandGrammarBuilder = new GrammarBuilder();
            commandGrammarBuilder.Append(powerChoices);
            commandGrammarBuilder.Append("in");
            commandGrammarBuilder.Append(numberChoices);
            commandGrammarBuilder.Append(minutesChoices);
            commandGrammarBuilder.Append("and");
            commandGrammarBuilder.Append(numberChoices);
            commandGrammarBuilder.Append(secondsChoices);


            //Get grammer
            var recognizerGrammar = new Grammar(commandGrammarBuilder);

            //Load Grammar
            _recognizer.LoadGrammar(recognizerGrammar);

        }
        private void initializeRecognizer()
        {
            LoadSystemVocabulary();
            _recognizer.SetInputToDefaultAudioDevice();

            //Speech event Handlers
            _recognizer.SpeechRecognized +=
                new EventHandler<SpeechRecognizedEventArgs>(SpeechRecognized);
        }
        #endregion

        #region Recognizer Event Handlers
        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            _textResult = e.Result.Text;
            _customAction(_textResult);
            Debug.WriteLine("Recognized dictation: " + _textResult);
        }
        #endregion
    }
}

#pragma warning restore CA1416 // Validate platform compatibility