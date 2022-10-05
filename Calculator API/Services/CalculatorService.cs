using Calculator_API.Data;
using Calculator_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator_API.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly CalculatorDbContext _context;
        public CalculatorService(CalculatorDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Calculator calculator)
        {
            var calculatorCounter = _context.Calculators.ToList().Count;
            calculatorCounter++;
            calculator.Id = calculatorCounter;
            _context.Calculators.Add(calculator);
            return await Save();
        }

        public async Task<bool> Save()
        {
            return _context.SaveChanges() >= 0 ? true : false;
        }
    }
}
