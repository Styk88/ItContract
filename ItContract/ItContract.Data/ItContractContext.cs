using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItContract.Data
{
    public class ItContractContext :  DbContext
    {
        public ItContractContext() : base("ItContractConnectionString")
        {
        }
    }
}
