using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaColeções
{
    public partial class Form1 : Form
    {
        List<Cachorro> Canil = new List<Cachorro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void butAdicionar_Click(object sender, EventArgs e)
        {
            Cachorro c = new Cachorro();

            c.Nome = txbNome.Text;
            c.DataNasc = dtpDataNascimento.Text;

            if (rbtSimPedigree.Checked) c.Pedigree = true;
            else c.Pedigree = false;


            Canil.Add(c);

            dgvCanil.DataSource = null;
            dgvCanil.DataSource = Canil;
        }

        private void butRemover_Click(object sender, EventArgs e)
        {
            Cachorro c = (Cachorro)dgvCanil.SelectedRows[0].DataBoundItem;

            Canil.Remove(c);

            dgvCanil.DataSource = null;
            dgvCanil.DataSource = Canil;
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            Cachorro c = (Cachorro)dgvCanil.SelectedRows[0].DataBoundItem;

            butAdicionar.Text = "Atualizar";
            Canil.Remove(c);

            txbNome.Text = c.Nome;
            dtpDataNascimento.Text = c.DataNasc;

            if (c.Pedigree) rbtSimPedigree.Checked = true;
            else rbtSimPedigree.Checked = false;
        }
    }
}
