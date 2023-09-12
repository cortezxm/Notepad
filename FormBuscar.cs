using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormBuscar : Form
    {
        private RichTextBox refRichTextBox;
        private int currentStartIndex = 0;
   
        public FormBuscar(RichTextBox rtb)
        {
            InitializeComponent();
            this.refRichTextBox = rtb;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            if (refRichTextBox == null || string.IsNullOrWhiteSpace(txtbBusq.Text))
                return;

            int startIndex = refRichTextBox.Find(txtbBusq.Text, currentStartIndex, RichTextBoxFinds.None);

            if (startIndex != -1)
            {
                refRichTextBox.Select(startIndex, txtbBusq.Text.Length);
                currentStartIndex = startIndex + txtbBusq.Text.Length;
                refRichTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Texto no encontrado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentStartIndex = 0; // Reset for the next search
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (currentStartIndex == 0)
                return;

            int startIndex = refRichTextBox.Find(txtbBusq.Text, 0, currentStartIndex - txtbBusq.Text.Length, RichTextBoxFinds.Reverse);

            if (startIndex != -1)
            {
                refRichTextBox.Select(startIndex, txtbBusq.Text.Length);
                currentStartIndex = startIndex;
                refRichTextBox.Focus();
            }
            else
            {
                MessageBox.Show("No más coincidencias", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            int startIndex = refRichTextBox.Find(txtbBusq.Text, currentStartIndex, RichTextBoxFinds.None);

            if (startIndex != -1)
            {
                refRichTextBox.Select(startIndex, txtbBusq.Text.Length);
                currentStartIndex = startIndex + txtbBusq.Text.Length;
                refRichTextBox.Focus();
            }
            else
            {
                MessageBox.Show("No más coincidencias", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentStartIndex = 0;
            }
        }
    }
}
