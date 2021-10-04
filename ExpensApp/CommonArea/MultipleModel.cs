using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonArea
{
    public class MultipleModel
    {
        public ExpenseCommon expense { get; set; }
        public List<ExpenseCommon> list = new List<ExpenseCommon>();
    }
}
