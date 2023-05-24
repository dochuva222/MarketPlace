using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Models
{
    public partial class Product
    {
        public string Fullname
        {
            get
            {
                return $"Name: {Name}, Price: {Price}";
            }
        }

        public byte[] MainPhoto
        {
            get
            {
                var firstPhoto = this.ProductPhoto.FirstOrDefault();
                if (firstPhoto != null)
                    return firstPhoto.Photo;
                return null;
            }
        }
    }
}
