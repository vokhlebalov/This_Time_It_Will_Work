namespace This_Time_It_Will_Work
{
    partial class EntriesManipulationForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_tablename = new System.Windows.Forms.TextBox();
            this.richTextBox_tabledesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(18, 617);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(176, 57);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(234, 617);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(131, 57);
            this.button_select.TabIndex = 2;
            this.button_select.Text = "SELECT";
            this.button_select.UseVisualStyleBackColor = true;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(396, 617);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(121, 57);
            this.button_insert.TabIndex = 3;
            this.button_insert.Text = "INSERT";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(545, 617);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(121, 57);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(694, 617);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(121, 57);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // textBox_tablename
            // 
            this.textBox_tablename.Location = new System.Drawing.Point(918, 99);
            this.textBox_tablename.Name = "textBox_tablename";
            this.textBox_tablename.Size = new System.Drawing.Size(202, 26);
            this.textBox_tablename.TabIndex = 7;
            // 
            // richTextBox_tabledesc
            // 
            this.richTextBox_tabledesc.Location = new System.Drawing.Point(918, 184);
            this.richTextBox_tabledesc.Name = "richTextBox_tabledesc";
            this.richTextBox_tabledesc.Size = new System.Drawing.Size(202, 124);
            this.richTextBox_tabledesc.TabIndex = 8;
            this.richTextBox_tabledesc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(945, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(945, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Описание таблицы";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(803, 581);
            this.dataGridView.TabIndex = 12;
            // 
            // EntriesManipulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_tabledesc);
            this.Controls.Add(this.textBox_tablename);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.buttonBack);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EntriesManipulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntriesManipulationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntriesManipulationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_tablename;
        private System.Windows.Forms.RichTextBox richTextBox_tabledesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}