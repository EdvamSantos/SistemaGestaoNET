using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.Globalization;
using static Sistema_Gestao.MENU_CADASTRO;
using System.Diagnostics;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml;



namespace Sistema_Gestao
{
    public partial class MENU_RECIBOS : Form
    {

        public MENU_RECIBOS()
        {
            InitializeComponent();

            // Acesso ao DataSet compartilhado
            DB_DADOSDataSet dS = SharedDataSet.DataSet;

            // Acesso ao TableAdapter compartilhado
            DB_DADOSDataSetTableAdapters.DADOS_GERALTableAdapter tableAdapter = SharedDataSet.DADOS_GERALTableAdapter;

            // Associe o manipulador de eventos Leave aos controles de entrada de texto para brutos
            txt_bruto1.Leave += TextBoxValor_Leave;
            txt_bruto2.Leave += TextBoxValor_Leave;
            txt_bruto3.Leave += TextBoxValor_Leave;
            txt_bruto4.Leave += TextBoxValor_Leave;
            txt_bruto5.Leave += TextBoxValor_Leave;
            txt_bruto6.Leave += TextBoxValor_Leave;

            // Associe o manipulador de eventos Leave aos controles de entrada de texto para descontos
            txt_desconto1.Leave += TextBoxValor_Leave;
            txt_desconto2.Leave += TextBoxValor_Leave;
            txt_desconto3.Leave += TextBoxValor_Leave;
            txt_desconto4.Leave += TextBoxValor_Leave;
            txt_desconto5.Leave += TextBoxValor_Leave;
            txt_desconto6.Leave += TextBoxValor_Leave;

            // Adicionar o evento TextChanged ao TextBox de origem (txt_nome1)
            txt_nome1.TextChanged += txt_nome1_TextChanged;

            // Adicionar o evento TextChanged ao TextBox de origem (txt_rg1)
            txt_rg1.TextChanged += txt_rg1_TextChanged;

        }
        private void TextBoxValor_Leave(object sender, EventArgs e)
        {
            // Realize a formatação desejada ao sair do controle TextBox
            TextBox textBox = (TextBox)sender;

            // Remover todos os caracteres não numéricos (exceto vírgula)
            string valorSemCaracteresNaoNumericos = string.Concat(textBox.Text.Where(c => char.IsDigit(c) || c == ','));

            // Converter a string para um número decimal
            if (decimal.TryParse(valorSemCaracteresNaoNumericos, out decimal valorDecimal))
            {
                // Formatar o valor como moeda e exibir no formato desejado
                if (textBox.Text.StartsWith("R$ "))
                {
                    textBox.Text = string.Format("R$ {0:N2}", valorDecimal);
                }
                else
                {
                    textBox.Text = string.Format("R$ {0:N2}", valorDecimal);
                }
            }
            else
            {
                // Caso a conversão não seja bem-sucedida, deixar o campo em branco
                textBox.Text = string.Empty;
            }

            // Somar os valores dos campos txt_bruto1 até txt_bruto6
            decimal somaBruto = 0;
            somaBruto += GetDecimalValue(txt_bruto1);
            somaBruto += GetDecimalValue(txt_bruto2);
            somaBruto += GetDecimalValue(txt_bruto3);
            somaBruto += GetDecimalValue(txt_bruto4);
            somaBruto += GetDecimalValue(txt_bruto5);
            somaBruto += GetDecimalValue(txt_bruto6);

            // Exibir o resultado formatado no campo de saída txt_somabruto
            txt_somabruto.Text = string.Format("R$ {0:N2}", somaBruto);

            // Somar os valores dos campos txt_desconto1 até txt_desconto6
            decimal somaDesconto = 0;
            somaDesconto += GetDecimalValue(txt_desconto1);
            somaDesconto += GetDecimalValue(txt_desconto2);
            somaDesconto += GetDecimalValue(txt_desconto3);
            somaDesconto += GetDecimalValue(txt_desconto4);
            somaDesconto += GetDecimalValue(txt_desconto5);
            somaDesconto += GetDecimalValue(txt_desconto6);

            // Exibir o resultado formatado no campo de saída txt_somadesconto
            txt_somadesconto.Text = string.Format("R$ {0:N2}", somaDesconto);

            // Somar os valores de txt_somabruto e txt_somadesconto para obter o total
            decimal somaTotal = somaBruto - somaDesconto;

            // Exibir o resultado formatado no campo de saída txt_somatotal
            txt_somatotal.Text = string.Format("R$ {0:N2}", somaTotal);
        }

