using System;
using System.Linq;

namespace _04.MineSweeper
{
    class Player
    {
        private string name;
		private int score;

        //Constructors        
        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public Player()
            : this(null, 0)
        {
        }


        //Properties
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		public int Score
		{
			get { return this.score; }
			set { this.score = value; }
		}

		
    }
}
