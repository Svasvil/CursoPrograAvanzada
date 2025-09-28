using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_1_CalculadoraSemana1
{
    public partial class Form1 : Form
    {

        int Num1 = 0;
        int Num2 = 0;
        int Resultado = 0;
        string Operacion = string.Empty; //Vaciamos la variable operacion mediante el String.Empty , tambien se puede hacer meidante con vacio "".


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "1"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "1"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "3"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "3"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "6"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "6"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }

        

        private void button10_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "0"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "0"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }

        private void BTN_Menos_Click(object sender, EventArgs e)
        {
            Operacion = "-"; //Asignamos el valor "Suma" a la variable operacion
            Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            TxT_Resultados.Text = string.Empty; //Vaciamos el TextBox
        }

        private void BTN_equal_Click(object sender, EventArgs e)
        {
            switch (Operacion)
            {
                case "+":
                    suma();
                    break;
                case "-":
                    Resta();
                    break;
                case "*":
                    Multiplicacion();
                    break;
                case "/":
                    Resultado = Num1 / Num2;
                    break;
            }
        }

        private void suma()
        {
            Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2   
            Resultado = Num1 + Num2; //Realizamos la operacion de suma y la guardamos en la variable Resultado
            TxT_Resultados.Text = Resultado.ToString(); //Convertimos el resultado a string y lo mostramos en el TextBox
        }

        private void Resta()
        {
            Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2   
            Resultado = Num1-Num2; //Realizamos la operacion de suma y la guardamos en la variable Resultado
            TxT_Resultados.Text = Resultado.ToString(); //Convertimos el resultado a string y lo mostramos en el TextBox
        }


        private void Multiplicacion()
        {
            Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2   
            Resultado = Num1 * Num2; //Realizamos la operacion de suma y la guardamos en la variable Resultado
            TxT_Resultados.Text = Resultado.ToString(); //Convertimos el resultado a string y lo mostramos en el TextBox
        }



        private void BTN_7_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "7"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "7"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }

        private void BTN_plus_Click(object sender, EventArgs e)
        {
            Operacion = "+"; //Asignamos el valor "Suma" a la variable operacion
            Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            TxT_Resultados.Text = string.Empty; //Vaciamos el TextBox

        }

        private void BTN_POr_Click(object sender, EventArgs e)
        {
            Operacion ="*"; //Asignamos el valor "Suma" a la variable operacion
            Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            TxT_Resultados.Text = string.Empty; //Vaciamos el TextBox
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "2"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "2"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "4"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "4"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "5"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "5"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "8"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "8"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            if (Operacion == string.Empty) //Si la variable operacion esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text = "9"; //Concatenamos el numero 1 al TextBox
                Num1 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num1
            }
            else //Si la variable operacion no esta vacia , entonces se ejecuta el siguiente codigo.
            {
                TxT_Resultados.Text = TxT_Resultados.Text + "9"; //Concatenamos el numero 1 al TextBox
                Num2 = int.Parse(TxT_Resultados.Text); //Convertimos el texto del TextBox a entero y lo guardamos en la variable Num2
            }
        }
    }
    }


    
       
