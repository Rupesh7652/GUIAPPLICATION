using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUIAPPLICATION;
using System.Drawing;

namespace GUI.UnitTest
{
    [TestClass]
    public class RectangleTest
    {

        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;

        [TestMethod]
        public void TestMethod1()
        {
            var r = new GUIAPPLICATION.Rectangle();
            int x = 200, y = 200, size = 100, size1 = 100;
            r.set(texturestyle, bb, c1, x, y, size, size1);
            Assert.AreEqual(200, r.x);
        }
    }
}
