
namespace Slumber.GUI
{
    using Slumber.Services.AudioService;
    using Slumber.Services.SystemService;

    public partial class SlumberForm : Form
    {
        #region Instances
        private int seconds;
        private Action _action;
        private TextToSpeech _textToSpeech;
        #endregion

        public SlumberForm()
        {
            this.seconds = 0;
            this._action = Console.Beep;
            this._textToSpeech = new TextToSpeech();
            InitializeComponent();
        }

        #region Event handlers
        private void exitButton_Click(object sender, EventArgs e)
        {
            this._textToSpeech.SpeakAsync(Vocabulary.GetPromptMessage("Report: Cancel"));
            this.timerWidget.Stop();
        }
        private void shutButton_Click(object sender, EventArgs e)
        {
            this._textToSpeech.SpeakAsync(Vocabulary.GetPromptMessage("Report: Shut down"));
            this._action = SysControl.ShutDown;
            StartCountDown();
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            this._textToSpeech.SpeakAsync(Vocabulary.GetPromptMessage("Report: Restart"));
            this._action = SysControl.Restart;
            StartCountDown();
        }
        private void lockButton_Click(object sender, EventArgs e)
        {
            this._textToSpeech.SpeakAsync(Vocabulary.GetPromptMessage("Report: Lock"));
            this._action = SysControl.Lock;
            StartCountDown();
        }
        #endregion

        #region Support methods
        private void timerWidget_Tick(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                this.progressBar.Text = this.seconds.ToString();
                if (this.seconds == 0)
                {
                    this.timerWidget.Stop();
                    this._action();
                }
                this.seconds--;

            }));
        }
        private void StartCountDown()
        {
            this.seconds = Int32.Parse(this.textBox.Text);
            this.textBox.Hide();
            this.progressBar.Show();
            this.timerWidget.Start();
        }
        #endregion


    }
}