
namespace appventas.VISTAS
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formCRUDUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formCRUDClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formCRUDDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formCRUDProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.cRUDToolStripMenuItem,
            this.documentoToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.ventaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formCRUDUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // formCRUDUsuarioToolStripMenuItem
            // 
            this.formCRUDUsuarioToolStripMenuItem.Name = "formCRUDUsuarioToolStripMenuItem";
            this.formCRUDUsuarioToolStripMenuItem.Size = new System.Drawing.Size(298, 34);
            this.formCRUDUsuarioToolStripMenuItem.Text = "Formulario de Usuarios";
            this.formCRUDUsuarioToolStripMenuItem.Click += new System.EventHandler(this.formCRUDUsuarioToolStripMenuItem_Click);
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formCRUDClienteToolStripMenuItem});
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(81, 32);
            this.cRUDToolStripMenuItem.Text = "Cliente";
            // 
            // formCRUDClienteToolStripMenuItem
            // 
            this.formCRUDClienteToolStripMenuItem.Name = "formCRUDClienteToolStripMenuItem";
            this.formCRUDClienteToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.formCRUDClienteToolStripMenuItem.Text = "Formulario de  Clientes";
            this.formCRUDClienteToolStripMenuItem.Click += new System.EventHandler(this.formCRUDClienteToolStripMenuItem_Click);
            // 
            // documentoToolStripMenuItem
            // 
            this.documentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formCRUDDocumentoToolStripMenuItem});
            this.documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            this.documentoToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.documentoToolStripMenuItem.Text = "Documento";
            // 
            // formCRUDDocumentoToolStripMenuItem
            // 
            this.formCRUDDocumentoToolStripMenuItem.Name = "formCRUDDocumentoToolStripMenuItem";
            this.formCRUDDocumentoToolStripMenuItem.Size = new System.Drawing.Size(337, 34);
            this.formCRUDDocumentoToolStripMenuItem.Text = "Formulario de  Documentos";
            this.formCRUDDocumentoToolStripMenuItem.Click += new System.EventHandler(this.formCRUDDocumentoToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formCRUDProductoToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // formCRUDProductoToolStripMenuItem
            // 
            this.formCRUDProductoToolStripMenuItem.Name = "formCRUDProductoToolStripMenuItem";
            this.formCRUDProductoToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.formCRUDProductoToolStripMenuItem.Text = "Formulario de  Productos";
            this.formCRUDProductoToolStripMenuItem.Click += new System.EventHandler(this.formCRUDProductoToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioDeVentasToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // formularioDeVentasToolStripMenuItem
            // 
            this.formularioDeVentasToolStripMenuItem.Name = "formularioDeVentasToolStripMenuItem";
            this.formularioDeVentasToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.formularioDeVentasToolStripMenuItem.Text = "Formulario de ventas";
            this.formularioDeVentasToolStripMenuItem.Click += new System.EventHandler(this.formularioDeVentasToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 628);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formCRUDClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formCRUDUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formCRUDDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formCRUDProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeVentasToolStripMenuItem;
    }
}