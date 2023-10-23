using Spire.Barcode;
using System.Drawing;
namespace BarcodesScanner;

public partial class Form1 : Form
{
    BarcodeSettings barcodeSettings = new BarcodeSettings();
    public Form1()
    {
        InitializeComponent();
    }

    private string CalculateEan13(string code)
    {
        int sum = 0;

        for (int i = code.Length; i >= 1; i--)
        {
            int digit = int.Parse(code[i-1].ToString());
            if (i % 2 == 0)
            { // odd  
                sum += digit * 3;
            }
            else
            { // even
                sum += digit * 1;
            }
        }
        int checkSum = sum % 10;
        if(checkSum != 0)
        {
            checkSum = 10 - checkSum;
        }
        return $"{code}{checkSum}";
    }


    private void ShowBarcode()

    {
        if(textBox1.Text == String.Empty || textBox1.Text.Length != 12)
        {
            MessageBox.Show("Wrong code format");
            return;
        }

        barcodeSettings.Type = BarCodeType.EAN13;
        barcodeSettings.Data = CalculateEan13(textBox1.Text);
        barcodeSettings.BarHeight = 70;
        barcodeSettings.ShowTextOnBottom = true;
        //barcodeSettings.UseChecksum = CheckSumMode.ForceEnable;
        barcodeSettings.TextAlignment = (int)StringAlignment.Center;

        BarCodeGenerator generator = new BarCodeGenerator(barcodeSettings);
        Image image = generator.GenerateImage();
        pictureBox1.Image = image;
        image.Save("EAN_13.png", System.Drawing.Imaging.ImageFormat.Png);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        ShowBarcode();
    }
}