# save-and-load-levels-unity
Save and load a game level in Unity using PlayerPrefs and Unity System.IO, without Serialization or any additional libraries.

Look how to save and load a game level in Unity using PlayerPrefs and Unity System.IO, without Serialization or any other additional libraries.

This Asset is a part of our projects like Animate.Space, Build with Cubes, Cute World Craft where we are save user's cartoons and game's worlds/levels.

The combination of Unity System.Io and PlayerPrefs for saving game levels without traditional Serialization methods makes it possible to use this method without modifications, addons and losses, on all platforms - Android, iOS, MacOS, Windows, etc.

It is necessary to take into account that it is impossible to use PlayerPrefs alone to save information about large amounts of data. PlayerPrefs have a size limit on some platforms (for example, WebGL).

You can save any information. The main thing is to pack it into text string and parse it back in the required data. You also need to pay attention to the pitfalls of Unity. For example, you can easily parse a float from a text string by using the System.Globalization only.

So, by and large, we should to save small data (such as level names, player location data, etc.) in PlayerPrefs, and all large data sets (for example, a screenshot of a level, data about player's buildings, world's data etc.) convert to string format, save to local storage files via the Unity System.IO, then read it back and parse it into the data we need.

The system we use can serve as the basis for creating a system for saving game levels, tables of contents for articles, image galleries, and so on.

For example, in our Animate.Space application we save every cartoon created by the user. 

In Build with Cubes and Cute World Craft, we transfer a huge amount of data with the coordinates of the player, the cubes, newly added buildings and objects, to our server, save it there, and allow users to read it back and open the created user's worlds.
