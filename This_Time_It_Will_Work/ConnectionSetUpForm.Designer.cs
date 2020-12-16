
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
            this.CreateConnectionButton.Location = new System.Drawing.Point(254, 288);
            this.CreateConnectionButton.Name = "CreateConnectionButton";
            this.CreateConnectionButton.Size = new System.Drawing.Size(292, 46);
            this.CreateConnectionButton.TabIndex = 5;
            this.CreateConnectionButton.Text = "button1";
            this.CreateConnectionButton.UseVisualStyleBackColor = true;
            this.CreateConnectionButton.Click += new System.EventHandler(this.CreateConnectionButton_Click);
            // 
            // ConnectionSetUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox depTableComboBox;
        private System.Windows.Forms.ComboBox refTableComboBox;
        private System.Windows.Forms.ListBox depAttrListBox;
        private System.Windows.Forms.ListBox refAttrListBox;
        private System.Windows.Forms.Button CreateConnectionButton;
    }
}