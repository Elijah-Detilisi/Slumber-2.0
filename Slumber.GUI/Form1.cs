
namespace Slumber.GUI
{
    using System.Linq;
    using Slumber.Services.AudioService;
    using Slumber.Services.SystemService;

    public partial class SlumberForm : Form
    {
        #region Instances
        private Action _operationAction;
        private TextToSpeech _textToSpeech;
        private SpeechRecognition _speechRecognition;
        #endregion

        public SlumberForm()
        {
            this._operationAction = Console.Beep;
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
                    this.cancelButton.Show();
                    this.confirmButton.Show();
                    this.shutButton.Enabled = false;
                    this.restartButton.Enabled = false;
                    this.lockButton.Enabled = false;
                }));
            }
            else
            {
                Invoke((MethodInvoker)(() =>
                {
                    this.cancelButton.Hide();
                    this.confirmButton.Hide();
                    this.shutButton.Enabled = true;
                    this.restartButton.Enabled = true;
                    this.lockButton.Enabled = true;
                }));   
            }
        }

        private void InitializeSlumberForm()
        {
            UpdateSystemState(isBusy: false);
            this._speechRecognition.SetCommandAction(this.ProccessCommands);
            this._speechRecognition.StartDictating();
        }
        #endregion  

        #region Event handlers
        //Power buttons
        private void shutButton_Click(object sender, EventArgs e)
        {
            this._operationAction = SysControl.ShutDown;
            this.ExecuteOperation("Report: Shut down");
            
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            this._operationAction = SysControl.Restart;
            this.ExecuteOperation("Report: Restart");
        }
        private void lockButton_Click(object sender, EventArgs e)
        {
            this._operationAction = SysControl.Lock;
            this.ExecuteOperation("Report: Lock");
        }
        //Control buttons
        private void confirmButton_Click(object sender, EventArgs e)
        {
            _ = this._textToSpeech.SpeakAsync(
                Vocabulary.GetPromptMessage("Report: Cancel")
            );

            UpdateSystemState(isBusy: false);
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            _ = this._textToSpeech.SpeakAsync(
                Vocabulary.GetPromptMessage("Report: Cancel")
            );

            UpdateSystemState(isBusy: false);
        }
        #endregion

        #region Support methods
        private void ExecuteOperation(string operation)
        {
            this.UpdateSystemState(isBusy: true);
            _ = this._textToSpeech.SpeakAsync(
                $"Are you sure you want to {operation.Split(":")[1]} the computer? Say Yes to proceed or No to cancel."
            );
            
            var verification = _speechRecognition.ControlListen();
            if(verification == "Proceed")
            {
                _ = this._textToSpeech.SpeakAsync(Vocabulary.GetPromptMessage(operation));
                _ = this._textToSpeech.SpeakAsync(Vocabulary.GetPromptMessage("Report: Farewell"));
                this._operationAction();
            }
            else
            {
                this.cancelButton.PerformClick();
            }
        }
        private void ProccessCommands(string userInput)
        {
            if (Vocabulary.GetCommands("Power: Off").Contains(userInput))
            {
                Console.Beep();
                this.shutButton.PerformClick();
            }
            else if (Vocabulary.GetCommands("Power: Restart").Contains(userInput))
            {
                Console.Beep();
                this.restartButton.PerformClick();
            }
            else if (Vocabulary.GetCommands("Power: Lock").Contains(userInput))
            {
                Console.Beep();
                this.lockButton.PerformClick();
            }
        }
        #endregion
    }
}