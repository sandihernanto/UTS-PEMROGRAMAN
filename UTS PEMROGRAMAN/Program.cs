using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PEMROGRAMAN
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Dosen dosen = new Dosen();

            //pengesetan nilai properties
            dosen.id = 1234567 ;
            dosen.nama = "Kamarudin, M.Kom";
            dosen.NIK = 2345432;
            dosen.gender = "Laki-laki";
            dosen.course = "Pemrograman";

            //pemanggilan method
            dosen.Dosenn();
            dosen.attDosen();
            dosen.addCourse();

            Console.ReadKey();
        }
    }
}
