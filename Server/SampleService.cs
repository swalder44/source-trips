using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Imaging;
//using System.Drawing;
//using System.DrawingCore;
//using System.DrawingCore.Imaging;
using Veldrid.ImageSharp;
using System.DrawingCore;
using SharpDX.Multimedia;
using System.DrawingCore.Imaging;


//using System.Drawing;
//using iTextSharp.text;

namespace Server
{
	public class SampleService : ISampleService
	{
        public Int64 CO = 0;
        public Int64 IDV; public int co;
        public string[,] PDK = new string[7, 30];
        public string[] KlSch = new string[6];
        public string[] Im = new string[15];
        public int i = 0;
        public string cstrU;
        public string cstrU1;
        public string cstrU2;
        public string strstr123;
        public Decimal IDStup;
        public string Stup;
        public int DatForSt;
        public int DatForStI=Convert.ToInt32(DateTime.Now.ToString("yyMMdd"));
        public Int32 NPRSt=0;
        public int ColNP;
        public string STRZam;
        public int FlStup;
        public string BinStr;
        //public long IP;
        public string Ping(int s)
		{
			Console.WriteLine("Exec ping method");
			return s.ToString();
		}

        public static string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
        static void CopyFolderYesterdayFiles(string sourceFolder, string destFolder)
        {
            DateTime YesterdayDate = DateTime.Today.Date;
            //DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\Users\\cherednikov\\Desktop\\АКТЫ");
            DirectoryInfo dirInfo = new DirectoryInfo(@"F:\archiv\XML");
            if (!Directory.Exists(destFolder))
            { Directory.CreateDirectory(destFolder); }
            FileInfo[] files = dirInfo.GetFiles(DateTime.Today.AddDays(-1).ToString("yyyyMMdd") + "_*.xml");//sourceFolder);
            //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\cherednikov\Desktop\АКТЫ\" + YesterdayDate.ToString("yyyyMMdd"));//file => file.LastWriteTime.Date == YesterdayDate );
            DirectoryInfo directory = new DirectoryInfo(@"F:\archiv\XML\" + YesterdayDate.ToString("yyyyMMdd"));
            foreach (FileInfo file in files)
                File.Move(file.FullName, Path.Combine(destFolder, file.Name));
            
        }

     

        public bool CheckRequestData(VehicleContainer inputModel)
        {

            ///////////////////////// процедура приема (сначала пишется файл - 7 строк, затем обработка для распихивания по таблицам)
            ConnectStr conStrKl1 = new ConnectStr();
            conStrKl1.ConStr(1);
            cstrU1 = conStrKl1.StP;
            if (inputModel.ID < 2832035 || inputModel.ID >= 2832037)
            {
            using (MySqlConnection sqlConnectionT1 = new MySqlConnection(cstrU1))
                {
                    long IP = Convert.ToInt64(inputModel.ID);
                    sqlConnectionT1.Open();
                    MySqlTransaction transaction = sqlConnectionT1.BeginTransaction();

                    string NamF = DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + "_" + inputModel.CreatedBy.PlatformId + "_" + inputModel.ID;
                    ////string NamF = DateTime.Now + "_" + inputModel.ID;
                    //using (FileStream stream = new FileStream(@"C:\Users\cherednikov\Desktop\АКТЫ\" + NamF.ToString() + ".xml", FileMode.CreateNew))

                    using (FileStream stream = new FileStream(@"F:\archiv\XML\" + NamF.ToString() + ".xml", FileMode.CreateNew))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(VehicleContainer));
                        serializer.Serialize(stream, inputModel);
                        stream.Flush();
                        //stream.Close();
                    }
                    //string aaa = @"C:\Users\cherednikov\Desktop\АКТЫ\" + DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
                    string aaa = @"F:\archiv\XML\" + DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
                    //CopyFolderYesterdayFiles(@"C:\Users\cherednikov\Desktop\АКТЫ", aaa);
                    CopyFolderYesterdayFiles(@"F:\archiv\XML", aaa);
                    KlSch = new string[4];
                    int j = 0;
                    ////////////////////////////////////  класс-схема и индекс  //////////////////////////////////////
                    foreach (Classification Cl in inputModel.Classification)
                    {
                        KlSch[j] = Cl.Index.ToString();
                        j = j + 1;
                        KlSch[j] = Cl.Schema.ToString();
                        j = j + 1;

                    }
                    ////////////////////////////////////////////////////////////////////////////////////////

                    using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(St1(inputModel), sqlConnectionT1))
                    {
                        if (sqlConnectionT1.State == System.Data.ConnectionState.Closed)
                        { sqlConnectionT1.Open(); }
                        cmd1.ExecuteNonQuery();
                    }

                    PDK = new string[inputModel.AxleCount, 30];

                    foreach (AxleContainer a in inputModel.Axles)
                    {
                        using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(StrAxel(a, IP), sqlConnectionT1))
                        {
                            if (sqlConnectionT1.State == System.Data.ConnectionState.Closed)
                            { sqlConnectionT1.Open(); }
                            cmd1.ExecuteNonQuery();
                        }
                    }

                    Im = new string[15];
                    co = 0;
                    foreach (BinaryContainer b in inputModel.Binaries)
                    {
                        string BS = @"F:\\archivACT\\Photo\\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\\" + IP.ToString() + "_" + b.CreatedBy.PlatformId.ToString() + "_" + b.Created.ToString("yyyyMMdd_HHmmss") + "_" + co.ToString();

                        if (b.Name != "Video")
                        {
                            if (b == null)
                                continue;
                            Im[co] = b.ID.ToString();
                            co = co + 1;
                            CO = CO + 1;
                            //b.CreatedBy.PlatformId
                            // b.Data;
                            //if (!System.IO.Directory.Exists(@"C:\Users\cherednikov\Desktop\АКТЫ\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\"))
                            if (!System.IO.Directory.Exists(@"F:\archivACT\Photo\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\"))
                            {
                                //System.IO.Directory.CreateDirectory(@"C:\Users\cherednikov\Desktop\АКТЫ\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\");
                                System.IO.Directory.CreateDirectory(@"F:\archivACT\Photo\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\");
                            }
                            // System.DrawingCore.Image imgg = byteArrayToImage(b.Data);
                            //string BS = @"C:\Users\cherednikov\Desktop\АКТЫ\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\"+IP.ToString()+"_"+b.CreatedBy.PlatformId.ToString()+"_"+b.Created.ToString("yyyyMMdd_HHmmss") + "_" + co.ToString();
                            BS = @"F:\\archivACT\\Photo\\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\\" + IP.ToString() + "_" + b.Name.ToString() + "_" + b.CreatedBy.PlatformId.ToString() +  "_" + b.Created.ToString("yyyyMMdd_HHmmss") + "_" + CO.ToString();

                            //Bitmap aa = byteArrayToImage(b.Data);
                            //aa.Save(@"C:\Users\cherednikov\Desktop\АКТЫ\123.png", System.DrawingCore.Imaging.ImageFormat.Png);
                            File.WriteAllBytes(BS + ".png", b.Data);
                            
                            //aa.Save(BS + ".png", System.DrawingCore.Imaging.ImageFormat.Png);
                            ////imgg.Save(BS + "_" + co + ".Jpeg", System.DrawingCore.Imaging.ImageFormat.Jpeg);
                            //BinStr = @BS.ToString();
                        using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(StrBinryN(b, IP, BS + ".png"), sqlConnectionT1))
                        {
                            if (sqlConnectionT1.State == System.Data.ConnectionState.Closed)
                            { sqlConnectionT1.Open(); }
                            cmd1.ExecuteNonQuery();
                        }
                        //using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(StrBinry(b, IP), sqlConnectionT1))
                        //{
                        //    if (sqlConnectionT1.State == System.Data.ConnectionState.Closed)
                        //    { sqlConnectionT1.Open(); }
                        //    cmd1.ExecuteNonQuery();
                        //}

                        }
                        else
                        {
                            Im[co] = b.ID.ToString();
                            co = co + 1;
                            CO = CO + 1;
                            File.WriteAllBytes(@"F:\\archivACT\\Photo\\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\\" + IP.ToString() + "_" + b.CreatedBy.PlatformId.ToString() + "_" + b.Created.ToString("yyyyMMdd_HHmmss") + "_" + co.ToString()+".avi", b.Data);
                            using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(StrBinryN(b, IP, @"F:\\archivACT\\Photo\\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\\" + IP.ToString() + "_" + b.CreatedBy.PlatformId.ToString() + "_" + b.Created.ToString("yyyyMMdd_HHmmss") + "_" + CO.ToString() + ".avi"), sqlConnectionT1))
                            {
                                if (sqlConnectionT1.State == System.Data.ConnectionState.Closed)
                                { sqlConnectionT1.Open(); }
                                cmd1.ExecuteNonQuery();
                            }
                            //using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(StrBinry(b, IP), sqlConnectionT1))
                            //{
                            //    if (sqlConnectionT1.State == System.Data.ConnectionState.Closed)
                            //    { sqlConnectionT1.Open(); }
                            //    cmd1.ExecuteNonQuery();
                            //}
                        }
                       
                    }

                    using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(StrPROEZD(inputModel, IP), sqlConnectionT1))
                    {
                        if (sqlConnectionT1.State == System.Data.ConnectionState.Closed)
                        { sqlConnectionT1.Open(); }
                        cmd1.ExecuteNonQuery();
                    }

                    ////////////////////////////////////////////////////////////////////////////////////////////

                    transaction.Commit();
                    sqlConnectionT1.Close();
                }
            }
            return true;
        }

