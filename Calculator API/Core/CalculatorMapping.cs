using AutoMapper;

namespace Calculator_API.Core
{
    public class CalculatorMapping : Profile
    {
        public CalculatorMapping()
        {
            CreateMap<Model.Calculator, DTOs.CalculatorDto>().ReverseMap();
        }
    }
}
