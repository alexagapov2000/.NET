namespace LabaForms1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.Tg = new LabaForms1.ButtonWithoutFocus();
            this.Cos = new LabaForms1.ButtonWithoutFocus();
            this.Sin = new LabaForms1.ButtonWithoutFocus();
            this.Divide = new LabaForms1.ButtonWithoutFocus();
            this.Multiply = new LabaForms1.ButtonWithoutFocus();
            this.Equals = new LabaForms1.ButtonWithoutFocus();
            this.Minus = new LabaForms1.ButtonWithoutFocus();
            this.Plus = new LabaForms1.ButtonWithoutFocus();
            this.Backspace = new LabaForms1.ButtonWithoutFocus();
            this.Floor = new LabaForms1.ButtonWithoutFocus();
            this.Round = new LabaForms1.ButtonWithoutFocus();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(312, 48);
            this.Label.TabIndex = 12;
            this.Label.Text = "0";
            this.Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tg
            // 
            this.Tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tg.Location = new System.Drawing.Point(224, 381);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(101, 100);
            this.Tg.TabIndex = 25;
            this.Tg.Text = "tg(x)";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tg_MouseDown);
            // 
            // Cos
            // 
            this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cos.Location = new System.Drawing.Point(118, 381);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(101, 100);
            this.Cos.TabIndex = 24;
            this.Cos.Text = "cos(x)";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cos_MouseDown);
            // 
            // Sin
            // 
            this.Sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sin.Location = new System.Drawing.Point(12, 381);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(101, 100);
            this.Sin.TabIndex = 23;
            this.Sin.Text = "sin(x)";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sin_MouseDown);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Divide.Location = new System.Drawing.Point(118, 275);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(101, 100);
            this.Divide.TabIndex = 20;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Divide_MouseDown);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiply.Location = new System.Drawing.Point(12, 275);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(101, 100);
            this.Multiply.TabIndex = 19;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Multiply_MouseDown);
            // 
            // Equals
            // 
            this.Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equals.Location = new System.Drawing.Point(224, 169);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(101, 206);
            this.Equals.TabIndex = 18;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Equals_MouseDown);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(118, 169);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(101, 100);
            this.Minus.TabIndex = 17;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Minus_MouseDown);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(12, 169);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(101, 100);
            this.Plus.TabIndex = 16;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Plus_MouseDown);
            // 
            // Backspace
            // 
            this.Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Backspace.Location = new System.Drawing.Point(224, 63);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(101, 100);
            this.Backspace.TabIndex = 15;
            this.Backspace.Text = "<<";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Backspace_MouseDown);
            // 
            // Floor
            // 
            this.Floor.Location = new System.Drawing.Point(118, 63);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(101, 100);
            this.Floor.TabIndex = 14;
            this.Floor.Text = "Floor";
            this.Floor.UseVisualStyleBackColor = true;
            this.Floor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Floor_MouseDown);
            // 
            // Round
            // 
            this.Round.Location = new System.Drawing.Point(12, 63);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(101, 100);
            this.Round.TabIndex = 13;
            this.Round.Text = "Round";
            this.Round.UseVisualStyleBackColor = true;
            this.Round.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Round_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 491);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Label;
        private ButtonWithoutFocus Round;
        private ButtonWithoutFocus Floor;
        private ButtonWithoutFocus Backspace;
        private ButtonWithoutFocus Equals;
        private ButtonWithoutFocus Minus;
        private ButtonWithoutFocus Plus;
        private ButtonWithoutFocus Cos;
        private ButtonWithoutFocus Sin;
        private ButtonWithoutFocus Divide;
        private ButtonWithoutFocus Multiply;
        private ButtonWithoutFocus Tg;
    }
}

