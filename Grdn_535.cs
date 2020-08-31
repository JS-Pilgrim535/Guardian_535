using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;


namespace Lock_535
{
    public enum CharactersLimit { None, Five, Ten, Fifteen, Twenty, Twenty_Five, Thirty, Thirty_Five }
    public enum VisionAction { None, ApplicationExit, HibernatePC, Logout, Restart, TurnOffPC }
        
    public class Grdn_535
    {
        public string Soneto535(string PassWord, CharactersLimit Limitary)
        {
            MD5 CreaterMD5 = MD5.Create();
            byte[] Input = Encoding.ASCII.GetBytes(PassWord);
            byte[] Hash = CreaterMD5.ComputeHash(Input);

            StringBuilder StrBuilder = new StringBuilder();

            for (byte i = 0; i < Hash.Length; i++)
            {
                StrBuilder.Append(Hash[i].ToString("X2") + ".");
            }

            CreaterMD5.Dispose();

            string[] Splitter = StrBuilder.ToString().Split('.');
            StrBuilder = new StringBuilder();
            for (int i = Splitter.Length - 1; i >= 0; i--)
            {
                StrBuilder.Append(Splitter[i]);
            }

            char[] Alphanumerics = new char[] { 'Ç', 's', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'o', 'p', 'q', 'r', 't', 'u', 'v', 'w', 'x', 'Y', 'z', 'ç', 'Z', 'y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q', 'a', 'O', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'P', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char Seed = '0';

            foreach (char item in StrBuilder.ToString())
            {
                for (int i = 48; i < Alphanumerics.Length; i++)
                {
                    if (item == Alphanumerics[i])
                    {
                        Seed = item;
                        break;
                    }
                }
            }

            Random Rand = new Random(Convert.ToInt16(Seed) + 535);

            string Return = StrBuilder.ToString().Replace(Seed.ToString(), Rand.Next(0, Rand.Next(100)).ToString());

            Return = Return.Insert(Return.Length / 2, Alphanumerics[Rand.Next(0, 48)].ToString());
            Rand = new Random(Seed + Rand.Next(Seed, 535));
            Return = Return.Insert(Return.Length / 4, Alphanumerics[Rand.Next(0, 48)].ToString());

            Rand = new Random(Seed + Rand.Next(0, 535));

            string Substring = Return.Substring(Return.Length / 2, Rand.Next(10));
            Return = Return.Insert(Rand.Next(10), Substring);

            Rand = new Random(Rand.Next(Seed + 535) + Rand.Next(0, 535));
            Return = Return.Insert(Rand.Next(10), Alphanumerics[Rand.Next(48)].ToString());
            Return = Return.Insert(Rand.Next(Return.Length - 1), Alphanumerics[Rand.Next(48)].ToString());

            string Inserter = Return.Insert(5, ",");
            Inserter = Inserter.Insert(3, ",");
            Inserter = Inserter.Insert(5, ",");

            Splitter = Inserter.Split(',');
            Return = Splitter[2] + Splitter[3] + Splitter[1];

            Return = Return + "gfyr9r535hw3j795iJAJyer3 mklçsçpwca";

            if (Limitary == CharactersLimit.Thirty_Five) Return = Return.Substring(0, 35);
            else if (Limitary == CharactersLimit.Thirty) Return = Return.Substring(0, 30);
            else if (Limitary == CharactersLimit.Twenty_Five) Return = Return.Substring(0, 25);
            else if (Limitary == CharactersLimit.Twenty) Return = Return.Substring(0, 20);
            else if (Limitary == CharactersLimit.Fifteen) Return = Return.Substring(0, 15);
            else if (Limitary == CharactersLimit.Ten) Return = Return.Substring(0, 10);
            else if (Limitary == CharactersLimit.Five) Return = Return.Substring(0, 5);
            else Return.Substring(Return.LastIndexOf('g'));

            return Return;

//#Pilgrim_535
            //MataNkisi
            //Matano Nankisi João de Castro
        }

        byte NumbersOfTentatives = 0;

        public void Vision_535(byte Tentatives, VisionAction Action)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Cookies).ToString() + @"\Lock535.matankisi"))
            {
                StreamWriter FOTWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Cookies).ToString() + @"\Lock535.matankisi", false, Encoding.Default);
                FOTWriter.WriteLine("0");
                FOTWriter.Close();
                FOTWriter.Dispose();
            }

            StreamReader FOTReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Cookies).ToString() + @"\Lock535.matankisi", Encoding.Default);
            NumbersOfTentatives = Convert.ToByte(FOTReader.ReadLine());
            FOTReader.Close();
            FOTReader.Dispose();

            if (NumbersOfTentatives == 0)
            {
                StreamWriter FOTWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Cookies).ToString() + @"\Lock535.matankisi", false, Encoding.Default);
                FOTWriter.WriteLine(Tentatives);
                FOTWriter.Close();
                FOTWriter.Dispose();
            }
            else
            {
                --NumbersOfTentatives;
                StreamWriter FOTWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Cookies).ToString() + @"\Lock535.matankisi", false, Encoding.Default);
                FOTWriter.WriteLine(NumbersOfTentatives);
                FOTWriter.Close();
                FOTWriter.Dispose();

                if (NumbersOfTentatives == 0)
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Cookies).ToString() + @"\Lock535.matankisi");

                    if (Action == VisionAction.ApplicationExit) Application.Exit();
                    else if (Action == VisionAction.HibernatePC) Process.Start("Shutdown", "-h");
                    else if (Action == VisionAction.Logout) Process.Start("Shutdown", "-l");
                    else if (Action == VisionAction.Restart) Process.Start("Shutdown", "-g");
                    else if (Action == VisionAction.TurnOffPC) Process.Start("Shutdown", "-p");
                }
                //https://free.facebook.com/john.serg.10?refid=46&__xts__%5B0%5D=12.%7B%22unit_id_click_type%22%3A%22graph_search_results_item_tapped%22%2C%22click_type%22%3A%22result%22%2C%22module_id%22%3A4052%2C%22result_id%22%3A100007145015136%2C%22session_id%22%3A%222dfe5496ea4e1ed78176091271d3858e%22%2C%22module_role%22%3A%22ENTITY_USER%22%2C%22unit_id%22%3A%22browse_rl%3Ad66c05b4-c1f6-49f1-ab04-5ee7f6569797%22%2C%22browse_result_type%22%3A%22browse_type_user%22%2C%22unit_id_result_id%22%3A100007145015136%2C%22module_result_position%22%3A0%7D
            }
        }

        public void StopVisionAction() {
            Process.Start("Shutdown", "-a");
        }
    }
}
