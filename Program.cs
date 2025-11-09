using Spectre.Console;
using System.Collections.Generic;
using System.Linq;

namespace AsciiArtBannerTool
{
    class Program
    {
        // ASCII art for each letter (6 lines high)
        private static readonly Dictionary<char, string[]> LetterArt = new()
        {
            // A
            ['A'] = new[] {
                " █████╗ ",
                "██╔══██╗",
                "███████║",
                "██╔══██║",
                "██║  ██║",
                "╚═╝  ╚═╝"
            },
            // B
            ['B'] = new[] {
                "██████╗ ",
                "██╔══██╗",
                "██████╔╝",
                "██╔══██╗",
                "██████╔╝",
                "╚═════╝ "
            },
            // C
            ['C'] = new[] {
                " ██████╗",
                "██╔════╝",
                "██║     ",
                "██║     ",
                "██║     ",
                "╚═╝     "
            },
            // D
            ['D'] = new[] {
                "██████╗ ",
                "██╔══██╗",
                "██║  ██║",
                "██║  ██║",
                "██║  ██║",
                "╚═╝  ╚═╝"
            },
            // E
            ['E'] = new[] {
                "███████╗",
                "██╔════╝",
                "██║     ",
                "██║     ",
                "██║     ",
                "╚═╝     "
            },
            // F
            ['F'] = new[] {
                "███████╗",
                "██╔════╝",
                "██║     ",
                "██║     ",
                "██║     ",
                "╚═╝     "
            },
            // G
            ['G'] = new[] {
                " ██████╗",
                "██╔════╝",
                "██║     ",
                "██║  ███╗",
                "██║   ██║",
                "╚═╝   ╚═╝"
            },
            // H
            ['H'] = new[] {
                "██╗  ██╗",
                "██║  ██║",
                "███████║",
                "██╔══██║",
                "██║  ██║",
                "╚═╝  ╚═╝"
            },
            // I
            ['I'] = new[] {
                "███████╗",
                "  ██╔══╝",
                "  ██║   ",
                "  ██║   ",
                "  ██║   ",
                "  ╚═╝   "
            },
            // J
            ['J'] = new[] {
                "  ╚═════╗",
                "        ║",
                "        ║",
                "   ███╔╝",
                "   ██╔═╝",
                "   ╚═╝  "
            },
            // K
            ['K'] = new[] {
                "██╗  ██╗",
                "██║  ██║",
                "██║  ██║",
                "██╗  ██║",
                "██║  ██║",
                "╚═╝  ╚═╝"
            },
            // L
            ['L'] = new[] {
                "██╗     ",
                "██║     ",
                "██║     ",
                "██║     ",
                "███████╗",
                "╚══════╝"
            },
            // M
            ['M'] = new[] {
                "██╗  ██╗",
                "██║ ██╔╝",
                "█████╔╝ ",
                "██╔═██╗ ",
                "██║  ██╗",
                "╚═╝  ╚═╝"
            },
            // N
            ['N'] = new[] {
                "██╗  ██╗",
                "██║ ██╔╝",
                "█████╔╝ ",
                "██╔═██╗ ",
                "██║  ██║",
                "╚═╝  ╚═╝"
            },
            // O
            ['O'] = new[] {
                " ██████╗",
                "██╔════╝",
                "██║     ",
                "██║     ",
                "██║     ",
                "╚═╝     "
            },
            // P
            ['P'] = new[] {
                "██████╗ ",
                "██╔══██╗",
                "██████╔╝",
                "██╔══██╗",
                "██║  ██║",
                "╚═╝  ╚═╝"
            },
            // Q
            ['Q'] = new[] {
                " ██████╗",
                "██╔════╝",
                "██║     ",
                "██║     ",
                "██║ ███╗",
                "╚═╝╚══╝ "
            },
            // R
            ['R'] = new[] {
                "██████╗ ",
                "██╔══██╗",
                "██████╔╝",
                "██╔══██╗",
                "██║  ██║",
                "╚═╝  ╚═╝"
            },
            // S
            ['S'] = new[] {
                " ██████╗",
                "██╔════╝",
                "██╗     ",
                "██║     ",
                "██║     ",
                "╚═╝     "
            },
            // T
            ['T'] = new[] {
                "███████╗",
                "  ██╔══╝",
                "  ██║   ",
                "  ██║   ",
                "  ██║   ",
                "  ╚═╝   "
            },
            // U
            ['U'] = new[] {
                "██║  ██║",
                "██║  ██║",
                "██║  ██║",
                "██║  ██║",
                "███████║",
                "╚══════╝"
            },
            // V
            ['V'] = new[] {
                "██║  ██║",
                "██║  ██║",
                "██║  ██║",
                "██║  ██║",
                " ██╗██╔╝",
                "  ╚═╝╚═╝ "
            },
            // W
            ['W'] = new[] {
                "██║  ██║",
                "██║  ██║",
                "██║  ██║",
                "██║ ███║",
                "██║██╔██║",
                "╚═╝╚═╝╚═╝"
            },
            // X
            ['X'] = new[] {
                "██╗  ██╗",
                " ██╗██╔╝",
                "  ╚═╝  ",
                "  ╚═╝  ",
                " ██╗██╔╝",
                "██║  ██║"
            },
            // Y
            ['Y'] = new[] {
                "██║  ██╗",
                " ██╗██╔╝",
                "  ╚═╝  ",
                "  ╚═╝  ",
                "  ╚═╝  ",
                "  ╚═╝  "
            },
            // Z
            ['Z'] = new[] {
                "███████╗",
                "██╔════╝",
                "  ██║  ",
                "  ██║  ",
                "  ██║  ",
                "  ╚═╝  "
            },
            // Space
            [' '] = new[] {
                "        ",
                "        ",
                "        ",
                "        ",
                "        ",
                "        "
            }
        };

