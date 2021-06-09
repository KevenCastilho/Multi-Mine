using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Multi_Mine
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            string DiretorioAtual = Directory.GetCurrentDirectory();
            string PastaMinecraft = DiretorioAtual + "\\suas_ponto_minecraft\\";
            if (!Directory.Exists(PastaMinecraft))
            {
                Directory.CreateDirectory(PastaMinecraft);
            }
            DirectoryInfo pasta = new DirectoryInfo(PastaMinecraft);
            DirectoryInfo[] subPasta = pasta.GetDirectories();

            foreach (DirectoryInfo dir in subPasta)
            {
                cbPastas.Items.Add(dir.Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DiretorioAtual = Directory.GetCurrentDirectory();
            string PastaMinecraft = DiretorioAtual + "\\suas_ponto_minecraft\\";
            if (!Directory.Exists(PastaMinecraft))
            {
                Directory.CreateDirectory(PastaMinecraft);
            }
            DirectoryInfo pasta = new DirectoryInfo(PastaMinecraft);
            DirectoryInfo[] subPasta = pasta.GetDirectories();

            foreach (DirectoryInfo dir in subPasta)
            {
                cbPastas.Items.Add(dir.Name);
            }
        }

        private void cbPastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ItemSelecionado = cbPastas.SelectedItem.ToString();
            string DiretorioAtual = Directory.GetCurrentDirectory();
            DirectoryInfo PastaItemSelecionado = new DirectoryInfo(ItemSelecionado);
            lblNome.Text = PastaItemSelecionado.Name;
            lblCriadoEm.Text = PastaItemSelecionado.CreationTime.ToString();
            lblCaminho.MaximumSize = new Size(212, 60);
            lblCaminho.AutoSize = true;
            lblCaminho.Text = PastaItemSelecionado.FullName;
            if(!File.Exists(DiretorioAtual + "\\suas_ponto_minecraft\\" + cbPastas.SelectedItem.ToString() + "\\mine.jpg"))
            {
                pbMinePack.Image = Properties.Resources.none;
            } else
            {
                pbMinePack.Load(DiretorioAtual + "\\suas_ponto_minecraft\\" + cbPastas.SelectedItem.ToString() + "\\mine.jpg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string DiretorioAtual = Directory.GetCurrentDirectory();
            string ItemSelecionado = cbPastas.SelectedItem.ToString();
            if (!File.Exists(DiretorioAtual + "\\suas_ponto_minecraft\\" + ItemSelecionado + "mine.exe"))
            {
                MessageBox.Show("Launcher (mine.exe) Não Encontrado!", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StreamWriter temp_bat = new StreamWriter("temp.cmd", true, Encoding.ASCII);
            temp_bat.WriteLine("cd " + DiretorioAtual + "\n\r");
            temp_bat.WriteLine("cd minecraft \n\r");
            temp_bat.WriteLine("set APPDATA=.\\\n\r");
            temp_bat.WriteLine("cd " + ItemSelecionado + "\n\r");
            temp_bat.WriteLine("start mine.exe\n\r");
            temp_bat.Close();
            ProcessStartInfo temp = new ProcessStartInfo("temp.cmd");
            temp.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(temp).WaitForExit();
            File.Delete("temp.cmd");
        }
    }
}
