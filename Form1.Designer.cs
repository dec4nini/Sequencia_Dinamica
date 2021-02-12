
namespace Sequencia__Maior_Menor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQtd = new System.Windows.Forms.Button();
            this.lblSeq = new System.Windows.Forms.Label();
            this.lblMaior = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPosi = new System.Windows.Forms.Label();
            this.cbx2Maior = new System.Windows.Forms.CheckBox();
            this.cbx2Menor = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl2Menor = new System.Windows.Forms.Label();
            this.lbl2Maior = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQtde
            // 
            this.txtQtde.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQtde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtQtde.Location = new System.Drawing.Point(21, 36);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(117, 20);
            this.txtQtde.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qtde de Valores:";
            // 
            // btnQtd
            // 
            this.btnQtd.BackColor = System.Drawing.Color.Cornsilk;
            this.btnQtd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQtd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQtd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnQtd.Location = new System.Drawing.Point(39, 62);
            this.btnQtd.Name = "btnQtd";
            this.btnQtd.Size = new System.Drawing.Size(99, 41);
            this.btnQtd.TabIndex = 4;
            this.btnQtd.Text = "Começar a Inserir";
            this.btnQtd.UseVisualStyleBackColor = false;
            this.btnQtd.Click += new System.EventHandler(this.BtnQtd);
            // 
            // lblSeq
            // 
            this.lblSeq.AutoSize = true;
            this.lblSeq.BackColor = System.Drawing.Color.Transparent;
            this.lblSeq.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeq.ForeColor = System.Drawing.Color.White;
            this.lblSeq.Location = new System.Drawing.Point(151, 149);
            this.lblSeq.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblSeq.Name = "lblSeq";
            this.lblSeq.Size = new System.Drawing.Size(99, 17);
            this.lblSeq.TabIndex = 5;
            this.lblSeq.Text = "Sequência:     ";
            // 
            // lblMaior
            // 
            this.lblMaior.AutoSize = true;
            this.lblMaior.BackColor = System.Drawing.Color.Transparent;
            this.lblMaior.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaior.ForeColor = System.Drawing.Color.White;
            this.lblMaior.Location = new System.Drawing.Point(242, 20);
            this.lblMaior.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblMaior.Name = "lblMaior";
            this.lblMaior.Size = new System.Drawing.Size(15, 17);
            this.lblMaior.TabIndex = 6;
            this.lblMaior.Text = "0";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.BackColor = System.Drawing.Color.Transparent;
            this.lblMenor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.ForeColor = System.Drawing.Color.White;
            this.lblMenor.Location = new System.Drawing.Point(242, 53);
            this.lblMenor.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(15, 17);
            this.lblMenor.TabIndex = 7;
            this.lblMenor.Text = "0";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Cornsilk;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnInserir.Location = new System.Drawing.Point(21, 175);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(59, 31);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Visible = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtValor.Location = new System.Drawing.Point(21, 149);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(117, 20);
            this.txtValor.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(79, 175);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(59, 31);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 53);
            this.label3.MaximumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Menor valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(151, 20);
            this.label4.MaximumSize = new System.Drawing.Size(100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Maior valor:";
            // 
            // lblPosi
            // 
            this.lblPosi.AutoSize = true;
            this.lblPosi.BackColor = System.Drawing.Color.Transparent;
            this.lblPosi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosi.ForeColor = System.Drawing.Color.White;
            this.lblPosi.Location = new System.Drawing.Point(70, 129);
            this.lblPosi.Name = "lblPosi";
            this.lblPosi.Size = new System.Drawing.Size(33, 16);
            this.lblPosi.TabIndex = 14;
            this.lblPosi.Text = "(0/0)";
            // 
            // cbx2Maior
            // 
            this.cbx2Maior.AutoSize = true;
            this.cbx2Maior.Location = new System.Drawing.Point(21, 212);
            this.cbx2Maior.Name = "cbx2Maior";
            this.cbx2Maior.Size = new System.Drawing.Size(123, 17);
            this.cbx2Maior.TabIndex = 15;
            this.cbx2Maior.Text = "Segundo maior valor";
            this.cbx2Maior.UseVisualStyleBackColor = true;
            // 
            // cbx2Menor
            // 
            this.cbx2Menor.AutoSize = true;
            this.cbx2Menor.Location = new System.Drawing.Point(21, 235);
            this.cbx2Menor.Name = "cbx2Menor";
            this.cbx2Menor.Size = new System.Drawing.Size(127, 17);
            this.cbx2Menor.TabIndex = 16;
            this.cbx2Menor.Text = "Segundo menor valor";
            this.cbx2Menor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 119);
            this.label5.MaximumSize = new System.Drawing.Size(100, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "2º menor";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(151, 86);
            this.label6.MaximumSize = new System.Drawing.Size(100, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "2º maior:";
            this.label6.Visible = false;
            // 
            // lbl2Menor
            // 
            this.lbl2Menor.AutoSize = true;
            this.lbl2Menor.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Menor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Menor.ForeColor = System.Drawing.Color.White;
            this.lbl2Menor.Location = new System.Drawing.Point(242, 119);
            this.lbl2Menor.MaximumSize = new System.Drawing.Size(100, 0);
            this.lbl2Menor.Name = "lbl2Menor";
            this.lbl2Menor.Size = new System.Drawing.Size(15, 17);
            this.lbl2Menor.TabIndex = 18;
            this.lbl2Menor.Text = "0";
            this.lbl2Menor.Visible = false;
            // 
            // lbl2Maior
            // 
            this.lbl2Maior.AutoSize = true;
            this.lbl2Maior.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Maior.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Maior.ForeColor = System.Drawing.Color.White;
            this.lbl2Maior.Location = new System.Drawing.Point(242, 86);
            this.lbl2Maior.MaximumSize = new System.Drawing.Size(100, 0);
            this.lbl2Maior.Name = "lbl2Maior";
            this.lbl2Maior.Size = new System.Drawing.Size(15, 17);
            this.lbl2Maior.TabIndex = 17;
            this.lbl2Maior.Text = "0";
            this.lbl2Maior.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(370, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl2Menor);
            this.Controls.Add(this.lbl2Maior);
            this.Controls.Add(this.cbx2Menor);
            this.Controls.Add(this.cbx2Maior);
            this.Controls.Add(this.lblPosi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMaior);
            this.Controls.Add(this.lblSeq);
            this.Controls.Add(this.btnQtd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sequências:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQtd;
        private System.Windows.Forms.Label lblSeq;
        private System.Windows.Forms.Label lblMaior;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPosi;
        private System.Windows.Forms.CheckBox cbx2Maior;
        private System.Windows.Forms.CheckBox cbx2Menor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl2Menor;
        private System.Windows.Forms.Label lbl2Maior;
    }
}

