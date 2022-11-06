namespace CustomerServiceManagementWF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.IncidentSolutionPanel = new System.Windows.Forms.Panel();
            this.IncidentTextBox = new System.Windows.Forms.TextBox();
            this.SolutionTextBox = new System.Windows.Forms.TextBox();
            this.IncidentSignTextBox = new System.Windows.Forms.TextBox();
            this.SolutionSignTextBox = new System.Windows.Forms.TextBox();
            this.SearchDataButton = new System.Windows.Forms.Button();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.IncidentSolutionPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(327, 3);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(378, 23);
            this.SearchTextBox.TabIndex = 5;
            // 
            // IncidentSolutionPanel
            // 
            this.IncidentSolutionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncidentSolutionPanel.Controls.Add(this.IncidentTextBox);
            this.IncidentSolutionPanel.Controls.Add(this.SolutionTextBox);
            this.IncidentSolutionPanel.Controls.Add(this.IncidentSignTextBox);
            this.IncidentSolutionPanel.Controls.Add(this.SolutionSignTextBox);
            this.IncidentSolutionPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncidentSolutionPanel.Location = new System.Drawing.Point(13, 267);
            this.IncidentSolutionPanel.Name = "IncidentSolutionPanel";
            this.IncidentSolutionPanel.Size = new System.Drawing.Size(708, 232);
            this.IncidentSolutionPanel.TabIndex = 8;
            // 
            // IncidentTextBox
            // 
            this.IncidentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncidentTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IncidentTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncidentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncidentTextBox.Location = new System.Drawing.Point(3, 29);
            this.IncidentTextBox.Multiline = true;
            this.IncidentTextBox.Name = "IncidentTextBox";
            this.IncidentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IncidentTextBox.Size = new System.Drawing.Size(702, 81);
            this.IncidentTextBox.TabIndex = 9;
            this.IncidentTextBox.TextChanged += new System.EventHandler(this.IncidentTextBox_TextChanged);
            // 
            // SolutionTextBox
            // 
            this.SolutionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolutionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SolutionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SolutionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolutionTextBox.Location = new System.Drawing.Point(3, 142);
            this.SolutionTextBox.Multiline = true;
            this.SolutionTextBox.Name = "SolutionTextBox";
            this.SolutionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SolutionTextBox.Size = new System.Drawing.Size(702, 81);
            this.SolutionTextBox.TabIndex = 10;
            this.SolutionTextBox.TextChanged += new System.EventHandler(this.SolutionTextBox_TextChanged);
            // 
            // IncidentSignTextBox
            // 
            this.IncidentSignTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IncidentSignTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncidentSignTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncidentSignTextBox.Location = new System.Drawing.Point(3, 10);
            this.IncidentSignTextBox.Name = "IncidentSignTextBox";
            this.IncidentSignTextBox.Size = new System.Drawing.Size(100, 13);
            this.IncidentSignTextBox.TabIndex = 11;
            this.IncidentSignTextBox.Text = "Обращение";
            // 
            // SolutionSignTextBox
            // 
            this.SolutionSignTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SolutionSignTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SolutionSignTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SolutionSignTextBox.Location = new System.Drawing.Point(3, 123);
            this.SolutionSignTextBox.Name = "SolutionSignTextBox";
            this.SolutionSignTextBox.Size = new System.Drawing.Size(100, 13);
            this.SolutionSignTextBox.TabIndex = 12;
            this.SolutionSignTextBox.Text = "Решение";
            // 
            // SearchDataButton
            // 
            this.SearchDataButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchDataButton.Location = new System.Drawing.Point(246, 3);
            this.SearchDataButton.Name = "SearchDataButton";
            this.SearchDataButton.Size = new System.Drawing.Size(69, 23);
            this.SearchDataButton.TabIndex = 4;
            this.SearchDataButton.Text = "Найти";
            this.SearchDataButton.UseVisualStyleBackColor = true;
            this.SearchDataButton.Click += new System.EventHandler(this.SearchDataButton_Click);
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveDataButton.Location = new System.Drawing.Point(165, 3);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(69, 23);
            this.SaveDataButton.TabIndex = 3;
            this.SaveDataButton.Text = "Сохранить";
            this.SaveDataButton.UseVisualStyleBackColor = true;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // AddDataButton
            // 
            this.AddDataButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddDataButton.Location = new System.Drawing.Point(84, 3);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(69, 23);
            this.AddDataButton.TabIndex = 2;
            this.AddDataButton.Text = "Создать";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // GetDataButton
            // 
            this.GetDataButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.GetDataButton.Location = new System.Drawing.Point(3, 3);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(69, 23);
            this.GetDataButton.TabIndex = 1;
            this.GetDataButton.Text = "Обновить";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.Controls.Add(this.GetDataButton);
            this.ButtonsPanel.Controls.Add(this.AddDataButton);
            this.ButtonsPanel.Controls.Add(this.SaveDataButton);
            this.ButtonsPanel.Controls.Add(this.SearchTextBox);
            this.ButtonsPanel.Controls.Add(this.SearchDataButton);
            this.ButtonsPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonsPanel.Location = new System.Drawing.Point(13, 12);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(708, 35);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.DataGridView);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainPanel.Location = new System.Drawing.Point(13, 53);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(708, 208);
            this.MainPanel.TabIndex = 6;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(3, 3);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.Size = new System.Drawing.Size(702, 202);
            this.DataGridView.TabIndex = 7;
            this.DataGridView.CurrentCellChanged += new System.EventHandler(this.DataGridView_CurrentCellChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.IncidentSolutionPanel);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Service Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.IncidentSolutionPanel.ResumeLayout(false);
            this.IncidentSolutionPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel IncidentSolutionPanel;
        private System.Windows.Forms.TextBox SolutionTextBox;
        private System.Windows.Forms.TextBox SolutionSignTextBox;
        private System.Windows.Forms.TextBox IncidentTextBox;
        private System.Windows.Forms.TextBox IncidentSignTextBox;
        private System.Windows.Forms.Button SearchDataButton;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.DataGridView DataGridView;
    }
}