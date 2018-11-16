using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace GraphingCalculator
{
    public partial class Form1 : Form
    {
        Graphics _graphic;
        System.Timers.Timer _timer;
        Pen _pen = new Pen(Color.Blue, 1f);

        ICoordinatePlane _coordinatePlane;

        public Form1()
        {
            InitializeComponent();
        }

        private void LabelQuadrants()
        {
            Color color = Color.FromArgb(255, 0, 0);

            FontFamily fontFamily = new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif);
            Brush brush = new SolidBrush(color);
            Font font = new Font(fontFamily, 2F);

            _graphic.DrawString("I", font, brush, (pictureBoxCalculator.Width * (1/2)), (pictureBoxCalculator.Height/4));
        }

        private void RedrawPage(object sender, ElapsedEventArgs e)
        {
            DrawPage();

            _timer.Enabled = false;
        }

        private void pictureBoxCalculator_SizeChanged(object sender, EventArgs e)
        {
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += new ElapsedEventHandler(RedrawPage);
            _timer.Enabled = true;
        }

        private void DrawPage()
        {
            _graphic = pictureBoxCalculator.CreateGraphics();

            _coordinatePlane = new CartesianPlane(ref _graphic, ref _pen, pictureBoxCalculator.Height, pictureBoxCalculator.Width);
            _coordinatePlane.TranslateOrigin((float)pictureBoxCalculator.Width / 2, (float)pictureBoxCalculator.Height / 2);
            _coordinatePlane.DrawAxes(5, 2, Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load axes
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += new ElapsedEventHandler(RedrawPage);
            _timer.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBoxCalculator.Refresh();
        }

        private void insertFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Function form = new Function())
            {
                form.ShowDialog();
            }
        }
    }
}
