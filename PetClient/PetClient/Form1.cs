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
using System.Globalization;
using System.Net.Mail;

namespace PetClient
{
    public partial class FrmPrincipal : Form
    {
                
        #region Inicialização
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Variáveis Globais
        static string[,] corredor = new string[1, 30]
        {
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
        };

        int posColuna = 1;

        int contador = 0;

        double preco = 0;

        double quantidade = 0;

        double total = 0;

        double contadordeprodutos = 0;

        double totaldinheiro = 0;

        double totalcartaoEpix = 0;

        string FormaDePagamento;

        #endregion

        #region Timer Animação do Avatar
        private void TmrAnimacaoAvatar_Tick(object sender, EventArgs e)
        {
            int x = PctBxAvatar.Location.X;
            int y = PctBxAvatar.Location.Y;

            if(contador <= 33 && contador % 2 == 0)
            {
                PctBxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Run1.png");
                PctBxAvatar.Location = new Point(x + 20, y);
                posColuna++;contador++;

            }
            else if (contador <= 33 && contador % 2 != 0)
            {
                PctBxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Run2.png");
                PctBxAvatar.Location = new Point(x + 20, y);
                posColuna++; contador++;
            }
            else if (contador == 34 )
            {
                PctBxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Dead.png");
                PctBxAvatar.Location = new Point(x + 20, y);
                posColuna++; contador++;
            }
            else if (contador == 35)
            {
                PctBxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Dead2.png");
                PctBxAvatar.Location = new Point(x + 20, y);
                posColuna++; contador++;
            }

            else if(contador == 36)
            {
                PctBxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Dead3.png");
                PctBxAvatar.Location = new Point(x + 20, y);
                posColuna++; contador++;
            }
            else
            {
                PctBxAvatar.Location = new Point(12, 366);
                PctBxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Frontal.png");
                posColuna = 1;contador = 0;
            }
        }
        #endregion

        #region Validando, Evento KeyPress Numeros
        private void VerificaNumeros(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || (e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 44)
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region Validando, Evento KeyPress caracteres
        private void VerificaCaracteres(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 32 || (e.KeyChar > 64 && e.KeyChar < 91) || (e.KeyChar > 96 && e.KeyChar < 123))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region Evento Form Closing
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja sair ?", "Encerrando o Programa...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
                    
        }
        #endregion

        #region Botão Salvar
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TxtBxProduto.Text.Length > 0 && TxtBxPreco.Text.Length > 0 && TxtBxQtd.Text.Length > 0 && (ckBxCartao.Checked == true ||
                ckBxDinheiro.Checked == true))
            {
                preco = Convert.ToDouble(TxtBxPreco.Text);
                quantidade = Convert.ToDouble(TxtBxQtd.Text);

                DtGrdViewTabelaDeProdutos.Enabled = true;

                DataRow novalinha = DataSetTabelaDeProdutos.Tables["TabelaDeProdutos"].NewRow();

                novalinha["NomeDoProduto"] = TxtBxProduto.Text.ToString();
                novalinha["Preco"] = TxtBxPreco.Text.ToString();
                novalinha["Quantidade"] = TxtBxQtd.Text.ToString();
                if (ckBxDinheiro.Checked == true)
                {
                    novalinha["Pagamento"] = ("Dinheiro");
                    totaldinheiro += preco * quantidade;
                    FormaDePagamento = "Dinheiro";
                }
                else
                {
                    novalinha["Pagamento"] = ("Cartão/PIX");
                    totalcartaoEpix += preco * quantidade;
                    FormaDePagamento = "Cartão/PIX";
                }

                DataSetTabelaDeProdutos.Tables[0].Rows.Add(novalinha);

                total += preco * quantidade;
                TxtBxTotal.Text = total.ToString();

                contadordeprodutos += quantidade;
                TxtBxContadorDeProdutos.ForeColor = Color.Green;
                TxtBxContadorDeProdutos.Text = contadordeprodutos.ToString();

                EmailEnviar();

                TxtBxProduto.Clear();
                TxtBxPreco.Clear();
                TxtBxQtd.Clear();
                ckBxDinheiro.Checked = false;
                ckBxCartao.Checked = false;
                FormaDePagamento = "";

                DtGrdViewTabelaDeProdutos.Enabled = false;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de salvar !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Function to send the email
        private void EmailEnviar()
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential("botbillnutripets@gmail.com", "Senha");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        email.From = new MailAddress("botbillnutripets@gmail.com");
                        email.To.Add("devmateussnr@gmail.com");
                        //email.To.Add("fenutrisaudavel@gmail.com");

                        email.Subject = ("Nova venda cadastrada com sucesso!!");
                        email.IsBodyHtml = false;
                        email.Body = ("Informações sobre o nova venda cadastrada: \n" + "Nome do produto: " + TxtBxProduto.Text.ToString() + ("\n") +
                            "Preço: " + TxtBxPreco.Text.ToString() + ("\n") +
                            "Quantidade: " + TxtBxQtd.Text.ToString() + ("\n") +
                            "Forma de pagamento: " + FormaDePagamento + ("\n") +
                            "Total em vendas até o momento: " + total.ToString("F2"));

                        smtp.Send(email);
                    }
                }
            }
            catch
            {

            }
        }
        #endregion

        #region Filtro
        private void TxtBxFiltro_TextChanged(object sender, EventArgs e)
        {
            switch (CmbBoxProdutos.Text)
            {
                case "NomeDoProduto":
                    BndSourceTabelaDeProdutos.Filter = "NomeDoProduto like '%" + TxtBxFiltro.Text + "%'";
                    break;
                case "Preco":
                    BndSourceTabelaDeProdutos.Filter = "Preco like '%" + TxtBxFiltro.Text + "%'";
                    break;
                case "Quantidade":
                    BndSourceTabelaDeProdutos.Filter = "Quantidade like '%" + TxtBxFiltro.Text + "%'";
                    break;
                case "Pagamento":
                    BndSourceTabelaDeProdutos.Filter = "Pagamento like '%" + TxtBxFiltro.Text + "%'";
                    break;
                default:
                    TxtBxFiltro.Clear();
                    MessageBox.Show("Escolha uma opção...","Erro!");
                    break;
            }
        }
        #endregion

        #region Exportar Arquivo
        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < DataSetTabelaDeProdutos.Tables["TabelaDeProdutos"].Rows.Count; i++)
                {
                    string nomeDoProduto = DtGrdViewTabelaDeProdutos.Rows[i].Cells[0].Value.ToString();
                    string precoDoProduto = DtGrdViewTabelaDeProdutos.Rows[i].Cells[1].Value.ToString();
                    string quantidadeDeProdutos = DtGrdViewTabelaDeProdutos.Rows[i].Cells[2].Value.ToString();
                    string metodoDePagamento = DtGrdViewTabelaDeProdutos.Rows[i].Cells[3].Value.ToString();
                    SW.WriteLine();
                    SW.WriteLine(nomeDoProduto + "|" + precoDoProduto + "|" + quantidadeDeProdutos + "|" + metodoDePagamento);
                }
                SW.WriteLine();
                SW.WriteLine("Total : " + total.ToString("F2") + ("\n") + "Quantidade de Produtos vendidos: " + contadordeprodutos);
                SW.WriteLine("Total em dinheiro : " + totaldinheiro.ToString("F2"));
                SW.WriteLine("Total em cartão e pix : " + totalcartaoEpix.ToString("F2"));
                SW.Dispose();
            }
        }
        #endregion
    }
}
