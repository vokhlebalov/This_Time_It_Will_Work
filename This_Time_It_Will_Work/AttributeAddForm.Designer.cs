
namespace This_Time_It_Will_Work
{
    partial class AttributeAddForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.AttrNametextBox = new System.Windows.Forms.TextBox();
            this.TypescomboBox = new System.Windows.Forms.ComboBox();
            this.StartValueTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UniqueCheckBox = new System.Windows.Forms.CheckBox();
            this.PrimKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 397);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 41);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(12, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(46, 18);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "label1";
            // 
            // AttrNametextBox
            // 
            this.AttrNametextBox.Location = new System.Drawing.Point(329, 50);
            this.AttrNametextBox.Name = "AttrNametextBox";
            this.AttrNametextBox.Size = new System.Drawing.Size(293, 20);
            this.AttrNametextBox.TabIndex = 2;
            // 
            // TypescomboBox
            // 
            this.TypescomboBox.FormattingEnabled = true;
            this.TypescomboBox.Items.AddRange(new object[] {
            "Varchar(255)",
            "Int",
            "Date"});
            this.TypescomboBox.Location = new System.Drawing.Point(329, 89);
            this.TypescomboBox.Name = "TypescomboBox";
            this.TypescomboBox.Size = new System.Drawing.Size(293, 21);
            this.TypescomboBox.TabIndex = 3;
            // 
            // StartValueTextBox
            // 
            this.StartValueTextBox.Location = new System.Drawing.Point(329, 130);
            this.StartValueTextBox.Name = "StartValueTextBox";
            this.StartValueTextBox.Size = new System.Drawing.Size(293, 20);
            this.StartValueTextBox.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(257, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(445, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование атрибута";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(225, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип атрибута";
            // 
            // UniqueCheckBox
            // 
            this.UniqueCheckBox.AutoSize = true;
            this.UniqueCheckBox.Location = new System.Drawing.Point(465, 175);
            this.UniqueCheckBox.Name = "UniqueCheckBox";
            this.UniqueCheckBox.Size = new System.Drawing.Size(15, 14);
            this.UniqueCheckBox.TabIndex = 12;
            this.UniqueCheckBox.UseVisualStyleBackColor = true;
            // 
            // PrimKeyCheckBox
            // 
            this.PrimKeyCheckBox.AutoSize = true;
            this.PrimKeyCheckBox.Location = new System.Drawing.Point(465, 210);
            this.PrimKeyCheckBox.Name = "PrimKeyCheckBox";
            this.PrimKeyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.PrimKeyCheckBox.TabIndex = 13;
            this.PrimKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Начальное значение (необязательно)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(144, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Является ли уникальным?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(67, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Входит ли в состав перичного ключа?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(113, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Описание атрибута";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(362, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить атрибут в таблицу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AttributeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrimKeyCheckBox);
            this.Controls.Add(this.UniqueCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.StartValueTextBox);
            this.Controls.Add(this.TypescomboBox);
            this.Controls.Add(this.AttrNametextBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.buttonBack);
            this.Name = "AttributeAddForm";
            this.Text = "AttributeAddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttributeAddForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox AttrNametextBox;
        private System.Windows.Forms.ComboBox TypescomboBox;
        private System.Windows.Forms.TextBox StartValueTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UniqueCheckBox;
        private System.Windows.Forms.CheckBox PrimKeyCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}