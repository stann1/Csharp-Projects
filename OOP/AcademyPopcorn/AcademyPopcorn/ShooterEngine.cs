using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShooterEngine : Engine
    {
        public ShooterEngine(IRenderer renderer, IUserInterface userInterface, ushort sleepInterval) : base(renderer, userInterface, sleepInterval)
        {
        }

        public void ShootPlayerRacket()                    //tasks 4 and 13
        {
            if (this.playerRacket is ShootingRacket)
            {
                ShootingRacket shooter = this.playerRacket as ShootingRacket;
                shooter.Shoot();
            }
        }

    }
}
