
using System.Runtime.CompilerServices;

namespace Slumber.Services.AudioService
{
    public class Vocabulary
    {
        #region Data fields
        private readonly static Dictionary<string, string> _promptMessages = new Dictionary<string, string>(){
            {
                "Report: Greeting",
                    "Slumber ready to take commands."
            },
            {
                "Report: Shut down",
                    "Shutting down computer"
            },
            {
                "Report: Restart",
                    "Restarting computer"
            },
            {
                "Report: Lock",
                    "Locking down computer"
            },
            {
                "Report: Cancel",
                    "Operation has been cancelled"
            },
            {
                "Report: Farewell",
                    "Good bye."
            }
        };

        private readonly static Dictionary<string, string[]> _commands = new Dictionary<string, string[]>()
        {
            {
                "Power: Off",
                    new string[]{
                        "turn off computer", "power off computer",
                        "power down computer"
                    }
            },
            {
                "Power: Restart",
                    new string[]{
                        "restart computer"
                    }
            },
            {
                "Power: Lock",
                    new string[]{
                        "lock computer"
                    }
            },
            {
                "System: Control", new string[]{
                        "Yes",  "No"
                    }
            }

        };
        #endregion

        #region Class methods
        public static string GetPromptMessage(string promptKey)
        {
            string message = _promptMessages[promptKey];

            return message;
        }
        public static string[] GetCommands(string commandKey)
        {
            var commands = _commands[commandKey];
            return commands;
        }
        #endregion

    }
}
