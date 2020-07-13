using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recital
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
            cbo_Banda.DataSource = _Predio.Bandas;
            cbo_Banda.DisplayMember = "Nombre";




        }

        private void cbo_Banda_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbo_Fecha.DataSource = _Predio.Fechas;
            cbo_Fecha.DisplayMember = "Fecha";

                     
        }

        private void cbo_Fecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_Entrada.DataSource = _Predio.Entradas;
            cbo_Entrada.DisplayMember = "Tipo";
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            //_Predio.Comprar((Entrada)cbo_Entrada.SelectedItem, (DateTime)cbo_Fecha.SelectedItem, (Banda)cbo_Banda.SelectedItem);
            _Predio.Comprar((Entrada)cbo_Entrada.SelectedItem, (Banda)cbo_Banda.SelectedItem, (Banda)cbo_Fecha.SelectedItem);
            lbl_MTCRM.Text = $"Metallica Vendió: {_Predio.CantidadEntradasMetallica()}";
            lbl_MTRL.Text = $"La Renga Vendió: {_Predio.CantidadEntradasLaRenga()}";
            lbl_TRecaudado.Text = $"Recaudación: {_Predio.TotalRecaudado()}";


        }

        private void cbo_Entrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Precio.Text = $"Precio:  {((Entrada)cbo_Entrada.SelectedItem).Precio}";

            lbl_CEV.Text = $"Cantidad Entradas Vendidas: {_Predio.CantidadEntradasVendidas()}";


        }
    }
}
