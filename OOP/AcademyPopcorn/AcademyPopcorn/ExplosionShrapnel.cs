using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplosionShrapnel : MovingObject                         //task 10, each explosion produces shrapnel
    {
        public ExplosionShrapnel(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, new char[,] {{'.'}}, speed)
        {
        }

        public override void Update()
        {
            base.Update();
            this.IsDestroyed = true;                    //to ensure that the shrapnel will be destroyed after 1 turn (even if no collision)
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;                      //destroyed on impact
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }

        public override string GetCollisionGroupString()
        {
            return Ball.CollisionGroupString;
        }
    }
}
