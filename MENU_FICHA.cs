using System;
using System.IO;
using Xceed.Words.NET;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Drawing;
using static Sistema_Gestao.MENU_CADASTRO;
using System.Diagnostics;

namespace Sistema_Gestao
{
    public partial class MENU_FICHA : Form
    {
        public MENU_FICHA()
        {
            InitializeComponent();

            // Acesso ao DataSet compartilhado
            DB_DADOSDataSet dS = SharedDataSet.DataSet;

            // Acesso ao TableAdapter compartilhado
            DB_DADOSDataSetTableAdapters.DADOS_GERALTableAdapter tableAdapter = SharedDataSet.DADOS_GERALTableAdapter;

            // Define a escala de DPI para 100% (escala normal)
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // Define a fonte "Microsoft Sans Serif" sem alterar o tamanho
            System.Drawing.Font currentFont = this.Font;
            this.Font = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string originalFilePath;

                if (radioButton1.Checked) // Logistica
                {
                    originalFilePath = @"C:\Users\edvam\OneDrive\Documentos\Teste\NovaFicha - Logistica.docx";
                }
                else if (radioButton2.Checked) // Escritorio
                {
                    originalFilePath = @"C:\Users\edvam\OneDrive\Documentos\Teste\NovaFicha - Escritorio.docx";
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma opção (Logistica ou Escritorio) antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (DocX doc = DocX.Load(originalFilePath))
                {
                    ReplaceTagsWithTextInTable(doc, "#NOMECOMPLETO", txt_nome.Text);
                    ReplaceTagsWithTextInTable(doc, "#SETOR", txt_setor.Text);
                    ReplaceTagsWithTextInTable(doc, "#CARGO", txt_cargo.Text);
                    ReplaceTagsWithTextInTable(doc, "#CPF", txt_cpf.Text);
                    ReplaceTagsWithTextInTable(doc, "#RG", txt_rg.Text);
                    ReplaceTagsWithTextInTable(doc, "#ADMIS", txt_adm.Text);

                    // Salva o documento modificado em formato .docx
                    string newFilePathDocx = Path.Combine(Path.GetDirectoryName(originalFilePath), $"{txt_nome.Text.ToUpper()}_MODIFICADO.docx");
                    doc.SaveAs(newFilePathDocx);

                    // Use o Microsoft Word para salvar o documento como PDF
                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Document wordDoc = wordApp.Documents.Open(newFilePathDocx);

                    string newFilePathPdf = Path.Combine(Path.GetDirectoryName(originalFilePath), $"{txt_nome.Text.ToUpper()}_MODIFICADO.pdf");
                    wordDoc.SaveAs2(newFilePathPdf, WdSaveFormat.wdFormatPDF);

                    wordDoc.Close();
                    wordApp.Quit();
                }

                MessageBox.Show("Substituições concluídas e documento PDF criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplaceTagsWithTextInTable(DocX doc, string tag, string newText)
        {
            foreach (var table in doc.Tables)
            {
                foreach (var row in table.Rows)
                {
                    foreach (var cell in row.Cells)
                    {
                        string text = cell.Paragraphs[0].Text;
                        if (text.Contains(tag))
                        {
                            text = text.Replace(tag, newText);
                            cell.Paragraphs[0].ReplaceText(tag, newText);
                        }
                    }
                }
            }
        }

        private void MENU_FICHA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_DADOSDataSet.DADOS_GERAL'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_GERALTableAdapter.Fill(this.dB_DADOSDataSet.DADOS_GERAL);
            // Código de inicialização, se necessário
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Evento de clique do rótulo, se necessário
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento de clique do rótulo, se necessário
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Evento de clique do rótulo, se necessário
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Evento de clique do grupo, se necessário
        }

        private void DADOS_Enter(object sender, EventArgs e)
        {

        }

        private void dADOSGERALBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar o formulário MENU_PRINCIPAL

            MENU_PRINCIPAL menuFicha = new MENU_PRINCIPAL();
            menuFicha.Closed += (s, args) => this.Close(); // Fechar a aplicação quando fechar o formulário MENU_FICHA
            menuFicha.Show();



        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide(); // Ocultar o formulário MENU_PRINCIPAL

            MENU_CADASTRO menuFicha = new MENU_CADASTRO();
            menuFicha.Closed += (s, args) => this.Close(); // Fechar a aplicação quando fechar o formulário MENU_FICHA
            menuFicha.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Caminho que você deseja abrir no Explorador de Arquivos
            string caminho = @"C:\Users\edvam\OneDrive\Documentos\Teste";

            // Abre o Explorador de Arquivos no caminho especificado
            Process.Start("explorer.exe", caminho);

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}