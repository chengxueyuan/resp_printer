using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace PrinterControlLibrary
{
    class ZxingCode
    {


        public static Bitmap getCodeBitmap(string code) {

            EncodingOptions options = null;

            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 465,
                Height = 60
            };

            BarcodeWriter barcodeWriter = new BarcodeWriter();

            barcodeWriter.Format = BarcodeFormat.CODE_128 ;
            
            barcodeWriter.Options= options;
            Bitmap bitmap = barcodeWriter.Write(code);
            
            return bitmap;
        }


        public static Bitmap getCodeBitmap5024(string code)
        {


        

                EncodingOptions options = null;

                options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    PureBarcode = true,
                    Margin = 0,
                    Width =150,
                    Height = 30
                };



                BarcodeWriter barcodeWriter = new BarcodeWriter();

                barcodeWriter.Format = BarcodeFormat.CODE_128;

                barcodeWriter.Options = options;
                Bitmap bitmap = barcodeWriter.Write(code);








            return bitmap;
        }



        private static  Bitmap ZoomImage(Bitmap sourImage, int destWidth)
        {
            try
            {
                
                
                Bitmap destBitmap = new Bitmap(destWidth, 50);
                Graphics g = Graphics.FromImage(destBitmap);
                g.Clear(Color.Transparent);
                //设置画布的描绘质量           
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.AssumeLinear;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                g.DrawImage(sourImage, new Rectangle(0, 0, destWidth, 50), 0, 0, sourImage.Width, sourImage.Height, GraphicsUnit.Point);
                g.Dispose();
                //设置压缩质量       
                System.Drawing.Imaging.EncoderParameters encoderParams = new System.Drawing.Imaging.EncoderParameters();
                long[] quality = new long[1];
                quality[0] = 100;
                System.Drawing.Imaging.EncoderParameter encoderParam = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                encoderParams.Param[0] = encoderParam;
                sourImage.Dispose();
                return destBitmap;
            }
            catch
            {
                return sourImage;
            }
        }



        public static Bitmap getPTCodeBitmap(string code)
        {
            EncodingOptions options = null;

            options = new QrCodeEncodingOptions
            {
                Width = 300,
                Height = 30
            };

            BarcodeWriter barcodeWriter = new BarcodeWriter();

            barcodeWriter.Format = BarcodeFormat.CODE_128;
            
            barcodeWriter.Options = options;
            Bitmap bitmap = barcodeWriter.Write(code);

            return bitmap;
        }


    }
}
