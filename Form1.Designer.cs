namespace Auto_Blank_3._0
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
            this.components = new System.ComponentModel.Container();
            this.wdPathB = new System.Windows.Forms.Button();
            this.wdPathTB = new System.Windows.Forms.TextBox();
            this.nextB = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wdPathL = new System.Windows.Forms.Label();
            this.xlPathL = new System.Windows.Forms.Label();
            this.xlPathTB = new System.Windows.Forms.TextBox();
            this.xlPathB = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wdPathB
            // 
            this.wdPathB.Location = new System.Drawing.Point(333, 51);
            this.wdPathB.Name = "wdPathB";
            this.wdPathB.Size = new System.Drawing.Size(75, 23);
            this.wdPathB.TabIndex = 0;
            this.wdPathB.Text = "Знайти";
            this.wdPathB.UseVisualStyleBackColor = true;
            this.wdPathB.Click += new System.EventHandler(this.wdPathB_Click);
            // 
            // wdPathTB
            // 
            this.wdPathTB.Location = new System.Drawing.Point(12, 53);
            this.wdPathTB.Name = "wdPathTB";
            this.wdPathTB.Size = new System.Drawing.Size(300, 20);
            this.wdPathTB.TabIndex = 1;
            // 
            // nextB
            // 
            this.nextB.Location = new System.Drawing.Point(337, 144);
            this.nextB.Name = "nextB";
            this.nextB.Size = new System.Drawing.Size(75, 23);
            this.nextB.TabIndex = 2;
            this.nextB.Text = "Далі";
            this.nextB.UseVisualStyleBackColor = true;
            this.nextB.Click += new System.EventHandler(this.nextB_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Auto_Blank_3._0.Form1);
            // 
            // wdPathL
            // 
            this.wdPathL.AutoSize = true;
            this.wdPathL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wdPathL.Location = new System.Drawing.Point(12, 34);
            this.wdPathL.Name = "wdPathL";
            this.wdPathL.Size = new System.Drawing.Size(172, 13);
            this.wdPathL.TabIndex = 4;
            this.wdPathL.Text = "Оберіть шаблон документа:";
            // 
            // xlPathL
            // 
            this.xlPathL.AutoSize = true;
            this.xlPathL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xlPathL.Location = new System.Drawing.Point(14, 83);
            this.xlPathL.Name = "xlPathL";
            this.xlPathL.Size = new System.Drawing.Size(126, 13);
            this.xlPathL.TabIndex = 7;
            this.xlPathL.Text = "Оберіть базу даних:";
            // 
            // xlPathTB
            // 
            this.xlPathTB.Location = new System.Drawing.Point(14, 102);
            this.xlPathTB.Name = "xlPathTB";
            this.xlPathTB.Size = new System.Drawing.Size(300, 20);
            this.xlPathTB.TabIndex = 6;
            // 
            // xlPathB
            // 
            this.xlPathB.Location = new System.Drawing.Point(335, 100);
            this.xlPathB.Name = "xlPathB";
            this.xlPathB.Size = new System.Drawing.Size(75, 23);
            this.xlPathB.TabIndex = 5;
            this.xlPathB.Text = "Знайти";
            this.xlPathB.UseVisualStyleBackColor = true;
            this.xlPathB.Click += new System.EventHandler(this.xlPathB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 185);
            this.Controls.Add(this.xlPathL);
            this.Controls.Add(this.xlPathTB);
            this.Controls.Add(this.xlPathB);
            this.Controls.Add(this.wdPathL);
            this.Controls.Add(this.nextB);
            this.Controls.Add(this.wdPathTB);
            this.Controls.Add(this.wdPathB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Auto Blank";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wdPathB;
        private System.Windows.Forms.TextBox wdPathTB;
        private System.Windows.Forms.Button nextB;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Label wdPathL;
        private System.Windows.Forms.Label xlPathL;
        private System.Windows.Forms.TextBox xlPathTB;
        private System.Windows.Forms.Button xlPathB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
    }
}

