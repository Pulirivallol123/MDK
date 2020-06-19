namespace MvideoWindowsForms
{
    partial class Connection_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection_Form));
            this.lblData = new System.Windows.Forms.Label();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.btChecked = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.lblServers = new System.Windows.Forms.Label();
            this.cbServers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData.Location = new System.Drawing.Point(0, 85);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(1077, 42);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "Название базы данных";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDatabases
            // 
            this.cbDatabases.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(0, 127);
            this.cbDatabases.Margin = new System.Windows.Forms.Padding(4);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(1077, 39);
            this.cbDatabases.TabIndex = 19;
            // 
            // btChecked
            // 
            this.btChecked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btChecked.Enabled = false;
            this.btChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btChecked.Location = new System.Drawing.Point(0, 166);
            this.btChecked.Margin = new System.Windows.Forms.Padding(4);
            this.btChecked.Name = "btChecked";
            this.btChecked.Size = new System.Drawing.Size(236, 193);
            this.btChecked.TabIndex = 20;
            this.btChecked.Text = "Проверка подключения";
            this.btChecked.UseVisualStyleBackColor = true;
            this.btChecked.Click += new System.EventHandler(this.BtCheked_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(877, 166);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(200, 193);
            this.btCancel.TabIndex = 25;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btConnect
            // 
            this.btConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConnect.Enabled = false;
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btConnect.Location = new System.Drawing.Point(236, 166);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(641, 193);
            this.btConnect.TabIndex = 26;
            this.btConnect.Text = "Подключиться";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // lblServers
            // 
            this.lblServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServers.Location = new System.Drawing.Point(0, 0);
            this.lblServers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(1077, 46);
            this.lblServers.TabIndex = 16;
            this.lblServers.Text = "Название сервера";
            this.lblServers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbServers
            // 
            this.cbServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Items.AddRange(new object[] {
            "DESKTOP-F28KLAR\\SQLEXPRESS"});
            this.cbServers.Location = new System.Drawing.Point(0, 46);
            this.cbServers.Margin = new System.Windows.Forms.Padding(4);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(1077, 39);
            this.cbServers.TabIndex = 17;
            this.cbServers.SelectedIndexChanged += new System.EventHandler(this.CbServers_SelectedIndexChanged);
            // 
            // Connection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 359);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChecked);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbServers);
            this.Controls.Add(this.lblServers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connection_Form";
            this.Text = "Настройка подключение к источнику данных";
            this.Load += new System.EventHandler(this.Connection_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Button btChecked;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.ComboBox cbServers;
    }
}