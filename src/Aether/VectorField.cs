using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace Aether
{
    public interface VectorField
    {
        Vector3d ValueAt(Point3d P);
        double Divergence(Point3d P);
        Vector3d Curl(Point3d P);
    }
}
