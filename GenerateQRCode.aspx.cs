using IronBarCode;
using System;
using System.Drawing;
using System.IO;
using Controller;
using System.Data;

namespace GenerateQRCode
{
    public partial class GenerateQRCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageGeneratedBarcode.Visible = false;
        }






        protected void BtnGenerateQRCode_Click(object sender, EventArgs e)
        {

            readdata newcounterinput = new readdata();

            DataTable NEWSDATATABLE = newcounterinput.GetNEWSDATA(SearchValue.Text);


            foreach (DataRow dr in NEWSDATATABLE.Rows)
            {

                string MEDIA_FILENAME = dr.ItemArray[0].ToString();
                //string NEWS_TITLE = ;
                string MEDIA_DATE =  dr.ItemArray[1].ToString().Substring(6,4)+"/"+ dr.ItemArray[1].ToString().Substring(0, 2);
                string Media_Title = dr.ItemArray[2].ToString();
                string[] topic = new string[10];
                topic = Media_Title.Split('<');
                string[] maintopic= new string[3];
                maintopic = topic[5].Split('>');
                string URLSTR = "https://www.tpww.ir/abfa_content/media/image/" + MEDIA_DATE + "/" + MEDIA_FILENAME;
                string generatebarcode = URLSTR;

                // GeneratedBarcode barcode = QRCodeWriter.CreateQrCode(generatebarcode, 300);

                //E:\QRCode\GenerateQRCode - master\GenerateQRCode\App_Data\Abfa.jpg
                string filePath2 = Server.MapPath("~/App_Data/Abfa.png");
                var barcode = QRCodeWriter.CreateQrCodeWithLogo(generatebarcode, filePath2, 500);
                //  barcode.SaveAsPng("Qr-Code-with-logo.png");


                // Styling a QR code and adding annotation text

                //barcode.AddBarcodeValueTextAboveBarcode();
                barcode.AddAnnotationTextBelowBarcode(maintopic[1]);
                barcode.SetMargins(10);
                barcode.ChangeBarCodeColor(Color.Black);





                var folder = Server.MapPath("/App_Data/GeneratedQRcode");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                string filePath = Server.MapPath("GeneratedQRcode/" + MEDIA_FILENAME + ".png");
                ImageGeneratedBarcode.ImageUrl = "~/GeneratedQRcode/" + Path.GetFileName(filePath);
               // ImageGeneratedBarcode.Visible = true;
                // barcode.SaveAsPng("barcode3.png");
                barcode.SaveAsPng(filePath);


            }


        }
    }
}