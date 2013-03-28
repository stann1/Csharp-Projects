using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class TrailObject : GameObject                                 //task 5 - implement TrailObject
    {
        public byte LifeTime { get; private set; }

        public TrailObject(MatrixCoords topLeft, byte lifeTime)
            : base(topLeft, new char[,] { { '.' } })
        {
            this.LifeTime = lifeTime;
        }

        public override void Update()
        {
            this.LifeTime--;
            if (this.LifeTime == 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
