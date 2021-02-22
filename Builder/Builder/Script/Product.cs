using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Script
{
    public class Product
    {
        public string partAType { get; private set; }
        public string partBType { get; private set; }

        public Product(string partAType, string partBType)
        {
            this.partAType = partAType;
            this.partBType = partBType;
        }

        public void Show() => Console.WriteLine($"product : \n  partA : {partAType} \n  partB : {partBType}");
    }
}
