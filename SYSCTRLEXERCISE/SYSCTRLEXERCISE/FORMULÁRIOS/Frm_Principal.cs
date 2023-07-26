using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCtrlExercise
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)  //sai ao apertar botão sair
        {
            Application.Exit();
        }

        private void tm_Principal_Tick(object sender, EventArgs e)  //programando o time por DateTime
        {
            tsslb_Data.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            tsslb_Hora.Text = DateTime.Now.Date.ToString("HH:mm:ss");
        }

        private void aparelhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Aparelho obj_Frm_Aparelho = new Frm_Aparelho();
            obj_Frm_Aparelho.ShowDialog();
        }
        private void convênioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Convenio obj_Frm_Convenio = new Frm_Convenio();
            obj_Frm_Convenio.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Cliente obj_Frm_Pessoa = new Frm_Cliente();
            obj_Frm_Pessoa.ShowDialog();
        }

        private void instrutorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Cliente obj_Frm_Pessoa = new Frm_Cliente();
            obj_Frm_Pessoa.ShowDialog();
        }
    }
}
