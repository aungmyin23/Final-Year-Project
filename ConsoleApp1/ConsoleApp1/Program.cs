using System;
using System.IO;
using System.Text;
using System.Threading;
using Thorlabs.CCS_Series;

namespace ConsoleApp1
{
    class Program
    {
        //private const string Resource_Name = "USB0::0x1313::0x8081::M00445812::RAW";

        static void Main(string[] args)
        {
            double[] Data = new double[3648];
            double[] wavelength_Data = new double[3648];
            double min_Wave = 0.00, max_Wave = 0.00;
            double integration_Time = 0.00; //2.67, 
            int device_Status;
            int delayTime = 0;
            string[] Resource_Name = new string[2];
            //Setting up the device
            Resource_Name = DeviceSetup();
            TLCCS tLCCS = new TLCCS(Resource_Name[0], true, true);
            TLCCS CCS100 = tLCCS;
            CCS100.identificationQuery(new StringBuilder(256), new StringBuilder(256), new StringBuilder(256), new StringBuilder(256), new StringBuilder(256));
            Console.Write("Device is connected.\n");
            Console.Write("Plesse key in integration time for the spectrometer." + "\n");
            //Setup integration time for the device 
            integration_Time = Convert.ToDouble(Console.ReadLine());
            CCS100.setIntegrationTime(integration_Time);
            CCS100.getIntegrationTime(out integration_Time);
            Console.Write("Integration time set to " + integration_Time + "sec.\n");
            CCS100.getDeviceStatus(out device_Status);
            Console.Write("Current device status is " + device_Status + "\n");
            delayTime = (int)Math.Ceiling(integration_Time) * 1000;
            Console.Write("Delay time is set to " + delayTime + "millisec\n");
            Console.Write("The device is ready" + "\n");
            //Wait for the command
            string DeviceAction = "0";
            while (DeviceAction != "exit") {
                Console.Write("Enter the next action.\n");
                DeviceAction = Console.ReadLine();
                switch (DeviceAction)
                {
                    //Scan once, get the result and save it in the file called Scan.csv
                    case "scan once":
                        Data = DoScan(delayTime, device_Status, CCS100);
                        StreamWriter sw = new StreamWriter(@"C:\Users\AungMyin\Desktop\School\FYP\Final-Year-Project\Scan.csv", false);
                        for (int i = 0; i < Data.Length; i++)
                        {
                            {
                                sw.WriteLine(Data[i].ToString());
                                sw.Write("\t");
                            }
                        }
                        sw.Write("\r\n");
                        sw.Flush();
                        sw.Close();
                        Console.Write("Scan completed and data saved in Scan.csv \n");
                    break;
                    
                    //Get wavelength information and save in the csv file called Wavelength.csv
                    case "wavelength info":
                        CCS100.getWavelengthData(0, wavelength_Data, out min_Wave, out max_Wave);
                        Console.WriteLine("minimum wavelenght is " + min_Wave);
                        Console.WriteLine("maximum wavelength is " + max_Wave);
                        Console.WriteLine("total wavelength " + wavelength_Data.Length);
                        StreamWriter sw1 = new StreamWriter(@"C:\Users\AungMyin\Desktop\School\FYP\Final-Year-Project\Wavelength.csv", false);
                        for (int i = 0; i < wavelength_Data.Length; i++)
                        {
                            {
                                sw1.WriteLine(wavelength_Data[i].ToString());
                                sw1.Write("\t");
                            }
                        }
                        sw1.Write("\r\n");
                        sw1.Flush();
                        sw1.Close();
                        Console.Write("Wavelength points are saved in Wavelength.csv \n");
                    break;

                    //Get device information for the user
                    case "device info":
                        CCS100.getIntegrationTime(out integration_Time);
                        Console.Write("Device type: " + Resource_Name[1] + "\n");
                        Console.Write(Resource_Name[0] + "\n");
                        Console.Write("Integration time: " + integration_Time + " Delay Time " + delayTime + "\n");
                    break;
                    
                    //Changing the integration time 
                    case "change integration":
                        Console.Write("Plesse key in integration time to be change." + "\n");
                        integration_Time = Convert.ToDouble(Console.ReadLine());
                        CCS100.setIntegrationTime(integration_Time);
                        CCS100.getIntegrationTime(out integration_Time);
                        Console.Write("Integration time set to " + integration_Time + "sec.\n");
                        delayTime = (int)Math.Ceiling(integration_Time) * 1000;
                        Console.Write("Delay time is set to " + delayTime + "sec\n");
                        break;
                    
                    //If user enter the incorrect code as for valid command
                    default:
                        Console.Write("Please enter the valid funcation. \n");
                    break;


                }
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        //This function scan once and send the scanned data back into the main function
        static double [] DoScan(int delayTime, int device_Status, TLCCS CCS100)
        {
            double[] ScanData = new double[3648];
            Console.Write("Scanning....\n");
            CCS100.startScan();
            Thread.Sleep(delayTime);
            CCS100.getDeviceStatus(out device_Status);
            Console.Write("Scan completed.\n");
            CCS100.getScanData(ScanData);
            return ScanData;
        }

        //For initial setup of the device
        static String [] DeviceSetup ()
        {
            // connect the ccs device and start the sample c application. Read out the instrument resource name from the sample application
            // the instrument number 0x8081 is used for the CCS100 device. If you have another CCS instrument please change the number.
            // 0x8081: CCS100
            // 0x8083: CCS125
            // 0x8085: CCS150
            // 0x8087: CCS175
            // 0x8089: CCS200
            string instrumentNumber = "0", deviceChoice = "0";
            int deviceNum = 0;
            string[] Resource_Name = new string[2];
            Console.Write("Plesse select the desire device - 1) CCS100, 2) CCS125, 3) CCS150, 4) CCS175, 5)CCS200" + "\n");
            deviceNum = Convert.ToInt32(Console.ReadLine());
            switch (deviceNum)
            {
                case 1:
                    instrumentNumber = "0x8081";
                    deviceChoice = "CCS100";
                break;
                case 2:
                    instrumentNumber = "0x8083";
                    deviceChoice = "CCS125";
                    break;
                case 3:
                    instrumentNumber = "0x8085";
                    deviceChoice = "CCS150";
                    break;
                case 4:
                    instrumentNumber = "0x8087";
                    deviceChoice = "CCS175";
                    break;
                case 5:
                    instrumentNumber = "0x8089";
                    deviceChoice = "CCS200";
                    break;
                default:
                    Console.WriteLine("Please enter valid number.");
                break;
            }
            Console.WriteLine("Plesse enter 8 numerial serial numbers");
            deviceNum = Convert.ToInt32(Console.ReadLine());
            Resource_Name[0] = "USB0::0x1313::" + instrumentNumber + "::M00" + deviceNum + "::RAW";
            Console.Write(deviceChoice + " information - " + Resource_Name[0] + "\n");
            Resource_Name[1] = deviceChoice;
            return Resource_Name;
        }
    }
}
