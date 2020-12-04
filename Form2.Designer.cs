namespace Auto_Blank_3._0
{
    partial class Form2
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
            this.markTB = new System.Windows.Forms.TextBox();
            this.fieldCB = new System.Windows.Forms.ComboBox();
            this.markL = new System.Windows.Forms.Label();
            this.fieldL = new System.Windows.Forms.Label();
            this.nextB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // markTB
            // 
            this.markTB.Location = new System.Drawing.Point(13, 48);
            this.markTB.Name = "markTB";
            this.markTB.Size = new System.Drawing.Size(185, 20);
            this.markTB.TabIndex = 0;
            // 
            // fieldCB
            // 
            this.fieldCB.FormattingEnabled = true;
            this.fieldCB.Location = new System.Drawing.Point(253, 47);
            this.fieldCB.Name = "fieldCB";
            this.fieldCB.Size = new System.Drawing.Size(185, 21);
            this.fieldCB.TabIndex = 1;
            // 
            // markL
            // 
            this.markL.AutoSize = true;
            this.markL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markL.Location = new System.Drawing.Point(13, 29);
            this.markL.Name = "markL";
            this.markL.Size = new System.Drawing.Size(44, 13);
            this.markL.TabIndex = 2;
            this.markL.Text = "Мітка:";
            // 
            // fieldL
            // 
            this.fieldL.AutoSize = true;
            this.fieldL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldL.Location = new System.Drawing.Point(253, 29);
            this.fieldL.Name = "fieldL";
            this.fieldL.Size = new System.Drawing.Size(41, 13);
            this.fieldL.TabIndex = 3;
            this.fieldL.Text = "Поле:";
            // 
            // nextB
            // 
            this.nextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextB.Location = new System.Drawing.Point(363, 102);
            this.nextB.Name = "nextB";
            this.nextB.Size = new System.Drawing.Size(75, 23);
            this.nextB.TabIndex = 4;
            this.nextB.Text = "Далі";
            this.nextB.UseVisualStyleBackColor = true;
            this.nextB.Click += new System.EventHandler(this.nextB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 151);
            this.Controls.Add(this.nextB);
            this.Controls.Add(this.fieldL);
            this.Controls.Add(this.markL);
            this.Controls.Add(this.fieldCB);
            this.Controls.Add(this.markTB);
            this.Name = "Form2";
            this.Text = "Оберіть";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox markTB;
        private System.Windows.Forms.ComboBox fieldCB;
        private System.Windows.Forms.Label markL;
        private System.Windows.Forms.Label fieldL;
        private System.Windows.Forms.Button nextB;
    }
}