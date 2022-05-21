using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;


namespace Telemetri_Data_Logger_and_Graph
{
    public partial class Form1 : Form
    {
        public byte[] get_data = new byte[1000];
        public int get_i = 0;
        public float tempdata;
        int rf_id;


        public ChartValues<MeasureModel> SpeedValues { get; set; }
        public ChartValues<MeasureModel> MotorCurrent_Values{ get; set; }
        DataClass Data = new DataClass();
        //List<string> DataList = new List<string>();


        
        //StreamWriter objStreamWriter;
        string FilePath;

        #region Methods

        /*
        private void SaveData()
        {
            try
            {
                objStreamWriter = new StreamWriter(FilePath, true);
                objStreamWriter.WriteLine(DataList[DataNumber-1]);
                objStreamWriter.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        
        private void Charts_Initiliaze()
        {
            var speed_mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(speed_mapper);

            //the ChartValues property will store our values array
            SpeedValues = new ChartValues<MeasureModel>();
            Speed_Chart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = SpeedValues,
                    PointGeometrySize = 3,
                    StrokeThickness = 2
                }
            };
            Speed_Chart.AxisY.Add(
            new Axis
            {
                MinValue = 0
            });
            Speed_Chart.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(20).Ticks
                }
            });


            var MotorCurrent_mapper = Mappers.Xy<MeasureModel>()
               .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
               .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(MotorCurrent_mapper);

            //the ChartValues property will store our values array
            MotorCurrent_Values = new ChartValues<MeasureModel>();
            MotorCurrent_Chart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = MotorCurrent_Values,
                    PointGeometrySize = 0,
                    StrokeThickness = 2
                }
            };
            MotorCurrent_Chart.AxisY.Add(
            new Axis
            {
                MinValue = 0
            });
            MotorCurrent_Chart.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(20).Ticks
                }
            });




            SetAxisLimits(System.DateTime.Now);
        }
        private void SetAxisLimits(System.DateTime now)
        {
            Speed_Chart.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            Speed_Chart.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(300).Ticks; //Sadece son 300 saniyeyi göz önünde bulundurur

            MotorCurrent_Chart.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            MotorCurrent_Chart.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(300).Ticks; //Sadece son 300 saniyeyi göz önünde bulundurur

        }
        private bool Start_check()
        {
            // : başa gelecek şelikde byte kaydır.
            while (get_i > 0 && get_data[0] != ':')
            {
                for (int i = 1; i < get_i; i++)
                {
                    get_data[i - 1] = get_data[i];
                }
                get_i--;
            }


            if (get_data[0] != ':')
            {
                get_i = 0;
                return false;
            }// ilk karakterin : olması lazım
            if (get_i < 37)
                return false;// minimum karakter sayısını bekle
            return true;
        }

        private bool Channel_check()
        {
            //Kanalları kontrol eder, eğer başka bir kanal eklenecekse burası güncellenmeli.
            //Buradaki 'A' batarya sıcaklarını 'B' GPS, MPU9250, NTC verilerini gönderildiği kanal.
            //70'ten 76 ya kadar sırasıyla bms1 bms2 bms3 bms4 batarya gerilimleri yer aldığı kanal.
            //6 Ana modül verilerinin gönderildiği kanaldır.
            if (get_data[4] != 6 && get_data[4] != 70 && get_data[4] != 72 && get_data[4] != 74 && get_data[4] != 76 && get_data[1] != 'A' && get_data[1] != 'B')
            {
                return false;
            }
            return true;

        }

        private bool CRC_Check()
        {
            Int64 CRC_checksum = 0;
            for (int i = 0; i < 34; i++)
            {
                // 34'e kadar tüm verileri topla
                CRC_checksum += get_data[i];
            }
            // Kalanı hesapla
            CRC_checksum = CRC_checksum % 256;

            if (CRC_checksum == get_data[34])
            {
                // Gelen CRC ile bizim hesapladığımız aynı, veriler doğru geldi.
                return true;
            }
            else
            {
                // Veriler hatalı geldi.
                return false;
            }
        }

        private float msb_lsb_düzenleme(int i) //i-> lsb biti gönder
        {
            tempdata = 0;
            int a;
            a= (Convert.ToInt16(get_data[i+1]))*256 + (Convert.ToInt16(get_data[i]));
            return (float)a;

            /* yanlış
            byte[] temp_arr = new byte[2];

            temp_arr[0] = (get_data[i + 1]);
            temp_arr[1] = (get_data[i]);

            return BitConverter.ToInt16(temp_arr, 0);*/

        }


