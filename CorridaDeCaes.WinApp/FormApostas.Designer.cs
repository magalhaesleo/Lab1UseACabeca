namespace CorridaDeCaes.WinApp
{
    partial class FormApostas
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
            this.lblApostaMinima = new System.Windows.Forms.Label();
            this.radioJoao = new System.Windows.Forms.RadioButton();
            this.radioBeto = new System.Windows.Forms.RadioButton();
            this.radioAlfredo = new System.Windows.Forms.RadioButton();
            this.gpBoxBalcao = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txtCao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAposta = new System.Windows.Forms.Button();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.lblAlfredo = new System.Windows.Forms.Label();
            this.lblBeto = new System.Windows.Forms.Label();
            this.lblJoao = new System.Windows.Forms.Label();
            this.lblSelectedGuy = new System.Windows.Forms.Label();
            this.picBDog4 = new System.Windows.Forms.PictureBox();
            this.picBDog3 = new System.Windows.Forms.PictureBox();
            this.picBDog2 = new System.Windows.Forms.PictureBox();
            this.picBDog1 = new System.Windows.Forms.PictureBox();
            this.picBPista = new System.Windows.Forms.PictureBox();
            this.gpBoxBalcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBPista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApostaMinima
            // 
            this.lblApostaMinima.AutoSize = true;
            this.lblApostaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaMinima.Location = new System.Drawing.Point(6, 26);
            this.lblApostaMinima.Name = "lblApostaMinima";
            this.lblApostaMinima.Size = new System.Drawing.Size(142, 13);
            this.lblApostaMinima.TabIndex = 5;
            this.lblApostaMinima.Text = "Aposta Mínima: 5 Reais";
            // 
            // radioJoao
            // 
            this.radioJoao.AutoSize = true;
            this.radioJoao.Location = new System.Drawing.Point(30, 42);
            this.radioJoao.Name = "radioJoao";
            this.radioJoao.Size = new System.Drawing.Size(48, 17);
            this.radioJoao.TabIndex = 6;
            this.radioJoao.TabStop = true;
            this.radioJoao.Text = "João";
            this.radioJoao.UseVisualStyleBackColor = true;
            this.radioJoao.CheckedChanged += new System.EventHandler(this.radioJoao_CheckedChanged);
            // 
            // radioBeto
            // 
            this.radioBeto.AutoSize = true;
            this.radioBeto.Location = new System.Drawing.Point(30, 65);
            this.radioBeto.Name = "radioBeto";
            this.radioBeto.Size = new System.Drawing.Size(47, 17);
            this.radioBeto.TabIndex = 7;
            this.radioBeto.TabStop = true;
            this.radioBeto.Text = "Beto";
            this.radioBeto.UseVisualStyleBackColor = true;
            this.radioBeto.CheckedChanged += new System.EventHandler(this.radioBeto_CheckedChanged);
            // 
            // radioAlfredo
            // 
            this.radioAlfredo.AutoSize = true;
            this.radioAlfredo.Location = new System.Drawing.Point(30, 88);
            this.radioAlfredo.Name = "radioAlfredo";
            this.radioAlfredo.Size = new System.Drawing.Size(58, 17);
            this.radioAlfredo.TabIndex = 8;
            this.radioAlfredo.TabStop = true;
            this.radioAlfredo.Text = "Alfredo";
            this.radioAlfredo.UseVisualStyleBackColor = true;
            this.radioAlfredo.CheckedChanged += new System.EventHandler(this.radioAlfredo_CheckedChanged);
            // 
            // gpBoxBalcao
            // 
            this.gpBoxBalcao.Controls.Add(this.btnReiniciar);
            this.gpBoxBalcao.Controls.Add(this.txtCao);
            this.gpBoxBalcao.Controls.Add(this.label1);
            this.gpBoxBalcao.Controls.Add(this.txtValor);
            this.gpBoxBalcao.Controls.Add(this.btnAposta);
            this.gpBoxBalcao.Controls.Add(this.btnCorrer);
            this.gpBoxBalcao.Controls.Add(this.lblAlfredo);
            this.gpBoxBalcao.Controls.Add(this.lblBeto);
            this.gpBoxBalcao.Controls.Add(this.lblJoao);
            this.gpBoxBalcao.Controls.Add(this.lblSelectedGuy);
            this.gpBoxBalcao.Controls.Add(this.lblApostaMinima);
            this.gpBoxBalcao.Controls.Add(this.radioJoao);
            this.gpBoxBalcao.Controls.Add(this.radioBeto);
            this.gpBoxBalcao.Controls.Add(this.radioAlfredo);
            this.gpBoxBalcao.Location = new System.Drawing.Point(0, 208);
            this.gpBoxBalcao.Name = "gpBoxBalcao";
            this.gpBoxBalcao.Size = new System.Drawing.Size(602, 145);
            this.gpBoxBalcao.TabIndex = 14;
            this.gpBoxBalcao.TabStop = false;
            this.gpBoxBalcao.Text = "Balcão de Apostas";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(417, 117);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(103, 23);
            this.btnReiniciar.TabIndex = 19;
            this.btnReiniciar.Text = "Reiniciar Corrida";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // txtCao
            // 
            this.txtCao.Location = new System.Drawing.Point(356, 119);
            this.txtCao.Name = "txtCao";
            this.txtCao.Size = new System.Drawing.Size(55, 20);
            this.txtCao.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "reais no cão numero";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(186, 120);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(55, 20);
            this.txtValor.TabIndex = 16;
            this.txtValor.Text = "5";
            // 
            // btnAposta
            // 
            this.btnAposta.Location = new System.Drawing.Point(105, 120);
            this.btnAposta.Name = "btnAposta";
            this.btnAposta.Size = new System.Drawing.Size(75, 20);
            this.btnAposta.TabIndex = 15;
            this.btnAposta.Text = "Aposta";
            this.btnAposta.UseVisualStyleBackColor = true;
            this.btnAposta.Click += new System.EventHandler(this.btnAposta_Click);
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(526, 116);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(68, 23);
            this.btnCorrer.TabIndex = 14;
            this.btnCorrer.Text = "Corram!";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // lblAlfredo
            // 
            this.lblAlfredo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlfredo.Location = new System.Drawing.Point(356, 89);
            this.lblAlfredo.Name = "lblAlfredo";
            this.lblAlfredo.Size = new System.Drawing.Size(238, 17);
            this.lblAlfredo.TabIndex = 13;
            this.lblAlfredo.Text = "Alfredo ainda não apostou";
            // 
            // lblBeto
            // 
            this.lblBeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBeto.Location = new System.Drawing.Point(356, 66);
            this.lblBeto.Name = "lblBeto";
            this.lblBeto.Size = new System.Drawing.Size(238, 17);
            this.lblBeto.TabIndex = 12;
            this.lblBeto.Text = "Beto ainda não apostou";
            // 
            // lblJoao
            // 
            this.lblJoao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoao.Location = new System.Drawing.Point(356, 42);
            this.lblJoao.Name = "lblJoao";
            this.lblJoao.Size = new System.Drawing.Size(238, 17);
            this.lblJoao.TabIndex = 11;
            this.lblJoao.Text = "João ainda não apostou";
            // 
            // lblSelectedGuy
            // 
            this.lblSelectedGuy.Location = new System.Drawing.Point(12, 119);
            this.lblSelectedGuy.Name = "lblSelectedGuy";
            this.lblSelectedGuy.Size = new System.Drawing.Size(87, 20);
            this.lblSelectedGuy.TabIndex = 9;
            this.lblSelectedGuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBDog4
            // 
            this.picBDog4.Image = global::CorridaDeCaes.WinApp.Properties.Resources.dog;
            this.picBDog4.Location = new System.Drawing.Point(9, 168);
            this.picBDog4.Name = "picBDog4";
            this.picBDog4.Size = new System.Drawing.Size(75, 20);
            this.picBDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBDog4.TabIndex = 13;
            this.picBDog4.TabStop = false;
            this.picBDog4.Click += new System.EventHandler(this.picBDog4_Click);
            // 
            // picBDog3
            // 
            this.picBDog3.Image = global::CorridaDeCaes.WinApp.Properties.Resources.dog;
            this.picBDog3.Location = new System.Drawing.Point(9, 116);
            this.picBDog3.Name = "picBDog3";
            this.picBDog3.Size = new System.Drawing.Size(75, 20);
            this.picBDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBDog3.TabIndex = 12;
            this.picBDog3.TabStop = false;
            this.picBDog3.Click += new System.EventHandler(this.picBDog3_Click);
            // 
            // picBDog2
            // 
            this.picBDog2.Image = global::CorridaDeCaes.WinApp.Properties.Resources.dog;
            this.picBDog2.Location = new System.Drawing.Point(9, 63);
            this.picBDog2.Name = "picBDog2";
            this.picBDog2.Size = new System.Drawing.Size(75, 20);
            this.picBDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBDog2.TabIndex = 11;
            this.picBDog2.TabStop = false;
            this.picBDog2.Click += new System.EventHandler(this.picBDog2_Click);
            // 
            // picBDog1
            // 
            this.picBDog1.Image = global::CorridaDeCaes.WinApp.Properties.Resources.dog;
            this.picBDog1.Location = new System.Drawing.Point(9, 12);
            this.picBDog1.Name = "picBDog1";
            this.picBDog1.Size = new System.Drawing.Size(75, 20);
            this.picBDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBDog1.TabIndex = 2;
            this.picBDog1.TabStop = false;
            this.picBDog1.Click += new System.EventHandler(this.picBDog1_Click);
            // 
            // picBPista
            // 
            this.picBPista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBPista.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBPista.Image = global::CorridaDeCaes.WinApp.Properties.Resources.racetrack;
            this.picBPista.Location = new System.Drawing.Point(0, 0);
            this.picBPista.Name = "picBPista";
            this.picBPista.Size = new System.Drawing.Size(602, 202);
            this.picBPista.TabIndex = 10;
            this.picBPista.TabStop = false;
            // 
            // FormApostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 353);
            this.Controls.Add(this.picBDog4);
            this.Controls.Add(this.picBDog3);
            this.Controls.Add(this.picBDog2);
            this.Controls.Add(this.picBDog1);
            this.Controls.Add(this.picBPista);
            this.Controls.Add(this.gpBoxBalcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormApostas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Um dia de Corrida";
            this.gpBoxBalcao.ResumeLayout(false);
            this.gpBoxBalcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBPista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBDog1;
        private System.Windows.Forms.Label lblApostaMinima;
        private System.Windows.Forms.RadioButton radioJoao;
        private System.Windows.Forms.RadioButton radioBeto;
        private System.Windows.Forms.RadioButton radioAlfredo;
        private System.Windows.Forms.PictureBox picBPista;
        private System.Windows.Forms.PictureBox picBDog2;
        private System.Windows.Forms.PictureBox picBDog3;
        private System.Windows.Forms.PictureBox picBDog4;
        private System.Windows.Forms.GroupBox gpBoxBalcao;
        private System.Windows.Forms.Label lblSelectedGuy;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.Label lblAlfredo;
        private System.Windows.Forms.Label lblBeto;
        private System.Windows.Forms.Label lblJoao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAposta;
        private System.Windows.Forms.TextBox txtCao;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

