namespace Help_with_ideas
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
            System.Windows.Forms.Label TheResult;
            this.checkedListWorkSpace = new System.Windows.Forms.CheckedListBox();
            this.GetTheResult = new System.Windows.Forms.Button();
            this.NewWorkSpace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewMainIdea = new System.Windows.Forms.TextBox();
            this.checkedListMainIdea = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddWorkSpace = new System.Windows.Forms.Button();
            this.AddMainIdea = new System.Windows.Forms.Button();
            TheResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListWorkSpace
            // 
            this.checkedListWorkSpace.FormattingEnabled = true;
            this.checkedListWorkSpace.HorizontalScrollbar = true;
            this.checkedListWorkSpace.Items.AddRange(new object[] {
            "Unity",
            "VisualStudio",
            "AndroidStudio",
            "PyCharm"});
            this.checkedListWorkSpace.Location = new System.Drawing.Point(432, 74);
            this.checkedListWorkSpace.Name = "checkedListWorkSpace";
            this.checkedListWorkSpace.Size = new System.Drawing.Size(333, 130);
            this.checkedListWorkSpace.TabIndex = 0;
            // 
            // GetTheResult
            // 
            this.GetTheResult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetTheResult.Location = new System.Drawing.Point(52, 74);
            this.GetTheResult.Name = "GetTheResult";
            this.GetTheResult.Size = new System.Drawing.Size(333, 131);
            this.GetTheResult.TabIndex = 2;
            this.GetTheResult.Text = "Let\'s go!!";
            this.GetTheResult.UseVisualStyleBackColor = true;
            this.GetTheResult.Click += new System.EventHandler(this.GetTheResult_Click);
            // 
            // TheResult
            // 
            TheResult.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TheResult.Location = new System.Drawing.Point(61, 268);
            TheResult.MaximumSize = new System.Drawing.Size(400, 0);
            TheResult.Name = "TheResult";
            TheResult.Size = new System.Drawing.Size(289, 94);
            TheResult.TabIndex = 3;
            TheResult.Text = "Your challenge is waiting for you....";
            // 
            // NewWorkSpace
            // 
            this.NewWorkSpace.Location = new System.Drawing.Point(432, 45);
            this.NewWorkSpace.Name = "NewWorkSpace";
            this.NewWorkSpace.Size = new System.Drawing.Size(252, 23);
            this.NewWorkSpace.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(555, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "WorkSpace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(555, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Main Idea";
            // 
            // NewMainIdea
            // 
            this.NewMainIdea.Location = new System.Drawing.Point(432, 255);
            this.NewMainIdea.Name = "NewMainIdea";
            this.NewMainIdea.Size = new System.Drawing.Size(252, 23);
            this.NewMainIdea.TabIndex = 11;
            // 
            // checkedListMainIdea
            // 
            this.checkedListMainIdea.FormattingEnabled = true;
            this.checkedListMainIdea.HorizontalScrollbar = true;
            this.checkedListMainIdea.Items.AddRange(new object[] {
            "Music",
            "FrontEnd",
            "InterestingFunction",
            "InternetSource"});
            this.checkedListMainIdea.Location = new System.Drawing.Point(432, 284);
            this.checkedListMainIdea.Name = "checkedListMainIdea";
            this.checkedListMainIdea.Size = new System.Drawing.Size(333, 130);
            this.checkedListMainIdea.TabIndex = 9;
            // 
            // AddWorkSpace
            // 
            this.AddWorkSpace.Location = new System.Drawing.Point(690, 45);
            this.AddWorkSpace.Name = "AddWorkSpace";
            this.AddWorkSpace.Size = new System.Drawing.Size(75, 23);
            this.AddWorkSpace.TabIndex = 13;
            this.AddWorkSpace.Text = "Add";
            this.AddWorkSpace.UseVisualStyleBackColor = true;
            this.AddWorkSpace.Click += new System.EventHandler(this.AddWorkSpace_Click);
            // 
            // AddMainIdea
            // 
            this.AddMainIdea.Location = new System.Drawing.Point(690, 254);
            this.AddMainIdea.Name = "AddMainIdea";
            this.AddMainIdea.Size = new System.Drawing.Size(75, 23);
            this.AddMainIdea.TabIndex = 14;
            this.AddMainIdea.Text = "Add";
            this.AddMainIdea.UseVisualStyleBackColor = true;
            this.AddMainIdea.Click += new System.EventHandler(this.AddMainIdea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddMainIdea);
            this.Controls.Add(this.AddWorkSpace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewMainIdea);
            this.Controls.Add(this.checkedListMainIdea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewWorkSpace);
            this.Controls.Add(TheResult);
            this.Controls.Add(this.GetTheResult);
            this.Controls.Add(this.checkedListWorkSpace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListWorkSpace;
        private Button GetTheResult;
        private Label TheResult;
        private TextBox NewWorkSpace;
        private Label label2;
        private Label label3;
        private TextBox NewMainIdea;
        private CheckedListBox checkedListMainIdea;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button AddWorkSpace;
        private Button AddMainIdea;
    }
}