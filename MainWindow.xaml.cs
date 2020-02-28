using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Computer
        private void BtnRun_Click(object sender, RoutedEventArgs e)
        {
            String MotherBoard = "MSI B450M Gaming Plus Micro Atx AM4";
            String CPU = "AMD Ryzen 5 2600 3.4Gz 6- core procceser";
            String CPUColler = "Cooler Master Hyper 212 RGB Black Edition 57.3 CFM";
            String GPU = "Cooler Master Hyper 212 RGB Black Edition 57.3 CFM";
            String PowerSupply = "EVGA BR 450 W 80+ Bronze Certified";
            String Ram = "G. Skill Aegis 16Gb(2* 8Gb) DDR4 3200 Memory";
            String Storage = "Samsung 970 evo Solid state Drive";
            String OpticalDrive = "Asus DRW -24B1ST/BLK/B/DVD/CD Writer";
            String TotalCost = "Total Cost of parts";
            String TaxInculded = " Tax Inculded";
            String Subtotal = " Subtotal Cost";

            

            //Output
            lblOutput.Content = MotherBoard + "- MotherBoard- $89.97" + Environment.NewLine;
            lblOutput.Content += CPU + "- CPU- $119.99" + Environment.NewLine;
            lblOutput.Content += CPUColler + "- CPUColler- $44.99" + Environment.NewLine;
            lblOutput.Content += GPU + "- GPU- $113.98" + Environment.NewLine;
            lblOutput.Content += PowerSupply + "- powerSupply- $39.99" + Environment.NewLine;
            lblOutput.Content += Ram + "- Ram- $69.99" + Environment.NewLine;
            lblOutput.Content += Storage + "- Storage- $168.99" + Environment.NewLine;
            lblOutput.Content += OpticalDrive + "- Optical Drive- $19.85" + Environment.NewLine;
            lblOutput.Content += TotalCost + ": $667.75" + Environment.NewLine;
            lblOutput.Content += TaxInculded + ": $86.81" + Environment.NewLine;
            lblOutput.Content += Subtotal + ": $754.56" + Environment.NewLine;

        }
        //Phone Parts
        private void BrnRun2_Click(object sender, RoutedEventArgs e)
        {
            String Battery = "Google Pixel 1st 5.0-Inch New Replacement Battery 2770mAh 3.85V";
            String PowerCable = "USB Type C Cable, Anker [2-Pack 6Ft] Premium Nylon USB-C to USB-A Fast Charging Type C Cable";
            String ChargerBox = "Quick Charge 3.0 Wall Charger";
            String TotalCost = "Total Cost of Parts";
            String TaxIncluded = "Tax Inculded";
            String Subtotal = "Subtotal Cost";


            //Output pt2
            lblOutput.Content = Battery + "- Battery- $27.99" + Environment.NewLine;
            lblOutput.Content += PowerCable + "- Power Cable- $15.29" + Environment.NewLine;
            lblOutput.Content += ChargerBox + "- Charger Box- 14.99" + Environment.NewLine;
            lblOutput.Content += TotalCost + ": $58.27" + Environment.NewLine;
            lblOutput.Content += TaxIncluded + ": $7.58" + Environment.NewLine;
            lblOutput.Content += Subtotal + ": $65.85" + Environment.NewLine;


        }

        private void BtnRun3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.com/MSI-Performance-Micro-ATX-Motherboard-B450M/dp/B07F7WQDZJ/ref=sr_1_1?keywords=MSI+B450M+Gaming+Plus+Micro+Atx+AM4&qid=1581444170&sr=8-1");
        }

        private void BtnRun4_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.com/AMD-Processor-Wraith-Stealth-Cooler/dp/B07B41WS48/ref=sr_1_fkmr1_1?keywords=amd+ryzen+5+2600+3.4gz+6-+core+processer&qid=1581444110&sr=8-1-fkmr1");
        }

        private void BtnRun5_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.com/Cooler-Master-RR-212S-20PC-R1-Direct-Contact/dp/B07H22TC1N/ref=sr_1_1?keywords=Cooler+Master+Hyper+212+RGB+Black+Edition+57.3+CFM&qid=1581444206&sr=8-1");
        }

        private void BtnRun6_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.newegg.com/xfx-radeon-rx-570-rx-570p427d6/p/N82E16814150795?Item=N82E16814150795&nm_mc=AFC-RAN-COM&cm_mmc=AFC-RAN-COM&utm_medium=affiliates&utm_source=afc-PCPartPicker&AFFID=2558510&AFFNAME=PCPartPicker&ACRID=1&ASID=https%3a%2f%2fpcpartpicker.com%2fproduct%2ftF648d%2fxfx-radeon-rx-570-4gb-rs-xxx-video-card-rx-570p427d6&ranMID=44583&ranEAID=2558510&ranSiteID=8BacdVP0GFs-sucmYsnpbFZm4IqZBxL99w");
        }

        private void BtnRun7_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.com/dp/B07DTP6SLJ?tag=pcpapi-20&linkCode=ogi&th=1&psc=1");
        }

        private void BtnRun8_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.newegg.com/g-skill-16gb-288-pin-ddr4-sdram/p/N82E16820232884?Item=N82E16820232884&nm_mc=AFC-RAN-COM&cm_mmc=AFC-RAN-COM&utm_medium=affiliates&utm_source=afc-PCPartPicker&AFFID=2558510&AFFNAME=PCPartPicker&ACRID=1&ASID=https%3a%2f%2fpcpartpicker.com%2fproduct%2fmcH8TW%2fgskill-aegis-16-gb-2-x-8-gb-ddr4-3200-memory-f4-3200c16d-16gis&ranMID=44583&ranEAID=2558510&ranSiteID=8BacdVP0GFs-cSeINGyi8qpP0cF8I0UYTw");
        }

        private void BtnRun9_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.com/Samsung-970-EVO-1TB-MZ-V7E1T0BW/dp/B07BN217QG/ref=sr_1_1?keywords=Samsung+970+evo+Solid+state+drive&qid=1581444246&sr=8-1");
        }

        private void BtnRun1A_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.com/dp/B0033Z2BAQ?tag=pcpapi-20&linkCode=ogi&th=1&psc=1");
        }

        private void BtnRun1B_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.ca/5-0-Inch-Replacement-Battery-B2PW4100-35H00262-00M/dp/B07GPG96W8/ref=sr_1_1_sspa?keywords=Pixel+1+Battery&qid=1581445771&sr=8-1-spons&psc=1&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUEzNFQ3OUsxQ0M5VDlGJmVuY3J5cHRlZElkPUEwNzA4MTkwMVY1NkdHSEJMNkNCNCZlbmNyeXB0ZWRBZElkPUEwODg4Mjk2SDVLQTNFN0hUQ1RGJndpZGdldE5hbWU9c3BfYXRmJmFjdGlvbj1jbGlja1JlZGlyZWN0JmRvTm90TG9nQ2xpY2s9dHJ1ZQ==");
        }

        private void BtnRun1C_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.ca/Anker-Premium-Double-Braided-Samsung-Devices/dp/B07DC5PPFV/ref=sr_1_8?crid=333ET9TGZG5IA&keywords=usb+c+cable+fast+charge&qid=1581445984&s=electronics&smid=AREE309N4XPXI&sprefix=USB+c+%2Celectronics%2C180&sr=1-8");
        }

        private void BrnRun1D_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.ca/Charger-iSeekerkit-Portable-Adapter-Qualcomm/dp/B07FRC155S/ref=sr_1_1_sspa?keywords=USB+charging+block+fast&qid=1581446109&sr=8-1-spons&psc=1&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUEyVlRTNEZVRlRRSFI3JmVuY3J5cHRlZElkPUEwMzg3OTY1MzczUU5SNlg5SzhGViZlbmNyeXB0ZWRBZElkPUEwMjA5ODg2MUlPVVRSVlZDVkFTUiZ3aWRnZXROYW1lPXNwX2F0ZiZhY3Rpb249Y2xpY2tSZWRpcmVjdCZkb05vdExvZ0NsaWNrPXRydWU=");
        }
    }
}
