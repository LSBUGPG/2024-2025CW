# Creating a Button to Start Game
## This tutorial shows how to create a button that will load the first scene of your game, aimed for use as part of the start menu.
### Prerequisites
- Another Scene
  - In order to complete this tutorial, you need a different scene to the one the start menu will be in. This can be a placeholder, the first level of your game, anything. You just need to have a different scene to the one your button will be in, so it can be loaded when the button is pressed.

## Creating the Start Menu Scene
1) In the project window, navigate to the `Assets` tab and right click, navigating to `Create > Scene`. This new scene is the scene in which your start menu will be in, so name it something appropriate like 'MainMenu'

![image](https://github.com/user-attachments/assets/8cede149-d9a6-4910-9ef8-728750eb7a94)

2) Enter the scene and navigate to the hierarchy. Right click and navigate to `UI > Button - TextMeshPro`, which will create the button in your scene.
  - In the inspector, we can play around with the colour, font, position and so on for the button. For now, just make it so the text on the button is something like 'play'. 

![image](https://github.com/user-attachments/assets/d230fe83-7014-4154-915a-a401afbb88b2)

## Creating the Script
1) Go back to the hierarchy and click on the `Main Camera`. Create a new script and attach it to this - call it something along the lines of 'MainMenu'.

![image](https://github.com/user-attachments/assets/aaa73027-6929-4ad7-8187-165d3fb7a9f4)

2) Click on the script so it will take you to visual studio. We want this script to make it so when we call a specific function, unity will load another scene of our choosing, typically the first level in the game. First, make sure to add `using UnityEngine.SceneManagement;` at the top, as we need access to this library to do anything relating to the management of scenes.

```c#
public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Text Appear");
    }

}
```

We can delete start and update because we don't want anything to happen when the game starts, and we have nothing to check for with update.

We create the public function `PlayGame`, which will be the trigger for loading the next scene. We want it so when this function runs, it will load the appropriate scene; in this case, it is `"Text Appear"`. Thus inside the brackets, we will use `SceneManager.LoadScene`, which is the appropriate command for loading a scene.

According to Unity's scripting API, it recommends that to "avoid pauses or performance hiccups while loading, you should use the asynchronous version of this command which is: `LoadSceneAsync`". This is the version of the code that I have used in this tutorial.

We can use either the name of the scene or the scene build index; the latter can be found by navigating to `File > Build Settings` and looking at the number next to the scene in the `Scenes in Build` box.

![image](https://github.com/user-attachments/assets/6de3595f-b1a1-4649-a16c-9631a745bb9a)

So, if we wanted to use the scene build index rather than the scene name, we would simply have to write the code like this instead:

```c#
SceneManager.LoadSceneAsync(1);
```

## Attaching the Script

1) Going back to Unity, navigate to the play button itself in your hierarchy. In the inspector, there is a window where we can dictate what happens when the button is pressed. Click on the plus icon to add a function, and keep it to `Runtime Only`. We now want to drag and drop the `Main Camera` into the 'object' window, and from there we can go into the 'function' menu and attach the `PlayGame` from the `MainMenu` script that we attached to the camera.

![image](https://github.com/user-attachments/assets/c91e8f59-d786-4c6c-9a42-77a1b230e277) ![image](https://github.com/user-attachments/assets/68978f2f-da57-4f08-9ac2-0966f4d1067b)

This means so that when we press the button, it will call the `PlayGame` function. In the `MainMenu` script, we have already written that if this function is called, it will change the scene via `SceneManager.LoadSceneAsync`.

## The Script in Action
If you have followed these steps correctly, your script should perform like so;

https://github.com/user-attachments/assets/f3b8f361-7e70-400a-940c-1988a11d6617
