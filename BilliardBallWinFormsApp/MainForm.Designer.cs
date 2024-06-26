namespace BilliardBallWinFormsApp
{
    partial class MainForm
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
            leftLabelBlue = new Label();
            topLabelBlue = new Label();
            downLabelBlue = new Label();
            rightLabelBlue = new Label();
            topLabelRed = new Label();
            rightLabelRed = new Label();
            leftLabelRed = new Label();
            downLabelRed = new Label();
            menuStrip = new MenuStrip();
            перезапускToolStripMenuItem = new ToolStripMenuItem();
            playToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // leftLabelBlue
            // 
            leftLabelBlue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            leftLabelBlue.AutoSize = true;
            leftLabelBlue.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            leftLabelBlue.ForeColor = Color.Blue;
            leftLabelBlue.Location = new Point(1, 167);
            leftLabelBlue.Name = "leftLabelBlue";
            leftLabelBlue.Size = new Size(14, 16);
            leftLabelBlue.TabIndex = 0;
            leftLabelBlue.Text = "0";
            // 
            // topLabelBlue
            // 
            topLabelBlue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topLabelBlue.AutoSize = true;
            topLabelBlue.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            topLabelBlue.ForeColor = Color.Blue;
            topLabelBlue.Location = new Point(309, 9);
            topLabelBlue.Name = "topLabelBlue";
            topLabelBlue.Size = new Size(14, 16);
            topLabelBlue.TabIndex = 1;
            topLabelBlue.Text = "0";
            // 
            // downLabelBlue
            // 
            downLabelBlue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downLabelBlue.AutoSize = true;
            downLabelBlue.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            downLabelBlue.ForeColor = Color.Blue;
            downLabelBlue.Location = new Point(481, 425);
            downLabelBlue.Name = "downLabelBlue";
            downLabelBlue.Size = new Size(14, 16);
            downLabelBlue.TabIndex = 2;
            downLabelBlue.Text = "0";
            // 
            // rightLabelBlue
            // 
            rightLabelBlue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightLabelBlue.AutoSize = true;
            rightLabelBlue.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            rightLabelBlue.ForeColor = Color.Blue;
            rightLabelBlue.Location = new Point(774, 229);
            rightLabelBlue.Name = "rightLabelBlue";
            rightLabelBlue.Size = new Size(14, 16);
            rightLabelBlue.TabIndex = 3;
            rightLabelBlue.Text = "0";
            // 
            // topLabelRed
            // 
            topLabelRed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topLabelRed.AutoSize = true;
            topLabelRed.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            topLabelRed.ForeColor = Color.Red;
            topLabelRed.Location = new Point(481, 9);
            topLabelRed.Name = "topLabelRed";
            topLabelRed.Size = new Size(14, 16);
            topLabelRed.TabIndex = 4;
            topLabelRed.Text = "0";
            // 
            // rightLabelRed
            // 
            rightLabelRed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightLabelRed.AutoSize = true;
            rightLabelRed.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            rightLabelRed.ForeColor = Color.Red;
            rightLabelRed.Location = new Point(774, 167);
            rightLabelRed.Name = "rightLabelRed";
            rightLabelRed.Size = new Size(14, 16);
            rightLabelRed.TabIndex = 5;
            rightLabelRed.Text = "0";
            // 
            // leftLabelRed
            // 
            leftLabelRed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            leftLabelRed.AutoSize = true;
            leftLabelRed.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            leftLabelRed.ForeColor = Color.Red;
            leftLabelRed.Location = new Point(1, 229);
            leftLabelRed.Name = "leftLabelRed";
            leftLabelRed.Size = new Size(14, 16);
            leftLabelRed.TabIndex = 6;
            leftLabelRed.Text = "0";
            // 
            // downLabelRed
            // 
            downLabelRed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            downLabelRed.AutoSize = true;
            downLabelRed.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            downLabelRed.ForeColor = Color.Red;
            downLabelRed.Location = new Point(309, 425);
            downLabelRed.Name = "downLabelRed";
            downLabelRed.Size = new Size(14, 16);
            downLabelRed.TabIndex = 7;
            downLabelRed.Text = "0";
            // 
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackColor = Color.White;
            menuStrip.GripStyle = ToolStripGripStyle.Visible;
            menuStrip.Items.AddRange(new ToolStripItem[] { перезапускToolStripMenuItem, playToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.System;
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 10;
            menuStrip.Text = "Меню";
            // 
            // перезапускToolStripMenuItem
            // 
            перезапускToolStripMenuItem.Name = "перезапускToolStripMenuItem";
            перезапускToolStripMenuItem.Size = new Size(83, 20);
            перезапускToolStripMenuItem.Text = "Перезапуск";
            перезапускToolStripMenuItem.Click += перезапускToolStripMenuItem_Click;
            // 
            // playToolStripMenuItem
            // 
            playToolStripMenuItem.Name = "playToolStripMenuItem";
            playToolStripMenuItem.Size = new Size(50, 20);
            playToolStripMenuItem.Text = "Старт";
            playToolStripMenuItem.Click += playToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(downLabelRed);
            Controls.Add(leftLabelRed);
            Controls.Add(rightLabelRed);
            Controls.Add(topLabelRed);
            Controls.Add(rightLabelBlue);
            Controls.Add(downLabelBlue);
            Controls.Add(topLabelBlue);
            Controls.Add(leftLabelBlue);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diffusion simulation";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabelBlue;
        private Label topLabelBlue;
        private Label downLabelBlue;
        private Label rightLabelBlue;
        private Label topLabelRed;
        private Label rightLabelRed;
        private Label leftLabelRed;
        private Label downLabelRed;
        private MenuStrip menuStrip;
        private ToolStripMenuItem перезапускToolStripMenuItem;
        private ToolStripMenuItem playToolStripMenuItem;
    }
}
