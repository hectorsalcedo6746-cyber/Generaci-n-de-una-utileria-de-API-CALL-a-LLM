namespace GeminiWinForms_2
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
            txtChat = new TextBox();
            txtInput = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtChat
            // 
            txtChat.BackColor = SystemColors.ActiveCaptionText;
            txtChat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChat.ForeColor = Color.SpringGreen;
            txtChat.Location = new Point(12, 12);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(776, 288);
            txtChat.TabIndex = 0;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(188, 326);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(588, 23);
            txtInput.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 308);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(154, 57);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 365);
            Controls.Add(btnEnviar);
            Controls.Add(txtInput);
            Controls.Add(txtChat);
            Name = "Form1";
            Text = "ChatGemeniIA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtChat;
        private TextBox txtInput;
        private Button btnEnviar;
    }
}
