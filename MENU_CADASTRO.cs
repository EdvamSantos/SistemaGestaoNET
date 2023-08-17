using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Sistema_Gestao
{
    public partial class MENU_CADASTRO : Form
    {
        private const string ViaCepUrl = "https://viacep.com.br/ws/{0}/json/";

        public MENU_CADASTRO()
        {
            InitializeComponent();

            // Define a escala de DPI para 100% (escala normal)
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // Define a fonte "Microsoft Sans Serif" sem alterar o tamanho
            Font currentFont = this.Font;
            this.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            // Configurar o evento KeyPress para o campo de texto txt_cep
            txt_cep.KeyPress += TxtCep_KeyPress;
            txt_telefone.Leave += TxtTelefone_Leave;
        }

        private bool DadosForamAlterados = false; // Variável para controlar se os dados foram alterados

        private async void bt_buscar_Click(object sender, EventArgs e)
        {
            string cep = txt_cep.Text;

            if (!string.IsNullOrWhiteSpace(cep))
            {
                string apiUrl = string.Format(ViaCepUrl, cep);

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            string data = await response.Content.ReadAsStringAsync();
                            ViaCepResponse viaCepResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ViaCepResponse>(data);

                            if (viaCepResponse != null)
                            {
                                string enderecoCompleto = $"{viaCepResponse.Logradouro}, {viaCepResponse.Bairro}, {viaCepResponse.Localidade}/{viaCepResponse.Uf}";
                                txt_endereco.Text = enderecoCompleto.ToUpper(); // Converter para maiúsculas
                            }
                            else
                            {
                                MessageBox.Show("CEP não encontrado.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao buscar informações do CEP.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        private void TxtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Pressionar Enter dentro do campo txt_cep acionará o evento do botão bt_buscar
                bt_buscar.PerformClick();
                e.Handled = true; // Impede que o caractere 'Enter' seja exibido no campo de texto
            }
        }

        private void MENU_CADASTRO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_DADOSDataSet.DADOS_GERAL'. Você pode movê-la ou removê-la conforme necessário.
            this.dADOS_GERALTableAdapter.Fill(this.dB_DADOSDataSet.DADOS_GERAL);
            // O código de inicialização do formulário, se houver
        }

        // Classe ViaCepResponse aqui
        public class ViaCepResponse
        {
            public string Logradouro { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string Uf { get; set; }
            // Outras propriedades que você pode querer adicionar aqui
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {

        }
          private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            string inputNumber = txt_telefone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "");

            if (inputNumber.Length == 11)
            {
                string formattedNumber = string.Format("({0}) {1} {2}-{3}",
                    inputNumber.Substring(0, 2),
                    inputNumber.Substring(2, 1),
                    inputNumber.Substring(3, 4),
                    inputNumber.Substring(7, 4));

                txt_telefone.Text = formattedNumber;
            }
            else if (inputNumber.Length == 10)
            {
                string formattedNumber = string.Format("({0}) {1}-{2}",
                    inputNumber.Substring(0, 2),
                    inputNumber.Substring(2, 4),
                    inputNumber.Substring(6));

                txt_telefone.Text = formattedNumber;
            }
            // Adicione mais condições de formato conforme necessário
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            dADOSGERALBindingSource.MovePrevious();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            dADOSGERALBindingSource.MoveNext();
        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            // Obtém a linha atual da fonte de dados vinculada
            var currentRow = ((DataRowView)dADOSGERALBindingSource.Current).Row;

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

        private void bt_cadastrolinha_Click(object sender, EventArgs e)
        {
            dADOSGERALBindingSource.AddNew();
        }

        private void bt_atualizar_Click(object sender, EventArgs e)

        {
            dADOSGERALBindingSource.EndEdit();
            dADOS_GERALTableAdapter.Update(dB_DADOSDataSet);
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
                var dataTable = (dADOS_GERALTableAdapter.GetData() as DB_DADOSDataSet.DADOS_GERALDataTable);

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
                    saveFileDialog.FileName = "DADOS DOS FUNCIONARIOS AMÉRICA RENTAL.xlsx"; // Definir o nome padrão
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                        MessageBox.Show("Arquivo Excel gerado e salvo com sucesso!");
                    }
                }
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você deseja salvar antes de sair?", "Salvar antes de sair",
                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bt_atualizar.PerformClick(); // Chama o evento do botão de atualizar
                Close(); // Fecha o formulário após a atualização
            }
            else if (result == DialogResult.No)
            {
                var confirmResult = MessageBox.Show("Você escolheu não salvar. Tem certeza? Você poderá perder os dados.",
                                                    "Confirmação",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    Close(); // Fecha o formulário sem salvar
                }
                // Se o confirmResult for DialogResult.No, o diálogo permanece aberto
            }
            // Se o result for DialogResult.Cancel, o diálogo permanece aberto
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar o formulário MENU_PRINCIPAL

            MENU_PRINCIPAL menuFicha = new MENU_PRINCIPAL();
            menuFicha.Closed += (s, args) => this.Close(); // Fechar a aplicação quando fechar o formulário MENU_FICHA
            menuFicha.Show();
        }

        public static class SharedDataSet

        {
            public static DB_DADOSDataSet DataSet = new DB_DADOSDataSet(); //Fiz para compartilhar meu DB com todos os forms
            public static DB_DADOSDataSetTableAdapters.DADOS_GERALTableAdapter DADOS_GERALTableAdapter = new DB_DADOSDataSetTableAdapters.DADOS_GERALTableAdapter();

            static SharedDataSet()
            {
                DADOS_GERALTableAdapter.Fill(DataSet.DADOS_GERAL);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}