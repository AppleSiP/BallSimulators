namespace CatchMeWinFormsApp
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
            clearButton = new Button();
            countcatchBallsLabel = new Label();
            statusTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startButton.Location = new Point(690, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(98, 31);
            startButton.TabIndex = 0;
            startButton.Text = "Создать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearButton.Enabled = false;
            clearButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearButton.Location = new Point(690, 407);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(98, 31);
            clearButton.TabIndex = 1;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // countcatchBallsLabel
            // 
            countcatchBallsLabel.BackColor = Color.White;
            countcatchBallsLabel.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countcatchBallsLabel.Location = new Point(10, 12);
            countcatchBallsLabel.Name = "countcatchBallsLabel";
            countcatchBallsLabel.Size = new Size(120, 31);
            countcatchBallsLabel.TabIndex = 2;
            countcatchBallsLabel.Text = "Поймано:";
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
            Controls.Add(countcatchBallsLabel);
            Controls.Add(clearButton);
            Controls.Add(startButton);
            Name = "MainForm";
            Text = "Поймай меня!";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button clearButton;
        private Label countcatchBallsLabel;
        private System.Windows.Forms.Timer statusTimer;
    }
}
