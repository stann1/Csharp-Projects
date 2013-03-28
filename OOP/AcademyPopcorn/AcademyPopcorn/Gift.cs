using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Gift : MovingObject
    {         
        public Gift(MatrixCoords topLeft) : base(topLeft, new char[,] {{'?'}}, new MatrixCoords(1,0))
        {
            
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            List<string> hitObjects = collisionData.hitObjectsCollisionGroupStrings;
            foreach (var hit in hitObjects)
            {
                if (hit == Racket.CollisionGroupString)
                {
                    this.IsDestroyed = true;
                }
            }            
        }

        //Implementing shooting gift for task 13
        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                List<GameObject> shooters = new List<GameObject>();
                shooters.Add(new ShootingRacket(new MatrixCoords(this.topLeft.Row+1, this.topLeft.Col), 6));
                return shooters;
            }
            else
            {
                return new List<GameObject>();
            }
           
        }
    }
}
