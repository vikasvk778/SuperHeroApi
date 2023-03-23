namespace SuperHeroApi.services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "iron man",
                    Firstname = "Tony",
                    Lastname = "Stark",
                    Place = "new york"
                },
                 new SuperHero
                {
                    Id = 2,
                    Name = "spider man",
                    Firstname = "peter",
                    Lastname = "parker",
                    Place = "london"
                }
            };
        public List<SuperHero> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(h => h.Id == id);
            if (hero == null)
                return null;
            superHeroes.Remove(hero);
            return superHeroes; ;
        }

        public List<SuperHero> GetAllHeroes()
        {

            return superHeroes;
        }

        public SuperHero? Getsinglehero(int id)
        {
            var hero = superHeroes.Find(h => h.Id == id);
            if (hero == null)
                return null;
            return hero;
        }

        public List<SuperHero>? UpdateHero(int id,SuperHero request)
        {

            var hero = superHeroes.Find(h => h.Id == request.Id);
            if (hero == null)
                return null;

            hero.Name = request.Name;
            hero.Firstname = request.Firstname;
            hero.Lastname = request.Lastname;
            hero.Place = request.Place;
            return superHeroes;
        }

     
    }

}
