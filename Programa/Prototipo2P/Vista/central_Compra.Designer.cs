
namespace Vista
{
    partial class central_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(central_Compra));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnRecepción = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.White;
            this.panelSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSideMenu.Controls.Add(this.panelCompras);
            this.panelSideMenu.Controls.Add(this.btnCompras);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(237, 561);
            this.panelSideMenu.TabIndex = 1;
            // 
            // panelCompras
            // 
            this.panelCompras.BackColor = System.Drawing.Color.White;
            this.panelCompras.Controls.Add(this.btnOrdenes);
            this.panelCompras.Controls.Add(this.btnRecepción);
            this.panelCompras.Controls.Add(this.btnCompra);
            this.panelCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompras.Location = new System.Drawing.Point(0, 126);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(237, 265);
            this.panelCompras.TabIndex = 1;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.White;
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnOrdenes.Location = new System.Drawing.Point(0, 70);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnOrdenes.Size = new System.Drawing.Size(237, 35);
            this.btnOrdenes.TabIndex = 2;
            this.btnOrdenes.Text = "Procesos";
            this.btnOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnRecepción
            // 
            this.btnRecepción.BackColor = System.Drawing.Color.White;
            this.btnRecepción.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecepción.FlatAppearance.BorderSize = 0;
            this.btnRecepción.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepción.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnRecepción.Location = new System.Drawing.Point(0, 35);
            this.btnRecepción.Name = "btnRecepción";
            this.btnRecepción.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnRecepción.Size = new System.Drawing.Size(237, 35);
            this.btnRecepción.TabIndex = 1;
            this.btnRecepción.Text = "Catalogo";
            this.btnRecepción.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecepción.UseVisualStyleBackColor = false;
            this.btnRecepción.Click += new System.EventHandler(this.btnRecepción_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.White;
            this.btnCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCompra.Location = new System.Drawing.Point(0, 0);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.btnCompra.Size = new System.Drawing.Size(237, 35);
            this.btnCompra.TabIndex = 0;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.DimGray;
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnCompras.Location = new System.Drawing.Point(0, 87);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnCompras.Size = new System.Drawing.Size(237, 39);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.Text = "Abrir";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(237, 87);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 87);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(237, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(647, 561);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // central_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "central_Compra";
            this.Text = "Jason Ortega 0901-19-22658";
            this.panelSideMenu.ResumeLayout(false);
            this.panelCompras.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnRecepción;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}