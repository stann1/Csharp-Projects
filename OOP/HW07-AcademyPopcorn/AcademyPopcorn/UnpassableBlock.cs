using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class UnpassableBlock : Block                  //task 8
    {
        public const char Symbol = '%';
        public new const string CollisionGroupString = "indestructibleBlock";

        public UnpassableBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            //base.RespondToCollision(collisionData);
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
