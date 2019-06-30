using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUIAPPLICATION;
using System.Drawing;

namespace GUI.UnitTest
{
    [TestClass]
    public class PolygonTest
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;
        [TestMethod]
        public void TestMethod1()
        {
            var p = new Polygon();
            int  size1 = 200, size2 = 200,size3 = 200, size4= 200, size5 = 200, size6= 200, size7=200, size8 = 200, size9 =200, size10= 200  ;
            p.set(texturestyle, bb, c1, size1, size2, size3, size4, size5, size6, size7, size8, size9, size10);
            Assert.AreEqual(200, p.size1);
        }
    }
}
