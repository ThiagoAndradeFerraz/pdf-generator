using Domain.Enums;

namespace Domain.Entities
{
    public class ContractType
    {
        public EContractType Type { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
