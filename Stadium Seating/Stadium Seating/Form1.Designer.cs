namespace Stadium_Seating
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ticketsSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.ticketClassCLabel = new System.Windows.Forms.Label();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.ticketClassBLabel = new System.Windows.Forms.Label();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.ticketClassALabel = new System.Windows.Forms.Label();
            this.enterTicketsLabel = new System.Windows.Forms.Label();
            this.revenueGeneratedGroupBox = new System.Windows.Forms.GroupBox();
            this.calculatedClassBLabel = new System.Windows.Forms.Label();
            this.calculatedClassCLabel = new System.Windows.Forms.Label();
            this.calculatedTotalLabel = new System.Windows.Forms.Label();
            this.calculatedClassALabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.revenueClassBLabel = new System.Windows.Forms.Label();
            this.revenueClassCLabel = new System.Windows.Forms.Label();
            this.revenueClassALabel = new System.Windows.Forms.Label();
            this.calcRevenueButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsSoldGroupBox.SuspendLayout();
            this.revenueGeneratedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSoldGroupBox
            // 
            this.ticketsSoldGroupBox.Controls.Add(this.classCTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.ticketClassCLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classBTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.ticketClassBLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classATextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.ticketClassALabel);
            this.ticketsSoldGroupBox.Controls.Add(this.enterTicketsLabel);
            this.ticketsSoldGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ticketsSoldGroupBox.Name = "ticketsSoldGroupBox";
            this.ticketsSoldGroupBox.Size = new System.Drawing.Size(233, 160);
            this.ticketsSoldGroupBox.TabIndex = 0;
            this.ticketsSoldGroupBox.TabStop = false;
            this.ticketsSoldGroupBox.Text = "Tickets Sold";
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(88, 115);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(92, 20);
            this.classCTextBox.TabIndex = 6;
            // 
            // ticketClassCLabel
            // 
            this.ticketClassCLabel.AutoSize = true;
            this.ticketClassCLabel.Location = new System.Drawing.Point(24, 118);
            this.ticketClassCLabel.Name = "ticketClassCLabel";
            this.ticketClassCLabel.Size = new System.Drawing.Size(45, 13);
            this.ticketClassCLabel.TabIndex = 5;
            this.ticketClassCLabel.Text = "Class C:";
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(88, 89);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(92, 20);
            this.classBTextBox.TabIndex = 4;
            // 
            // ticketClassBLabel
            // 
            this.ticketClassBLabel.AutoSize = true;
            this.ticketClassBLabel.Location = new System.Drawing.Point(24, 92);
            this.ticketClassBLabel.Name = "ticketClassBLabel";
            this.ticketClassBLabel.Size = new System.Drawing.Size(45, 13);
            this.ticketClassBLabel.TabIndex = 3;
            this.ticketClassBLabel.Text = "Class B:";
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(88, 63);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(92, 20);
            this.classATextBox.TabIndex = 2;
            // 
            // ticketClassALabel
            // 
            this.ticketClassALabel.AutoSize = true;
            this.ticketClassALabel.Location = new System.Drawing.Point(24, 66);
            this.ticketClassALabel.Name = "ticketClassALabel";
            this.ticketClassALabel.Size = new System.Drawing.Size(45, 13);
            this.ticketClassALabel.TabIndex = 1;
            this.ticketClassALabel.Text = "Class A:";
            // 
            // enterTicketsLabel
            // 
            this.enterTicketsLabel.Location = new System.Drawing.Point(24, 27);
            this.enterTicketsLabel.Name = "enterTicketsLabel";
            this.enterTicketsLabel.Size = new System.Drawing.Size(169, 39);
            this.enterTicketsLabel.TabIndex = 0;
            this.enterTicketsLabel.Text = "Enter the number of tickets sold for each class of seats";
            // 
            // revenueGeneratedGroupBox
            // 
            this.revenueGeneratedGroupBox.Controls.Add(this.calculatedClassBLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.calculatedClassCLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.calculatedTotalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.calculatedClassALabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.totalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.revenueClassBLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.revenueClassCLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.revenueClassALabel);
            this.revenueGeneratedGroupBox.Location = new System.Drawing.Point(251, 12);
            this.revenueGeneratedGroupBox.Name = "revenueGeneratedGroupBox";
            this.revenueGeneratedGroupBox.Size = new System.Drawing.Size(168, 160);
            this.revenueGeneratedGroupBox.TabIndex = 0;
            this.revenueGeneratedGroupBox.TabStop = false;
            this.revenueGeneratedGroupBox.Text = "Revenue Generated";
            // 
            // calculatedClassBLabel
            // 
            this.calculatedClassBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedClassBLabel.Location = new System.Drawing.Point(57, 63);
            this.calculatedClassBLabel.Name = "calculatedClassBLabel";
            this.calculatedClassBLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedClassBLabel.TabIndex = 7;
            this.calculatedClassBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedClassCLabel
            // 
            this.calculatedClassCLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedClassCLabel.Location = new System.Drawing.Point(57, 89);
            this.calculatedClassCLabel.Name = "calculatedClassCLabel";
            this.calculatedClassCLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedClassCLabel.TabIndex = 6;
            this.calculatedClassCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedTotalLabel
            // 
            this.calculatedTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedTotalLabel.Location = new System.Drawing.Point(57, 117);
            this.calculatedTotalLabel.Name = "calculatedTotalLabel";
            this.calculatedTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedTotalLabel.TabIndex = 5;
            this.calculatedTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedClassALabel
            // 
            this.calculatedClassALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedClassALabel.Location = new System.Drawing.Point(57, 35);
            this.calculatedClassALabel.Name = "calculatedClassALabel";
            this.calculatedClassALabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedClassALabel.TabIndex = 4;
            this.calculatedClassALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(17, 122);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total:";
            // 
            // revenueClassBLabel
            // 
            this.revenueClassBLabel.AutoSize = true;
            this.revenueClassBLabel.Location = new System.Drawing.Point(6, 68);
            this.revenueClassBLabel.Name = "revenueClassBLabel";
            this.revenueClassBLabel.Size = new System.Drawing.Size(45, 13);
            this.revenueClassBLabel.TabIndex = 2;
            this.revenueClassBLabel.Text = "Class B:";
            // 
            // revenueClassCLabel
            // 
            this.revenueClassCLabel.AutoSize = true;
            this.revenueClassCLabel.Location = new System.Drawing.Point(6, 94);
            this.revenueClassCLabel.Name = "revenueClassCLabel";
            this.revenueClassCLabel.Size = new System.Drawing.Size(45, 13);
            this.revenueClassCLabel.TabIndex = 1;
            this.revenueClassCLabel.Text = "Class C:";
            // 
            // revenueClassALabel
            // 
            this.revenueClassALabel.AutoSize = true;
            this.revenueClassALabel.Location = new System.Drawing.Point(6, 40);
            this.revenueClassALabel.Name = "revenueClassALabel";
            this.revenueClassALabel.Size = new System.Drawing.Size(45, 13);
            this.revenueClassALabel.TabIndex = 0;
            this.revenueClassALabel.Text = "Class A:";
            // 
            // calcRevenueButton
            // 
            this.calcRevenueButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calcRevenueButton.Location = new System.Drawing.Point(66, 196);
            this.calcRevenueButton.Name = "calcRevenueButton";
            this.calcRevenueButton.Size = new System.Drawing.Size(80, 51);
            this.calcRevenueButton.TabIndex = 1;
            this.calcRevenueButton.Text = "Calculate Revenue";
            this.calcRevenueButton.UseVisualStyleBackColor = true;
            this.calcRevenueButton.Click += new System.EventHandler(this.calcRevenueButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(170, 196);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 51);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(271, 196);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 51);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 272);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcRevenueButton);
            this.Controls.Add(this.revenueGeneratedGroupBox);
            this.Controls.Add(this.ticketsSoldGroupBox);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ticketsSoldGroupBox.ResumeLayout(false);
            this.ticketsSoldGroupBox.PerformLayout();
            this.revenueGeneratedGroupBox.ResumeLayout(false);
            this.revenueGeneratedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ticketsSoldGroupBox;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.Label ticketClassCLabel;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.Label ticketClassBLabel;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label ticketClassALabel;
        private System.Windows.Forms.Label enterTicketsLabel;
        private System.Windows.Forms.GroupBox revenueGeneratedGroupBox;
        private System.Windows.Forms.Button calcRevenueButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label revenueClassALabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label revenueClassBLabel;
        private System.Windows.Forms.Label revenueClassCLabel;
        private System.Windows.Forms.Label calculatedClassBLabel;
        private System.Windows.Forms.Label calculatedClassCLabel;
        private System.Windows.Forms.Label calculatedTotalLabel;
        private System.Windows.Forms.Label calculatedClassALabel;
    }
}

