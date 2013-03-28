using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class UnstoppableBall : Ball            //task 8
    {
        public new const string CollisionGroupString = "unstoppableBall";
        public const char Symbol = '@';

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, speed)
        {
            this.body[0, 0] = Symbol;
        }

        //Methods
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "indestructibleBlock";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            List<string> hitObjects = collisionData.hitObjectsCollisionGroupStrings;
            foreach (var hit in hitObjects)
            {
                if (hit == UnpassableBlock.CollisionGroupString || hit == Racket.CollisionGroupString)
                {
                    base.RespondToCollision(collisionData);
                }
            }
            
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }
    }
}
