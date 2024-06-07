namespace WFA240607
{
    public partial class Form1 : Form
    {
        private Color oCol;
        private string oFrmText;
        private string oBtnText;

        public Form1()
        {
            InitializeComponent();

            oCol = this.BackColor;
            oFrmText = this.Text;
            oBtnText = btnGomb.Text;
        }

        private void btnGomb_Click(object sender, EventArgs e)
        {
            btnGomb.Text = btnGomb.Text.ToUpper();
        }

        private void btnGomb_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.ForestGreen;
        }

        private void btnGomb_MouseMove(object sender, MouseEventArgs e)
        {
            string text = $"x:={Cursor.Position.X}; y:={Cursor.Position.Y}";
            this.Text = text;
        }

        private void btnGomb_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = oCol;
            this.Text = oFrmText;
            btnGomb.Text = oBtnText;
        }
    }
}
