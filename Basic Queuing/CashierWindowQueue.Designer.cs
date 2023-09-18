namespace Basic_Queuing
{
    partial class CashierWindowQueue
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
            btnNext = new Button();
            listCashierQueue = new ListBox();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.SandyBrown;
            btnNext.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(132, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(114, 34);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.BackColor = Color.AntiqueWhite;
            listCashierQueue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listCashierQueue.FormattingEnabled = true;
            listCashierQueue.ItemHeight = 25;
            listCashierQueue.Location = new Point(15, 52);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(231, 254);
            listCashierQueue.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SandyBrown;
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(12, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 34);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CashierWindowQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(258, 338);
            Controls.Add(btnRefresh);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Name = "CashierWindowQueue";
            Text = "CashierWindowQueue";
            Load += CashierWindowQueue_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnNext;
        private ListBox listCashierQueue;
        private Button btnRefresh;
    }
}