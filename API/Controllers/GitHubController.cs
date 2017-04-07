using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;
using SampleProject.Contracts.Services;
using API.ViewModels;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class GitHubController : Controller
    {
        private IGitHubService<GitHubModel> _services;
        public GitHubController(IGitHubService<GitHubModel> services)
        {
            this._services = services;
        }

        // GET api/github/chilas
        [HttpGet("{username}")]
        public async Task<UserViewModel> Get(string username)
        {
            var userData = await _services.GetUser(username);
            UserViewModel user = new UserViewModel
            {
                FullName = userData.Name,
                Description = userData.Bio,
                Organisation = userData.Company,
                Website = userData.Blog
            };
            return user;
        }
    }
}
