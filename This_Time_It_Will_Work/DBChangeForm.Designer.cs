
namespace This_Time_It_Will_Work
{
    partial class DBChangeForm
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
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.buttonCreateConnection = new System.Windows.Forms.Button();
            this.TabelsListBox = new System.Windows.Forms.ListBox();
            this.buttonAddAttribute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 266);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 37);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Location = new System.Drawing.Point(13, 99);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(108, 38);
            this.buttonAddTable.TabIndex = 2;
            this.buttonAddTable.Text = "Добавить таблицу";
            this.buttonAddTable.UseVisualStyleBackColor = true;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableNameTextBox.Location = new System.Drawing.Point(13, 73);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(222, 24);
            this.TableNameTextBox.TabIndex = 3;
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.Location = new System.Drawing.Point(131, 99);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(104, 38);
            this.buttonDeleteTable.TabIndex = 4;
            this.buttonDeleteTable.Text = "Удалить таблицу";
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // buttonCreateConnection
            // 
            this.buttonCreateConnection.Location = new System.Drawing.Point(12, 175);
            this.buttonCreateConnection.Name = "buttonCreateConnection";
            this.buttonCreateConnection.Size = new System.Drawing.Size(223, 41);
            this.buttonCreateConnection.TabIndex = 5;
            this.buttonCreateConnection.Text = "Установить связь между двумя таблицами";
            this.buttonCreateConnection.UseVisualStyleBackColor = true;
            this.buttonCreateConnection.Click += new System.EventHandler(this.buttonCreateConnection_Click);
            // 
            // TabelsListBox
            // 
            this.TabelsListBox.FormattingEnabled = true;
            this.TabelsListBox.Location = new System.Drawing.Point(331, 54);
            this.TabelsListBox.Name = "TabelsListBox";
            this.TabelsListBox.Size = new System.Drawing.Size(258, 43);
            this.TabelsListBox.TabIndex = 6;
            // 
            // buttonAddAttribute
            // 
            this.buttonAddAttribute.Location = new System.Drawing.Point(457, 103);
            this.buttonAddAttribute.Name = "buttonAddAttribute";
            this.buttonAddAttribute.Size = new System.Drawing.Size(132, 34);
            this.buttonAddAttribute.TabIndex = 7;
            this.buttonAddAttribute.Text = "Добавить атрибут";
            this.buttonAddAttribute.UseVisualStyleBackColor = true;
            this.buttonAddAttribute.Click += new System.EventHandler(this.buttonAddAttribute_Click);
            // 
            // DBChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 345);
            this.Controls.Add(this.buttonAddAttribute);
            this.Controls.Add(this.TabelsListBox);
            this.Controls.Add(this.buttonCreateConnection);
            this.Controls.Add(this.buttonDeleteTable);
            this.Controls.Add(this.TableNameTextBox);
            this.Controls.Add(this.buttonAddTable);
            this.Controls.Add(this.buttonBack);
            this.Name = "DBChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBChangeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBChangeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.Button buttonCreateConnection;
        private System.Windows.Forms.ListBox TabelsListBox;
        private System.Windows.Forms.Button buttonAddAttribute;
    }
}