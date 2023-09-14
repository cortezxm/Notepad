namespace Notepad
{
    public partial class FormPrincipal : Form
    {
        private bool cambiosRealizados = false;
        public FormPrincipal()
        {
            InitializeComponent();
            richTextBox1.TextChanged += RichTextBox1_TextChanged;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            cambiosRealizados = true;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Abrir";
            openFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            this.Text = openFileDialog.FileName;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                richTextBox1.SaveFile(this.Text, RichTextBoxStreamType.PlainText);
                cambiosRealizados = false; // Restablece el indicador de cambios
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar";
            saveFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                this.Text = saveFileDialog.FileName;
                cambiosRealizados = false; //
            }
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cambiosRealizados)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    guardarComoToolStripMenuItem_Click(sender, e);
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }


        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();

        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fnt.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = fnt.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBuscar buscarForm = new FormBuscar(richTextBox1);
            buscarForm.Show();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //richTextBox1.Undo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //richTextBox1.Clear();
            //desea guardar cambios
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Abrir";
            openFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            this.Text = openFileDialog.FileName;*/
        }

        private void tlsbSave_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar";
            saveFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                this.Text = saveFileDialog.FileName;
                cambiosRealizados = false; //
            }*/
        }

        private void tlsbRehacer_Click(object sender, EventArgs e)
        {
            //richTextBox1.Redo();
        }

        private void tlsbCut_Click(object sender, EventArgs e)
        {
            //richTextBox1.Cut();
        }

        private void tlsbCopy_Click(object sender, EventArgs e)
        {
            //richTextBox1.Copy();
        }

        private void tlsbPage_Click(object sender, EventArgs e)
        {
            //richTextBox1.Paste();
        }

        private void tlsbSaveAs_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar";
            saveFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                this.Text = saveFileDialog.FileName;
                cambiosRealizados = false; //
            }*/
        }

        private void tlsbSub_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectAll();
        }

        private void tlsbSearch_Click(object sender, EventArgs e)
        {
            /*FormBuscar buscarForm = new FormBuscar(richTextBox1);
            buscarForm.Show();*/
        }

        private void tlsbFont_Click(object sender, EventArgs e)
        {
            /*FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fnt.Font;*/
        }

        private void tlsbColor_Click(object sender, EventArgs e)
        {
            /*ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = fnt.Color;*/
        }

        private void tlsbExit_Click(object sender, EventArgs e)
        {
            /*if (cambiosRealizados)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    guardarComoToolStripMenuItem_Click(sender, e);
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }*/
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}