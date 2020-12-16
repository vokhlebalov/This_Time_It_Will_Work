
namespace This_Time_It_Will_Work
{
    partial class DBCreationFrom
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.DB_Name_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 161);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 37);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(305, 161);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(113, 37);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать базу данных";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // DB_Name_TextBox
            // 
            this.DB_Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DB_Name_TextBox.ForeColor = System.Drawing.Color.Black;
            this.DB_Name_TextBox.Location = new System.Drawing.Point(34, 46);
            this.DB_Name_TextBox.Name = "DB_Name_TextBox";
            this.DB_Name_TextBox.Size = new System.Drawing.Size(354, 29);
            this.DB_Name_TextBox.TabIndex = 3;
            // 
            // DBCreationFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 210);
            this.Controls.Add(this.DB_Name_TextBox);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonBack);
            this.Name = "DBCreationFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBCreationFrom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBCreationFrom_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox DB_Name_TextBox;
    }
}