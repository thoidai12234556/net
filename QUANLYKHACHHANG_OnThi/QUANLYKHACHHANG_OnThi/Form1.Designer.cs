
namespace QUANLYKHACHHANG_OnThi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem1,
            this.quảnLíKháchHàngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.kiểmToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem1
            // 
            this.hệThốngToolStripMenuItem1.Name = "hệThốngToolStripMenuItem1";
            this.hệThốngToolStripMenuItem1.Size = new System.Drawing.Size(88, 26);
            this.hệThốngToolStripMenuItem1.Text = "Hệ Thống";
            // 
            // quảnLíKháchHàngToolStripMenuItem
            // 
            this.quảnLíKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dSKháchHàngToolStripMenuItem});
            this.quảnLíKháchHàngToolStripMenuItem.Name = "quảnLíKháchHàngToolStripMenuItem";
            this.quảnLíKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.quảnLíKháchHàngToolStripMenuItem.Text = "Quản Lí Khách Hàng";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // kiểmToánToolStripMenuItem
            // 
            this.kiểmToánToolStripMenuItem.Name = "kiểmToánToolStripMenuItem";
            this.kiểmToánToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.kiểmToánToolStripMenuItem.Text = "Kiểm Toán";
            // 
            // dSKháchHàngToolStripMenuItem
            // 
            this.dSKháchHàngToolStripMenuItem.Name = "dSKháchHàngToolStripMenuItem";
            this.dSKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dSKháchHàngToolStripMenuItem.Text = "DS Khách Hàng";
            this.dSKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.dSKháchHàngToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Danh Mục Chinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmToánToolStripMenuItem;
    }
}

