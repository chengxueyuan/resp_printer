using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web.Script.Serialization;

namespace PrinterControlLibrary
{

    

    [Guid("406B0055-8B8E-4828-886A-6E86ABC3A6B9"), ProgId("PrinterControlLibrary.UserControl1"), ComVisible(true)]
    public partial class UserControl1: UserControl,IObjectSafety, OnclickPrintListener
    {



        #region IObjectSafety 成员 格式固定  

        private const string _IID_IDispatch = "{00020400-0000-0000-C000-000000000046}";
        private const string _IID_IDispatchEx = "{a6ef9860-c720-11d0-9337-00a0c90dcaa9}";
        private const string _IID_IPersistStorage = "{0000010A-0000-0000-C000-000000000046}";
        private const string _IID_IPersistStream = "{00000109-0000-0000-C000-000000000046}";
        private const string _IID_IPersistPropertyBag = "{37D84F60-42CB-11CE-8135-00AA004BB851}";

        private const int INTERFACESAFE_FOR_UNTRUSTED_CALLER = 0x00000001;
        private const int INTERFACESAFE_FOR_UNTRUSTED_DATA = 0x00000002;
        private const int S_OK = 0;
        private const int E_FAIL = unchecked((int)0x80004005);
        private const int E_NOINTERFACE = unchecked((int)0x80004002);

        private bool _fSafeForScripting = true;
        private bool _fSafeForInitializing = true;
        public string wcz = "hhe";
        public int GetInterfaceSafetyOptions(ref Guid riid, ref int pdwSupportedOptions, ref int pdwEnabledOptions)
        {
            int Rslt = E_FAIL;

            string strGUID = riid.ToString("B");
            pdwSupportedOptions = INTERFACESAFE_FOR_UNTRUSTED_CALLER | INTERFACESAFE_FOR_UNTRUSTED_DATA;
            switch (strGUID)
            {
                case _IID_IDispatch:
                case _IID_IDispatchEx:
                    Rslt = S_OK;
                    pdwEnabledOptions = 0;
                    if (_fSafeForScripting == true)
                        pdwEnabledOptions = INTERFACESAFE_FOR_UNTRUSTED_CALLER;
                    break;
                case _IID_IPersistStorage:
                case _IID_IPersistStream:
                case _IID_IPersistPropertyBag:
                    Rslt = S_OK;
                    pdwEnabledOptions = 0;
                    if (_fSafeForInitializing == true)
                        pdwEnabledOptions = INTERFACESAFE_FOR_UNTRUSTED_DATA;
                    break;
                default:
                    Rslt = E_NOINTERFACE;
                    break;
            }

            return Rslt;
        }

        public int SetInterfaceSafetyOptions(ref Guid riid, int dwOptionSetMask, int dwEnabledOptions)
        {
            int Rslt = E_FAIL;
            string strGUID = riid.ToString("B");
            switch (strGUID)
            {
                case _IID_IDispatch:
                case _IID_IDispatchEx:
                    if (((dwEnabledOptions & dwOptionSetMask) == INTERFACESAFE_FOR_UNTRUSTED_CALLER) && (_fSafeForScripting == true))
                        Rslt = S_OK;
                    break;
                case _IID_IPersistStorage:
                case _IID_IPersistStream:
                case _IID_IPersistPropertyBag:
                    if (((dwEnabledOptions & dwOptionSetMask) == INTERFACESAFE_FOR_UNTRUSTED_DATA) && (_fSafeForInitializing == true))
                        Rslt = S_OK;
                    break;
                default:
                    Rslt = E_NOINTERFACE;
                    break;
            }

            return Rslt;
        }

        #endregion












        // private ComBartender barTender = null; 
        private static bool flag = true;
        private SATO sato = null;
        private AssetPrinter ap = null;
        private Thread printThread = null;

        private bool satoFlag = false;

        private List<BarEntity> tempBarList = null;

        public UserControl1()
        {


            InitializeComponent();

           

            if (sato == null) {

                sato = new SATO();
            }

            if (ap == null)
            {
                 ap = new AssetPrinter();
            }
            flag = true;

        }


