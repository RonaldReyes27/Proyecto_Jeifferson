namespace Capa_Presentacion
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btsaceptar = new Button();
            btncancelar = new Button();
            txtusuario = new TextBox();
            txtpassword = new TextBox();
            lblusuario = new Label();
            lblpassword = new Label();
            SuspendLayout();
            // 
            // btsaceptar
            // 
            btsaceptar.Location = new Point(169, 311);
            btsaceptar.Name = "btsaceptar";
            btsaceptar.Size = new Size(94, 29);
            btsaceptar.TabIndex = 0;
            btsaceptar.Text = "Aceptar";
            btsaceptar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(518, 311);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(94, 29);
            btncancelar.TabIndex = 1;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(518, 127);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(125, 27);
            txtusuario.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(518, 210);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 3;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(439, 130);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(59, 20);
            lblusuario.TabIndex = 4;
            lblusuario.Text = "Usuario";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(439, 217);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(83, 20);
            lblpassword.TabIndex = 5;
            lblpassword.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblpassword);
            Controls.Add(lblusuario);
            Controls.Add(txtpassword);
            Controls.Add(txtusuario);
            Controls.Add(btncancelar);
            Controls.Add(btsaceptar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsaceptar;
        private Button btncancelar;
        private TextBox txtusuario;
        private TextBox txtpassword;
        private Label lblusuario;
        private Label lblpassword;
    }
}
