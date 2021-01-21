
using System.Drawing;
using System.IO;

namespace BaraholkaTeamProject
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKorsina = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.btnContact = new System.Windows.Forms.Button();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.pcBox = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemKorsina});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProfile,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // toolStripMenuItemProfile
            // 
            this.toolStripMenuItemProfile.Name = "toolStripMenuItemProfile";
            this.toolStripMenuItemProfile.Size = new System.Drawing.Size(151, 26);
            this.toolStripMenuItemProfile.Text = "Профіль";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(151, 26);
            this.toolStripMenuItemExit.Text = "Вийти";
            // 
            // toolStripMenuItemKorsina
            // 
            this.toolStripMenuItemKorsina.Name = "toolStripMenuItemKorsina";
            this.toolStripMenuItemKorsina.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItemKorsina.Text = "Корзина";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(153, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Пошук...";
            this.txtSearch.Size = new System.Drawing.Size(494, 41);
            this.txtSearch.TabIndex = 1;
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.btnAdd);
            this.gbUser.Controls.Add(this.btnContact);
            this.gbUser.Controls.Add(this.lblProductDescription);
            this.gbUser.Controls.Add(this.lblNameProduct);
            this.gbUser.Controls.Add(this.pcBox);
            this.gbUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbUser.Location = new System.Drawing.Point(153, 113);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(494, 224);
            this.gbUser.TabIndex = 2;
            this.gbUser.TabStop = false;
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContact.Location = new System.Drawing.Point(20, 171);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(125, 47);
            this.btnContact.TabIndex = 3;
            this.btnContact.Text = "Зв\'язатися з автором";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoEllipsis = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductDescription.Location = new System.Drawing.Point(161, 62);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(327, 82);
            this.lblProductDescription.TabIndex = 2;
            this.lblProductDescription.Text = "Опис продукту";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Location = new System.Drawing.Point(161, 23);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(156, 28);
            this.lblNameProduct.TabIndex = 1;
            this.lblNameProduct.Text = "Назва продукту";
            // 
            // pcBox
            // 
            this.pcBox.Location = new System.Drawing.Point(20, 23);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(125, 121);
            this.pcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBox.TabIndex = 0;
            this.pcBox.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(161, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 47);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додати в корзину";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKorsina;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.PictureBox pcBox;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnAdd;
    }
}