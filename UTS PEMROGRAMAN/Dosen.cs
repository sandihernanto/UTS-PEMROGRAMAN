using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PEMROGRAMAN
{
   
    internal class Dosen
    {
        public int id { get; set; } 
        public string nama { get; set; }    
        public int NIK { get; set; }    
        public string gender { get; set; }  
        public string course { get; set; }

        public void Dosenn()
        {
            Console.WriteLine(" ID     : {0} ", id); 

            Console.WriteLine(" Nama   : {0} ", nama);

            Console.WriteLine(" NIK    : {0} ", NIK);

            Console.WriteLine(" Gender : {0} ", gender);

            Console.WriteLine(" Course : {0} ", course);
            Console.WriteLine();
        }

        public void attDosen()
           
        {
           
            Console.WriteLine(" Penambahana nama dosen dan NIK dosen  ");
            Console.Write(" Masukkan Nama = ");
            string nama = Console.ReadLine();
            Console.Write(" Masukkan NIK  = ");
            int NIK=Console.Read();
            

            }
            
        public void addCourse()
        {
            Console.WriteLine(" Penambahan Matkul ");
            Console.Write(" Mata Kuliah   = ");
            string course = Console.ReadLine();
            Console.ReadLine();
            
        }
       
    }
}
