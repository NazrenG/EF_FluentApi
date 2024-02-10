namespace Taskk
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
            this.remove_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.getAll_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.remove_btn.Location = new System.Drawing.Point(11, 162);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(121, 69);
            this.remove_btn.TabIndex = 0;
            this.remove_btn.Text = "remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insert_btn.Location = new System.Drawing.Point(11, 237);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(121, 69);
            this.insert_btn.TabIndex = 0;
            this.insert_btn.Text = "insert";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // getAll_btn
            // 
            this.getAll_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getAll_btn.Location = new System.Drawing.Point(11, 312);
            this.getAll_btn.Name = "getAll_btn";
            this.getAll_btn.Size = new System.Drawing.Size(121, 69);
            this.getAll_btn.TabIndex = 0;
            this.getAll_btn.Text = "get all";
            this.getAll_btn.UseVisualStyleBackColor = false;
            this.getAll_btn.Click += new System.EventHandler(this.getAll_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Author",
            "Book",
            "Category",
            "Department",
            "Faculty",
            "Group",
            "Lib",
            "Press",
            "Student",
            "Teacher",
            "Theme"});
            this.comboBox1.Location = new System.Drawing.Point(11, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(588, 299);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_btn.Location = new System.Drawing.Point(11, 87);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(121, 69);
            this.update_btn.TabIndex = 0;
            this.update_btn.Text = "update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search for name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.getAll_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.remove_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button remove_btn;
        private Button insert_btn;
        private Button getAll_btn;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button update_btn;
        private TextBox textBox1;
        private Label label1;
    }
}