namespace Droid_Cook
{
    partial class Demo
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxExclude = new System.Windows.Forms.TextBox();
            this.labelExclude = new System.Windows.Forms.Label();
            this.textBoxDiet = new System.Windows.Forms.TextBox();
            this.labelDiet = new System.Windows.Forms.Label();
            this.checkBoxInstructionRequiered = new System.Windows.Forms.CheckBox();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSearch.Location = new System.Drawing.Point(165, 52);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(76, 13);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Recipe name :";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxInput.Location = new System.Drawing.Point(281, 49);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(150, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(437, 47);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTitle,
            this.ColumnTime,
            this.ColumnImage});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 356);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxInstructionRequiered);
            this.groupBoxParameters.Controls.Add(this.textBoxDiet);
            this.groupBoxParameters.Controls.Add(this.buttonSearch);
            this.groupBoxParameters.Controls.Add(this.textBoxInput);
            this.groupBoxParameters.Controls.Add(this.labelDiet);
            this.groupBoxParameters.Controls.Add(this.labelSearch);
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.textBoxExclude);
            this.groupBoxParameters.Controls.Add(this.labelExclude);
            this.groupBoxParameters.Controls.Add(this.numericUpDown1);
            this.groupBoxParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(528, 81);
            this.groupBoxParameters.TabIndex = 4;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result number";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(94, 49);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // textBoxExclude
            // 
            this.textBoxExclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxExclude.Location = new System.Drawing.Point(57, 23);
            this.textBoxExclude.Name = "textBoxExclude";
            this.textBoxExclude.Size = new System.Drawing.Size(114, 20);
            this.textBoxExclude.TabIndex = 2;
            // 
            // labelExclude
            // 
            this.labelExclude.AutoSize = true;
            this.labelExclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelExclude.Location = new System.Drawing.Point(6, 26);
            this.labelExclude.Name = "labelExclude";
            this.labelExclude.Size = new System.Drawing.Size(51, 13);
            this.labelExclude.TabIndex = 0;
            this.labelExclude.Text = "Exclude :";
            // 
            // textBoxDiet
            // 
            this.textBoxDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxDiet.Location = new System.Drawing.Point(233, 23);
            this.textBoxDiet.Name = "textBoxDiet";
            this.textBoxDiet.Size = new System.Drawing.Size(114, 20);
            this.textBoxDiet.TabIndex = 6;
            // 
            // labelDiet
            // 
            this.labelDiet.AutoSize = true;
            this.labelDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDiet.Location = new System.Drawing.Point(182, 26);
            this.labelDiet.Name = "labelDiet";
            this.labelDiet.Size = new System.Drawing.Size(32, 13);
            this.labelDiet.TabIndex = 5;
            this.labelDiet.Text = "Diet :";
            // 
            // checkBoxInstructionRequiered
            // 
            this.checkBoxInstructionRequiered.AutoSize = true;
            this.checkBoxInstructionRequiered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxInstructionRequiered.Location = new System.Drawing.Point(390, 23);
            this.checkBoxInstructionRequiered.Name = "checkBoxInstructionRequiered";
            this.checkBoxInstructionRequiered.Size = new System.Drawing.Size(122, 17);
            this.checkBoxInstructionRequiered.TabIndex = 10;
            this.checkBoxInstructionRequiered.Text = "Instruction requiered";
            this.checkBoxInstructionRequiered.UseVisualStyleBackColor = true;
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 41;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.Name = "ColumnTitle";
            // 
            // ColumnTime
            // 
            this.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.Width = 55;
            // 
            // ColumnImage
            // 
            this.ColumnImage.HeaderText = "Picture";
            this.ColumnImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnImage.Name = "ColumnImage";
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 467);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Demo";
            this.Text = "Recipes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxExclude;
        private System.Windows.Forms.Label labelExclude;
        private System.Windows.Forms.TextBox textBoxDiet;
        private System.Windows.Forms.Label labelDiet;
        private System.Windows.Forms.CheckBox checkBoxInstructionRequiered;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
    }
}

