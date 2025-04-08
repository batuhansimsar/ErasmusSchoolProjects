using DocumentLibrary;
using DocumentLibrary.Models;
using DocumentLibrary.Exceptions;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Document Management System");
        Console.ResetColor();

        var manager = new DocumentManager();

        try
        {
            // Add some books
            var book1 = new Book("123", "The Great Gatsby", 1925, 180, "F. Scott Fitzgerald");
            var book2 = new Book("456", "1984", 1949, 328, "George Orwell");

            // Add some volumes
            var volume1 = new Volume("789", "Lord of the Rings", 1954, 1178, "J.R.R. Tolkien", 1, 3);
            var volume2 = new Volume("012", "Lord of the Rings", 1954, 1178, "J.R.R. Tolkien", 2, 3);

            // Add some magazines
            var magazine1 = new Magazine("345", "Time", 2023, 100, 1, Frequency.Monthly);
            var magazine2 = new Magazine("678", "Newsweek", 2023, 80, 1, Frequency.Weekly);

            manager.AddDocument(book1);
            manager.AddDocument(book2);
            manager.AddDocument(volume1);
            manager.AddDocument(volume2);
            manager.AddDocument(magazine1);
            manager.AddDocument(magazine2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAll documents:");
            Console.ResetColor();
            foreach (var doc in manager.SearchByTitle(""))
            {
                Console.WriteLine(doc);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSearching for 'Lord':");
            Console.ResetColor();
            foreach (var doc in manager.SearchByTitle("Lord"))
            {
                Console.WriteLine(doc);
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nMonthly magazines:");
            Console.ResetColor();
            foreach (var mag in manager.GetMagazinesByFrequency(Frequency.Monthly))
            {
                Console.WriteLine(mag);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPrinting all documents:");
            Console.ResetColor();
            foreach (var doc in manager.SearchByTitle(""))
            {
                Console.WriteLine(doc.Print());
            }

            // Test exceptions
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nTesting exceptions:");
            Console.ResetColor();

            // Try to add duplicate ISBN
            manager.AddDocument(book1);

            // Try to add invalid volume
            var invalidVolume = new Volume("999", "Invalid", 2023, 100, "Author", 5, 3);
            manager.AddDocument(invalidVolume);

            // Try to add book with invalid year
            var invalidBook = new Book("888", "Invalid", 1000, 100, "Author");
            manager.AddDocument(invalidBook);
        }
        catch (DocumentAlreadyExistsException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {ex.Message}");
            Console.ResetColor();
        }
        catch (InvalidVolumeNumberException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {ex.Message}");
            Console.ResetColor();
        }
        catch (InvalidPublicationYearException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {ex.Message}");
            Console.ResetColor();
        }
    }
}
