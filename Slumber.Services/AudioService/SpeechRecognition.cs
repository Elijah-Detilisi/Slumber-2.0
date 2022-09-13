using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CA1416 // Validate platform compatibility

namespace Slumber.Services.AudioService
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Speech.Recognition;

    public class SpeechRecognition
    {
        #region Instances
        private string _dicatationTextResult;
        private CultureInfo _recognizerDialact;
        private readonly SpeechRecognitionEngine _dictationSpeechRecognizer;

        #endregion

        public SpeechRecognition()
        {
            _dicatationTextResult = "";
            _recognizerDialact = new CultureInfo("en-GB");
            _dictationSpeechRecognizer = new SpeechRecognitionEngine(_recognizerDialact);

            initializeRecognizer();
        }

        #region Recognizer Launching
        public void StartDictating()
        {
            _dictationSpeechRecognizer.RecognizeAsync(RecognizeMode.Multiple);
        }
        #endregion

        #region Recognizer Results
        public string GetAsyncDictation()
        {
            var result = _dicatationTextResult;
            _dicatationTextResult = "";

            return result;
        }
        public string GetActiveDictation()
        {
            var result = _dictationSpeechRecognizer.Recognize().Text;

            return (result != null) ? result : "";
        }
        #endregion

        #region Recognizer Initialization
        private void LoadSystemVocabulary()
        {
            //Get commands
            var dictationVocabulary = Vocabulary.GetCommands("Power: Off").Concat(
                                      Vocabulary.GetCommands("Power: Restart").Concat(
                                      Vocabulary.GetCommands("Power: Lock")));

            var dictationChoices = new Choices(dictationVocabulary.ToArray<string>());

            //Prepare recognizer grammar
            var dicatationGrammar = new Grammar(new GrammarBuilder(dictationChoices));

            //Load Grammar
            _dictationSpeechRecognizer.LoadGrammar(dicatationGrammar);

        }
        private void initializeRecognizer()
        {
            LoadSystemVocabulary();
            _dictationSpeechRecognizer.SetInputToDefaultAudioDevice();

            //Speech event Handlers
            _dictationSpeechRecognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_dictationSpeechRecognizer_SpeechRecognized);
        }
        #endregion

        #region Recognizer Event Handlers
        private void _dictationSpeechRecognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            _dicatationTextResult = e.Result.Text;
            Debug.WriteLine("Recognized dictation: " + _dicatationTextResult);
        }
        #endregion
    }
}

#pragma warning restore CA1416 // Validate platform compatibility