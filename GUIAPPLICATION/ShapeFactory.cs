using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIAPPLICATION
{
    class ShapeFactory
    {
        public Shape GetShape(String shapeType)
        {
            if (shapeType == "circle")
            {
                return new Circle();

            }
            else if (shapeType == "rectangle")
            {
                return new Rectangle();
            }
            else if (shapeType == "line")
            {
                return new Line();
            }
            else if (shapeType == "triangle")
            {
                return new Triangle();
            }
            else if (shapeType == "polygon")
            {
                return new Polygon();
            }
            return null;
        }
    }
    }

