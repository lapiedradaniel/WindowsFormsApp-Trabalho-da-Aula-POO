using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp_Trabalho_da_Aula_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Jogador obj;
        Jogador[] v=new Jogador[5];
        int i =0;

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                obj = new Jogador();
                obj.Nome = txtNome.Text;
                obj.Peso = double.Parse(txtPeso.Text);
                obj.Altura = double.Parse(txtAltura.Text);
                obj.Idade = int.Parse(txtIdade.Text);
                obj.Time = txtTime.Text;
                obj.Numero_Camisa = int.Parse(txtnumCamisa.Text);
                v[i] = obj;
                i++;
            }
            else
            {
                MessageBox.Show("Não é possivel gravar");
            }


            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 5; j++)
            {
                if (v[j].Nome.Equals(txtNome.Text))
                {
                    txtPeso.Text = v[j].Peso.ToString();
                    txtAltura.Text = v[j].Altura.ToString();
                    txtIdade.Text = v[j].Idade.ToString();
                    txtTime.Text = v[j].Time.ToString();
                    txtnumCamisa.Text = v[j].Numero_Camisa.ToString();

                    j = 4;

                }
                else
                {
                    if (j == 4) MessageBox.Show("Time não encontrado");
                }
            }




        }
    }
}
