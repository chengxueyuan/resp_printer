using SATOPrinterAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterControlLibrary
{
    class SATO
    {

        Printer SATOPrinter = null;
        Driver SATODriver = null;
        public int labelType = 0;
        public SATO()
        {
            init();
        }
        string driverName = "";
        public void init()

        {
            SATOPrinter = new Printer();
            SATODriver = new Driver();
            
         //   List<Driver.Info> driverInfo = SATODriver.GetDriverList();


            // if (driverInfo == null || driverInfo.Count == 0)
            // {
            //     return;
            //}
            //driverName = driverInfo[0].DriverName;

            // print("1234000599999432341", "TIT", "AN", "AD", "201020334", "AA");



        }



        public bool setPrinter(string driverName) {
            try
            {
                List<Driver.Info> driverInfo = SATODriver.GetDriverList();

                foreach (Driver.Info info in driverInfo)
                {

                    string mDriverName = info.DriverName;
                    if (mDriverName.Contains(driverName))
                    {

                        this.driverName = mDriverName;
                        return true;
                    }

                }
            }
            catch (Exception e)
            {

                return false;
            }
          
            return false;
        }


   

        public List<Driver.Info> getPinterDriver(){
            List<Driver.Info> driverInfo = SATODriver.GetDriverList();
            return driverInfo;
        }

        public void print(BarEntity entity)
        {

            string aTitle = Str2Hex(entity.aTitle);
            string aName = Str2Hex(entity.aName);
            string aDept = Str2Hex(entity.aDept);
            string aDate = Str2Hex(entity.aDate);
            string aArea = Str2Hex(entity.aArea);
            string aBrand = Str2Hex(entity.aBrand);
            string aSpec = Str2Hex(entity.aSpec);

            if (labelType == 0)
            {
                sendData1(entity.aNo, aTitle, aName, aDept, aDate, aArea, aBrand, aSpec);
            }
            else if (labelType == 1)
            {
                sendData(entity.aNo, aTitle, aName, aDept, aDate, aArea, aBrand, aSpec);
            }
            else if (labelType == 2 || labelType == 3)
            {
                System.Windows.Forms.MessageBox.Show("当前打印机不能打印该类型标签模板！");

            }


        }


        public static string Str2Hex(string s)
        {
            string result = string.Empty;

            byte[] arrByte = System.Text.Encoding.GetEncoding("GB2312").GetBytes(s);
            for (int i = 0; i < arrByte.Length; i++)
            {
                result += System.Convert.ToString(arrByte[i], 16);        //Convert.ToString(byte, 16)把byte转化成十六进制string 
            }

            return result.ToUpper().ToString();
        }




        public void sendData(string aNo, string aTitle, string aName, string aDept, string aDate, string aArea, string aBrand, string aSpec)
        {

            // sendData1(aNo,aTitle, aName,  aDept, aDate,aArea);

            //    return;
            Console.WriteLine("send DATAkkkkkkkkkkkkkkkkkkkk");

            string tag = "";
            StringBuilder sb = new StringBuilder();
         

            //A1aaaabbbb 设置标签大小
            //aaaa 高度   bbbb宽度
            //Hbbbb bbbb水平坐标距离
            //Vbbbb bbbb垂直坐标距离
            //Laabb aabb横竖方向放大系数
            //K9abbbb   K9 汉子输入 a=B 二进制   a=H 十六进制
            //BGaabbb   条形码aa高，bbb宽


            /*
             * 
             * 标签：打印分辨率   305 dpi(12 dots / mm) 
             * 24 * 74 mm      288 * 888      
             * 字体 XM 24dots*24dots
            */

            
            sb.Append(tag + "A");
     
            sb.Append(tag + "A102880888");


            //名称
            sb.Append(tag + "L0201");
            sb.Append(tag + "V0070");
            sb.Append(tag + "H0010");
            sb.Append(tag + "K9H");
            sb.Append(aName);


          

            //日期
            sb.Append(tag + "L0201");
            sb.Append(tag + "V0240");
            sb.Append(tag + "H0010");
            sb.Append(tag + "K9H");
            sb.Append(aDate);

          

            //标题
            sb.Append(tag + "L0202");
            sb.Append(tag + "V0010");
            sb.Append(tag + getTitleX(aTitle));
            sb.Append(tag + "K9H");
            sb.Append(aTitle);



           


            //部门
            sb.Append(tag + "L0201");
            sb.Append(tag + "V0070");
            sb.Append(tag + getRightX(aDept));
            sb.Append(tag + "K9H");
            sb.Append(aDept);



            //条形码
            sb.Append(tag + "L0101");
            sb.Append(tag + "V0115");
            sb.Append(tag + "H0040");
            sb.Append(tag + "BG03060");
            sb.Append(aNo);

            //编号
            sb.Append(tag + "L0201");
            sb.Append(tag + "V0190");
            sb.Append(tag + "H0040"); 
            sb.Append(tag + "XM");
            sb.Append(aNo);

            //区域
            sb.Append(tag + "L0201");
            sb.Append(tag + "V0240");
            sb.Append(tag + getRightX(aArea));
            sb.Append(tag + "K9H");
            sb.Append(aArea);



            sb.Append(tag + "XURFID");
            sb.Append(tag + "IP0e:z,d:"+ aNo+", u:1234;");
          

            sb.Append(tag + "Q1");
            sb.Append(tag + "Z");
            byte[] data = Utils.StringToByteArray(sb.ToString());
            try {
               
                SATODriver.SendRawData(driverName, data);
            }
           catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("e:"+ex.Message);;
            }
            //  string  msg =    querySend(sb.ToString());
            //  System.Windows.Forms.MessageBox.Show(msg);

        }




        public void sendData1(string aNo, string aTitle, string aName, string aDept, string aDate, string aArea,string aBrand,string aSpec)
        {

            Console.WriteLine("send DATA 1");
            string tag = "";
            StringBuilder sb = new StringBuilder();


            //A1aaaabbbb 设置标签大小
            //aaaa 高度   bbbb宽度
            //Hbbbb bbbb水平坐标距离
            //Vbbbb bbbb垂直坐标距离
            //Laabb aabb横竖方向放大系数
            //K9abbbb   K9 汉子输入 a=B 二进制   a=H 十六进制
            //BGaabbb   条形码aa高，bbb宽


            /*
             * 
             * 标签：打印分辨率   305 dpi(12 dots / mm) 
             * 24 * 92 mm      288 * 1104      
             * 字体 XM 24dots*24dots
            */

            int offset = 8 * 12; //偏移8毫米 8*12 = 96;

            int width = 1104;

            int widthoffset = width + offset ;

            sb.Append(tag + "A");



            sb.Append(tag + "A10288"+ widthoffset);


     

            sb.Append(tag + "L0101");
            sb.Append(tag + "V0200");
            sb.Append(tag + "H0060");
          

           
            //日期
            sb.Append(tag + "L0201");
            sb.Append(tag + "V0240");
            sb.Append(tag + "H0010");
            sb.Append(tag + "K9H");
            sb.Append(aDate);



            //标题
            sb.Append(tag + "L0202");
            sb.Append(tag + "V0010");
            sb.Append(tag + getTitleX(aTitle));
            sb.Append(tag + "K9H");
            sb.Append(aTitle);






            //部门
            sb.Append(tag + "L0201");
            sb.Append(tag + "V0070");
            sb.Append(tag + getRightX(aDept));
            sb.Append(tag + "K9H");
            sb.Append(aDept);



            //条形码
            sb.Append(tag + "L0101");
            sb.Append(tag + "V0115");
            sb.Append(tag + "H0040");
            sb.Append(tag + "BG03060");
            sb.Append(aNo);

            //编号
            sb.Append(tag + "L0201");
            sb.Append(tag + "V0190");
            sb.Append(tag + "H0040");
            sb.Append(tag + "XM");
            sb.Append(aNo);

            //区域
            sb.Append(tag + "L0201");
            sb.Append(tag + "V0240");
            sb.Append(tag + getRightX(aArea));
            sb.Append(tag + "K9H");
            sb.Append(aArea);
           
   

          //  sb.Append(tag + "XURFID");
            //sb.Append(tag + "IP0e:z,d:" + aNo + ", u:1234;");

     
            sb.Append(tag + "Q1");
            sb.Append(tag + "Z");
            byte[] data = Utils.StringToByteArray(sb.ToString());
            try
            {
                SATODriver.SendRawData(driverName, data);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("e:" + ex.Message); ;
            }
            //  string  msg =    querySend(sb.ToString());
            //  System.Windows.Forms.MessageBox.Show(msg);


        }



        public string getTitleX(string aTitle) {
            int tLen = System.Text.Encoding.Default.GetBytes(aTitle).Length/4;

            if (tLen <2 ) {
                tLen = 2;
            }

           
            int iLeft = (888 -  (52 * tLen)) / 2;

            if (labelType == 1)
            {
                iLeft = (1104 - (52 * tLen)) / 2;
            }

            string sLeft = "H";
            if (iLeft <= 0)
            {
                sLeft = sLeft + "0010";

            } else  if (iLeft < 1000)
            {
                sLeft = sLeft + "0" + iLeft;
            }
            else
            {
                sLeft = sLeft + iLeft;
            }

            return sLeft;
        }



        public string getRightX(string aContent)
        {
            int tLen = System.Text.Encoding.Default.GetBytes(aContent).Length / 4;

            if (tLen <2 )
            {
                tLen = 2;
            }

            int iLeft = 840  - (52 * tLen);

            if (labelType == 1) {
                iLeft = 1062 - (26 * tLen);
            }

            string sLeft = "H";
            if (iLeft <= 100)
            {
                sLeft = sLeft + "0010";

            } else if (iLeft < 1000 )
            {
                sLeft = sLeft + "0" + iLeft;
            }
            else
            {
                sLeft = sLeft + iLeft;
            }

            return sLeft;
        }



        public string querySend(string strSend) {

            try
            {
                SATOPrinter.Interface = Printer.InterfaceType.USB;
                Printer.USBInfo usb = SATOPrinter.GetUSBList()[0];
                SATOPrinter.USBPortID = usb.PortID;
               
                System.Windows.Forms.MessageBox.Show(usb.Name);

                byte[] cmddata = Utils.StringToByteArray(strSend);

                System.Windows.Forms.MessageBox.Show("1");

                byte[] receiveData = SATOPrinter.Query(cmddata);
                System.Windows.Forms.MessageBox.Show("aa");
                if (receiveData != null)
                {
                    System.Windows.Forms.MessageBox.Show("bb");
                    return ConvDisplay(receiveData) ;
                }
            }
            catch (Exception ex)
            {
                return ex.Message + "er";
            }

            return null;
          
        }


        private string ConvDisplay(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length);
            foreach (char c in bytes.Select(b => (char)b))
            {
                switch (c)
                {
                    case '\u0000': sb.Append(""); break;
                    case '\u0001': sb.Append("[SOH]"); break;
                    case '\u0002': sb.Append("[STX]"); break;
                    case '\u0003': sb.Append("[ETX]"); break;
                    case '\u0004': sb.Append("[EOT]"); break;
                    case '\u0005': sb.Append("[ENQ]"); break;
                    case '\u0006': sb.Append("[ACK]"); break;
                    case '\u0007': sb.Append("[BEL]"); break;
                    case '\u0008': sb.Append("[BS]"); break;
                    case '\u0009': sb.Append("[HT]"); break;
                    case '\u000A': sb.Append("[LF]"); break;
                    case '\u000B': sb.Append("[VT]"); break;
                    case '\u000C': sb.Append("[FF]"); break;
                    case '\u000D': sb.Append("[CR]"); break;
                    case '\u000E': sb.Append("[SO]"); break;
                    case '\u000F': sb.Append("[SI]"); break;
                    case '\u0010': sb.Append("[DLE]"); break;
                    case '\u0011': sb.Append("[DC1]"); break;
                    case '\u0012': sb.Append("[DC2]"); break;
                    case '\u0013': sb.Append("[DC3]"); break;
                    case '\u0014': sb.Append("[DC4]"); break;
                    case '\u0015': sb.Append("[NAK]"); break;
                    case '\u0016': sb.Append("[SYN]"); break;
                    case '\u0017': sb.Append("[ETB]"); break;
                    case '\u0018': sb.Append("[CAN]"); break;
                    case '\u0019': sb.Append("[EM]"); break;
                    case '\u0020': sb.Append(" "); break;
                    case '\u001A': sb.Append("[SUB]"); break;
                    case '\u001B': sb.Append("[ESC]"); break;
                    case '\u001C': sb.Append("[FS]"); break;
                    case '\u001D': sb.Append("[GS]"); break;
                    case '\u001E': sb.Append("[RS]"); break;
                    case '\u001F': sb.Append("[US]"); break;
                    case '\u007F': sb.Append("[DEL]"); break;
                    default:
                        if (c > '\u007F')
                        {
                            sb.AppendFormat(@"\u{0:X4}", (ushort)c); // in ASCII, any octet in the range 0x80-0xFF doesn't have a character glyph associated with it
                        }
                        else
                        {
                            sb.Append(c);
                        }
                        break;
                }
            }
            return sb.ToString();
        }






    public void disconnect() {
            SATODriver.ClearSpoolerPrintJobs(driverName);
            SATOPrinter.Disconnect();
        }

    }
}
