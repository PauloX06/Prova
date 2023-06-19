namespace Prova
{
    partial class Servicos
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
            this.lb_Computador = new System.Windows.Forms.Label();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.lb_servicos = new System.Windows.Forms.Label();
            this.lb_tpag = new System.Windows.Forms.Label();
            this.lb_vfinal = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.tx_computador = new System.Windows.Forms.TextBox();
            this.tx_cliente = new System.Windows.Forms.TextBox();
            this.cb_servicos = new System.Windows.Forms.ComboBox();
            this.rb_dinheiro = new System.Windows.Forms.RadioButton();
            this.gb_pag = new System.Windows.Forms.GroupBox();
            this.rb_cartao = new System.Windows.Forms.RadioButton();
            this.rb_pix = new System.Windows.Forms.RadioButton();
            this.gb_pag.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Computador
            // 
            this.lb_Computador.AutoSize = true;
            this.lb_Computador.Location = new System.Drawing.Point(88, 87);
            this.lb_Computador.Name = "lb_Computador";
            this.lb_Computador.Size = new System.Drawing.Size(64, 13);
            this.lb_Computador.TabIndex = 0;
            this.lb_Computador.Text = "Cumputador";
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Location = new System.Drawing.Point(88, 123);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(39, 13);
            this.lb_cliente.TabIndex = 1;
            this.lb_cliente.Text = "Cliente";
            // 
            // lb_servicos
            // 
            this.lb_servicos.AutoSize = true;
            this.lb_servicos.Location = new System.Drawing.Point(88, 153);
            this.lb_servicos.Name = "lb_servicos";
            this.lb_servicos.Size = new System.Drawing.Size(48, 13);
            this.lb_servicos.TabIndex = 2;
            this.lb_servicos.Text = "Serviços";
            // 
            // lb_tpag
            // 
            this.lb_tpag.AutoSize = true;
            this.lb_tpag.Location = new System.Drawing.Point(88, 184);
            this.lb_tpag.Name = "lb_tpag";
            this.lb_tpag.Size = new System.Drawing.Size(65, 13);
            this.lb_tpag.TabIndex = 3;
            this.lb_tpag.Text = "Tipo de Pag";
            // 
            // lb_vfinal
            // 
            this.lb_vfinal.AutoSize = true;
            this.lb_vfinal.Location = new System.Drawing.Point(88, 287);
            this.lb_vfinal.Name = "lb_vfinal";
            this.lb_vfinal.Size = new System.Drawing.Size(53, 13);
            this.lb_vfinal.TabIndex = 4;
            this.lb_vfinal.Text = "Valor final";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(663, 365);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 5;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(569, 365);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 6;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // tx_computador
            // 
            this.tx_computador.Location = new System.Drawing.Point(169, 87);
            this.tx_computador.Name = "tx_computador";
            this.tx_computador.Size = new System.Drawing.Size(100, 20);
            this.tx_computador.TabIndex = 7;
            // 
            // tx_cliente
            // 
            this.tx_cliente.Location = new System.Drawing.Point(169, 123);
            this.tx_cliente.Name = "tx_cliente";
            this.tx_cliente.Size = new System.Drawing.Size(100, 20);
            this.tx_cliente.TabIndex = 8;
            // 
            // cb_servicos
            // 
            this.cb_servicos.FormattingEnabled = true;
            this.cb_servicos.Items.AddRange(new object[] {
            "Formatação",
            "Limpeza",
            "Troca de Peça"});
            this.cb_servicos.Location = new System.Drawing.Point(169, 153);
            this.cb_servicos.Name = "cb_servicos";
            this.cb_servicos.Size = new System.Drawing.Size(121, 21);
            this.cb_servicos.TabIndex = 9;
            // 
            // rb_dinheiro
            // 
            this.rb_dinheiro.AutoSize = true;
            this.rb_dinheiro.Location = new System.Drawing.Point(0, 19);
            this.rb_dinheiro.Name = "rb_dinheiro";
            this.rb_dinheiro.Size = new System.Drawing.Size(64, 17);
            this.rb_dinheiro.TabIndex = 10;
            this.rb_dinheiro.TabStop = true;
            this.rb_dinheiro.Text = "Dinheiro";
            this.rb_dinheiro.UseVisualStyleBackColor = true;
            // 
            // gb_pag
            // 
            this.gb_pag.Controls.Add(this.rb_cartao);
            this.gb_pag.Controls.Add(this.rb_pix);
            this.gb_pag.Controls.Add(this.rb_dinheiro);
            this.gb_pag.Location = new System.Drawing.Point(169, 184);
            this.gb_pag.Name = "gb_pag";
            this.gb_pag.Size = new System.Drawing.Size(100, 90);
            this.gb_pag.TabIndex = 11;
            this.gb_pag.TabStop = false;
            this.gb_pag.Text = "groupBox1";
            // 
            // rb_cartao
            // 
            this.rb_cartao.AutoSize = true;
            this.rb_cartao.Location = new System.Drawing.Point(0, 66);
            this.rb_cartao.Name = "rb_cartao";
            this.rb_cartao.Size = new System.Drawing.Size(56, 17);
            this.rb_cartao.TabIndex = 12;
            this.rb_cartao.TabStop = true;
            this.rb_cartao.Text = "Cartão";
            this.rb_cartao.UseVisualStyleBackColor = true;
            // 
            // rb_pix
            // 
            this.rb_pix.AutoSize = true;
            this.rb_pix.Location = new System.Drawing.Point(0, 42);
            this.rb_pix.Name = "rb_pix";
            this.rb_pix.Size = new System.Drawing.Size(39, 17);
            this.rb_pix.TabIndex = 11;
            this.rb_pix.TabStop = true;
            this.rb_pix.Text = "Pix";
            this.rb_pix.UseVisualStyleBackColor = true;
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_pag);
            this.Controls.Add(this.cb_servicos);
            this.Controls.Add(this.tx_cliente);
            this.Controls.Add(this.tx_computador);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.lb_vfinal);
            this.Controls.Add(this.lb_tpag);
            this.Controls.Add(this.lb_servicos);
            this.Controls.Add(this.lb_cliente);
            this.Controls.Add(this.lb_Computador);
            this.Name = "Servicos";
            this.Text = "Servicos";
            this.gb_pag.ResumeLayout(false);
            this.gb_pag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Computador;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.Label lb_servicos;
        private System.Windows.Forms.Label lb_tpag;
        private System.Windows.Forms.Label lb_vfinal;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.TextBox tx_computador;
        private System.Windows.Forms.TextBox tx_cliente;
        private System.Windows.Forms.ComboBox cb_servicos;
        private System.Windows.Forms.RadioButton rb_dinheiro;
        private System.Windows.Forms.GroupBox gb_pag;
        private System.Windows.Forms.RadioButton rb_cartao;
        private System.Windows.Forms.RadioButton rb_pix;
    }
}