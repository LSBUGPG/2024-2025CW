# Creating a Button to Quit Game
## This tutorial shows how to create a button that will exit the game, aimed for use as part of the start menu.
### Prerequisites
- There is nothing required to create a quit button; it can be made on a blank scene with no other gameobjects or even playable game required. In this specific tutorial, you will see that I have already created the bones of a main menu, but you are not required to already have this in order to make a functioning quit game button.

## Creating the Scene and Button
1) In the project window, navigate to the `Assets` tab and right click, navigating to `Create > Scene`. This new scene is the scene in which your start menu will be in, so name it something appropriate like 'MainMenu'

![image](https://github.com/user-attachments/assets/8cede149-d9a6-4910-9ef8-728750eb7a94)

2) Enter the scene and navigate to the hierarchy. Right click and navigate to `UI > Button - TextMeshPro`, which will create the button in your scene.
  - In the inspector, we can play around with the colour, font, position and so on for the button. For now, just make it so the text on the button is something like 'quit'. 

![image](https://github.com/user-attachments/assets/34b54efa-84c6-46f6-82ac-832f79aed1be)


## Creating the Script
1) Go back to the hierarchy and click on the `Main Camera`. Create a new script and attach it to this - call it something along the lines of 'MainMenu'.

![image](https://github.com/user-attachments/assets/62069091-151e-45ed-b959-98de81b9d69b)

2) Click on the script so it will take you to visual studio. We want this script to make it so when we call a specific function, unity will close the application/game. 

```c#
public void QuitGame()
{
    Application.Quit();
}
```

We can delete start and update because we don't want anything to happen when the game starts, and we have nothing to check for with update.

We create the public function `QuitGame`, which will be the trigger for closing the game. We want it so when this function runs, the game application will close. Thus inside the brackets, we will use `Application.Quit`, which is the appropriate command to close the game.


## Attaching the Script

1) Going back to Unity, navigate to the play button itself in your hierarchy. In the inspector, there is a window where we can dictate what happens when the button is pressed; we want to drag and drog the `Main Camera` into the 'object' window, and from there we can go into the 'function' menu and attach the `QuitGame` from the `MainMenu` script that we attached to the camera.

![image](https://github.com/user-attachments/assets/c91e8f59-d786-4c6c-9a42-77a1b230e277) ![image](https://github.com/user-attachments/assets/7700d177-5d1e-4d12-a1cd-ed362680ce45)


This means so that when we press the button, it will call the `QuitGame` function. In the `MainMenu` script, we have already written that if this function is called, it will close the game via `Application.Quit`.

## The Script in Action
In the Unity editor, `Application.Quit` is specifically ignored when testing a game. In order to see if you have followed the tutorial correctly, you will need to export a build of your game. This can be done by navigating to `File > Build and Run`, and creating a folder within your project that will house the application and all relevant files. Once the build has been exported, you can open the game application, and `Application.Quit` will finally work.

![image](https://github.com/user-attachments/assets/38ce3b30-c11e-47cc-ba6f-f0088f0b8a58)
