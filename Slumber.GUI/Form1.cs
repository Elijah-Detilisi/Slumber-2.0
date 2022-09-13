using System.Diagnostics;

namespace Slumber.GUI
{
    public partial class SlumberForm : Form
    {
        #region Instances
        private int seconds;
        private Action _action;
        #endregion

        public SlumberForm()
        {
            this.seconds = 0;
            this._action = Console.Beep;
            InitializeComponent();
        }

        #region Event handlers
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.timerWidget.Stop();
        }
        private void shutButton_Click(object sender, EventArgs e)
        {
            this._action = () => {

            };
            StartCountDown();
        }
        private void lockButton_Click(object sender, EventArgs e)
        {
            this._action = () => {

            };
            StartCountDown();
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            this._action = () => {

            };
            StartCountDown();
        }
        
        #endregion

        #region Support methods
        private void timerWidget_Tick(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                this.progressBar.Text = this.seconds.ToString();
                this.seconds--;

                if (this.seconds == 0)
                {
                    this.timerWidget.Stop();
                }

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