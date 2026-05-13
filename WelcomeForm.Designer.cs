using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    // Designer section of WelcomeForm
    partial class WelcomeForm
    {
        // Container for controls
        private System.ComponentModel.IContainer components = null;

        // Labels
        private Label lblWelcome;
        private Label lblMessage;

        // Button
        private Button btnContinue;

        // Cleans up resources
        protected override void Dispose(bool disposing)
        {
            // Dispose components
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            // Base dispose
            base.Dispose(disposing);
        }

        // Creates GUI controls
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 30F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblWelcome.Location = new System.Drawing.Point(81, 191);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(115, 60);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Test";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(85, 293);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(571, 70);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Welcome to the Cybersecurity Awareness Chatbot.\nI am here to help keep you safe o" +
    "nline";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(80)))), ((int)(((byte)(170)))));
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(91, 433);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(420, 50);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue to Chatbot";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnContinue);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}