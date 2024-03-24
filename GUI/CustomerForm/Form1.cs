namespace GUI
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.FontFamily, 18, FontStyle.Bold);
            button3.Font = new Font(button3.Font.FontFamily, 9, FontStyle.Regular);
            button4.Font = new Font(button4.Font.FontFamily, 9, FontStyle.Regular);
            button5.Font = new Font(button5.Font.FontFamily, 9, FontStyle.Regular);
            button6.Font = new Font(button6.Font.FontFamily, 9, FontStyle.Regular);
            button7.Font = new Font(button7.Font.FontFamily, 9, FontStyle.Regular);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.FontFamily, 9, FontStyle.Regular);
            button3.Font = new Font(button3.Font.FontFamily, 9, FontStyle.Regular);
            button4.Font = new Font(button4.Font.FontFamily, 9, FontStyle.Regular);
            button5.Font = new Font(button5.Font.FontFamily, 9, FontStyle.Regular);
            button6.Font = new Font(button6.Font.FontFamily, 9, FontStyle.Regular);
            button7.Font = new Font(button7.Font.FontFamily, 18, FontStyle.Bold);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.FontFamily, 9, FontStyle.Regular);
            button3.Font = new Font(button3.Font.FontFamily, 18, FontStyle.Bold);
            button4.Font = new Font(button4.Font.FontFamily, 9, FontStyle.Regular);
            button5.Font = new Font(button5.Font.FontFamily, 9, FontStyle.Regular);
            button6.Font = new Font(button6.Font.FontFamily, 9, FontStyle.Regular);
            button7.Font = new Font(button7.Font.FontFamily, 9, FontStyle.Regular);
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.FontFamily, 9, FontStyle.Regular);
            button3.Font = new Font(button3.Font.FontFamily, 9, FontStyle.Regular);
            button4.Font = new Font(button4.Font.FontFamily, 18, FontStyle.Bold);
            button5.Font = new Font(button5.Font.FontFamily, 9, FontStyle.Regular);
            button6.Font = new Font(button6.Font.FontFamily, 9, FontStyle.Regular);
            button7.Font = new Font(button7.Font.FontFamily, 9, FontStyle.Regular);
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.FontFamily, 9, FontStyle.Regular);
            button3.Font = new Font(button3.Font.FontFamily, 9, FontStyle.Regular);
            button4.Font = new Font(button4.Font.FontFamily, 9, FontStyle.Regular);
            button5.Font = new Font(button5.Font.FontFamily, 18, FontStyle.Bold);
            button6.Font = new Font(button6.Font.FontFamily, 9, FontStyle.Regular);
            button7.Font = new Font(button7.Font.FontFamily, 9, FontStyle.Regular);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.FontFamily, 9, FontStyle.Regular);
            button3.Font = new Font(button3.Font.FontFamily, 9, FontStyle.Regular);
            button4.Font = new Font(button4.Font.FontFamily, 9, FontStyle.Regular);
            button5.Font = new Font(button5.Font.FontFamily, 9, FontStyle.Regular);
            button6.Font = new Font(button6.Font.FontFamily, 18, FontStyle.Bold);
            button7.Font = new Font(button7.Font.FontFamily, 9, FontStyle.Regular);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.FontFamily, 9, FontStyle.Regular);
            button3.Font = new Font(button3.Font.FontFamily, 9, FontStyle.Regular);
            button4.Font = new Font(button4.Font.FontFamily, 9, FontStyle.Regular);
            button5.Font = new Font(button5.Font.FontFamily, 9, FontStyle.Regular);
            button6.Font = new Font(button6.Font.FontFamily, 9, FontStyle.Regular);
            button7.Font = new Font(button7.Font.FontFamily, 9, FontStyle.Regular);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }
    }
}
