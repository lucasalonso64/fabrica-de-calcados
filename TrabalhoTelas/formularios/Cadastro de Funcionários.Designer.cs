namespace TrabalhoTelas.formularios
{
    partial class Cadastro_de_Funcionários
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Funcionários));
            System.Windows.Forms.Label codigoFuncionarioLabel;
            System.Windows.Forms.Label nomeFuncionarioLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bancopetDataSet = new TrabalhoTelas.bancopetDataSet();
            this.cadastroFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroFuncionarioTableAdapter = new TrabalhoTelas.bancopetDataSetTableAdapters.CadastroFuncionarioTableAdapter();
            this.tableAdapterManager = new TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager();
            this.cadastroFuncionarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cadastroFuncionarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoFuncionarioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nomeFuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.cadastroFuncionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoFuncionarioLabel = new System.Windows.Forms.Label();
            nomeFuncionarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFuncionarioBindingNavigator)).BeginInit();
            this.cadastroFuncionarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoFuncionarioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFuncionarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 25;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(637, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 24;
            this.button5.Text = "Alterar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(637, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 22;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bancopetDataSet
            // 
            this.bancopetDataSet.DataSetName = "bancopetDataSet";
            this.bancopetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroFuncionarioBindingSource
            // 
            this.cadastroFuncionarioBindingSource.DataMember = "CadastroFuncionario";
            this.cadastroFuncionarioBindingSource.DataSource = this.bancopetDataSet;
            // 
            // cadastroFuncionarioTableAdapter
            // 
            this.cadastroFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroAnimalTableAdapter = null;
            this.tableAdapterManager.CadastroFuncionarioTableAdapter = this.cadastroFuncionarioTableAdapter;
            this.tableAdapterManager.CadastroServicoTableAdapter = null;
            this.tableAdapterManager.CadatroClienteTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.tipoAnimalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastroFuncionarioBindingNavigator
            // 
            this.cadastroFuncionarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastroFuncionarioBindingNavigator.BindingSource = this.cadastroFuncionarioBindingSource;
            this.cadastroFuncionarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastroFuncionarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastroFuncionarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cadastroFuncionarioBindingNavigatorSaveItem});
            this.cadastroFuncionarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastroFuncionarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastroFuncionarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastroFuncionarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastroFuncionarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastroFuncionarioBindingNavigator.Name = "cadastroFuncionarioBindingNavigator";
            this.cadastroFuncionarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadastroFuncionarioBindingNavigator.Size = new System.Drawing.Size(754, 25);
            this.cadastroFuncionarioBindingNavigator.TabIndex = 26;
            this.cadastroFuncionarioBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cadastroFuncionarioBindingNavigatorSaveItem
            // 
            this.cadastroFuncionarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastroFuncionarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroFuncionarioBindingNavigatorSaveItem.Image")));
            this.cadastroFuncionarioBindingNavigatorSaveItem.Name = "cadastroFuncionarioBindingNavigatorSaveItem";
            this.cadastroFuncionarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cadastroFuncionarioBindingNavigatorSaveItem.Text = "Save Data";
            this.cadastroFuncionarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastroFuncionarioBindingNavigatorSaveItem_Click);
            // 
            // codigoFuncionarioLabel
            // 
            codigoFuncionarioLabel.AutoSize = true;
            codigoFuncionarioLabel.Location = new System.Drawing.Point(12, 39);
            codigoFuncionarioLabel.Name = "codigoFuncionarioLabel";
            codigoFuncionarioLabel.Size = new System.Drawing.Size(100, 13);
            codigoFuncionarioLabel.TabIndex = 26;
            codigoFuncionarioLabel.Text = "codigo Funcionario:";
            // 
            // codigoFuncionarioNumericUpDown
            // 
            this.codigoFuncionarioNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadastroFuncionarioBindingSource, "codigoFuncionario", true));
            this.codigoFuncionarioNumericUpDown.Location = new System.Drawing.Point(118, 39);
            this.codigoFuncionarioNumericUpDown.Name = "codigoFuncionarioNumericUpDown";
            this.codigoFuncionarioNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.codigoFuncionarioNumericUpDown.TabIndex = 27;
            // 
            // nomeFuncionarioLabel
            // 
            nomeFuncionarioLabel.AutoSize = true;
            nomeFuncionarioLabel.Location = new System.Drawing.Point(12, 68);
            nomeFuncionarioLabel.Name = "nomeFuncionarioLabel";
            nomeFuncionarioLabel.Size = new System.Drawing.Size(94, 13);
            nomeFuncionarioLabel.TabIndex = 28;
            nomeFuncionarioLabel.Text = "nome Funcionario:";
            // 
            // nomeFuncionarioTextBox
            // 
            this.nomeFuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroFuncionarioBindingSource, "nomeFuncionario", true));
            this.nomeFuncionarioTextBox.Location = new System.Drawing.Point(118, 65);
            this.nomeFuncionarioTextBox.Name = "nomeFuncionarioTextBox";
            this.nomeFuncionarioTextBox.Size = new System.Drawing.Size(254, 20);
            this.nomeFuncionarioTextBox.TabIndex = 29;
            // 
            // cadastroFuncionarioDataGridView
            // 
            this.cadastroFuncionarioDataGridView.AutoGenerateColumns = false;
            this.cadastroFuncionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadastroFuncionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cadastroFuncionarioDataGridView.DataSource = this.cadastroFuncionarioBindingSource;
            this.cadastroFuncionarioDataGridView.Location = new System.Drawing.Point(15, 153);
            this.cadastroFuncionarioDataGridView.Name = "cadastroFuncionarioDataGridView";
            this.cadastroFuncionarioDataGridView.Size = new System.Drawing.Size(542, 220);
            this.cadastroFuncionarioDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigoFuncionario";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigoFuncionario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeFuncionario";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeFuncionario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Cadastro_de_Funcionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 432);
            this.Controls.Add(this.cadastroFuncionarioDataGridView);
            this.Controls.Add(codigoFuncionarioLabel);
            this.Controls.Add(this.codigoFuncionarioNumericUpDown);
            this.Controls.Add(nomeFuncionarioLabel);
            this.Controls.Add(this.nomeFuncionarioTextBox);
            this.Controls.Add(this.cadastroFuncionarioBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Cadastro_de_Funcionários";
            this.Text = "Cadastro_de_Funcionários";
            this.Load += new System.EventHandler(this.Cadastro_de_Funcionários_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFuncionarioBindingNavigator)).EndInit();
            this.cadastroFuncionarioBindingNavigator.ResumeLayout(false);
            this.cadastroFuncionarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoFuncionarioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFuncionarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private bancopetDataSet bancopetDataSet;
        private System.Windows.Forms.BindingSource cadastroFuncionarioBindingSource;
        private bancopetDataSetTableAdapters.CadastroFuncionarioTableAdapter cadastroFuncionarioTableAdapter;
        private bancopetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastroFuncionarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cadastroFuncionarioBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown codigoFuncionarioNumericUpDown;
        private System.Windows.Forms.TextBox nomeFuncionarioTextBox;
        private System.Windows.Forms.DataGridView cadastroFuncionarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}