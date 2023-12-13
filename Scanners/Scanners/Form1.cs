using WIA;
using System.IO;
using System.Windows.Forms;

namespace Scanners;

public partial class Form1 : Form
{
    DeviceManager deviceManager = new DeviceManager();
    List<(DeviceInfo, string)> devices = new();


    public Form1()
    {
        InitializeComponent();
        comboBox1.DataSource = devices.Select(e => e.Item2).ToList();
    }



    private void Form1_Load(object sender, EventArgs e)
    {
        for (int i = 0; i < deviceManager.DeviceInfos.Count; i++)
        {
            var currentDev = deviceManager.DeviceInfos[i];

            if (currentDev.Type == WiaDeviceType.ScannerDeviceType)
            {
                string name = deviceManager.DeviceInfos[i].Properties["Name"].get_Value();
                devices.Add((currentDev, name));
            }
        }
    }
}
