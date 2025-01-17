namespace Domain.Handlers.Templates
{
    public interface IGenerateContractHandler
    {
        public Task<string> GenerateContractAsync();
    }
}
