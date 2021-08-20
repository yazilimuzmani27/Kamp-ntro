using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }   //bu veriyi anlatan ana anahtardır tc no gibi categoryId ise ikinci referans tipidir.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        
        // Bu tip classlarda sadece özellik olur.
    }
}
