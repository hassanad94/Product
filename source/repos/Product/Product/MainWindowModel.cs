using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Product
{
    class MainWindowModel: BaseModel
    {
        public ObservableCollection<Product> Product { get; set; }


    }
}
