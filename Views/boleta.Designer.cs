
namespace parqueo.Views
{
    partial class boleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boleta));
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label ciLabel;
            System.Windows.Forms.Label horasLabel;
            System.Windows.Forms.Label pagoLabel;
            this.boletaPago1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boletaPago1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.boletaPago1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.boletaPago1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.ciTextBox = new System.Windows.Forms.TextBox();
            this.horasTextBox = new System.Windows.Forms.TextBox();
            this.pagoTextBox = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            matriculaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            ciLabel = new System.Windows.Forms.Label();
            horasLabel = new System.Windows.Forms.Label();
            pagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boletaPago1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaPago1BindingNavigator)).BeginInit();
            this.boletaPago1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boletaPago1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // boletaPago1BindingSource
            // 
            this.boletaPago1BindingSource.DataSource = typeof(parqueo.Data.boletaPago1);
            // 
            // boletaPago1BindingNavigator
            // 
            this.boletaPago1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.boletaPago1BindingNavigator.BindingSource = this.boletaPago1BindingSource;
            this.boletaPago1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.boletaPago1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.boletaPago1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.boletaPago1BindingNavigatorSaveItem});
            this.boletaPago1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.boletaPago1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.boletaPago1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.boletaPago1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.boletaPago1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.boletaPago1BindingNavigator.Name = "boletaPago1BindingNavigator";
            this.boletaPago1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.boletaPago1BindingNavigator.Size = new System.Drawing.Size(665, 25);
            this.boletaPago1BindingNavigator.TabIndex = 1;
            this.boletaPago1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // boletaPago1BindingNavigatorSaveItem
            // 
            this.boletaPago1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boletaPago1BindingNavigatorSaveItem.Enabled = false;
            this.boletaPago1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("boletaPago1BindingNavigatorSaveItem.Image")));
            this.boletaPago1BindingNavigatorSaveItem.Name = "boletaPago1BindingNavigatorSaveItem";
            this.boletaPago1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.boletaPago1BindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // boletaPago1DataGridView
            // 
            this.boletaPago1DataGridView.AutoGenerateColumns = false;
            this.boletaPago1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boletaPago1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.boletaPago1DataGridView.DataSource = this.boletaPago1BindingSource;
            this.boletaPago1DataGridView.Location = new System.Drawing.Point(333, 28);
            this.boletaPago1DataGridView.Name = "boletaPago1DataGridView";
            this.boletaPago1DataGridView.Size = new System.Drawing.Size(300, 220);
            this.boletaPago1DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ci";
            this.dataGridViewTextBoxColumn4.HeaderText = "ci";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "horas";
            this.dataGridViewTextBoxColumn5.HeaderText = "horas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pago";
            this.dataGridViewTextBoxColumn6.HeaderText = "pago";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(53, 58);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(52, 13);
            matriculaLabel.TabIndex = 2;
            matriculaLabel.Text = "matricula:";
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletaPago1BindingSource, "matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(111, 55);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(60, 88);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletaPago1BindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(111, 85);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(62, 120);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(46, 13);
            apellidoLabel.TabIndex = 6;
            apellidoLabel.Text = "apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletaPago1BindingSource, "apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(114, 117);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 7;
            // 
            // ciLabel
            // 
            ciLabel.AutoSize = true;
            ciLabel.Location = new System.Drawing.Point(67, 155);
            ciLabel.Name = "ciLabel";
            ciLabel.Size = new System.Drawing.Size(18, 13);
            ciLabel.TabIndex = 8;
            ciLabel.Text = "ci:";
            // 
            // ciTextBox
            // 
            this.ciTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletaPago1BindingSource, "ci", true));
            this.ciTextBox.Location = new System.Drawing.Point(91, 152);
            this.ciTextBox.Name = "ciTextBox";
            this.ciTextBox.Size = new System.Drawing.Size(100, 20);
            this.ciTextBox.TabIndex = 9;
            // 
            // horasLabel
            // 
            horasLabel.AutoSize = true;
            horasLabel.Location = new System.Drawing.Point(69, 183);
            horasLabel.Name = "horasLabel";
            horasLabel.Size = new System.Drawing.Size(36, 13);
            horasLabel.TabIndex = 10;
            horasLabel.Text = "horas:";
            // 
            // horasTextBox
            // 
            this.horasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletaPago1BindingSource, "horas", true));
            this.horasTextBox.Location = new System.Drawing.Point(111, 180);
            this.horasTextBox.Name = "horasTextBox";
            this.horasTextBox.Size = new System.Drawing.Size(100, 20);
            this.horasTextBox.TabIndex = 11;
            // 
            // pagoLabel
            // 
            pagoLabel.AutoSize = true;
            pagoLabel.Location = new System.Drawing.Point(71, 214);
            pagoLabel.Name = "pagoLabel";
            pagoLabel.Size = new System.Drawing.Size(34, 13);
            pagoLabel.TabIndex = 12;
            pagoLabel.Text = "pago:";
            // 
            // pagoTextBox
            // 
            this.pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletaPago1BindingSource, "pago", true));
            this.pagoTextBox.Location = new System.Drawing.Point(111, 211);
            this.pagoTextBox.Name = "pagoTextBox";
            this.pagoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pagoTextBox.TabIndex = 13;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(111, 265);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 14;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(pagoLabel);
            this.Controls.Add(this.pagoTextBox);
            this.Controls.Add(horasLabel);
            this.Controls.Add(this.horasTextBox);
            this.Controls.Add(ciLabel);
            this.Controls.Add(this.ciTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(this.boletaPago1DataGridView);
            this.Controls.Add(this.boletaPago1BindingNavigator);
            this.Name = "boleta";
            this.Text = "boleta";
            this.Load += new System.EventHandler(this.boleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boletaPago1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaPago1BindingNavigator)).EndInit();
            this.boletaPago1BindingNavigator.ResumeLayout(false);
            this.boletaPago1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boletaPago1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource boletaPago1BindingSource;
        private System.Windows.Forms.BindingNavigator boletaPago1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton boletaPago1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView boletaPago1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox ciTextBox;
        private System.Windows.Forms.TextBox horasTextBox;
        private System.Windows.Forms.TextBox pagoTextBox;
        private System.Windows.Forms.Button Aceptar;
    }
}