        private void Ek_Veri()
        {
                // Ek veri blokları,

                // Burada kendi CRC metodumuzla bir kontrol mekanizması kullanıyoruz.
                // CRC hesabı için bir tane büyük değişkene, CRC byte'ına kadar tüm değerleri toplayıp koyuyoruz.
                // (CRC'yi içeren byte; LoRa'dan gelen veri setindeki 34 indeksli eleman.)
                // Akabinde uint8_t tipine sığabilmesi için 256'ya göre kalanını hesaplıyoruz.
                Int64 CRC_checksum_Ek_set = 0;
                for (int i = 0; i < 42; i++)
                {
                    // 34'e kadar tüm verileri topla
                    CRC_checksum_Ek_set += get_data[i];
                }

                // Kalanı hesapla
                CRC_checksum_Ek_set = CRC_checksum_Ek_set % 256;

                if (CRC_checksum_Ek_set == get_data[42])
                {
                    // Gelen CRC ile bizim hesapladığımız aynı, veriler doğru geldi
                    // Devam edilebilir.
                }
                else
                {
                    // Veriler hatalı geldi.
                    return;
                }

                if (get_data[1] == 'A')
                {

                    // Battarya sıcaklıkları
                    Data.battery_temp1 = get_data[2];
                    Data.battery_temp2 = get_data[3];
                    Data.battery_temp3 = get_data[4];
                    Data.battery_temp4 = get_data[5];
                    Data.battery_temp5 = get_data[6];
                    Data.battery_temp6 = get_data[7];
                    Data.battery_temp7 = get_data[8];
                    Data.battery_temp8 = get_data[9];
                    Data.battery_temp9 = get_data[10];
                    Data.battery_temp10 = get_data[11];
                    Data.battery_temp11 = get_data[12];
                    Data.battery_temp12 = get_data[13];
                    Data.battery_temp13 = get_data[14];
                    Data.battery_temp14 = get_data[15];
                    Data.battery_temp15 = get_data[16];
                    Data.battery_temp16 = get_data[17];
                    Data.battery_temp17 = get_data[18];
                    Data.battery_temp18 = get_data[19];
                    Data.battery_temp19 = get_data[20];
                    Data.battery_temp20 = get_data[21];
                    Data.battery_temp21 = get_data[22];
                    Data.battery_temp22 = get_data[23];
                    Data.battery_temp23 = get_data[24];
                    Data.battery_temp24 = get_data[25];
                    Data.battery_temp25 = get_data[26];
                    Data.battery_temp26 = get_data[27];
                    Data.battery_temp27 = get_data[28];
                    Data.battery_temp28 = get_data[29];
                    Data.battery_temp29 = get_data[30];

                }

            if (get_data[1] == 'B')
                {

                    float tempData;

                    // Yaw
                    tempData = BitConverter.ToInt16(get_data, 13);
                    if (tempData > 20000)
                    {
                        tempData = tempData - 65535;
                        tempData = tempData / 10;
                    Data.Yaw = tempData;
                    }
                    else
                    {
                        tempData = tempData / 10;
                        Data.Yaw = tempData;
                    }

                    // Pitch
                    tempData = BitConverter.ToInt16(get_data, 15);
                    if (tempData > 20000)
                    {
                        tempData = tempData - 65535;
                        tempData = tempData / 10;
                        tempData = tempData - (float)2.2; // Offset
                        Data.Pitch = tempData;
                        //label3.Text = Data.Pitch;
                    }
                    else
                    {
                        tempData = tempData / 10;
                        tempData = tempData - (float)2.2; // Offset
                        Data.Pitch = tempData;
                    }

                    // Roll
                    tempData = BitConverter.ToInt16(get_data, 17);
                    if (tempData > 20000)
                    {
                        tempData = tempData - 65535;
                        tempData = tempData / 10;
                        Data.Roll = tempData;
                    }
                    else
                    {
                        tempData = tempData / 10;
                        Data.Roll = tempData;
                    }

                    // Gyro X
                    tempData = BitConverter.ToInt16(get_data, 19);
                    if (tempData > 20000)
                    {
                        tempData = tempData - 65535;
                        tempData = tempData / 10;
                        Data.Gyro_x = tempData;
                    }
                    else
                    {
                        tempData = tempData / 10;
                        Data.Gyro_x = tempData;
                    }

                    // Gyro Y
                    tempData = BitConverter.ToInt16(get_data, 21);
                    if (tempData > 20000)
                    {
                        tempData = tempData - 65535;
                        tempData = tempData / 10;
                        Data.Gyro_y = tempData;
                    }
                    else
                    {
                        tempData = tempData / 10;
                        Data.Gyro_y = tempData;
                    }

                    // Gyro Z
                    tempData = BitConverter.ToInt16(get_data, 23);
                    if (tempData > 20000)
                    {
                        tempData = tempData - 65535;
                        tempData = tempData / 10;
                        Data.Gyro_z = tempData;
                    }
                    else
                    {
                        tempData = tempData / 10;
                        Data.Gyro_z = tempData;
                    }

                    // Acc X
                    tempData = BitConverter.ToInt16(get_data, 25);
                    if (tempData > 20000)
                    {
                        tempData = tempData - 65535;
                        tempData = tempData / 10;
                        Data.Acc_x = tempData;
                    }
                    else
                    {
                        tempData = tempData / 10;
                        Data.Acc_x = tempData;
                    }

                    // Acc Y
                    tempData = BitConverter.ToInt16(get_data, 27);
                    if (tempData > 20000)
                    {
                        tempData = tempData - 65535;
                        tempData = tempData / 10;
                        Data.Acc_y = tempData;
                    }
                    else
                    {
                        tempData = tempData / 10;
                        Data.Acc_y = tempData;
                    }

                    // Acc Z
                    tempData = BitConverter.ToInt16(get_data, 29);
                    if (tempData > 20000)
                    {
                        tempData = tempData - 65535;
                        tempData = tempData / 10;
                        Data.Acc_z = tempData;
                    }
                    else
                    {
                        tempData = tempData / 10;
                        Data.Acc_z = tempData;
                    }
                    /*
                    // Pilot uyarı butonu,
                    tempData = get_data[37];
                    if (tempData == 1)
                    {
                        // Sorun var:
                        label44.Text = "DİKKAT ET!";
                    }
                    else
                    {
                        // Sorun yok:
                        label44.Text = "Sorun yok.";

                    }
                    */

                    // Enlem
                    tempData = (float)BitConverter.ToInt32(get_data, 2) / 1000000;
                    Data.Latitude = tempData;

                    // Boylam
                    tempData = (float)BitConverter.ToInt32(get_data, 6) / 1000000;
                    Data.Longitude = tempData;

                    // GPS hız
                    tempData = Convert.ToInt16(get_data[10]);
                    Data.GPS_speed = tempData;

                    // GPS yükseklik
                    Data.GPS_height = (float)BitConverter.ToInt16(get_data, 11);

                    // Sıcaklıklar
                    Data.MPPT_temp1 = get_data[30]; // MPPT 1
                    Data.MPPT_temp2 = get_data[31]; // MPPT 2
                    Data.Motor_temp1 = get_data[32]; // Motor 1
                    Data.Motor_temp2 = get_data[33]; // Motor 2
                    Data.Motor_temp3 = get_data[34]; // Motor 3
                    Data.PV_temp1 = get_data[35]; // PV 1
                    Data.PV_temp2 = get_data[36]; // PV 2

                }
        }

