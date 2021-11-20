using _3C1LUCAS26.bll;
using _3C1LUCAS26.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1LUCAS26
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        Produtobll produtoBLL = new Produtobll();
        Produtodto produtodto = new Produtodto();
        
        private void Form2_Load(object sender, EventArgs e)
        {
            dtgView.DataSource = produtoBLL.Listar();
        }

        private void dtgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbarras.Text = dtgView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dtgView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPreco.Text = dtgView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtquant.Text = dtgView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void bntCad_Click(object sender, EventArgs e)
        {
            produtodto.Codg_barras = int.Parse(txtbarras.Text);
            produtodto.Preco = double.Parse(txtPreco.Text);
            produtodto.Nome = txtnome.Text;
            produtodto.Quantidade = int.Parse(txtquant.Text);
            produtoBLL.Inserir(produtodto);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            produtodto.Codg_barras = int.Parse(txtbarras.Text);
            produtoBLL.excluir(produtodto);
            produtoBLL.Listar();
        }
    }
}
