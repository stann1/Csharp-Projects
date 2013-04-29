using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] playField = CreatePlayFiled();
            char[,] bombs = PlaceBombs();
            int scoreCount = 0;
            bool explosion = false;
            List<Player> players = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool newGameStarted = true;
            const int MaxScore = 35;
            bool reachedMaxScore = false;

            do
            {
                //TODO: refactor this
                if (newGameStarted)
                {
                    Console.WriteLine("Lets play Minesweeper. Try your luck by discovering tiles without mines." +
                    "Command \"top\" shows the score board, \"restart\" resets the current game, \"exit\" exits the game. Good luck!");
                    DrawPlayField(playField);
                    newGameStarted = false;
                }

                Console.Write("Enter a command (to open a tile, enter coordinates seperated with space): ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    bool validRow = int.TryParse(command[0].ToString(), out row);
                    bool validCol = int.TryParse(command[2].ToString(), out column);
                    if (validRow && validCol && row <= playField.GetLength(0) && column <= playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        ShowLeaderBoard(players);
                        break;
                    case "restart":
                        playField = CreatePlayFiled();
                        bombs = PlaceBombs();
                        DrawPlayField(playField);
                        explosion = false;
                        newGameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                NextMove(playField, bombs, row, column);
                                scoreCount++;
                            }
                            if (MaxScore == scoreCount)
                            {
                                reachedMaxScore = true;
                            }
                            else
                            {
                                DrawPlayField(playField);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        Console.WriteLine();
                        break;
                }
                if (explosion)
                {
                    DrawPlayField(bombs);
                    Console.Write("Boom! You just died with a score of {0}. " +
                        "Enter your name: ", scoreCount);
                    string playerName = Console.ReadLine();
                    Player currentPlayer = new Player(playerName, scoreCount);

                    if (players.Count < 5)
                    {
                        players.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Score < currentPlayer.Score)
                            {
                                players.Insert(i, currentPlayer);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }
                    players.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    players.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Score.CompareTo(firstPlayer.Score));

                    ShowLeaderBoard(players);
                    playField = CreatePlayFiled();
                    bombs = PlaceBombs();
                    scoreCount = 0;
                    explosion = false;
                    newGameStarted = true;
                }
                if (reachedMaxScore)
                {
                    Console.WriteLine("Congratulations! You just open the maxium {0} number of tiles.", MaxScore);
                    DrawPlayField(bombs);
                    Console.WriteLine("Enter your name for the leaderboard: ");
                    string currentPlayerName = Console.ReadLine();

                    Player currentPlayer = new Player(currentPlayerName, scoreCount);
                    players.Add(currentPlayer);

                    ShowLeaderBoard(players);
                    playField = CreatePlayFiled();
                    bombs = PlaceBombs();
                    scoreCount = 0;
                    reachedMaxScore = false;
                    newGameStarted = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("See ya soon!");            
        }

        private static void ShowLeaderBoard(List<Player> players)
        {
            Console.WriteLine("Ranking:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, players[i].Name, players[i].Score);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("LeaderBoard is empty");
                Console.WriteLine();
            }
        }

        private static void NextMove(char[,] playField, char[,] bombs, int row, int column)
        {
            char numberOfBombs = BombCount(bombs, row, column);
            bombs[row, column] = numberOfBombs;
            playField[row, column] = numberOfBombs;
        }

        private static void DrawPlayField(char[,] playField)
        {
            int totalRows = playField.GetLength(0);
            int totalCols = playField.GetLength(1);

            Console.WriteLine();
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("  ---------------------");

            for (int i = 0; i < totalRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < totalCols; j++)
                {
                    Console.Write(playField[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine(" ---------------------");
            Console.WriteLine();
        }

        private static char[,] CreatePlayFiled()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] playField = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    playField[i, j] = '?';
                }
            }

            return playField;
        }

        private static char[,] PlaceBombs()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] bombCollection = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    bombCollection[i, j] = '-';
                }
            }

            List<int> placedBombs = new List<int>();
            while (placedBombs.Count < 15)
            {
                Random random = new Random();
                int bombAtPosition = random.Next(50);

                if (!placedBombs.Contains(bombAtPosition))
                {
                    placedBombs.Add(bombAtPosition);
                }
            }

            foreach (int position in placedBombs)
            {
                int column = (position / boardColumns);
                int row = (position % boardColumns);

                if (row == 0 && position != 0)
                {
                    column--;
                    row = boardColumns;
                }
                else
                {
                    row++;
                }
                bombCollection[column, row - 1] = '*';
            }

            return bombCollection;
        }

        private static void ShowAdjacentBombs(char[,] pole)
        {
            int column = pole.GetLength(0);
            int row = pole.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char adjacentBombs = BombCount(pole, i, j);
                        pole[i, j] = adjacentBombs;
                    }
                }
            }
        }

        private static char BombCount(char[,] bombs, int row, int column)
        {
            int count = 0;
            int totalRows = bombs.GetLength(0);
            int totalCols = bombs.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombs[row - 1, column] == '*')
                {
                    count++;
                }
            }
            if (row + 1 < totalRows)
            {
                if (bombs[row + 1, column] == '*')
                {
                    count++;
                }
            }
            if (column - 1 >= 0)
            {
                if (bombs[row, column - 1] == '*')
                {
                    count++;
                }
            }
            if (column + 1 < totalCols)
            {
                if (bombs[row, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (bombs[row - 1, column - 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (column + 1 < totalCols))
            {
                if (bombs[row - 1, column + 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < totalRows) && (column - 1 >= 0))
            {
                if (bombs[row + 1, column - 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < totalRows) && (column + 1 < totalCols))
            {
                if (bombs[row + 1, column + 1] == '*')
                {
                    count++;
                }
            }
            return char.Parse(count.ToString());
        }
    }
}
