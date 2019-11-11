using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataScreen
{
    public partial class MainWindow : Form
    {
        Array textObjects;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add all text objects to a text object array so they can be updated for 
            textObjects.SetValue(labelTitle, 0);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