        private void Ana_module_veri()
        {
            //Ana modülden gelen veriler burada bir class'a aktarılır.

            //Battery energy
            tempdata = msb_lsb_düzenleme(6);
            if(tempdata > 20000)
            {
                tempdata = tempdata - 65535;
                tempdata = tempdata / 10;
                Data.Battery_energy = tempdata ;
            }
            else
            {
                tempdata = tempdata / 10;
                Data.Battery_energy = tempdata;
            }

            //PV energy
            tempdata = msb_lsb_düzenleme(10);
            if (tempdata > 20000)
            {
                Data.PV_energy = (tempdata - 65536);
            }
            else
            {
                Data.PV_energy = tempdata;
            }
            //Data.PV_energy=tempdata;

            //Battery current
            tempdata = msb_lsb_düzenleme(12);
            if(tempdata > 20000)
            {
                Data.Battery_current = (tempdata-65535)/10;
            }
            else
            {
                Data.Battery_current = tempdata/10;
            }

            //PV current
            tempdata = msb_lsb_düzenleme(14); //can be 12
            if (tempdata > 20000)
            {
                Data.PV_current = (tempdata - 65536) / 10;
            }
            else
            {
                Data.PV_current = tempdata / 10;
            }
            //Data.PV_current = tempdata/10;

            //Battery voltage
            tempdata = msb_lsb_düzenleme(16);
            Data.Battery_voltage = tempdata / 10;

            //Speed
            tempdata = msb_lsb_düzenleme(18);
            Data.Speed = tempdata / 10;

            //Cabin temp
            tempdata = msb_lsb_düzenleme(20);
            Data.Cabin_Temp = tempdata / 10;
            /*
            //Total used current
            tempdata = msb_lsb_düzenleme(22);
            if (tempdata > 20000)
            {
                Data.Total_current = (tempdata - 65535) / 10;
            }
            else
            {
                Data.Total_current = tempdata / 10;
            }
            */

            //Hesaplamalı işlemler
            //Motor_Current
            Data.Motor_current = Data.Battery_current + Data.PV_current;

        }
        
