namespace FormsExercício1
{
    partial class frmRetangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetangulo));
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblArea2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            resources.ApplyResources(this.txtBase, "txtBase");
            this.txtBase.Name = "txtBase";
            // 
            // txtAltura
            // 
            resources.ApplyResources(this.txtAltura, "txtAltura");
            this.txtAltura.Name = "txtAltura";
            // 
            // lblBase
            // 
            resources.ApplyResources(this.lblBase, "lblBase");
            this.lblBase.Name = "lblBase";
            // 
            // lblAltura
            // 
            resources.ApplyResources(this.lblAltura, "lblAltura");
            this.lblAltura.Name = "lblAltura";
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.Name = "lblTitulo";
            // 
            // btnCalcularArea
            // 
            resources.ApplyResources(this.btnCalcularArea, "btnCalcularArea");
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.clickou_calcular_area);
            // 
            // lblArea
            // 
            resources.ApplyResources(this.lblArea, "lblArea");
            this.lblArea.Name = "lblArea";
            // 
            // lblArea2
            // 
            resources.ApplyResources(this.lblArea2, "lblArea2");
            this.lblArea2.Name = "lblArea2";
            // 
            // frmRetangulo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblArea2);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Name = "frmRetangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblArea2;
    }
}

