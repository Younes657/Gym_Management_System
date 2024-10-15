using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_system_app
{
    internal class Product
    {
        private decimal? WEI;
        private string CO;
        private byte[] im;
        public int Id { get; set; }
        public string NameP { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public decimal? Weight {
            get 
            {
                if (WEI is null) return 0;
                else return WEI;
            } set 
            {
                WEI = value;
            } }
        public byte[] image 
        { 
            get {
                if (im == null) return null;
                else return im;
            } set { 
                im = value;
            } 
        }
        public string Country { 
            get
            {
                if (CO == "") return "unknown";
                else return CO;
            }
            set
            {
                CO = value;
            }
        }
          
    }
}
