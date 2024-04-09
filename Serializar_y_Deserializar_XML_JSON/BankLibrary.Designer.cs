namespace Serializar_y_Deserializar_XML_JSON
{
    partial class BankLibrary
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            accountTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            balanceTextBox = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 37);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 109);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Primer Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 205);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 299);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Saldo";
            // 
            // accountTextBox
            // 
            accountTextBox.Location = new Point(237, 30);
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Size = new Size(183, 27);
            accountTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(237, 198);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(183, 27);
            lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(237, 102);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(183, 27);
            firstNameTextBox.TabIndex = 6;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Location = new Point(237, 292);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(183, 27);
            balanceTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(24, 369);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "SERIALIZAR";
            // 
            // button2
            // 
            button2.Location = new Point(124, 49);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "JSON";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 49);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "XML";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(386, 369);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "DESERIALIZAR";
            // 
            // button4
            // 
            button4.Location = new Point(134, 58);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "JSON";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(18, 58);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "XML";
            button3.UseVisualStyleBackColor = true;
            // 
            // BankLibrary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 523);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(balanceTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(accountTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BankLibrary";
            Text = "BankLibrary";
            Load += BankLibrary_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox accountTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox balanceTextBox;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
    }
}