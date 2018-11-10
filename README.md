# Qwopple
## About Qwopple
Grapple hooks are the best. This is a well-established game design fact. Ragdoll physics are also the best. This is also well-established scientific fact. The only thing better than one or the other is both.
## Project Setup
1. [Download the xbox 360 controller drivers.](https://github.com/360Controller/360Controller/releases)
2. You will be prompted to give the drivers some security permissions, because we're developing on Mac. Allow the drivers to do their thing.
3. Restart your computer.
4. Go to System Preferences -> Xbox 360 Controllers, and go to Advanced. Enable the drivers (Looks like you might have to do this every time you restart your computer? I'm still trying to figure this out). If you plug in a controller, the computer should be able to find it and you can test all the inputs in this menu.

## Unity Stuff
### Adding Input Fields
If you want to add more buttons to push, in Unity:
1. Edit->Project Settings->Input. The Input Manager should open on the right side of Unity.
2. [Check out the keycodes for the controller.](http://wiki.unity3d.com/index.php/Xbox360Controller) (Yes, they're different between Windows and Mac. The Input Manager so far is set up for Mac only.) Be sure to look at the reference photo for the platform you're designing for!
3. Replace an unused input with the new one you want. If all of them are taken, add a new field by incrementing the counter at the top of the Input Manager.
