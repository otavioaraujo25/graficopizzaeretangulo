using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Graphics1310
{
    public abstract class Grafico
    {
        public void Desenha(Graphics formulario, int humanas, int exatas, int biologicas, int agrarias)
        {
            float qtdtotal = humanas + exatas + biologicas + agrarias;
            float divpartes = 360 / qtdtotal;

            formulario.FillPie(new SolidBrush(Color.Red), 100, 30, 170, 170, 0, humanas * divpartes);
            formulario.FillPie(new SolidBrush(Color.Blue), 100, 30, 170, 170, humanas * divpartes, exatas * divpartes);
            formulario.FillPie(new SolidBrush(Color.Yellow), 100, 30, 170, 170, exatas * divpartes + humanas * divpartes, biologicas * divpartes);
            formulario.FillPie(new SolidBrush(Color.Green), 100, 30, 170, 170, biologicas * divpartes + exatas * divpartes + humanas * divpartes, agrarias * divpartes);

            formulario.DrawPie(new Pen(Color.Black), 100, 30, 170, 170, 0, humanas * divpartes);
            formulario.DrawPie(new Pen(Color.Black), 100, 30, 170, 170, humanas * divpartes, exatas * divpartes);
            formulario.DrawPie(new Pen(Color.Black), 100, 30, 170, 170, exatas * divpartes + humanas * divpartes, biologicas * divpartes);
            formulario.DrawPie(new Pen(Color.Black), 100, 30, 170, 170, biologicas * divpartes + exatas * divpartes + humanas * divpartes, agrarias * divpartes);                        

        }
    }

    public class GraficoPizza : Grafico
    {
        
    }

    public class GraficoColuna : Grafico
    {
        public void DesenhaColuna(Graphics formulario, int humanas, int exatas, int biologicas, int agrarias)
        {
           
                formulario.FillRectangle(new SolidBrush(Color.Red), 100, 400-humanas, 10, humanas);
                formulario.DrawRectangle(new Pen(Color.Black), 100, 400-humanas, 10, humanas);

                formulario.FillRectangle(new SolidBrush(Color.Blue), 125, 400-exatas, 10, exatas);
                formulario.DrawRectangle(new Pen(Color.Black), 125, 400-exatas, 10, exatas);

                formulario.FillRectangle(new SolidBrush(Color.Yellow), 150, 400-biologicas, 10, biologicas);
                formulario.DrawRectangle(new Pen(Color.Black), 150, 400-biologicas, 10, biologicas);

                formulario.FillRectangle(new SolidBrush(Color.Green), 175, 400-agrarias, 10, agrarias);
                formulario.DrawRectangle(new Pen(Color.Black), 175, 400-agrarias, 10, agrarias);
            
        }
    }


}
