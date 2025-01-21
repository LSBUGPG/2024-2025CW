## The following tutorial will explain how to make a finish line/ end point to your level to your game in Unity 3D. This will help you learn how to make an end to your level, but not a game over so this might not be a tutorial suited for you.
## I followed this tutorial to make this by Hackingtons Code School https://www.youtube.com/watch?v=Q90cUrm4LYo however for people who need to make this in 2D then follow the original tutorial instead of this one.
1) First your going to want to make a new script for this, it can be called anything you want but I'll call it endpoint.

![image](https://github.com/user-attachments/assets/7aa07eba-d2cc-4929-aee0-514d54e5b62a)

2) Then your going to create something for your character to interact with or in this collide with so I made a wall for this collide with(note, if you don't plan on having it collide to progress to a new level then don't follow the rest of the tutorial. Next your going to give it a box collider so that your player character doesn't phase through it & your going to attach your script to the wall.
   ![image](https://github.com/user-attachments/assets/14c21d26-8b31-44ab-8c03-a0e9f81e791b)

3)After you'll go into the script and add this line of code under 'using unityengine' so that it will help manage the levels/scenes.

![image](https://github.com/user-attachments/assets/b4482411-e6fc-4c26-ace9-672db1e3a759)

4)Afterwards you'll add in this piece of code which will check if the player is colliding with the wall and if it does then the scenemanager will take it to the beginning of the game again(note the reason it says game over is because it was for an endgame screen which I couldn't finish but it will circle back to the main menu if you also create another scene with whatever title matches where gameover is).

![image](https://github.com/user-attachments/assets/f9bbfaba-f9b6-4dd2-9ede-19bdab5f0880)

And then finally, if it worked properly then your game should look like this:


https://github.com/user-attachments/assets/20ce90d8-8f5e-4f01-a5c9-5a6869d66353

