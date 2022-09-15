
namespace Slumber.GUI
{
    using Slumber.Services.AudioService;
    using Slumber.Services.SystemService;
    using System.Diagnostics;
    using System.Linq;
    using static System.Net.Mime.MediaTypeNames;

    public partial class SlumberForm : Form
    {
        #region Instances
        private int seconds;
        private Action _action;
        private TextToSpeech _textToSpeech;
        private SpeechRecognition _speechRecognition;
        #endregion

        public SlumberForm()
        {
            this.seconds = 0;
            this._action = Console.Beep;
            this._textToSpeech = new TextToSpeech();
            this._speechRecognition = new SpeechRecognition();

            //this._speechRecognition.SetCustomAction(this.ProccessUserInput);
            this._speechRecognition.StartDictating();
            InitializeComponent();
        }

        #region Event handlers
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.progressBar.Hide();
            this.label1.Show();
            this.label2.Show();
            this.minutesTextBox.Show();
            this.secondsTextBox.Show();
            
            _ = this._textToSpeech.SpeakAsync(
                Vocabulary.GetPromptMessage("Report: Cancel")
            );
            this.timerWidget.Stop();
        }
        private void shutButton_Click(object sender, EventArgs e)
        {
            _ = this._textToSpeech.SpeakAsync(
                Vocabulary.GetPromptMessage("Report: Shut down")
            );
            this._action = SysControl.ShutDown;
            StartCountDown();
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            _ = this._textToSpeech.SpeakAsync(
                Vocabulary.GetPromptMessage("Report: Restart")
            );
            this._action = SysControl.Restart;
            StartCountDown();
        }
        private void lockButton_Click(object sender, EventArgs e)
        {
            _ = this._textToSpeech.SpeakAsync(
                Vocabulary.GetPromptMessage("Report: Lock")
            );
            this._action = SysControl.Lock;
            StartCountDown();
        }

        private void timerWidget_Tick(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                this.progressBar.Text = this.seconds.ToString();
                if (this.seconds == 0)
                {
                    _ = this._textToSpeech.SpeakAsync(
                            Vocabulary.GetPromptMessage("Report: Farewell")
                    );
                    this.timerWidget.Stop();
                    this._action();
                    this.Close();
                }
                this.seconds--;

            }));
        }
        #endregion

        #region Support methods

        private void StartCountDown()
        {
            this.seconds = Int32.Parse(this.minutesTextBox.Text)*60 + Int32.Parse(this.secondsTextBox.Text);
            _ = this._textToSpeech.SpeakAsync($"In {this.seconds} seconds");

            this.label1.Hide();
            this.label2.Hide();
            this.minutesTextBox.Hide();
            this.secondsTextBox.Hide();

            this.progressBar.Show();
            this.timerWidget.Start();
        }

        private void ProccessUserInput(string userInput)
        {
            var splitUserInput = userInput.Split(" ");
            var powerOffCommand = splitUserInput[0] + " " + splitUserInput[1];

            if (Vocabulary.GetCommands("Power: Off").Contains(powerOffCommand))
            {
                Console.Beep();
                userInput = userInput.Replace(powerOffCommand, "");
                Debug.WriteLine(userInput);
                this.minutesTextBox.Text = splitUserInput[3];
                this.secondsTextBox.Text = splitUserInput[6];

                this.shutButton.PerformClick();
            }
            else if (Vocabulary.GetCommands("Power: Restart").Contains(splitUserInput[0]))
            {
                Console.Beep();
                this.restartButton.PerformClick();
            }
            else if (Vocabulary.GetCommands("Power: Lock").Contains(splitUserInput[0]))
            {
                Console.Beep();
                this.lockButton.PerformClick();
            }

        }

        #endregion
    }
}