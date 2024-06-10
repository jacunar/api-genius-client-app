namespace APIGeniusClientUI {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            HeaderLabel = new Label();
            APILabel = new Label();
            ApiUrlTextBox = new TextBox();
            CallAPIButton = new Button();
            ResultLabel = new Label();
            ResultTextBox = new TextBox();
            StatusStrip1 = new StatusStrip();
            SystemStatusLabel = new ToolStripStatusLabel();
            StatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLabel.Location = new Point(54, 18);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(115, 30);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "API Client";
            // 
            // APILabel
            // 
            APILabel.AutoSize = true;
            APILabel.Location = new Point(54, 64);
            APILabel.Name = "APILabel";
            APILabel.Size = new Size(61, 21);
            APILabel.TabIndex = 1;
            APILabel.Text = "API Url:";
            // 
            // ApiUrlTextBox
            // 
            ApiUrlTextBox.Location = new Point(121, 61);
            ApiUrlTextBox.Name = "ApiUrlTextBox";
            ApiUrlTextBox.Size = new Size(495, 29);
            ApiUrlTextBox.TabIndex = 2;
            // 
            // CallAPIButton
            // 
            CallAPIButton.Location = new Point(634, 61);
            CallAPIButton.Name = "CallAPIButton";
            CallAPIButton.Size = new Size(91, 29);
            CallAPIButton.TabIndex = 3;
            CallAPIButton.Text = "Go";
            CallAPIButton.UseVisualStyleBackColor = true;
            CallAPIButton.Click += CallAPIButton_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(54, 105);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(77, 21);
            ResultLabel.TabIndex = 4;
            ResultLabel.Text = "Response";
            // 
            // ResultTextBox
            // 
            ResultTextBox.BorderStyle = BorderStyle.FixedSingle;
            ResultTextBox.Location = new Point(54, 139);
            ResultTextBox.Multiline = true;
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.ScrollBars = ScrollBars.Both;
            ResultTextBox.Size = new Size(671, 279);
            ResultTextBox.TabIndex = 5;
            // 
            // StatusStrip1
            // 
            StatusStrip1.Items.AddRange(new ToolStripItem[] { SystemStatusLabel });
            StatusStrip1.Location = new Point(0, 444);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Size = new Size(752, 26);
            StatusStrip1.TabIndex = 6;
            StatusStrip1.Text = "MyStatusStrip";
            // 
            // SystemStatusLabel
            // 
            SystemStatusLabel.Font = new Font("Segoe UI", 12F);
            SystemStatusLabel.Name = "SystemStatusLabel";
            SystemStatusLabel.Size = new Size(53, 21);
            SystemStatusLabel.Text = "Ready";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 470);
            Controls.Add(StatusStrip1);
            Controls.Add(ResultTextBox);
            Controls.Add(ResultLabel);
            Controls.Add(CallAPIButton);
            Controls.Add(ApiUrlTextBox);
            Controls.Add(APILabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimumSize = new Size(768, 509);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Genius API Client";
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label APILabel;
        private TextBox ApiUrlTextBox;
        private Button CallAPIButton;
        private Label ResultLabel;
        private TextBox ResultTextBox;
        private StatusStrip StatusStrip1;
        private ToolStripStatusLabel SystemStatusLabel;
    }
}
