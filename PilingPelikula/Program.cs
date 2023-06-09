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
                                Console.WriteLine("\nClarita synopsis: A young woman is apprehended and held by police when they suspect that she is possessed by a demon.");
                                break;
                            case 2:
                                Console.WriteLine("\nAurora synopsis: The passenger ship Aurora mysteriously collides into the rocky sea threatening an entire island. \nA young woman and her sister must both survive by finding the missing dead for a bounty.");
                                break;
                            case 3:
                                Console.WriteLine("\nSunod synopsis: A woman who is desperate to find the cure for her daughter's illness takes a job at a call center, only to be haunted by the ghost in it.");
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
                                Console.WriteLine("\nBooba synopsis: A girl promises to her dying mother that she'll find her long-lost sister who ran away from home.");
                                break;
                            case 2:
                                Console.WriteLine("\nPrivate Benjamin synopsis: When civil war breaks out in the Philippines, \na gay dance teacher (Vice Ganda) is forced to join the military in order to spare his ailing father.");
                                break;
                            case 3:
                                Console.WriteLine("\nGirl, Boy, Bakla, Tomboy synopsis: Quadruplets are split into pairs and raised apart by their parents. \nThey meet as adults by accident and have a tough choice to make when one needs a liver transplant.");
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
                                Console.WriteLine("\nBarcelona: A Love Untold synopsis: While earning a degree in Spain, \na young architecture student dealing with grief meets a fellow expatriate trying to escape her past.");
                                break;
                            case 2:
                                Console.WriteLine("\nNever Not Love You synopsis: Two young lovers meet and fall in love. \nTogether they build a life until career opportunities bring them out of the country. \nOut of the comforts of home and with individual careers going different directions. Will their love survive?");
                                break;
                            case 3:
                                Console.WriteLine("\nVince, Kath and James synopsis: Love can be complicated, \nespecially when Vince agrees to secretly woo Kath via text on behalf of James, while falling for her, too.");
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
                                Console.WriteLine("\nThe Kingmaster synopsis: Filmmaker Lauren Greenfield examines the controversial history of Filipino politician Imelda Marcos and her family.");
                                break;
                            case 2:
                                Console.WriteLine("\nGoyo: Ang batang Heneral synopsis: The life of Gregorio `Goyo' del Pilar, one of the youngest generals during the Philippine-American War, \nwho fought in the Battle of Tirad Pass.");
                                break;
                            case 3:
                                Console.WriteLine("\nHeneral Luna synopsis: In 1898, Gen. Antonio Luna (John Arcilla) faces resistance from his own countrymen as he fights for freedom during the Philippine-American War.");
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




