using CommunityToolkit.Mvvm.Input;
using Game2048Maui.Data;
using Game2048Maui.Enums;
using Game2048Maui.Models;
using MvvmHelpers;
using System.Collections.ObjectModel;

namespace Game2048Maui.ViewModels
{
    /// <summary>
    /// Game logic been refered from https://github.com/jakowskidev/u2048_Jakowski
    /// </summary>
    public partial class MainPageViewModel : BaseViewModel
    {
        private int[][] iBoard;
        private int iScore = 0, iBest = 0, iAdded = 0;
        private int addNum = 2;
        private Random oR = new Random();
        private Boolean gameOver = false;
        private int iNewX, iNewY;
        private NumberTile currentTile;
        private CancellationTokenSource cancelAnimationTokenSource;
        private int guessedCount;
        private LevelState state;
        private string _mauiRobotPhrase;

        private int totalMoves;
        public int TotalMoves
        {
            get => totalMoves;
            set => SetProperty(ref totalMoves, value);
        }
        private string formattedTime;
        public string FormattedTime
        {
            get => formattedTime;
            set => SetProperty(ref formattedTime, value);
        }

        private string score = "0";
        private string bestScore = "0";
        private string addedScore = "0";

        public string Score
        {
            get => score;
            set => SetProperty(ref score, value);
        }

        public string BestScore
        {
            get => bestScore;
            set => SetProperty(ref bestScore, value);
        }

        public string AddedScore
        {
            get => addedScore;
            set
            {
                //need to notify even for same value.
                addedScore = value;
                OnPropertyChanged(nameof(AddedScore));
            }
        }

        public int GuessedCount
        {
            get => guessedCount;
            set => SetProperty(ref guessedCount, value);
        }

        public LevelState State
        {
            get => state;
            set => SetProperty(ref state, value);
        }
        public string MauiRobotPhrase
        {
            get => _mauiRobotPhrase;
            set => SetProperty(ref _mauiRobotPhrase, value);
        }
        
        public ObservableRangeCollection<NumberTile> GuessedTiles { get; } = new MvvmHelpers.ObservableRangeCollection<NumberTile>();

       
        private ObservableCollection<NumberTile> tiles = new ObservableCollection<NumberTile>();
        public ObservableCollection<NumberTile> Tiles
        {
            get => tiles;
            set => SetProperty(ref tiles, value);
        }


        [RelayCommand]
        void LeftSwipe()
        {
            MoveBoard(Direction.Left);
            UpdateGame();
        }
        [RelayCommand]
        void RightSwipe()
        {
            MoveBoard(Direction.Right);
            UpdateGame();
        }
        [RelayCommand]
        void UpSwipe()
        {
            MoveBoard(Direction.Up);
            UpdateGame();
        }
        [RelayCommand]
        void DownSwipe()
        {
            MoveBoard(Direction.Down);
            UpdateGame();
        }
        [RelayCommand]
        void NewGame()
        {
            State = LevelState.Playing;
            ResetGame();
            Update();
            LoadAsync();
        }
        public MainPageViewModel()
        {
            MauiRobotPhrase = "Hello! I am MauiRobots.";
            this.iBoard = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                iBoard[i] = new int[4];
            }

