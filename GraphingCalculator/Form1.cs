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
        // Someday this will be modifiable
        Pen _pen = new Pen(Color.Blue, 1f);

        int _height = 0;
        int _width = 0;

        Bitmap drawArea;

        ICoordinatePlane _coordinatePlane;

        public Form1()
        {
            InitializeComponent();
        }

        private void LabelQuadrants(Graphics graphic)
        {
            Color color = Color.FromArgb(255, 0, 0);

            FontFamily fontFamily = new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif);
            Brush brush = new SolidBrush(color);
            Font font = new Font(fontFamily, 10F);

            graphic.DrawString("I", font, brush, (pictureBoxCalculator.Width * (3/4)), (pictureBoxCalculator.Height/4));
        }

        private void RedrawPage(object sender, ElapsedEventArgs e)
        {
            DrawPage();
        }

        private void pictureBoxCalculator_SizeChanged(object sender, EventArgs e)
        {
            if (_height != pictureBoxCalculator.Size.Height || _width != pictureBoxCalculator.Size.Width)
            {
                _height = pictureBoxCalculator.Size.Height;
                _width = pictureBoxCalculator.Size.Width;

                DrawPage();
            }
        }

        private void DrawPage()
        {
            // set up our bitmap to match the picturebox in size
            this.drawArea = new Bitmap(pictureBoxCalculator.Size.Width, pictureBoxCalculator.Size.Height);

            Graphics graphic = Graphics.FromImage(this.drawArea);
            
            _coordinatePlane = new CartesianPlane(ref graphic,ref _pen, pictureBoxCalculator.Height, pictureBoxCalculator.Width);
            _coordinatePlane.TranslateOrigin((float)pictureBoxCalculator.Width / 2, (float)pictureBoxCalculator.Height / 2);
            _coordinatePlane.DrawAxes(5, 2, Color.Black);
            //LabelQuadrants(graphic);

            pictureBoxCalculator.Image = drawArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load axes
            DrawPage();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //pictureBoxCalculator.Refresh();
        }

        private void insertFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Function form = new Function())
            {
                DialogResult result = form.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    string function = form.GetText();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
