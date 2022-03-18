using System;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double unit_consumed, unit_price, bill_amount, tax, tot = 0;
            unit_consumed = Convert.ToDouble(unit_cons.Text);

            if (cmb_type.SelectedIndex == 0)
            {
                if (unit_consumed < 50)
                {
                    bill_amount = unit_consumed * 10;
                    tax = bill_amount * 2 / 100;
                    tot = bill_amount + tax;
                    tot_bill.Text = tot.ToString();
                }
                else if (unit_consumed >= 50 && unit_consumed <= 100)
                {
                    bill_amount = unit_consumed * 20;
                    tax = bill_amount * 3 / 100;
                    tot = bill_amount + tax;
                    tot_bill.Text = tot.ToString();
                }
                else if (unit_consumed > 100)
                {
                    bill_amount = unit_consumed * 30;
                    tax = bill_amount * 5 / 100;
                    tot = bill_amount + tax;
                    tot_bill.Text = tot.ToString();
                }
            }
            else if (cmb_type.SelectedIndex == 1)
            {
                if (unit_consumed < 50)
                {
                    bill_amount = unit_consumed * 20;
                    tax = bill_amount * 5 / 100;
                    tot = bill_amount + tax;
                    tot_bill.Text = tot.ToString();
                }
                else if (unit_consumed >= 50 && unit_consumed < 100)
                {
                    bill_amount = unit_consumed * 50;
                    tax = bill_amount * 8 / 100;
                    tot = bill_amount + tax;
                    tot_bill.Text= tot.ToString();
                }
                else if (unit_consumed >=100)
                {
                    bill_amount = unit_consumed * 100;
                    tax = bill_amount * 10 / 100;
                    tot = bill_amount + tax;
                    tot_bill.Text = tot.ToString();
                }
            }

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {

        }
    }
}