        private void BMS_Veri()
        {
            switch (get_data[4])
            {
                //BMS1
                case 70:
                    Data.battery_voltage1 = ((float)msb_lsb_düzenleme(8) / 100);
                    Data.battery_voltage2 = (float)msb_lsb_düzenleme(10) / 100;
                    Data.battery_voltage3 = (float)msb_lsb_düzenleme(12) / 100;
                    Data.battery_voltage4 = (float)msb_lsb_düzenleme(14) / 100;
                    Data.battery_voltage5 = (float)msb_lsb_düzenleme(16) / 100;
                    Data.battery_voltage6 = (float)msb_lsb_düzenleme(18) / 100;
                    Data.battery_voltage7 = (float)msb_lsb_düzenleme(20) / 100;
                    Data.battery_voltage8 = (float)msb_lsb_düzenleme(22) / 100;
                    
                    break;
                //BMS2
                case 72:
                    Data.battery_voltage9 = (float)msb_lsb_düzenleme(8) / 100;
                    Data.battery_voltage10 = (float)msb_lsb_düzenleme(10) / 100;
                    Data.battery_voltage11 = (float)msb_lsb_düzenleme(12) / 100;
                    Data.battery_voltage12 = (float)msb_lsb_düzenleme(14) / 100;
                    Data.battery_voltage13 = (float)msb_lsb_düzenleme(16) / 100;
                    Data.battery_voltage14 = (float)msb_lsb_düzenleme(18) / 100;
                    Data.battery_voltage15 = (float)msb_lsb_düzenleme(20) / 100;
                    Data.battery_voltage16 = (float)msb_lsb_düzenleme(22) / 100;
                   
                    break;
                //BMS3
                case 74:
                    Data.battery_voltage17 = (float)msb_lsb_düzenleme(8) / 100;
                    Data.battery_voltage18 = (float)msb_lsb_düzenleme(10) / 100;
                    Data.battery_voltage19 = (float)msb_lsb_düzenleme(12) / 100;
                    Data.battery_voltage20 = (float)msb_lsb_düzenleme(14) / 100;
                    Data.battery_voltage21 = (float)msb_lsb_düzenleme(16) / 100;
                    Data.battery_voltage22 = (float)msb_lsb_düzenleme(18) / 100;
                    Data.battery_voltage23 = (float)msb_lsb_düzenleme(20) / 100;
                    Data.battery_voltage24 = (float)msb_lsb_düzenleme(22) / 100;
                    break;
                //BMS4
                case 76:
                    Data.battery_voltage25 = (float)msb_lsb_düzenleme(8) / 100;
                    Data.battery_voltage26 = (float)msb_lsb_düzenleme(10) / 100;
                    Data.battery_voltage27 = (float)msb_lsb_düzenleme(12) / 100;
                    Data.battery_voltage28 = (float)msb_lsb_düzenleme(14) / 100;
                    Data.battery_voltage29 = (float)msb_lsb_düzenleme(16) / 100;
                    Data.battery_voltage30 = (float)msb_lsb_düzenleme(18) / 100;
                    Data.battery_voltage31 = (float)msb_lsb_düzenleme(20) / 100;
                    Data.battery_voltage32 = (float)msb_lsb_düzenleme(22) / 100;     
                    break; 

                    
            }
        }