        public void VoidMethod(out string s)
		{
			s = "Value from server";
		}

		public Task<int> AsyncMethod()
		{
			return Task.Run(() => 42);
		}

		public int? NullableMethod(bool? arg)
		{
			return null;
		}
        private string St1(VehicleContainer inputModel)
        {
            return  "INSERT INTO vehiclecontainer (ID, "
                 + "  PlatformId, "
                 + "  ComponentId, "
                 + "  SoftwareVersion, "
                 + "  CreatedBy, "
                 + "  Created, "
                 + "  Credence, "
                 + "  CredenceExceeded, "
                 + "  Lane, "
                 + " Direction, "
                 + "  Speed, "
                 + "  SpeedDifference, "
                 + "  Length, "
                 + "  Width, "
                 + "  Height, "
                 + "  PositionLeft, "
                 + "  PositionRight, "
                 + "  Units, "
                 + "  WheelBase, "
                 + "  Weight, "
                 + "  WeightLimit, "
                 + "  Overweight, "
                 + "  AxleCount, "
                 + "  Plate, "
                 + "  PlateConfidence, "
                 + "  PlateValid, "
                 + "  PlateRearConfidence, "
                 + "  PlateRearValid, "
                 + "  Country, "
                 //+ "  CountrySubdivision, "
                 + "  CountryConfidence, "
                 + "  AdrFrontEmpty, "
                 + "  AdrFrontKemler, "
                 + "  AdrFrontUn, "
                 + "  AdrFrontConfidence, "
                 + "  AdrRearEmpty, "
                 + "  AdrRearKemler, "
                 + "  AdrRearUn, "
                 + "  AdrRearConfidence, "
                 + "  IsOverweightGross, "
                 + "  IsOverweightPartial, "
                 + "  IsExceededLength, "
                 + "  IsExceededWidth, "
                 + "  IsExceededHeight, "
                 + "  IsOverspeed, "
                 + "  IsWrongDirection, "
                 + "  IsNonStandard, "
                 + "  OperatingRangeExceededSpeed, "
                 + "  OperatingRangeExceededWeight, "
                 + "  Divert, "
                 + "  Diverted ) "
                 + " VALUES( "
                 + "" + inputModel.ID + ", " +
             "'" + inputModel.CreatedBy.PlatformId + "', " +
             "'" + inputModel.CreatedBy.BGuidType + "'," +
             "'" + inputModel.CreatedBy.KeyMark + "'," +
             "'" + inputModel.CreatedBy.ID + "'," +
              "'" + inputModel.Created + "'," +
             "'" + inputModel.Credence + "'," +
             "'" + inputModel.CodeInt + "', " +//CredenceExceeded + "'," +
             "'" + inputModel.LaneNumber + "'," +
             "'" + inputModel.Direction + "'," +
             "'" + inputModel.Speed + "'," +
             "'" + inputModel.SpeedDifference + "'," +
             "'" + inputModel.Length + "'," +
             "'" + inputModel.Width + "'," +
             "'" + inputModel.Height + "'," +
             "'" + inputModel.PositionLeft + "'," +
             "'" + inputModel.PositionRight + "'," +
             "'" + inputModel.Units + "'," +
             "'" + inputModel.WheelBase + "'," +
             "'" + inputModel.Weight + "'," +
             "'" + inputModel.WeightLimit + "'," +
             "'" + inputModel.Overweight + "'," +
             "'" + inputModel.AxleCount + "'," +
             "'" + inputModel.Plate + "'," +
             "'" + inputModel.PlateConfidence + "'," +
             "'" + inputModel.PlateValid + "'," +
             "'" + inputModel.PlateRearConfidence + "'," +
             "'" + inputModel.PlateRearValid + "'," +
             "'" + inputModel.CountryCode + "'," +
             //"'" + inputModel.CountrySubdivisionCode + "'," +
             "'" + inputModel.CountryConfidence + "'," +
             "'" + inputModel.AdrFrontEmpty + "'," +
             "'" + inputModel.AdrFrontKemler + "'," +
             "'" + inputModel.AdrFrontUn + "'," +
             "'" + inputModel.AdrFrontConfidence + "'," +
             "'" + inputModel.AdrRearEmpty + "'," +
             "'" + inputModel.AdrRearKemler + "'," +
             "'" + inputModel.AdrRearUn + "'," +
             "'" + inputModel.AdrRearConfidence + "'," +
             "'" + inputModel.IsOverweightGross + "'," +
             "'" + inputModel.IsOverweightPartial + "'," +
             "'" + inputModel.IsExceededLength + "'," +
             "'" + inputModel.IsExceededWidth + "'," +
             "'" + inputModel.IsExceededHeight + "'," +
             "'" + inputModel.IsOverspeed + "'," +
             "'" + inputModel.IsWrongDirection + "'," +
             "'" + inputModel.IsNonStandard + "'," +
             "'" + inputModel.OperatingRangeExceededSpeed + "'," +
             "'" + inputModel.OperatingRangeExceededWeight + "'," +
             "'" + inputModel.Divert + "'," +
             "'" + inputModel.Diverted + "');";             
        }

