using RenderTest.Models;

namespace RenderTest.Services.IServices
{
    public interface IRickAndMortyService
    {
        public Task<RickAndMorty> Get();

    }
}
