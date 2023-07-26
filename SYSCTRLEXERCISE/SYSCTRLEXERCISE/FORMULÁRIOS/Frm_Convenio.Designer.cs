namespace SysCtrlExercise
{
    partial class Frm_Convenio
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
            this.lbox_Convenios = new System.Windows.Forms.ListBox();
            this.pnl_Detalhes = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbox_Cat_Convenio = new System.Windows.Forms.ComboBox();
            this.rdbtn_Empresa = new System.Windows.Forms.RadioButton();
            this.rdbtn_Particular = new System.Windows.Forms.RadioButton();
            this.tbox_Nm_Convenio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_Cod_Convenio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Botoes = new System.Windows.Forms.Panel();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_titulo2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_Nro_Convenio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_Detalhes.SuspendLayout();
            this.pnl_Botoes.SuspendLayout();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbox_Convenios
            // 
            this.lbox_Convenios.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbox_Convenios.FormattingEnabled = true;
            this.lbox_Convenios.Location = new System.Drawing.Point(0, 68);
            this.lbox_Convenios.Name = "lbox_Convenios";
            this.lbox_Convenios.Size = new System.Drawing.Size(120, 266);
            this.lbox_Convenios.TabIndex = 7;
            // 
            // pnl_Detalhes
            // 
            this.pnl_Detalhes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnl_Detalhes.Controls.Add(this.tbox_Nro_Convenio);
            this.pnl_Detalhes.Controls.Add(this.label7);
            this.pnl_Detalhes.Controls.Add(this.label8);
            this.pnl_Detalhes.Controls.Add(this.cbbox_Cat_Convenio);
            this.pnl_Detalhes.Controls.Add(this.rdbtn_Empresa);
            this.pnl_Detalhes.Controls.Add(this.rdbtn_Particular);
            this.pnl_Detalhes.Controls.Add(this.tbox_Nm_Convenio);
            this.pnl_Detalhes.Controls.Add(this.label5);
            this.pnl_Detalhes.Controls.Add(this.tbox_Cod_Convenio);
            this.pnl_Detalhes.Controls.Add(this.label2);
            this.pnl_Detalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhes.Location = new System.Drawing.Point(0, 68);
            this.pnl_Detalhes.Name = "pnl_Detalhes";
            this.pnl_Detalhes.Size = new System.Drawing.Size(612, 266);
            this.pnl_Detalhes.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Categoria";
            // 
            // cbbox_Cat_Convenio
            // 
            this.cbbox_Cat_Convenio.FormattingEnabled = true;
            this.cbbox_Cat_Convenio.Items.AddRange(new object[] {
            "Categoria A",
            "Categoria B",
            "Categoria C"});
            this.cbbox_Cat_Convenio.Location = new System.Drawing.Point(150, 218);
            this.cbbox_Cat_Convenio.Name = "cbbox_Cat_Convenio";
            this.cbbox_Cat_Convenio.Size = new System.Drawing.Size(400, 21);
            this.cbbox_Cat_Convenio.TabIndex = 11;
            // 
            // rdbtn_Empresa
            // 
            this.rdbtn_Empresa.AutoSize = true;
            this.rdbtn_Empresa.Location = new System.Drawing.Point(465, 158);
            this.rdbtn_Empresa.Name = "rdbtn_Empresa";
            this.rdbtn_Empresa.Size = new System.Drawing.Size(66, 17);
            this.rdbtn_Empresa.TabIndex = 10;
            this.rdbtn_Empresa.TabStop = true;
            this.rdbtn_Empresa.Text = "Empresa";
            this.rdbtn_Empresa.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Particular
            // 
            this.rdbtn_Particular.AutoSize = true;
            this.rdbtn_Particular.Location = new System.Drawing.Point(348, 158);
            this.rdbtn_Particular.Name = "rdbtn_Particular";
            this.rdbtn_Particular.Size = new System.Drawing.Size(69, 17);
            this.rdbtn_Particular.TabIndex = 9;
            this.rdbtn_Particular.Text = "Particular";
            this.rdbtn_Particular.UseVisualStyleBackColor = true;
            // 
            // tbox_Nm_Convenio
            // 
            this.tbox_Nm_Convenio.Location = new System.Drawing.Point(150, 96);
            this.tbox_Nm_Convenio.Name = "tbox_Nm_Convenio";
            this.tbox_Nm_Convenio.Size = new System.Drawing.Size(400, 20);
            this.tbox_Nm_Convenio.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome Convênio";
            // 
            // tbox_Cod_Convenio
            // 
            this.tbox_Cod_Convenio.Enabled = false;
            this.tbox_Cod_Convenio.Location = new System.Drawing.Point(150, 34);
            this.tbox_Cod_Convenio.Name = "tbox_Cod_Convenio";
            this.tbox_Cod_Convenio.Size = new System.Drawing.Size(100, 20);
            this.tbox_Cod_Convenio.TabIndex = 1;
            this.tbox_Cod_Convenio.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // pnl_Botoes
            // 
            this.pnl_Botoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Botoes.Controls.Add(this.btn_Confirmar);
            this.pnl_Botoes.Controls.Add(this.btn_Cancelar);
            this.pnl_Botoes.Controls.Add(this.btn_Excluir);
            this.pnl_Botoes.Controls.Add(this.btn_Alterar);
            this.pnl_Botoes.Controls.Add(this.btn_Novo);
            this.pnl_Botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botoes.Location = new System.Drawing.Point(0, 334);
            this.pnl_Botoes.Name = "pnl_Botoes";
            this.pnl_Botoes.Size = new System.Drawing.Size(612, 70);
            this.pnl_Botoes.TabIndex = 5;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Location = new System.Drawing.Point(419, 22);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 4;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(517, 22);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Excluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Location = new System.Drawing.Point(232, 22);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Alterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Alterar.FlatAppearance.BorderSize = 0;
            this.btn_Alterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Location = new System.Drawing.Point(121, 22);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Novo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Novo.FlatAppearance.BorderSize = 0;
            this.btn_Novo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Location = new System.Drawing.Point(21, 22);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Titulo.Controls.Add(this.label10);
            this.pnl_Titulo.Controls.Add(this.label9);
            this.pnl_Titulo.Controls.Add(this.label6);
            this.pnl_Titulo.Controls.Add(this.label4);
            this.pnl_Titulo.Controls.Add(this.label3);
            this.pnl_Titulo.Controls.Add(this.lb_titulo2);
            this.pnl_Titulo.Controls.Add(this.label1);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(612, 68);
            this.pnl_Titulo.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("News706 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(361, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Convênio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("News706 BT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(439, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Convênio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("News706 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Convênio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Convênio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convênio";
            // 
            // lb_titulo2
            // 
            this.lb_titulo2.AutoSize = true;
            this.lb_titulo2.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_titulo2.Location = new System.Drawing.Point(336, 12);
            this.lb_titulo2.Name = "lb_titulo2";
            this.lb_titulo2.Size = new System.Drawing.Size(65, 15);
            this.lb_titulo2.TabIndex = 1;
            this.lb_titulo2.Text = "Convênio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convênio";
            // 
            // tbox_Nro_Convenio
            // 
            this.tbox_Nro_Convenio.Location = new System.Drawing.Point(150, 156);
            this.tbox_Nro_Convenio.Name = "tbox_Nro_Convenio";
            this.tbox_Nro_Convenio.Size = new System.Drawing.Size(100, 20);
            this.tbox_Nro_Convenio.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número Convênio";
            // 
            // Frm_Convenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 404);
            this.Controls.Add(this.lbox_Convenios);
            this.Controls.Add(this.pnl_Detalhes);
            this.Controls.Add(this.pnl_Botoes);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Convenio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnl_Detalhes.ResumeLayout(false);
            this.pnl_Detalhes.PerformLayout();
            this.pnl_Botoes.ResumeLayout(false);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Convenios;
        private System.Windows.Forms.Panel pnl_Detalhes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbox_Cat_Convenio;
        private System.Windows.Forms.RadioButton rdbtn_Empresa;
        private System.Windows.Forms.RadioButton rdbtn_Particular;
        private System.Windows.Forms.TextBox tbox_Nm_Convenio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_Cod_Convenio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Botoes;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_titulo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_Nro_Convenio;
        private System.Windows.Forms.Label label7;
    }
}