namespace Notepad
{
    partial class FormBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscar));
            txtbBusq = new TextBox();
            label1 = new Label();
            btnAnt = new PictureBox();
            btnSig = new PictureBox();
            bttnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)btnAnt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSig).BeginInit();
            SuspendLayout();
            // 
            // txtbBusq
            // 
            txtbBusq.Location = new Point(114, 31);
            txtbBusq.Name = "txtbBusq";
            txtbBusq.Size = new Size(312, 27);
            txtbBusq.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 30);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 4;
            label1.Text = "Navegación";
            // 
            // btnAnt
            // 
            btnAnt.Image = (Image)resources.GetObject("btnAnt.Image");
            btnAnt.Location = new Point(526, 36);
            btnAnt.Name = "btnAnt";
            btnAnt.Size = new Size(35, 22);
            btnAnt.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAnt.TabIndex = 6;
            btnAnt.TabStop = false;
            btnAnt.Click += btnAnt_Click;
            // 
            // btnSig
            // 
            btnSig.Image = (Image)resources.GetObject("btnSig.Image");
            btnSig.Location = new Point(567, 35);
            btnSig.Name = "btnSig";
            btnSig.Size = new Size(35, 24);
            btnSig.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSig.TabIndex = 7;
            btnSig.TabStop = false;
            btnSig.Click += btnSig_Click;
            // 
            // bttnBuscar
            // 
            bttnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            bttnBuscar.Location = new Point(432, 30);
            bttnBuscar.Name = "bttnBuscar";
            bttnBuscar.Size = new Size(75, 29);
            bttnBuscar.TabIndex = 8;
            bttnBuscar.Text = "Buscar";
            bttnBuscar.TextAlign = ContentAlignment.TopCenter;
            bttnBuscar.UseVisualStyleBackColor = true;
            bttnBuscar.Click += bttnBuscar_Click;
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 86);
            Controls.Add(bttnBuscar);
            Controls.Add(btnSig);
            Controls.Add(btnAnt);
            Controls.Add(label1);
            Controls.Add(txtbBusq);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBuscar";
            Text = "Busca";
            ((System.ComponentModel.ISupportInitialize)btnAnt).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbBusq;
        private Label label1;
        private PictureBox btnAnt;
        private PictureBox btnSig;
        private Button bttnBuscar;
    }
}