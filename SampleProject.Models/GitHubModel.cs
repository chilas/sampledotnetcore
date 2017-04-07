using System;

namespace SampleProject.Models
{
    public class GitHubModel
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Blog { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public int PublicRepos { get; set; }
        public int Folowers { get; set; }
        public int Following { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
