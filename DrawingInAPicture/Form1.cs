using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace DrawingInAPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            //Get all the system colours. KnownColor gets all the colours.
            //We extract the system colours from the whole list of known colours 
            List<KnownColor> KnowColors = new List<KnownColor>();
            foreach (string color in Enum.GetNames(typeof(KnownColor)))
            {
                if (!Color.FromKnownColor((KnownColor)Enum.Parse(typeof(KnownColor), color)).IsSystemColor)
                {
                    cbobx_colours.Items.Add((KnownColor)Enum.Parse(typeof(KnownColor), color));
                }
            }

            //Set the index to the 11th item on the list
            cbobx_colours.SelectedIndex = 10;
        }


        private void btn_draw_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Graphics g = picbx_canvas.CreateGraphics();

            //We now choose to draw a line, you can draw many other things like square circle etc.
            //All the parameters come from the UI

            g.DrawLine(new Pen(Color.FromName(cbobx_colours.Text)),
                Int32.Parse(txtbx_tx.Text), Int32.Parse(txtbx_ty.Text),
                Int32.Parse(txtbx_bx.Text), Int32.Parse(txtbx_by.Text));

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            picbx_canvas.Image = null;
            picbx_canvas.Invalidate();
            picbx_canvas.Image = Properties.Resources.c42_sideview;
        }
    }
}
