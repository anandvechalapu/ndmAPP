namespace Ndm.Repositories
{
    public class ConfigureGithubRepository
    {
        private readonly NdmDTO _context;

        public ConfigureGithubRepository(NdmDTO context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(ConfigureGithubModel model)
        {
            var newConfigureGithubModel = new ConfigureGithubModel
            {
                Username = model.Username,
                Password = model.Password,
                Url = model.Url,
                RepositoryName = model.RepositoryName,
                Title = model.Title,
                UserName = model.UserName,
                Action = model.Action,
                NumberOfEntries = model.NumberOfEntries
            };

            try
            {
                _context.ConfigureGithubModel.Add(newConfigureGithubModel);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(ConfigureGithubModel model)
        {
            var updateConfigureGithubModel = await _context.ConfigureGithubModel.FindAsync(model.Id);

            if (updateConfigureGithubModel == null)
            {
                return false;
            }

            updateConfigureGithubModel.Username = model.Username;
            updateConfigureGithubModel.Password = model.Password;
            updateConfigureGithubModel.Url = model.Url;
            updateConfigureGithubModel.RepositoryName = model.RepositoryName;
            updateConfigureGithubModel.Title = model.Title;
            updateConfigureGithubModel.UserName = model.UserName;
            updateConfigureGithubModel.Action = model.Action;
            updateConfigureGithubModel.NumberOfEntries = model.NumberOfEntries;

            try
            {
                _context.ConfigureGithubModel.Update(updateConfigureGithubModel);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var deleteConfigureGithubModel = await _context.ConfigureGithubModel.FindAsync(id);

            if (deleteConfigureGithubModel == null)
            {
                return false;
            }

            try
            {
                _context.ConfigureGithubModel.Remove(deleteConfigureGithubModel);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<ConfigureGithubModel> GetAsync(int id)
        {
            var getConfigureGithubModel = await _context.ConfigureGithubModel.FindAsync(id);
            return getConfigureGithubModel;
        }

        public async Task<IEnumerable<ConfigureGithubModel>> GetAllAsync()
        {
            var getAllConfigureGithubModels = await _context.ConfigureGithubModel.ToListAsync();
            return getAllConfigureGithubModels;
        }
    }
}