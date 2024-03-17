namespace KnapsackGUI
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
            labelNumberOfItems = new Label();
            textBoxNumberOfItems = new TextBox();
            labelSeed = new Label();
            textBoxSeed = new TextBox();
            labelCapacity = new Label();
            textBoxCapacity = new TextBox();
            buttonRun = new Button();
            textBoxResults = new TextBox();
            labelResults = new Label();
            textBoxItems = new TextBox();
            labelItems = new Label();
            SuspendLayout();
            // 
            // labelNumberOfItems
            // 
            labelNumberOfItems.AutoSize = true;
            labelNumberOfItems.Location = new Point(12, 27);
            labelNumberOfItems.Name = "labelNumberOfItems";
            labelNumberOfItems.Size = new Size(121, 20);
            labelNumberOfItems.TabIndex = 0;
            labelNumberOfItems.Text = "Number of items";
            // 
            // textBoxNumberOfItems
            // 
            textBoxNumberOfItems.Location = new Point(12, 50);
            textBoxNumberOfItems.Name = "textBoxNumberOfItems";
            textBoxNumberOfItems.Size = new Size(125, 27);
            textBoxNumberOfItems.TabIndex = 1;
            // 
            // labelSeed
            // 
            labelSeed.AutoSize = true;
            labelSeed.Location = new Point(12, 80);
            labelSeed.Name = "labelSeed";
            labelSeed.Size = new Size(42, 20);
            labelSeed.TabIndex = 2;
            labelSeed.Text = "Seed";
            // 
            // textBoxSeed
            // 
            textBoxSeed.Location = new Point(12, 103);
            textBoxSeed.Name = "textBoxSeed";
            textBoxSeed.Size = new Size(125, 27);
            textBoxSeed.TabIndex = 3;
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Location = new Point(12, 133);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(66, 20);
            labelCapacity.TabIndex = 4;
            labelCapacity.Text = "Capacity";
            // 
            // textBoxCapacity
            // 
            textBoxCapacity.Location = new Point(12, 156);
            textBoxCapacity.Name = "textBoxCapacity";
            textBoxCapacity.Size = new Size(125, 27);
            textBoxCapacity.TabIndex = 5;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(12, 200);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(125, 29);
            buttonRun.TabIndex = 6;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // textBoxResults
            // 
            textBoxResults.Location = new Point(12, 248);
            textBoxResults.Multiline = true;
            textBoxResults.Name = "textBoxResults";
            textBoxResults.ReadOnly = true;
            textBoxResults.ScrollBars = ScrollBars.Vertical;
            textBoxResults.Size = new Size(372, 460);
            textBoxResults.TabIndex = 7;
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Location = new Point(329, 225);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(55, 20);
            labelResults.TabIndex = 8;
            labelResults.Text = "Results";
            // 
            // textBoxItems
            // 
            textBoxItems.Location = new Point(390, 50);
            textBoxItems.Multiline = true;
            textBoxItems.Name = "textBoxItems";
            textBoxItems.ReadOnly = true;
            textBoxItems.ScrollBars = ScrollBars.Vertical;
            textBoxItems.Size = new Size(398, 658);
            textBoxItems.TabIndex = 9;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Location = new Point(743, 27);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(45, 20);
            labelItems.TabIndex = 10;
            labelItems.Text = "Items";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 720);
            Controls.Add(labelItems);
            Controls.Add(textBoxItems);
            Controls.Add(labelResults);
            Controls.Add(textBoxResults);
            Controls.Add(buttonRun);
            Controls.Add(textBoxCapacity);
            Controls.Add(labelCapacity);
            Controls.Add(textBoxSeed);
            Controls.Add(labelSeed);
            Controls.Add(textBoxNumberOfItems);
            Controls.Add(labelNumberOfItems);
            Name = "Form1";
            Text = "Knapsack Problem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumberOfItems;
        private TextBox textBoxNumberOfItems;
        private Label labelSeed;
        private TextBox textBoxSeed;
        private Label labelCapacity;
        private TextBox textBoxCapacity;
        private Button buttonRun;
        private TextBox textBoxResults;
        private Label labelResults;
        private TextBox textBoxItems;
        private Label labelItems;
    }
}
