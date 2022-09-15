
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
        private Action<string> _timerAction;
        private Action<string> _commandAction;
        private CultureInfo _recognizerDialact;

        private readonly SpeechRecognitionEngine _timerRecognizer;
        private readonly SpeechRecognitionEngine _commandRecognizer;
        
        #endregion

        public SpeechRecognition()
        {
            _timerAction = Console.WriteLine;
            _commandAction = Console.WriteLine;
            
            _recognizerDialact = new CultureInfo("en-GB");
            _timerRecognizer = new SpeechRecognitionEngine(_recognizerDialact);
            _commandRecognizer = new SpeechRecognitionEngine(_recognizerDialact);
            
            initializeRecognizer();
        }

        #region Setter methods
        public void SetCommandAction(Action<string> action)
        {
            _commandAction = action; 
        }
        public void SetTimerAction(Action<string> action)
        {
            _timerAction = action; 
        }
        #endregion

        #region Recognizer Launching
        public void StartDictating()
        {
            _commandRecognizer.RecognizeAsync(RecognizeMode.Multiple);
            _timerRecognizer.RecognizeAsync(RecognizeMode.Multiple);
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
            var numberChoices = new Choices(numberCommands);
            var powerChoices = new Choices(powerCommands.ToArray<string>());
            var minutesChoices = new Choices(new string[] { "minute", "minutes" });
            var secondsChoices = new Choices(new string[] { "second", "seconds" });


            //Get grammar builder
            var commandGrammarBuilder = new GrammarBuilder();
            var timerGrammarBuilder = new GrammarBuilder();
            
            commandGrammarBuilder.Append(powerChoices);
            timerGrammarBuilder.Append("Set timer");
            timerGrammarBuilder.Append(numberChoices);
            timerGrammarBuilder.Append(minutesChoices);
            timerGrammarBuilder.Append("and");
            timerGrammarBuilder.Append(numberChoices);
            timerGrammarBuilder.Append(secondsChoices);

            //Get grammer
            var timerGrammar = new Grammar(timerGrammarBuilder);
            var recognizerGrammar = new Grammar(commandGrammarBuilder);
            
            //Load Grammar
            _commandRecognizer.LoadGrammar(recognizerGrammar);
            _timerRecognizer.LoadGrammar(timerGrammar);

        }
        private void initializeRecognizer()
        {
            LoadSystemVocabulary();
            _commandRecognizer.SetInputToDefaultAudioDevice();
            _timerRecognizer.SetInputToDefaultAudioDevice();

            //Speech event Handlers
            _commandRecognizer.SpeechRecognized +=
                new EventHandler<SpeechRecognizedEventArgs>(SpeechRecognized);
            _timerRecognizer.SpeechRecognized +=
                new EventHandler<SpeechRecognizedEventArgs>(TimerSpeechRecognized);
        }
        #endregion

        #region Recognizer Event Handlers
        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            var textResult = e.Result.Text;
            _commandAction(textResult);

            Debug.WriteLine("Recognized recognizer: " + textResult);
        }
        private void TimerSpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            var textResult = e.Result.Text;
            _timerAction(textResult);

            Debug.WriteLine("Recognized Timer: " + textResult);
        }
        #endregion
    }
}

#pragma warning restore CA1416 // Validate platform compatibility