using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int buttonRadius = 12; // raggio
        private float buttonSmoothingMode = 3f; //(1f = Anti-Alias, 2f = Anti-Alias High Quality)
        Color verdeacqua = Color.FromArgb(67, 118, 108);
        Color marroncino = Color.FromArgb(118, 69, 59);
        Color beg = Color.FromArgb(177, 148, 112);
        Color nero = Color.FromArgb(255,255,255);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            

            button2.Click += new EventHandler(clickbtn2);
            button3.Click += new EventHandler(clickbtn3);
            button4.Click += new EventHandler(clickbtn4);
            
            
            button4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, button4.Width, button4.Height, buttonRadius, buttonRadius));
            button2.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, button2.Width, button2.Height, buttonRadius, buttonRadius));
            button3.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, button3.Width, button3.Height, buttonRadius, buttonRadius));


            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, panel1.Width, panel1.Height, 15, 15));
            panel1.BackColor = verdeacqua;
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, panel2.Width, panel2.Height, 15, 15));
            panel2.BackColor = verdeacqua;
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, panel3.Width, panel3.Height, 15, 15));
            panel3.BackColor = verdeacqua;

            
            textBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 1, textBox1.Width, textBox1.Height, 15, 15));
            //textBox1.BackColor = beg;
            textBox2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 1, textBox2.Width, textBox2.Height, 15, 15));
            //textBox2.BackColor = beg;
            textBox3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 1, textBox3.Width, textBox3.Height, 15, 15));
            //textBox3.BackColor = beg;


            label1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, label1.Width, label1.Height, buttonRadius, buttonRadius));



        }

        private void clickbtn4(object sender, EventArgs e)
        {
            String s = label1.Text + "\n" + textBox3.Text;
            label1.Text = s;
            textBox3.Text = "";
        }

        private void clickbtn3(object sender, EventArgs e)
        {
            String s = label1.Text + "\n" + textBox2.Text;
            label1.Text = s;
            textBox2.Text = "";
        }

        private void clickbtn2(object sender, EventArgs e)
        {

            String s = label1.Text + "\n" + textBox1.Text;
            label1.Text = s;
            textBox1.Text = "";
        }

        private void b1_Click(object sender, EventArgs e, TextBox tb)
        {
            String s = tb.Text;
            setClear(tb);
            MessageBox.Show(s);
        }

        private void setClear(TextBox tb)
        {
            tb.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

       

        private void Button_SizeChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, button.Width, button.Height, buttonRadius, buttonRadius));
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}