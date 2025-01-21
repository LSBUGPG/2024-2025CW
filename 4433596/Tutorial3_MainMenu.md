# Main Menu System 
## This tutorial shows how to make a Main Menu system with a Play, Options anc Quit button in Unity 3d, as well as another section with a back button after clicking options.

1. Create a new scene in Unity 3d and then right click the mouse button in the Hierachy, select UI, then click "Button - textMeshPro"
2. Move around the button with the move tool and place it where you'd like it to be. You can also adjust the button itself in the Rect Transform component, adjusting the scale and position more accurately.

### Now we're going to make so that, whenever your mouse hovers over the button, the opacity drops, and when you actually click the button, the opacity is now 100% and hard.

3. On the button, go to the button component, for normal colour, on the A section, make sure that's set to 0. For Highlighted colour, you can choose what colour you want for the RGB sections, and make sure the A section is set to 77. For Pressed colour, again, adjust the colours to your liking for RGB's section, and this time the A section should be 123.
Lastly, for Selected Colour, you adjust RGB colours to your liking and then set section A to 255. 

![image](https://github.com/user-attachments/assets/61264aea-fad6-4ab4-bb9f-27a0f3c838d7)

This is what it should look like once you're finished with the button.

4. Next on the Text object, which should be inside the button on the hierachy, change the text to "Play" and underneath it somewhere, select "Enable Auto Sizing" then change the colour (towards the top of the textMeshPro component) to white.
5. Re-name the Button on the hierachy to PlayButton, then duplicate this object twice and re-name the 2 buttons to OptionsButton and QuitButton. Then update the text for both the OptionsButton and QuitButton in the TextMeshPro component, and of course change them to "Options" and "Quit" for their respective buttons.

![image](https://github.com/user-attachments/assets/286a7fbf-1c0d-4e4b-b3c7-0059a7c43b31)

6. Create an Empty game object in the hierarchy, right click it and select create empty, re-name this empty object to MainMenu, then select the 3 objects and drop onto the Main Menu so that the 3 buttons become a children object to MainMenu, which becomes a parent. Make sure the MainMenu object is a child to the Canvas.

![image](https://github.com/user-attachments/assets/b603cf5e-d00e-471e-93ac-5248265f9c5c)


It should look like this.


7. Next, we're now going to these buttons have a function when clicked on. Select all 3 button objects, then on the right side, in the button component, add in an "On-click" method and drag in the MainMenu object and place it into the box, where it says "No Function", select that then click MainMenu then clcik Play Game ().
8. Select on the Quit button, and create an on-click method, then on the "No Functions" tab, click it then select MainMenu then click Quit Game ().
9. Now select the MainMenu object, and duplicate it by pressing control + D, change the name to SettingsMenu, then delete Play and Options button for SettingsMenu, then change the name of the Quit button, to BackButton.
10. On the Options Button, the first On-Click Method, it should be displayed as "Editor and Runtime" with GameObject.SetActive as its function above the MainMenu box with an unchecked box. Then for the 2nd on-click method of the Options Button, Drag in the SettingsMenu object and place it into the box, have it on Runtime Only with GameObject.SetActive with a tick in the check box.
11. For the BackButton, the first on-click method should be on Editor and Runtime, with an unchecked box for GameObject.SetActive with SettingsMenu in the box. And for the second on-click method, it should be on Runtime Only with a ticked GameObject.SetActive box, with MainMenu in its box.

## Now to make it so the Play Button actually loads a scene in.

12. If you have a scene, use that, if not then create a scene. In the top left of Unity, click file then towards the bottom, click Build Settings.
13. Drag the MainMenu scene into the build settings first, then drag in the 2nd scene into the build settings.

![image](https://github.com/user-attachments/assets/2c5edcff-e4e5-4208-be8e-8c06b6d3d21a)

14. Next, we go into our scripts folder and creat a new script, right click in the scripts folder, create then select C# Script and name it MainMenu.
15. Open the MainMenu script, then delete all the void Update and void Start statements.

```.cs
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePrototype");
    }

    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
```

This essentially allows us to do what it's supposed to, the LoadScene("GamePrototype"); part is my second scene which I want to be loaded after I click the Play button in the main menu. The "SettingsMenu" will direct you to the settings menu itself, but in this tutorial we don't have one so it won't load anything besides the Back Button. MainMenu is to simply load the MainMenu scene and lastly the Application.Quit is to simply quit the application, although in this case it doesn't actually do anything.

16. Lastly, on the SettingsMenu object, uncheck the tickbox at the top right so it hides the BackButton, and when you click the Options Button, the BackButton re-appears.


https://github.com/user-attachments/assets/14f65ffe-c479-4749-abdb-50a2e7025c1f