        private decimal GetDecimalValue(TextBox textBox)
        {
            string valorSemCaracteresNaoNumericos = string.Concat(textBox.Text.Where(c => char.IsDigit(c) || c == ','));
            if (decimal.TryParse(valorSemCaracteresNaoNumericos, out decimal valorDecimal))
            {
                return valorDecimal;
            }
            return 0;
        }

        private void AtualizarCamposTotais()
        {
            decimal somaBruto = GetDecimalValue(txt_somabruto);
            decimal somaDesconto = GetDecimalValue(txt_somadesconto);
            decimal somaTotal = somaBruto - somaDesconto;

            txt_somabruto.Text = string.Format("R$ {0:N2}", somaBruto);
            txt_somadesconto.Text = string.Format("R$ {0:N2}", somaDesconto);
            txt_somatotal.Text = string.Format("R$ {0:N2}", somaTotal);
        }

        private void tabPage1_Click(object sender, EventArgs e) // FINAL
        {

        }
        private void button1_Click(object sender, EventArgs e) //br_recibo
        {
            try
            {
                string originalFilePath;

                if (radioButton1.Checked) // Vale Combustivel e Transporte
                {

                    originalFilePath = @"C:\Users\edvam\OneDrive\Documentos\Teste\ReciboCombustivelTransporte.docx";
                }
                else if (radioButton2.Checked) // Vale Refeição
                {
                    originalFilePath = @"C:\Users\edvam\OneDrive\Documentos\Teste\ReciboRefeição.docx";
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma opção (Vale Refeição ou Vale Combustivel | Transporte) antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (DocX doc = DocX.Load(originalFilePath))
                {


                    //Dados Funcionario //Fora da Tabela
                    doc.ReplaceText("#NOMECOMPLETO", txt_nome1.Text);
                    doc.ReplaceText("#RG", txt_rg1.Text);
                    doc.ReplaceText("#TOTALGERAL", txt_somatotal.Text);
                    doc.ReplaceText("#MES", txt_periodomes.Text);
                    doc.ReplaceText("#VALORES", txt_valores.Text);
                    doc.ReplaceText("#TIPOVALE", txt_vales.Text);
                    doc.ReplaceText("#PERIODO", txt_periodo.Text);

                    // Dados da Tabela

                    //Observação e Periodo
                    ReplaceTagsWithTextInTable(doc, "#PERIODO", txt_indicativo.Text);
                    ReplaceTagsWithTextInTable(doc, "#OBS1", txt_obs1.Text);
                    ReplaceTagsWithTextInTable(doc, "#OBS2", txt_obs2.Text);
                    ReplaceTagsWithTextInTable(doc, "#OBS3", txt_obs3.Text);
                    ReplaceTagsWithTextInTable(doc, "#OBS4", txt_obs4.Text);
                    ReplaceTagsWithTextInTable(doc, "#OBS5", txt_obs5.Text);
                    ReplaceTagsWithTextInTable(doc, "#OBS6", txt_obs6.Text);

                    //Valor Bruto
                    ReplaceTagsWithTextInTable(doc, "#VL_BRUTO1", txt_bruto1.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_BRUTO2", txt_bruto2.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_BRUTO3", txt_bruto3.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_BRUTO4", txt_bruto4.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_BRUTO5", txt_bruto5.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_BRUTO6", txt_bruto6.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_TOTAL1", txt_somabruto.Text);

                    //Valor Desconto
                    ReplaceTagsWithTextInTable(doc, "#VL_DESCONTO1", txt_desconto1.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_DESCONTO2", txt_desconto2.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_DESCONTO3", txt_desconto3.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_DESCONTO4", txt_desconto4.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_DESCONTO5", txt_desconto5.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_DESCONTO6", txt_desconto6.Text);
                    ReplaceTagsWithTextInTable(doc, "#VL_TOTAL2", txt_somadesconto.Text);

                    // Fora da Tabela
                    // Data
                    doc.ReplaceText("#DATA", txt_data.Text);


                    // Salva o documento modificado em formato .docx
                    string newFilePathDocx = Path.Combine(Path.GetDirectoryName(originalFilePath), $"{txt_nome1.Text.ToUpper()}_MODIFICADO.docx");
                    doc.SaveAs(newFilePathDocx);

                    // Use o Microsoft Word para salvar o documento como PDF
                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Document wordDoc = wordApp.Documents.Open(newFilePathDocx);

                    string newFilePathPdf = Path.Combine(Path.GetDirectoryName(originalFilePath), $"{txt_nome1.Text.ToUpper()}_MODIFICADO.pdf");
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

        private void MENU_RECIBOS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_DADOSDataSet.DADOS_PAGO'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_PAGOTableAdapter.Fill(this.dB_DADOSDataSet.DADOS_PAGO);
            // TODO: esta linha de código carrega dados na tabela 'dB_DADOSDataSet.DADOS_GERAL'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_GERALTableAdapter.Fill(this.dB_DADOSDataSet.DADOS_GERAL);
            // TODO: esta linha de código carrega dados na tabela 'dB_DADOSDataSet.DADOS_PAGO'. Você pode movê-la ou removê-la conforme necessário.
 

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide(); // Ocultar o formulário MENU_PRINCIPAL

            MENU_PRINCIPAL menuFicha = new MENU_PRINCIPAL();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dADOSPAGOBindingSource.AddNew();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            dADOSPAGOBindingSource.EndEdit();
            dADOS_PAGOTableAdapter.Update(dB_DADOSDataSet);
            MessageBox.Show("SALVO COM SUCESSO");


        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {

            dADOSPAGOBindingSource.MovePrevious();

        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {

            dADOSPAGOBindingSource.MoveNext();

        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {

            // Obtém a linha atual da fonte de dados vinculada
            var currentRow = ((DataRowView)dADOSPAGOBindingSource.Current).Row;

            // Obtém o valor do ID da linha
            int idToDelete = (int)currentRow["Código"];

            // Exibe uma caixa de diálogo de confirmação
            var confirmationResult = MessageBox.Show($"Deseja apagar o Código {idToDelete}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                // Remove a linha da fonte de dados vinculada
                currentRow.Delete();

            }
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {

            // Definir o contexto de licença para evitar a exceção de licença
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Criar um novo arquivo Excel
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                var worksheet = excelPackage.Workbook.Worksheets.Add("Dados");

                // Substitua pelo nome correto do DataTable (exemplo: dADOS_GERALTableAdapter)
                var dataTable = (dADOS_PAGOTableAdapter.GetData() as DB_DADOSDataSet.DADOS_PAGODataTable);

                if (dataTable != null)
                {
                    // Preencher os cabeçalhos
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataTable.Columns[col].ColumnName;
                    }

                    // Preencher os dados
                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                        }
                    }

                    // Usar o diálogo de salvamento do Windows para escolher onde salvar
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Arquivos Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar arquivo Excel";
                    saveFileDialog.FileName = "DADOS PAGOS AMÉRICA RENTAL.xlsx"; // Definir o nome padrão
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                        MessageBox.Show("Arquivo Excel gerado e salvo com sucesso!");
                    }
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            dADOSPAGOBindingSource.EndEdit();
            dADOS_PAGOTableAdapter.Update(dB_DADOSDataSet);

        }

        private void txt_nome1_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto do TextBox de origem (txt_nome1)
            string textoNomeOrigem = txt_nome1.Text;

            // Define o texto no TextBox de destino (txt_nome)
            txt_nome.Text = textoNomeOrigem;


        }

        private void txt_rg1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            // Obtém o texto do TextBox de origem (txt_rg1)
            string textoRgOrigem = txt_rg1.Text;

            // Define o texto no TextBox de destino (txt_rg)
            txt_rg.Text = textoRgOrigem;

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cb_busca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_rg1_TextChanged(object sender, EventArgs e)
        {

            // Obtém o texto do TextBox de origem (txt_rg1)
            string textoRgOrigem = txt_rg1.Text;

            // Define o texto no TextBox de destino (txt_rg)
            txt_rg.Text = textoRgOrigem;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            dADOSPAGOBindingSource.EndEdit();
            dADOS_PAGOTableAdapter.Update(dB_DADOSDataSet);

        }
    }
}









    





