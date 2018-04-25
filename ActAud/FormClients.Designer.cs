namespace ActAud
{
    partial class FormClients
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
            this.lsbClients = new System.Windows.Forms.ListBox();
            this.lbClients = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbClients
            // 
            this.lsbClients.FormattingEnabled = true;
            this.lsbClients.Location = new System.Drawing.Point(12, 28);
            this.lsbClients.Name = "lsbClients";
            this.lsbClients.Size = new System.Drawing.Size(296, 290);
            this.lsbClients.TabIndex = 0;
            this.lsbClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbClients_MouseDoubleClick);
            // 
            // lbClients
            // 
            this.lbClients.AutoSize = true;
            this.lbClients.Location = new System.Drawing.Point(73, 9);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(151, 13);
            this.lbClients.TabIndex = 1;
            this.lbClients.Text = "Список компьютеров в сети";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск компьютеров";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 349);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.lsbClients);
            this.Name = "FormClients";
            this.Text = "Мониторинг событий информационной безопасности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbClients;
        private System.Windows.Forms.Label lbClients;
        private System.Windows.Forms.Button btnSearch;
    }
}