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
    public partial class LOGIN_USER : Form
    {
        private Dictionary<string, string> usuariosSenhas = new Dictionary<string, string>
        {
            {"EDVAM", "123456"},
            {"THAIS", "docinho"}
        };

        private bool mostrarSenha = false;

        public LOGIN_USER()
        {
            InitializeComponent();

            // Define a escala de DPI para 100% (escala normal)
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // Define a fonte "Microsoft Sans Serif" sem alterar o tamanho
            Font currentFont = this.Font;
            this.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            ck_senha.CheckedChanged += checkBoxMostrarSenha_CheckedChanged;
            txt_senha.KeyPress += txt_senha_KeyPress;
            txt_senha.UseSystemPasswordChar = true;

            txt_user.KeyPress += txt_user_KeyPress; // Capturar pressionamento da tecla Enter no campo de usuário
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        private void RealizarLogin()
        {
            string usuario = txt_user.Text.ToUpper(); // Converter para maiúsculas
            string senha = txt_senha.Text;

            if (usuariosSenhas.ContainsKey(usuario) && usuariosSenhas[usuario] == senha)
            {
                MessageBox.Show($"Bem-vindo, {usuario}!");

                this.Hide(); // Ocultar a janela de login

                MENU_PRINCIPAL menuPrincipal = new MENU_PRINCIPAL();
                menuPrincipal.Closed += (s, args) => this.Close(); // Fechar aplicação quando fechar a janela principal
                menuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos.");
            }
        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            mostrarSenha = ck_senha.Checked;
            txt_senha.UseSystemPasswordChar = !mostrarSenha;
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Verificar se a tecla pressionada é Enter
            {
                RealizarLogin();
                e.Handled = true; // Impedir que o caractere Enter seja inserido no campo de senha
            }
            else
            {
                txt_senha.UseSystemPasswordChar = !mostrarSenha;
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Verificar se a tecla pressionada é Enter
            {
                txt_senha.Focus(); // Mover o foco para o campo de senha
                e.Handled = true; // Impedir que o caractere Enter seja inserido no campo de usuário
            }
        }

        private void ck_senha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_USER_Load(object sender, EventArgs e)
        {

        }
    }
}