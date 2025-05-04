using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин.Datagrid
{
    public class Spicok
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsSelected { get; set; }
        public string Foto {  get; set; }
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }


        //private bool choise;
        //public bool Choise
        //{
        //    get { return choise; }
        //    set { choise = value; }
        //}


    }
}
