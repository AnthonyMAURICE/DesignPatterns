using ClassLibraryCompoVisit;
using System.Drawing;

namespace WinFormsShapes
{
    public partial class PrintForm : Form
    {
        readonly AddForm addForm = new();
        Shapes shapes = new(1, 1);
        public PrintForm()
        {
            InitializeComponent();
            ClassLibraryCompoVisit.Rectangle rectangle = new(5, 8, new Point(15, 10), new Point(20, 25));
            shapes.Add(rectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm.Show();
        }

        private void PrintForm_Paint(object sender, PaintEventArgs e)
        {
            
            
        }
    }
}
