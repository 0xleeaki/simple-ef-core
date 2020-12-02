using System;
using System.Linq;
using Newtonsoft.Json;

namespace SimpleConsole
{
    class Program
    {
        static NoteContext db = new NoteContext();
        static void Main(string[] args)
        {
            ReadListNote();
            var isAddNoteDone = AddNote();
            if (isAddNoteDone)
            {
                ReadListNote();
            }
        }

        public static bool AddNote()
        {
            Console.WriteLine("Input text to add note!");
            string note = Console.ReadLine();
            if (String.IsNullOrEmpty(note))
            {
                Console.WriteLine("Note is required!");
                return false;
            }
            else
            {
                Console.WriteLine("Insert note... {0}", note);
                db.Add(new Note { Content = note, NoteId = new Random().Next(int.MinValue, int.MaxValue) });
                db.SaveChanges();
                return true;
            }
        }

        public static bool DeleteNote(int id)
        {
            return true;
        }

        public static void ReadListNote()
        {
            Console.WriteLine("Init new context...");
            Console.WriteLine("Start get list note...");
            var notes = db.Notes.OrderBy(n => n.NoteId);
            Console.WriteLine(JsonConvert.SerializeObject(notes));
        }
    }
}
