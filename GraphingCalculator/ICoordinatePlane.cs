using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphingCalculator
{
    interface ICoordinatePlane
    {
        void TranslateOrigin(float x, float y);
        void DrawAxes(int increments, int tickHeight, Color axesColor);
        void DrawEllipse(int x, int y);
        void DrawFunction(string function);
    }
}
