namespace loginapp
{
    partial class FormLOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLOGIN));
            this.butn_Pass = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.text_UsrN = new System.Windows.Forms.TextBox();
            this.text_Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGoSingUp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butn_Pass
            // 
            this.butn_Pass.BackColor = System.Drawing.Color.LightCoral;
            this.butn_Pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butn_Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butn_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.butn_Pass.Location = new System.Drawing.Point(182, 317);
            this.butn_Pass.Name = "butn_Pass";
            this.butn_Pass.Size = new System.Drawing.Size(184, 50);
            this.butn_Pass.TabIndex = 0;
            this.butn_Pass.Text = "Login";
            this.butn_Pass.UseVisualStyleBackColor = false;
            this.butn_Pass.Click += new System.EventHandler(this.Butn_Pass_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Username.Location = new System.Drawing.Point(177, 192);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(146, 29);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username :";
            // 
            // text_UsrN
            // 
            this.text_UsrN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_UsrN.Location = new System.Drawing.Point(354, 192);
            this.text_UsrN.Name = "text_UsrN";
            this.text_UsrN.Size = new System.Drawing.Size(209, 34);
            this.text_UsrN.TabIndex = 2;
            this.text_UsrN.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // text_Pass
            // 
            this.text_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Pass.Location = new System.Drawing.Point(354, 254);
            this.text_Pass.Name = "text_Pass";
            this.text_Pass.Size = new System.Drawing.Size(209, 34);
            this.text_Pass.TabIndex = 4;
            this.text_Pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(181, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(210, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Don\'t Have An Account?";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelGoSingUp
            // 
            this.labelGoSingUp.AutoSize = true;
            this.labelGoSingUp.BackColor = System.Drawing.Color.Transparent;
            this.labelGoSingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelGoSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoSingUp.ForeColor = System.Drawing.Color.Crimson;
            this.labelGoSingUp.Location = new System.Drawing.Point(472, 427);
            this.labelGoSingUp.Name = "labelGoSingUp";
            this.labelGoSingUp.Size = new System.Drawing.Size(91, 24);
            this.labelGoSingUp.TabIndex = 7;
            this.labelGoSingUp.Text = "SING UP";
            this.labelGoSingUp.Click += new System.EventHandler(this.Label3_Click);
            this.labelGoSingUp.MouseEnter += new System.EventHandler(this.labelGoSingUp_MouseEnter);
            this.labelGoSingUp.MouseLeave += new System.EventHandler(this.labelGoSingUp_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 100);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(201, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "ACCOUNT LOGIN";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(44)))));
            this.button1.Location = new System.Drawing.Point(379, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Admin Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(866, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelGoSingUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_UsrN);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.butn_Pass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLOGIN_FormClosing);
            this.Load += new System.EventHandler(this.FormLOGIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butn_Pass;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox text_UsrN;
        private System.Windows.Forms.TextBox text_Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGoSingUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}