namespace Basic_Queuing
{
    partial class QueuingForm
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
            label3 = new Label();
            lblQueue = new Label();
            label1 = new Label();
            btnCashier = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(138, 17);
            label3.TabIndex = 7;
            label3.Text = "Click to get a number*";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueue.Location = new Point(206, 79);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(116, 45);
            lblQueue.TabIndex = 6;
            lblQueue.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 31);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 5;
            label1.Text = "Position in Queue";
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.SandyBrown;
            btnCashier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCashier.Location = new Point(12, 14);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(135, 127);
            btnCashier.TabIndex = 4;
            btnCashier.Text = "CASHIER";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(410, 183);
            Controls.Add(label3);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "QueuingForm";
            Load += QueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        public Label lblQueue;
        private Label label1;
        private Button btnCashier;
    }
}