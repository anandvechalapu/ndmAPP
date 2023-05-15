namespace NDM
{
    public class ConfigureGithubModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public string RepositoryName { get; set; }
        public int NoOfEntries { get; set; }
        public string Title { get; set; }
        public string Action { get; set; }
        public int PageNumber { get; set; }
    }
}