        private string StrAxel(AxleContainer a, long IP)
        {
            return "INSERT INTO axlecontainer(id, "
                  + "   parentid, "
                  + "   platformid, "
                  + "   componentid, "
                  + "   softwareversion, "
                  + "   created, "
                  + "   `index`, "
                  + "   unit, "
                  + "   `group`, "
                  + "   `position`, "
                  + "   weight, "
                  + "   weightleft, "
                  + "   weightright, "
                  + "   weightlimit, "
                  + "   wheelcount, "
                  + "   isoverweight, "
                  + "   speed, "
                  + "   credence, "
                  + "   measurementstatus," +
                  "idpr) "
                  + "  VALUES(" +
              "'" + a.ID + "'," +
              "'" + a.CreatedBy.ID + "'," +
              "'" + a.CreatedBy.PlatformId + "'," +
              "'" + a.CreatedBy.BGuidType + "'," +
              "'" + a.CreatedBy.KeyMark + "'," +
              "'" + a.Created + "'," +
              "'" + a.Index + "'," +
              "'" + a.Unit + "'," +
              "'" + a.Group + "'," +
              "'" + a.Position + "'," +
              "'" + a.Weight + "'," +
              "'" + a.WeightLeft + "'," +
              "'" + a.WeightRight + "'," +
              "'" + a.WeightLimit + "'," +
              "'" + a.WheelCount + "'," +
              "'" + a.IsOverweight + "'," +
              "'" + a.Speed + "'," +
              "'" + a.Credence + "'," +
              "'" + a.MeasurementStatus + "', " +
              "" + IP + ");";
        }
        private string StrBinry(BinaryContainer b, long IP)
        {
            return "INSERT INTO binarycontainer(id, "
                    + "platformid, "
                    + "BGuidType, "
                    + "KeyMark, "
                    + "CBID, "
                    + "created, "
                 //   + "signature, "
                    + "binarytype, "
                    + "name, "
                    + "length, "
                    + "dataavailable, "
                     + "ID_PR) "
                     + "VALUES('" + b.ID + "', " +
                 "'" + b.CreatedBy.PlatformId + "', " +
                 "" + b.CreatedBy.BGuidType + "," +
                 "" + b.CreatedBy.KeyMark + "," +
                 "'" + b.CreatedBy.ID + "'," +
                 "'" + b.Created + "'," +
                // "'" + b.Captions.ToString() + "'," +
                 "'" + b.BinaryType + "'," +
                 "'" + b.Name + "'," +
                 "" + b.Length + "," +
                 "'" + Convert.ToBase64String(b.Data) + "'," +
                 "" + IP + ");";
        }

