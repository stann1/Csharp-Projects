using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class GiftBlock : Block
    {
        public const char Symbol = '$';

        public GiftBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }
                
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;            
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                List<GameObject> gifts = new List<GameObject>();
                gifts.Add(new Gift(this.topLeft));

                return gifts;
            }
            else
            {
                return new List<GameObject>();
            }
        }

    }
}
