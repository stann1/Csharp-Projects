using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodingBlock : Block                    //task 10
    {
        public const char Symbol = '*';
        public bool Explosion { get; private set; }

        public ExplodingBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            this.Explosion = true;
            ProduceObjects();
            
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.Explosion)
            {
                List<GameObject> shrapnels = new List<GameObject>();
                shrapnels.Add(new ExplosionShrapnel(this.topLeft, new MatrixCoords(-1, 0)));
                shrapnels.Add(new ExplosionShrapnel(this.topLeft, new MatrixCoords(-1, 1)));
                shrapnels.Add(new ExplosionShrapnel(this.topLeft, new MatrixCoords(0, 1)));
                shrapnels.Add(new ExplosionShrapnel(this.topLeft, new MatrixCoords(1, 1)));
                shrapnels.Add(new ExplosionShrapnel(this.topLeft, new MatrixCoords(1, 0)));
                shrapnels.Add(new ExplosionShrapnel(this.topLeft, new MatrixCoords(1, -1)));
                shrapnels.Add(new ExplosionShrapnel(this.topLeft, new MatrixCoords(0, -1)));
                shrapnels.Add(new ExplosionShrapnel(this.topLeft, new MatrixCoords(-1, -1)));
                return shrapnels;
            }
            else
            {
                return new List<GameObject>();
            }
        }



    }
}
