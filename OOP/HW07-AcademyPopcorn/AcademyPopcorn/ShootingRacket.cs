using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShootingRacket : Racket
    {
        private bool isShooter = false;

        public ShootingRacket(MatrixCoords topLeft, int width) : base(topLeft, width)
        {
        }
               
        public void Shoot()                     //This is called when the spacebar is pressed
        {
            this.isShooter = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (isShooter)
            {
                List<GameObject> bullets = new List<GameObject>();
                bullets.Add(new Bullet(new MatrixCoords(this.topLeft.Row, this.topLeft.Col + 2)));
                isShooter = false;                                      //If this is ommited, the racket shoots constantly
                return bullets;
                
            }
            else
	        {
                return new List<GameObject>();
	        }
            
        }

    }
}
