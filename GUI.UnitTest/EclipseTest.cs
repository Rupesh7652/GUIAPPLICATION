using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using GUIAPPLICATION;

namespace GUI.UnitTest
{
    [TestClass]
    public class EclipseTest
    {
       
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Circle();
            int x = 200, y = 200, size = 100, size1 = 100;
            c.set(texturestyle, bb, c1, x, y, size, size1);
            Assert.AreEqual(200, c.x);
        }
    }
}
