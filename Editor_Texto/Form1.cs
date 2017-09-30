using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            look_for();
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void salvar()
        {
            //String conteudo = textBox1.Text;
            StreamWriter conteudo = new StreamWriter(textBox1.Text);
            SaveFileDialog salve = new SaveFileDialog();
            salve.Filter = "texto |*.txt";
            salve.Title = "Escolha o lugar para salvar seu arquivo.";
            salve.FileName = ".css";
            
            salve.ShowDialog();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvar();
        }

        public void look_for()
        {
            if (textBox1.Text.Contains("html"))
            {
                
                /* String palavra01 = "html";
                this.textBox1.BackColor = Color.DarkRed;
               // Color.Red.ToString("html");*/
               

            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            look_for();
        }
        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if 
        }


    }
}
