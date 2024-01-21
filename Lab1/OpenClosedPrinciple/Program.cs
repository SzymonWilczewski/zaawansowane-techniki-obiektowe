// Add IShape interface, and implement in Circle as well as in Square so that ShapeDrawer could meet the open closed principle based on:
// https://pierresimondelaplace.gitlab.io/wsb-zaawansowane-techniki-obiektowe/WSB_ZaawansowaneTechnikiObiektowe.pdf

using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class Program
    {
        public static void Main()
        {
            Circle circle = new Circle();
            Square square = new Square();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();

            List<IShape> shapes = new List<IShape>
            {
                circle,
                square,
                rectangle,
                triangle
            };

            UI ui = new UI();

            ui.DrawShapes(shapes);
        }
    }
}
