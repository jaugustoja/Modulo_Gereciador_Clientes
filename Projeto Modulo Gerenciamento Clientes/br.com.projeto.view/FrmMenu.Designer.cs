namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txthora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCliente,
            this.MenuConfiguracao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCliente
            // 
            this.MenuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroClientes,
            this.menuConsultaClientes});
            this.MenuCliente.Image = global::Projeto_Controle_Vendas.Properties.Resources.baixa;
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(77, 20);
            this.MenuCliente.Text = "Clientes";
            // 
            // menuCadastroClientes
            // 
            this.menuCadastroClientes.Image = global::Projeto_Controle_Vendas.Properties.Resources.pasta;
            this.menuCadastroClientes.Name = "menuCadastroClientes";
            this.menuCadastroClientes.Size = new System.Drawing.Size(182, 22);
            this.menuCadastroClientes.Text = "Cadastro de Clientes";
            this.menuCadastroClientes.Click += new System.EventHandler(this.menuCadastroClientes_Click);
            // 
            // menuConsultaClientes
            // 
            this.menuConsultaClientes.Image = global::Projeto_Controle_Vendas.Properties.Resources.estrela;
            this.menuConsultaClientes.Name = "menuConsultaClientes";
            this.menuConsultaClientes.Size = new System.Drawing.Size(182, 22);
            this.menuConsultaClientes.Text = "Consulta de Clientes";
            this.menuConsultaClientes.Click += new System.EventHandler(this.menuConsultaClientes_Click);
            // 
            // MenuConfiguracao
            // 
            this.MenuConfiguracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSair});
            this.MenuConfiguracao.Image = global::Projeto_Controle_Vendas.Properties.Resources.baixa;
            this.MenuConfiguracao.Name = "MenuConfiguracao";
            this.MenuConfiguracao.Size = new System.Drawing.Size(112, 20);
            this.MenuConfiguracao.Text = "Configurações";
            // 
            // MenuSair
            // 
            this.MenuSair.Image = global::Projeto_Controle_Vendas.Properties.Resources.cruzar;
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(180, 22);
            this.MenuSair.Text = "Sair do sistema";
            this.MenuSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtdata,
            this.toolStripStatusLabel3,
            this.txthora,
            this.toolStripStatusLabel5,
            this.txtusuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel1.Text = "Data atual:";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(71, 17);
            this.txtdata.Text = "01/06/2024";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel3.Text = "Hora atual:";
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(36, 17);
            this.txthora.Text = "18:30";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel5.Text = "Usuário logado:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(30, 17);
            this.txtusuario.Text = "José";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Controle_Vendas.Properties.Resources.Free_business_2016_High_Quality_HD_Wallpaper_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Princiapl - Módulo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaClientes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuConfiguracao;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtdata;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txthora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripStatusLabel txtusuario;
    }
}