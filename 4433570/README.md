# Learning_Journal
Progress of Project and Notes

15/10/24
Created learning journal 

When making the tutorials make them unlinked so that none require a watch of another to understand the statements used. 

Use tutorial tips in Week 2 notes

22/10/24

Started making the script for the first tutorial. Decided to make a 3d movement script that moves a cube around a space.

Cube is able move horizontally but collision with objects sends it flying. Will fix next week

29/10/24

Cube's flying issue was solved by locking rotations of the cube in its inspector window.

The movement code felt to stiff for smooth movement and would immediatly change direction when inputs where pressed. 

Going to research how to keep momentum  over movement

5/11/24

Found out how to keep momentum so changed the movement code to use float commands ands use the scenes time to determine speed.

Experimenting with the movement itself I want to add a boost type of button that lets my character move at increased speeds. Like a sprint button

12/11/24

Boost button was added by adding force to the body with its vector and impulses. 

Movement codes tutorials is being written. Will decide the next code next week. 

19/11/24

1st tutorials script is now complete and I can begin the next code. 

Ive decided tyo do a pickup script tutorial as that will be the main goal for the end prototype game, picking up coins. 

I have made the coin assets and found out how to colour them using the materials in unity.

The script has been started but not much progress yet. Will work on it more next week.

26/11/24

Pickup script has been finished, had some issues with the coins not detecting the player and the canvas not changing when they were picked up.

Coins being picked up was easily fixed with making a tag for the player which then was detected by the code instead. 

Canva's issues were helped by Paul, seemed to be an issue with the UI picking up changes from the code due to parenting issues and code not being in the right place.

Started writing the tutorial for pickups.

3/12/24

2nd Tutorial is finisshed along with final touchups for the pickup script.

I want to do something unique with this tutorial so ill take inpspiration from the Binding of Isaac.

I want to have simialr door mechanics to top down games that open when the player goes near them. Did some reserach on the Unity animator window that allows objects to have states saved and move between them within unity under certain conditions. Im going to find a tutorial on how to use this properly.

Found how to use the Unity animator with cube blocks that move inward and outward away from each other. Now i just need to make these into a door shape.

10/12/24

I made the door asset quicky using some blocks for the walls and doors of the object and started making the animation states. Had some issues at first with the states not saving properly but was fixed after I started using the record button and creatign a Bool

The states of the door are now saved so im going to start putting this into some code. 

Easiest way to detect collsion was to make an invisble box that detects the player approaching the door. 

Quickly finished the code for the door as it wasnt too long to make. Had some issues with the code making the states move back and forth but this was fixed quickly with setting the Bool to be changed. 

17/12/24

Worked on tweaking the settings for the door like the speed, how far away it detected the playe rmoving towards it and its sizes and shapes. 

Worked on writing the tutorial for the rest of the day

24/12/24

Continued writing the tutorial for the door opening script. This script has a lot of explaining to do expecially because im using features not many others are using for this project. 

Finished most of it by the end of the day. 

20/12/24

Began working on my final script which was going to be a first person moevemnt code. I had some issues with the code not picking up on certain commands such as the cursors lockstate and its visibility causing errors in the scene.

Im going to take a break from coding for a bit.

7/01/25

Picked back up the movement code after sorting out some other work. Got the cursor lock code lines working now, some spelling and grammar was causing some issues.

Got through the majority of the movement code abd began the lines for the sprinting mechanic.

8/01/25

Sprinting mechanic was finished, the calculations did not seem to do much so i increased the variable of the sprint speed and it seemed suitable. 

Jumping mechanic has been added. Used some inspriation from online tutorials on how they use movement direction for the jumping so that the player can jump backwards with proper momentum. 

Added in a ground check to stop the player from flying away. 

9/01/25

Put together all of the code for the players movement using a new parent object with a capsule in an empty object along with the main charcater. Made a mistake with the movement script as it was innitially added to the capsule object instead of the parent which caused the camera to not be able to turn horzintally. This was fixed after I removed it from the capsule and put it on the parent object instead. After moving the camera up slightly for a better point of view the script was not complete. 

I need a break man ill do the tutorial tmr

10/01/25

Tutorial for the 4th script has now been done. Went back to the Unity project to start placing things around to make a small protype minigame for the prototype. 

13/01/25

Prototype for the game is now finished. Made a small map with coins to collect with some visible and others hidden a bit. 

Recorded some gameplay of the scene and uploaded that to the github repo

Touched up some files along with uploading all the project and videos to the main branch and saved everything.

Project Done :)

Im going to bed.