        private void Yazdir()
        {

            String DataDate = DateTime.Now.ToString();
            Data_Time_Label.Text = DataDate;


            BattCurrent_Label.Text = Data.Battery_current.ToString() + " A";
            BattEnergy_Label.Text = Data.Battery_energy.ToString() + " W";
            BattVoltage_Label.Text = Data.Battery_voltage.ToString() + " V";
            PVCurrent_Label.Text = Data.PV_current.ToString() + " A";
            PVEnergy_Label.Text = Data.PV_energy.ToString() + " W";
            Speed_Label.Text = Data.Speed.ToString() + " km/h";
            CabinTemp_Label.Text = Data.Cabin_Temp.ToString() + " °C";
            //TotalCurrent_Label.Text = Data.Total_current.ToString() + " A";
            Motor_Current_Label.Text = Data.Motor_current.ToString() + " A";

            BMS_Voltage1_Label.Text = Data.battery_voltage1.ToString();
            BMS_Voltage2_Label.Text = Data.battery_voltage2.ToString();
            BMS_Voltage3_Label.Text = Data.battery_voltage3.ToString();
            BMS_Voltage4_Label.Text = Data.battery_voltage4.ToString();
            BMS_Voltage5_Label.Text = Data.battery_voltage5.ToString();
            BMS_Voltage6_Label.Text = Data.battery_voltage6.ToString();
            BMS_Voltage7_Label.Text = Data.battery_voltage7.ToString();
            BMS_Voltage8_Label.Text = Data.battery_voltage8.ToString();
            BMS_Voltage9_Label.Text = Data.battery_voltage9.ToString();
            BMS_Voltage10_Label.Text = Data.battery_voltage10.ToString();
            BMS_Voltage11_Label.Text = Data.battery_voltage11.ToString();
            BMS_Voltage12_Label.Text = Data.battery_voltage12.ToString();
            BMS_Voltage13_Label.Text = Data.battery_voltage13.ToString();
            BMS_Voltage14_Label.Text = Data.battery_voltage14.ToString();
            BMS_Voltage15_Label.Text = Data.battery_voltage15.ToString();
            BMS_Voltage16_Label.Text = Data.battery_voltage16.ToString();
            BMS_Voltage17_Label.Text = Data.battery_voltage17.ToString();
            BMS_Voltage18_Label.Text = Data.battery_voltage18.ToString();
            BMS_Voltage19_Label.Text = Data.battery_voltage19.ToString();
            BMS_Voltage20_Label.Text = Data.battery_voltage20.ToString();
            BMS_Voltage21_Label.Text = Data.battery_voltage21.ToString();
            BMS_Voltage22_Label.Text = Data.battery_voltage22.ToString();
            BMS_Voltage23_Label.Text = Data.battery_voltage23.ToString();
            BMS_Voltage24_Label.Text = Data.battery_voltage24.ToString();
            BMS_Voltage25_Label.Text = Data.battery_voltage25.ToString();
            BMS_Voltage26_Label.Text = Data.battery_voltage26.ToString();
            BMS_Voltage27_Label.Text = Data.battery_voltage27.ToString();
            BMS_Voltage28_Label.Text = Data.battery_voltage28.ToString();
            BMS_Voltage29_Label.Text = Data.battery_voltage29.ToString();
            BMS_Voltage30_Label.Text = Data.battery_voltage30.ToString();
            BMS_Voltage31_Label.Text = Data.battery_voltage31.ToString();
            BMS_Voltage32_Label.Text = Data.battery_voltage32.ToString();


            BattTemp1_Label.Text = Data.battery_temp1.ToString() + " °C";
            BattTemp2_Label.Text = Data.battery_temp2.ToString() + " °C";
            BattTemp3_Label.Text = Data.battery_temp3.ToString() + " °C";
            BattTemp4_Label.Text = Data.battery_temp4.ToString() + " °C";
            BattTemp5_Label.Text = Data.battery_temp5.ToString() + " °C";
            BattTemp6_Label.Text = Data.battery_temp6.ToString() + " °C";
            BattTemp7_Label.Text = Data.battery_temp7.ToString() + " °C";
            BattTemp8_Label.Text = Data.battery_temp8.ToString() + " °C";
            BattTemp9_Label.Text = Data.battery_temp9.ToString() + " °C";
            BattTemp10_Label.Text = Data.battery_temp10.ToString() + " °C";
            BattTemp11_Label.Text = Data.battery_temp11.ToString() + " °C";
            BattTemp12_Label.Text = Data.battery_temp12.ToString() + " °C";
            BattTemp13_Label.Text = Data.battery_temp13.ToString() + " °C";
            BattTemp14_Label.Text = Data.battery_temp14.ToString() + " °C";
            BattTemp15_Label.Text = Data.battery_temp15.ToString() + " °C";
            BattTemp16_Label.Text = Data.battery_temp16.ToString() + " °C";
            BattTemp17_Label.Text = Data.battery_temp17.ToString() + " °C";
            BattTemp18_Label.Text = Data.battery_temp18.ToString() + " °C";
            BattTemp19_Label.Text = Data.battery_temp19.ToString() + " °C";
            BattTemp20_Label.Text = Data.battery_temp20.ToString() + " °C";
            BattTemp21_Label.Text = Data.battery_temp21.ToString() + " °C";
            BattTemp22_Label.Text = Data.battery_temp22.ToString() + " °C";
            BattTemp23_Label.Text = Data.battery_temp23.ToString() + " °C";
            BattTemp24_Label.Text = Data.battery_temp24.ToString() + " °C";
            BattTemp25_Label.Text = Data.battery_temp25.ToString() + " °C";
            BattTemp26_Label.Text = Data.battery_temp26.ToString() + " °C";
            BattTemp27_Label.Text = Data.battery_temp27.ToString() + " °C";
            BattTemp28_Label.Text = Data.battery_temp28.ToString() + " °C";
            BattTemp29_Label.Text = Data.battery_temp29.ToString() + " °C";
            BattTemp30_Label.Text = Data.battery_temp30.ToString() + " °C";

            Yaw_Label.Text = Data.Yaw.ToString("n2") + " deg";
            Pitch_Label.Text = Data.Pitch.ToString("n2") + " deg";
            Roll_Label.Text= Data.Roll.ToString("n2") + " deg";

            GyroX_Label.Text = Data.Gyro_x.ToString("n2") + " deg/s";
            GyroY_Label.Text = Data.Gyro_y.ToString("n2") + " deg/s";
            GyroZ_Label.Text= Data.Gyro_z.ToString("n2") + " deg/s";
            AccelX_Label.Text = Data.Acc_x.ToString("n2") + " G";
            AccelY_Label.Text = Data.Acc_y.ToString("n2") + " G";
            AccelZ_Label.Text = Data.Acc_z.ToString("n2") + " G";
            Longitude_Label.Text = Data.Longitude.ToString("n2");
            Latitude_Label.Text = Data.Latitude.ToString("n2");
            GPS_Speed_Label.Text = Data.GPS_speed.ToString("n2") + " km/h";
            GPS_Height_Label.Text = Data.GPS_height.ToString("n2") + " m";

            MPPT_T1_Label.Text = Data.MPPT_temp1.ToString() + " °C";
            MPPT_T2_Label.Text = Data.MPPT_temp2.ToString() + " °C";
            Motor_T1_Label.Text= Data.Motor_temp1.ToString() + " °C";
            Motor_T2_Label.Text= Data.Motor_temp2.ToString() + " °C";
            Motor_T3_Label.Text = Data.Motor_temp3.ToString() + " °C";
            PV_T1_Label.Text = Data.PV_temp1.ToString() + " °C";
            PV_T2_Label.Text = Data.PV_temp2.ToString() + " °C";

        }
       

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            ComboBoxPort.Items.AddRange(ports);

