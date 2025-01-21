# Make a Button and Attach a Function
## This tutorial shows how to make a functioning button. Buttons can be used to call many functions, though this tutorial will just do a generic testing function. The tutorial will not show you how to do different functions, just how to create the scripts and attach a function to a button correctly.

### Prerequisites
- Code for the Function you want to call.
  - In this tutorial I will simply be making an image appear on the screen, and while the core coding of the button is universal, the exact nature of what you want it to do heavily depends on your own project. You must
    already have a rough idea of what you want the button to do, and the capability to put the code into a script to attach to the button.

    The tutorial will assume you already know how to create a function and attach the
    script with it to a gameobject.


## Creating the Button
1) In the hierarchy, right click and navigate to `UI > Button - TextMeshPro`. Clicking on it will add a new item in the hierarchy - a `Canvas` folder, and within the folder is our button.

![image](https://github.com/user-attachments/assets/d230fe83-7014-4154-915a-a401afbb88b2)

## Attaching the Function

1) Navigating down in the inspector, we can see a little area with the label `On Click ()`, with a plus and minus sign in the corner. This will be where we attach the scripts and assign exactly what function we want the
   button to call. Press the plus sign to add a new function.

![image](https://github.com/user-attachments/assets/7aa2108d-64ae-42e3-a5ba-38deb005738b)

2) A smaller menu inside will appear- this is where we can attach the game object that holds the function script. Click and drag the gameobject from the hierarchy into the slot labelled `None (Object)`.
   - If you have done this correctly, the slot reading `No Function` should become ungreyed and accessible to edit.

![image](https://github.com/user-attachments/assets/345c2d07-6779-4065-a214-3da74fa1d58a) ![image](https://github.com/user-attachments/assets/5b0ba13f-035e-44ab-bb3c-26d046b42c72)

3) Click on the `No Function` slot and navigate to the bar with the name of the function script you have attached to your gameobject. In this specific example, my script is named `SpriteAppear`. Then navigate further into the
dropdown menu to locate the name of the function you wish to call. In this example I named my function `ShowImage`, so I select this.

![image](https://github.com/user-attachments/assets/94eb3f79-f740-4ddb-a0f0-750c5a07562b) 

If you have done this correctly, your `OnClick` menu should look like so, with the correct names for your gameobject, script, and function:

![image](https://github.com/user-attachments/assets/45bffc2c-8a63-4abd-aaaf-e7b0d87f378a)

## The Button in Action

While it will look different for whatever function you are calling, if you test your scene and click on your button, it should call your function correctly. As an example, this is my function that makes an image
appear:

https://github.com/user-attachments/assets/d456f1ba-bc90-47db-94f6-bcc70f9419b5 

