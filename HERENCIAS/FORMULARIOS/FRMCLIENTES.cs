using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOS
{
    public partial class FRMCLIENTES : Form
    {
        public FRMCLIENTES()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CLASES.CLIENTE CLIENTE1 = new CLASES.CLIENTE();
            CLIENTE1.APPATERNO1 = TxtApPaterno.Text;
            CLIENTE1.APMATERNO1 = TxtApMaterno.Text;
            CLIENTE1.SEXO1 = CmbSexo.Text;
            CLIENTE1.NUMEROSEGURIDADSOCIAL1 = TxtNumSegSoc.Text;
            CLIENTE1.CATEGORIA1 = CmbCategoria.Text;
            CLIENTE1.CEDULA1 = TxtCedula.Text;
            CLIENTE1.GENERARCODIGODEPEDIDO();
            TxtCodigoPedido.Text = CLIENTE1.CODIGODEPEDIDO1;
            DGVClientes.Rows.Insert(0, CLIENTE1.APPATERNO1, CLIENTE1.APMATERNO1, CLIENTE1.SEXO1, CLIENTE1.NUMEROSEGURIDADSOCIAL1, CLIENTE1.CATEGORIA1, CLIENTE1.CODIGODEPEDIDO1, CLIENTE1.CEDULA1);
        }
    }
}
