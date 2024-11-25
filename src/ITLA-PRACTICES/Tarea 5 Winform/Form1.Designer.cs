namespace Tarea_5_Winform
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
            label1 = new Label();
            num2 = new TextBox();
            num1 = new TextBox();
            add = new Button();
            Resultados = new ListBox();
            substract = new Button();
            clear = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(353, 9);
            label1.Name = "label1";
            label1.Size = new Size(399, 41);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Suma y Resta";
            // 
            // num2
            // 
            num2.Location = new Point(899, 169);
            num2.Name = "num2";
            num2.Size = new Size(150, 31);
            num2.TabIndex = 1;
            num2.TextChanged += num2_TextChanged;
            // 
            // num1
            // 
            num1.Location = new Point(633, 169);
            num1.Name = "num1";
            num1.Size = new Size(150, 31);
            num1.TabIndex = 2;
            num1.TextChanged += num1_TextChanged;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI Emoji", 12F);
            add.Location = new Point(908, 367);
            add.Name = "add";
            add.Size = new Size(141, 57);
            add.TabIndex = 3;
            add.Text = "Suma";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // Resultados
            // 
            Resultados.Font = new Font("Segoe UI", 14F);
            Resultados.FormattingEnabled = true;
            Resultados.ItemHeight = 38;
            Resultados.Location = new Point(12, 204);
            Resultados.Name = "Resultados";
            Resultados.Size = new Size(381, 346);
            Resultados.TabIndex = 6;
            // 
            // substract
            // 
            substract.Font = new Font("Segoe UI Emoji", 12F);
            substract.Location = new Point(908, 430);
            substract.Name = "substract";
            substract.Size = new Size(141, 57);
            substract.TabIndex = 7;
            substract.Text = "Resta";
            substract.UseVisualStyleBackColor = true;
            substract.Click += substract_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI Emoji", 12F);
            clear.Location = new Point(908, 493);
            clear.Name = "clear";
            clear.Size = new Size(141, 57);
            clear.TabIndex = 8;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(705, 93);
            label2.Name = "label2";
            label2.Size = new Size(268, 38);
            label2.TabIndex = 9;
            label2.Text = "Ingrese los numeros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 562);
            Controls.Add(label2);
            Controls.Add(clear);
            Controls.Add(substract);
            Controls.Add(Resultados);
            Controls.Add(add);
            Controls.Add(num1);
            Controls.Add(num2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num2;
        private TextBox num1;
        private Button add;
        private ListBox Resultados;
        private Button substract;
        private Button clear;
        private Label label2;
    }
}
