using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
            lb_vfinal.Text = "";
        }

        internal class CalcularServicos
        {
            private string Computador;
            private string Cliente;
            private string Servicos;
            private string tipoPag;

        }

        

    

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
           tx_cliente.Clear();
           tx_computador.Clear();
           cb_servicos.ResetText();
           gb_pag.ResetText();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string computador = this.tx_computador.Text;
            string cliente = this.tx_cliente.Text;
            
        }
    }
}
