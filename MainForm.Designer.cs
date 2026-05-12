using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Panel pnlChatContainer;
        private Panel pnlInput;
        private Panel pnlInputBox;

        private Label lblTitle;
        private Label lblStatus;

        private FlowLayoutPanel flpChat;
        private TextBox txtUserInput;
        private Button btnSend;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            pnlChatContainer = new Panel();
            pnlInput = new Panel();
            pnlInputBox = new Panel();

            lblTitle = new Label();
            lblStatus = new Label();

            flpChat = new FlowLayoutPanel();
            txtUserInput = new TextBox();
            btnSend = new Button();

            SuspendLayout();

            Text = "Cybersecurity Awareness Chatbot";
            WindowState = FormWindowState.Maximized;
            BackColor = Color.FromArgb(10, 10, 15);
            Font = new Font("Segoe UI", 10F);

            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 120;
            pnlHeader.BackColor = Color.FromArgb(20, 10, 35);

            lblTitle.Text = "CYBER SECURITY CHATBOT";
            lblTitle.ForeColor = Color.FromArgb(0, 255, 255);
            lblTitle.Font = new Font("Bahnschrift SemiBold", 24F, FontStyle.Bold);
            lblTitle.AutoSize = true;

            // Increase the Y value to move the title lower
            lblTitle.Location = new Point(40, 45);

            //Only way I could find to move the status label lower without affecting the title was to add extra padding to the header and then move the status down with a location change
            lblStatus.Text = "";
            lblStatus.ForeColor = Color.FromArgb(255, 120, 220);
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.AutoSize = true;

            // Increase the Y value to move the status lower
            lblStatus.Location = new Point(45, 85);

            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblStatus);

            pnlChatContainer.Dock = DockStyle.Fill;
            pnlChatContainer.Padding = new Padding(40, 30, 40, 30);
            pnlChatContainer.BackColor = Color.FromArgb(10, 10, 15);

            flpChat.Dock = DockStyle.Fill;
            flpChat.BackColor = Color.FromArgb(18, 18, 28);
            flpChat.FlowDirection = FlowDirection.TopDown;
            flpChat.WrapContents = false;
            flpChat.AutoScroll = true;
            flpChat.Padding = new Padding(25);

            pnlChatContainer.Controls.Add(flpChat);

            pnlInput.Dock = DockStyle.Bottom;
            pnlInput.Height = 95;
            pnlInput.BackColor = Color.FromArgb(10, 10, 15);
            pnlInput.Padding = new Padding(40, 15, 40, 15);

            pnlInputBox.Dock = DockStyle.Fill;
            pnlInputBox.BackColor = Color.FromArgb(28, 20, 40);
            pnlInputBox.Padding = new Padding(20, 15, 20, 15);

            btnSend.Dock = DockStyle.Right;
            btnSend.Width = 80;
            btnSend.Text = "➤";
            btnSend.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSend.BackColor = Color.FromArgb(210, 80, 170);
            btnSend.ForeColor = Color.White;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.Cursor = Cursors.Hand;
            btnSend.Click += btnSend_Click;

            txtUserInput.Dock = DockStyle.Fill;
            txtUserInput.BorderStyle = BorderStyle.None;
            txtUserInput.BackColor = Color.FromArgb(28, 20, 40);
            txtUserInput.ForeColor = Color.White;
            txtUserInput.Font = new Font("Segoe UI", 13F);

            txtUserInput.KeyDown += txtUserInput_KeyDown;
            txtUserInput.Enter += RemovePlaceholder;
            txtUserInput.Leave += AddPlaceholder;

            pnlInputBox.Controls.Add(btnSend);
            pnlInputBox.Controls.Add(txtUserInput);

            pnlInput.Controls.Add(pnlInputBox);

            Controls.Add(pnlChatContainer);
            Controls.Add(pnlInput);
            Controls.Add(pnlHeader);

            ResumeLayout(false);
        }
    }
}