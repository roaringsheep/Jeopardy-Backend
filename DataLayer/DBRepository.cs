using System.Data;
using Models;

namespace DataLayer;

public class DBRepository : IRepository
{
    private readonly string _connectionString;

    public DBRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Question
    public async Task<List<List<QA>>> GetQuestionsAsync(List<int> subcategories) { return await DBQuestion.GetQuestions(subcategories, _connectionString); }
    public async Task<List<Question>> GetAllQuestionsAsync(int subcategory) { return await DBQuestion.GetAllQuestions(subcategory, _connectionString); }
    public async Task<int> CreateQuestionAsync(Question question) { return await DBQuestion.CreateQuestion(question, _connectionString); }
    public async Task CreateAnswerAsync(Answer answer) { await DBQuestion.CreateAnswer(answer, _connectionString); }

    // Player
    public async Task<Admin> GetAdminAsync(string username, string password) { return await DBPlayer.GetAdmin(username, password, _connectionString); }
    public async Task<List<Player>> GetPlayersAsync() { return await DBPlayer.GetPlayers(_connectionString); }
    public async Task<List<Player>> GetTeamMembersAsync(int team_id) { return await DBPlayer.GetTeamMembers(team_id, _connectionString); }
    public async Task CreatePlayersAsync(List<List<Player>> players) { await DBPlayer.CreatePlayers(players, _connectionString); }

    // Team
    public async Task<List<Team>> GetTeamsSortedbyScoreAsync() { return await DBTeam.GetTeamsSortedbyScore(_connectionString); }
    public async Task UpdateTeamsAsync(List<Team> teams) { await DBTeam.UpdateTeams(teams, _connectionString); }
    public async Task CreateTeamsAsync(List<Team> teams) { await DBTeam.CreateTeams(teams, _connectionString); }

    // Category
    public async Task<List<Models.Type>> GetCategoriesAsync() { return await DBCategory.GetCategories(_connectionString); }
    public async Task CreateCategoryAsync(string categoryName) { await DBCategory.CreateCategory(categoryName, _connectionString); }
    public async Task CreateSubcategoryAsync(Subcategory subcategory) { await DBCategory.CreateSubcategory(subcategory, _connectionString); }

    // Game
    public async Task<int> CreateGameAsync(Game game) { return await DBGame.CreateGame(game, _connectionString); }
    public async Task CreateGamestateAsync(List<Gamestate> gamestates) { await DBGame.CreateGamestate(gamestates, _connectionString); }
    public async Task CreateBoardstateAsync(List<Boardstate> boardstates) { await DBGame.CreateBoardstate(boardstates, _connectionString); }
    public async Task<List<GameUI>> GetSavedGamesAsync() { return await DBGame.GetSavedGames(_connectionString); }
    public async Task DeleteBoardstatesAsync(int game_id) { await DBGame.DeleteBoardstates(game_id, _connectionString); }
    public async Task DeleteGamestatesAsync(int game_id) { await DBGame.DeleteGamestates(game_id, _connectionString); }
    public async Task DeleteGameAsync(int game_id) { await DBGame.DeleteGame(game_id, _connectionString); }
    public async Task UpdateGameAsync(Game game) { await DBGame.UpdateGame(game, _connectionString); }
    public async Task UpdateBoardstatesAsync(List<Boardstate> boardstates) { await DBGame.UpdateBoardstates(boardstates, _connectionString); }
}