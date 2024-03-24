using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System;


namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        private string OBS_File;
        private string NAV_File;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_OpenOBSFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd_obs = new OpenFileDialog();
            if (ofd_obs.ShowDialog() == true)
            {
                OBS_File = txtblk_OBSFilePath.Text = ofd_obs.FileName;
            }
        }

        private void Btn_OpenNAVFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd_nav = new OpenFileDialog();
            if (ofd_nav.ShowDialog() == true)
            {
                NAV_File = txtblk_NAVFilePath.Text = ofd_nav.FileName;
            }
        }
        private void Btn_OBS_Header_Click(object sender, RoutedEventArgs e)
        {
            string line = "";
            StreamReader sr = new StreamReader(OBS_File,Encoding.GetEncoding("UTF-8"));
            while ((line = sr.ReadLine())!= null || line.Contains("END OF HEADER"))
            {
                if (line.Contains("RINEX VERSION / TYPE") == true)
                {
                    double ver = double.Parse(line.Substring(0,9));
                    char file_type = line[20];
                    char type = line[40];
                }
                else if (line.Contains("PGM / RUN BY / DATE") == true)
                {

                }
                else if (line.Contains("MARKER NAME") == true)
                {

                }
                else if (line.Contains("OBSERVER / AGENCY") == true)
                {

                }
                else if (line.Contains("REC # / TYPE / VERS") == true)
                {

                }
                else if (line.Contains("ANT # / TYPE") == true)
                {

                }
                else if (line.Contains("APPROX POSITION XYZ") == true)
                {
                    double[] approx_xyz = new double[3];
                    approx_xyz[0] = double.Parse(line.Substring(0,  14));
                    approx_xyz[1] = double.Parse(line.Substring(15, 14));
                    approx_xyz[2] = double.Parse(line.Substring(30, 14));
                }
                else if (line.Contains("ANTENNA: DELTA H/E/N") == true)
                {
                    double[] ant_delta_hen = new double[3];
                    ant_delta_hen[0] = double.Parse(line.Substring(0, 14));
                    ant_delta_hen[1] = double.Parse(line.Substring(15, 14));
                    ant_delta_hen[2] = double.Parse(line.Substring(30, 14));
                }
                else if (line.Contains("SYS / # / OBS TYPES") == true)
                {

                }
                else if (line.Contains("TIME OF FIRST OBS") == true)
                {

                }
                else if (line.Contains("TIME OF LAST OBS") == true)
                {

                }
                else if (line.Contains("SYS / PHASE SHIFT") == true)
                {

                }
                else if (line.Contains("GLONASS SLOT / FRQ #") == true)
                {

                }
                else if (line.Contains("GLONASS COD/PHS/BIS") == true)
                {

                }
                else if (line.Contains("INTERVAL") == true)
                {
                    double interval = double.Parse(line.Substring(0, 10));
                }
                else if (line.Contains("LEAP SECONDS") == true)
                {
                    int leap = int.Parse(line.Substring(4,3));
                }
                else if (line.Contains("COMMENT") == true)
                {

                }
                else if (line.Contains("END OF HEADER") == true)
                {
                    break;
                }
            }
            txtblk_DisplayOBSData.Text = "READING OBS HEADER";
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(">"))
                {
                    int satnum = int.Parse(line.Substring(32, 3));
                    
                    for(int i = 0; i < satnum; i++)
                    {
                        line = sr.ReadLine();
                        if (line[0] == 'G')
                        {
                            int prn = int.Parse(line.Substring(1, 2));
                            double P1 = double.Parse(line.Substring(4, 14));
                            //int LLI_P1 = int.Parse(line.Substring(19, 1));
                            //int SNR1 = int.Parse(line.Substring(20, 1));
                            double L1 = double.Parse(line.Substring(18, 14));
                            double D1 = double.Parse(line.Substring(35, 14));
                            double S1 = double.Parse(line.Substring(51, 14));

                        }
                    }
                }
            }
        }

        private void Btn_OBS_Body_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(OBS_File, Encoding.GetEncoding("UTF-8"));
            txtblk_DisplayOBSData.Text = sr.ReadLine();
        }
    }

}