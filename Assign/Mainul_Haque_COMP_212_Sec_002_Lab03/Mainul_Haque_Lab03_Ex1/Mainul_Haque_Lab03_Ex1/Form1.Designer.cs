namespace Mainul_Haque_Lab03_Ex1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.facResult = new System.Windows.Forms.Label();
            this.FactorialButton = new System.Windows.Forms.Button();
            this.factorialInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.oddResult = new System.Windows.Forms.Label();
            this.oddButton = new System.Windows.Forms.Button();
            this.oddInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.indexHighText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.indexLowText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listValues = new System.Windows.Forms.ListBox();
            this.buttonValue = new System.Windows.Forms.Button();
            this.radioChar = new System.Windows.Forms.RadioButton();
            this.radioDouble = new System.Windows.Forms.RadioButton();
            this.radioInt = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.facResult);
            this.groupBox1.Controls.Add(this.FactorialButton);
            this.groupBox1.Controls.Add(this.factorialInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1) Calculate Asynchronously";
            // 
            // facResult
            // 
            this.facResult.AutoSize = true;
            this.facResult.Location = new System.Drawing.Point(28, 54);
            this.facResult.Name = "facResult";
            this.facResult.Size = new System.Drawing.Size(151, 13);
            this.facResult.TabIndex = 3;
            this.facResult.Text = "                                                ";
            // 
            // FactorialButton
            // 
            this.FactorialButton.Location = new System.Drawing.Point(55, 80);
            this.FactorialButton.Name = "FactorialButton";
            this.FactorialButton.Size = new System.Drawing.Size(75, 23);
            this.FactorialButton.TabIndex = 2;
            this.FactorialButton.Text = "Calculate";
            this.FactorialButton.UseVisualStyleBackColor = true;
            this.FactorialButton.Click += new System.EventHandler(this.FactorialButton_Click_1);
            // 
            // factorialInput
            // 
            this.factorialInput.Location = new System.Drawing.Point(88, 19);
            this.factorialInput.Name = "factorialInput";
            this.factorialInput.Size = new System.Drawing.Size(100, 20);
            this.factorialInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Factorial of";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.oddResult);
            this.groupBox2.Controls.Add(this.oddButton);
            this.groupBox2.Controls.Add(this.oddInput);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2) Check for Even/Odd ";
            // 
            // oddResult
            // 
            this.oddResult.AutoSize = true;
            this.oddResult.Location = new System.Drawing.Point(48, 54);
            this.oddResult.Name = "oddResult";
            this.oddResult.Size = new System.Drawing.Size(82, 13);
            this.oddResult.TabIndex = 3;
            this.oddResult.Text = "                         ";
            // 
            // oddButton
            // 
            this.oddButton.Location = new System.Drawing.Point(41, 81);
            this.oddButton.Name = "oddButton";
            this.oddButton.Size = new System.Drawing.Size(116, 23);
            this.oddButton.TabIndex = 2;
            this.oddButton.Text = "Check for Even/Odd";
            this.oddButton.UseVisualStyleBackColor = true;
            this.oddButton.Click += new System.EventHandler(this.oddButton_Click);
            // 
            // oddInput
            // 
            this.oddInput.Location = new System.Drawing.Point(91, 22);
            this.oddInput.Name = "oddInput";
            this.oddInput.Size = new System.Drawing.Size(100, 20);
            this.oddInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showIndex);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonDisplay);
            this.groupBox3.Controls.Add(this.indexHighText);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.indexLowText);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.searchBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.listValues);
            this.groupBox3.Controls.Add(this.buttonValue);
            this.groupBox3.Controls.Add(this.radioChar);
            this.groupBox3.Controls.Add(this.radioDouble);
            this.groupBox3.Controls.Add(this.radioInt);
            this.groupBox3.Location = new System.Drawing.Point(218, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 297);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3) Display List of Values and Search";
            // 
            // showIndex
            // 
            this.showIndex.Location = new System.Drawing.Point(70, 258);
            this.showIndex.Name = "showIndex";
            this.showIndex.Size = new System.Drawing.Size(246, 20);
            this.showIndex.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Output of value between high and low Index";
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(241, 138);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 12;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // indexHighText
            // 
            this.indexHighText.Location = new System.Drawing.Point(160, 160);
            this.indexHighText.Name = "indexHighText";
            this.indexHighText.Size = new System.Drawing.Size(74, 20);
            this.indexHighText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Inputt High Index";
            // 
            // indexLowText
            // 
            this.indexLowText.Location = new System.Drawing.Point(160, 120);
            this.indexLowText.Name = "indexLowText";
            this.indexLowText.Size = new System.Drawing.Size(73, 20);
            this.indexLowText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Input Low Index";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(241, 77);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchBox1
            // 
            this.searchBox1.Location = new System.Drawing.Point(172, 77);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(62, 20);
            this.searchBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input Value for search";
            // 
            // listValues
            // 
            this.listValues.FormattingEnabled = true;
            this.listValues.Location = new System.Drawing.Point(4, 54);
            this.listValues.Name = "listValues";
            this.listValues.Size = new System.Drawing.Size(58, 225);
            this.listValues.TabIndex = 4;
            // 
            // buttonValue
            // 
            this.buttonValue.Location = new System.Drawing.Point(192, 23);
            this.buttonValue.Name = "buttonValue";
            this.buttonValue.Size = new System.Drawing.Size(104, 23);
            this.buttonValue.TabIndex = 3;
            this.buttonValue.Text = "Generate Values";
            this.buttonValue.UseVisualStyleBackColor = true;
            this.buttonValue.Click += new System.EventHandler(this.buttonValue_Click);
            // 
            // radioChar
            // 
            this.radioChar.AutoSize = true;
            this.radioChar.Location = new System.Drawing.Point(122, 23);
            this.radioChar.Name = "radioChar";
            this.radioChar.Size = new System.Drawing.Size(47, 17);
            this.radioChar.TabIndex = 2;
            this.radioChar.TabStop = true;
            this.radioChar.Text = "Char";
            this.radioChar.UseVisualStyleBackColor = true;
            // 
            // radioDouble
            // 
            this.radioDouble.AutoSize = true;
            this.radioDouble.Location = new System.Drawing.Point(62, 23);
            this.radioDouble.Name = "radioDouble";
            this.radioDouble.Size = new System.Drawing.Size(59, 17);
            this.radioDouble.TabIndex = 1;
            this.radioDouble.TabStop = true;
            this.radioDouble.Text = "Double";
            this.radioDouble.UseVisualStyleBackColor = true;
            // 
            // radioInt
            // 
            this.radioInt.AutoSize = true;
            this.radioInt.Location = new System.Drawing.Point(6, 22);
            this.radioInt.Name = "radioInt";
            this.radioInt.Size = new System.Drawing.Size(58, 17);
            this.radioInt.TabIndex = 0;
            this.radioInt.TabStop = true;
            this.radioInt.Text = "Integer";
            this.radioInt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FactorialButton;
        private System.Windows.Forms.TextBox factorialInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button oddButton;
        private System.Windows.Forms.TextBox oddInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label facResult;
        private System.Windows.Forms.Label oddResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox showIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.TextBox indexHighText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox indexLowText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listValues;
        private System.Windows.Forms.Button buttonValue;
        private System.Windows.Forms.RadioButton radioChar;
        private System.Windows.Forms.RadioButton radioDouble;
        private System.Windows.Forms.RadioButton radioInt;
    }
}

