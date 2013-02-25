using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structure3D
{
    public class Path                      //task 4
    {
        private List<Point3D> pointList = new List<Point3D>();
        
        public List<Point3D> PointList
        {
            get { return this.pointList; }
        }

        //Methods
        public void AddPoint(Point3D point)
        {            
             pointList.Add(point);
           
        }
    }
}
