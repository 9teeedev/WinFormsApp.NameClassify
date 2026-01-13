namespace WinFormsApp.NameClassify
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
            label1 = new Label();
            txtFullname = new TextBox();
            btnClassify = new Button();
            label2 = new Label();
            txtTitle = new TextBox();
            txtFname = new TextBox();
            label3 = new Label();
            txtLname = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 54);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ สกุล แบบเต็ม";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(245, 51);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(461, 36);
            txtFullname.TabIndex = 1;
            // 
            // btnClassify
            // 
            btnClassify.Location = new Point(733, 51);
            btnClassify.Name = "btnClassify";
            btnClassify.Size = new Size(113, 36);
            btnClassify.TabIndex = 2;
            btnClassify.Text = "แยก";
            btnClassify.UseVisualStyleBackColor = true;
            btnClassify.Click += btnClassify_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 142);
            label2.Name = "label2";
            label2.Size = new Size(84, 30);
            label2.TabIndex = 3;
            label2.Text = "คำนำหน้า";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Window;
            txtTitle.Location = new Point(245, 139);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(216, 36);
            txtTitle.TabIndex = 4;
            // 
            // txtFname
            // 
            txtFname.BackColor = SystemColors.Window;
            txtFname.Location = new Point(245, 191);
            txtFname.Name = "txtFname";
            txtFname.ReadOnly = true;
            txtFname.Size = new Size(216, 36);
            txtFname.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 197);
            label3.Name = "label3";
            label3.Size = new Size(35, 30);
            label3.TabIndex = 5;
            label3.Text = "ชื่อ";
            // 
            // txtLname
            // 
            txtLname.BackColor = SystemColors.Window;
            txtLname.Location = new Point(245, 243);
            txtLname.Name = "txtLname";
            txtLname.ReadOnly = true;
            txtLname.Size = new Size(216, 36);
            txtLname.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 246);
            label4.Name = "label4";
            label4.Size = new Size(48, 30);
            label4.TabIndex = 7;
            label4.Text = "สกุล";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 635);
            Controls.Add(txtLname);
            Controls.Add(label4);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(btnClassify);
            Controls.Add(txtFullname);
            Controls.Add(label1);
            Font = new Font("Kanit", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "โปรแกรมแยกส่วนของชื่อ สกุล";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullname;
        private Button btnClassify;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtFname;
        private Label label3;
        private TextBox txtLname;
        private Label label4;
    }
}
