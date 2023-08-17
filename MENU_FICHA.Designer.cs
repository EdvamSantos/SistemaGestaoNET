namespace Sistema_Gestao
{
    partial class MENU_FICHA
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.dADOSGERALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDADOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_DADOSDataSet = new Sistema_Gestao.DB_DADOSDataSet();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.txt_setor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_adm = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.DADOS = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dADOS_GERALTableAdapter = new Sistema_Gestao.DB_DADOSDataSetTableAdapters.DADOS_GERALTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dADOSGERALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDADOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DADOSDataSet)).BeginInit();
            this.DADOS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dADOSGERALBindingSource, "NOME COMPLETO", true));
            this.txt_nome.Enabled = false;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(137, 92);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(338, 23);
            this.txt_nome.TabIndex = 11;
            // 
            // dADOSGERALBindingSource
            // 
            this.dADOSGERALBindingSource.DataMember = "DADOS_GERAL";
            this.dADOSGERALBindingSource.DataSource = this.dBDADOSDataSetBindingSource;
            // 
            // dBDADOSDataSetBindingSource
            // 
            this.dBDADOSDataSetBindingSource.DataSource = this.dB_DADOSDataSet;
            this.dBDADOSDataSetBindingSource.Position = 0;
            // 
            // dB_DADOSDataSet
            // 
            this.dB_DADOSDataSet.DataSetName = "DB_DADOSDataSet";
            this.dB_DADOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_cargo
            // 
            this.txt_cargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dADOSGERALBindingSource, "SETOR", true));
            this.txt_cargo.Enabled = false;
            this.txt_cargo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo.Location = new System.Drawing.Point(344, 124);
            this.txt_cargo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(132, 23);
            this.txt_cargo.TabIndex = 1;
            // 
            // txt_setor
            // 
            this.txt_setor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dADOSGERALBindingSource, "SETOR", true));
            this.txt_setor.Enabled = false;
            this.txt_setor.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_setor.Location = new System.Drawing.Point(344, 157);
            this.txt_setor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_setor.Name = "txt_setor";
            this.txt_setor.Size = new System.Drawing.Size(132, 23);
            this.txt_setor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOME:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "SETOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "RG:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "ADMISSÃO:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "CARGO:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(12, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "CRIAR FICHA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dADOSGERALBindingSource;
            this.comboBox1.DisplayMember = "NOME COMPLETO";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 55);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(338, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "BUSCAR:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_adm
            // 
            this.txt_adm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dADOSGERALBindingSource, "ADMISSÃO DATA", true));
            this.txt_adm.Enabled = false;
            this.txt_adm.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adm.Location = new System.Drawing.Point(137, 177);
            this.txt_adm.Margin = new System.Windows.Forms.Padding(2);
            this.txt_adm.Mask = "00/00/0000";
            this.txt_adm.Name = "txt_adm";
            this.txt_adm.Size = new System.Drawing.Size(130, 23);
            this.txt_adm.TabIndex = 15;
            this.txt_adm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adm.ValidatingType = typeof(System.DateTime);
            // 
            // txt_cpf
            // 
            this.txt_cpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dADOSGERALBindingSource, "CPF", true));
            this.txt_cpf.Enabled = false;
            this.txt_cpf.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.Location = new System.Drawing.Point(137, 149);
            this.txt_cpf.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cpf.Mask = "000\\.000\\.000\\-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(130, 23);
            this.txt_cpf.TabIndex = 16;
            this.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_rg
            // 
            this.txt_rg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dADOSGERALBindingSource, "RG", true));
            this.txt_rg.Enabled = false;
            this.txt_rg.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rg.Location = new System.Drawing.Point(137, 120);
            this.txt_rg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rg.Mask = "00\\.000\\.000\\-0";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(130, 23);
            this.txt_rg.TabIndex = 17;
            this.txt_rg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DADOS
            // 
            this.DADOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DADOS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DADOS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DADOS.Controls.Add(this.radioButton2);
            this.DADOS.Controls.Add(this.radioButton1);
            this.DADOS.Controls.Add(this.comboBox1);
            this.DADOS.Controls.Add(this.txt_rg);
            this.DADOS.Controls.Add(this.txt_nome);
            this.DADOS.Controls.Add(this.txt_cpf);
            this.DADOS.Controls.Add(this.txt_cargo);
            this.DADOS.Controls.Add(this.txt_adm);
            this.DADOS.Controls.Add(this.txt_setor);
            this.DADOS.Controls.Add(this.label7);
            this.DADOS.Controls.Add(this.label1);
            this.DADOS.Controls.Add(this.label2);
            this.DADOS.Controls.Add(this.label3);
            this.DADOS.Controls.Add(this.label6);
            this.DADOS.Controls.Add(this.label4);
            this.DADOS.Controls.Add(this.label5);
            this.DADOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DADOS.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DADOS.Location = new System.Drawing.Point(131, 93);
            this.DADOS.Margin = new System.Windows.Forms.Padding(2);
            this.DADOS.Name = "DADOS";
            this.DADOS.Padding = new System.Windows.Forms.Padding(2);
            this.DADOS.Size = new System.Drawing.Size(571, 246);
            this.DADOS.TabIndex = 18;
            this.DADOS.TabStop = false;
            this.DADOS.Text = "DADOS DOS FUNCIONARIOS";
            this.DADOS.Enter += new System.EventHandler(this.DADOS_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(392, 184);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 22);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Escritorio";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(303, 184);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 22);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Logistica";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(178, 344);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(524, 20);
            this.label22.TabIndex = 55;
            this.label22.Text = "- Você sabia que, para criar uma Ficha de EPI, basta escolher o nome na busca e c" +
    "licar em Criar Ficha?\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_sair);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(116, 246);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "O QUE DESEJA?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(12, 55);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 31);
            this.button4.TabIndex = 15;
            this.button4.Text = "MENU ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Location = new System.Drawing.Point(12, 131);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "CADASTRAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(12, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "ABRIR PASTA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dADOS_GERALTableAdapter
            // 
            this.dADOS_GERALTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "Dev. Edvam S. - Versão:  2.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 14);
            this.label9.TabIndex = 57;
            this.label9.Text = "Escolha o tipo de Ficha: Logistica ou Funcionarios";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(278, 40);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 18);
            this.label21.TabIndex = 56;
            this.label21.Text = "CRIAR FICHA DE E.P.I";
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.Purple;
            this.bt_sair.Location = new System.Drawing.Point(11, 19);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(90, 30);
            this.bt_sair.TabIndex = 51;
            this.bt_sair.Text = "SAIR";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // MENU_FICHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 373);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DADOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MENU_FICHA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema Gestão > Ficha de E.P.I";
            this.Load += new System.EventHandler(this.MENU_FICHA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dADOSGERALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDADOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DADOSDataSet)).EndInit();
            this.DADOS.ResumeLayout(false);
            this.DADOS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.TextBox txt_setor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox txt_adm;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.MaskedTextBox txt_rg;
        private System.Windows.Forms.GroupBox DADOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label22;
        private DB_DADOSDataSet dB_DADOSDataSet;
        private System.Windows.Forms.BindingSource dBDADOSDataSetBindingSource;
        private System.Windows.Forms.BindingSource dADOSGERALBindingSource;
        private DB_DADOSDataSetTableAdapters.DADOS_GERALTableAdapter dADOS_GERALTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button bt_sair;
    }
}

