using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaDeCaes.WinApp
{
    public partial class FormApostas : Form
    {
        private Guy[] ArrayGuy = new Guy[3];
        private Greyhound[] ArrayGreygound = new Greyhound[4];
        private int guySelected;
        public FormApostas()
        {
            InitializeComponent();

            //Inicializar o array com os apostadores
            ArrayGuy[0] = new Guy("João", 50, radioJoao, lblJoao);
            ArrayGuy[1] = new Guy("Beto", 75, radioBeto, lblBeto);
            ArrayGuy[2] = new Guy("Alfredo", 45, radioAlfredo, lblAlfredo);

            //Inicializar o Array com as rais de corrida
            ArrayGreygound[0] = new Greyhound(picBDog1, picBPista.Width);
            ArrayGreygound[1] = new Greyhound(picBDog2, picBPista.Width);
            ArrayGreygound[2] = new Greyhound(picBDog3, picBPista.Width);
            ArrayGreygound[3] = new Greyhound(picBDog4, picBPista.Width);

        }

        private void radioAlfredo_CheckedChanged(object sender, EventArgs e)
        {
            guySelected = 3;
            EnableBet();
        }

        private void radioBeto_CheckedChanged(object sender, EventArgs e)
        {
            guySelected = 2;
            EnableBet();
        }

        private void radioJoao_CheckedChanged(object sender, EventArgs e)
        {
            guySelected = 1;
            EnableBet();
        }
        private void EnableBet()
        {
            switch (guySelected)
            {
                case 1:
                    lblSelectedGuy.Text = "João";
                    break;
                case 2:
                    lblSelectedGuy.Text = "Beto";
                    break;
                case 3:
                    lblSelectedGuy.Text = "Alfredo";
                    break;
                default:
                    break;
            }

        }

        private void btnAposta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
                return;

            switch (guySelected)
            {
                case 1:
                    if (!ArrayGuy[0].PlaceBet(int.Parse(txtValor.Text), int.Parse(txtCao.Text)))
                    {
                        ExibirMessageBox(ArrayGuy[0].Name + " não possui dinheiro suficiente", "Atenção");
                        LimparCampos();
                    }
                    break;
                case 2:
                    if (!ArrayGuy[1].PlaceBet(int.Parse(txtValor.Text), int.Parse(txtCao.Text)))
                    {
                        ExibirMessageBox(ArrayGuy[1].Name + " não possui dinheiro suficiente", "Atenção");
                        LimparCampos();
                    }
                    break;
                case 3:
                    if (!ArrayGuy[2].PlaceBet(int.Parse(txtValor.Text), int.Parse(txtCao.Text)))
                    {
                        ExibirMessageBox(ArrayGuy[2].Name + " não possui dinheiro suficiente", "Atenção");
                        LimparCampos();
                    }
                    break;
                default:
                    break;
            }
        }

        private void LimparCampos()
        {
            txtCao.Text = "";
            txtValor.Text = "";
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtValor.Text) || string.IsNullOrEmpty(txtCao.Text))
            {
                ExibirMessageBox("Os campos não podem estar em branco!", "Erro");
                return false;
            }
            int valor, cao;
            if (!int.TryParse(txtCao.Text, out cao) || !int.TryParse(txtValor.Text, out valor))
            {
                ExibirMessageBox("Insira somente numeros!", "Erro");
                return false;
            }

            if (valor < 5)
            {
                ExibirMessageBox("Aposta minima é 5 Reais!", "Erro");
                return false;
            }

            if (cao < 1 || cao > 4)
            {
                ExibirMessageBox("Escolha um cão entre 1 e 4!", "Erro");
                return false;
            }

            return true;
        }

        private void ExibirMessageBox(string texto, string title = "")
        {
            MessageBox.Show(texto, title);
        }
        private void btnCorrer_Click(object sender, EventArgs e)
        {
            ReiniciarCorrida();
            if (!ValidarApostas())
            {
                ExibirMessageBox("É necessário no mínimo uma aposta para iniciar a corrida!", "Atenção");
                return;
            }

            ModificarLabels(false);
            while (true)
            {
                for (int i = 0; i < 4; i++)
                {
                    System.Threading.Thread.Sleep(200);
                    if (ArrayGreygound[i].Run())
                    {
                        int value = i + 1;
                        ExecutarTransacoes(value);
                        ExibirMessageBox("Temos um vencedor: cão numero " + value + "!", "Incrível");
                        ModificarLabels(true);
                        return;
                    }
                }
            }
        }

        private bool ValidarApostas()
        {
            for (int i = 0; i < ArrayGuy.Length; i++)
            {
                if (ArrayGuy[i].MyBet.Amount != 0)
                    return true;
            }

            return false;
        }

        private void ExecutarTransacoes(int winner)
        {
            for (int i = 0; i < ArrayGuy.Length; i++)
            {
                ArrayGuy[i].Collect(winner);
            }
        }
        private void ReiniciarCorrida()
        {
            for (int i = 0; i < ArrayGreygound.Length; i++)
            {
                ArrayGreygound[i].TakeStartPosition();
            }
        }
        private void ModificarLabels(bool acao)
        {
            btnAposta.Enabled = acao;
            btnCorrer.Enabled = acao;
            radioJoao.Enabled = acao;
            radioBeto.Enabled = acao;
            radioAlfredo.Enabled = acao;
            txtValor.Enabled = acao;
            txtCao.Enabled = acao;
            btnReiniciar.Enabled = acao;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarCorrida();
        }

        private void picBDog1_Click(object sender, EventArgs e)
        {
            txtCao.Text = "1";
        }

        private void picBDog2_Click(object sender, EventArgs e)
        {
            txtCao.Text = "2";
        }

        private void picBDog3_Click(object sender, EventArgs e)
        {
            txtCao.Text = "3";
        }

        private void picBDog4_Click(object sender, EventArgs e)
        {
            txtCao.Text = "4";
        }
    }
}
