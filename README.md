# Slumber-2.0 : Just for fun
This software allows you to shutdown, lock or restart your Windows computer when you issue a simple voice command.
No need to stain your keyboard and mouse with greasy fingers when you want to power down your pc to enjoy your favourite snack.
While running the software, you can easy say "Computer shutdown now" or "Computer restart immediately", it's like having your very own virtual butler.

## System Capabilities
1. Shut down/turn off computer
2. Restart computer
3. Lock computer
4. Count down before executing one of above operation (1-3)
5. Recognize speech
6. Talk back via Text-to-Speech

## Recognized Voice Commads
To enagage with the system, the user should structure thier voice commands in the following formate:
- Device_Name + Operation + TimeInterval
#### Where Device_Name is:
Whatever you chose to name the software, but the default device name is simply "Computer"; to change the device name please see the GUI.
#### Where Operation is:
Could either be one of the following
1. To shut down: ("shut down", "power down", "turn off")
2. To restart : ("restart", "reset")
3. To lock: ("lock up", "lock down")
#### Where Time_Interval is:
The time you want to wait until performing the operation you have selected, these may be:
1. "Now", "Immediately", "Right away"
2. "In" + (0, 1, 2, 3 .... 1000) + "Minutes" + "And" + (0, 1, 2, 3 .... 1000) + "Seconds"

### Correct Voice Command Examples
1. "Computer shutdown immediately."
2. "Computer shutdown in 5 minutes and 7 seconds"
3. "Computer shutdown in 0 minutes and 80 seconds"
