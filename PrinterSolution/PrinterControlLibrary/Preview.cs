using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterControlLibrary
{
    public partial class Preview : Form
    {
        OnclickPrintListener listener = null;
        public Preview(OnclickPrintListener printListener,BarEntity entity)
        {

           
            InitializeComponent();

             
            this.listener = printListener;



            //公司名称==标题
            this.labelTitle.Text = entity.aTitle.ToString();
            this.textTitle.Text = entity.aTitle.ToString();
            this.labelTitle5024.Text = entity.aTitle.ToString();



            //资产名称
            this.labelName.Text = entity.aName.ToString();
            this.textName.Text = "资产名称：" + entity.aName.ToString();
            this.labelName5024.Text = "资产名称：" + entity.aName.ToString();



            //根据字数重新设置部门位置
            int tLen = System.Text.Encoding.Default.GetBytes(entity.aDept.ToString()).Length / 2;
            int x = this.labelDept.Location.X - (tLen * 8);
            this.labelDept.Location = new Point(x, this.labelDept.Location.Y);
            this.labelDept.Text = entity.aDept.ToString();
            


            this.labelDate.Text = entity.aDate.ToString();
            this.textDate.Text = "购置日期：" + entity.aDate.ToString();
            this.labelDate5024.Text = "购置日期：" + entity.aDate.ToString();




            tLen = System.Text.Encoding.Default.GetBytes(entity.aArea.ToString()).Length / 2;


            x = this.labelArea.Location.X - (tLen * 8);

            this.labelArea.Location = new Point(x, this.labelArea.Location.Y);

            this.labelArea.Text = entity.aArea.ToString();
            this.textArea.Text = "区域：" + entity.aArea.ToString();




            this.labelArea5024.Text = "区    域：" + entity.aArea.ToString();



            this.labelNo.Text = entity.aNo.ToString();

            this.textNo.Text = "资产编号："+entity.aNo.ToString();

            this.textBrand.Text = "品牌：" + entity.aBrand.ToString();

            this.textSpec.Text = "规格：" + entity.aSpec.ToString();

            this.labelSpec5024.Text = "规    格：" + entity.aSpec.ToString();

            this.cbxLabel.SelectedIndex = 0;
            // this.cbxLabel.SelectedIndex = 0;

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int selectLabel = this.cbxLabel.SelectedIndex;
            listener.confirmPrint(selectLabel);
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelArea_Click(object sender, EventArgs e)
        {

        }

        private void cbxLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxLabel.SelectedIndex;
            this.panel92.Visible = false;
            this.panel74.Visible = false;
            this.panel5024.Visible = false;

            

            if (index == 0) {
                this.panel92.Visible = true;
               
            } else if (index == 1) {
               
                
                this.panel74.Visible = true;
              
            } else if (index == 2)
            {
                this.panel92.Visible = true;
              
            } else if (index == 3)
            {
               
                this.panel5024.Visible = true;
          
            }

        }
    }

    public  interface OnclickPrintListener
    {

        void confirmPrint(int labelType);
    }
}
