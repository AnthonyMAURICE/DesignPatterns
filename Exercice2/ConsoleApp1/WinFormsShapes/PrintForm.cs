using ClassLibraryCompoVisit;
using System.Drawing;
using Rectangle = ClassLibraryCompoVisit.Rectangle;
using Circle = ClassLibraryCompoVisit.Circle;
using System.Drawing.Drawing2D;


namespace WinFormsShapes
{
    public partial class PrintForm : Form
    {
        readonly AddForm addForm = new();
        //Shapes shapes = new(1, 1, 250, 250);
        Shape shape;
        Brush redBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        Pen pen = new Pen(System.Drawing.Color.Black);
        List<Shape> shapes = new List<Shape>();

        VisiteurWinForm visiteurWinForm = new();
        public PrintForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm.ShapeAdded += ShapesControl;
            addForm.ShowDialog();
        }

        private void ShapesControl(object sender, EventArgs e)
        {
            shape = (Shape)sender;
            shapes.Add(shape);
            this.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null) 
            {
                listBox1.Items.Add(shape.Name);
            }
            foreach (Shape shape in shapes)
            {
                if (shape.GetType() == typeof(Circle))
                {
                    e.Graphics.FillEllipse(redBrush, shape.Accept(visiteurWinForm));
                }
                if (shape.GetType() == typeof(Rectangle))
                {
                    e.Graphics.FillRectangle(redBrush, shape.Accept(visiteurWinForm));
                }
                if (shape.GetType() == typeof(Triangle))
                {
                    shape.Accept(visiteurWinForm);
                    FillMode newFillMode = FillMode.Winding;
                    e.Graphics.FillPolygon(redBrush, shape.Points, newFillMode);
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
