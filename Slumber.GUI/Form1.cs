
namespace Slumber.GUI
{
    using System.Linq;
    using Slumber.Services.AudioService;
    using Slumber.Services.SystemService;
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

            InitializeComponent();
            Shown += SlumberForm_Shown;
        }
        private void SlumberForm_Shown(object? sender, EventArgs e)
        {
            this.InitializeSlumberForm();
        }

        #region Class methods
        private void UpdateSystemState(bool isBusy)
        {
            if (isBusy)
            {
                Invoke((MethodInvoker)(() =>
                {
                    this.exitButton.Enabled = true;
                    this.shutButton.Enabled = false;
                    this.restartButton.Enabled = false;
                    this.lockButton.Enabled = false;

                    this.label1.Hide();
                    this.label2.Hide();
                    this.minutesTextBox.Hide();
                    this.secondsTextBox.Hide();
                    this.progressBar.Show();
                }));
            }
            else
            {
                Invoke((MethodInvoker)(() =>
                {
                    this.exitButton.Enabled = false;
                    this.shutButton.Enabled = true;
                    this.restartButton.Enabled = true;
                    this.lockButton.Enabled = true;

                    this.progressBar.Hide();
                    this.label1.Show();
                    this.label2.Show();
                    this.minutesTextBox.Show();
                    this.secondsTextBox.Show();
                }));   
            }
        }

        private void InitializeSlumberForm()
        {
            UpdateSystemState(isBusy: false);
            this._speechRecognition.SetTimerAction(this.ProccessTimer);
            this._speechRecognition.SetCommandAction(this.ProccessCommands);
            this._speechRecognition.StartDictating();
        }
        #endregion  

        #region Event handlers
        private void shutButton_Click(object sender, EventArgs e)
        {
            this._action = SysControl.ShutDown;
            this.ExecuteOperation("Report: Shut down");
            
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            this._action = SysControl.Restart;
            this.ExecuteOperation("Report: Restart");
        }
        private void lockButton_Click(object sender, EventArgs e)
        {
            this._action = SysControl.Lock;
            this.ExecuteOperation("Report: Lock");
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.timerWidget.Stop();
            _ = this._textToSpeech.SpeakAsync(
                Vocabulary.GetPromptMessage("Report: Cancel")
            );
            
            UpdateSystemState(isBusy: false);
        }
        private void timerWidget_Tick(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                this.progressBar.Text = this.seconds.ToString();
                if (this.seconds == 0)
                {
                    _ = this._textToSpeech.SpeakAsync(Vocabulary.GetPromptMessage("Report: Farewell"));
                    this.timerWidget.Stop();
                    this._action();
                }
                this.seconds--;

            }));
        }
        #endregion

        #region Support methods
        private void ExecuteOperation(string operation)
        {
            UpdateSystemState(isBusy: true);
            this.seconds = Int32.Parse(this.minutesTextBox.Text) * 60 + Int32.Parse(this.secondsTextBox.Text);

            // Notify User
            this._textToSpeech.Speak(
                Vocabulary.GetPromptMessage(operation) + $" in {this.seconds} seconds"
            );
            
            // Start timer
            this.timerWidget.Start();
        }
        private void ProccessCommands(string userInput)
        {
            var splitUserInput = userInput.Split(" ");
            var powerOffCommand = splitUserInput[0] + " " + splitUserInput[1];

            if (Vocabulary.GetCommands("Power: Off").Contains(powerOffCommand))
            {
                Console.Beep();
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
        private void ProccessTimer(string userInput)
        {
            var splitUserInput = userInput.Split(" ");

            this.minutesTextBox.Text = splitUserInput[2];
            this.secondsTextBox.Text = splitUserInput[5];
        }

        #endregion

    }
}