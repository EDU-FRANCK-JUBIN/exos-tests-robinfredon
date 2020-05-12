using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebugNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice;

namespace UnitTestProject1
{
  [TestClass]
  public class ClasseChaineUT
  {
    private static String resultatGood, resultatBad;
    private static Users userGood, userBadShort, userBadLong;
    private static ClasseChaine classeChaine;


    [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
      Console.WriteLine("Class Initialize start!");
      userGood = new Users("Franck Jubin",30);
      userBadShort = new Users("Franck", 30);
      userBadLong = new Users("Franck Jubin Senior", 30);
      resultatGood = "F.J.";
      resultatBad = "";
      classeChaine = new Exercice.ClasseChaine();
      Console.WriteLine("Class Initialize end!");
    }

    [TestMethod]
    public void TestMethodGood()
    {
      Assert.AreEqual(resultatGood, classeChaine.RetourneInitiales(userGood.Nom));
    }

    [TestMethod]
    public void TestMethodShort()
    {
      Assert.AreEqual(resultatBad, classeChaine.RetourneInitiales(userBadShort.Nom));
    }

    [TestMethod]
    public void TestMethodEmpty()
    {
      Assert.AreEqual(resultatBad, classeChaine.RetourneInitiales(""));
    }

    [TestMethod]
    public void TestMethodLong()
    {
      Assert.AreEqual(resultatBad, classeChaine.RetourneInitiales(userBadLong.Nom));
    }
  }
}
