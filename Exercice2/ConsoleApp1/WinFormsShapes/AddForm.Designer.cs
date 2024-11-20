namespace WinFormsShapes
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonAddCircle = new Button();
            textBoxRadius = new TextBox();
            label3 = new Label();
            textBoxCircOrdo = new TextBox();
            label2 = new Label();
            textBoxCircleAbsc = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            textBoxRectHeight = new TextBox();
            textBoxRectWidth = new TextBox();
            label7 = new Label();
            label6 = new Label();
            buttonAddRect = new Button();
            textBoxRectOrd = new TextBox();
            label4 = new Label();
            textBoxRectAbs = new TextBox();
            label5 = new Label();
            tabPage3 = new TabPage();
            textTriHeight = new TextBox();
            textTriWidth = new TextBox();
            label12 = new Label();
            label13 = new Label();
            textTriOrd = new TextBox();
            label10 = new Label();
            textTriAbs = new TextBox();
            label11 = new Label();
            buttonAddTriangle = new Button();
            button2 = new Button();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(28, 73);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(277, 197);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonAddCircle);
            tabPage1.Controls.Add(textBoxRadius);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBoxCircOrdo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBoxCircleAbsc);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(269, 169);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cercle";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAddCircle
            // 
            buttonAddCircle.Location = new Point(90, 125);
            buttonAddCircle.Name = "buttonAddCircle";
            buttonAddCircle.Size = new Size(75, 23);
            buttonAddCircle.TabIndex = 6;
            buttonAddCircle.Text = "Ajouter";
            buttonAddCircle.UseVisualStyleBackColor = true;
            buttonAddCircle.Click += buttonAddCircle_Click;
            // 
            // textBoxRadius
            // 
            textBoxRadius.Location = new Point(125, 71);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(40, 23);
            textBoxRadius.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 74);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Rayon";
            // 
            // textBoxCircOrdo
            // 
            textBoxCircOrdo.Location = new Point(225, 17);
            textBoxCircOrdo.Name = "textBoxCircOrdo";
            textBoxCircOrdo.Size = new Size(36, 23);
            textBoxCircOrdo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Ordonnées";
            // 
            // textBoxCircleAbsc
            // 
            textBoxCircleAbsc.Location = new Point(77, 17);
            textBoxCircleAbsc.Name = "textBoxCircleAbsc";
            textBoxCircleAbsc.Size = new Size(37, 23);
            textBoxCircleAbsc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Abscisse";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxRectHeight);
            tabPage2.Controls.Add(textBoxRectWidth);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(buttonAddRect);
            tabPage2.Controls.Add(textBoxRectOrd);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBoxRectAbs);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(269, 169);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rectangle";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxRectHeight
            // 
            textBoxRectHeight.Location = new Point(227, 76);
            textBoxRectHeight.Name = "textBoxRectHeight";
            textBoxRectHeight.Size = new Size(36, 23);
            textBoxRectHeight.TabIndex = 12;
            // 
            // textBoxRectWidth
            // 
            textBoxRectWidth.Location = new Point(81, 76);
            textBoxRectWidth.Name = "textBoxRectWidth";
            textBoxRectWidth.Size = new Size(37, 23);
            textBoxRectWidth.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(137, 79);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 10;
            label7.Text = "Hauteur";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 79);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 9;
            label6.Text = "Longueur";
            // 
            // buttonAddRect
            // 
            buttonAddRect.Location = new Point(90, 140);
            buttonAddRect.Name = "buttonAddRect";
            buttonAddRect.Size = new Size(75, 23);
            buttonAddRect.TabIndex = 8;
            buttonAddRect.Text = "Ajouter";
            buttonAddRect.UseVisualStyleBackColor = true;
            buttonAddRect.Click += buttonAddRect_Click;
            // 
            // textBoxRectOrd
            // 
            textBoxRectOrd.Location = new Point(227, 17);
            textBoxRectOrd.Name = "textBoxRectOrd";
            textBoxRectOrd.Size = new Size(36, 23);
            textBoxRectOrd.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 20);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Ordonnées";
            // 
            // textBoxRectAbs
            // 
            textBoxRectAbs.Location = new Point(81, 17);
            textBoxRectAbs.Name = "textBoxRectAbs";
            textBoxRectAbs.Size = new Size(37, 23);
            textBoxRectAbs.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 20);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Abscisse";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textTriHeight);
            tabPage3.Controls.Add(textTriWidth);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(textTriOrd);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(textTriAbs);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(buttonAddTriangle);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(269, 169);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Triangle";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textTriHeight
            // 
            textTriHeight.Location = new Point(226, 73);
            textTriHeight.Name = "textTriHeight";
            textTriHeight.Size = new Size(36, 23);
            textTriHeight.TabIndex = 16;
            // 
            // textTriWidth
            // 
            textTriWidth.Location = new Point(80, 73);
            textTriWidth.Name = "textTriWidth";
            textTriWidth.Size = new Size(37, 23);
            textTriWidth.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(136, 76);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 14;
            label12.Text = "Hauteur";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 76);
            label13.Name = "label13";
            label13.Size = new Size(58, 15);
            label13.TabIndex = 13;
            label13.Text = "Longueur";
            // 
            // textTriOrd
            // 
            textTriOrd.Location = new Point(222, 7);
            textTriOrd.Name = "textTriOrd";
            textTriOrd.Size = new Size(36, 23);
            textTriOrd.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(132, 10);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 10;
            label10.Text = "Ordonnées";
            // 
            // textTriAbs
            // 
            textTriAbs.Location = new Point(76, 7);
            textTriAbs.Name = "textTriAbs";
            textTriAbs.Size = new Size(37, 23);
            textTriAbs.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 10);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 8;
            label11.Text = "Abscisse";
            // 
            // buttonAddTriangle
            // 
            buttonAddTriangle.Location = new Point(90, 143);
            buttonAddTriangle.Name = "buttonAddTriangle";
            buttonAddTriangle.Size = new Size(75, 23);
            buttonAddTriangle.TabIndex = 5;
            buttonAddTriangle.Text = "Ajouter";
            buttonAddTriangle.UseVisualStyleBackColor = true;
            buttonAddTriangle.Click += buttonAddTriangle_Click;
            // 
            // button2
            // 
            button2.Location = new Point(122, 294);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Retour";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.Location = new Point(64, 9);
            label8.Name = "label8";
            label8.Size = new Size(210, 30);
            label8.TabIndex = 2;
            label8.Text = "Ajouter des figures";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 329);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Name = "AddForm";
            Text = "Ajouter Formes";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxCircOrdo;
        private Label label2;
        private TextBox textBoxCircleAbsc;
        private Label label1;
        private TabPage tabPage3;
        private Button buttonAddCircle;
        private TextBox textBoxRadius;
        private Label label3;
        private TextBox textBoxRectOrd;
        private Label label4;
        private TextBox textBoxRectAbs;
        private Label label5;
        private Button button2;
        private TextBox textBoxRectHeight;
        private TextBox textBoxRectWidth;
        private Label label7;
        private Label label6;
        private Button buttonAddRect;
        private Label label8;
        private Button buttonAddTriangle;
        private TextBox textTriOrd;
        private Label label10;
        private TextBox textTriAbs;
        private Label label11;
        private TextBox textTriHeight;
        private TextBox textTriWidth;
        private Label label12;
        private Label label13;
    }
}