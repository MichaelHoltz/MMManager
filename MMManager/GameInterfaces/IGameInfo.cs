using MMManager.GameObjects;
using MMManager.GameControls;
namespace MMManager.GameInterfaces
{
    public interface IGameInfo
    {
        IGame Game { get; set; } 
        IGameOptions GameOptions { get; set; }
        TicTacToePlayers Players { get; set; }
        TicTacToePlayer Player { get; set; }
        IScore GameScore { get; set; }
        void GameOver(string results);
        void AddGame(string gameName);
        void RemoveGame(string gameName);
        string GameName { get; set; }
        void StartGame(string gameName);
        void PlayersChanged();
        void RefreshGameList();
        ControlStatus GameMode { get; set;}
        SharedTicTacToeBoardData.GameState GameState { get; set; }
        void playSound(int sound);
       // void UpdateScore(IPlayer player, int currentScore);
    }

    public enum ControlStatus
    {
        Unknown=0,
        Hosting=1,
        Joined=2,
        Watching=3
    }
}
