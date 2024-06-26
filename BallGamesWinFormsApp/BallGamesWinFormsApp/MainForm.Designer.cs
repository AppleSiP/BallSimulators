namespace BallGamesWinFormsApp
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
            components = new System.ComponentModel.Container();
            startButton = new Button();
            stopButton = new Button();
            statusTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startButton.Location = new Point(668, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(120, 30);
            startButton.TabIndex = 0;
            startButton.Text = "Начать Броуновское движение";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            stopButton.Enabled = false;
            stopButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stopButton.Location = new Point(668, 408);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(120, 30);
            stopButton.TabIndex = 1;
            stopButton.Text = "Поймать";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // statusTimer
            // 
            statusTimer.Tick += statusTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Name = "MainForm";
            Text = "BallsGame";
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button stopButton;
        private System.Windows.Forms.Timer statusTimer;
    }
}
