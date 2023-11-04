using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_3
{
    internal class Person
    {
        public string CMND;
        public string HoTen;
        public string DiaChi;
        public Person() { }
        public Person(string cmnd, string hoten, string diachi)
        {
            this.CMND = cmnd;
            this.HoTen = hoten;
            this.DiaChi = diachi;
        }
    }
}
