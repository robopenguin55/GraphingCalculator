using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphingCalculator
{
    public class CartesianPlane : ICoordinatePlane
    {
        Graphics _graphic;
        Pen _pen;

        int _height;
        int _width;

        public CartesianPlane(ref Graphics graphic, ref Pen pen, int height, int width)
        {
            this._graphic = graphic;
            this._pen = pen;
            this._height = height;
            this._width = width;
        }

        void ICoordinatePlane.DrawAxes(int increments, int tickHeight, Color axesColor)
        {
            lock (_graphic)
            {
                lock (_pen)
                {
                    // draw from the origin to the positive side of the y-axis
                    _graphic.DrawLine(_pen, -_width, 0, _width, 0);

                    // draw the y-axis
                    _graphic.DrawLine(_pen, 0, -_height, 0, _height);

                    for (int index = increments; index < _height; index = index + increments)
                    {
                        _graphic.DrawLine(_pen, -tickHeight, index, tickHeight, index);
                    }

                    for (int index = -increments; index > -_height; index = index - increments)
                    {
                        _graphic.DrawLine(_pen, -tickHeight, index, tickHeight, index);
                    }

                    for (int index = increments; index < _width; index = index + increments)
                    {
                        _graphic.DrawLine(_pen, index, -tickHeight, index, tickHeight);
                    }

                    for (int index = -increments; index > -_width; index = index - increments)
                    {
                        _graphic.DrawLine(_pen, index, -tickHeight, index, tickHeight);
                    }

                    // draw the origin
                    _graphic.DrawEllipse(_pen, 0, 0, tickHeight, tickHeight);
                }
            }
        }

        void ICoordinatePlane.DrawEllipse(int x, int y)
        {
            throw new NotImplementedException();
        }

        void ICoordinatePlane.TranslateOrigin(float x, float y)
        {
            lock (_graphic)
            {
                _graphic.TranslateTransform(x, y);

                // for some reason, the origin is upside down to start with. Let's fix that.
                _graphic.RotateTransform(180);
            }
        }

        void ICoordinatePlane.DrawFunction(string function)
        {

        }
    }
}
