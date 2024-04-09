﻿/*Created by: Robert James Newell-Landry
In the Unknown of Psychosis, where adventure awaits in the vast expanses of Thear, your journey begins amidst the intricate tapestry of the Main Hall of Nexus Tavern, nestled within the bustling town of Nexus, Bractalia. Here, amidst the clinking of tankards and murmurs of patrons, your tale unfurls with boundless possibilities.
As you venture forth, prepare to navigate a fully explorable solar system, where round planets beckon exploration and discovery. Engage in tactical combat, where each move is pivotal, utilizing a limb removal system that adds depth and strategy to every encounter.
But it's not just combat that shapes your journey; immerse yourself in an ecosystem simulation where animal communication hints at the secrets of the wild. Beyond mere survival, aspire to greatness as you raise a nation to power, navigating the complexities of multi-faction warfare while managing logistics, agriculture, commerce, and succession.
Within the social fabric of Thear, navigate a bounty system that tests your mettle and reputation. Forge alliances, create hierarchies, or challenge rivals as you navigate a spectrum of loyalty, fear, respect, and morality, all under the jurisdiction of a dynamic justice system tied to territorial borders.
Time flows seamlessly, marked by day/night cycles and shifting seasons, as you engage in the construction, repair, and destruction of structures, shaping entire villages according to your will. Decide the fate of prisoners, wield influence over named locations and objects, and commandeer the aid of others to build armies or delegate tasks.
Supply and demand drive a barter system fueled by an expansive array of renewable and non-renewable resources, while an in-depth crafting system, intertwined with metallurgy, allows for the creation of powerful artifacts and tools essential for survival.
Survival itself is a challenge, with oxygen, temperature, disease, hunger, energy, sanity, hygiene, and waste all factors to consider. Grow and evolve your character through a comprehensive system of advancement and learning, utilizing futuristic customization options and genetic manipulation to craft unique personas suited to your playstyle.
In Psychosis, every choice matters, every action shapes your destiny.Embark on an odyssey through Thear, where the boundaries of reality blur, and the possibilities are as infinite as the cosmos itself.
*/

using System;
using System.Collections.Generic;

namespace Initialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the console window size
            Console.SetWindowSize(100, 40);

            // Set the console title
            Console.Title = "Psychosis: Initialization";
            Console.ReadKey();

            // Set the console colours
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey(true);

            // Display the interface description
            Console.WriteLine(interfaceDescription);

            // Execute the initialization
            Initialization game = new Initialization();
            game.Initialize();

            // Reset the console colours
            Console.ResetColor();

            // Character initialization and creation
        }

        // Colour palette for the interface
        static Dictionary<string, Dictionary<string, string>> colours = new Dictionary<string, Dictionary<string, string>>()
    {
        {
            "background", new Dictionary<string, string>()
            {
                { "window", "\u001b[47m" }, // Light Gray
                { "control", "\u001b[37m" }, // White
                { "progress", "\u001b[6m" } // Dark Turquoise
            }
        },
        {
            "text", new Dictionary<string, string>()
            {
                { "window", "\u001b[30m" }, // Black
                { "control", "\u001b[30m" }, // Black
                { "progress", "\u001b[30m" } // Black
            }
        },
        {
            "highlight", new Dictionary<string, string>()
            {
                { "control", "\u001b[36m" } // Dark Turquoise
            }
        },
        {
            "selected", new Dictionary<string, string>()
            {
                { "control", "\u001b[100m" } // Dark Gray
            }
        }
    };

        // Interface description
        static string interfaceDescription = @"
Welcome to the world of Psychosis, set in the vibrant realm of Thear. As you explore this vast and immersive universe, you'll encounter a variety of environments and challenges. To enhance your experience, we've designed a visually stunning interface with carefully chosen colours.

Colour Palette:
- Background:
  - Window: {colours[""background""][""window""]} (Light Gray)
  - Control: {colours[""background""][""control""]} (White)
  - Progress: {colours[""background""][""progress""]} (Dark Turquoise)
- Text:
  - Window: {colours[""text""][""window""]} (Black)
  - Control: {colours[""text""][""control""]} (Black)
  - Progress: {colours[""text""][""progress""]} (Black)
- Highlight:
  - Control: {colours[""highlight""][""control""]} (Dark Turquoise)
- Selected:
  - Control: {colours[""selected""][""control""]} (Dark Gray)

These colours have been selected to provide a clear and immersive experience as you navigate the world of Psychosis. Whether you're engaging in tactical combat, managing your nation, or exploring the ecosystem, these colours will help you stay focused and engaged.

We hope you enjoy your adventure in Psychosis, where every choice you make shapes the world around you. Dive in and explore the possibilities that await!";
    }
}
