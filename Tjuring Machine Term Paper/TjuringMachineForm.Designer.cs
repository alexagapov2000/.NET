namespace Tjuring_Machine_Term_Paper
{
    partial class TjuringMachineForm
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
            this.components = new System.ComponentModel.Container();
            this.PressEnterTip = new System.Windows.Forms.Label();
            this.CommandsBox = new System.Windows.Forms.RichTextBox();
            this.SavedInstructionsList = new System.Windows.Forms.ListBox();
            this.CommandsBoxTip = new System.Windows.Forms.Label();
            this.SavedInctructionsTip = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OneStepButton = new System.Windows.Forms.Button();
            this.StateTip = new System.Windows.Forms.Label();
            this.TotalButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UnaryTip = new System.Windows.Forms.Label();
            this.ResetStateButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PressEnterTip
            // 
            this.PressEnterTip.AutoSize = true;
            this.PressEnterTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PressEnterTip.Location = new System.Drawing.Point(12, 9);
            this.PressEnterTip.Name = "PressEnterTip";
            this.PressEnterTip.Size = new System.Drawing.Size(239, 20);
            this.PressEnterTip.TabIndex = 0;
            this.PressEnterTip.Text = "Press Enter to center the pointer";
            // 
            // CommandsBox
            // 
            this.CommandsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CommandsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommandsBox.Location = new System.Drawing.Point(12, 244);
            this.CommandsBox.Name = "CommandsBox";
            this.CommandsBox.Size = new System.Drawing.Size(300, 485);
            this.CommandsBox.TabIndex = 1;
            this.CommandsBox.Text = "";
            this.CommandsBox.TextChanged += new System.EventHandler(this.CommandsBox_TextChanged);
            // 
            // SavedInstructionsList
            // 
            this.SavedInstructionsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SavedInstructionsList.FormattingEnabled = true;
            this.SavedInstructionsList.Location = new System.Drawing.Point(318, 244);
            this.SavedInstructionsList.Name = "SavedInstructionsList";
            this.SavedInstructionsList.Size = new System.Drawing.Size(300, 485);
            this.SavedInstructionsList.TabIndex = 2;
            this.SavedInstructionsList.SelectedIndexChanged += new System.EventHandler(this.SavedInstructionsList_SelectedIndexChanged);
            // 
            // CommandsBoxTip
            // 
            this.CommandsBoxTip.AutoSize = true;
            this.CommandsBoxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommandsBoxTip.Location = new System.Drawing.Point(8, 221);
            this.CommandsBoxTip.Name = "CommandsBoxTip";
            this.CommandsBoxTip.Size = new System.Drawing.Size(119, 20);
            this.CommandsBoxTip.TabIndex = 4;
            this.CommandsBoxTip.Text = "Commands box";
            // 
            // SavedInctructionsTip
            // 
            this.SavedInctructionsTip.AutoSize = true;
            this.SavedInctructionsTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavedInctructionsTip.Location = new System.Drawing.Point(314, 221);
            this.SavedInctructionsTip.Name = "SavedInctructionsTip";
            this.SavedInctructionsTip.Size = new System.Drawing.Size(139, 20);
            this.SavedInctructionsTip.TabIndex = 5;
            this.SavedInctructionsTip.Text = "Saved instructions";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(624, 629);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(200, 100);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OneStepButton
            // 
            this.OneStepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OneStepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneStepButton.Location = new System.Drawing.Point(624, 523);
            this.OneStepButton.Name = "OneStepButton";
            this.OneStepButton.Size = new System.Drawing.Size(200, 100);
            this.OneStepButton.TabIndex = 7;
            this.OneStepButton.Text = "One step";
            this.OneStepButton.UseVisualStyleBackColor = true;
            this.OneStepButton.Click += new System.EventHandler(this.OneStepButton_Click);
            // 
            // StateTip
            // 
            this.StateTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StateTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StateTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateTip.Location = new System.Drawing.Point(624, 417);
            this.StateTip.Name = "StateTip";
            this.StateTip.Size = new System.Drawing.Size(200, 100);
            this.StateTip.TabIndex = 8;
            this.StateTip.Text = "q1";
            this.StateTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalButton
            // 
            this.TotalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalButton.Location = new System.Drawing.Point(830, 523);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(200, 100);
            this.TotalButton.TabIndex = 9;
            this.TotalButton.Text = "Total";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UnaryTip
            // 
            this.UnaryTip.AutoSize = true;
            this.UnaryTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnaryTip.Location = new System.Drawing.Point(12, 29);
            this.UnaryTip.Name = "UnaryTip";
            this.UnaryTip.Size = new System.Drawing.Size(18, 20);
            this.UnaryTip.TabIndex = 11;
            this.UnaryTip.Text = "0";
            // 
            // ResetStateButton
            // 
            this.ResetStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetStateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetStateButton.Location = new System.Drawing.Point(830, 417);
            this.ResetStateButton.Name = "ResetStateButton";
            this.ResetStateButton.Size = new System.Drawing.Size(200, 100);
            this.ResetStateButton.TabIndex = 12;
            this.ResetStateButton.Text = "Reset state";
            this.ResetStateButton.UseVisualStyleBackColor = true;
            this.ResetStateButton.Click += new System.EventHandler(this.ResetStateButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton.Location = new System.Drawing.Point(830, 629);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(200, 100);
            this.HelpButton.TabIndex = 13;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // TjuringMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 741);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ResetStateButton);
            this.Controls.Add(this.UnaryTip);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.StateTip);
            this.Controls.Add(this.OneStepButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SavedInctructionsTip);
            this.Controls.Add(this.CommandsBoxTip);
            this.Controls.Add(this.SavedInstructionsList);
            this.Controls.Add(this.CommandsBox);
            this.Controls.Add(this.PressEnterTip);
            this.Name = "TjuringMachineForm";
            this.Text = "Tjuring Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PressEnterTip;
        private System.Windows.Forms.RichTextBox CommandsBox;
        private System.Windows.Forms.ListBox SavedInstructionsList;
        private System.Windows.Forms.Label CommandsBoxTip;
        private System.Windows.Forms.Label SavedInctructionsTip;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OneStepButton;
        private System.Windows.Forms.Label StateTip;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label UnaryTip;
        private System.Windows.Forms.Button ResetStateButton;
        private System.Windows.Forms.Button HelpButton;
    }
}

