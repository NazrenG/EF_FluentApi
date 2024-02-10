namespace Taskk
{
    partial class BookForm
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
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.themeTxt = new System.Windows.Forms.TextBox();
            this.pressTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(160, 182);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(154, 23);
            this.quantityTxt.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(239, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstTxt
            // 
            this.firstTxt.Location = new System.Drawing.Point(160, 90);
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(154, 23);
            this.firstTxt.TabIndex = 24;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(160, 124);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(154, 23);
            this.yearTxt.TabIndex = 25;
            this.yearTxt.TextChanged += new System.EventHandler(this.lastTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Year";
            // 
            // commentTxt
            // 
            this.commentTxt.Location = new System.Drawing.Point(160, 153);
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(154, 23);
            this.commentTxt.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Comment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Add Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "PressId";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "AuthorId";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(160, 279);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(154, 23);
            this.authorTxt.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "ThemeId";
            // 
            // themeTxt
            // 
            this.themeTxt.Location = new System.Drawing.Point(160, 250);
            this.themeTxt.Name = "themeTxt";
            this.themeTxt.Size = new System.Drawing.Size(154, 23);
            this.themeTxt.TabIndex = 25;
            // 
            // pressTxt
            // 
            this.pressTxt.Location = new System.Drawing.Point(160, 216);
            this.pressTxt.Name = "pressTxt";
            this.pressTxt.Size = new System.Drawing.Size(154, 23);
            this.pressTxt.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "CategoryId";
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(160, 308);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(154, 23);
            this.categoryTxt.TabIndex = 29;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 409);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pressTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.themeTxt);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox quantityTxt;
        private Label label5;
        private Button button1;
        private TextBox firstTxt;
        private TextBox yearTxt;
        private Label label3;
        private TextBox commentTxt;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label6;
        private Label label7;
        private TextBox authorTxt;
        private Label label8;
        private TextBox themeTxt;
        private TextBox pressTxt;
        private Label label9;
        private TextBox categoryTxt;
    }
}