# Prerequisite
## The following tutorial will explain how to make your player move in Unity 3D. This includes the character moving in multiple directions and being able to jump.
# Copyright
## I followed this tutorial from Paul to create the code https://github.com/LSBUGPG/movement-tutorial
1) Start by creating a C# called Player Movement(you can do this by right clicking in the asset are, selecting create and then clicking on C# script, also don't put a space in it or it won't work).

2) You'll want to left click which will bring you into MS Visual Studio where under public class you'll want to create these floats. What the public & private floats. What they will do is assign a value of speed and jump force(how fast the character will go and jump), private [rigidbody](https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Rigidbody.html) will allow the character to feel forces so your character can move because if your character cannot recieve forces then the speed & jump force will be for nothing. What the next three variables do is help the character jump by allowing the character to jump with bool jump which detects whether or not the character is jumping (which will be helpful when we move onto the character jump part of the tutorial). Float horizontal & vertical allow it so that the character can move in any direction whilst in air, whether the character is catapulted in a certain direction or if they’re jumping and using the keys to change directions. ![Capture 2](https://github.com/user-attachments/assets/2b4fc5af-47dc-4d23-99f3-a64a98822846)

3) Then under void start, make this variable so that the code can reference the [rigidbody](https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Rigidbody.html) to the game.

![image](https://github.com/user-attachments/assets/addeea2c-85e0-461e-8846-840571f3900d)

4)  We'll add in this code which will help with allowing the program to understand what will happen when the player uses an input such as W, A, S or D & any of the arrow keys. There is also a piece of code that will the program understand that when the player uses the spacebar that it will detect whether the function is true.

![image](https://github.com/user-attachments/assets/d60bfdd0-1017-414f-9a1e-f382323e6344)

5) What this code will do is add force & speed to the character so that it can move in multiple directions.
![image](https://github.com/user-attachments/assets/11c517a2-ff91-4ba0-9b2f-e7c4c122a73c)

6) And if the jump is true then it will use the player [rigidbody](https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Rigidbody.html) and add force to it so it can move upwards.
![image](https://github.com/user-attachments/assets/ea0654e1-b625-481b-a12d-b160e5af2a99)

7) After that is all done, whilst you have your player character selected, you will drag the script you made into the add component button which will apply all you made into the character. 

![image](https://github.com/user-attachments/assets/dcbb0f00-685d-4c81-8957-7ba15e3859d1)

8) One thing you will want to do when adding in the Rigid Body is click on freeze rotation on X and Z. What this will do is make sure that the character does not tip over when moving. 

![image](https://github.com/user-attachments/assets/ab4f2111-5069-4828-9455-4303cd862d0c)

However, that is only for the character moving. Now we are going to learn how to make the player jump properly as I have covered how to put a limit on how many times the player can jump. 

9) We’ll start by adding in this code which will help us detect whether or not the player is touching the ground. 

![image](https://github.com/user-attachments/assets/72051fff-97f8-4815-9f24-399da45480c0)

10) In void update, add in this code which will detect if its touching the ground more than 0 times to allow the player to jump.

![image](https://github.com/user-attachments/assets/abab5d95-4ead-43eb-982e-79ca21fb38e8)

11)  And then you'll want to add in this code which will detect for collision with the ground so that it can register if the player character is still in the air or not & if it isn't it will let the player jump again.

![image](https://github.com/user-attachments/assets/418696c1-eb04-4361-a30e-9401ae35609d)


And if everything is working right your character should be able to move like this:


https://github.com/user-attachments/assets/40ce64c5-6919-4cb7-bf1d-44acbe807f50


