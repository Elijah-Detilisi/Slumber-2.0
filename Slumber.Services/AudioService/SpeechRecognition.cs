
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
        private Action<string> _controlAction;
        private Action<string> _commandAction;
        private CultureInfo _recognizerDialact;

        private readonly SpeechRecognitionEngine _controlRecognizer;
        private readonly SpeechRecognitionEngine _commandRecognizer;
        
        #endregion

        public SpeechRecognition()
        {
            _controlAction = Console.WriteLine;
            _commandAction = Console.WriteLine;
            
            _recognizerDialact = new CultureInfo("en-GB");
            _controlRecognizer = new SpeechRecognitionEngine(_recognizerDialact);
            _commandRecognizer = new SpeechRecognitionEngine(_recognizerDialact);
            
            initializeRecognizer();
        }

        #region Setter methods
        public void SetCommandAction(Action<string> action)
        {
            _commandAction = action; 
        }
        public void SetControlAction(Action<string> action)
        {
            _controlAction = action; 
        }
        #endregion

        #region Recognizer Launching
        public void StartDictating()
        {
            _commandRecognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        public string ControlListen()
        {
            var textResults = _controlRecognizer.Recognize();
            Debug.WriteLine("Recognized Control: " + textResults);
            return textResults.Text;
        }
        #endregion

        #region Recognizer Initialization
        private void LoadSystemVocabulary()
        {
            //Get commands
            var controlCommands = Vocabulary.GetCommands("System: Control");
            var powerCommands = Vocabulary.GetCommands("Power: Off").Concat(
                                Vocabulary.GetCommands("Power: Restart").Concat(
                                Vocabulary.GetCommands("Power: Lock")));

            //Get choices
            var controlChoices = new Choices(controlCommands);
            var powerChoices = new Choices(powerCommands.ToArray<string>());

            //Get grammar builder
            var commandGrammarBuilder = new GrammarBuilder();
            var controlGrammarBuilder = new GrammarBuilder();
            
            commandGrammarBuilder.Append(powerChoices);
            controlGrammarBuilder.Append(controlChoices);
            
            //Get grammer
            var controlGrammar = new Grammar(controlGrammarBuilder);
            var commandGrammar = new Grammar(commandGrammarBuilder);

            //Load Grammar
            _controlRecognizer.LoadGrammar(controlGrammar);
            _commandRecognizer.LoadGrammar(commandGrammar);

        }
        private void initializeRecognizer()
        {
            LoadSystemVocabulary();
            _commandRecognizer.SetInputToDefaultAudioDevice();
            _controlRecognizer.SetInputToDefaultAudioDevice();

            //Speech event Handlers
            _commandRecognizer.SpeechRecognized +=
                new EventHandler<SpeechRecognizedEventArgs>(SpeechRecognized);
        }
        #endregion

        #region Recognizer Event Handlers
        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            var textResult = e.Result.Text;
            _commandAction(textResult);

            Debug.WriteLine("Recognized recognizer: " + textResult);
        }
        #endregion

    }
}

#pragma warning restore CA1416 // Validate platform compatibility