        static void Main(string[] args)
{
    // Configure Spectre.Console (initial banner display)
    AnsiConsole.MarkupLine("[bold cyan]╔══════════════════════════════════════════════════════════════════════╗[/]");
    AnsiConsole.MarkupLine("[bold cyan]║[/]                                                              [bold cyan]║[/]");
    AnsiConsole.MarkupLine("[bold cyan]║[/] [bold yellow]███████╗██╗███╗   ██╗██╗  ██╗███████╗███╗   ██╗███████╗████████╗[/]");
    AnsiConsole.MarkupLine("[bold cyan]║[/] [bold yellow]██╔════╝██║████╗  ██║██║ ██╔╝██╔════╝████╗  ██║██╔════╝╚══██╔══╝[/]");
    AnsiConsole.MarkupLine("[bold cyan]║[/] [bold yellow]█████╗  ██║██╔██╗ ██║█████╔╝ █████╗  ██╔██╗ ██║█████╗     ██║   [/]");
    AnsiConsole.MarkupLine("[bold cyan]║[/] [bold yellow]██╔══╝  ██║██║╚██╗██║██╔═╝  ██╔══╝  ██║╚██╗██║██╔══╝     ██║   [/]");
    AnsiConsole.MarkupLine("[bold cyan]║[/] [bold yellow]██║     ██║██║ ╚████║██║  ██╗███████╗██║ ╚████║███████╗   ██║   [/]");
    AnsiConsole.MarkupLine("[bold cyan]║[/] [bold yellow]╚═╝     ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   [/]");
    AnsiConsole.MarkupLine("[bold cyan]║[/]                                                              [bold cyan]║[/]");
    AnsiConsole.MarkupLine("[bold cyan]╚══════════════════════════════════════════════════════════════════════╝[/]");

    // Display info (one-time)
    AnsiConsole.MarkupLine("");
    AnsiConsole.MarkupLine("[bold green]👤 Created by:[/]");
    AnsiConsole.MarkupLine("[underline blue]@akgamerz_790[/]");
    AnsiConsole.MarkupLine("");
    AnsiConsole.MarkupLine("[bold green]📂 GitHub:[/]");
    Console.WriteLine("https://github.com/akgamerz790/GameZ");
    AnsiConsole.MarkupLine("");
    AnsiConsole.MarkupLine("[bold green]📝 About:[/]");
    AnsiConsole.MarkupLine("[dim white]Cool ASCII art banner generator that automatically strips 's' letters from your input text.[/]");
    AnsiConsole.MarkupLine("");
    AnsiConsole.MarkupLine("[bold green]Type 'n' to exit after each generation.[/]");
    AnsiConsole.MarkupLine("");

    // Main loop: Repeat until user chooses to exit
    while (true)
{
    var prompt = AnsiConsole.Prompt(
        new TextPrompt<string>("[bold magenta]✏️  Enter your text to generate banner:[/]")
            .PromptStyle("bold magenta")
            .Validate(text => !string.IsNullOrWhiteSpace(text))
    );

    var processedText = StripLetters(prompt.ToUpper());
    var banner = GenerateBanner(processedText);

    DisplayRainbowBanner(banner);

    AnsiConsole.MarkupLine("");
    AnsiConsole.MarkupLine("[bold green]🎉 Banner generated successfully![/]");
    AnsiConsole.MarkupLine("[dim yellow]Original text:[/]");
    AnsiConsole.MarkupLine($"[dim white]{Markup.Escape(prompt)}[/]");
    AnsiConsole.MarkupLine("[dim yellow]Processed text (without 's' letters):[/]");
    AnsiConsole.MarkupLine($"[dim white]{Markup.Escape(processedText)}[/]");
                AnsiConsole.MarkupLine("");

    // Ask confirmation to continue
    var confirmationPrompt = new ConfirmationPrompt("Generate another banner?");
    confirmationPrompt.DefaultValue = true;
    confirmationPrompt.ShowChoices = true;
    confirmationPrompt.Yes = 'y';
    confirmationPrompt.No = 'n';

var continueGenerating = AnsiConsole.Prompt(confirmationPrompt);

    var continueGenerating = AnsiConsole.Prompt(
        new ConfirmationPrompt("[bold cyan]Generate another banner?[/]")
            .DefaultValue(true)  // Default is yes
            .ShowChoices()
            .Yes('y')
            .No('n')
    );

    if (!continueGenerating)
    {
        AnsiConsole.MarkupLine("[bold green]👋 Thanks for using ASCIIGenSharp! Goodbye![/]");
        break;
    }

    AnsiConsole.MarkupLine("");
}

}

