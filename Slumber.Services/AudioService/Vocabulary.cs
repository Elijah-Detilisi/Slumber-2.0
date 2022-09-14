
using System.Runtime.CompilerServices;

namespace Slumber.Services.AudioService
{
    public class Vocabulary
    {
        #region Data fields
        private readonly static Dictionary<string, string> _promptMessages = new Dictionary<string, string>(){
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
                        "turn off", "power off",
                        "shut down", "power down"
                    }
            },
            {
                "Power: Restart",
                    new string[]{
                        "restart", "reset"
                    }
            },
            {
                "Power: Lock",
                    new string[]{
                        "lock", "lock down", "lock up",
                        "security"
                    }
            },
            {
                "Power: Numbers", GetNumbers()
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

        #region Support entities
        private static string[] GetNumbers()
        {
            var numbers = new List<string>();

            for(int i=0; i<60; i++)
            {
                numbers.Add(i.ToString());  
            }

            return numbers.ToArray();
        }
        #endregion
    }
}
