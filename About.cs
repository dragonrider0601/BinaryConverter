using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConverter
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        //Close information window
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
