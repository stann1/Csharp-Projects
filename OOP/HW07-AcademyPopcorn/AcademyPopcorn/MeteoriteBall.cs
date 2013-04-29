using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball
    {
        List<GameObject> trailList;
        public byte TrailLifes { get; private set; }

        //Base constructor with 3 default trails
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed, byte trailLifes = 3) : base(topLeft, speed)
        {
            this.TrailLifes = trailLifes;
        }
        
        public override void Update()
        {
            base.Update();
            trailList = new List<GameObject>();
            this.trailList.Add(new TrailObject(this.topLeft, this.TrailLifes));
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            return this.trailList;
        }
    }
}
