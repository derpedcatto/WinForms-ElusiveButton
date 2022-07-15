namespace ElusiveButton
{
    public partial class MainForm : Form
    {
        #region Global Variables

        Random RAND = new();
        int ELUSIVEBUTTON_COUNTER = 0;

        #endregion

        #region MainForm

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Elusive Button

        private void ElusiveButton_MouseEnter(object sender, EventArgs e)
        {
            ElusiveButton_ChangePos();
            ElusiveButton_ChangeColor();
            SetRandomBackgroundColor();

            ELUSIVEBUTTON_COUNTER++;
            SetMainFormText("Elusive Button Wins = " + ELUSIVEBUTTON_COUNTER.ToString());
        }

        private void ElusiveButton_ChangePos()
        {
            ElusiveButton.Left = RAND.Next(this.Width - ElusiveButton.Width * 2);
            ElusiveButton.Top = RAND.Next(this.Height - ElusiveButton.Height * 2);
        }

        private void ElusiveButton_ChangeColor()
        {
            ElusiveButton.BackColor = RandomColor();
            ElusiveButton.ForeColor = RandomColor();
        }

        #endregion

        #region Private Service Methods

        private Color RandomColor()
        {
            return Color.FromArgb(RAND.Next(256), RAND.Next(256), RAND.Next(256));
        }

        private void SetRandomBackgroundColor()
        {
            MainForm.ActiveForm.BackColor = RandomColor();
        }

        private void SetMainFormText(string text)
        {
            this.Text = text;
        }

        #endregion
    }
}