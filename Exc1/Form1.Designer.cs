namespace Exc1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidev = new System.Windows.Forms.TextBox();
            this.txteventoev = new System.Windows.Forms.TextBox();
            this.txtinicioev = new System.Windows.Forms.TextBox();
            this.btncadastrarEv = new System.Windows.Forms.Button();
            this.btnconsultaEv = new System.Windows.Forms.Button();
            this.btnalterarEv = new System.Windows.Forms.Button();
            this.btnexcluirEv = new System.Windows.Forms.Button();
            this.txtterminoev = new System.Windows.Forms.TextBox();
            this.txtlocalev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalorev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnomein = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcidadein = new System.Windows.Forms.TextBox();
            this.txtestadoin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btncadastrarIn = new System.Windows.Forms.Button();
            this.btnconsultaIn = new System.Windows.Forms.Button();
            this.btnalterarIn = new System.Windows.Forms.Button();
            this.btnexcluirIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evento";
            // 
            // txtidev
            // 
            this.txtidev.Location = new System.Drawing.Point(102, 27);
            this.txtidev.Name = "txtidev";
            this.txtidev.Size = new System.Drawing.Size(219, 20);
            this.txtidev.TabIndex = 3;
            // 
            // txteventoev
            // 
            this.txteventoev.Location = new System.Drawing.Point(102, 53);
            this.txteventoev.Name = "txteventoev";
            this.txteventoev.Size = new System.Drawing.Size(219, 20);
            this.txteventoev.TabIndex = 4;
            // 
            // txtinicioev
            // 
            this.txtinicioev.Location = new System.Drawing.Point(102, 79);
            this.txtinicioev.Name = "txtinicioev";
            this.txtinicioev.Size = new System.Drawing.Size(219, 20);
            this.txtinicioev.TabIndex = 5;
            // 
            // btncadastrarEv
            // 
            this.btncadastrarEv.Location = new System.Drawing.Point(348, 27);
            this.btncadastrarEv.Name = "btncadastrarEv";
            this.btncadastrarEv.Size = new System.Drawing.Size(75, 23);
            this.btncadastrarEv.TabIndex = 6;
            this.btncadastrarEv.Text = "Cadastrar";
            this.btncadastrarEv.UseVisualStyleBackColor = true;
            this.btncadastrarEv.Click += new System.EventHandler(this.btncadastrarEv_Click);
            // 
            // btnconsultaEv
            // 
            this.btnconsultaEv.Location = new System.Drawing.Point(348, 56);
            this.btnconsultaEv.Name = "btnconsultaEv";
            this.btnconsultaEv.Size = new System.Drawing.Size(75, 23);
            this.btnconsultaEv.TabIndex = 7;
            this.btnconsultaEv.Text = "Consulta";
            this.btnconsultaEv.UseVisualStyleBackColor = true;
            this.btnconsultaEv.Click += new System.EventHandler(this.btnconsultaEv_Click);
            // 
            // btnalterarEv
            // 
            this.btnalterarEv.Location = new System.Drawing.Point(348, 85);
            this.btnalterarEv.Name = "btnalterarEv";
            this.btnalterarEv.Size = new System.Drawing.Size(75, 23);
            this.btnalterarEv.TabIndex = 8;
            this.btnalterarEv.Text = "Alterar";
            this.btnalterarEv.UseVisualStyleBackColor = true;
            this.btnalterarEv.Click += new System.EventHandler(this.btnalterarEv_Click);
            // 
            // btnexcluirEv
            // 
            this.btnexcluirEv.Location = new System.Drawing.Point(348, 114);
            this.btnexcluirEv.Name = "btnexcluirEv";
            this.btnexcluirEv.Size = new System.Drawing.Size(75, 23);
            this.btnexcluirEv.TabIndex = 9;
            this.btnexcluirEv.Text = "Excluir";
            this.btnexcluirEv.UseVisualStyleBackColor = true;
            this.btnexcluirEv.Click += new System.EventHandler(this.btnexcluirEv_Click);
            // 
            // txtterminoev
            // 
            this.txtterminoev.Location = new System.Drawing.Point(102, 105);
            this.txtterminoev.Name = "txtterminoev";
            this.txtterminoev.Size = new System.Drawing.Size(219, 20);
            this.txtterminoev.TabIndex = 10;
            // 
            // txtlocalev
            // 
            this.txtlocalev.Location = new System.Drawing.Point(102, 132);
            this.txtlocalev.Name = "txtlocalev";
            this.txtlocalev.Size = new System.Drawing.Size(219, 20);
            this.txtlocalev.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Termino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Local";
            // 
            // txtvalorev
            // 
            this.txtvalorev.Location = new System.Drawing.Point(102, 159);
            this.txtvalorev.Name = "txtvalorev";
            this.txtvalorev.Size = new System.Drawing.Size(219, 20);
            this.txtvalorev.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Id Inst.";
            // 
            // txtidin
            // 
            this.txtidin.Location = new System.Drawing.Point(102, 243);
            this.txtidin.Name = "txtidin";
            this.txtidin.Size = new System.Drawing.Size(219, 20);
            this.txtidin.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nome Inst.";
            // 
            // txtnomein
            // 
            this.txtnomein.Location = new System.Drawing.Point(102, 269);
            this.txtnomein.Name = "txtnomein";
            this.txtnomein.Size = new System.Drawing.Size(219, 20);
            this.txtnomein.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cidade";
            // 
            // txtcidadein
            // 
            this.txtcidadein.Location = new System.Drawing.Point(102, 296);
            this.txtcidadein.Name = "txtcidadein";
            this.txtcidadein.Size = new System.Drawing.Size(219, 20);
            this.txtcidadein.TabIndex = 21;
            // 
            // txtestadoin
            // 
            this.txtestadoin.Location = new System.Drawing.Point(102, 323);
            this.txtestadoin.Name = "txtestadoin";
            this.txtestadoin.Size = new System.Drawing.Size(219, 20);
            this.txtestadoin.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Estado";
            // 
            // btncadastrarIn
            // 
            this.btncadastrarIn.Location = new System.Drawing.Point(348, 243);
            this.btncadastrarIn.Name = "btncadastrarIn";
            this.btncadastrarIn.Size = new System.Drawing.Size(75, 23);
            this.btncadastrarIn.TabIndex = 24;
            this.btncadastrarIn.Text = "Cadastrar";
            this.btncadastrarIn.UseVisualStyleBackColor = true;
            this.btncadastrarIn.Click += new System.EventHandler(this.btncadastrarIn_Click);
            // 
            // btnconsultaIn
            // 
            this.btnconsultaIn.Location = new System.Drawing.Point(348, 269);
            this.btnconsultaIn.Name = "btnconsultaIn";
            this.btnconsultaIn.Size = new System.Drawing.Size(75, 23);
            this.btnconsultaIn.TabIndex = 25;
            this.btnconsultaIn.Text = "Consulta";
            this.btnconsultaIn.UseVisualStyleBackColor = true;
            this.btnconsultaIn.Click += new System.EventHandler(this.btnconsultaIn_Click);
            // 
            // btnalterarIn
            // 
            this.btnalterarIn.Location = new System.Drawing.Point(348, 294);
            this.btnalterarIn.Name = "btnalterarIn";
            this.btnalterarIn.Size = new System.Drawing.Size(75, 23);
            this.btnalterarIn.TabIndex = 26;
            this.btnalterarIn.Text = "Alterar";
            this.btnalterarIn.UseVisualStyleBackColor = true;
            this.btnalterarIn.Click += new System.EventHandler(this.btnalterarIn_Click);
            // 
            // btnexcluirIn
            // 
            this.btnexcluirIn.Location = new System.Drawing.Point(348, 320);
            this.btnexcluirIn.Name = "btnexcluirIn";
            this.btnexcluirIn.Size = new System.Drawing.Size(75, 23);
            this.btnexcluirIn.TabIndex = 27;
            this.btnexcluirIn.Text = "Excluir";
            this.btnexcluirIn.UseVisualStyleBackColor = true;
            this.btnexcluirIn.Click += new System.EventHandler(this.btnexcluirIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexcluirIn);
            this.Controls.Add(this.btnalterarIn);
            this.Controls.Add(this.btnconsultaIn);
            this.Controls.Add(this.btncadastrarIn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtestadoin);
            this.Controls.Add(this.txtcidadein);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnomein);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtvalorev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlocalev);
            this.Controls.Add(this.txtterminoev);
            this.Controls.Add(this.btnexcluirEv);
            this.Controls.Add(this.btnalterarEv);
            this.Controls.Add(this.btnconsultaEv);
            this.Controls.Add(this.btncadastrarEv);
            this.Controls.Add(this.txtinicioev);
            this.Controls.Add(this.txteventoev);
            this.Controls.Add(this.txtidev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidev;
        private System.Windows.Forms.TextBox txteventoev;
        private System.Windows.Forms.TextBox txtinicioev;
        private System.Windows.Forms.Button btncadastrarEv;
        private System.Windows.Forms.Button btnconsultaEv;
        private System.Windows.Forms.Button btnalterarEv;
        private System.Windows.Forms.Button btnexcluirEv;
        private System.Windows.Forms.TextBox txtterminoev;
        private System.Windows.Forms.TextBox txtlocalev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalorev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnomein;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcidadein;
        private System.Windows.Forms.TextBox txtestadoin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncadastrarIn;
        private System.Windows.Forms.Button btnconsultaIn;
        private System.Windows.Forms.Button btnalterarIn;
        private System.Windows.Forms.Button btnexcluirIn;
    }
}

