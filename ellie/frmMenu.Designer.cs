﻿namespace Ellie
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnContar = new System.Windows.Forms.Button();
            this.btnContas = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pic_opcoes = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnJuntarCores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_opcoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.Transparent;
            this.btnContar.BackgroundImage = global::Ellie.Properties.Resources.MenuContar;
            this.btnContar.FlatAppearance.BorderSize = 0;
            this.btnContar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(92, 101);
            this.btnContar.Margin = new System.Windows.Forms.Padding(50);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(100, 100);
            this.btnContar.TabIndex = 0;
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnContas
            // 
            this.btnContas.BackColor = System.Drawing.Color.Transparent;
            this.btnContas.BackgroundImage = global::Ellie.Properties.Resources.MenuContas;
            this.btnContas.FlatAppearance.BorderSize = 0;
            this.btnContas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContas.Location = new System.Drawing.Point(228, 234);
            this.btnContas.Margin = new System.Windows.Forms.Padding(50);
            this.btnContas.Name = "btnContas";
            this.btnContas.Size = new System.Drawing.Size(100, 100);
            this.btnContas.TabIndex = 2;
            this.btnContas.UseVisualStyleBackColor = false;
            this.btnContas.Click += new System.EventHandler(this.button4_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = global::Ellie.Properties.Resources.door;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(904, 474);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 53);
            this.button11.TabIndex = 18;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(671, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(331, 47);
            this.button5.TabIndex = 19;
            this.button5.Text = "(Not Click Me!!)\r\nVai ser para ver se há novas versões";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pic_opcoes
            // 
            this.pic_opcoes.BackColor = System.Drawing.Color.Transparent;
            this.pic_opcoes.Image = global::Ellie.Properties.Resources.rodaDentada;
            this.pic_opcoes.Location = new System.Drawing.Point(960, 38);
            this.pic_opcoes.Name = "pic_opcoes";
            this.pic_opcoes.Size = new System.Drawing.Size(40, 40);
            this.pic_opcoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_opcoes.TabIndex = 20;
            this.pic_opcoes.TabStop = false;
            this.pic_opcoes.Click += new System.EventHandler(this.pic_opcoes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(671, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 241);
            this.button1.TabIndex = 21;
            this.button1.Text = "(Click Me!!)\r\nEste form irá aparecer aquando do arranque da aplicação";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Ellie.Properties.Resources.muteOff;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(868, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ellie.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(914, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnJuntarCores
            // 
            this.btnJuntarCores.BackColor = System.Drawing.Color.Transparent;
            this.btnJuntarCores.BackgroundImage = global::Ellie.Properties.Resources.menuJuntarCores;
            this.btnJuntarCores.FlatAppearance.BorderSize = 0;
            this.btnJuntarCores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnJuntarCores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnJuntarCores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuntarCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuntarCores.Location = new System.Drawing.Point(363, 101);
            this.btnJuntarCores.Margin = new System.Windows.Forms.Padding(50);
            this.btnJuntarCores.Name = "btnJuntarCores";
            this.btnJuntarCores.Size = new System.Drawing.Size(100, 100);
            this.btnJuntarCores.TabIndex = 24;
            this.btnJuntarCores.UseVisualStyleBackColor = false;
            this.btnJuntarCores.Click += new System.EventHandler(this.btnJuntarCores_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ellie.Properties.Resources.FundoJogos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 566);
            this.Controls.Add(this.btnJuntarCores);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_opcoes);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnContas);
            this.Controls.Add(this.btnContar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_opcoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pic_opcoes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnJuntarCores;
    }
}