        /// <summary>
        ///  1，js页面获取打印机列表
        /// </summary>
        public string getPrinters()
        {

            


            if (ap == null) return "";
            
            List<string> list = ap.getPrinterList();
            StringBuilder buf = new StringBuilder();

            string splite = ",&,";
            foreach (String printerName in list)
            {

                buf.Append(printerName);
                buf.Append(splite);

            }

            string ps = buf.ToString();
            ps = ps.Substring(0, (ps.Length - 3));

            return ps;

        }


        //1.1 设置佐藤的打印机
        public void setPrinter(string printerName)

        {


            if (sato == null) return;

            satoFlag = sato.setPrinter(printerName);

            if (satoFlag == false)
            {

                if (ap == null) return;
                ap.setDefaultPrinter(printerName);
            }

        }



        /// <summary>
        ///  2，js页面打印条码集合，json字符串格式
        /// </summary>
        public void printBarList(string barsString)
        {

            tempBarList = null;

            if (printThread != null)
            {
                printThread.Abort();
                printThread = null;
            }

            flag = true;
            JavaScriptSerializer js = new JavaScriptSerializer();

            List<BarEntity> barList = js.Deserialize<List<BarEntity>>((string)barsString);

            printThread = new Thread(new ParameterizedThreadStart(startPrint));

            printThread.Start(barList);

        }





        /// <summary>
        ///  3，开启打印线程，开始打印
        /// </summary>
        private void startPrint(Object obj)

        {
            
            List<BarEntity> barList = (List<BarEntity>)obj;
            foreach (BarEntity bar in barList)
            {
                if (flag == true && satoFlag == true)
                {
                    if (sato == null) continue;
                     // MessageBox.Show(bar.aTitle + " " + bar.aName + " " + bar.aNo + " " + bar.aDept + " " + bar.aDate + " " + bar.aArea);
                    sato.print(bar);

                }
                else
                {
                 
                    if (ap == null) continue;
                    ap.print(bar);

                }
            }


        }

        /// <summary>
        ///  4，停止打印
        /// </summary>
        public void stop()
        {
            flag = false;

            if (sato == null) {
                satoFlag = false;
                return;
            } 

            if (satoFlag) sato.disconnect();
            
        }






        public string getAPrinterVersion()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }


        /**
         * 
         * 打印预览
         * 
         */
        public void preview(string barsString) {


       
            JavaScriptSerializer js = new JavaScriptSerializer();

            this.tempBarList = js.Deserialize<List<BarEntity>>((string)barsString);


           
            if (this.tempBarList == null || this.tempBarList.Count == 0) {

                return;
            }
            Preview preview = new Preview(this, tempBarList[0]);
            preview.Show();

        }

        /**
         * 
         * 预览后确定打印
         * 
         */

        public void confirmPrint(int labelType)
        {

            sato.labelType = labelType;
            ap.labelType = labelType;


            if (printThread != null)
            {
                printThread.Abort();
                printThread = null;
            }

            flag = true;


            printThread = new Thread(new ParameterizedThreadStart(startPrint));

            printThread.Start(this.tempBarList);


        }
       

        private void button1_Click(object sender, EventArgs e)
        {
             setPrinter("SATO CL4NX 305dpi (副本 1)");

            //setPrinter("Brother PT-P900"); 

            BarEntity bar = new BarEntity();
            bar.aTitle = Str2Hex("国国国国国国");
            bar.aName = Str2Hex("电脑键盘");
            bar.aDept = Str2Hex("人事部门");
            bar.aDate = Str2Hex("2112-21-23");
            bar.aArea = Str2Hex("9691");

                bar.aNo = "00020170612102124309";
       
            // sato.print(bar);
            string data = "[{'aTitle':'宁波法师学院','aNo':'00020170703113638471','aName':'电脑','aDept':'会议室','aDate':'2017-12-26','aArea':'很隐蔽的地方','aBrand':'品牌联想','aSpec':'T1234567890'}]";

            preview(data);

        }

        public static string Str2Hex(string s)
        {
            return s;
        }

      
    }
}
