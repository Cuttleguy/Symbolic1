using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public interface IRemainderOperators<TSelf,TOther,TResult>
         where TSelf : IRemainderOperators<TSelf, TOther, TResult>?
    {
        public abstract static TResult operator %(TSelf left, TOther right);
        //public virtual static TResult operator checked %(TSelf left, TOther right);

    }

}
