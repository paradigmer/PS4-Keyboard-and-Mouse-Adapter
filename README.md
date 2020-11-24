# PS4 Keyboard and Mouse Adapter 
Disclaimer: This project is not endorsed or certified by Sony, Playstation or any of their partners.

![example UI](documentation/example-ui.png)


## DISCORD
Try our discord here https://discord.gg/zH4b8p4 where you can either suggest ideas or ask other members for help.


## DOWNLOAD
:rocket: Click --> [here (v1.0.8)](https://github.com/starshinata/PS4-Keyboard-and-Mouse-Adapter/releases/download/1.0.8/Setup.exe) <-- to Download!



## How to use
1. Do NOT plug your DS4 controller into your PC while using this tool. If it is plugged already, unplug it because it will interfere with the device emulation.
2. Make sure you've enabled remote play from your PS4's settings menu. To do that:
  * Go to your PS4, select (Settings) -> [Remote Play Connection Settings], and then select the checkbox for [Enable Remote Play].
  * To activate it as your primary PS4, select  (Settings) -> [Account Management] -> [Activate as Your Primary PS4] -> [Activate].
3. Download and run the setup from the download link above. It will automatically do all the configuration stuff for you
4. If you want 0 lag, connect your PS4 to your TV/Monitor and watch the game from there (thus NOT from the Remote Play app)


## To-do list
* Explicit error message box for when mappings.json is missing or invalid <br> Currently it (kinda) silently fails unless you open it via a command line.
* Create and switch between multiple mapping profiles to make configuration easy when playing multiple games <br>I am thinking of  being able to save and load mappings.json files
* Map multiple keys to the same button
* option to allow mouse button remapping
* supporting ps5 (we dont know if this works on ps5 atm)
* support linux/mac 
* support chaikis


## Frequently Asked Questions
see [here](documentation/frequently-asked-questions.md)


## Documentation
All documenation [here](documentation/)

But some popular topics are
* [mouse configuration](documentation/mouse-configuration.md)
* [troubleshooting](documentation/troubleshooting.md)
* [version history](documentation/version-history.md)



## Credits

- [PS4Macro](https://github.com/komefai/PS4Macro) - Big thanks to komefai for making and open-sourcing this tool. Komefai is MIA for 2 years and his repo is not supported anymore but you can still write pretty good bots with it, definitely check it out if you are into that kind of stuff
- [EasyHook](https://easyhook.github.io) - The best tool for Windows API hooking. Works flawlessly - from the assembly injection, to the hook trampoline code. ~~I haven't had a single problem with it~~ I had one but that doesn't make EasyHook any less cool
- [Jays2Kings/DS4Windows](https://github.com/Jays2Kings/DS4Windows) - don't need to explain that one
- [soulehshaikh9](https://github.com/soulehshaikh99/self-signed-certificate-generator) for pfx certificate generator
