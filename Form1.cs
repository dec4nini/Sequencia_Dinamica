using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequencia__Maior_Menor
{
    public partial class Form1 : Form
    {


        List<int> lista = new List<int>();
        int qtd_nums;
        int cont = 0;
        int num;


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQtd(object sender, EventArgs e)
        {
            try
            {
                qtd_nums = Convert.ToInt32(txtQtde.Text);
                
                if (qtd_nums<0)
                {
                    MessageBox.Show("Por favor insira valores válidos!");                    
                }
                else
                {
                    btnQtd.Visible = false;
                    lblPosi.Text = ("(" + cont + "/" + qtd_nums + ")");
                    #region Habilitar botões                    
                    btnInserir.Visible = true;
                    btnLimpar.Visible = true;
                    txtValor.Focus();
                    #endregion                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor insira valores válidos!");                
            }            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            bool ok = true;
            try
            {
                num = Convert.ToInt32(txtValor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Valor não é válido!");
                ok = false;
            }

            
            if (cont<qtd_nums-1 & ok)
            {
                lista.Add(num);
                cont++;
                txtValor.Focus();
                txtValor.Text = "";
                lblPosi.Text = ("(" + cont + "/" + qtd_nums + ")");
            }
            else if(ok)
            {
                lblPosi.Text = ("(" + cont + "/" + qtd_nums + ")");
                lblMaior.Text = lista[0].ToString();
                lblMenor.Text = lista[0].ToString();
                lista.Add(Convert.ToInt32(txtValor.Text));
                cont++;
                foreach (var item in lista)
                {
                    if (item > Convert.ToInt32(lblMaior.Text))
                    {
                        lblMaior.Text = Convert.ToString(item);
                    }
                    else if (item < Convert.ToInt32(lblMenor.Text))
                    {
                        lblMenor.Text = Convert.ToString(item);
                    }                    
                }
                foreach (var i in lista)
                {
                    lblSeq.Text += " " + Convert.ToString(i);
                }
                btnInserir.Visible = false;
                lblPosi.Text = ("(" + cont + "/" + qtd_nums + ")");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtQtde.Text = "";
            txtValor.Text = "";
            lblMaior.Text = 0.ToString();
            lblMenor.Text = 0.ToString();
            lblSeq.Text = "Sequência:     ";
            txtQtde.Focus();
            btnLimpar.Visible = false;
            btnInserir.Visible = false;
            btnQtd.Visible = true;
            lista.Clear();
            cont = 0;
            lblPosi.Text = "(0/0)";
        }
    }
}
