using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product 
{
   
    class Product : BaseModel
    {
        string _name;
        int _price;
        int _quantity;


        public string Name {

            get { return _name; }
            set {
                _name = value;
                OnPropertyChange();
            }
        }

        public int Price
        {
            get { return _price; }
            set {
                _price = value;
                    OnPropertyChange();
            }
        }

        public int Quantity {
            get { return _quantity; }
            set { _quantity = value;
                OnPropertyChange();
            }
        }

    }
}
