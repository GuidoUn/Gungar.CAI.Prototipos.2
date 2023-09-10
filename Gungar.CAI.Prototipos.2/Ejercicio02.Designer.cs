namespace Gungar.CAI.Prototipos._2
{
    partial class Ejercicio02
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
            cancelBtn = new Button();
            aceptarBtn = new Button();
            precioText = new TextBox();
            label4 = new Label();
            anoText = new TextBox();
            label3 = new Label();
            modeloText = new TextBox();
            label2 = new Label();
            label1 = new Label();
            marcaCombo = new ComboBox();
            resultadoText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            nombreUsuarioText = new Label();
            label8 = new Label();
            nombreRealText = new Label();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(330, 114);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 34);
            cancelBtn.TabIndex = 20;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // aceptarBtn
            // 
            aceptarBtn.Location = new Point(224, 114);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(100, 34);
            aceptarBtn.TabIndex = 19;
            aceptarBtn.Text = "OK";
            aceptarBtn.UseVisualStyleBackColor = true;
            aceptarBtn.Click += aceptarBtn_Click;
            // 
            // precioText
            // 
            precioText.AccessibleDescription = "";
            precioText.Location = new Point(330, 73);
            precioText.Name = "precioText";
            precioText.Size = new Size(100, 23);
            precioText.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 55);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 17;
            label4.Text = "Precio";
            // 
            // anoText
            // 
            anoText.AccessibleDescription = "";
            anoText.Location = new Point(224, 73);
            anoText.Name = "anoText";
            anoText.Size = new Size(100, 23);
            anoText.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 55);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 15;
            label3.Text = "Año";
            // 
            // modeloText
            // 
            modeloText.AccessibleDescription = "";
            modeloText.Location = new Point(118, 73);
            modeloText.Name = "modeloText";
            modeloText.Size = new Size(100, 23);
            modeloText.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 55);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 13;
            label2.Text = "Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 12;
            label1.Text = "Marca";
            // 
            // marcaCombo
            // 
            marcaCombo.FormattingEnabled = true;
            marcaCombo.Location = new Point(12, 73);
            marcaCombo.Name = "marcaCombo";
            marcaCombo.Size = new Size(100, 23);
            marcaCombo.TabIndex = 11;
            // 
            // resultadoText
            // 
            resultadoText.Location = new Point(12, 192);
            resultadoText.Name = "resultadoText";
            resultadoText.Size = new Size(418, 23);
            resultadoText.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 174);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 22;
            label5.Text = "Resultado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 23;
            label6.Text = "Usuario:";
            label6.Click += label6_Click;
            // 
            // nombreUsuarioText
            // 
            nombreUsuarioText.AutoSize = true;
            nombreUsuarioText.Location = new Point(68, 9);
            nombreUsuarioText.Name = "nombreUsuarioText";
            nombreUsuarioText.Size = new Size(0, 15);
            nombreUsuarioText.TabIndex = 24;
            nombreUsuarioText.Text = "Nombre de usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 24);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 25;
            label8.Text = "Nombre Real:";
            label8.Click += label8_Click;
            // 
            // nombreRealText
            // 
            nombreRealText.AutoSize = true;
            nombreRealText.Location = new Point(97, 24);
            nombreRealText.Name = "nombreRealText";
            nombreRealText.Size = new Size(73, 15);
            nombreRealText.TabIndex = 26;
            nombreRealText.Text = "Nombre real";
            // 
            // Ejercicio02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nombreRealText);
            Controls.Add(label8);
            Controls.Add(nombreUsuarioText);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(resultadoText);
            Controls.Add(cancelBtn);
            Controls.Add(aceptarBtn);
            Controls.Add(precioText);
            Controls.Add(label4);
            Controls.Add(anoText);
            Controls.Add(label3);
            Controls.Add(modeloText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(marcaCombo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Ejercicio02";
            Text = "Prototipos - Ejercicio 2";
            Load += Ejercicio02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button aceptarBtn;
        private TextBox precioText;
        private Label label4;
        private TextBox anoText;
        private Label label3;
        private TextBox modeloText;
        private Label label2;
        private Label label1;
        private ComboBox marcaCombo;
        private TextBox resultadoText;
        private Label label5;
        private Label label6;
        private Label nombreUsuarioText;
        private Label label8;
        private Label nombreRealText;
    }
}