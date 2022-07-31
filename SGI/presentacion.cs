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

namespace SGI
{
    public partial class presentacion : Form
    {
        public presentacion()
        {
            InitializeComponent();
        }

        private void presentacion_Load(object sender, EventArgs e)
        {
          
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
