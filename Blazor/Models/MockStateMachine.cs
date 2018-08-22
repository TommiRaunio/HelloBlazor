using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Models
{
    public static class MockStateMachine
    {
        private static string _mood;
        public static string Mood
        {
            get => _mood;
            set
            {
                _mood = value;
                StateChanged?.Invoke(null, EventArgs.Empty);
                Console.WriteLine(_mood);
            }
        }

        public static event EventHandler StateChanged;
    }    
}
