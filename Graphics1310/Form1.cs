using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics1310
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pizza_Click(object sender, EventArgs e)
        {

            int humanas = int.Parse(ValorHumanas.Text);
            int exatas = int.Parse(ValorExatas.Text);
            int biologicas = int.Parse(ValorBiologicas.Text);
            int agrarias = int.Parse(ValorAgrarias.Text);

            float qtdtotal = humanas + exatas + biologicas + agrarias;

            Graphics formulario = CreateGraphics();
            GraficoPizza graficopizza = new GraficoPizza();
            graficopizza.Desenha(formulario, humanas, exatas, biologicas, agrarias);

            float pcth, pctex, pctb, pctag;

            pcth = (humanas / qtdtotal) * 100;
            pctex = (exatas / qtdtotal) * 100;
            pctb = (biologicas / qtdtotal) * 100;
            pctag = (agrarias / qtdtotal) * 100;

            pctH.Text = pcth.ToString() + "%" + " de Alunos ";
            pctEx.Text = pctex.ToString() + "%" + " de  Alunos ";
            PctB.Text = pctb.ToString() + "%" + " de Alunos ";
            PctAg.Text = pctag.ToString() + "%" + " de Alunos ";
               

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Coluna_Click(object sender, EventArgs e)
        {
            int humanas = int.Parse(ValorHumanas.Text);
            int exatas = int.Parse(ValorExatas.Text);
            int biologicas = int.Parse(ValorBiologicas.Text);
            int agrarias = int.Parse(ValorAgrarias.Text);

            Graphics formulario = CreateGraphics();
            GraficoColuna graficocoluna = new GraficoColuna();
            graficocoluna.DesenhaColuna(formulario, humanas, exatas, biologicas, agrarias);
        }
    }
}
