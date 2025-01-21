### Khayne Lutchmun
# Programming learning journal
### Date format = Year/Month/Day
## 2024/10/22
Worked on making the main menu, making sure that it works correctly and takes you to the right places.

## 2024/10/29
working on checks on the main menu and then going to plan the first tutorial.

First tutorial will be on making a seesaw platform in a 2d game, I plan to make it by having two colliders that change the rotation of the platform as suggested by a person on the unity forums here (https://discussions.unity.com/t/how-do-you-tilt-a-platform-depending-on-what-side-your-player-is-standing/175194/3). It says to use OnTriggerStay to make the platform tilt while the player is on a half of the platform, you could probably simulate weight by having smaller sections that half that increase the amount of rotation depending where you are on the platform.
    
Another user in the same post wrote a comment saying to use a hinge point and the 2d physics (https://discussions.unity.com/t/how-do-you-tilt-a-platform-depending-on-what-side-your-player-is-standing/175194/4).
    
Im going to attempt to make the physics based on but i will also make the collider version as a backup option.


First tutorial will be on making a seesaw platform in a 2d game, I plan to make it by having two colliders that change the rotation of the platform as suggested by a person on the unity forums here (https://discussions.unity.com/t/how-do-you-tilt-a-platform-depending-on-what-side-your-player-is-standing/175194/3).

It says to use OnTriggerStay to make the platform tilt while the player is on a half of the platform, you could probably simulate weight by having smaller sections that half that increase the amount of rotation depending where you are on the platform.

Another user in the same post wrote a comment saying to use a hinge point and the 2d physics (https://discussions.unity.com/t/how-do-you-tilt-a-platform-depending-on-what-side-your-player-is-standing/175194/4).
    
Im going to attempt to make the physics based on but i will also make the collider version as a backup option.

## 2024/11/3
Attempting to finish what was done above and will start making the tutorial for this, it will prove useful as searches on how to make a seesaw platform seem to bring up either unavailable content or content that uses within a whole tutorial project. 

#### 3:56pm
Finished making the seesaw platform and uploaded the project to github.

 [Tutorial 1 repository link](https://github.com/SilentVortex/Tutorial-1-seesaw-platform)

## 2024/11/5
Today I decided to make a 2d camera that will follow an object such as a character. While looking at a tutorial (https://youtu.be/2jTY11Am0Ig?feature=shared) I came across the issue of my version of cinemachine not having an option for the 2d camera seen in the tutorial. A quick search later revealed that they had just moved the option to another place as seen here (https://www.reddit.com/r/Unity2D/comments/10h7m50/no_create_2d_camera_option_in_cinemachine/). After that I had a functioning 2d camera however it is not completely finished at the moment. Needs to be finished.

## 2024/11/12
I went back to brief 1 to add a movment function when the player is on it so that it has code attached to it.

## 2024/12/10
After much time I started working on my 2nd tutorial, this took a while due to me reusing old code that i still had and fixing issues it had since it had to be migrated from an older unity version. After making a working scene with all the functions I need to make a tutorial on it I began to write up the tutorial.

##2024/12/17
After a whole week I am still on my second tutorial due to issues with getting the code to work as well as lack of time available, I intend work on it more this week as much as I can.

## 2025/1/9 - 2025/1/11
During these days I got back to working on my tutorials, I had put off doing them due to other modules needing to be submit earlier, however at the end of this I had finished my 2nd tutorial and moved onto my next one.

[Tutorial 2 repository link](https://github.com/SilentVortex/Tutorial-2)

## 2025/1/12
During this day I started my 3rd tutorial, which was a main menu. Since I already had the code for the main menu, all I had to do was change it up a bit so that it could be used as a way to change between each level of a game. It does this by using specific scene names rather than going up a number in the scene order which allows me to make  a level select if i so wish as it just uses public methods which can be tied to buttons.

## 2025/1/13
Today I aim to finish the 3rd tutorial and move on my final tutorial, so far I have not run into any issues when making my code other than testing other functions such as using [SerializeField] instead of making my methods public for me to be able to use it with Unity's button game object. I will continue to work on this tutorial and hopefully it will be finished by today.


I had then managed to finish my 3rd tutorial and then began work on making my 4th and final tutorial, after that I would need to put all my code together in order to make my prototype.

[Tutorial 3 repository link](https://github.com/SilentVortex/Tutorial-3)

I have finished my 4th tutorial and can now move on to making my prototype, I am aiming to make a single level for the player to go through by moving and jumping in a 2D perspective.

[Tutorial 4 repository](https://github.com/SilentVortex/Tutorial_4)

## 2025/1/14
I began work on my prototype and realised I had already made a mai menu for it earlier, I decided to keep this but make sure that it still works as intended. The settings menu was giving me some errors so I decided to do some bug fixing to make it work correctly.

I had realised the reason why it had not worked when I made it was due to it using legacy dropdowns instead of the newer TextMeshPro versions, once that was changed it began working. I should probably find out how to change it the newer dropdowns in my own time since the lgacy options will be removed at one point.

I had finished the day off by putting all the necessary files i needed to make my prototype from my tutorials into my scenes and with that done i was ready to add the scripts i needed as well as any other parts that i need in order to make the prototype function completely.

## 2025/1/15

Now that I had gotten all my resources together I began to make the level that would serve as the 1st one. I decided to utilise Shigeru Miyamoto's 1-1 level from the original Super Mario Bros as the inspiration for this level and as such it borrows the layout heavily from it. I have changed some parts up to add functions that my prototype includes such as the plan for tilting platforms as well as ones that can move.

I then fixed up some code to make it function as a game, once done I could fully play the game.

Once the game was fully playable I then went and made the video for it and uploaded my source code to the Github repository that I had for it, with that done I was then ready to submit to the VLE.

[Prototype repository](https://github.com/SilentVortex/Learning-Journal-and-prototype-project)
