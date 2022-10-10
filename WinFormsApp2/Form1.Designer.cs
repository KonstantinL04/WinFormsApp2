namespace WinFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAreaOfCircle = new System.Windows.Forms.TextBox();
            this.txtAreaOfSquare = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус круга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Радиус квадрата";
            // 
            // txtAreaOfCircle
            // 
            this.txtAreaOfCircle.Location = new System.Drawing.Point(12, 12);
            this.txtAreaOfCircle.Name = "txtAreaOfCircle";
            this.txtAreaOfCircle.Size = new System.Drawing.Size(125, 27);
            this.txtAreaOfCircle.TabIndex = 2;
            // 
            // txtAreaOfSquare
            // 
            this.txtAreaOfSquare.Location = new System.Drawing.Point(12, 45);
            this.txtAreaOfSquare.Name = "txtAreaOfSquare";
            this.txtAreaOfSquare.Size = new System.Drawing.Size(125, 27);
            this.txtAreaOfSquare.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAreaOfSquare);
            this.Controls.Add(this.txtAreaOfCircle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAreaOfCircle;
        private TextBox txtAreaOfSquare;
        private Button button1;
    }
}