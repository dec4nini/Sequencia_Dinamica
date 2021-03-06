﻿using System;
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
        int max;
        int min;
        int max2;
        int min2;


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQtd(object sender, EventArgs e)
        {
            try
            {
                qtd_nums = Convert.ToInt32(txtQtde.Text);
                
                if (qtd_nums<2)
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
            cbx2Maior.Enabled = false;
            cbx2Menor.Enabled = false;
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

            if (ok & lista.Contains(num))
            {
                MessageBox.Show(num+ " já existe na sequência, insira outro valor!");
            }
            
            else if (cont<qtd_nums-1 & ok)
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
                max = lista[0];
                min = lista[0];
                lista.Add(Convert.ToInt32(txtValor.Text));
                cont++;
                //Imprimir sequência
                foreach (var i in lista)
                {
                    lblSeq.Text += " " + Convert.ToString(i);
                }
                btnInserir.Visible = false;
                lblPosi.Text = ("(" + cont + "/" + qtd_nums + ")");

                foreach (var item in lista)
                {
                    if (item > max)
                    {
                        max = item;                        
                    }
                    if (item < min)
                    {
                        min = item;                        
                    }                    
                }
                
                lblMaior.Text = max.ToString();
                lblMenor.Text = min.ToString();
                lista.Sort();
                if (cbx2Maior.Checked)
                {
                    label6.Visible = true;
                    lbl2Maior.Visible = true;
                    foreach (var item in lista)
                    {
                        if (item < max & item > min)
                        {
                            max2 = item;
                        }
                    }
                }
                lista.Reverse();
                if (cbx2Menor.Checked)
                {
                    label5.Visible = true;
                    lbl2Menor.Visible = true;
                    foreach (var item in lista)
                    {
                        if (item < max & item > min)
                        {
                            min2 = item;
                        }
                    }
                }

              
                lbl2Maior.Text = max2.ToString();
                lbl2Menor.Text = min2.ToString();

                
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
            cbx2Maior.Enabled = true;
            cbx2Menor.Enabled = true;
        }
    }
}
