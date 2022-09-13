namespace Slumber.GUI
{
    public partial class SlumberForm : Form
    {
        public SlumberForm()
        {
            InitializeComponent();
        }

        #region Event handlers
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}