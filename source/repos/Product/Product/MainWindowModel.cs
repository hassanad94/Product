using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Product
{
    class MainWindowModel : BaseModel
    {
        public ObservableCollection<Product> Product { get; set; }

        public MainWindowModel() {
            Product = new ObservableCollection<Product> {
                new Product{Name = "Kecske", Price=10, Quantity=100 },
                new Product {Name = "Káposzta", Price=7, Quantity=100 }
            };

        }
  

    }
}
