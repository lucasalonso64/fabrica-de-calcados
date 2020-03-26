namespace TrabalhoTelas.formularios
{
    partial class Cadastro_de_Animais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoAnimalLabel;
            System.Windows.Forms.Label nomeAnimalLabel;
            System.Windows.Forms.Label tipoAnimalLabel;
            System.Windows.Forms.Label racaAnimalLabel;
            System.Windows.Forms.Label nomeClienteLabel;
            System.Windows.Forms.Label codigoClienteLabel;
            System.Windows.Forms.Label sexoAnimalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Animais));
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cadastroAnimalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cadastroAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancopetDataSet = new TrabalhoTelas.bancopetDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroAnimalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoAnimalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nomeAnimalTextBox = new System.Windows.Forms.TextBox();
            this.tipoAnimalComboBox = new System.Windows.Forms.ComboBox();
            this.tipoAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancopetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaAnimalTextBox = new System.Windows.Forms.TextBox();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.codigoClienteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cadastroAnimalTableAdapter = new TrabalhoTelas.bancopetDataSetTableAdapters.CadastroAnimalTableAdapter();
            this.tableAdapterManager = new TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager();
            this.cadastroAnimalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAnimalTableAdapter = new TrabalhoTelas.bancopetDataSetTableAdapters.tipoAnimalTableAdapter();
            this.sexoAnimalComboBox = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexoTableAdapter = new TrabalhoTelas.bancopetDataSetTableAdapters.SexoTableAdapter();
            codigoAnimalLabel = new System.Windows.Forms.Label();
            nomeAnimalLabel = new System.Windows.Forms.Label();
            tipoAnimalLabel = new System.Windows.Forms.Label();
            racaAnimalLabel = new System.Windows.Forms.Label();
            nomeClienteLabel = new System.Windows.Forms.Label();
            codigoClienteLabel = new System.Windows.Forms.Label();
            sexoAnimalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroAnimalBindingNavigator)).BeginInit();
            this.cadastroAnimalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoAnimalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoClienteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroAnimalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoAnimalLabel
            // 
            codigoAnimalLabel.AutoSize = true;
            codigoAnimalLabel.Location = new System.Drawing.Point(12, 29);
            codigoAnimalLabel.Name = "codigoAnimalLabel";
            codigoAnimalLabel.Size = new System.Drawing.Size(76, 13);
            codigoAnimalLabel.TabIndex = 22;
            codigoAnimalLabel.Text = "codigo Animal:";
            // 
            // nomeAnimalLabel
            // 
            nomeAnimalLabel.AutoSize = true;
            nomeAnimalLabel.Location = new System.Drawing.Point(12, 91);
            nomeAnimalLabel.Name = "nomeAnimalLabel";
            nomeAnimalLabel.Size = new System.Drawing.Size(70, 13);
            nomeAnimalLabel.TabIndex = 24;
            nomeAnimalLabel.Text = "nome Animal:";
            // 
            // tipoAnimalLabel
            // 
            tipoAnimalLabel.AutoSize = true;
            tipoAnimalLabel.Location = new System.Drawing.Point(12, 117);
            tipoAnimalLabel.Name = "tipoAnimalLabel";
            tipoAnimalLabel.Size = new System.Drawing.Size(61, 13);
            tipoAnimalLabel.TabIndex = 26;
            tipoAnimalLabel.Text = "tipo Animal:";
            // 
            // racaAnimalLabel
            // 
            racaAnimalLabel.AutoSize = true;
            racaAnimalLabel.Location = new System.Drawing.Point(12, 144);
            racaAnimalLabel.Name = "racaAnimalLabel";
            racaAnimalLabel.Size = new System.Drawing.Size(65, 13);
            racaAnimalLabel.TabIndex = 28;
            racaAnimalLabel.Text = "raca Animal:";
            // 
            // nomeClienteLabel
            // 
            nomeClienteLabel.AutoSize = true;
            nomeClienteLabel.Location = new System.Drawing.Point(12, 196);
            nomeClienteLabel.Name = "nomeClienteLabel";
            nomeClienteLabel.Size = new System.Drawing.Size(71, 13);
            nomeClienteLabel.TabIndex = 32;
            nomeClienteLabel.Text = "nome Cliente:";
            // 
            // codigoClienteLabel
            // 
            codigoClienteLabel.AutoSize = true;
            codigoClienteLabel.Location = new System.Drawing.Point(12, 58);
            codigoClienteLabel.Name = "codigoClienteLabel";
            codigoClienteLabel.Size = new System.Drawing.Size(77, 13);
            codigoClienteLabel.TabIndex = 34;
            codigoClienteLabel.Text = "codigo Cliente:";
            // 
            // sexoAnimalLabel
            // 
            sexoAnimalLabel.AutoSize = true;
            sexoAnimalLabel.Location = new System.Drawing.Point(12, 170);
            sexoAnimalLabel.Name = "sexoAnimalLabel";
            sexoAnimalLabel.Size = new System.Drawing.Size(66, 13);
            sexoAnimalLabel.TabIndex = 35;
            sexoAnimalLabel.Text = "sexo Animal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(579, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 20;
            this.button5.Text = "Alterar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 18;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cadastroAnimalBindingNavigator
            // 
            this.cadastroAnimalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastroAnimalBindingNavigator.BindingSource = this.cadastroAnimalBindingSource;
            this.cadastroAnimalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastroAnimalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastroAnimalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cadastroAnimalBindingNavigatorSaveItem});
            this.cadastroAnimalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastroAnimalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastroAnimalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastroAnimalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastroAnimalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastroAnimalBindingNavigator.Name = "cadastroAnimalBindingNavigator";
            this.cadastroAnimalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadastroAnimalBindingNavigator.Size = new System.Drawing.Size(749, 25);
            this.cadastroAnimalBindingNavigator.TabIndex = 22;
            this.cadastroAnimalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // cadastroAnimalBindingSource
            // 
            this.cadastroAnimalBindingSource.DataMember = "CadastroAnimal";
            this.cadastroAnimalBindingSource.DataSource = this.bancopetDataSet;
            // 
            // bancopetDataSet
            // 
            this.bancopetDataSet.DataSetName = "bancopetDataSet";
            this.bancopetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cadastroAnimalBindingNavigatorSaveItem
            // 
            this.cadastroAnimalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastroAnimalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroAnimalBindingNavigatorSaveItem.Image")));
            this.cadastroAnimalBindingNavigatorSaveItem.Name = "cadastroAnimalBindingNavigatorSaveItem";
            this.cadastroAnimalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cadastroAnimalBindingNavigatorSaveItem.Text = "Save Data";
            this.cadastroAnimalBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastroAnimalBindingNavigatorSaveItem_Click);
            // 
            // codigoAnimalNumericUpDown
            // 
            this.codigoAnimalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadastroAnimalBindingSource, "codigoAnimal", true));
            this.codigoAnimalNumericUpDown.Location = new System.Drawing.Point(95, 29);
            this.codigoAnimalNumericUpDown.Name = "codigoAnimalNumericUpDown";
            this.codigoAnimalNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.codigoAnimalNumericUpDown.TabIndex = 23;
            // 
            // nomeAnimalTextBox
            // 
            this.nomeAnimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroAnimalBindingSource, "nomeAnimal", true));
            this.nomeAnimalTextBox.Location = new System.Drawing.Point(95, 88);
            this.nomeAnimalTextBox.Name = "nomeAnimalTextBox";
            this.nomeAnimalTextBox.Size = new System.Drawing.Size(251, 20);
            this.nomeAnimalTextBox.TabIndex = 25;
            // 
            // tipoAnimalComboBox
            // 
            this.tipoAnimalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroAnimalBindingSource, "tipoAnimal", true));
            this.tipoAnimalComboBox.DataSource = this.tipoAnimalBindingSource;
            this.tipoAnimalComboBox.DisplayMember = "descricao";
            this.tipoAnimalComboBox.FormattingEnabled = true;
            this.tipoAnimalComboBox.Location = new System.Drawing.Point(95, 114);
            this.tipoAnimalComboBox.Name = "tipoAnimalComboBox";
            this.tipoAnimalComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoAnimalComboBox.TabIndex = 27;
            this.tipoAnimalComboBox.ValueMember = "descricao";
            this.tipoAnimalComboBox.SelectedIndexChanged += new System.EventHandler(this.tipoAnimalComboBox_SelectedIndexChanged);
            // 
            // tipoAnimalBindingSource
            // 
            this.tipoAnimalBindingSource.DataMember = "tipoAnimal";
            this.tipoAnimalBindingSource.DataSource = this.bancopetDataSetBindingSource;
            // 
            // bancopetDataSetBindingSource
            // 
            this.bancopetDataSetBindingSource.DataSource = this.bancopetDataSet;
            this.bancopetDataSetBindingSource.Position = 0;
            // 
            // racaAnimalTextBox
            // 
            this.racaAnimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroAnimalBindingSource, "racaAnimal", true));
            this.racaAnimalTextBox.Location = new System.Drawing.Point(95, 141);
            this.racaAnimalTextBox.Name = "racaAnimalTextBox";
            this.racaAnimalTextBox.Size = new System.Drawing.Size(121, 20);
            this.racaAnimalTextBox.TabIndex = 29;
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroAnimalBindingSource, "nomeCliente", true));
            this.nomeClienteTextBox.Location = new System.Drawing.Point(95, 193);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomeClienteTextBox.TabIndex = 33;
            // 
            // codigoClienteNumericUpDown
            // 
            this.codigoClienteNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadastroAnimalBindingSource, "codigoCliente", true));
            this.codigoClienteNumericUpDown.Location = new System.Drawing.Point(95, 58);
            this.codigoClienteNumericUpDown.Name = "codigoClienteNumericUpDown";
            this.codigoClienteNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.codigoClienteNumericUpDown.TabIndex = 35;
            // 
            // cadastroAnimalTableAdapter
            // 
            this.cadastroAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroAnimalTableAdapter = this.cadastroAnimalTableAdapter;
            this.tableAdapterManager.CadastroServicoTableAdapter = null;
            this.tableAdapterManager.CadatroClienteTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.tipoAnimalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastroAnimalDataGridView
            // 
            this.cadastroAnimalDataGridView.AutoGenerateColumns = false;
            this.cadastroAnimalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadastroAnimalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.cadastroAnimalDataGridView.DataSource = this.cadastroAnimalBindingSource;
            this.cadastroAnimalDataGridView.Location = new System.Drawing.Point(15, 251);
            this.cadastroAnimalDataGridView.Name = "cadastroAnimalDataGridView";
            this.cadastroAnimalDataGridView.Size = new System.Drawing.Size(714, 220);
            this.cadastroAnimalDataGridView.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigoAnimal";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigoAnimal";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeAnimal";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeAnimal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipoAnimal";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipoAnimal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "racaAnimal";
            this.dataGridViewTextBoxColumn4.HeaderText = "racaAnimal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sexoAnimal";
            this.dataGridViewTextBoxColumn5.HeaderText = "sexoAnimal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nomeCliente";
            this.dataGridViewTextBoxColumn6.HeaderText = "nomeCliente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codigoCliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "codigoCliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // tipoAnimalTableAdapter
            // 
            this.tipoAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // sexoAnimalComboBox
            // 
            this.sexoAnimalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroAnimalBindingSource, "sexoAnimal", true));
            this.sexoAnimalComboBox.DataSource = this.sexoBindingSource;
            this.sexoAnimalComboBox.DisplayMember = "descricao";
            this.sexoAnimalComboBox.FormattingEnabled = true;
            this.sexoAnimalComboBox.Location = new System.Drawing.Point(95, 167);
            this.sexoAnimalComboBox.Name = "sexoAnimalComboBox";
            this.sexoAnimalComboBox.Size = new System.Drawing.Size(121, 21);
            this.sexoAnimalComboBox.TabIndex = 36;
            this.sexoAnimalComboBox.ValueMember = "descricao";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.bancopetDataSetBindingSource;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // Cadastro_de_Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 509);
            this.Controls.Add(sexoAnimalLabel);
            this.Controls.Add(this.sexoAnimalComboBox);
            this.Controls.Add(this.cadastroAnimalDataGridView);
            this.Controls.Add(codigoAnimalLabel);
            this.Controls.Add(this.codigoAnimalNumericUpDown);
            this.Controls.Add(nomeAnimalLabel);
            this.Controls.Add(this.nomeAnimalTextBox);
            this.Controls.Add(tipoAnimalLabel);
            this.Controls.Add(this.tipoAnimalComboBox);
            this.Controls.Add(racaAnimalLabel);
            this.Controls.Add(this.racaAnimalTextBox);
            this.Controls.Add(nomeClienteLabel);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(codigoClienteLabel);
            this.Controls.Add(this.codigoClienteNumericUpDown);
            this.Controls.Add(this.cadastroAnimalBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Cadastro_de_Animais";
            this.Text = "Cadastro_de_Animais";
            this.Load += new System.EventHandler(this.Cadastro_de_Animais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroAnimalBindingNavigator)).EndInit();
            this.cadastroAnimalBindingNavigator.ResumeLayout(false);
            this.cadastroAnimalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoAnimalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoClienteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroAnimalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private bancopetDataSet bancopetDataSet;
        private System.Windows.Forms.BindingSource cadastroAnimalBindingSource;
        private bancopetDataSetTableAdapters.CadastroAnimalTableAdapter cadastroAnimalTableAdapter;
        private bancopetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastroAnimalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cadastroAnimalBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown codigoAnimalNumericUpDown;
        private System.Windows.Forms.TextBox nomeAnimalTextBox;
        private System.Windows.Forms.ComboBox tipoAnimalComboBox;
        private System.Windows.Forms.TextBox racaAnimalTextBox;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.NumericUpDown codigoClienteNumericUpDown;
        private System.Windows.Forms.DataGridView cadastroAnimalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource bancopetDataSetBindingSource;
        private System.Windows.Forms.BindingSource tipoAnimalBindingSource;
        private bancopetDataSetTableAdapters.tipoAnimalTableAdapter tipoAnimalTableAdapter;
        private System.Windows.Forms.ComboBox sexoAnimalComboBox;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private bancopetDataSetTableAdapters.SexoTableAdapter sexoTableAdapter;
    }
}