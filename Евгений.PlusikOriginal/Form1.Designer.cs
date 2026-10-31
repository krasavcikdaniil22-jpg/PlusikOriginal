namespace Евгений.PlusikOriginal
{
    partial class FormMain
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
            label1 = new Label();
            label2 = new Label();
            labelTargetNumber = new Label();
            labelUserNumber = new Label();
            buttonMult = new Button();
            buttonPlus = new Button();
            buttonRandomNumber = new Button();
            buttonReset = new Button();
            label3 = new Label();
            labelUserSteps = new Label();
            textBoxNum = new TextBox();
            buttonSpecifyNumber = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 162);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 50;
            label1.Text = "Your Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 51;
            label2.Text = "Target:";
            // 
            // labelTargetNumber
            // 
            labelTargetNumber.AutoSize = true;
            labelTargetNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTargetNumber.Location = new Point(107, 42);
            labelTargetNumber.Name = "labelTargetNumber";
            labelTargetNumber.Size = new Size(40, 32);
            labelTargetNumber.TabIndex = 52;
            labelTargetNumber.Text = "21";
            // 
            // labelUserNumber
            // 
            labelUserNumber.AutoSize = true;
            labelUserNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserNumber.Location = new Point(165, 162);
            labelUserNumber.Name = "labelUserNumber";
            labelUserNumber.Size = new Size(27, 32);
            labelUserNumber.TabIndex = 53;
            labelUserNumber.Text = "1";
            // 
            // buttonMult
            // 
            buttonMult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMult.Location = new Point(259, 19);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(87, 88);
            buttonMult.TabIndex = 54;
            buttonMult.Text = "*2";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlus.Location = new Point(259, 137);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(87, 88);
            buttonPlus.TabIndex = 55;
            buttonPlus.Text = "+1";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonRandomNumber
            // 
            buttonRandomNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRandomNumber.Location = new Point(12, 265);
            buttonRandomNumber.Name = "buttonRandomNumber";
            buttonRandomNumber.Size = new Size(334, 41);
            buttonRandomNumber.TabIndex = 56;
            buttonRandomNumber.Text = "generate a random number";
            buttonRandomNumber.UseVisualStyleBackColor = true;
            buttonRandomNumber.Click += buttonRandomNumber_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(12, 312);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(334, 36);
            buttonReset.TabIndex = 57;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 389);
            label3.Name = "label3";
            label3.Size = new Size(86, 37);
            label3.TabIndex = 58;
            label3.Text = "Steps:";
            // 
            // labelUserSteps
            // 
            labelUserSteps.AutoSize = true;
            labelUserSteps.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserSteps.Location = new Point(104, 394);
            labelUserSteps.Name = "labelUserSteps";
            labelUserSteps.Size = new Size(27, 32);
            labelUserSteps.TabIndex = 59;
            labelUserSteps.Text = "0";
            // 
            // textBoxNum
            // 
            textBoxNum.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNum.Location = new Point(243, 371);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(117, 35);
            textBoxNum.TabIndex = 60;
            textBoxNum.Text = "1";
            // 
            // buttonSpecifyNumber
            // 
            buttonSpecifyNumber.Location = new Point(243, 412);
            buttonSpecifyNumber.Name = "buttonSpecifyNumber";
            buttonSpecifyNumber.Size = new Size(117, 32);
            buttonSpecifyNumber.TabIndex = 61;
            buttonSpecifyNumber.Text = "Specify a number";
            buttonSpecifyNumber.UseVisualStyleBackColor = true;
            buttonSpecifyNumber.Click += buttonSpecifyNumber_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 457);
            Controls.Add(buttonSpecifyNumber);
            Controls.Add(textBoxNum);
            Controls.Add(labelUserSteps);
            Controls.Add(label3);
            Controls.Add(buttonReset);
            Controls.Add(buttonRandomNumber);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMult);
            Controls.Add(labelUserNumber);
            Controls.Add(labelTargetNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelTargetNumber;
        private Label labelUserNumber;
        private Button buttonMult;
        private Button buttonPlus;
        private Button buttonRandomNumber;
        private Button buttonReset;
        private Label label3;
        private Label labelUserSteps;
        private TextBox textBoxNum;
        private Button buttonSpecifyNumber;
    }
}
