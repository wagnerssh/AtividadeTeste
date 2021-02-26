using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TesteGFT.Categoria;
using TesteGFT.Negocios;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TesteGFT
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }
        public class Pessoa
        {
            public Pessoa() { }

            public string Nome { get; set; }
            public int Idade { get; set; }

            public Pessoa(int idade, string nome)
            {
                this.Idade = idade;
                this.Nome = nome;
            }
        }

        public class Trader
        {
            public Trader() { }

            //public int Id { get; set; }
            public string Nome { get; set; }

            public Trader(string Nome)
            {
                //this.Id = Id;
                this.Nome = Nome;
            }

        }

    private void button1_Click(object sender, EventArgs e)
        {
            var valor = TraderBox1.Text;
            var vale = Convert.ToDouble(ValorBox1.Text);

            List<INegociar> port;
            List<string> tradeCategories;

            Negociar negocio1 = new Negociar { Valores = vale, Clientes = valor, Calculado = ""}; 
            //Negociar negocio2 = new Negociar { Valores = vale, Clientes = "Public"  , Calculado = "" };
            //Negociar negocio3 = new Negociar { Valores = vale, Clientes = "Public"  , Calculado = "" };
            //Negociar negocio4 = new Negociar { Valores = vale, Clientes = "Public"  , Calculado = "" };



            port = new List<INegociar> { negocio1 };

            tradeCategories = new Categorias(port).GetCategorias();

            //string Trade = negocio1 ;

            foreach (INegociar negociar in port)
            {
                
      
                    MessageBox.Show(negociar.Valores + ", "+ negociar.Clientes + ", " + negociar.Calculado );
           
            }

        }


        private void  comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
