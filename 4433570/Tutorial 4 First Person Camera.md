For this tutorial I will be making a proper first person camera on a moving player object 

The aim of this tutorial is to make a smooth fully operation firts person perspective of a playr within a scene that can move around and interact with other things in the future.

To begin this tutorial we need to make a new script. Name this script FPSController or anything that you will remember.

Now we can start inserting the code that will help us move. 

First above public class insert the following line of code. This code will insert a character controller into the scene if it is missing. It should look like the image below.

![image](https://github.com/user-attachments/assets/b9ce12ae-3799-43ab-a25f-7736a7758ce7)

Next we need to add the variables that will determine the various features of the movement script and how they work. For this we will need how fast the player walks, how fast they are when they sprint, how high they can jump and how much they are affected by gravity.
This also includes how quickly the camera rotates with the mouse. The variables will be layed out as the following. 

![image](https://github.com/user-attachments/assets/3b45bcdf-f798-450e-be69-8009be21fdd1)

After this we need to set the start method for the script. These lines of code will get our character controller and hide the cursor when we play the scene. 

![image](https://github.com/user-attachments/assets/b16fb6ec-9503-4892-bda0-8ec869938250)

For the actual movement part of the code the lines are as the following. This code will change how the movement works depending on the face of the camera so that wherever the player is looking is what 'forward' is and vice versa for other directions. This will also detect if the player is sprinting and bring up the speed to the variable put into sprint speed earlier. 

**![image](https://github.com/user-attachments/assets/c39bf508-976d-4dfe-9412-bfedff9cfdb9)

 Next we need to asssign the code that allows the player to jump. This code will check for if the player is grounded when they attempt to jump. This happens because if the player attempts to jump when they have already left the floor or are falling, the code will prevent them from being able to jump again on nothing and potentially fly away, which is not something I want to happen with my prototype. This code will also make sure that the duirection of jumpign is relative to the movement of the player not the camera as this allows the player to keep suitable movement and momentum when looking away from where they are jumping to. 

 ![image](https://github.com/user-attachments/assets/ff488d14-1a00-471c-ad57-3e59b78c35e3)

Finally the last section of code for the movement will handle the rotation of the camera based on the mouse controls. The movement of the mouse will turn the camera based on the camera speed variable determined earlier and this affects both X and Y translations of the camera. This code also holds where the rotation of the camera and player are as both need to rotate in sync for the point of foward to be the same for both objects. 

![image](https://github.com/user-attachments/assets/a59c4c32-9049-48b8-9003-e85794ab5992)

Now we can assign our code to be used in the scene. First however we need to make this scene.

In the hieracry of the scene create a large plane. This will be the floor that the player will run around on. 

![image](https://github.com/user-attachments/assets/5fc321c6-0ff5-4b0e-ae78-a0d216a9ab61)

Next we can set up the player itself. Create an empty object and name it Player. This will become the parent of the other assets we will be adding layer including the camera and the capsule controller itself.

![image](https://github.com/user-attachments/assets/5599f32e-fc07-4279-99fd-ad60cab612f2)

Next make a capsule object and place it within the Player object for it to be parented and then drag the main camera object in as well so that both object are inside the empty player object. Making sure that the capsule and the cameras location is 0 in all dimensions will help move the camera higher up within the capsule to about where head hight would be instead of viewing from the chest area. 

![image](https://github.com/user-attachments/assets/d338bb2c-ebda-4a11-ba59-2b76a0ffa2c1)

Now add the player script to the parent object player object. Note; if you add this script to the capsule and not the parents the objects camera will not be able move horizontally. 

![image](https://github.com/user-attachments/assets/c6343e5c-ff34-48c1-88d3-e018a62b5fd9)

Finally put the main camera object into the player camera box as seen in the image above and the player should be fully functionable within the screen. (Note; the mouse will not be removed from the screen until you click on the scene window and will reappear again when hitting Esc.)

