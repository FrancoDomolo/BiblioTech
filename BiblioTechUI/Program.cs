using BiblioTechBL;
using BiblioTechBL.Entities;
using BiblioTechBL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UIUtils.ColorClass;
using static UIUtils.InputLib;

namespace BiblioTechUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMainBL mainBL = new MainBL();
            TypeColor("\t---BiblioTech---\t\n", ConsoleColor.Green);
            TypeColor("Scegli un'opzione\n\n", ConsoleColor.DarkCyan);
            string input = string.Empty;
            do
            {
                MostraAiuto();
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("I libri disponibili sono:");
                        foreach (Libro libro in mainBL.GetDisponibili())
                        {
                            TypeColor(libro.Nome + "\n", ConsoleColor.Green);
                        }
                        break;
                    case "2":
                        Console.WriteLine("I libri in prestito sono: ");
                        foreach (Libro libro in mainBL.GetInPrestito())
                        {
                            TypeColor(libro.Nome + "\n", ConsoleColor.Green);
                        }
                        break;
                    case "3":
                        AggiungiLibro(mainBL);
                        break;
                    case "4":
                        TogliLibro(mainBL);
                        break;
                    case "5":
                        Console.WriteLine("Gli utenti inattivi sono:");
                        foreach (Iscritto iscritto in mainBL.GetInattvi())
                        {
                            TypeColor(iscritto.Nome + "\n", ConsoleColor.DarkRed);
                        };
                        break;
                    case "6":
                        Console.WriteLine("Gli utenti ritardatari sono:");
                        foreach (Iscritto iscritto in mainBL.GetRitardatari())
                        {
                            TypeColor(iscritto.Nome + "\n", ConsoleColor.DarkYellow);
                        };
                        break;
                    default:
                        TypeColor("Errore nell'input", ConsoleColor.Red);
                        break;
                }
            } while (input != "Q" | input != "q");

        }

        static void MostraAiuto()
        {

            TypeColor("1) Mostra tutti i libri disponibili\n" +
                "2) Mostra i libri in prestito\n" +
                "3) Aggiungi un libro\n" +
                "4) Togli un libro\n" +
                "5) Mostra inattivi\n" +
                "6) Mostra ritardatari\n",
                ConsoleColor.Cyan);
        }

        static void AggiungiLibro(IMainBL logic) {
            Console.WriteLine("Inserisci i dati del libro");
            int id = ReadNaturalNumberFromConsole("ID:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Autore:");
            string autore = Console.ReadLine();
            int pubblicazione = ReadNaturalNumberFromConsole("Anno di pubblicazione:");
            Console.WriteLine("Genere:");
            string genere = Console.ReadLine();

            Libro libro = new Libro(id, nome, autore, pubblicazione, genere, true);
            logic.AddLibro(libro);
            TypeColor($"{libro.Nome} Aggiunto al catalogo libri.\n", ConsoleColor.Green);
        }
        static void TogliLibro(IMainBL logic) {
            int id = ReadNaturalNumberFromConsole("Id del libro da rimuovere:");
            string name = logic.GetLibroById(id).Nome;
            logic.RemoveLibroById(id);
            TypeColor($"{name} tolto dal catalogo\n", ConsoleColor.Red);
        }

    }
}