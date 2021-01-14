# stationeers-slow-down

This is a mod for Stationeers that provides players with a "walk" key - Left Control by default. Users can choose the key that slows them down and what speed to slow down to in ``Stationeers\BepInEx\config\SlowDown.cfg`` following installation of the mod (and running the game once with the mod installed).

**To choose a different key than the default LeftControl, go to the config file at Stationeers\BepInEx\config\SlowDown.cfg" and change SlowKeyCode to a KeyCode from here: https://docs.unity3d.com/ScriptReference/KeyCode.html**

### Features

Completed features
 - :heavy_check_mark: Allow users to slow down using a key and speed of their choice (LeftControl by default, configurable)
 - :heavy_check_mark: Allow users to toggle walk using a key of their choice (CapsLock by default, configurable)
 - :heavy_check_mark: When toggle walking is ON, the (held) walk key will cause users to walk at vanilla speed.

### Compatibility

#### With existing saves
 - This mod is compatible with existing saves and will not corrupt them when you install or uninstall the mod

#### With other mods
 - I would not recommend running this with any other mod that alters the player's speed
 
### Installation

 0. Download the latest release https://github.com/daniellovell/stationeers-slow-down/releases/latest
 1. Install BepInEx to your Stationeers folder in Program Files (x86) https://github.com/BepInEx/BepInEx/releases
 2. Run Stationeers once to complete the BepInEx installation
 3. Install ``SlowDown.dll`` to the Stationeers/BepInEx/plugins folder
 4. Run Stationeers once to generate the config file
 5. Change the config to your liking in /Stationeers/BepInEx/config/SlowDown.cfg

### Contributions

 - Any contributions welcome, post an issue or create a pull request freely :-)