            Update();
            LoadAsync();
            _timer = new Timer(new TimerCallback((s) => UpdateTimerInUI()), null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        void UpdateGame()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = 0;
                    if (i == 1) index += 3;
                    if (i == 2) index += 6;
                    if (i == 3) index += 9;
                    if (iBoard[i][j] > 0)
                    {
                        Tiles[i + j + index].Number = iBoard[i][j].ToString();
                        if(i == iNewX && j == iNewY)
                        {
                            Tiles[i + j + index].IsNewNumberGenerated = true;
                        }
                    }
                    else 
                    {
                        Tiles[i + j + index].Number = String.Empty;
                    }
                }
            }
            if (iAdded > 0)
            {
                AddedScore = $"+ {iAdded}";
            }
            Score = iScore.ToString();
            BestScore = iBest.ToString();
            //See if Game Over
            if(IsGameOver())
            {

            }
        }
        private DateTime startTime = DateTime.Now;
        Timer _timer;
        
        private void UpdateTimerInUI()
        {
            TimeSpan spent = DateTime.Now - startTime;
            string elapsedTime = string.Format("{0:00}:{1:00}",
                spent.Minutes, spent.Seconds);
            FormattedTime = elapsedTime;
        }
       
        public void Update()
        {
            while (!gameOver && addNum > 0)
            {
                int nX = oR.Next(0, 4), nY = oR.Next(0, 4);

                if (iBoard[nX][nY] == 0)
                {
                    iBoard[nX][nY] = oR.Next(0, 20) == 0 ? oR.Next(0, 15) == 0 ? 8 : 4 : 2;
                    iNewX = nX;
                    iNewY = nY;
                    --addNum;
                }
            }
        }

        private async Task LoadAsync()
        {
            var numberRepository = new GameRepository();

            var allShapes = await numberRepository.ListAsync();
            var actualTiles = new List<NumberTile>();

            foreach (var item in allShapes)
            {
                actualTiles.Add(item);
            }
            // 0,0 0,1 0,2 0,3
            // 1,0 1,1 1,2 1,3
            // 2,0 2,1 2,2 2,3
            // 3,0 3,1 3,2 3,3
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (iBoard[i][j] > 0)
                    {
                        var index = 0;
                        if (i == 1) index += 3;
                        if (i == 2) index += 6;
                        if (i == 3) index += 9;
                        actualTiles[i + j + index].Number = iBoard[i][j].ToString();
                    }
                }
            }

            State = LevelState.Playing;
            Tiles = new ObservableCollection<NumberTile>(actualTiles);
        }

        public void MoveBoard(Direction nDirection)
        {
            TotalMoves += 1;
            iNewX = -1;
            iNewY = -1;
            iAdded = 0;
            Boolean bAdd = false;

            switch (nDirection)
            {
                case Direction.Left:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            for (int k = j + 1; k < 4; k++)
                            {
                                if (iBoard[i][k] == 0)
                                {
                                    continue;
                                }
                                else if (iBoard[i][k] == iBoard[i][j])
                                {
                                    iBoard[i][j] *= 2;
                                    Tiles[i + j + GetAddOnIndex(i)].IsNumberMultiplied = true;
                                    iAdded = iBoard[i][j];
                                    iScore += iBoard[i][j];
                                    iBoard[i][k] = 0;
                                    bAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (iBoard[i][j] == 0 && iBoard[i][k] != 0)
                                    {
                                        iBoard[i][j] = iBoard[i][k];
                                        iBoard[i][k] = 0;
                                        j--;
                                        bAdd = true;
                                        break;
                                    }
                                    else if (iBoard[i][j] != 0)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case Direction.Down:
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 3; i >= 0; i--)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (iBoard[k][j] == 0)
                                {
                                    continue;
                                }
                                else if (iBoard[k][j] == iBoard[i][j])
                                {
                                    iBoard[i][j] *= 2;
                                    Tiles[i + j + GetAddOnIndex(i)].IsNumberMultiplied = true;
                                    iAdded = iBoard[i][j];
                                    iScore += iBoard[i][j];
                                    iBoard[k][j] = 0;
                                    bAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (iBoard[i][j] == 0 && iBoard[k][j] != 0)
                                    {
                                        iBoard[i][j] = iBoard[k][j];
                                        iBoard[k][j] = 0;
                                        i++;
                                        bAdd = true;
                                        break;
                                    }
                                    else if (iBoard[i][j] != 0)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case Direction.Right:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 3; j >= 0; j--)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (iBoard[i][k] == 0)
                                {
                                    continue;
                                }
                                else if (iBoard[i][k] == iBoard[i][j])
                                {
                                    iBoard[i][j] *= 2;
                                    Tiles[i + j + GetAddOnIndex(i)].IsNumberMultiplied = true;
                                    iAdded = iBoard[i][j];
                                    iScore += iBoard[i][j];
                                    iBoard[i][k] = 0;
                                    bAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (iBoard[i][j] == 0 && iBoard[i][k] != 0)
                                    {
                                        iBoard[i][j] = iBoard[i][k];
                                        iBoard[i][k] = 0;
                                        j++;
                                        bAdd = true;
                                        break;
                                    }
                                    else if (iBoard[i][j] != 0)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case Direction.Up:
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int k = i + 1; k < 4; k++)
                            {
                                if (iBoard[k][j] == 0)
                                {
                                    continue;
                                }
                                else if (iBoard[k][j] == iBoard[i][j])
                                {
                                    iBoard[i][j] *= 2;
                                    Tiles[i + j + GetAddOnIndex(i)].IsNumberMultiplied = true;
                                    iAdded = iBoard[i][j];
                                    iScore += iBoard[i][j];
                                    iBoard[k][j] = 0;
                                    bAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (iBoard[i][j] == 0 && iBoard[k][j] != 0)
                                    {
                                        iBoard[i][j] = iBoard[k][j];
                                        iBoard[k][j] = 0;
                                        i--;
                                        bAdd = true;
                                        break;
                                    }
                                    else if (iBoard[i][j] != 0)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
            }

            if (iScore > iBest)
            {
                iBest = iScore;
            }

            if (bAdd)
            {
                ++addNum;
            }

            if (IsGameOver())
            {
                State = LevelState.GameOver;
            }
            Update();
        }

        public bool IsGameOver()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i - 1 >= 0)
                    {
                        if (iBoard[i - 1][j] == iBoard[i][j])
                        {
                            return false;
                        }
                    }

                    if (i + 1 < 4)
                    {
                        if (iBoard[i + 1][j] == iBoard[i][j])
                        {
                            return false;
                        }
                    }

                    if (j - 1 >= 0)
                    {
                        if (iBoard[i][j - 1] == iBoard[i][j])
                        {
                            return false;
                        }
                    }

                    if (j + 1 < 4)
                    {
                        if (iBoard[i][j + 1] == iBoard[i][j])
                        {
                            return false;
                        }
                    }

                    if (iBoard[i][j] == 0)
                    {
                        return false;
                    }
                }
            }

            gameOver = true;
            return true;
        }

        private void ResetGame()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    this.iBoard[i][j] = 0;
                }
            }

            this.addNum = 2;
            this.iScore = 0;
            this.iAdded = 0;
            this.gameOver = false;
            startTime = DateTime.Now;
            TotalMoves = 0;
            Score = "0";
        }
        private int GetAddOnIndex(int i)
        {
            var index = 0;
            if (i == 1) index += 3;
            if (i == 2) index += 6;
            if (i == 3) index += 9;
            return index;
        }
    }
}
