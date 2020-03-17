using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdemo1.Models
{
    public class Emp
    {
        int empno;
        string ename;
        double salary;

        public int Empno { get => empno; set => empno = value; }
        public string Ename { get => ename; set => ename = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}