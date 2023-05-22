namespace Riddling_Tic_Tac_Toe
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            resultDisplay = new Label();
            restartButton = new Button();
            questionBox = new Label();
            answerBox = new TextBox();
            label2 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            decisionBox = new Label();
            nextButton = new Button();
            checkButton = new Button();
            turnLabel = new Label();
            topBox = new Label();
            boardMark = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(386, 280);
            button1.Name = "button1";
            button1.Size = new Size(89, 89);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(481, 280);
            button2.Name = "button2";
            button2.Size = new Size(89, 89);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(576, 280);
            button3.Name = "button3";
            button3.Size = new Size(89, 89);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(386, 375);
            button4.Name = "button4";
            button4.Size = new Size(89, 89);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(481, 375);
            button5.Name = "button5";
            button5.Size = new Size(89, 89);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(576, 375);
            button6.Name = "button6";
            button6.Size = new Size(89, 89);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(386, 470);
            button7.Name = "button7";
            button7.Size = new Size(89, 89);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(481, 470);
            button8.Name = "button8";
            button8.Size = new Size(89, 89);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(576, 470);
            button9.Name = "button9";
            button9.Size = new Size(89, 89);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // resultDisplay
            // 
            resultDisplay.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            resultDisplay.Location = new Point(364, 571);
            resultDisplay.Name = "resultDisplay";
            resultDisplay.Size = new Size(323, 52);
            resultDisplay.TabIndex = 9;
            resultDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // restartButton
            // 
            restartButton.BackColor = Color.Yellow;
            restartButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            restartButton.Location = new Point(693, 571);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(110, 55);
            restartButton.TabIndex = 10;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // questionBox
            // 
            questionBox.BackColor = Color.White;
            questionBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            questionBox.Location = new Point(58, 22);
            questionBox.Name = "questionBox";
            questionBox.Size = new Size(1023, 95);
            questionBox.TabIndex = 11;
            questionBox.Text = "Loading...";
            questionBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerBox
            // 
            answerBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            answerBox.Location = new Point(386, 130);
            answerBox.Multiline = true;
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(279, 56);
            answerBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(289, 134);
            label2.Name = "label2";
            label2.Size = new Size(91, 52);
            label2.TabIndex = 13;
            label2.Text = "Ans: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // decisionBox
            // 
            decisionBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            decisionBox.Location = new Point(671, 129);
            decisionBox.Name = "decisionBox";
            decisionBox.Size = new Size(419, 52);
            decisionBox.TabIndex = 14;
            decisionBox.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Yellow;
            nextButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nextButton.Location = new Point(531, 192);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(134, 55);
            nextButton.TabIndex = 15;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // checkButton
            // 
            checkButton.BackColor = Color.Yellow;
            checkButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkButton.Location = new Point(387, 192);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(138, 55);
            checkButton.TabIndex = 16;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = false;
            checkButton.Click += checkButton_Click;
            // 
            // turnLabel
            // 
            turnLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            turnLabel.Location = new Point(671, 192);
            turnLabel.Name = "turnLabel";
            turnLabel.Size = new Size(278, 52);
            turnLabel.TabIndex = 17;
            turnLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // topBox
            // 
            topBox.BackColor = Color.White;
            topBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            topBox.Location = new Point(58, 22);
            topBox.Name = "topBox";
            topBox.Size = new Size(1023, 95);
            topBox.TabIndex = 18;
            topBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boardMark
            // 
            boardMark.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            boardMark.Location = new Point(680, 375);
            boardMark.Name = "boardMark";
            boardMark.Size = new Size(401, 102);
            boardMark.TabIndex = 19;
            boardMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1117, 632);
            Controls.Add(boardMark);
            Controls.Add(topBox);
            Controls.Add(turnLabel);
            Controls.Add(checkButton);
            Controls.Add(nextButton);
            Controls.Add(decisionBox);
            Controls.Add(label2);
            Controls.Add(answerBox);
            Controls.Add(questionBox);
            Controls.Add(restartButton);
            Controls.Add(resultDisplay);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(1139, 688);
            MinimumSize = new Size(1139, 688);
            Name = "Form1";
            Text = "Riddling Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label resultDisplay;
        private Button restartButton;
        private Label questionBox;
        private TextBox answerBox;
        private Label label2;
        private System.Windows.Forms.Timer timer;
        private Label decisionBox;
        private Button nextButton;
        private Button checkButton;
        private Label turnLabel;
        private Label topBox;
        private Label boardMark;
    }
}