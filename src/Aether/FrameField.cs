using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace Aether
{
    public interface FrameField
    {
        Vector3d[] ValueAt(Point3d P);     
    }
}
