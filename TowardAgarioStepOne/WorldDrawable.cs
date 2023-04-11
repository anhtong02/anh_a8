using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowardAgarioStepOne
{
    internal class WorldDrawable : IDrawable
    {
        private WorldModel circle;
        private GraphicsView gv;

        public WorldDrawable(WorldModel circle, GraphicsView gv)
        {
            this.circle = circle;
            this.gv = gv;
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            //GV
            canvas.StrokeColor = Colors.Black;
            canvas.FillColor = Colors.DarkBlue;

            canvas.DrawRectangle(0, 0, (float)gv.WidthRequest, (float)gv.HeightRequest);
            canvas.FillRectangle(0, 0, (float)gv.WidthRequest, (float)gv.HeightRequest);

            //Circle
            canvas.FillColor = Color.FromRgba(255, 0, 0, 255);

            canvas.DrawCircle(circle.x, circle.y, circle.radius);
            canvas.FillCircle(circle.x, circle.y, circle.radius);

            canvas.DrawString("Michelle", circle.x, circle.y, HorizontalAlignment.Center);
        }
    }
}