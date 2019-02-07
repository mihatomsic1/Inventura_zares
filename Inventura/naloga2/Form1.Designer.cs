namespace naloga2
{
    partial class Form1
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
            this.nameID = new System.Windows.Forms.TextBox();
            this.nameItem = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.izdelkiCombo = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameID
            // 
            this.nameID.Location = new System.Drawing.Point(117, 24);
            this.nameID.Name = "nameID";
            this.nameID.Size = new System.Drawing.Size(100, 20);
            this.nameID.TabIndex = 0;
            // 
            // nameItem
            // 
            this.nameItem.Location = new System.Drawing.Point(117, 57);
            this.nameItem.Name = "nameItem";
            this.nameItem.Size = new System.Drawing.Size(100, 20);
            this.nameItem.TabIndex = 1;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(117, 92);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(100, 20);
            this.priceText.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(45, 183);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(172, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Shrani";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID izdelka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena:";
            // 
            // izdelkiCombo
            // 
            this.izdelkiCombo.FormattingEnabled = true;
            this.izdelkiCombo.Location = new System.Drawing.Point(261, 23);
            this.izdelkiCombo.Name = "izdelkiCombo";
            this.izdelkiCombo.Size = new System.Drawing.Size(121, 21);
            this.izdelkiCombo.TabIndex = 7;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(261, 57);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Izbriši";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(261, 88);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(121, 23);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Posodobi";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 218);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.izdelkiCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.nameItem);
            this.Controls.Add(this.nameID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameID;
        private System.Windows.Forms.TextBox nameItem;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox izdelkiCombo;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
    }
}

