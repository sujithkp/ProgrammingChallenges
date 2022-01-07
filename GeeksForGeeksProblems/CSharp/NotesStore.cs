using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.CSharp
{
    public class NotesStore
    {
        private Dictionary<string, List<string>> _noteStates;

        private string[] _validStates = { "completed", "active", "others" };

        public NotesStore()
        {
            _noteStates = new Dictionary<string, List<string>>();
        }

        public void AddNote(String state, String name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Name cannot be empty");

            if (!_validStates.Contains(state))
                throw new Exception("Invalid state " + state);

            if (!_noteStates.Keys.Contains(state))
                _noteStates.Add(state, new List<string>());

            _noteStates[state].Add(name);
        }
        public List<String> GetNotes(String state)
        {
            if (!_validStates.Contains(state))
                throw new Exception("Invalid state " + state);

            if (!_noteStates.Keys.Contains(state))
                return new List<string> { "No Notes" };

            return _noteStates[state];
        }
    }
}
