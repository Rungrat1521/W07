using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_6214421017_w07_new
{
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            int income = Int32.Parse(incomeText.Text);
            int dispense = Int32.Parse(dispenseText.Text);
            int total = (income - dispense);
			double tax = 0;

			if (total <= 150000){
				tax = 0;
			}else if (total <= 300000){
				tax = (total - 150000) *0.05;
			}else if (total <= 500000){
				tax = (total - 300000) *0.1 + 75000;
			}else if (total <= 750000){
				tax = (total - 500000) *0.15 + 20000 + 7500;
			}else if (total <= 1000000){
				tax = (total - 750000) *0.2 + 37500 + 20000 + 7500;
			}else if (total <= 2000000){
				tax = (total - 1000000) *0.25 + 50000 + 20000 + 7500;
			}else if (total <= 5000000){
				tax = (total - 2000000) * 0.30 + 250000 + 50000 + 7500;
			}else 
			{
				tax = (total - 5000000) *0.35 + 900000 + 250000 + 50000 + 7500;
			}


			OuputName.Text = "ชื่อผู้เสียภาษี :" + name;
            OutputTotal.Text = "จำนวนภาษีที่ต้องจ่าย :" + tax + "บาท";
        }
    }
}b
