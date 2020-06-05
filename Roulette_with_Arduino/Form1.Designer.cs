namespace Roulette_with_Arduino
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serialCommToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboPorts = new System.Windows.Forms.ToolStripComboBox();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEvenUneven = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmdRequest = new System.Windows.Forms.Button();
            this.lboData = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialCommToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1562, 44);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serialCommToolStripMenuItem
            // 
            this.serialCommToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.serialCommToolStripMenuItem.Name = "serialCommToolStripMenuItem";
            this.serialCommToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.serialCommToolStripMenuItem.Text = "Serial Comm";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboPorts,
            this.openToolStripMenuItem});
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(172, 38);
            this.portToolStripMenuItem.Text = "Port";
            // 
            // cboPorts
            // 
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 40);
            this.cboPorts.Click += new System.EventHandler(this.cboPorts_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(172, 38);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(77, 225);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 25);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "label1";
            // 
            // lblEvenUneven
            // 
            this.lblEvenUneven.AutoSize = true;
            this.lblEvenUneven.Location = new System.Drawing.Point(154, 224);
            this.lblEvenUneven.Name = "lblEvenUneven";
            this.lblEvenUneven.Size = new System.Drawing.Size(70, 25);
            this.lblEvenUneven.TabIndex = 10;
            this.lblEvenUneven.Text = "label1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(82, 78);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 31);
            this.txtInput.TabIndex = 12;
            // 
            // cmdRequest
            // 
            this.cmdRequest.Location = new System.Drawing.Point(247, 78);
            this.cmdRequest.Name = "cmdRequest";
            this.cmdRequest.Size = new System.Drawing.Size(185, 55);
            this.cmdRequest.TabIndex = 13;
            this.cmdRequest.Text = "Rièn n va plus";
            this.cmdRequest.UseVisualStyleBackColor = true;
            this.cmdRequest.Click += new System.EventHandler(this.cmdRequest_Click);
            // 
            // lboData
            // 
            this.lboData.FormattingEnabled = true;
            this.lboData.ItemHeight = 25;
            this.lboData.Location = new System.Drawing.Point(479, 78);
            this.lboData.Name = "lboData";
            this.lboData.Size = new System.Drawing.Size(228, 429);
            this.lboData.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 832);
            this.Controls.Add(this.lboData);
            this.Controls.Add(this.cmdRequest);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblEvenUneven);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serialCommToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cboPorts;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEvenUneven;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button cmdRequest;
        private System.Windows.Forms.ListBox lboData;
    }
}

