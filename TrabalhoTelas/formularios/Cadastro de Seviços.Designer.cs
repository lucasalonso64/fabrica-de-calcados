namespace TrabalhoTelas.formularios
{
    partial class Controle_de_Serviços
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
            System.Windows.Forms.Label nomeServicoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoServicoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle_de_Serviços));
            this.SairCliente = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Cad_Salvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cadastroServicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroServicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeServicoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.cadastroServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoServicoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cadastroServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancopetDataSet = new TrabalhoTelas.bancopetDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroServicoTableAdapter = new TrabalhoTelas.bancopetDataSetTableAdapters.CadastroServicoTableAdapter();
            this.tableAdapterManager = new TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager();
            this.buscarNomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.nomeServicoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nomeServicoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.buscarNomeToolStripButton = new System.Windows.Forms.ToolStripButton();
            nomeServicoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoServicoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroServicoBindingNavigator)).BeginInit();
            this.cadastroServicoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroServicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServicoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).BeginInit();
            this.buscarNomeToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeServicoLabel
            // 
            nomeServicoLabel.AutoSize = true;
            nomeServicoLabel.Location = new System.Drawing.Point(8, 65);
            nomeServicoLabel.Name = "nomeServicoLabel";
            nomeServicoLabel.Size = new System.Drawing.Size(75, 13);
            nomeServicoLabel.TabIndex = 28;
            nomeServicoLabel.Text = "nome Servico:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(8, 91);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 30;
            valorLabel.Text = "valor:";
            // 
            // codigoServicoLabel1
            // 
            codigoServicoLabel1.AutoSize = true;
            codigoServicoLabel1.Location = new System.Drawing.Point(12, 36);
            codigoServicoLabel1.Name = "codigoServicoLabel1";
            codigoServicoLabel1.Size = new System.Drawing.Size(81, 13);
            codigoServicoLabel1.TabIndex = 31;
            codigoServicoLabel1.Text = "codigo Servico:";
            // 
            // SairCliente
            // 
            this.SairCliente.Location = new System.Drawing.Point(645, 131);
            this.SairCliente.Name = "SairCliente";
            this.SairCliente.Size = new System.Drawing.Size(75, 27);
            this.SairCliente.TabIndex = 25;
            this.SairCliente.Text = "Sair";
            this.SairCliente.UseVisualStyleBackColor = true;
            this.SairCliente.Click += new System.EventHandler(this.SairCliente_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(645, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 24;
            this.button5.Text = "Salvar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Cad_Salvar
            // 
            this.Cad_Salvar.Location = new System.Drawing.Point(645, 65);
            this.Cad_Salvar.Name = "Cad_Salvar";
            this.Cad_Salvar.Size = new System.Drawing.Size(75, 27);
            this.Cad_Salvar.TabIndex = 23;
            this.Cad_Salvar.Text = "Cadastrar";
            this.Cad_Salvar.UseVisualStyleBackColor = true;
            this.Cad_Salvar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 22;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cadastroServicoBindingNavigator
            // 
            this.cadastroServicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastroServicoBindingNavigator.BindingSource = this.cadastroServicoBindingSource;
            this.cadastroServicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastroServicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastroServicoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.cadastroServicoBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cadastroServicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cadastroServicoBindingNavigatorSaveItem});
            this.cadastroServicoBindingNavigator.Location = new System.Drawing.Point(9, 4);
            this.cadastroServicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastroServicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastroServicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastroServicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastroServicoBindingNavigator.Name = "cadastroServicoBindingNavigator";
            this.cadastroServicoBindingNavigator.PositionItem = null;
            this.cadastroServicoBindingNavigator.Size = new System.Drawing.Size(217, 25);
            this.cadastroServicoBindingNavigator.TabIndex = 26;
            this.cadastroServicoBindingNavigator.Text = "bindingNavigator1";
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
            // cadastroServicoBindingNavigatorSaveItem
            // 
            this.cadastroServicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastroServicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroServicoBindingNavigatorSaveItem.Image")));
            this.cadastroServicoBindingNavigatorSaveItem.Name = "cadastroServicoBindingNavigatorSaveItem";
            this.cadastroServicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cadastroServicoBindingNavigatorSaveItem.Text = "Save Data";
            this.cadastroServicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastroServicoBindingNavigatorSaveItem_Click);
            // 
            // nomeServicoTextBox
            // 
            this.nomeServicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroServicoBindingSource, "nomeServico", true));
            this.nomeServicoTextBox.Location = new System.Drawing.Point(95, 62);
            this.nomeServicoTextBox.Name = "nomeServicoTextBox";
            this.nomeServicoTextBox.Size = new System.Drawing.Size(248, 20);
            this.nomeServicoTextBox.TabIndex = 29;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroServicoBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(95, 88);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 31;
            // 
            // cadastroServicoDataGridView
            // 
            this.cadastroServicoDataGridView.AutoGenerateColumns = false;
            this.cadastroServicoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cadastroServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadastroServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cadastroServicoDataGridView.DataSource = this.cadastroServicoBindingSource;
            this.cadastroServicoDataGridView.Location = new System.Drawing.Point(11, 162);
            this.cadastroServicoDataGridView.Name = "cadastroServicoDataGridView";
            this.cadastroServicoDataGridView.ReadOnly = true;
            this.cadastroServicoDataGridView.Size = new System.Drawing.Size(344, 220);
            this.cadastroServicoDataGridView.TabIndex = 31;
            // 
            // codigoServicoNumericUpDown
            // 
            this.codigoServicoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadastroServicoBindingSource, "codigoServico", true));
            this.codigoServicoNumericUpDown.Location = new System.Drawing.Point(99, 36);
            this.codigoServicoNumericUpDown.Name = "codigoServicoNumericUpDown";
            this.codigoServicoNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.codigoServicoNumericUpDown.TabIndex = 32;
            // 
            // cadastroServicoBindingSource
            // 
            this.cadastroServicoBindingSource.DataMember = "CadastroServico";
            this.cadastroServicoBindingSource.DataSource = this.bancopetDataSet;
            // 
            // trabalhoDataSet
            // 
            this.bancopetDataSet.DataSetName = "bancopetDataSet";
            this.bancopetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigoServico";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigoServico";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeServico";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeServico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 94;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 55;
            // 
            // cadastroServicoTableAdapter
            // 
            this.cadastroServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroServicoTableAdapter = this.cadastroServicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buscarNomeToolStrip
            // 
            this.buscarNomeToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.buscarNomeToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.buscarNomeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeServicoToolStripLabel,
            this.nomeServicoToolStripTextBox,
            this.buscarNomeToolStripButton});
            this.buscarNomeToolStrip.Location = new System.Drawing.Point(426, 4);
            this.buscarNomeToolStrip.Name = "buscarNomeToolStrip";
            this.buscarNomeToolStrip.Size = new System.Drawing.Size(230, 25);
            this.buscarNomeToolStrip.TabIndex = 33;
            this.buscarNomeToolStrip.Text = "buscarNomeToolStrip";
            // 
            // nomeServicoToolStripLabel
            // 
            this.nomeServicoToolStripLabel.Name = "nomeServicoToolStripLabel";
            this.nomeServicoToolStripLabel.Size = new System.Drawing.Size(79, 22);
            this.nomeServicoToolStripLabel.Text = "nomeServico:";
            // 
            // nomeServicoToolStripTextBox
            // 
            this.nomeServicoToolStripTextBox.Name = "nomeServicoToolStripTextBox";
            this.nomeServicoToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // buscarNomeToolStripButton
            // 
            this.buscarNomeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buscarNomeToolStripButton.Name = "buscarNomeToolStripButton";
            this.buscarNomeToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.buscarNomeToolStripButton.Text = "Buscar";
            this.buscarNomeToolStripButton.Click += new System.EventHandler(this.buscarNomeToolStripButton_Click);
            // 
            // Controle_de_Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 457);
            this.Controls.Add(this.buscarNomeToolStrip);
            this.Controls.Add(codigoServicoLabel1);
            this.Controls.Add(this.codigoServicoNumericUpDown);
            this.Controls.Add(this.cadastroServicoDataGridView);
            this.Controls.Add(nomeServicoLabel);
            this.Controls.Add(this.nomeServicoTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.cadastroServicoBindingNavigator);
            this.Controls.Add(this.SairCliente);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Cad_Salvar);
            this.Controls.Add(this.button2);
            this.Name = "Controle_de_Serviços";
            this.Text = "Controle_de_Serviços";
            this.Load += new System.EventHandler(this.Controle_de_Serviços_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroServicoBindingNavigator)).EndInit();
            this.cadastroServicoBindingNavigator.ResumeLayout(false);
            this.cadastroServicoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroServicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServicoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).EndInit();
            this.buscarNomeToolStrip.ResumeLayout(false);
            this.buscarNomeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SairCliente;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Cad_Salvar;
        private System.Windows.Forms.Button button2;
        private bancopetDataSet bancopetDataSet;
        private System.Windows.Forms.BindingSource cadastroServicoBindingSource;
        private bancopetDataSetTableAdapters.CadastroServicoTableAdapter cadastroServicoTableAdapter;
        private bancopetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastroServicoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cadastroServicoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeServicoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.DataGridView cadastroServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.NumericUpDown codigoServicoNumericUpDown;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStrip buscarNomeToolStrip;
        private System.Windows.Forms.ToolStripLabel nomeServicoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nomeServicoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton buscarNomeToolStripButton;
    }
}