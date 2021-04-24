using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Certificate.CBasic
{
    public class NotesStore
    {
         public NotesStore() {}
         public List<Note> notes { get; set; }
        public void AddNote(String state, String name) {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be empty");

            }
            if(!Enum.IsDefined(typeof(state), state))
            {
                  throw new ArgumentException($"invalid state {state}");
            }
            notes.Add(new Note{Name=name, State=state});

        }
        public List<String> GetNotes(String state) {
             if(!Enum.IsDefined(typeof(state), state))
            {
                  throw new ArgumentException($"invalid state {state}");
            }
            var notess = notes.Where(x=>x.State.Equals(state)).Select(x=>x.Name).ToList();
            return notess;

        }
    }
    public class Note{
        public string Name { get; set; }
        public string State { get; set; }
    }
    enum state
    {
        completed,
        active, 
        others
    }
}