using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picSketch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sketch_Click(object sender, EventArgs e)
        {
            game start = new game();

            start.startGame();

            txt_char.Text = start.character;
            txt_att.Text = start.attribute;
        
        }
    }
}
