
namespace SuperHeroApi.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>{
                new SuperHero { Id = 1,
                                Name = "Bat Man",
                                FirstName = "Robert",
                                LastName = "Smith",
                                Place = "Manitoba City",
                              },
                new SuperHero { Id = 2,
                                Name = "Iron Man",
                                FirstName = "Anthony",
                                LastName = "Mark",
                                Place = "New York City",
                              },
                new SuperHero { Id = 3,
                                Name = "Spider Man",
                                FirstName = "Tony",
                                LastName = "Mark",
                                Place = "California City",
                              }
                };
        public List<SuperHero>? AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;
            superHeroes.Remove(hero);
            return superHeroes;
        }

        public List<SuperHero>? GetAllHeroes()
        {
            return superHeroes;
        }

        public SuperHero? GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;
            return hero;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == request.Id);
            if (hero is null)
                return null;

            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            return superHeroes;
        }
    }
}
