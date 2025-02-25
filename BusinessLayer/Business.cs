using DataLayer;
using Models;

namespace BusinessLayer;

public class Business : IBusiness
{
    private readonly IRepository _repo;

    public Business(IRepository repo)
    {
        _repo = repo;
    }

    // Question
    public async Task<List<List<QA>>> GetQuestionsAsync(List<int> subcategories) { return await _repo.GetQuestionsAsync(subcategories); }
    public async Task<List<Question>> GetAllQuestionsAsync(int subcategory) { return await _repo.GetAllQuestionsAsync(subcategory); }
    public async Task<int> CreateQuestionAsync(Question question) { return await _repo.CreateQuestionAsync(question); }
    public async Task CreateAnswerAsync(Answer answer) { await _repo.CreateAnswerAsync(answer); }

    // Player
    public async Task<Admin> GetAdminAsync(string username, string password) { return await _repo.GetAdminAsync(username, password); }
    public async Task<List<Player>> GetPlayersAsync() { return await _repo.GetPlayersAsync(); }
    public async Task<List<Player>> GetTeamMembersAsync(int team_id) { return await _repo.GetTeamMembersAsync(team_id); }
    public async Task CreatePlayersAsync(List<List<Player>> players) { await _repo.CreatePlayersAsync(players); }

    // Team
    public async Task<List<Team>> GetTeamsSortedbyScoreAsync() { return await _repo.GetTeamsSortedbyScoreAsync(); }
    public async Task UpdateTeamsAsync(List<Team> teams) { await _repo.UpdateTeamsAsync(teams); }
    public async Task CreateTeamsAsync(List<Team> teams) { await _repo.CreateTeamsAsync(teams); }

    // Category
    public async Task<List<Models.Type>> GetCategoriesAsync() { return await _repo.GetCategoriesAsync(); }
    public async Task CreateCategoryAsync(string categoryName) { await _repo.CreateCategoryAsync(categoryName); }
    public async Task CreateSubcategoryAsync(Subcategory subcategory) { await _repo.CreateSubcategoryAsync(subcategory); }

    // Game
    public async Task<int> CreateGameAsync(Game game) { return await _repo.CreateGameAsync(game); }
    public async Task CreateGamestateAsync(List<Gamestate> gamestates) { await _repo.CreateGamestateAsync(gamestates); }
    public async Task CreateBoardstateAsync(List<Boardstate> boardstates) { await _repo.CreateBoardstateAsync(boardstates); }
    public async Task<List<GameUI>> GetSavedGamesAsync() { return await _repo.GetSavedGamesAsync(); }
    public async Task DeleteBoardstatesAsync(int game_id) { await _repo.DeleteBoardstatesAsync(game_id); }
    public async Task DeleteGamestatesAsync(int game_id) { await _repo.DeleteGamestatesAsync(game_id); }
    public async Task DeleteGameAsync(int game_id) { await _repo.DeleteGameAsync(game_id); }
    public async Task UpdateGameAsync(Game game) { await _repo.UpdateGameAsync(game); }
    public async Task UpdateBoardstatesAsync(List<Boardstate> boardstates) { await _repo.UpdateBoardstatesAsync(boardstates); }
}