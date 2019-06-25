using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphingCalculator
{
    public partial class Function : Form
    {
        public Function()
        {
            InitializeComponent();
        }

        private void Function_Load(object sender, EventArgs e)
        {
            comboBoxFunctionType.SelectedIndex = 0;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public string GetText()
        {
            return this.textBoxEquation.Text;
        }
    }
}
