/*using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class AngleMeasure<T>:INumberBase<AngleMeasure<T>>,IFloatingPointConstants<AngleMeasure<T>>
        where T : INumberBase<T>, IFloatingPointConstants<T>,IAdditionOperators<T,double,T>
    {
        public T constant;
        public Dictionary<T, T> powerToExponent=new Dictionary<T, T>();
        public AngleMeasure(T constant, Dictionary<T, T> powerToExponent)
        {
            this.constant = constant;
            this.powerToExponent = powerToExponent;
        }
        
        public AngleMeasure(T constant, T piValue)
        {
            this.constant = constant;
            this.powerToExponent.Add(T.One,piValue);
        }
        public T GetValue()
        {
            T toReturn = constant;
            foreach(T )
        }
    }
}
*/