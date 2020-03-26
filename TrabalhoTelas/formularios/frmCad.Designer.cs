namespace TrabalhoTelas.formularios
{
    partial class frmCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCad));
            System.Windows.Forms.Label codigoClienteLabel;
            System.Windows.Forms.Label nomeClienteLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label enderecoLabel;
            this.bancopetDataSet = new TrabalhoTelas.bancopetDataSet();
            this.cadatroClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadatroClienteTableAdapter = new TrabalhoTelas.bancopetDataSetTableAdapters.CadatroClienteTableAdapter();
            this.tableAdapterManager = new TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager();
            this.cadatroClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cadatroClienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoClienteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cadatroClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoClienteLabel = new System.Windows.Forms.Label();
            nomeClienteLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteBindingNavigator)).BeginInit();
            this.cadatroClienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoClienteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trabalhoDataSet1
            // 
            this.bancopetDataSet.DataSetName = "bancopetDataSet";
            this.bancopetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadatroClienteBindingSource
            // 
            this.cadatroClienteBindingSource.DataMember = "CadatroCliente";
            this.cadatroClienteBindingSource.DataSource = this.bancopetDataSet;
            // 
            // cadatroClienteTableAdapter
            // 
            this.cadatroClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadatroClienteTableAdapter = this.cadatroClienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = TrabalhoTelas.bancopetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadatroClienteBindingNavigator
            // 
            this.cadatroClienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadatroClienteBindingNavigator.BindingSource = this.cadatroClienteBindingSource;
            this.cadatroClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadatroClienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.cadatroClienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadatroClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadatroClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadatroClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadatroClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadatroClienteBindingNavigator.Name = "cadatroClienteBindingNavigator";
            this.cadatroClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadatroClienteBindingNavigator.Size = new System.Drawing.Size(723, 25);
            this.cadatroClienteBindingNavigator.TabIndex = 0;
            this.cadatroClienteBindingNavigator.Text = "bindingNavigator1";
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
            // cadatroClienteBindingNavigatorSaveItem
            // 
            this.cadatroClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadatroClienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadatroClienteBindingNavigatorSaveItem.Image")));
            this.cadatroClienteBindingNavigatorSaveItem.Name = "cadatroClienteBindingNavigatorSaveItem";
            this.cadatroClienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cadatroClienteBindingNavigatorSaveItem.Text = "Save Data";
            this.cadatroClienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadatroClienteBindingNavigatorSaveItem_Click);
            // 
            // codigoClienteLabel
            // 
            codigoClienteLabel.AutoSize = true;
            codigoClienteLabel.Location = new System.Drawing.Point(12, 42);
            codigoClienteLabel.Name = "codigoClienteLabel";
            codigoClienteLabel.Size = new System.Drawing.Size(77, 13);
            codigoClienteLabel.TabIndex = 1;
            codigoClienteLabel.Text = "codigo Cliente:";
            // 
            // codigoClienteNumericUpDown
            // 
            this.codigoClienteNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadatroClienteBindingSource, "codigoCliente", true));
            this.codigoClienteNumericUpDown.Location = new System.Drawing.Point(95, 42);
            this.codigoClienteNumericUpDown.Name = "codigoClienteNumericUpDown";
            this.codigoClienteNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.codigoClienteNumericUpDown.TabIndex = 2;
            // 
            // nomeClienteLabel
            // 
            nomeClienteLabel.AutoSize = true;
            nomeClienteLabel.Location = new System.Drawing.Point(12, 71);
            nomeClienteLabel.Name = "nomeClienteLabel";
            nomeClienteLabel.Size = new System.Drawing.Size(71, 13);
            nomeClienteLabel.TabIndex = 3;
            nomeClienteLabel.Text = "nome Cliente:";
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadatroClienteBindingSource, "nomeCliente", true));
            this.nomeClienteTextBox.Location = new System.Drawing.Point(95, 68);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(120, 20);
            this.nomeClienteTextBox.TabIndex = 4;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(12, 97);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(48, 13);
            telefoneLabel.TabIndex = 5;
            telefoneLabel.Text = "telefone:";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadatroClienteBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(95, 94);
            this.telefoneMaskedTextBox.Mask = "(###)####-####";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(94, 20);
            this.telefoneMaskedTextBox.TabIndex = 6;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(12, 123);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "endereco:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadatroClienteBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(95, 120);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(120, 20);
            this.enderecoTextBox.TabIndex = 8;
            // 
            // cadatroClienteDataGridView
            // 
            this.cadatroClienteDataGridView.AllowUserToAddRows = false;
            this.cadatroClienteDataGridView.AllowUserToDeleteRows = false;
            this.cadatroClienteDataGridView.AutoGenerateColumns = false;
            this.cadatroClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadatroClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cadatroClienteDataGridView.DataSource = this.cadatroClienteBindingSource;
            this.cadatroClienteDataGridView.Enabled = false;
            this.cadatroClienteDataGridView.Location = new System.Drawing.Point(15, 176);
            this.cadatroClienteDataGridView.Name = "cadatroClienteDataGridView";
            this.cadatroClienteDataGridView.ReadOnly = true;
            this.cadatroClienteDataGridView.Size = new System.Drawing.Size(443, 220);
            this.cadatroClienteDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigoCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigoCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeCliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 524);
            this.Controls.Add(this.cadatroClienteDataGridView);
            this.Controls.Add(codigoClienteLabel);
            this.Controls.Add(this.codigoClienteNumericUpDown);
            this.Controls.Add(nomeClienteLabel);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.cadatroClienteBindingNavigator);
            this.Name = "frmCad";
            this.Text = "frmCad";
            this.Load += new System.EventHandler(this.frmCad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancopetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteBindingNavigator)).EndInit();
            this.cadatroClienteBindingNavigator.ResumeLayout(false);
            this.cadatroClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoClienteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadatroClienteDataGridView)).EndInit();
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
        private System.Windows.Forms.NumericUpDown codigoClienteNumericUpDown;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.DataGridView cadatroClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}