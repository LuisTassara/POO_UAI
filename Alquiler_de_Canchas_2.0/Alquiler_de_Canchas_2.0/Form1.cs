using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_de_Canchas_2._0
{
    public partial class Form1 : Form
    {
        private Predio _Predio;
        public Form1()
        {
            InitializeComponent();
            _Predio = new Predio();
        }
             
        
    private void Form1_Load(object sender, EventArgs e)
        {
        


        }


    }
}
