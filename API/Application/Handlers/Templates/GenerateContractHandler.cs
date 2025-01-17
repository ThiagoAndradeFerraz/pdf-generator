using Domain.Handlers.Templates;
using Domain.Repositories;

namespace Application.Handlers.Templates
{
    public class GenerateContractHandler(
        IContractRepository contractRepository) : IGenerateContractHandler
    {
        private readonly IContractRepository _contractRepository = contractRepository;

        public async Task<string> GenerateContractAsync()
        {
            // todo: query path
            return await _contractRepository.GetTemplatePath(1) ?? "";

            // todo: read file

            // todo: replace placeholders

            // todo: convert to pdf

            // todo: return as base64

            //throw new NotImplementedException();
        }
    }
}
