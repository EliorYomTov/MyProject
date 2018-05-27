using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Logic
{
    public interface IIterator
    {
        bool IsDone { get; }

        object CurrentItem { get; }

        IEnumerable<object> NextItem { get; }

        void Reset();

        void Dispose();

        bool Next();
    }

    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
