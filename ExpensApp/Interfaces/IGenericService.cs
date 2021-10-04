using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGenericService<T>
    {
        void Add(T entity);

        //Getting expense from ID of the form that have this expense.
        T Get(int FormID);

        //Listing all expenses
        List<T> List();

        //Updating existing expense
        int Update(T entity);

        IEnumerable<T> Select(Expression<Func<T, bool>> Filter = null);
    }
}
