namespace test
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
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.ctm_type = new System.Windows.Forms.Label();
            this.unit_con = new System.Windows.Forms.Label();
            this.unit_cons = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tot_bill = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_type
            // 
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Domestic Customer",
            "Business Customer"});
            this.cmb_type.Location = new System.Drawing.Point(535, 82);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(222, 37);
            this.cmb_type.TabIndex = 0;
            // 
            // ctm_type
            // 
            this.ctm_type.AutoSize = true;
            this.ctm_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctm_type.Location = new System.Drawing.Point(222, 82);
            this.ctm_type.Name = "ctm_type";
            this.ctm_type.Size = new System.Drawing.Size(223, 36);
            this.ctm_type.TabIndex = 1;
            this.ctm_type.Text = "Customer Type";
            // 
            // unit_con
            // 
            this.unit_con.AutoSize = true;
            this.unit_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_con.Location = new System.Drawing.Point(224, 154);
            this.unit_con.Name = "unit_con";
            this.unit_con.Size = new System.Drawing.Size(223, 36);
            this.unit_con.TabIndex = 2;
            this.unit_con.Text = "Unit Consumed";
            // 
            // unit_cons
            // 
            this.unit_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_cons.Location = new System.Drawing.Point(535, 154);
            this.unit_cons.Name = "unit_cons";
            this.unit_cons.Size = new System.Drawing.Size(222, 34);
            this.unit_cons.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Bill Amount";
            // 
            // tot_bill
            // 
            this.tot_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_bill.Location = new System.Drawing.Point(535, 222);
            this.tot_bill.Name = "tot_bill";
            this.tot_bill.Size = new System.Drawing.Size(222, 34);
            this.tot_bill.TabIndex = 5;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(212, 361);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(145, 58);
            this.btn_cal.TabIndex = 6;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(490, 361);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(156, 58);
            this.btn_clr.TabIndex = 7;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 665);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.tot_bill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unit_cons);
            this.Controls.Add(this.unit_con);
            this.Controls.Add(this.ctm_type);
            this.Controls.Add(this.cmb_type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label ctm_type;
        private System.Windows.Forms.Label unit_con;
        private System.Windows.Forms.TextBox unit_cons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tot_bill;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_clr;
    }
}

