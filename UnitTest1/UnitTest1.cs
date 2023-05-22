using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryMath9_14;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        //тригонометрия
        //синус
        [TestMethod]
        public void num10num5sin2()
        {
            double num1 = 10;
            double num2 = 5;
            double disc = 2;

            num1 = LibraryMath9_14.TrigonometriaClass.Sin(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num153num6sin255()
        {
            double num1 = 153;
            int num2 = 6;
            double disc = 25.5;

            num1 = LibraryMath9_14.TrigonometriaClass.Sin(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num4num0sinNULL()
        {
            double num1 = -4;
            double num2 = 0;
            double disc = double.NegativeInfinity;

            num1 = LibraryMath9_14.TrigonometriaClass.Sin(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num0num4sin0()
        {
            double num1 = 0;
            double num2 = -4;
            double disc = 0;

            num1 = LibraryMath9_14.TrigonometriaClass.Sin(num1, num2);
            Assert.AreEqual(num1, disc);
        }

        //косинус
        [TestMethod]
        public void num3num2cos15()
        {
            double num1 = -3;
            double num2 = 2;
            double disc = -1.5;

            num1 = LibraryMath9_14.TrigonometriaClass.Cos(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num256num65cos393()
        {
            double num1 = 256;
            double num2 = -65;
            double disc = -3.93;

            num1 = LibraryMath9_14.TrigonometriaClass.Cos(num1, num2);
            Assert.AreEqual(num1, disc);
        }

        [TestMethod]
        public void num0num0cos0()
        {
            double num1 = 0;
            double num2 = 0;
            double disc = 0;

            num1 = LibraryMath9_14.TrigonometriaClass.Cos(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num0num2cos0()
        {
            double num1 = 0;
            double num2 = 2;
            double disc = 0;

            num1 = LibraryMath9_14.TrigonometriaClass.Cos(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        //тангенс
        [TestMethod]
        public void num900num0tgNULL()
        {
            double num1 = -900;
            double num2 = 0;
            double disc = double.NegativeInfinity;

            num1 = LibraryMath9_14.TrigonometriaClass.Tg(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num0num0tg0()
        {
            double num1 = 0;
            double num2 = 0;
            double disc = 0;

            num1 = LibraryMath9_14.TrigonometriaClass.Tg(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num0num20tg0()
        {
            double num1 = 0;
            double num2 = -20;
            double disc = 0;

            num1 = LibraryMath9_14.TrigonometriaClass.Tg(num1, num2);
            Assert.AreEqual(num1, disc);
        }

        //котангенс
        [TestMethod]
        public void num33num33ctg1()
        {
            double num1 = 33;
            double num2 = 33;
            double disc = 1;

            num1 = LibraryMath9_14.TrigonometriaClass.Ctg(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num200num0ctgNULL()
        {
            double num1 = -200;
            double num2 = 0;
            double disc = double.NegativeInfinity;

            num1 = LibraryMath9_14.TrigonometriaClass.Ctg(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num33num0ctg0()
        {
            double num1 = -33;
            double num2 = 0;
            double disc = 0;

            num1 = LibraryMath9_14.TrigonometriaClass.Ctg(num1, num2);
            Assert.AreEqual(num1, disc);
        }




        [TestMethod]
        //Сумма
        public void arr0310503summ17()
        {
            double[] arr = { 0, 3, -10, 5, 0.3 };
            double summ = -1.7;

            double res = LibraryMath9_14.AlgebraClass.Summ(arr);
            Assert.AreEqual(res, summ);
        }
        [TestMethod]
        public void arr10937summ29()
        {
            double[] arr = { -10, -9, -3, -7 };
            double summ = -29;

            double res = LibraryMath9_14.AlgebraClass.Summ(arr);
            Assert.AreEqual(res, summ);
        }
        [TestMethod]
        public void arr033330451087500103001summ195494()
        {
            double[] arr = { 0.3333, 3.045, 10.87, 5.001, 0.3001 };
            double summ = 19.5494;

            double res = LibraryMath9_14.AlgebraClass.Summ(arr);
            Assert.AreEqual(res, summ);
        }
        //Максимальное значение
        [TestMethod]
        public void arr13500100max5()
        {
            double[] arr = { -1,3,5,0,0,-100};
            double max = 5;

            double res = LibraryMath9_14.AlgebraClass.Max(arr);
            Assert.AreEqual(res, max);
        }

        [TestMethod]
        public void arr1353013140max1()
        {
            double[] arr = { -1, -3, -5, -30, -13, -140 };
            double max = -1;

            double res = LibraryMath9_14.AlgebraClass.Max(arr);
            Assert.AreEqual(res, max);
        }

        [TestMethod]
        public void arr13355645100max13()
        {
            double[] arr = { -1.3, -3.5, -5.6, -4.5, -100 };
            double max = -1.3;

            double res = LibraryMath9_14.AlgebraClass.Max(arr);
            Assert.AreEqual(res, max);
        }
        //Минимальное значение
        [TestMethod]
        public void arrmin()
        {
            double[] arr = { };
            double min = 0;

            double res = LibraryMath9_14.AlgebraClass.Min(arr);
            Assert.AreEqual(res, min);
        }
        [TestMethod]
        public void arr13355645100min100()
        {
            double[] arr = { -1.3, -3.5, -5.6, -4.5, -100 };
            double min = -100;

            double res = LibraryMath9_14.AlgebraClass.Min(arr);
            Assert.AreEqual(res, min);
        }
        [TestMethod]
        public void arr13355645241min56()
        {
            double[] arr = { -13, 3.5, -56, 4.5, 241 };
            double min = -56;

            double res = LibraryMath9_14.AlgebraClass.Min(arr);
            Assert.AreEqual(res, min);
        }
        //Среднее значение
        [TestMethod]
        public void arr13355645100sr2298()
        {
            double[] arr = { -1.3, -3.5, -5.6, -4.5, -100 };
            double sr = -22.98;

            double res = LibraryMath9_14.AlgebraClass.Sred(arr);
            Assert.AreEqual(res, sr);
        }
        [TestMethod]
        public void arrsr()
        {
            double[] arr = { };
            double sr = 0;

            double res = LibraryMath9_14.AlgebraClass.Sred(arr);
            Assert.AreEqual(res, sr);
        }
        [TestMethod]
        public void arr164564sr1275()
        {
            double[] arr = {1,6,4.5,-6.4 };
            double sr = 1.275;

            double res = LibraryMath9_14.AlgebraClass.Sred(arr);
            Assert.AreEqual(res, sr);
        }


        //площадь квадрата
        [TestMethod]
        public void num3disc9()
        {
            double num1 = 3;
            double disc = 9;

            num1 = LibraryMath9_14.GeometryClass.kvadrat(num1);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num15disc225()
        {
            double num1 = -1.5;
            double disc = 2.25;

            num1 = LibraryMath9_14.GeometryClass.kvadrat(num1);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num0disc0()
        {
            double num1 = 0;
            double disc = 0;

            num1 = LibraryMath9_14.GeometryClass.kvadrat(num1);
            Assert.AreEqual(num1, disc);
        }
        //площадь прямоугольника
        [TestMethod]
        public void num15num17disc255()
        {
            double num1 = -1.5;
            double num2 = -1.7;
            double disc = 2.55;

            num1 = LibraryMath9_14.GeometryClass.pryamoygolnic(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num3num4disc12()
        {
            double num1 = 3;
            double num2 = 4;
            double disc = 12;

            num1 = LibraryMath9_14.GeometryClass.pryamoygolnic(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num5num9disc45()
        {
            double num1 = -5;
            double num2 = 9;
            double disc = -45;

            num1 = LibraryMath9_14.GeometryClass.pryamoygolnic(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        //круг
        [TestMethod]
        public void num17disc5338()
        {
            double num1 = -1.5;
            double disc = 53.38;

            num1 = LibraryMath9_14.GeometryClass.Circle(num1);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num0discNULL()
        {
            double num1 = 0;
            double disc = double.NegativeInfinity;

            num1 = LibraryMath9_14.GeometryClass.Circle(num1);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num33disc10362()
        {
            double num1 = 33;
            double disc = 103.62;

            num1 = LibraryMath9_14.GeometryClass.Circle(num1);
            Assert.AreEqual(num1, disc);
        }
        //ромб
        [TestMethod]
        public void num0num0disc0()
        {
            double num1 = 0;
            double num2 = 0;
            double disc = 0;

            num1 = LibraryMath9_14.GeometryClass.Romb(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num50num20disc500()
        {
            double num1 = 50;
            double num2 = 20;
            double disc = 500;

            num1 = LibraryMath9_14.GeometryClass.Romb(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num10num20disc500()
        {
            double num1 = -10;
            double num2 = 20;
            double disc = -200;

            num1 = LibraryMath9_14.GeometryClass.Romb(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num0num20disc0()
        {
            double num1 = 0;
            double num2 = 20;
            double disc = 0;

            num1 = LibraryMath9_14.GeometryClass.Romb(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        //треугольник
        [TestMethod]
        public void num1num0disc0()
        {
            double num1 = -1;
            double num2 = 0;
            double disc = 0;

            num1 = LibraryMath9_14.GeometryClass.treygolnic(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num3num5disc75()
        {
            double num1 = 3;
            double num2 = 5;
            double disc = 7.5;

            num1 = LibraryMath9_14.GeometryClass.treygolnic(num1, num2);
            Assert.AreEqual(num1, disc);
        }
        [TestMethod]
        public void num33num5disc825()
        {
            double num1 = 3.3;
            double num2 = -5;
            double disc = -8.25;

            num1 = LibraryMath9_14.GeometryClass.treygolnic(num1, num2);
            Assert.AreEqual(num1, disc);
        }
    }
    
    
}
