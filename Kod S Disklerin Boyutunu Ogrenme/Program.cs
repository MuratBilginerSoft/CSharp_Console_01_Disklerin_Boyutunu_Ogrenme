using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kod_S_Disklerin_Boyutunu_Ogrenme
{
    class Program
    {
        public enum Boyutlar
        {
            bytee
        }

        static void Main(string[] args)
        {
            foreach (DriveInfo disk in DriveInfo.GetDrives())
            {
                Console.WriteLine("Disk: {0}", disk.Name);

                if (disk.IsReady)
                {
                    Console.WriteLine("Toplam Alan:\t\t{0}", disk.TotalSize.ToString());

                    Console.WriteLine("Boş Alan Miktarı:\t{0}", disk.AvailableFreeSpace.ToString());
                }
                Console.WriteLine("**********");
            }

            Console.ReadLine();

        }
        public string frm(long DosyaBoyutu)
        {
            Boyutlar BoyutTanim = Boyutlar.bytee;

            while (Math.Round((decimal)DosyaBoyutu) >= 1000)
            {
                DosyaBoyutu /= 1024;

                BoyutTanim++;
            }

            return string.Format("{0}\t{1}", DosyaBoyutu.ToString("f2"), BoyutTanim);
        }
   
    }
}
