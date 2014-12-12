using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace Aether
{
    public interface ScalarField
    {
        double ValueAt(Point3d P);
        Vector3d GradientAt(Point3d P);
    }
}
