namespace Notepad
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            deshacerToolStripMenuItem = new ToolStripMenuItem();
            rehacerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            seleccionarTodoToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem1 = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tlsbOpen = new ToolStripButton();
            tlsbSave = new ToolStripButton();
            tlsbSaveAs = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tlsbAtras = new ToolStripButton();
            tlsbRehacer = new ToolStripButton();
            tlsbCut = new ToolStripButton();
            tlsbCopy = new ToolStripButton();
            tlsbPage = new ToolStripButton();
            tlsbSub = new ToolStripButton();
            tlsbSearch = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tlsbFont = new ToolStripButton();
            tlsbColor = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tlsbExit = new ToolStripButton();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Bottom;
            richTextBox1.Location = new Point(0, 61);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(889, 367);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(889, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, openToolStripMenuItem, guardarComoToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Image = (Image)resources.GetObject("archivoToolStripMenuItem.Image");
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(80, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = (Image)resources.GetObject("nuevoToolStripMenuItem.Image");
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(150, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(150, 22);
            openToolStripMenuItem.Text = "Abrir";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Image = (Image)resources.GetObject("guardarComoToolStripMenuItem.Image");
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(150, 22);
            guardarComoToolStripMenuItem.Text = "Guardar";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = (Image)resources.GetObject("guardarToolStripMenuItem.Image");
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(150, 22);
            guardarToolStripMenuItem.Text = "Guardar como";
            guardarToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = (Image)resources.GetObject("salirToolStripMenuItem.Image");
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(150, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deshacerToolStripMenuItem, rehacerToolStripMenuItem, toolStripMenuItem1, cortarToolStripMenuItem, copiarToolStripMenuItem, pegarToolStripMenuItem, toolStripMenuItem2, seleccionarTodoToolStripMenuItem, buscarToolStripMenuItem1 });
            editarToolStripMenuItem.Image = (Image)resources.GetObject("editarToolStripMenuItem.Image");
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(69, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            deshacerToolStripMenuItem.Image = (Image)resources.GetObject("deshacerToolStripMenuItem.Image");
            deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            deshacerToolStripMenuItem.Size = new Size(162, 22);
            deshacerToolStripMenuItem.Text = "Deshacer";
            deshacerToolStripMenuItem.Click += deshacerToolStripMenuItem_Click;
            // 
            // rehacerToolStripMenuItem
            // 
            rehacerToolStripMenuItem.Image = (Image)resources.GetObject("rehacerToolStripMenuItem.Image");
            rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            rehacerToolStripMenuItem.Size = new Size(162, 22);
            rehacerToolStripMenuItem.Text = "Rehacer";
            rehacerToolStripMenuItem.Click += rehacerToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(159, 6);
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Image = (Image)resources.GetObject("cortarToolStripMenuItem.Image");
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.Size = new Size(162, 22);
            cortarToolStripMenuItem.Text = "Cortar";
            cortarToolStripMenuItem.Click += cortarToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Image = (Image)resources.GetObject("copiarToolStripMenuItem.Image");
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(162, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Image = (Image)resources.GetObject("pegarToolStripMenuItem.Image");
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(162, 22);
            pegarToolStripMenuItem.Text = "Pegar";
            pegarToolStripMenuItem.Click += pegarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(159, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            seleccionarTodoToolStripMenuItem.Image = (Image)resources.GetObject("seleccionarTodoToolStripMenuItem.Image");
            seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            seleccionarTodoToolStripMenuItem.Size = new Size(162, 22);
            seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            seleccionarTodoToolStripMenuItem.Click += seleccionarTodoToolStripMenuItem_Click;
            // 
            // buscarToolStripMenuItem1
            // 
            buscarToolStripMenuItem1.Image = (Image)resources.GetObject("buscarToolStripMenuItem1.Image");
            buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            buscarToolStripMenuItem1.Size = new Size(162, 22);
            buscarToolStripMenuItem1.Text = "Buscar";
            buscarToolStripMenuItem1.Click += buscarToolStripMenuItem1_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem, colorToolStripMenuItem });
            formatToolStripMenuItem.Image = (Image)resources.GetObject("formatToolStripMenuItem.Image");
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(84, 24);
            formatToolStripMenuItem.Text = "Formato";
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Image = (Image)resources.GetObject("fuenteToolStripMenuItem.Image");
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(184, 26);
            fuenteToolStripMenuItem.Text = "Fuente";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Image = (Image)resources.GetObject("colorToolStripMenuItem.Image");
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(184, 26);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, tlsbOpen, tlsbSave, tlsbSaveAs, toolStripSeparator1, tlsbAtras, tlsbRehacer, tlsbCut, tlsbCopy, tlsbPage, tlsbSub, tlsbSearch, toolStripSeparator2, tlsbFont, tlsbColor, toolStripSeparator3, tlsbExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(366, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(24, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tlsbOpen
            // 
            tlsbOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbOpen.Image = (Image)resources.GetObject("tlsbOpen.Image");
            tlsbOpen.ImageTransparentColor = Color.Magenta;
            tlsbOpen.Name = "tlsbOpen";
            tlsbOpen.Size = new Size(24, 24);
            tlsbOpen.Text = "tlsbOpen";
            tlsbOpen.Click += toolStripButton2_Click;
            // 
            // tlsbSave
            // 
            tlsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbSave.Image = (Image)resources.GetObject("tlsbSave.Image");
            tlsbSave.ImageTransparentColor = Color.Magenta;
            tlsbSave.Name = "tlsbSave";
            tlsbSave.Size = new Size(24, 24);
            tlsbSave.Click += tlsbSave_Click;
            // 
            // tlsbSaveAs
            // 
            tlsbSaveAs.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbSaveAs.Image = (Image)resources.GetObject("tlsbSaveAs.Image");
            tlsbSaveAs.ImageTransparentColor = Color.Magenta;
            tlsbSaveAs.Name = "tlsbSaveAs";
            tlsbSaveAs.Size = new Size(24, 24);
            tlsbSaveAs.Click += tlsbSaveAs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tlsbAtras
            // 
            tlsbAtras.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbAtras.Image = (Image)resources.GetObject("tlsbAtras.Image");
            tlsbAtras.ImageTransparentColor = Color.Magenta;
            tlsbAtras.Name = "tlsbAtras";
            tlsbAtras.Size = new Size(24, 24);
            tlsbAtras.Click += toolStripButton5_Click;
            // 
            // tlsbRehacer
            // 
            tlsbRehacer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbRehacer.Image = (Image)resources.GetObject("tlsbRehacer.Image");
            tlsbRehacer.ImageTransparentColor = Color.Magenta;
            tlsbRehacer.Name = "tlsbRehacer";
            tlsbRehacer.Size = new Size(24, 24);
            tlsbRehacer.Click += tlsbRehacer_Click;
            // 
            // tlsbCut
            // 
            tlsbCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbCut.Image = (Image)resources.GetObject("tlsbCut.Image");
            tlsbCut.ImageTransparentColor = Color.Magenta;
            tlsbCut.Name = "tlsbCut";
            tlsbCut.Size = new Size(24, 24);
            tlsbCut.Click += tlsbCut_Click;
            // 
            // tlsbCopy
            // 
            tlsbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbCopy.Image = (Image)resources.GetObject("tlsbCopy.Image");
            tlsbCopy.ImageTransparentColor = Color.Magenta;
            tlsbCopy.Name = "tlsbCopy";
            tlsbCopy.Size = new Size(24, 24);
            tlsbCopy.Click += tlsbCopy_Click;
            // 
            // tlsbPage
            // 
            tlsbPage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbPage.Image = (Image)resources.GetObject("tlsbPage.Image");
            tlsbPage.ImageTransparentColor = Color.Magenta;
            tlsbPage.Name = "tlsbPage";
            tlsbPage.Size = new Size(24, 24);
            tlsbPage.Click += tlsbPage_Click;
            // 
            // tlsbSub
            // 
            tlsbSub.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbSub.Image = (Image)resources.GetObject("tlsbSub.Image");
            tlsbSub.ImageTransparentColor = Color.Magenta;
            tlsbSub.Name = "tlsbSub";
            tlsbSub.Size = new Size(24, 24);
            tlsbSub.Click += tlsbSub_Click;
            // 
            // tlsbSearch
            // 
            tlsbSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbSearch.Image = (Image)resources.GetObject("tlsbSearch.Image");
            tlsbSearch.ImageTransparentColor = Color.Magenta;
            tlsbSearch.Name = "tlsbSearch";
            tlsbSearch.Size = new Size(24, 24);
            tlsbSearch.Click += tlsbSearch_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // tlsbFont
            // 
            tlsbFont.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbFont.Image = (Image)resources.GetObject("tlsbFont.Image");
            tlsbFont.ImageTransparentColor = Color.Magenta;
            tlsbFont.Name = "tlsbFont";
            tlsbFont.Size = new Size(24, 24);
            tlsbFont.Click += tlsbFont_Click;
            // 
            // tlsbColor
            // 
            tlsbColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbColor.Image = (Image)resources.GetObject("tlsbColor.Image");
            tlsbColor.ImageTransparentColor = Color.Magenta;
            tlsbColor.Name = "tlsbColor";
            tlsbColor.Size = new Size(24, 24);
            tlsbColor.Click += tlsbColor_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // tlsbExit
            // 
            tlsbExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsbExit.Image = (Image)resources.GetObject("tlsbExit.Image");
            tlsbExit.ImageTransparentColor = Color.Magenta;
            tlsbExit.Name = "tlsbExit";
            tlsbExit.Size = new Size(24, 24);
            tlsbExit.Click += tlsbExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 25);
            panel1.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 428);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            RightToLeftLayout = true;
            Text = "Notes";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem deshacerToolStripMenuItem;
        private ToolStripMenuItem rehacerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton tlsbOpen;
        private ToolStripButton tlsbSave;
        private ToolStripButton tlsbSaveAs;
        private ToolStripButton tlsbAtras;
        private ToolStripButton tlsbRehacer;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tlsbCut;
        private ToolStripButton tlsbCopy;
        private ToolStripButton tlsbPage;
        private ToolStripButton tlsbSub;
        private ToolStripButton tlsbSearch;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tlsbFont;
        private ToolStripButton tlsbColor;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tlsbExit;
        private Panel panel1;
    }
}