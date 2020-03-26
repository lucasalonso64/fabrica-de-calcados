namespace TrabalhoTelas.formularios
{
    partial class Cadastro_Clientes
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
            System.Windows.Forms.Label codigoClienteLabel;
            System.Windows.Forms.Label nomeClienteLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Clientes));
            this.cadatroClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.cadatroClienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cadatroClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoClienteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buscaClienteToolStrip = new System.Windows.Forms.ToolStrip();
            this.nomeClienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nomeClienteToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.buscaClienteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cadatroClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancopetDataSet = new TrabalhoTelas.bancopetDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadatroClienteTableAdapter = new TrabalhoTelas.bancopetDataSetTableAdapters.CadatroClienteTableAdapter();
            this.tableAdapterManager = new TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager();
            codigoClienteLabel = new System.Windows.Forms.Label();
            nomeClienteLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteBindingNavigator)).BeginInit();
            this.cadatroClienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoClienteNumericUpDown)).BeginInit();
            this.buscaClienteToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoClienteLabel
            // 
            codigoClienteLabel.AutoSize = true;
            codigoClienteLabel.Location = new System.Drawing.Point(12, 48);
            codigoClienteLabel.Name = "codigoClienteLabel";
            codigoClienteLabel.Size = new System.Drawing.Size(77, 13);
            codigoClienteLabel.TabIndex = 2;
            codigoClienteLabel.Text = "codigo Cliente:";
            // 
            // nomeClienteLabel
            // 
            nomeClienteLabel.AutoSize = true;
            nomeClienteLabel.Location = new System.Drawing.Point(12, 77);
            nomeClienteLabel.Name = "nomeClienteLabel";
            nomeClienteLabel.Size = new System.Drawing.Size(71, 13);
            nomeClienteLabel.TabIndex = 4;
            nomeClienteLabel.Text = "nome Cliente:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(12, 129);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 8;
            enderecoLabel.Text = "endereco:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(13, 103);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(48, 13);
            telefoneLabel.TabIndex = 9;
            telefoneLabel.Text = "telefone:";
            // 
            // cadatroClienteBindingNavigator
            // 
            this.cadatroClienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadatroClienteBindingNavigator.BindingSource = this.cadatroClienteBindingSource;
            this.cadatroClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadatroClienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadatroClienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.cadatroClienteBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cadatroClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cadatroClienteBindingNavigatorSaveItem});
            this.cadatroClienteBindingNavigator.Location = new System.Drawing.Point(9, 9);
            this.cadatroClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadatroClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadatroClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadatroClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadatroClienteBindingNavigator.Name = "cadatroClienteBindingNavigator";
            this.cadatroClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadatroClienteBindingNavigator.Size = new System.Drawing.Size(269, 25);
            this.cadatroClienteBindingNavigator.TabIndex = 0;
            this.cadatroClienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // cadatroClienteBindingNavigatorSaveItem
            // 
            this.cadatroClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadatroClienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadatroClienteBindingNavigatorSaveItem.Image")));
            this.cadatroClienteBindingNavigatorSaveItem.Name = "cadatroClienteBindingNavigatorSaveItem";
            this.cadatroClienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cadatroClienteBindingNavigatorSaveItem.Text = "Save Data";
            this.cadatroClienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadatroClienteBindingNavigatorSaveItem_Click);
            // 
            // cadatroClienteDataGridView
            // 
            this.cadatroClienteDataGridView.AllowUserToAddRows = false;
            this.cadatroClienteDataGridView.AllowUserToDeleteRows = false;
            this.cadatroClienteDataGridView.AutoGenerateColumns = false;
            this.cadatroClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cadatroClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadatroClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cadatroClienteDataGridView.DataSource = this.cadatroClienteBindingSource;
            this.cadatroClienteDataGridView.Location = new System.Drawing.Point(12, 225);
            this.cadatroClienteDataGridView.Name = "cadatroClienteDataGridView";
            this.cadatroClienteDataGridView.ReadOnly = true;
            this.cadatroClienteDataGridView.Size = new System.Drawing.Size(446, 220);
            this.cadatroClienteDataGridView.TabIndex = 1;
            // 
            // codigoClienteNumericUpDown
            // 
            this.codigoClienteNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadatroClienteBindingSource, "codigoCliente", true));
            this.codigoClienteNumericUpDown.Location = new System.Drawing.Point(95, 46);
            this.codigoClienteNumericUpDown.Name = "codigoClienteNumericUpDown";
            this.codigoClienteNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.codigoClienteNumericUpDown.TabIndex = 3;
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadatroClienteBindingSource, "nomeCliente", true));
            this.nomeClienteTextBox.Enabled = false;
            this.nomeClienteTextBox.Location = new System.Drawing.Point(95, 74);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(120, 20);
            this.nomeClienteTextBox.TabIndex = 5;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadatroClienteBindingSource, "endereco", true));
            this.enderecoTextBox.Enabled = false;
            this.enderecoTextBox.Location = new System.Drawing.Point(95, 126);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(120, 20);
            this.enderecoTextBox.TabIndex = 9;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadatroClienteBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(95, 100);
            this.telefoneMaskedTextBox.Mask = "(###)####-####";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(120, 20);
            this.telefoneMaskedTextBox.TabIndex = 10;
            // 
            // buscaClienteToolStrip
            // 
            this.buscaClienteToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.buscaClienteToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.buscaClienteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeClienteToolStripLabel,
            this.nomeClienteToolStripTextBox1,
            this.buscaClienteToolStripButton});
            this.buscaClienteToolStrip.Location = new System.Drawing.Point(508, 9);
            this.buscaClienteToolStrip.Name = "buscaClienteToolStrip";
            this.buscaClienteToolStrip.Size = new System.Drawing.Size(235, 25);
            this.buscaClienteToolStrip.TabIndex = 11;
            this.buscaClienteToolStrip.Text = "buscaClienteToolStrip";
            // 
            // nomeClienteToolStripLabel
            // 
            this.nomeClienteToolStripLabel.Name = "nomeClienteToolStripLabel";
            this.nomeClienteToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.nomeClienteToolStripLabel.Text = "Cliente";
            // 
            // nomeClienteToolStripTextBox1
            // 
            this.nomeClienteToolStripTextBox1.Name = "nomeClienteToolStripTextBox1";
            this.nomeClienteToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // buscaClienteToolStripButton
            // 
            this.buscaClienteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buscaClienteToolStripButton.Name = "buscaClienteToolStripButton";
            this.buscaClienteToolStripButton.Size = new System.Drawing.Size(86, 22);
            this.buscaClienteToolStripButton.Text = "Buscar Cliente";
            this.buscaClienteToolStripButton.Click += new System.EventHandler(this.buscaClienteToolStripButton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadatroClienteBindingSource
            // 
            this.cadatroClienteBindingSource.DataMember = "CadatroCliente";
            this.cadatroClienteBindingSource.DataSource = this.bancopetDataSet;
            // 
            // bancopetDataSet
            // 
            this.bancopetDataSet.DataSetName = "bancopetDataSet";
            this.bancopetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigoCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigoCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 96;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeCliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 77;
            // 
            // cadatroClienteTableAdapter
            // 
            this.cadatroClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroAnimalTableAdapter = null;
            this.tableAdapterManager.CadastroServicoTableAdapter = null;
            this.tableAdapterManager.CadatroClienteTableAdapter = this.cadatroClienteTableAdapter;
            this.tableAdapterManager.tipoAnimalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Cadastro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscaClienteToolStrip);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(codigoClienteLabel);
            this.Controls.Add(this.codigoClienteNumericUpDown);
            this.Controls.Add(nomeClienteLabel);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.cadatroClienteDataGridView);
            this.Controls.Add(this.cadatroClienteBindingNavigator);
            this.Name = "Cadastro_Clientes";
            this.Text = "Cadastro_Clientes";
            this.Load += new System.EventHandler(this.Cadastro_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteBindingNavigator)).EndInit();
            this.cadatroClienteBindingNavigator.ResumeLayout(false);
            this.cadatroClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoClienteNumericUpDown)).EndInit();
            this.buscaClienteToolStrip.ResumeLayout(false);
            this.buscaClienteToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bancopetDataSet bancopetDataSet;
        private System.Windows.Forms.BindingSource cadatroClienteBindingSource;
        private bancopetDataSetTableAdapters.CadatroClienteTableAdapter cadatroClienteTableAdapter;
        private bancopetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadatroClienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cadatroClienteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cadatroClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.NumericUpDown codigoClienteNumericUpDown;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.ToolStrip buscaClienteToolStrip;
        private System.Windows.Forms.ToolStripLabel nomeClienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nomeClienteToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton buscaClienteToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}