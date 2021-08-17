using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Cars
    {
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Cars()
        {
        }
        public Cars(string model, int year) {
            this.model = model;
            this.year = year;
         }

    }
}
