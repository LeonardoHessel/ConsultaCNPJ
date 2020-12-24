using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCNPJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cnpj = textBox1.Text;

            try
            {

                var ws = new WSDataPrev.ServicosDataprevSoapClient();
                var par = new WSDataPrev.parametrosTO();
                
                var empresa = ws.GetSituacaoFiscalPrevidenciaria(par);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