            ButtonDisconnect.Enabled = false;
            Charts_Initiliaze();

            // Tarihi dosya adına işlemek için tarih verisi alınır
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            String dy = datevalue.Day.ToString();
            String mn = datevalue.Month.ToString();
            String yy = datevalue.Year.ToString();
            //Verinin yazılacağı dosya yolu ve ismi tarih ile birlikte belirlenir
            //not: buraya yarışın adı da arayüzde bir pencere ile kullanıcıdan alınıp eklenebilir
            FilePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            FilePath += @"\Log\" + yy + "." + mn + "." + dy + ".txt";
        }

        private void ButtonScanPort_Click(object sender, EventArgs e)
        {
            ComboBoxPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            ComboBoxPort.Items.AddRange(ports);
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                serialPort1.PortName = ComboBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(ComboBoxBaudRate.Text);
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Open();

                LabelStatus.Text = "Status: Connected";
                ButtonConnect.Enabled = false;
                ButtonDisconnect.Enabled = true;
                ButtonScanPort.Enabled = false;
                //graphstarttime = DateTime.Now
                graph_clock.Start();

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();

                LabelStatus.Text = "Status: Disconnected";
                ButtonConnect.Enabled = true;
                ButtonDisconnect.Enabled = false;
                ButtonScanPort.Enabled = true;
                graph_clock.Stop();
            }

        }


        private void modbus_master_clock_Tick(object sender, EventArgs e)
        {
            //Gelen veriler alınır, uzunluğu get_i verinin kendisi get_data'ya atanır
            SerialPort sp = serialPort1;
            if (serialPort1.IsOpen)
            {
                if (sp.BytesToRead > 0)
                {
                    byte[] aaa = new byte[sp.BytesToRead];
                    sp.Read(get_data, get_i, aaa.Length);
                    get_i += aaa.Length * sizeof(byte);

                    if (get_i > 90) get_i = 90;
                }
                if (!Start_check()) return;
                get_i = 0;
                if (!Channel_check()) return;
                if (get_data[1] == 'A' || get_data[1] == 'B')
                {
                    Ek_Veri();
                }
                //CRC check gir (default)

                rf_id = BitConverter.ToInt16(get_data, 4);

                if (!CRC_Check()) return;
                else if (rf_id == 6)
                {
                    Ana_module_veri();
                }
                //
                else if (rf_id == 70 || rf_id == 72 || rf_id == 74 || rf_id == 76)
                {
                    BMS_Veri();
                }
                Yazdir();
            }
        }

        private void graph_clock_Tick(object sender, EventArgs e)
        {
            var now = System.DateTime.Now;

            SpeedValues.Add(new MeasureModel
            {
                DateTime = now,
                Value = Data.Speed
            });

            MotorCurrent_Values.Add(new MeasureModel
            {
                DateTime = now,
                Value = Data.Motor_current
            });

            SetAxisLimits(now);

            //Maksimum 10000 tane veri tutacak şekilde ayarlandı
            if (SpeedValues.Count > 10000) SpeedValues.RemoveAt(0);
            if (MotorCurrent_Values.Count > 10000) MotorCurrent_Values.RemoveAt(0);
        }
        private void Axis_RangeChanged(LiveCharts.Events.RangeChangedEventArgs eventArgs)
        {
            //sync the graphs
            double min = ((Axis)eventArgs.Axis).MinValue;
            double max = ((Axis)eventArgs.Axis).MaxValue;

            this.Speed_Chart.AxisX[0].MinValue = min;
            this.Speed_Chart.AxisX[0].MaxValue = max;

            this.MotorCurrent_Chart.AxisX[0].MinValue = min;
            this.MotorCurrent_Chart.AxisX[0].MaxValue = max;


            //Repeat for as many graphs as you have
        }
    }
}
