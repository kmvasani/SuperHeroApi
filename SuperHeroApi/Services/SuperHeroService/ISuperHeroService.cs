using Microsoft.AspNetCore.Mvc;

namespace SuperHeroApi.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero>? GetAllHeroes();
        SuperHero? GetSingleHero(int id);
        List<SuperHero>? AddHero(SuperHero hero);
        List<SuperHero>? DeleteHero(int id);
        List<SuperHero>? UpdateHero(int id, SuperHero request);
    }
}
