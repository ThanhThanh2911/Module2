using System;
using PokemonApp.Domain;
using PokemonApp.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PokemonConsole
{
    class Program
    {
        private static PokemonContext _context = new PokemonContext();
        static void Main(string[] args)
        {
            //InsertPokemom();
            //Insert2Pokemon();
            //Insert3Pokemon();
            //ShowPokemon();
            //QueriesUse();
            //UpdatePokemon();
            //InsertDateBattle();
            //DeletePokemon();
            DeleteBattle();
        }

        private static void DeleteBattle()
        {
            var battles = _context.Battles.ToList();
            foreach (var item in battles)
            {
                _context.Remove(item);
                _context.Entry(item).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        private static void InsertNameBattle()
        {
            var battle1 = new Battle { Name = "WarInWater" };
            var battle2 = new Battle { Name = "WarInLand" };
            var battle3 = new Battle { Name = "WarInRock" };
            var battle4 = new Battle { Name = "WarInIce" };
            _context.Battles.AddRange(battle1, battle2, battle3, battle4);
            _context.SaveChanges();
        }

        private static void DeletePokemon()
        {
            var pokemon = _context.Pokemons.FirstOrDefault(poke => poke.Name == "Pikachu");
            _context.Remove(pokemon);
            _context.Entry(pokemon).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        private static void InsertDateBattle()
        {
            _context.Battles.Add(new Battle
            {
                Name = "WarInWater",
                StartDate = new DateTime(2019, 10, 2),
                EndDate = new DateTime(2019, 10, 3),
            });
            _context.Battles.Add(new Battle
            {
                Name = "WarInLand",
                StartDate = new DateTime(2019, 10, 4),
                EndDate = new DateTime(2019, 10, 5),
            });
            _context.Battles.Add(new Battle
            {
                Name = "WarInRock",
                StartDate = new DateTime(2019, 10, 6),
                EndDate = new DateTime(2019, 10, 7),
            });
            _context.Battles.Add(new Battle
            {
                Name = "WarInIce",
                StartDate = new DateTime(2019, 10, 8),
                EndDate = new DateTime(2019, 10, 9),
            });            
            _context.SaveChanges();
        }

        private static void UpdatePokemon()
        {
            var pokemon = _context.Pokemons.FirstOrDefault();
            pokemon.Name = "Bullbasaur";
            _context.SaveChanges();
        }

        private static void QueriesUse()
        {
            var name = "Pikachu";
            var searchPokemon = _context.Pokemons.Where(poke => poke.Name == name).ToList();
            var searchPokemonById = _context.Pokemons.Find(3);
            var pokemon = _context.Pokemons.Where(poke => EF.Functions.Like(poke.Name, "T%")).ToList();
        }

        private static void ShowPokemon()
        {
            using (var context = new PokemonContext())
            {
                var pokemons = context.Pokemons.ToList();
                foreach (var item in pokemons)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

        private static void Insert2Pokemon()
        {
            var pokemon1 = new Pokemon { Name = "Oishi" };
            var pokemon2 = new Pokemon { Name = "Pikachu" };
            using (var context = new PokemonContext())
            {
                context.Pokemons.AddRange(pokemon1, pokemon2);
                context.SaveChanges();
            }
        }

        private static void InsertPokemom()
        {
            var pokemon = new Pokemon { Name = "Pikachu" };
            using (var context = new PokemonContext())
            {
                context.Pokemons.Add(pokemon);
                context.SaveChanges();
            }
        }
    }
}
