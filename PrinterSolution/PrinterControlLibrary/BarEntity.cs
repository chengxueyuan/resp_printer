using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterControlLibrary
{

    

    public class BarEntity
    {
        public string aTitle = "";
        public string aName = "";
        public string aDept = "";
        public string aDate = "";
        public string aArea = "";
        public string aNo = "";

        public string aBrand = "";

        public string aSpec = "";

        public BarEntity(string aTitle, string aName, string aDept, string aDate, string aArea, string aNo,string aBrand,string aSpec)
        {
            this.aTitle = aTitle;
            this.aName = aName;
            this.aDept = aDept;
            this.aDate = aDate;
            this.aArea = aArea;
            this.aNo = aNo;
            this.aBrand = aBrand;
            this.aSpec = aSpec;

        }

        public BarEntity()
        {
         

        }

    }
}
