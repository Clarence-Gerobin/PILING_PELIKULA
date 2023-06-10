using System;
using System.Collections.Generic;

namespace PilingPelikula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piling Pelikula!");

            bool exitProgram = false;
            while (!exitProgram)
            {
                // Available genres
                Console.WriteLine("\nChoose a genre: ");
                Console.WriteLine("1. Horror");
                Console.WriteLine("2. Comedy");
                Console.WriteLine("3. Romance");
                Console.WriteLine("4. History and Documentary");
                Console.WriteLine("5. Exit");

                // User's options
                Console.Write("\nEnter your choice: ");
                int genreChoice = Convert.ToInt32(Console.ReadLine());

                switch (genreChoice)
                {
                    case 1:
                        Console.WriteLine("\nChoose a horror movie: ");
                        List<string> horrorMovies = new List<string>
                        {
                            "Clarita",
                            "Aurora",
                            "Sunod"
                        };
                        DisplayMovieList(horrorMovies);
                        break;
                    case 2:
                        Console.WriteLine("\nChoose a comedy movie: ");
                        List<string> comedyMovies = new List<string>
                        {
                            "Booba",
                            "Private Benjamin",
                            "Girl, Boy, Bakla, Tomboy"
                        };
                        DisplayMovieList(comedyMovies);
                        break;
                    case 3:
                        Console.WriteLine("\nChoose a romantic movie: ");
                        List<string> romanticMovies = new List<string>
                        {
                            "Barcelona: A Love Untold",
                            "Never Not Love You",
                            "Vince, Kath and James"
                        };
                        DisplayMovieList(romanticMovies);
                        break;
                    case 4:
                        Console.WriteLine("\nChoose a historical or documentary movie: ");
                        List<string> historicDocuMovies = new List<string>
                        {
                            "The Kingmaster",
                            "Goyo: Ang Batang Heneral",
                            "Heneral Luna"
                        };
                        DisplayMovieList(historicDocuMovies);
                        break;
                    case 5:
                        exitProgram = true;
                        Console.WriteLine("\nExiting the program...");
                        Console.WriteLine("Salamat at sa susunod ulit!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                if (exitProgram)
                    break;

                // Movie synopses
                Console.Write("\nEnter your choice: ");
                int movieChoice = Convert.ToInt32(Console.ReadLine());

                switch (genreChoice)
                {
                    case 1:
                        switch (movieChoice)
                        {
                            case 1:
                                Console.WriteLine("\n–––––––––––––––––––––––––");
                                Console.WriteLine("Clarita synopsis:");
                                Console.WriteLine("\nA young woman is apprehended and held by police when they suspect that she is possessed by a demon.");
                                Console.WriteLine("\n–––––––––––––––––––––––––");
                                break;
                            case 2:
                                Console.WriteLine("\n–––––––––––––––––––––––––");
                                Console.WriteLine("Aurora synopsis:");
                                Console.WriteLine("\nThe passenger ship Aurora mysteriously collides into the rocky sea threatening an entire island. \nA young woman and her sister must both survive by finding the missing dead for a bounty.");
                                Console.WriteLine("\n–––––––––––––––––––––––––");
                                break;
                            case 3:
                                Console.WriteLine("\n–––––––––––––––––––––––––");
                                Console.WriteLine("Sunod synopsis:");
                                Console.WriteLine("\nA woman who is desperate to find the cure for her daughter's illness takes a job at a call center, only to be haunted by the ghost in it.");
                                Console.WriteLine("\n–––––––––––––––––––––––––");
                                break;
                            case 4:
                                continue;
                            case 5:
                                exitProgram = true;
                                Console.WriteLine("\nExiting the program...");
                                Console.WriteLine("Salamat at sa susunod ulit!");
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    case 2:
                        switch (movieChoice)
                        {
                            case 1:
                                Console.WriteLine("\n–––––––––––––––––––––––––");
                                Console.WriteLine("Booba synopsis:");
                                Console.WriteLine("\nA girl promises to her dying mother that she'll find her long-lost sister who ran away from home.");
                                Console.WriteLine("\n–––––––––––––––––––––––––");
                                break;
                            case 2:
                                Console.WriteLine("\n––––––––––––––––––––––––––––––");
                                Console.WriteLine("Private Benjamin synopsis:");
                                Console.WriteLine("\nWhen civil war breaks out in the Philippines, \na gay dance teacher (Vice Ganda) is forced to join the military in order to spare his ailing father.");
                                Console.WriteLine("\n––––––––––––––––––––––––––––––");
                                break;
                            case 3:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––");
                                Console.WriteLine("Girl, Boy, Bakla, Tomboy synopsis:");
                                Console.WriteLine("\nQuadruplets are split into pairs and raised apart by their parents. \nThey meet as adults by accident and have a tough choice to make when one needs a liver transplant.");
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––");
                                break;
                            case 4:
                                continue;
                            case 5:
                                exitProgram = true;
                                Console.WriteLine("\nExiting the program...");
                                Console.WriteLine("Salamat at sa susunod ulit!");
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    case 3:
                        switch (movieChoice)
                        {
                            case 1:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––");
                                Console.WriteLine("Barcelona: A Love Untold synopsis: ");
                                Console.WriteLine("\nWhile earning a degree in Spain, \na young architecture student dealing with grief meets a fellow expatriate trying to escape her past.");
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––");
                                break;
                            case 2:
                                Console.WriteLine("\n––––––––––––––––––––––––––––––––––");
                                Console.WriteLine("Never Not Love You synopsis: ");
                                Console.WriteLine("\nTwo young lovers meet and fall in love. \nTogether they build a life until career opportunities bring them out of the country. \nOut of the comforts of home and with individual careers going different directions. Will their love survive?");
                                Console.WriteLine("\n––––––––––––––––––––––––––––––––––");
                                break;
                            case 3:
                                Console.WriteLine("\n––––––––––––––––––––––––––––––––––––");
                                Console.WriteLine("Vince, Kath and James synopsis: ");
                                Console.WriteLine("\nLove can be complicated, \nespecially when Vince agrees to secretly woo Kath via text on behalf of James, while falling for her, too.");
                                Console.WriteLine("\n––––––––––––––––––––––––––––––––––––");
                                break;
                            case 4:
                                continue;
                            case 5:
                                exitProgram = true;
                                Console.WriteLine("\nExiting the program...");
                                Console.WriteLine("Salamat at sa susunod ulit!");
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    case 4:
                        switch (movieChoice)
                        {
                            case 1:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––");
                                Console.WriteLine("The Kingmaster synopsis: ");
                                Console.WriteLine("\nFilmmaker Lauren Greenfield examines the controversial history of Filipino politician Imelda Marcos and her family.");
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––");
                                break;
                            case 2:
                                Console.WriteLine("\n––––––––––––––––––––––––––––––––––––––––");
                                Console.WriteLine("Goyo: Ang batang Heneral synopsis:");
                                Console.WriteLine("\nThe life of Gregorio `Goyo' del Pilar, one of the youngest generals during the Philippine-American War, \nwho fought in the Battle of Tirad Pass.");
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––");
                                break;
                            case 3:
                                Console.WriteLine("\n––––––––––––––––––––––––––");
                                Console.WriteLine("Heneral Luna synopsis: ");
                                Console.WriteLine("\nIn 1898, Gen. Antonio Luna (John Arcilla) faces resistance from his own countrymen as he fights for freedom during the Philippine-American War.");
                                Console.WriteLine("––––––––––––––––––––––––––––");
                                break;
                            case 4:
                                continue;
                            case 5:
                                exitProgram = true;
                                Console.WriteLine("\nExiting the program...");
                                Console.WriteLine("Salamat at sa susunod ulit!");
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        static void DisplayMovieList(List<string> movies)
        {
            for (int j = 0; j < movies.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {movies[j]}");
            }
            Console.WriteLine("4. Go back to genre selection");
            Console.WriteLine("5. Exit");
        }

    }
}