        private string StrBinryN(BinaryContainer b, long IP, string BS)
        {
            return "INSERT INTO binarycontainer_n(id, "
                    + "platformid, "
                    + "BGuidType, "
                    + "KeyMark, "
                    + "CBID, "
                    + "created, "
                   // + "signature, "
                    + "binarytype, "
                    + "name, "
                    + "length, "
                    + "dataavailable, "
                     + "ID_PR) "
                     + "VALUES(" + b.ID + ", " +
                 "'" + b.CreatedBy.PlatformId + "', " +
                 "" + b.CreatedBy.BGuidType + "," +
                 "" + b.CreatedBy.KeyMark + "," +
                 "'" + b.CreatedBy.ID + "'," +
                 "'" + b.Created + "'," +
                // "'" + b.Captions.ToString() + "'," +
                 "'" + b.BinaryType + "'," +
                 "'" + b.Name + "'," +
                 "" + b.Length + "," +
                 "'" + BS + "'," +
                 "" + IP + ");";
        }
        private string StrPROEZD(VehicleContainer inputModel, long IP)
        {
            double Ll = 0;double LL=0; double LA=0;
            if (inputModel.LocationLatitude != "NaN")
            { Ll = Convert.ToDouble(inputModel.LocationLatitude); }
            else { Ll = 0; }
            if (inputModel.LocationLongitude != "NaN" )
            { LL = Convert.ToDouble(inputModel.LocationLongitude); }
            else { LL = 0; }
            if (inputModel.LocationAltitude != "NaN")
            { LA = Convert.ToDouble(inputModel.LocationAltitude); }
            else { LA = 0; }
            
            //if ( inputModel.LocationLatitude. != null)
            //         //"" + inputModel.LocationLongitude + ", " +
            //         //"" + inputModel.LocationAltitude + ", " +)
            //{ }
            return "INSERT INTO vehiclecontainer_r ("
                    + "ParentType, "
                    + " ParentID, "
                    + " PlatformId, "
                    + " ComponentId, "
                    + " Created, "
                    + " Checksum, "
                    + " Captions, "
                    + " Credence, "
                    + " CredenceExceeded, "
                    + " Lane, "
                    + " Direction, "
                    + " Speed, "
                    + " SpeedDifference, "
                    + " Length, "
                    + " Width, "
                    + " Height, "
                    + " PositionLeft, "
                    + " PositionRight, "
                    + " ClassScheme, "
                    + " Class, "
                    + " ClassScheme2, "
                    + " Class2, "
                    + " ClassScheme3, "
                    + " Class3, "
                    + " Units, "
                    + " WheelBase, "
                    + " Weight, "
                    + " WeightLimit, "
                    + " Overweight, "
                    + " AxleCount, "
                    + " Plate, "
                    + " PlateConfidence, "
                    + " PlateValid, "
                    + " PlateRear, "
                    + " PlateRearConfidence, "
                    + " Country, "
                     + " CountryConfidence, "
                    + " AdrFrontEmpty, "
                    + " AdrFrontKemler, "
                    + " AdrFrontUn, "
                    + " AdrFrontConfidence, "
                    + " AdrRearEmpty, "
                    + " AdrRearKemler, "
                    + " AdrRearUn, "
                    + " AdrRearConfidence, "
                    + " IsOverweightGross, "
                    + " IsOverweightPartial, "
                     + " IsExceededLength, "
                    + " IsExceededWidth, "
                    + " IsExceededHeight, "
                    + " IsOverspeed, "
                    + " IsWrongDirection, "
                    + " IsNonStandard, "
                    + " OperatingRangeExceededSpeed, "
                    + " OperatingRangeExceededWeight, "
                    + " Divert, "
                    + " Diverted, "
                    + " ID_wim, "
                    + " VehicleTypeName, "
                    + " IDVStup, " +
                    " LocationLatitude, " +
                    " LocationLongitude, " +
                    " LocationAltitude, " +
                    "IsOverweightGroup )" 
                    + " VALUES(" +
                     "" + Convert.ToInt32(inputModel.CreatedBy.BGuidType) + ", " +
                     "" + Convert.ToInt32(inputModel.CreatedBy.KeyMark) + ", " +
                     "" + Convert.ToInt64(inputModel.CreatedBy.PlatformId) + ", " +
                     "" + Convert.ToInt64(inputModel.CreatedBy.ID) + ", " +
                     "REPLACE(REPLACE(REPLACE(REPLACE('" + inputModel.Created.ToString("u") + "','-',''),' ',''),':',''),'Z',''), " +
                     "'" + bit(Convert.ToString(inputModel.Checksum), 10,16) + "', " +
                     "'" + inputModel.Captions[0] + "', " +
                     "" + inputModel.Credence + ", " +
                     "" + inputModel.CodeInt + ", " +//CredenceExceeded
                     "" + inputModel.LaneNumber + ", " +
                     "" + Convert.ToInt16(inputModel.Direction) + ", " +
                     "" + inputModel.Speed + ", " +
                     "" + inputModel.SpeedDifference + ", " +
                     "" + inputModel.Length + ", " +
                     "" + inputModel.Width + ", " +
                     "" + inputModel.Height + ", " +
                     "" + inputModel.PositionLeft + ", " +
                     "" + inputModel.PositionRight + ", " +
                     "'" + KlSch[1] + "', " +//inputModel.Classification.Where(s=>s.Schema=="EUR13").FirstOrDefault()?.Schema ?? "No" 
                     "" + Convert.ToInt32(KlSch[0]) + ", " +
                      "'" + KlSch[3] + "', " +//inputModel.Classification.Where(s=>s.Schema=="EUR13").FirstOrDefault()?.Schema ?? "No" 
                     "" + Convert.ToInt32(KlSch[2]) + ", " +
                     "" + co + ", " +
                     "(SELECT MAX(binarycontainer_n.id) AS expr1 FROM binarycontainer_n WHERE binarycontainer_n.ID_PR = " + IP + " GROUP BY binarycontainer_n.ID_PR), " +
                     //"'" + KlSch[3] ??"" + "', " +
                     //"" + Convert.ToInt32(KlSch[2]) ?? 0 + ", " +
                     "" + inputModel.Units + ", " +
                     "" + inputModel.WheelBase + ", " +
                     "" + inputModel.Weight + ", " +
                     "" + inputModel.WeightLimit + ", " +
                     "" + inputModel.Overweight + ", " +
                     "" + inputModel.AxleCount + ", " +
                     "'" + inputModel.Plate + "', " +
                     "" + inputModel.PlateConfidence + ", " +
                     "'" + inputModel.PlateValid.ToString() + "', " +
                     "'" + inputModel.PlateRear + "', " +
                     "" + inputModel.PlateRearConfidence + ", " +
                     "'" + inputModel.CountryCode + "', " +
                     "" + inputModel.CountryConfidence + ", " +
                     "" + inputModel.AdrFrontEmpty + ", " +
                     "'" + inputModel.AdrFrontKemler + "', " +
                     "'" + inputModel.AdrFrontUn + "', " +
                     "" + inputModel.AdrFrontConfidence + ", " +
                     "" + inputModel.AdrRearEmpty + ", " +
                     "'" + inputModel.AdrRearKemler + "', " +
                     "'" + inputModel.AdrRearUn + "', " +
                     "" + inputModel.AdrRearConfidence + ", " +
                     "" + inputModel.IsOverweightGross + ", " +
                     "" + inputModel.IsOverweightPartial + ", " +
                     //"" + inputModel.Overweight + ", " +
                     "" + inputModel.IsExceededLength + ", " +
                     "" + inputModel.IsExceededWidth + ", " +
                     "" + inputModel.IsExceededHeight + ", " +
                     "" + inputModel.IsOverspeed + ", " +
                     "" + inputModel.IsWrongDirection + ", " +
                     "" + inputModel.IsNonStandard + ", " +
                     "" + inputModel.OperatingRangeExceededSpeed + ", " +
                     "" + inputModel.OperatingRangeExceededWeight + ", " +
                     "" + inputModel.Divert + ", " +
                     "" + inputModel.Diverted + ", " +
                     "" + IP + ", " +
                     "'" + inputModel.VehicleTypeName + "', " +
                     "" + 0 + ", " +
                     "" + Ll + ", " +
                     "" + LL + ", " +
                     "" + LA + ", " +
                     "" + inputModel.IsOverweightPartialGroup + "); ";

        }
        public string bit(String Число, Byte ОснованиеЧисла, Byte ОснованиеРезультата)
        {
            decimal dec;
            int m;
            int i;
            string str; decimal m1;
            int m2;
            byte[] m3;
            m3 = new byte[1];
            str = "";
            dec = 0;
            Число = Число.ToUpper();
            for (i = 0; i < Число.Length; i++)
            {
                m3 = Encoding.Default.GetBytes(Число.Substring(i, 1));
                m = Convert.ToInt32(m3[0]);
                m = m - 48;
                if (m > 9) { m = m - 7; }
                dec = Convert.ToDecimal(dec * ОснованиеЧисла + m);// 'max Decimal = "79228162514264337593543950335"
            }

            while (dec > 0)
            {
                m1 = dec - (ОснованиеРезультата * Math.Truncate(dec / ОснованиеРезультата)) + 48;
                m2 = Convert.ToInt32(m1);
                if (m2 > 57) { m2 = m2 + 7; }
                m3[0] = (Byte)m2;
                dec = Math.Truncate(dec / ОснованиеРезультата);
                str = Convert.ToString((char)m3[0]) + str;
            }
            return str;
        }
        public System.DrawingCore.Bitmap byteArrayToImage(byte[] byteArrayIn)
        {

            ImageConverter ic = new ImageConverter();
            Image img = (Image)ic.ConvertFrom(byteArrayIn);
            Bitmap bitmap1 = new Bitmap(img);
            return bitmap1;

            //  using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            // {

            //   return System.DrawingCore.image.FromStream(mStream);


            // }


        }
        //public video Bytes2Video(byte[] bytBytes2Convert)
        //{
        //    string strTempFile = Path.GetTempPath() + "MyTempFile.wmv";
        //    File.WriteAllBytes(strTempFile, bytBytes2Convert);
        //    Video vidConvertedVideo = Video.FromFile(strTempFile);
        //    DeleteTempFile(strTempFile);

        //    return vidConvertedVideo;
        //}


    }
}
