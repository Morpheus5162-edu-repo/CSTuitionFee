
namespace CSTutitionFee
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
            this.GbMode = new System.Windows.Forms.GroupBox();
            this.Rdthreepayments = new System.Windows.Forms.RadioButton();
            this.Rdtwopayments = new System.Windows.Forms.RadioButton();
            this.Rdcash = new System.Windows.Forms.RadioButton();
            this.Lbltuitionfee = new System.Windows.Forms.Label();
            this.Txttuitionfee = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.Txttotal = new System.Windows.Forms.TextBox();
            this.Lbltotal = new System.Windows.Forms.Label();
            this.GbMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbMode
            // 
            this.GbMode.Controls.Add(this.Rdthreepayments);
            this.GbMode.Controls.Add(this.Rdtwopayments);
            this.GbMode.Controls.Add(this.Rdcash);
            this.GbMode.Location = new System.Drawing.Point(31, 42);
            this.GbMode.Name = "GbMode";
            this.GbMode.Size = new System.Drawing.Size(200, 100);
            this.GbMode.TabIndex = 0;
            this.GbMode.TabStop = false;
            this.GbMode.Text = "Mode of Payment";
            // 
            // Rdthreepayments
            // 
            this.Rdthreepayments.AutoSize = true;
            this.Rdthreepayments.Location = new System.Drawing.Point(23, 66);
            this.Rdthreepayments.Name = "Rdthreepayments";
            this.Rdthreepayments.Size = new System.Drawing.Size(165, 17);
            this.Rdthreepayments.TabIndex = 2;
            this.Rdthreepayments.TabStop = true;
            this.Rdthreepayments.Text = "Three Payments(10% interest)";
            this.Rdthreepayments.UseVisualStyleBackColor = true;
            // 
            // Rdtwopayments
            // 
            this.Rdtwopayments.AutoSize = true;
            this.Rdtwopayments.Location = new System.Drawing.Point(23, 43);
            this.Rdtwopayments.Name = "Rdtwopayments";
            this.Rdtwopayments.Size = new System.Drawing.Size(152, 17);
            this.Rdtwopayments.TabIndex = 1;
            this.Rdtwopayments.TabStop = true;
            this.Rdtwopayments.Text = "Two Payments(5% interest)";
            this.Rdtwopayments.UseVisualStyleBackColor = true;
            // 
            // Rdcash
            // 
            this.Rdcash.AutoSize = true;
            this.Rdcash.Location = new System.Drawing.Point(23, 20);
            this.Rdcash.Name = "Rdcash";
            this.Rdcash.Size = new System.Drawing.Size(121, 17);
            this.Rdcash.TabIndex = 0;
            this.Rdcash.TabStop = true;
            this.Rdcash.Text = "Cash (10% discount)";
            this.Rdcash.UseVisualStyleBackColor = true;
            // 
            // Lbltuitionfee
            // 
            this.Lbltuitionfee.AutoSize = true;
            this.Lbltuitionfee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbltuitionfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltuitionfee.Location = new System.Drawing.Point(250, 19);
            this.Lbltuitionfee.Name = "Lbltuitionfee";
            this.Lbltuitionfee.Size = new System.Drawing.Size(192, 20);
            this.Lbltuitionfee.TabIndex = 1;
            this.Lbltuitionfee.Text = "Enter your Tuition Fee:";
            // 
            // Txttuitionfee
            // 
            this.Txttuitionfee.Location = new System.Drawing.Point(254, 43);
            this.Txttuitionfee.Name = "Txttuitionfee";
            this.Txttuitionfee.Size = new System.Drawing.Size(188, 20);
            this.Txttuitionfee.TabIndex = 2;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.LightGray;
            this.btnCompute.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Location = new System.Drawing.Point(305, 71);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(83, 44);
            this.btnCompute.TabIndex = 3;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // Txttotal
            // 
            this.Txttotal.Location = new System.Drawing.Point(254, 152);
            this.Txttotal.Name = "Txttotal";
            this.Txttotal.Size = new System.Drawing.Size(188, 20);
            this.Txttotal.TabIndex = 5;
            // 
            // Lbltotal
            // 
            this.Lbltotal.AutoSize = true;
            this.Lbltotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltotal.Location = new System.Drawing.Point(250, 129);
            this.Lbltotal.Name = "Lbltotal";
            this.Lbltotal.Size = new System.Drawing.Size(183, 20);
            this.Lbltotal.TabIndex = 4;
            this.Lbltotal.Text = "Your Total tuition fee:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(483, 196);
            this.Controls.Add(this.Txttotal);
            this.Controls.Add(this.Lbltotal);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.Txttuitionfee);
            this.Controls.Add(this.Lbltuitionfee);
            this.Controls.Add(this.GbMode);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuition Fee";
            this.GbMode.ResumeLayout(false);
            this.GbMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbMode;
        private System.Windows.Forms.RadioButton Rdtwopayments;
        private System.Windows.Forms.RadioButton Rdcash;
        private System.Windows.Forms.RadioButton Rdthreepayments;
        private System.Windows.Forms.Label Lbltuitionfee;
        private System.Windows.Forms.TextBox Txttuitionfee;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox Txttotal;
        private System.Windows.Forms.Label Lbltotal;
    }
}

