using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionWork {
    public interface IFraction {
        int Numerator { get; set; }
        int Denominator {get; set; }

        void add(IFraction fraction);

        void sub(IFraction fraction);
        void mul(IFraction fraction);
        void div(IFraction fraction);
        bool equal(IFraction fraction);
        void mulByInt(int num);
        void subByInt(int num);

    }

}