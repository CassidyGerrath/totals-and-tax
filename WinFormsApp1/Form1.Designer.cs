namespace WinFormsApp1
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
            btnUber = new Button();
            btnSkip = new Button();
            btnDash = new Button();
            btnInsCart = new Button();
            lstReciept = new ListBox();
            lblTotal = new Label();
            lblTotalwTax = new Label();
            lblTip = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnUber
            // 
            btnUber.Location = new Point(49, 43);
            btnUber.Name = "btnUber";
            btnUber.Size = new Size(116, 23);
            btnUber.TabIndex = 0;
            btnUber.Text = "Call an Uber";
            btnUber.UseVisualStyleBackColor = true;
            btnUber.Click += btnUber_Click;
            // 
            // btnSkip
            // 
            btnSkip.Location = new Point(49, 72);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(116, 23);
            btnSkip.TabIndex = 1;
            btnSkip.Text = "Skip Some Dishes";
            btnSkip.UseVisualStyleBackColor = true;
            // 
            // btnDash
            // 
            btnDash.Location = new Point(49, 101);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(116, 23);
            btnDash.TabIndex = 2;
            btnDash.Text = "Door Dash";
            btnDash.UseVisualStyleBackColor = true;
            // 
            // btnInsCart
            // 
            btnInsCart.Location = new Point(49, 133);
            btnInsCart.Name = "btnInsCart";
            btnInsCart.Size = new Size(116, 23);
            btnInsCart.TabIndex = 3;
            btnInsCart.Text = "Get Groceries";
            btnInsCart.UseVisualStyleBackColor = true;
            // 
            // lstReciept
            // 
            lstReciept.FormattingEnabled = true;
            lstReciept.ItemHeight = 15;
            lstReciept.Location = new Point(184, 46);
            lstReciept.Name = "lstReciept";
            lstReciept.Size = new Size(314, 379);
            lstReciept.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F);
            lblTotal.Location = new Point(698, 46);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(71, 32);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "$0.00";
            // 
            // lblTotalwTax
            // 
            lblTotalwTax.AutoSize = true;
            lblTotalwTax.Font = new Font("Segoe UI", 18F);
            lblTotalwTax.Location = new Point(698, 78);
            lblTotalwTax.Name = "lblTotalwTax";
            lblTotalwTax.Size = new Size(71, 32);
            lblTotalwTax.TabIndex = 6;
            lblTotalwTax.Text = "$0.00";
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI", 18F);
            lblTip.Location = new Point(698, 110);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(71, 32);
            lblTip.TabIndex = 7;
            lblTip.Text = "$0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(510, 110);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 10;
            label1.Text = "Tip Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(510, 78);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 9;
            label2.Text = "Total with Tax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(510, 44);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 8;
            label3.Text = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblTip);
            Controls.Add(lblTotalwTax);
            Controls.Add(lblTotal);
            Controls.Add(lstReciept);
            Controls.Add(btnInsCart);
            Controls.Add(btnDash);
            Controls.Add(btnSkip);
            Controls.Add(btnUber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUber;
        private Button btnSkip;
        private Button btnDash;
        private Button btnInsCart;
        private ListBox lstReciept;
        private Label lblTotal;
        private Label lblTotalwTax;
        private Label lblTip;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
