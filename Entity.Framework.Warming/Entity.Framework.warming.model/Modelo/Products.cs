using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Framework.warming.model.Modelo
{
    class Products : Product
    {

        public string ListPriceStr { get { return this.ListPrice.ToString(); }} 

        public int AntiquityInYears { get {
                return ((int)((DateTime.Now - this.SellStartDate).TotalDays));  }
        }


    }


    }

