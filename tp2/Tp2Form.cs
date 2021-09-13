using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace tp2
{
    public partial class Tp2Form : Form
    {
        public Tp2Form()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ResolverBton_Click(object sender, EventArgs e)
        {
            int Valor1 = 0, Valor2 = 0, Resultado = 0;
            try
            {
                Valor1 = int.Parse(IngresarValorTxt.Text);
                Valor2 = int.Parse(Valor2Txt.Text);
                Resultado = Valor1 / Valor2;


            }

            catch (DivideByZeroException x)
            {
                MessageBox.Show("ERROR: ¡No se puede dividir por cero!  ", x.Message);
            }
            catch (System.FormatException i)
            {
                MessageBox.Show("ERROR:  ¡El formato no es valido, ingrese un número!", i.Message);
            }
            finally
            {
                MessageBox.Show("Finalizó el proceso", "Finalización");

            }
        }

        private void IngresarValorTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor2Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resolver2Bton_Click(object sender, EventArgs e)
        {
            float Valor3 = 0, Valor4 = 0, Resultado2 = 0;
            try
            {                                
                Valor3 = float.Parse(Valor3Txt.Text);
                Valor4 = float.Parse(Valor4Txt.Text);
                if (Valor4 == 0)
                {
                    throw new DivideByZeroException();
                }
            
                Resultado2 = Valor3 / Valor4;
                MessageBox.Show($"El resultado de la división es: {Resultado2} ", "Resultado");

            }
            catch (DivideByZeroException x)
            {
                MessageBox.Show("Solo Chuck Norris divide por cero!", x.Message);
            }
            catch (System.FormatException i)
            {
                MessageBox.Show("Seguro Ingreso una letra o no ingreso nada!!", i.Message);
            }
            finally
            {
                MessageBox.Show("Finalizó el proceso", "Finalización");
            }
        }

        private void ResultadoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resolver3Bton_Click(object sender, EventArgs e)
        {
            try
            {
                float Num1 = float.Parse(Valor5Txt.Text);
                float Num2 = float.Parse(Valor6Txt.Text);
                float resultado = Logic.Dividir(Num1, Num2);
                MessageBox.Show($"El resultado es : {resultado}","Resultado" );
            } 
            catch (DivideByZeroException x)
            {
                MessageBox.Show(x.Message, "Excepción de tipo DivideByZeroException");
            }
            catch (System.FormatException i)
            {
                MessageBox.Show(i.Message, "Debe ingresar un número");
            }
            finally
            {
                MessageBox.Show("Finalizó el proceso", "Finalización");
            }

        }

        private void MultiplicLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Logic.ValidarVocal(VocalTxt.Text))
                    ExceptionTxt.Text="Correcto!";
            }
            catch(MyException x)
            {
                ExceptionTxt.Text = x.Message;
            }
        }
    }
}
