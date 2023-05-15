namespace ndm
{
    public class ConfigureGithubModel 
    {
        public int Id { get; set; }
        public string WebsiteUrl { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public string RepositoryName { get; set; }
        public string Title { get; set; }
        public int EntriesToDisplay { get; set; }
        public bool IsConfigured { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}