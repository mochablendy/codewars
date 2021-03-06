﻿using System;
using NUnit.Framework;

namespace codewars
{
    [TestFixture]
    public class YourOrderPleaseTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", Kata.Order("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", Kata.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.AreEqual("", Kata.Order(""));
        }
    }
}
