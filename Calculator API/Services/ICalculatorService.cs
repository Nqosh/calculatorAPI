
using Calculator_API.Model;
using System.Threading.Tasks;

namespace Calculator_API.Services
{
    public interface ICalculatorService
    { 
        Task<bool> Create(Calculator customer);
        Task<bool> Save();
    }
}
