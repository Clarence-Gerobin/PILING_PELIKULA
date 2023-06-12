using System;
using System.Collections.Generic;

namespace PilingPelikula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Piling Pelikula!");

            bool exitProgram = false;
            while (!exitProgram)
            {
                // Available genres
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nChoose a genre: ");
                Console.WriteLine("1. Horror");
                Console.WriteLine("2. Comedy");
                Console.WriteLine("3. Romance");
                Console.WriteLine("4. History and Documentary");
                Console.WriteLine("5. Exit");

                // User's options
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nEnter your choice: ");
                int genreChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

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
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nExiting the program...");
                        Console.WriteLine("Salamat at sa susunod ulit!");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                if (exitProgram)
                    break;

                // Movie synopses
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nEnter your choice: ");
                int movieChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;

                switch (genreChoice)
                {
                    case 1:
                        switch (movieChoice)
                        {
                            case 1:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Clarita synopsis:");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Clarita\" is a Filipino horror film based on true events set in the 1950s."      +
                                                  "\nThe story follows Clarita Villanueva, a young girl who becomes possessed"          +
                                                  "\nby a demonic entity. As her possession intensifies, a psychiatrist and \na "       +
                                                  "skeptical priest join forces to uncover the truth behind her condition \nand "       +
                                                  "perform an exorcism to save her soul. Filled with terrifying \nencounters and "      +
                                                  "a battle between good and evil,\"Clarita\" delves into \nthe supernatural realm "    +
                                                  "and explores themes of faith and redemption.\r\n");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White; ;
                                break;
                            case 2:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Aurora synopsis:");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Aurora\" is a 2018 Filipino horror-thriller film where a woman named Leana, "    +
                                                  "\nwho runs a salvage business, uncovers supernatural occurrences and a string \nof " +
                                                  "mysterious deaths connected to a sunken ship. She must confront the \nterrifying "   +
                                                  "forces at play to protect herself and those around her.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 3:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Sunod synopsis:");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Sunod\" is a 2019 Filipino horror film directed by Carlo Ledesma. \nThe story "  +
                                                  "revolves around Olivia, a single mother who becomes a \nsecurity guard in a haunted" +
                                                  " high-rise building to support her \ndaughter's medical needs. As Olivia grapples "  +
                                                  "with eerie \noccurrences and encounters vengeful spirits, she must uncover \nthe "   +
                                                  "building's dark secrets and confront her deepest fears to \nprotect her daughter "   +
                                                  "from the supernatural forces at play.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 4:
                                continue;
                            case 5:
                                exitProgram = true;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nExiting the program...");
                                Console.WriteLine("Salamat at sa susunod ulit!");
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    case 2:
                        switch (movieChoice)
                        {
                            case 1:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Booba synopsis:");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Booba\" is a 2001 Filipino comedy film directed by Joyce Bernal. The story "        +
                                                  "\nrevolves around Booba, a simple-minded and good-natured woman who moves \nfrom "      +
                                                  "the province to Manila. As she tries to adapt to city life, Booba \nfinds herself "     +
                                                  "in humorous situations, encountering eccentric \ncharacters and experiencing comical "  +
                                                  "mishaps along the way. The film \nshowcases Booba's lighthearted journey, filled with " +
                                                  "laughter and \nunexpected encounters.\r\n");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 2:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Private Benjamin synopsis:");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Private Benjamin\" is a 2011 Filipino comedy film starring Vice Ganda. "            +
                                                  "\nThe movie follows the comedic journey of Benjamin Santos, a gay man \nwho "           +
                                                  "enlists in the Philippine Army and brings his unique personality \nand "                +
                                                  "humor to the military setting. Through hilarious situations and \ncomedic "             +
                                                  "twists, Benjamin's character adds laughter and \nlight-heartedness to "                 +
                                                  "his military training.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                break;
                            case 3:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Girl, Boy, Bakla, Tomboy synopsis:");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Girl, Boy, Bakla, Tomboy\" is a 2013 Filipino comedy film directed "                +
                                                  "by \nWenn V. Deramas. The movie revolves around quadruplets played by "                 +
                                                  "\nVice Ganda, each with a distinct personality and sexual orientation."                 +
                                                  "\nThe story follows their humorous and intertwined journey, filled "                    + 
                                                  "\nwith mistaken identities, comedic encounters, and family dynamics,"                   +
                                                  "\nproviding a light-hearted and entertaining comedy experience.\r\n");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 4:
                                continue;
                            case 5:
                                exitProgram = true;
                                Console.WriteLine("\nExiting the program...");
                                Console.WriteLine("Salamat at sa susunod ulit!");
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    case 3:
                        switch (movieChoice)
                        {
                            case 1:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Barcelona: A Love Untold synopsis: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Barcelona: A Love Untold\" is a 2016 Filipino romantic drama film "        +
                                                  "directed \nby Olivia Lamasan. The story follows the lives of Ely and Mia, "    +
                                                  "two Filipino \nimmigrants in Barcelona, as they find solace and love in "      +
                                                  "each other's \ncompany while confronting their pasts and pursuing their "      +
                                                  "dreams. It's a \ntale of healing, forgiveness, and the transformative "        +
                                                  "power of love.\r\n");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 2:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Never Not Love You synopsis: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Never Not Love You\" is a 2018 Filipino romantic drama film directed "     +
                                                  "by \nAntoinette Jadaone. The movie follows the story of Gio and Joanne, a "    +
                                                  "\nyoung couple who fall deeply in love. As they navigate the complexities "    +
                                                  "\nof their individual career paths and personal growth, they must confront "   +
                                                  "\nthe sacrifices and choices required to sustain their relationship. "         +
                                                  "\n\"Never Not Love You\" explores the joys and challenges of young love "      +
                                                  "and \nthe pursuit of dreams.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 3:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Vince, Kath and James synopsis: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Vince, Kath and James\" is a 2016 Filipino teen romantic comedy film "     +
                                                  "\ndirected by Theodore Boborol. The story follows the lives of Vince \nand "   +
                                                  "Kath, two high school students who develop a romantic connection \nthrough"    +
                                                  " text messages and online interactions. However, complications \narise when"   +
                                                  " Vince's best friend, James, also becomes interested in Kath. \nThe movie "    +
                                                  "explores the dynamics of friendship, love, and the challenges \nfaced by "     +
                                                  "the three characters as they navigate their emotions \nand relationships.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 4:
                                continue;
                            case 5:
                                exitProgram = true;
                                Console.WriteLine("\nExiting the program...");
                                Console.WriteLine("Salamat at sa susunod ulit!");
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    case 4:
                        switch (movieChoice)
                        {
                            case 1:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("The Kingmaster synopsis: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\nExplore the controversial political career of Imelda Marcos, the former \nfirst"   +
                                                  " lady of the Philippines, in this extraordinary documentary. \nWitness her opulent"  +
                                                  " lifestyle, behind-the-scenes influence, and the \nMarcos family's history of "      + 
                                                  "corruption, extravagance, and brutality. \nThis cautionary tale reveals the story"   +
                                                  " of a powerful female leader \nwhose questionable sense of reality left a nation "   +
                                                  "divided.\r\n");  
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 2:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Goyo: Ang batang Heneral synopsis:");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Goyo: Ang Batang Heneral\" is a 2018 Filipino historical biographical \nfilm "   +
                                                  "directed by Jerrold Tarog. It portrays the life of Gregorio \n\"Goyo\" del Pilar,"   +
                                                  " a young general during the Philippine-American War. \nThe film follows Goyo's rise" +
                                                  " as a military leader, his personal \nstruggles, and his role in the fight for "     +
                                                  "Philippine independence. \nIt explores themes of heroism, sacrifice, and the "       +
                                                  "complexities of war, \nproviding a glimpse into Goyo's significant contribution "    +
                                                  "to Philippine history.\r\n");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 3:
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Heneral Luna synopsis: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\"Heneral Luna\" is a 2015 Filipino historical biographical film directed "        +
                                                  "\nby Jerrold Tarog. It tells the story of General Antonio Luna, a fierce \nand "     +
                                                  "principled leader during the Philippine-American War. The film \nfocuses on "        + 
                                                  "Luna's struggles against internal conflicts, political rivals, \nand the "           +
                                                  "challenges of uniting his countrymen in the fight for Philippine "                   +
                                                  "\nindependence. It explores themes of patriotism, heroism, and the \ncomplexities"   +
                                                  " of leadership in a time of war.\r\n");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 4:
                                continue;
                            case 5:
                                exitProgram = true;
                                Console.WriteLine("\nExiting the program...");
                                Console.WriteLine("Salamat at sa susunod ulit!");
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
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
