using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class UI
    {
        public void DrawShapes(IEnumerable<IShape> shapes)
        {
            foreach (IShape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
