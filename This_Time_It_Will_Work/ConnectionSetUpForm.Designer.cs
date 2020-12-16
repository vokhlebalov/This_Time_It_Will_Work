
namespace This_Time_It_Will_Work
{
    partial class ConnectionSetUpForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.depTableComboBox = new System.Windows.Forms.ComboBox();
            this.refTableComboBox = new System.Windows.Forms.ComboBox();
            this.depAttrListBox = new System.Windows.Forms.ListBox();
            this.refAttrListBox = new System.Windows.Forms.ListBox();
            this.CreateConnectionButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 397);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 41);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // depTableComboBox
            // 
            this.depTableComboBox.FormattingEnabled = true;
            this.depTableComboBox.Location = new System.Drawing.Point(12, 12);
            this.depTableComboBox.Name = "depTableComboBox";
            this.depTableComboBox.Size = new System.Drawing.Size(286, 21);
            this.depTableComboBox.TabIndex = 1;
            this.depTableComboBox.TextChanged += new System.EventHandler(this.depTableComboBox_TextChanged);
            // 
            // refTableComboBox
            // 
            this.refTableComboBox.FormattingEnabled = true;
            this.refTableComboBox.Location = new System.Drawing.Point(498, 12);
            this.refTableComboBox.Name = "refTableComboBox";
            this.refTableComboBox.Size = new System.Drawing.Size(290, 21);
            this.refTableComboBox.TabIndex = 2;
            this.refTableComboBox.TextChanged += new System.EventHandler(this.refTableComboBox_TextChanged);
            // 
            // depAttrListBox
            // 
            this.depAttrListBox.FormattingEnabled = true;
            this.depAttrListBox.Location = new System.Drawing.Point(12, 39);
            this.depAttrListBox.Name = "depAttrListBox";
            this.depAttrListBox.Size = new System.Drawing.Size(286, 199);
            this.depAttrListBox.TabIndex = 3;
            // 
            // refAttrListBox
            // 
            this.refAttrListBox.FormattingEnabled = true;
            this.refAttrListBox.Location = new System.Drawing.Point(498, 39);
            this.refAttrListBox.Name = "refAttrListBox";
            this.refAttrListBox.Size = new System.Drawing.Size(290, 199);
            this.refAttrListBox.TabIndex = 4;
            // 
            // CreateConnectionButton
            // 
            this.CreateConnectionButton.Location = new System.Drawing.Point(254, 392);
            this.CreateConnectionButton.Name = "CreateConnectionButton";
            this.CreateConnectionButton.Size = new System.Drawing.Size(292, 46);
            this.CreateConnectionButton.TabIndex = 5;
            this.CreateConnectionButton.Text = "Установить связь";
            this.CreateConnectionButton.UseVisualStyleBackColor = true;
            this.CreateConnectionButton.Click += new System.EventHandler(this.CreateConnectionButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(171, 290);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Внешний ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(635, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ссылка на атрибут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(322, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Добавьте описание";
            // 
            // ConnectionSetUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CreateConnectionButton);
            this.Controls.Add(this.refAttrListBox);
            this.Controls.Add(this.depAttrListBox);
            this.Controls.Add(this.refTableComboBox);
            this.Controls.Add(this.depTableComboBox);
            this.Controls.Add(this.BackButton);
            this.Name = "ConnectionSetUpForm";
            this.Text = "ConnectionSetUpForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectionSetUpForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox depTableComboBox;
        private System.Windows.Forms.ComboBox refTableComboBox;
        private System.Windows.Forms.ListBox depAttrListBox;
        private System.Windows.Forms.ListBox refAttrListBox;
        private System.Windows.Forms.Button CreateConnectionButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}