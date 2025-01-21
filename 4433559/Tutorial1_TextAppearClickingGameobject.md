# Text Appearing after Clicking Gameobject
## This tutorial shows how to make text appear on the screen after clicking on a gameobject with the mouse. This can be useful for things such as prompting dialogue from characters after clicking on their sprite in-game.
### Prerequisites
- Image of your sprite
  - All you need for this tutorial is the image of whatever sprite you will need to click on for the text to appear. This can be anything from a picture of a simple box, to a fully rendered character sprite. For this tutorial we will be using a simple solid coloured square made in MS Paint.

## Creating the Gameobject
1) Import your sprite image into Unity by going into the `project window` and navigating to the `Assets folder`. Right click inside this folder and select `Import New Asset`.

![image](https://github.com/user-attachments/assets/a07769f9-24c5-4af5-b48e-d43326fb1664)

2) Click and drag the sprite onto the scene. You will see it appear in the hierarchy if this is done correctly.

![image](https://github.com/user-attachments/assets/b3ce2c85-8bc0-479b-9fa1-7ac2f75fb8d0)

3) Clicking on the sprite gameobject in the hierarchy, go to the inspector and navigate to the `add component` button. Add a `Box Collider 2D` to the gameobject.
   - We want to do this as we need the game to know when we are clicking on the gameobject specifically vs anywhere in general on the screen. We only want the text to appear when we click on the gameobject, not anywhere else, so this collider is necessary.
   - We don't need to edit the parameters on this component as it is already tailored to the dimensions of the sprite. Again, as we only want the text to appear if we click directly on the gameobject, there is no need to edit it at this point.

![image](https://github.com/user-attachments/assets/2f3bad62-9bad-41aa-8f42-d50217739e14)

## Creating the Text
1) Back in the hierarchy, right click and navigate to `UI > Text - TextMeshPro`. Clicking on it will add a new item in the hierarchy - a `Canvas` folder, and within the folder is our text file.
   - You may be prompted to install some additional components to make TextMeshPro work. Don't panic, just install what is needed and continue on with the tutorial.

![image](https://github.com/user-attachments/assets/e223860f-b256-4530-8125-4ecc94991203)

2) In the inspector for the TextMeshPro file, you can write whatever you wish in the text input. This will be the text that appears on-screen when the script is succesfully executed.

![image](https://github.com/user-attachments/assets/1214a13a-4bb0-4629-8dc9-557db4561fb7)

3) You may notice that when you created the TextMeshPro in the hierarchy, it created a brand-new, giant screen in the scene editor. When it is zoomed out fully, this new box is actually another representation of the game screen when it is being played, but specifically for allowing you to see where exactly the gameobjects in the `Canvas` folder (essentially, your UI!) will be in the final game. Try moving your text placement around the screen and putting it in different places once the tutorial is finished to get a proper understanding of this!

![image](https://github.com/user-attachments/assets/3fed549c-e93a-4737-b88e-642a1d6cc8a3)

![image](https://github.com/user-attachments/assets/7e0226da-f5df-4c1a-8a0d-bd2940c625c2)

As you can see, in the first image where we are still editing the scene, you can barely see the square sprite as we are zoomed out to see the canvas editor. But when we go to live, the square is back at its normal size and position, and the text is accurate to where we put it on the canvas editor.

4) Navigate back to the inspector for the text, and locate the check box right underneath the inspector. You will want to uncheck it - this will mark the text as 'inactive', and therefore invisible on the screen. In our script, we will be making it 'active' - visible - when we click on the gameobject.

![image](https://github.com/user-attachments/assets/692ecd1e-ca55-458e-bdf4-f5cab117cdb3)


## Creating the Scripts
1) Back in the project window, right-click and navigate to `Create > C# Script`. I will be calling this script 'Square'.


![image](https://github.com/user-attachments/assets/f7b48d8b-185a-4ee9-9110-91a3964db27f)

2) Click on the script so it will take you to visual studio. We want this script to make it so that when we click our left mouse button on the gameobject, it will make the TextMeshPro become active again, turning it visible on our game screen. 
```c#
public class Square : MonoBehaviour
 {   
      public GameObject target;

      void OnMouseDown()
       {
        target.SetActive(true);
       }
 }
```
We can delete start and void because we don't want anything to happen when the game starts, and we have nothing we have to check for constantly with update. 

We use `MonoBehaviour` so that the script can attach itself to gameobjects in the editor, and so that our new class 'Square' has access to all the functions that monobehaviour has, such as the start and update methods (though we do not need to use either of these in this specific example). 

We use `public GameObject target` so that inside the unity editor, where the script is attached to the gameobject we have a little box where we can put the 'target' of the code. In this case I dragged and dropped the text from the `Canvas` group. This is possible due to making it a `public` class - this essentially means we can manipulate this class through Unity manually in the inspector. If it were a `private` class, we would only be able to attach these scripts to each other by referencing them in the scripts themselves, which is time consuming and not very efficient for the function.

## The Script in Action
If you have followed these steps correctly, your script should perform like so;

https://github.com/user-attachments/assets/5803e141-ce39-487a-ac0f-90e436e34869

