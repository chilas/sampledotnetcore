using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Contracts.Services
{
    public interface IGitHubService <T>
    {
        Task<T> GetUser(string username);
    }
}
