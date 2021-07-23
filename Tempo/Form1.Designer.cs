using System.Drawing;
using System.Windows.Forms;

namespace Tempo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previsãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amanhãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ºDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(64, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(186, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(64, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Máxima";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(186, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mínima";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(130, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(109, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data da última atualização";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(130, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(109, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Localidade";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(128, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(109, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(109, 120);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(316, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.previsãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(392, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.alterarCidadeToolStripMenuItem, this.toolStripSeparator1, this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "&Ficheiro";
            // 
            // alterarCidadeToolStripMenuItem
            // 
            this.alterarCidadeToolStripMenuItem.Name = "alterarCidadeToolStripMenuItem";
            this.alterarCidadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alterarCidadeToolStripMenuItem.Text = "Alterar cidade";
            this.alterarCidadeToolStripMenuItem.Click += new System.EventHandler(this.alterarCidadeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // previsãoToolStripMenuItem
            // 
            this.previsãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.hojeToolStripMenuItem, this.amanhãToolStripMenuItem, this.diasToolStripMenuItem, this.diasToolStripMenuItem1, this.ºDiaToolStripMenuItem});
            this.previsãoToolStripMenuItem.Name = "previsãoToolStripMenuItem";
            this.previsãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.previsãoToolStripMenuItem.Text = "&Previsão";
            // 
            // hojeToolStripMenuItem
            // 
            this.hojeToolStripMenuItem.Name = "hojeToolStripMenuItem";
            this.hojeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hojeToolStripMenuItem.Text = "Hoje";
            this.hojeToolStripMenuItem.Click += new System.EventHandler(this.hojeToolStripMenuItem_Click);
            // 
            // amanhãToolStripMenuItem
            // 
            this.amanhãToolStripMenuItem.Name = "amanhãToolStripMenuItem";
            this.amanhãToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.amanhãToolStripMenuItem.Text = "Amanhã";
            this.amanhãToolStripMenuItem.Click += new System.EventHandler(this.amanhãToolStripMenuItem_Click);
            // 
            // diasToolStripMenuItem
            // 
            this.diasToolStripMenuItem.Name = "diasToolStripMenuItem";
            this.diasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.diasToolStripMenuItem.Text = "3º Dia";
            this.diasToolStripMenuItem.Click += new System.EventHandler(this.diasToolStripMenuItem_Click);
            // 
            // diasToolStripMenuItem1
            // 
            this.diasToolStripMenuItem1.Name = "diasToolStripMenuItem1";
            this.diasToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.diasToolStripMenuItem1.Text = "4º Dia";
            this.diasToolStripMenuItem1.Click += new System.EventHandler(this.diasToolStripMenuItem1_Click);
            // 
            // ºDiaToolStripMenuItem
            // 
            this.ºDiaToolStripMenuItem.Name = "ºDiaToolStripMenuItem";
            this.ºDiaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ºDiaToolStripMenuItem.Text = "5º Dia";
            this.ºDiaToolStripMenuItem.Click += new System.EventHandler(this.ºDiaToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(218, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Direção";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(239, 169);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(33, 20);
            this.textBox7.TabIndex = 14;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 386);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ToolStripMenuItem amanhãToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ºDiaToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem previsãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hojeToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarCidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        #endregion
    }
}