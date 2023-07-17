using System;

namespace PokemonBattleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Pokemon has appeared!");
            Console.ReadLine();

            Pokemon pikachu = new Pokemon("Pikachu", "Electric", 100, 50);
            pikachu.DisplayPokemonDetails();
            Console.ReadLine();

            Pokemon squirtle = new Pokemon("Squirtle", "Water", 90, 60);
            squirtle.DisplayPokemonDetails();
            Console.ReadLine();

            Console.WriteLine("Let the battle begin!");
            Console.ReadLine();

            while (pikachu.IsAlive() && squirtle.IsAlive())
            {
                pikachu.Attack(squirtle);
                Console.ReadLine();

                if (!squirtle.IsAlive())
                    break;

                squirtle.Attack(pikachu);
                Console.ReadLine();

                if (!pikachu.IsAlive())
                    break;
            }

            Console.WriteLine("Battle ended!");
            Console.ReadLine();

            if (pikachu.IsAlive())
            {
                Console.WriteLine($"{pikachu.pokemonName} is the winner!");
            }
            else if (squirtle.IsAlive())
            {
                Console.WriteLine($"{squirtle.pokemonName} is the winner!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

            Console.ReadLine();
        }

        class Pokemon
        {
            public string pokemonName;
            public string pokemonType;
            public int pokemonHp;
            public int pokemonDmg;

            public Pokemon(string pokemonName, string pokemonType, int pokemonHp, int pokemonDmg)
            {
                this.pokemonName = pokemonName;
                this.pokemonType = pokemonType;
                this.pokemonHp = pokemonHp;
                this.pokemonDmg = pokemonDmg;
            }

            public void Attack(Pokemon target)
            {
                target.pokemonHp -= this.pokemonDmg;
                Console.WriteLine($"{this.pokemonName} attacks {target.pokemonName} for {this.pokemonDmg} damage!");
                Console.WriteLine($"{target.pokemonName} has {target.pokemonHp} HP remaining.");
                Console.WriteLine();
            }

            public bool IsAlive()
            {
                return pokemonHp > 0;
            }

            public void DisplayPokemonDetails()
            {
                Console.WriteLine($"Pokemon {pokemonName} is a {pokemonType} type, has {pokemonHp} HP, and can deal {pokemonDmg} damage!");
            }
        }
    }
}