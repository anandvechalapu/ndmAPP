namespace Ndm
{
    public class ConfigureGitHubRepository : IConfigureGitHubRepository
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _mongoDatabase;
        private readonly IMongoCollection<ConfigureGitHubModel> _mongoCollection;

        public ConfigureGitHubRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            _mongoDatabase = _mongoClient.GetDatabase("GitHubDb");
            _mongoCollection = _mongoDatabase.GetCollection<ConfigureGitHubModel>("GitHubConfig");
        }

        public async Task<bool> CreateAsync(ConfigureGitHubModel model)
        {
            try
            {
                await _mongoCollection.InsertOneAsync(model);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<ConfigureGitHubModel> ReadAsync(int id)
        {
            try
            {
                var filter = Builders<ConfigureGitHubModel>.Filter.Eq(s => s.Id, id);
                var result = await _mongoCollection.Find(filter).SingleOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(ConfigureGitHubModel model)
        {
            try
            {
                var filter = Builders<ConfigureGitHubModel>.Filter.Eq(s => s.Id, model.Id);
                var update = Builders<ConfigureGitHubModel>.Update
                    .Set(s => s.SacralAiUrl, model.SacralAiUrl)
                    .Set(s => s.GithubUsername, model.GithubUsername)
                    .Set(s => s.GithubPassword, model.GithubPassword)
                    .Set(s => s.GithubUrl, model.GithubUrl)
                    .Set(s => s.RepositoryName, model.RepositoryName)
                    .Set(s => s.Title, model.Title)
                    .Set(s => s.UserName, model.UserName)
                    .Set(s => s.Action, model.Action)
                    .Set(s => s.NoOfEntries, model.NoOfEntries);

                var result = await _mongoCollection.UpdateOneAsync(filter, update);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var filter = Builders<ConfigureGitHubModel>.Filter.Eq(s => s.Id, id);
                var result = await _mongoCollection.DeleteOneAsync(filter);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}