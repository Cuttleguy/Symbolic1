// See https://aka.ms/new-console-template for more information
using Symbolic1;
using System.Globalization;
using System.Numerics;
using Fraction = Symbolic1.Rational<double>;
/*
Console.WriteLine("Hello, World!");
*//*Console.WriteLine(new Fraction(1.0 / 3.0, 16).ToDouble());*//*
Console.WriteLine(new Fraction(3, 4)== new Fraction(3, 4));
Console.WriteLine(new Complex<Fraction>(new Fraction(3, 4), new Fraction(-2, 3)));*/
Vector3<double> point = new Vector3<double>(3, 4, 5);
Quaternion<double> transformation = Quaternion<double>.FromRotationAroundVectorPi(1.0/2.0, Vector3<double>.ihat);
/*Console.WriteLine(transformation);
Console.WriteLine(transformation.Invert());*/
Vector3<double> newPoint = Vector3<double>.Round((transformation * point * transformation.Invert()).ExtractVector(),4);
Console.WriteLine(newPoint);
/*Console.WriteLine(Quaternion<double>.I*point);
*//*Console.WriteLine(new Complex<NumericRational<double>>(new Rational<double>(3, 4), new Rational<double>(3, 4)));*/