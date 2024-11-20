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
        Shapes shapes = new(1, 1, 250, 250);
        Brush redBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        Pen pen = new Pen(System.Drawing.Color.Black);
        readonly Rectangle rectangle = new(1, 1, 45, 40);
        readonly Circle circle = new(34, 51, 50, 50);


        VisiteurWinForm visiteurWinForm = new();
        public PrintForm()
        {
            shapes.Add(rectangle);
            shapes.Add(circle);
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm.ShapeAdded += ShapesControl;
            addForm.ShowDialog();
        }

        private void PrintForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes.ShapesList)
            {
                if (shape.GetType() == typeof(Circle))
                {
                    e.Graphics.FillEllipse(redBrush, shape.Accept(visiteurWinForm));
                }
                if (shape.GetType() == typeof(Rectangle))
                {
                    e.Graphics.FillRectangle(redBrush, shape.Accept(visiteurWinForm));
                }
                if(shape.GetType() == typeof(Triangle))
                {
                    shape.Accept(visiteurWinForm);
                    FillMode newFillMode = FillMode.Winding;
                    e.Graphics.FillPolygon(redBrush, shape.Points, newFillMode);
                }
            }
        }


        private void ShapesControl(object sender, EventArgs e)
        {
            Shape circle = (Shape) sender;
            shapes.Add(circle);
            this.Refresh();
        }
    }
}
