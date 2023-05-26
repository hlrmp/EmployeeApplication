namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            firstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            position = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            hScrollBar1 = new HScrollBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, firstName, lastName, position });
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(364, 68);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 365);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // firstName
            // 
            firstName.HeaderText = "firstName";
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.HeaderText = "lastName";
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // position
            // 
            position.HeaderText = "position";
            position.Name = "position";
            position.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Location = new Point(75, 377);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(132, 47);
            button1.TabIndex = 1;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 40);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 2;
            label1.Text = "add Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 90);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 3;
            label2.Text = "Employee Id *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 156);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 4;
            label3.Text = "First Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 225);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 5;
            label4.Text = "Last Name  *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 288);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 6;
            label5.Text = "Position *";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 29);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(36, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 29);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(36, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 29);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(36, 310);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(226, 29);
            textBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(364, 40);
            label6.Name = "label6";
            label6.Size = new Size(140, 24);
            label6.TabIndex = 11;
            label6.Text = "Employee list :";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(610, 34);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(80, 17);
            hScrollBar1.TabIndex = 12;
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(829, 454);
            Controls.Add(hScrollBar1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmEmployeeDatabase";
            Text = "EmployeeDatabase";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn position;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private HScrollBar hScrollBar1;
    }
}