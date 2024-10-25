using FractionWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FractionWorkTest {

    [TestClass]
    public class FractionTest {

        // Test case: Creating a fraction with a zero denominator should throw an exception.
        [TestMethod]
        public void FractionCreation_ZeroDenominator_ThrowsException() {
            int numerator = 1;
            int denominator = 0;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Fraction(numerator, denominator));
        }

        // Test case: Creating a fraction with valid numerator and denominator.
        [TestMethod]
        public void FractionCreation_ValidInput_CreatesCorrectFraction() {
            int numerator = 0;
            int denominator = 4;
            Fraction fraction = new Fraction();

            fraction.Numerator = numerator;
            fraction.Denominator = denominator;

            Assert.AreEqual(numerator, fraction.Numerator);
            Assert.AreEqual(denominator, fraction.Denominator);
        }

        // Test case: Adding two fractions with a common denominator and simplifying.
        [TestMethod]
        public void AddFractions_ValidInput_AddsAndSimplifies() {
            Fraction fraction1 = new Fraction(1, 4);
            Fraction fraction2 = new Fraction(1, 4);

            fraction1.add(fraction2);

            Assert.AreEqual(1, fraction1.Numerator);
            Assert.AreEqual(2, fraction1.Denominator);
        }

        // Test case: Adding two fractions with different denominators and simplifying the result.
        [TestMethod]
        public void AddFractions_ValidInput_CommonDenominatorAndAdd() {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(5, 6);

            fraction1.add(fraction2);

            Assert.AreEqual(19, fraction1.Numerator);
            Assert.AreEqual(12, fraction1.Denominator);
        }

        // Test case: Subtracting two fractions and simplifying the result.
        [TestMethod]
        public void SubtractFractions_ValidInput_SubtractAndSimplify() {
            Fraction fraction1 = new Fraction(5, 6);
            Fraction fraction2 = new Fraction(7, 6);

            fraction1.sub(fraction2);

            Assert.AreEqual(-1, fraction1.Numerator);
            Assert.AreEqual(3, fraction1.Denominator);
        }

        // Test case: Multiplying two fractions and simplifying the result.
        [TestMethod]
        public void MultiplyFractions_ValidInput_MultiplyAndSimplify() {
            Fraction fraction1 = new Fraction(2, 3);
            Fraction fraction2 = new Fraction(3, 4);

            fraction1.mul(fraction2);

            Assert.AreEqual(1, fraction1.Numerator);
            Assert.AreEqual(2, fraction1.Denominator);
        }

        // Test case: Dividing one fraction by another and simplifying the result.
        [TestMethod]
        public void DivideFractions_ValidInput_DivideAndSimplify() {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(2, 5);

            fraction1.div(fraction2);

            Assert.AreEqual(15, fraction1.Numerator);
            Assert.AreEqual(8, fraction1.Denominator);
        }

        // Test case: Comparing two equal fractions should return true.
        [TestMethod]
        public void CompareFractions_EqualFractions_CompareAndReturn() {
            Fraction fraction1 = new Fraction(2, 3);
            Fraction fraction2 = new Fraction(4, 6);

            bool isEqual = fraction1.equal(fraction2);

            Assert.IsTrue(isEqual);
        }

        // Test case: Comparing two unequal fractions should return false.
        [TestMethod]
        public void CompareFractions_NotEqualFractions_CompareAndReturn() {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(2, 3);

            bool isEqual = fraction1.equal(fraction2);

            Assert.IsFalse(isEqual);
        }

        // Test case: Multiplying a fraction by an integer and simplifying the result.
        [TestMethod]
        public void MultiplyFraction_ValidInput_MultiplyByIntegerAndSimplify() {
            Fraction fraction = new Fraction(3, 5);
            int multiplier = 10;

            fraction.mulByInt(multiplier);

            Assert.AreEqual(6, fraction.Numerator);
            Assert.AreEqual(1, fraction.Denominator);
        }

        // Test case: Subtracting an integer from a fraction and simplifying the result.
        [TestMethod]
        public void SubtractFraction_ValidInput_SubtractByIntegerAndSimplify() {
            Fraction fraction = new Fraction(7, 3);
            int integerToSubtract = 1;

            fraction.subByInt(integerToSubtract);

            Assert.AreEqual(4, fraction.Numerator);
            Assert.AreEqual(3, fraction.Denominator);
        }
    }
}
