using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrinterControlLibrary
{
    class AssetPrinter
    {



       private  PrintDocument printDocument = new PrintDocument();
        private int pwidth = 0;
        public  int labelType = 2;


        private BarEntity entity = null ;
        public List<String> getPrinterList() {

            List<String> printerList = new List<String>();

            String defaultPrinter = printDocument.PrinterSettings.PrinterName;

            printerList.Add(defaultPrinter); //默认打印机
            foreach (String printerName in PrinterSettings.InstalledPrinters)
            {
                if (!printerList.Contains(printerName))
                {
                       
                    if (printerName.Contains("Brother PT-P900"))

                    {
                        printerList.Add(printerName);
                    } else if(printerName.Contains("SATO CL4NX 305dpi"))
                        
                    {
                        printerList.Add(printerName);

                    }
                    
                }
            }
            return printerList;
        }


     


     
        public  bool setDefaultPrinter(String pinterName)
        {


            if (pinterName == null || pinterName == "")
            {
                return false;
            }
            return Externs.SetDefaultPrinter(pinterName);

        }



        class Externs
        {
            [DllImport("winspool.drv")]
            public static extern bool SetDefaultPrinter(String name);
        }

  

        public void config() {


        }


        public void print(BarEntity entity) {

            

            this.entity = entity;

            printDocument.DefaultPageSettings.Landscape = true;



            printDocument.PrinterSettings.Copies = 1;


            int width = PrinterUnitConvert.Convert(100, PrinterUnit.TenthsOfAMillimeter, PrinterUnit.ThousandthsOfAnInch);
            pwidth = width;
            int height = PrinterUnitConvert.Convert(36, PrinterUnit.TenthsOfAMillimeter, PrinterUnit.ThousandthsOfAnInch);

          




           // System.Windows.Forms.MessageBox.Show(height + "" + width);
            // printDocument.PrinterSettings.DefaultPageSettings.PaperSize.Width = width;


            // printDocument.PrinterSettings.DefaultPageSettings.PaperSize.Height = height;

            printDocument.PrintPage += new PrintPageEventHandler(printHandler);


            printDocument.Print();

        }

        private void printHandler(object sender, PrintPageEventArgs e)
        {
            e.HasMorePages = false; //关掉多页打印属性
                                    //  e.PageSettings.Landscape = true;

            if (labelType == 3) {

               
                try { print5024(e); }
                catch(Exception c){
                }
               
                return;
            }
            Font font = new Font("宋体", 11, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            
            String title = entity.aTitle;
           // System.Windows.Forms.MessageBox.Show(title);
            float tLen = System.Text.Encoding.Default.GetBytes(title).Length / 2;
            //System.Windows.Forms.MessageBox.Show(tLen+"");

            tLen = (394 - (17.5f * tLen)) / 2;
            PointF pf = new PointF(tLen, 1);
            e.Graphics.DrawString(entity.aTitle, font, drawBrush,pf);



           

             pf = new PointF(0, 90);
            Bitmap bitmap = ZxingCode.getCodeBitmap(entity.aNo);
            e.Graphics.DrawImage(bitmap, pf);


            font = new Font("宋体", 9, FontStyle.Regular);
           


            pf = new PointF(10, 22);
            e.Graphics.DrawString("资产名称："+entity.aName, font, drawBrush, pf);


            pf = new PointF(10, 46);
            e.Graphics.DrawString("资产编号："+entity.aNo, font, drawBrush, pf);

            pf = new PointF(10, 71);
            e.Graphics.DrawString("购置日期：" + entity.aDate, font, drawBrush, pf);



            pf = new PointF(220, 22);
            e.Graphics.DrawString("品牌：" + entity.aBrand, font, drawBrush, pf);



            pf = new PointF(220, 46);
            e.Graphics.DrawString("区域：" + entity.aArea, font, drawBrush, pf);


            pf = new PointF(220, 71);
            e.Graphics.DrawString("规格：" + entity.aSpec, font, drawBrush, pf);

          
      

        }



        private void print5024(PrintPageEventArgs e) {

            Font font = new Font("宋体", 7f, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);








            String title = entity.aTitle;
            // System.Windows.Forms.MessageBox.Show(title);
            float tLen = System.Text.Encoding.Default.GetBytes(title).Length / 2;
            //System.Windows.Forms.MessageBox.Show(tLen+"");

            tLen = (197- (9.85f * tLen)) / 2;
            PointF pf = new PointF(tLen, 5);
            e.Graphics.DrawString(entity.aTitle, font, drawBrush, pf);




        
            pf = new PointF(26, 60);
            Bitmap bitmap = ZxingCode.getCodeBitmap5024(entity.aNo);
            e.Graphics.DrawImage(bitmap, pf);


            font = new Font("宋体", 6.5f, FontStyle.Regular);



            pf = new PointF(0, 21);

            string strName = entity.aName;
            if (strName.Length>=7) {
                strName = strName.Substring(0, 7);
            }
            e.Graphics.DrawString("资产名称：" + strName, font, drawBrush, pf);

            pf = new PointF(0, 41);
            e.Graphics.DrawString("购置日期：" + entity.aDate, font, drawBrush, pf);





 



            pf = new PointF(110, 21);
            e.Graphics.DrawString("部门：" + entity.aDept, font, drawBrush, pf);


            pf = new PointF(110, 41);
            e.Graphics.DrawString("规格：" + entity.aSpec, font, drawBrush, pf);

            Pen pen = new Pen(Color.Black,1);

            Rectangle rect = new Rectangle(0,0,189,89);
         
            e.Graphics.DrawRectangle(pen,rect);
            e.Graphics.DrawLine(pen,0.0f,18.0f,188.0f,18.0f);


            e.Graphics.DrawRectangle(pen, rect);
            e.Graphics.DrawLine(pen, 0.0f, 38.0f, 188.0f, 38.0f);


            e.Graphics.DrawRectangle(pen, rect);
            e.Graphics.DrawLine(pen, 0.0f, 58.0f, 188.0f, 58.0f);


        }

        public void stop()

        {
            

        }




    }
}
