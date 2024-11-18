namespace WinFormsShapes
{
    public partial class PrintForm : Form
    {
        readonly AddForm addForm = new();
        public PrintForm()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            addForm.Show();
        }
    }
}
