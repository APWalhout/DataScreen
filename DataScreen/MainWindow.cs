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
        Label[] textObjects;
        byte zero = 0;

        Font defaultFont = new Font("Arial", 9, FontStyle.Regular);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add all text objects to a text object array so they can be updated for 
            //!!! number of items in textObjects cannot exceed a byte !!!!!!
            //textObjects.SetValue(labelTitle, 0);
            //load the default theme:::future extensibility, load from file so theme can be saved
            LoadTheme(zero);
        }

        //loads the called selection. byte keeps memory storage small
        private void LoadTheme(byte selection)
        {
            //switch case based on selection will call theme adjustments
            switch(selection)
            {
                default:
                    /*foreach(Label label in textObjects)
                    {
                        label.Font = defaultFont;
                    }*/
                    break;
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