        static string StripLetters(string input)
        {
            // Remove 'S' letters (case insensitive)
            return new string(input.Where(c => c != 'S' && c != 's').ToArray());
        }

        static string[] GenerateBanner(string text)
        {
            var lines = new string[6]; // 6 lines for each letter
            for (int i = 0; i < 6; i++)
            {
                lines[i] = "";
            }

            var characters = text.ToCharArray();
            for (int charIndex = 0; charIndex < characters.Length; charIndex++)
            {
                char c = characters[charIndex];
                char upperC = char.ToUpper(c);

                if (LetterArt.TryGetValue(upperC, out string[] letter))
                {
                    for (int lineIndex = 0; lineIndex < 6; lineIndex++)
                    {
                        lines[lineIndex] += letter[lineIndex] ?? LetterArt[' '][lineIndex] ?? "";
                        // Add spacing between letters
                        if (charIndex < characters.Length - 1)
                        {
                            lines[lineIndex] += " ";
                        }
                    }
                }
                else
                {
                    // For unsupported characters, add spaces
                    for (int lineIndex = 0; lineIndex < 6; lineIndex++)
                    {
                        lines[lineIndex] += (LetterArt[' '][lineIndex] ?? "");
                        if (charIndex < characters.Length - 1)
                        {
                            lines[lineIndex] += " ";
                        }
                    }
                }
            }

            return lines;
        }

        static void DisplayRainbowBanner(string[] bannerLines)
        {
            // White text borders (unchanged for consistency)
            AnsiConsole.MarkupLine("");
            AnsiConsole.MarkupLine("[bold white on black]══════════════════════════════════════════════════════════[/]");

            // Plain white bold text for all ASCII lines
            for (int i = 0; i < bannerLines.Length; i++)
            {
                AnsiConsole.MarkupLine($"[bold white]{bannerLines[i]}[/]");
            }

            AnsiConsole.MarkupLine("[bold white on black]══════════════════════════════════════════════════════════[/]");
        }

    }
}
