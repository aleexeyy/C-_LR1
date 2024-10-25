// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace FractionWork {
//     public class Fraction: IFraction {
//         public int Numerator { get; set; }

//         private int _denominator;
//         public int Denominator {
//                 get => _denominator;
//                 set => _denominator = value == 0 ? throw new ArgumentOutOfRangeException("Denominator can't be equal 0") : value;
//             }

//         public Fraction(int num, int denom) {
//             throw new NotImplementedException();
//         }
//         public Fraction() {
//             throw new NotImplementedException();
//         }
//         private int NOD(int num1, int num2) {
            
//             int a = Math.Min(num1, num2);
//             int b = Math.Max(num1, num2);

//             while (true) {
//                 int remainder = b % a;
//                 if (remainder == 0) {
//                     return a;
//                 }
//                 b = a;
//                 a = remainder;
//             }
//         }
//         private int NOK(IFraction fraction) {
//             return (Denominator*fraction.Denominator) / NOD(Denominator, fraction.Denominator);
//         }
//         private void simplify() {
//             int nod = NOD(Math.Abs(Numerator), Math.Abs(Denominator));
//             Numerator /= nod;
//             Denominator /= nod;
//         }

//         public void add(IFraction fraction) {
//             throw new NotImplementedException();
//         }
//         public void sub(IFraction fraction) {
//             throw new NotImplementedException();
//         }
//         public void mul(IFraction fraction) {
//             throw new NotImplementedException();
//         }
//         public void div(IFraction fraction) {
//             throw new NotImplementedException();
//         }

//         public void subByInt(int num) {
//             throw new NotImplementedException();
//         }
//         public void mulByInt(int num) {
//             throw new NotImplementedException();
//         }

//         public bool equal(IFraction fraction) {
//             throw new NotImplementedException();
//         }

//         public override string ToString() {
//             return String.Format("Numerator - %f, Denominator - %f", Numerator, Denominator);
//         }
//     }
// }