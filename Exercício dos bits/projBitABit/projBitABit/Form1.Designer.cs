namespace projBitABit
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblBase10 = new System.Windows.Forms.Label();
            this.lblBase2 = new System.Windows.Forms.Label();
            this.lblBase16 = new System.Windows.Forms.Label();
            this.lblInformeUmNumero = new System.Windows.Forms.Label();
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblHexadecimal = new System.Windows.Forms.Label();
            this.chkBit1 = new System.Windows.Forms.CheckBox();
            this.chkBit4 = new System.Windows.Forms.CheckBox();
            this.chkBit3 = new System.Windows.Forms.CheckBox();
            this.chkBit2 = new System.Windows.Forms.CheckBox();
            this.chkBit6 = new System.Windows.Forms.CheckBox();
            this.chkBit7 = new System.Windows.Forms.CheckBox();
            this.chkBit8 = new System.Windows.Forms.CheckBox();
            this.chkBit5 = new System.Windows.Forms.CheckBox();
            this.picSwitch8 = new System.Windows.Forms.PictureBox();
            this.picSwitch7 = new System.Windows.Forms.PictureBox();
            this.picSwitch5 = new System.Windows.Forms.PictureBox();
            this.picSwitch6 = new System.Windows.Forms.PictureBox();
            this.picSwitch3 = new System.Windows.Forms.PictureBox();
            this.picSwitch4 = new System.Windows.Forms.PictureBox();
            this.picSwitch1 = new System.Windows.Forms.PictureBox();
            this.picSwitch2 = new System.Windows.Forms.PictureBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnDesligadoLigado = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNumero.Location = new System.Drawing.Point(320, 31);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(303, 30);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.Text = "0";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOK.Location = new System.Drawing.Point(407, 80);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.clickou_em_SET);
            // 
            // lblBase10
            // 
            this.lblBase10.AutoSize = true;
            this.lblBase10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBase10.Location = new System.Drawing.Point(803, 194);
            this.lblBase10.Name = "lblBase10";
            this.lblBase10.Size = new System.Drawing.Size(45, 25);
            this.lblBase10.TabIndex = 2;
            this.lblBase10.Text = "000";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBase2.Location = new System.Drawing.Point(247, 194);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(100, 25);
            this.lblBase2.TabIndex = 3;
            this.lblBase2.Text = "00000000";
            // 
            // lblBase16
            // 
            this.lblBase16.AutoSize = true;
            this.lblBase16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBase16.Location = new System.Drawing.Point(1358, 194);
            this.lblBase16.Name = "lblBase16";
            this.lblBase16.Size = new System.Drawing.Size(34, 25);
            this.lblBase16.TabIndex = 4;
            this.lblBase16.Text = "00";
            // 
            // lblInformeUmNumero
            // 
            this.lblInformeUmNumero.AutoSize = true;
            this.lblInformeUmNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeUmNumero.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInformeUmNumero.Location = new System.Drawing.Point(40, 34);
            this.lblInformeUmNumero.Name = "lblInformeUmNumero";
            this.lblInformeUmNumero.Size = new System.Drawing.Size(191, 25);
            this.lblInformeUmNumero.TabIndex = 19;
            this.lblInformeUmNumero.Text = "Informe um número: ";
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBinario.Location = new System.Drawing.Point(86, 194);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(44, 25);
            this.lblBinario.TabIndex = 20;
            this.lblBinario.Text = "BIN";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDecimal.Location = new System.Drawing.Point(656, 194);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(54, 25);
            this.lblDecimal.TabIndex = 21;
            this.lblDecimal.Text = "DEC";
            // 
            // lblHexadecimal
            // 
            this.lblHexadecimal.AutoSize = true;
            this.lblHexadecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexadecimal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHexadecimal.Location = new System.Drawing.Point(1197, 194);
            this.lblHexadecimal.Name = "lblHexadecimal";
            this.lblHexadecimal.Size = new System.Drawing.Size(53, 25);
            this.lblHexadecimal.TabIndex = 22;
            this.lblHexadecimal.Text = "HEX";
            // 
            // chkBit1
            // 
            this.chkBit1.AutoSize = true;
            this.chkBit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkBit1.Location = new System.Drawing.Point(1347, 468);
            this.chkBit1.Margin = new System.Windows.Forms.Padding(4);
            this.chkBit1.Name = "chkBit1";
            this.chkBit1.Size = new System.Drawing.Size(72, 29);
            this.chkBit1.TabIndex = 23;
            this.chkBit1.Tag = "1";
            this.chkBit1.Text = "Bit 1";
            this.chkBit1.UseVisualStyleBackColor = true;
            this.chkBit1.Click += new System.EventHandler(this.clickou_no_chk);
            // 
            // chkBit4
            // 
            this.chkBit4.AutoSize = true;
            this.chkBit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkBit4.Location = new System.Drawing.Point(788, 468);
            this.chkBit4.Margin = new System.Windows.Forms.Padding(4);
            this.chkBit4.Name = "chkBit4";
            this.chkBit4.Size = new System.Drawing.Size(72, 29);
            this.chkBit4.TabIndex = 24;
            this.chkBit4.Tag = "4";
            this.chkBit4.Text = "Bit 4";
            this.chkBit4.UseVisualStyleBackColor = true;
            this.chkBit4.Click += new System.EventHandler(this.clickou_no_chk);
            // 
            // chkBit3
            // 
            this.chkBit3.AutoSize = true;
            this.chkBit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkBit3.Location = new System.Drawing.Point(978, 468);
            this.chkBit3.Margin = new System.Windows.Forms.Padding(4);
            this.chkBit3.Name = "chkBit3";
            this.chkBit3.Size = new System.Drawing.Size(72, 29);
            this.chkBit3.TabIndex = 25;
            this.chkBit3.Tag = "3";
            this.chkBit3.Text = "Bit 3";
            this.chkBit3.UseVisualStyleBackColor = true;
            this.chkBit3.Click += new System.EventHandler(this.clickou_no_chk);
            // 
            // chkBit2
            // 
            this.chkBit2.AutoSize = true;
            this.chkBit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkBit2.Location = new System.Drawing.Point(1163, 468);
            this.chkBit2.Margin = new System.Windows.Forms.Padding(4);
            this.chkBit2.Name = "chkBit2";
            this.chkBit2.Size = new System.Drawing.Size(72, 29);
            this.chkBit2.TabIndex = 26;
            this.chkBit2.Tag = "2";
            this.chkBit2.Text = "Bit 2";
            this.chkBit2.UseVisualStyleBackColor = true;
            this.chkBit2.Click += new System.EventHandler(this.clickou_no_chk);
            // 
            // chkBit6
            // 
            this.chkBit6.AutoSize = true;
            this.chkBit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkBit6.Location = new System.Drawing.Point(424, 468);
            this.chkBit6.Margin = new System.Windows.Forms.Padding(4);
            this.chkBit6.Name = "chkBit6";
            this.chkBit6.Size = new System.Drawing.Size(72, 29);
            this.chkBit6.TabIndex = 30;
            this.chkBit6.Tag = "6";
            this.chkBit6.Text = "Bit 6";
            this.chkBit6.UseVisualStyleBackColor = true;
            this.chkBit6.Click += new System.EventHandler(this.clickou_no_chk);
            // 
            // chkBit7
            // 
            this.chkBit7.AutoSize = true;
            this.chkBit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkBit7.Location = new System.Drawing.Point(245, 468);
            this.chkBit7.Margin = new System.Windows.Forms.Padding(4);
            this.chkBit7.Name = "chkBit7";
            this.chkBit7.Size = new System.Drawing.Size(72, 29);
            this.chkBit7.TabIndex = 29;
            this.chkBit7.Tag = "7";
            this.chkBit7.Text = "Bit 7";
            this.chkBit7.UseVisualStyleBackColor = true;
            this.chkBit7.Click += new System.EventHandler(this.clickou_no_chk);
            // 
            // chkBit8
            // 
            this.chkBit8.AutoSize = true;
            this.chkBit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkBit8.Location = new System.Drawing.Point(64, 468);
            this.chkBit8.Margin = new System.Windows.Forms.Padding(4);
            this.chkBit8.Name = "chkBit8";
            this.chkBit8.Size = new System.Drawing.Size(72, 29);
            this.chkBit8.TabIndex = 28;
            this.chkBit8.Tag = "8";
            this.chkBit8.Text = "Bit 8";
            this.chkBit8.UseVisualStyleBackColor = true;
            this.chkBit8.Click += new System.EventHandler(this.clickou_no_chk);
            // 
            // chkBit5
            // 
            this.chkBit5.AutoSize = true;
            this.chkBit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBit5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkBit5.Location = new System.Drawing.Point(610, 468);
            this.chkBit5.Margin = new System.Windows.Forms.Padding(4);
            this.chkBit5.Name = "chkBit5";
            this.chkBit5.Size = new System.Drawing.Size(72, 29);
            this.chkBit5.TabIndex = 27;
            this.chkBit5.Tag = "5";
            this.chkBit5.Text = "Bit 5";
            this.chkBit5.UseVisualStyleBackColor = true;
            this.chkBit5.Click += new System.EventHandler(this.clickou_no_chk);
            // 
            // picSwitch8
            // 
            this.picSwitch8.Image = global::projBitABit.Properties.Resources.Button_OFF;
            this.picSwitch8.Location = new System.Drawing.Point(25, 342);
            this.picSwitch8.Name = "picSwitch8";
            this.picSwitch8.Size = new System.Drawing.Size(140, 81);
            this.picSwitch8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSwitch8.TabIndex = 31;
            this.picSwitch8.TabStop = false;
            this.picSwitch8.Tag = "8";
            // 
            // picSwitch7
            // 
            this.picSwitch7.Image = global::projBitABit.Properties.Resources.Button_OFF;
            this.picSwitch7.Location = new System.Drawing.Point(209, 342);
            this.picSwitch7.Name = "picSwitch7";
            this.picSwitch7.Size = new System.Drawing.Size(140, 81);
            this.picSwitch7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSwitch7.TabIndex = 32;
            this.picSwitch7.TabStop = false;
            this.picSwitch7.Tag = "7";
            // 
            // picSwitch5
            // 
            this.picSwitch5.Image = global::projBitABit.Properties.Resources.Button_OFF;
            this.picSwitch5.Location = new System.Drawing.Point(573, 342);
            this.picSwitch5.Name = "picSwitch5";
            this.picSwitch5.Size = new System.Drawing.Size(140, 81);
            this.picSwitch5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSwitch5.TabIndex = 34;
            this.picSwitch5.TabStop = false;
            this.picSwitch5.Tag = "5";
            // 
            // picSwitch6
            // 
            this.picSwitch6.Image = global::projBitABit.Properties.Resources.Button_OFF;
            this.picSwitch6.Location = new System.Drawing.Point(389, 342);
            this.picSwitch6.Name = "picSwitch6";
            this.picSwitch6.Size = new System.Drawing.Size(140, 81);
            this.picSwitch6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSwitch6.TabIndex = 33;
            this.picSwitch6.TabStop = false;
            this.picSwitch6.Tag = "6";
            // 
            // picSwitch3
            // 
            this.picSwitch3.Image = global::projBitABit.Properties.Resources.Button_OFF;
            this.picSwitch3.Location = new System.Drawing.Point(941, 342);
            this.picSwitch3.Name = "picSwitch3";
            this.picSwitch3.Size = new System.Drawing.Size(140, 81);
            this.picSwitch3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSwitch3.TabIndex = 36;
            this.picSwitch3.TabStop = false;
            this.picSwitch3.Tag = "3";
            // 
            // picSwitch4
            // 
            this.picSwitch4.Image = global::projBitABit.Properties.Resources.Button_OFF;
            this.picSwitch4.Location = new System.Drawing.Point(757, 342);
            this.picSwitch4.Name = "picSwitch4";
            this.picSwitch4.Size = new System.Drawing.Size(140, 81);
            this.picSwitch4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSwitch4.TabIndex = 35;
            this.picSwitch4.TabStop = false;
            this.picSwitch4.Tag = "4";
            // 
            // picSwitch1
            // 
            this.picSwitch1.Image = global::projBitABit.Properties.Resources.Button_OFF;
            this.picSwitch1.Location = new System.Drawing.Point(1311, 342);
            this.picSwitch1.Name = "picSwitch1";
            this.picSwitch1.Size = new System.Drawing.Size(140, 81);
            this.picSwitch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSwitch1.TabIndex = 38;
            this.picSwitch1.TabStop = false;
            this.picSwitch1.Tag = "1";
            // 
            // picSwitch2
            // 
            this.picSwitch2.Image = global::projBitABit.Properties.Resources.Button_OFF;
            this.picSwitch2.Location = new System.Drawing.Point(1127, 342);
            this.picSwitch2.Name = "picSwitch2";
            this.picSwitch2.Size = new System.Drawing.Size(140, 81);
            this.picSwitch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSwitch2.TabIndex = 37;
            this.picSwitch2.TabStop = false;
            this.picSwitch2.Tag = "2";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimer.Location = new System.Drawing.Point(936, 34);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(68, 25);
            this.lblTimer.TabIndex = 41;
            this.lblTimer.Text = "Timer:";
            // 
            // btnDesligadoLigado
            // 
            this.btnDesligadoLigado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDesligadoLigado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligadoLigado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesligadoLigado.Location = new System.Drawing.Point(1202, 80);
            this.btnDesligadoLigado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesligadoLigado.Name = "btnDesligadoLigado";
            this.btnDesligadoLigado.Size = new System.Drawing.Size(131, 39);
            this.btnDesligadoLigado.TabIndex = 40;
            this.btnDesligadoLigado.Text = "Desligado";
            this.btnDesligadoLigado.UseVisualStyleBackColor = false;
            this.btnDesligadoLigado.Click += new System.EventHandler(this.clickou_em_ligar);
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTimer.Location = new System.Drawing.Point(1115, 31);
            this.txtTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(303, 30);
            this.txtTimer.TabIndex = 39;
            this.txtTimer.Text = "500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1522, 539);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnDesligadoLigado);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.picSwitch1);
            this.Controls.Add(this.picSwitch2);
            this.Controls.Add(this.picSwitch3);
            this.Controls.Add(this.picSwitch4);
            this.Controls.Add(this.picSwitch5);
            this.Controls.Add(this.picSwitch6);
            this.Controls.Add(this.picSwitch7);
            this.Controls.Add(this.picSwitch8);
            this.Controls.Add(this.chkBit6);
            this.Controls.Add(this.chkBit7);
            this.Controls.Add(this.chkBit8);
            this.Controls.Add(this.chkBit5);
            this.Controls.Add(this.chkBit2);
            this.Controls.Add(this.chkBit3);
            this.Controls.Add(this.chkBit4);
            this.Controls.Add(this.chkBit1);
            this.Controls.Add(this.lblHexadecimal);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblBinario);
            this.Controls.Add(this.lblInformeUmNumero);
            this.Controls.Add(this.lblBase16);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.lblBase10);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNumero);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitch2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblBase10;
        private System.Windows.Forms.Label lblBase2;
        private System.Windows.Forms.Label lblBase16;
        private System.Windows.Forms.Label lblInformeUmNumero;
        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblHexadecimal;
        private System.Windows.Forms.CheckBox chkBit1;
        private System.Windows.Forms.CheckBox chkBit4;
        private System.Windows.Forms.CheckBox chkBit3;
        private System.Windows.Forms.CheckBox chkBit2;
        private System.Windows.Forms.CheckBox chkBit6;
        private System.Windows.Forms.CheckBox chkBit7;
        private System.Windows.Forms.CheckBox chkBit8;
        private System.Windows.Forms.CheckBox chkBit5;
        private System.Windows.Forms.PictureBox picSwitch8;
        private System.Windows.Forms.PictureBox picSwitch7;
        private System.Windows.Forms.PictureBox picSwitch5;
        private System.Windows.Forms.PictureBox picSwitch6;
        private System.Windows.Forms.PictureBox picSwitch3;
        private System.Windows.Forms.PictureBox picSwitch4;
        private System.Windows.Forms.PictureBox picSwitch1;
        private System.Windows.Forms.PictureBox picSwitch2;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnDesligadoLigado;
        private System.Windows.Forms.TextBox txtTimer;
    }
}

