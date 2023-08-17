using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestao
{
    public partial class MENU_PRINCIPAL : Form
    {
        public MENU_PRINCIPAL()
        {
            InitializeComponent();

            // Define a escala de DPI para 100% (escala normal)
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // Define a fonte "Microsoft Sans Serif" sem alterar o tamanho
            Font currentFont = this.Font;
            this.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));


        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide(); // Ocultar o formulário MENU_PRINCIPAL

            MENU_FICHA menuFicha = new MENU_FICHA();
            menuFicha.Closed += (s, args) => this.Close(); // Fechar a aplicação quando fechar o formulário MENU_FICHA
            menuFicha.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar o formulário MENU_PRINCIPAL

            MENU_CADASTRO menuFicha = new MENU_CADASTRO();
            menuFicha.Closed += (s, args) => this.Close(); // Fechar a aplicação quando fechar o formulário MENU_FICHA
            menuFicha.Show();
        }

        private void MENU_PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            this.Hide(); // Ocultar o formulário MENU_PRINCIPAL

            MENU_RECIBOS menuFicha = new MENU_RECIBOS();
            menuFicha.Closed += (s, args) => this.Close(); // Fechar a aplicação quando fechar o formulário MENU_FICHA
            menuFicha.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide(); // Ocultar o formulário MENU_PRINCIPAL

            MENU_NR01_OBRA menuFicha = new MENU_NR01_OBRA();
            menuFicha.Closed += (s, args) => this.Close(); // Fechar a aplicação quando fechar o formulário MENU_FICHA
            menuFicha.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
