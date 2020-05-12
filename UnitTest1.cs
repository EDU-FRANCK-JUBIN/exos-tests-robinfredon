using System;
using DebugNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Users user = new Users("Suresh Dasari", 30);
      user.GetUserDetails();
    }

    [TestMethod]
    public void TestMethod2()
    {
      Users user = new Users("Suresh Dasari", 30);
      Users user2 = new Users("Suresh Dasari", 31);
      Assert.AreNotEqual(user, user2);
    }
  }
}
