﻿namespace EscolaIdiomas
{
    partial class FormCadastradarAluno
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
            this.pic_fotoAluno = new System.Windows.Forms.PictureBox();
            this.txt_nomeAluno = new System.Windows.Forms.TextBox();
            this.txt_codAluno = new System.Windows.Forms.TextBox();
            this.msk_rgALuno = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.msk_nascAluno = new System.Windows.Forms.MaskedTextBox();
            this.txt_emailAluno = new System.Windows.Forms.TextBox();
            this.txt_enderecoAluno = new System.Windows.Forms.TextBox();
            this.txt_cidadeAluno = new System.Windows.Forms.TextBox();
            this.txt_bairroAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rd_F = new System.Windows.Forms.RadioButton();
            this.rd_M = new System.Windows.Forms.RadioButton();
            this.GrupoResponsaveisLegais = new System.Windows.Forms.GroupBox();
            this.msk_telPai = new System.Windows.Forms.MaskedTextBox();
            this.msk_dddPai = new System.Windows.Forms.MaskedTextBox();
            this.msk_telMae = new System.Windows.Forms.MaskedTextBox();
            this.msk_dddMae = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_nomePai = new System.Windows.Forms.TextBox();
            this.txt_nomeMae = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rd_S = new System.Windows.Forms.RadioButton();
            this.rd_N = new System.Windows.Forms.RadioButton();
            this.btn_salvarAluno = new System.Windows.Forms.Button();
            this.btn_fotoAluno = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.GrupoResposabilidade = new System.Windows.Forms.GroupBox();
            this.msk_dddAluno = new System.Windows.Forms.MaskedTextBox();
            this.msk_telAluno = new System.Windows.Forms.MaskedTextBox();
            this.msk_telAltAluno = new System.Windows.Forms.MaskedTextBox();
            this.msk_dddAltAluno = new System.Windows.Forms.MaskedTextBox();
            this.groupoSituacao = new System.Windows.Forms.GroupBox();
            this.rd_I = new System.Windows.Forms.RadioButton();
            this.rd_A = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotoAluno)).BeginInit();
            this.GrupoResponsaveisLegais.SuspendLayout();
            this.GrupoResposabilidade.SuspendLayout();
            this.groupoSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_fotoAluno
            // 
            this.pic_fotoAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_fotoAluno.Location = new System.Drawing.Point(366, 38);
            this.pic_fotoAluno.Name = "pic_fotoAluno";
            this.pic_fotoAluno.Size = new System.Drawing.Size(118, 157);
            this.pic_fotoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_fotoAluno.TabIndex = 0;
            this.pic_fotoAluno.TabStop = false;
            // 
            // txt_nomeAluno
            // 
            this.txt_nomeAluno.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nomeAluno.Location = new System.Drawing.Point(56, 45);
            this.txt_nomeAluno.MaxLength = 100;
            this.txt_nomeAluno.Name = "txt_nomeAluno";
            this.txt_nomeAluno.Size = new System.Drawing.Size(293, 20);
            this.txt_nomeAluno.TabIndex = 1;
            this.txt_nomeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomeAluno_KeyPress);
            // 
            // txt_codAluno
            // 
            this.txt_codAluno.Enabled = false;
            this.txt_codAluno.Location = new System.Drawing.Point(401, 12);
            this.txt_codAluno.Name = "txt_codAluno";
            this.txt_codAluno.Size = new System.Drawing.Size(83, 20);
            this.txt_codAluno.TabIndex = 2;
            // 
            // msk_rgALuno
            // 
            this.msk_rgALuno.Location = new System.Drawing.Point(56, 71);
            this.msk_rgALuno.Mask = "00.000.000-A";
            this.msk_rgALuno.Name = "msk_rgALuno";
            this.msk_rgALuno.Size = new System.Drawing.Size(76, 20);
            this.msk_rgALuno.TabIndex = 2;
            this.msk_rgALuno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // msk_cpfAluno
            // 
            this.msk_cpfAluno.Location = new System.Drawing.Point(210, 71);
            this.msk_cpfAluno.Mask = "000.000.000-00";
            this.msk_cpfAluno.Name = "msk_cpfAluno";
            this.msk_cpfAluno.Size = new System.Drawing.Size(87, 20);
            this.msk_cpfAluno.TabIndex = 3;
            this.msk_cpfAluno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // msk_nascAluno
            // 
            this.msk_nascAluno.Location = new System.Drawing.Point(125, 97);
            this.msk_nascAluno.Mask = "00/00/0000";
            this.msk_nascAluno.Name = "msk_nascAluno";
            this.msk_nascAluno.Size = new System.Drawing.Size(67, 20);
            this.msk_nascAluno.TabIndex = 4;
            this.msk_nascAluno.Leave += new System.EventHandler(this.msk_nascAluno_Leave);
            // 
            // txt_emailAluno
            // 
            this.txt_emailAluno.Location = new System.Drawing.Point(56, 123);
            this.txt_emailAluno.MaxLength = 100;
            this.txt_emailAluno.Name = "txt_emailAluno";
            this.txt_emailAluno.Size = new System.Drawing.Size(293, 20);
            this.txt_emailAluno.TabIndex = 7;
            // 
            // txt_enderecoAluno
            // 
            this.txt_enderecoAluno.Location = new System.Drawing.Point(77, 175);
            this.txt_enderecoAluno.MaxLength = 50;
            this.txt_enderecoAluno.Name = "txt_enderecoAluno";
            this.txt_enderecoAluno.Size = new System.Drawing.Size(272, 20);
            this.txt_enderecoAluno.TabIndex = 12;
            // 
            // txt_cidadeAluno
            // 
            this.txt_cidadeAluno.Location = new System.Drawing.Point(225, 201);
            this.txt_cidadeAluno.MaxLength = 20;
            this.txt_cidadeAluno.Name = "txt_cidadeAluno";
            this.txt_cidadeAluno.Size = new System.Drawing.Size(124, 20);
            this.txt_cidadeAluno.TabIndex = 14;
            this.txt_cidadeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cidadeAluno_KeyPress);
            // 
            // txt_bairroAluno
            // 
            this.txt_bairroAluno.Location = new System.Drawing.Point(56, 201);
            this.txt_bairroAluno.MaxLength = 20;
            this.txt_bairroAluno.Name = "txt_bairroAluno";
            this.txt_bairroAluno.Size = new System.Drawing.Size(108, 20);
            this.txt_bairroAluno.TabIndex = 13;
            this.txt_bairroAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bairroAluno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bairro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Telefone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tel. Alternativo:";
            // 
            // rd_F
            // 
            this.rd_F.AutoSize = true;
            this.rd_F.Location = new System.Drawing.Point(278, 98);
            this.rd_F.Name = "rd_F";
            this.rd_F.Size = new System.Drawing.Size(31, 17);
            this.rd_F.TabIndex = 5;
            this.rd_F.TabStop = true;
            this.rd_F.Text = "F";
            this.rd_F.UseVisualStyleBackColor = true;
            // 
            // rd_M
            // 
            this.rd_M.AutoSize = true;
            this.rd_M.Location = new System.Drawing.Point(315, 98);
            this.rd_M.Name = "rd_M";
            this.rd_M.Size = new System.Drawing.Size(34, 17);
            this.rd_M.TabIndex = 6;
            this.rd_M.TabStop = true;
            this.rd_M.Text = "M";
            this.rd_M.UseVisualStyleBackColor = true;
            // 
            // GrupoResponsaveisLegais
            // 
            this.GrupoResponsaveisLegais.Controls.Add(this.msk_telPai);
            this.GrupoResponsaveisLegais.Controls.Add(this.msk_dddPai);
            this.GrupoResponsaveisLegais.Controls.Add(this.msk_telMae);
            this.GrupoResponsaveisLegais.Controls.Add(this.msk_dddMae);
            this.GrupoResponsaveisLegais.Controls.Add(this.label16);
            this.GrupoResponsaveisLegais.Controls.Add(this.label15);
            this.GrupoResponsaveisLegais.Controls.Add(this.label14);
            this.GrupoResponsaveisLegais.Controls.Add(this.label13);
            this.GrupoResponsaveisLegais.Controls.Add(this.txt_nomePai);
            this.GrupoResponsaveisLegais.Controls.Add(this.txt_nomeMae);
            this.GrupoResponsaveisLegais.Enabled = false;
            this.GrupoResponsaveisLegais.Location = new System.Drawing.Point(17, 243);
            this.GrupoResponsaveisLegais.Name = "GrupoResponsaveisLegais";
            this.GrupoResponsaveisLegais.Size = new System.Drawing.Size(342, 145);
            this.GrupoResponsaveisLegais.TabIndex = 28;
            this.GrupoResponsaveisLegais.TabStop = false;
            this.GrupoResponsaveisLegais.Text = "Responsáveis Legais";
            // 
            // msk_telPai
            // 
            this.msk_telPai.Location = new System.Drawing.Point(133, 106);
            this.msk_telPai.Mask = "000000000";
            this.msk_telPai.Name = "msk_telPai";
            this.msk_telPai.Size = new System.Drawing.Size(60, 20);
            this.msk_telPai.TabIndex = 20;
            // 
            // msk_dddPai
            // 
            this.msk_dddPai.Location = new System.Drawing.Point(107, 106);
            this.msk_dddPai.Mask = "00";
            this.msk_dddPai.Name = "msk_dddPai";
            this.msk_dddPai.Size = new System.Drawing.Size(20, 20);
            this.msk_dddPai.TabIndex = 19;
            // 
            // msk_telMae
            // 
            this.msk_telMae.Location = new System.Drawing.Point(133, 54);
            this.msk_telMae.Mask = "000000000";
            this.msk_telMae.Name = "msk_telMae";
            this.msk_telMae.Size = new System.Drawing.Size(60, 20);
            this.msk_telMae.TabIndex = 17;
            // 
            // msk_dddMae
            // 
            this.msk_dddMae.Location = new System.Drawing.Point(107, 54);
            this.msk_dddMae.Mask = "00";
            this.msk_dddMae.Name = "msk_dddMae";
            this.msk_dddMae.Size = new System.Drawing.Size(20, 20);
            this.msk_dddMae.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Telefone do Pai:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Telefone da Mãe:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Nome do Pai:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nome da Mãe:";
            // 
            // txt_nomePai
            // 
            this.txt_nomePai.Location = new System.Drawing.Point(93, 80);
            this.txt_nomePai.MaxLength = 100;
            this.txt_nomePai.Name = "txt_nomePai";
            this.txt_nomePai.Size = new System.Drawing.Size(239, 20);
            this.txt_nomePai.TabIndex = 18;
            this.txt_nomePai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomePai_KeyPress);
            // 
            // txt_nomeMae
            // 
            this.txt_nomeMae.Location = new System.Drawing.Point(93, 28);
            this.txt_nomeMae.MaxLength = 100;
            this.txt_nomeMae.Name = "txt_nomeMae";
            this.txt_nomeMae.Size = new System.Drawing.Size(239, 20);
            this.txt_nomeMae.TabIndex = 15;
            this.txt_nomeMae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomeMae_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 409);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(255, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Deseja atribuir responsabilidade financeira ao aluno?";
            // 
            // rd_S
            // 
            this.rd_S.AutoSize = true;
            this.rd_S.Location = new System.Drawing.Point(6, 10);
            this.rd_S.Name = "rd_S";
            this.rd_S.Size = new System.Drawing.Size(32, 17);
            this.rd_S.TabIndex = 21;
            this.rd_S.TabStop = true;
            this.rd_S.Text = "S";
            this.rd_S.UseVisualStyleBackColor = true;
            // 
            // rd_N
            // 
            this.rd_N.AutoSize = true;
            this.rd_N.Location = new System.Drawing.Point(45, 10);
            this.rd_N.Name = "rd_N";
            this.rd_N.Size = new System.Drawing.Size(33, 17);
            this.rd_N.TabIndex = 22;
            this.rd_N.TabStop = true;
            this.rd_N.Text = "N";
            this.rd_N.UseVisualStyleBackColor = true;
            // 
            // btn_salvarAluno
            // 
            this.btn_salvarAluno.Location = new System.Drawing.Point(389, 406);
            this.btn_salvarAluno.Name = "btn_salvarAluno";
            this.btn_salvarAluno.Size = new System.Drawing.Size(95, 23);
            this.btn_salvarAluno.TabIndex = 23;
            this.btn_salvarAluno.Text = "Salvar";
            this.btn_salvarAluno.UseVisualStyleBackColor = true;
            this.btn_salvarAluno.Click += new System.EventHandler(this.btn_salvarAluno_Click);
            // 
            // btn_fotoAluno
            // 
            this.btn_fotoAluno.Location = new System.Drawing.Point(366, 202);
            this.btn_fotoAluno.Name = "btn_fotoAluno";
            this.btn_fotoAluno.Size = new System.Drawing.Size(118, 23);
            this.btn_fotoAluno.TabIndex = 33;
            this.btn_fotoAluno.Text = "Escolher Foto";
            this.btn_fotoAluno.UseVisualStyleBackColor = true;
            this.btn_fotoAluno.Click += new System.EventHandler(this.btn_fotoAluno_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Sexo:";
            // 
            // GrupoResposabilidade
            // 
            this.GrupoResposabilidade.Controls.Add(this.rd_N);
            this.GrupoResposabilidade.Controls.Add(this.rd_S);
            this.GrupoResposabilidade.Location = new System.Drawing.Point(275, 399);
            this.GrupoResposabilidade.Name = "GrupoResposabilidade";
            this.GrupoResposabilidade.Size = new System.Drawing.Size(84, 33);
            this.GrupoResposabilidade.TabIndex = 34;
            this.GrupoResposabilidade.TabStop = false;
            // 
            // msk_dddAluno
            // 
            this.msk_dddAluno.Location = new System.Drawing.Point(68, 149);
            this.msk_dddAluno.Mask = "00";
            this.msk_dddAluno.Name = "msk_dddAluno";
            this.msk_dddAluno.Size = new System.Drawing.Size(20, 20);
            this.msk_dddAluno.TabIndex = 8;
            // 
            // msk_telAluno
            // 
            this.msk_telAluno.Location = new System.Drawing.Point(94, 149);
            this.msk_telAluno.Mask = "000000000";
            this.msk_telAluno.Name = "msk_telAluno";
            this.msk_telAluno.Size = new System.Drawing.Size(60, 20);
            this.msk_telAluno.TabIndex = 9;
            // 
            // msk_telAltAluno
            // 
            this.msk_telAltAluno.Location = new System.Drawing.Point(289, 149);
            this.msk_telAltAluno.Mask = "000000000";
            this.msk_telAltAluno.Name = "msk_telAltAluno";
            this.msk_telAltAluno.Size = new System.Drawing.Size(60, 20);
            this.msk_telAltAluno.TabIndex = 11;
            // 
            // msk_dddAltAluno
            // 
            this.msk_dddAltAluno.Location = new System.Drawing.Point(263, 149);
            this.msk_dddAltAluno.Mask = "00";
            this.msk_dddAltAluno.Name = "msk_dddAltAluno";
            this.msk_dddAltAluno.Size = new System.Drawing.Size(20, 20);
            this.msk_dddAltAluno.TabIndex = 10;
            // 
            // groupoSituacao
            // 
            this.groupoSituacao.Controls.Add(this.rd_I);
            this.groupoSituacao.Controls.Add(this.rd_A);
            this.groupoSituacao.Location = new System.Drawing.Point(56, 3);
            this.groupoSituacao.Name = "groupoSituacao";
            this.groupoSituacao.Size = new System.Drawing.Size(85, 36);
            this.groupoSituacao.TabIndex = 76;
            this.groupoSituacao.TabStop = false;
            this.groupoSituacao.Text = "Situação:";
            // 
            // rd_I
            // 
            this.rd_I.AutoSize = true;
            this.rd_I.Enabled = false;
            this.rd_I.Location = new System.Drawing.Point(51, 13);
            this.rd_I.Name = "rd_I";
            this.rd_I.Size = new System.Drawing.Size(28, 17);
            this.rd_I.TabIndex = 73;
            this.rd_I.TabStop = true;
            this.rd_I.Text = "I";
            this.rd_I.UseVisualStyleBackColor = true;
            // 
            // rd_A
            // 
            this.rd_A.AutoSize = true;
            this.rd_A.Enabled = false;
            this.rd_A.Location = new System.Drawing.Point(13, 13);
            this.rd_A.Name = "rd_A";
            this.rd_A.Size = new System.Drawing.Size(32, 17);
            this.rd_A.TabIndex = 72;
            this.rd_A.TabStop = true;
            this.rd_A.Text = "A";
            this.rd_A.UseVisualStyleBackColor = true;
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 443);
            this.Controls.Add(this.groupoSituacao);
            this.Controls.Add(this.msk_telAltAluno);
            this.Controls.Add(this.msk_dddAltAluno);
            this.Controls.Add(this.msk_telAluno);
            this.Controls.Add(this.msk_dddAluno);
            this.Controls.Add(this.GrupoResposabilidade);
            this.Controls.Add(this.btn_fotoAluno);
            this.Controls.Add(this.btn_salvarAluno);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.GrupoResponsaveisLegais);
            this.Controls.Add(this.rd_M);
            this.Controls.Add(this.rd_F);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_bairroAluno);
            this.Controls.Add(this.txt_cidadeAluno);
            this.Controls.Add(this.txt_enderecoAluno);
            this.Controls.Add(this.txt_emailAluno);
            this.Controls.Add(this.msk_nascAluno);
            this.Controls.Add(this.msk_cpfAluno);
            this.Controls.Add(this.msk_rgALuno);
            this.Controls.Add(this.txt_codAluno);
            this.Controls.Add(this.txt_nomeAluno);
            this.Controls.Add(this.pic_fotoAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotoAluno)).EndInit();
            this.GrupoResponsaveisLegais.ResumeLayout(false);
            this.GrupoResponsaveisLegais.PerformLayout();
            this.GrupoResposabilidade.ResumeLayout(false);
            this.GrupoResposabilidade.PerformLayout();
            this.groupoSituacao.ResumeLayout(false);
            this.groupoSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_fotoAluno;
        private System.Windows.Forms.TextBox txt_nomeAluno;
        private System.Windows.Forms.TextBox txt_codAluno;
        private System.Windows.Forms.MaskedTextBox msk_rgALuno;
        private System.Windows.Forms.MaskedTextBox msk_cpfAluno;
        private System.Windows.Forms.MaskedTextBox msk_nascAluno;
        private System.Windows.Forms.TextBox txt_emailAluno;
        private System.Windows.Forms.TextBox txt_enderecoAluno;
        private System.Windows.Forms.TextBox txt_cidadeAluno;
        private System.Windows.Forms.TextBox txt_bairroAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rd_F;
        private System.Windows.Forms.RadioButton rd_M;
        private System.Windows.Forms.GroupBox GrupoResponsaveisLegais;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_nomePai;
        private System.Windows.Forms.TextBox txt_nomeMae;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rd_S;
        private System.Windows.Forms.RadioButton rd_N;
        private System.Windows.Forms.Button btn_salvarAluno;
        private System.Windows.Forms.Button btn_fotoAluno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox GrupoResposabilidade;
        private System.Windows.Forms.MaskedTextBox msk_dddAluno;
        private System.Windows.Forms.MaskedTextBox msk_telAluno;
        private System.Windows.Forms.MaskedTextBox msk_telAltAluno;
        private System.Windows.Forms.MaskedTextBox msk_dddAltAluno;
        private System.Windows.Forms.MaskedTextBox msk_telPai;
        private System.Windows.Forms.MaskedTextBox msk_dddPai;
        private System.Windows.Forms.MaskedTextBox msk_telMae;
        private System.Windows.Forms.MaskedTextBox msk_dddMae;
        private System.Windows.Forms.GroupBox groupoSituacao;
        private System.Windows.Forms.RadioButton rd_I;
        private System.Windows.Forms.RadioButton rd_A;
    }
}