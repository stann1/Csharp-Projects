using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            //Testing Unpassable, Exploding and Gift blocks
            for (int i = startCol; i < endCol; i++)
            {
                if (i % 10 == 0 )
                {
                    Block currBlock = new UnpassableBlock(new MatrixCoords(startRow + 1, i));
                    engine.AddObject(currBlock);
                }
                else if (i % 4 == 0)
                {
                    Block currBlock = new GiftBlock(new MatrixCoords(startRow + 1, i));
                    engine.AddObject(currBlock);
                }
                else if (i % 11 == 0)
                {
                    Block currBlock = new ExplodingBlock(new MatrixCoords(startRow + 1, i));
                    engine.AddObject(currBlock);
                }
                else
                {
                    Block currBlock = new Block(new MatrixCoords(startRow + 1, i));
                    engine.AddObject(currBlock);
                }

            }

            //Testing meteorite
            Ball theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            //Testing unstoppable ball
            //Ball theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
           
            //Adding indestructible walls and ceiling
            for (int i = 0; i < WorldRows; i++)
            {
                Block wallBlockLeft = new IndestructibleBlock(new MatrixCoords(i, 0));
                Block wallBlockRight = new IndestructibleBlock(new MatrixCoords(i, WorldCols-1));
                engine.AddObject(wallBlockLeft);
                engine.AddObject(wallBlockRight);
            }

            for (int i = 0; i < WorldCols; i++)
            {
                Block ceilingBlock = new IndestructibleBlock(new MatrixCoords(0, i));
                engine.AddObject(ceilingBlock);
            }

                       
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            ShooterEngine gameEngine = new ShooterEngine(renderer, keyboard, 300);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
