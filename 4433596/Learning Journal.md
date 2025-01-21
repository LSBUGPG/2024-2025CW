# Learning-Journal-GP
Learning Journal for Games Programming (Year 2)

15/10/24
- Created learning journal
- Getting to understand the process of learning code
- Learnt that coding scripts is a step by step build up process.

22/10/24
Planning and Brainstorming Ideas for my tutorials:
- First Person movement and jumping in a 3d Environment.
- Taking damage i.e. from high ground, from objects like Spikes
- Meter bar for things like HP


- Started the First Person Movement, first starting with using a random game object (capsule) and tested its horizontal movement.
- Searched through tutorials and had a go at them. Bumped into many issues such as misunderstanding certain scripts and objects in Unity.
- The main reason for this was because the tutorial had skipped major parts i.e. didnt show the process of creating emptyobjects, cameras etc.
- It also referenced to other tutorials they had created, so it wasn't exactly successful when working on the movement. So instead, I looked for a new tutorial and that was successful.
- As I was planning, I realised that those should be done after I do other steps, i.e. taking damage means I'd have to make a health system. So I took a step back, and decided a HP system should be completed first.

29/10/24
- Continued with First Person POV movement, searched for other tutorials.
- Decided to work on First Person POV first and was successful, little to no issues/errors.
- Began working on movement
- First started with the Camera, created a script solely for the Camera, the camera being in first person POV and it is controlled simply by moving the mouse.
- I attached the main camera, that is created from simply creating a Unity project, to my Player and the first person POV was successful, as well as the camera movement.
- Went back to work on player movement, and it was somewhat confusing and bumped into a lot of issues since I wasn't able to understand what was going on, so I restarted and searched for a different tutorial.
- The main reason for it, was because the tutorial I was looking at, had skipped a few major steps, like creating the empty objects and making more than 1 camera, so I was unsure of what to do, and couldn't figure it out.
- I looked for a different tutorial, and this tutorial was a lot better at explaining, and included the major parts when explaining how things works and what to add.
- Movement became a lot more successful, with little to no issues. It contains simple movement with jumping, and has a lookXLimit so it doesnt look further than say 90 degrees.

05/11/2024
- Finalised the player Movement, and began to work on the Health System.
- I found a tutorial on a health system that functions like Dark Souls, and used the tutorial to help on the health system.
- I bumped into a small issue where, one of the HP bars, which functions as the main HP, to not actually appear in the scene.
- What I did was, rearrange some of th objects and emptyobjects in the inspector, connecting so that it becomes a parent/child.
- I had had to re-shape the hp bar since I found out that, duplicating an object, doesn't fully copy everything and that was what went wrong, so once I fixed the shape of the main HP Bar, it displayed in the scene and works
how it should do.
- I went to the object that has the shape of the HP bar, and I had to re-shape the Anchor preset in the Rect Transform component, once I did that for the duplicated object, it appeared this time when I tested it and functioned how it should.

12/11/2024
- Last week I finished the health system, and now this week, it's about my player taking damage.
- I'll be experimenting i.e. taking damage from other objects (these objects will be playing as enemies/environmental objects i.e. spikes)
- I began searching for a tutorial online.

15/11/2024
- Started to work on tutorial 3, where my player takes damage when coming into contact with something, in this case it'll be a placeholder object (a cube)
- I managed to find a tutorial on how to get these objects to damage my player when coming into contact, I bumped into a few issues when working on this tutorial.
- What went wrong was that whenever my character came into contact with the object, I wasn't being damaged or losing HP.
- I thought it was an issue with the script, but it turns out I forgot to add in components to the cube playholder, rigidbody.
- Once I added the rigidbody, I actually started to take damage when coming into contact with the cube.

19/11/2024
- Continuing the taking damage tutorial work.
- Bumping into issues where taking damage is inconsistent.
- I'm using a cube as a placeholder and whenever I bump into it, I either take damage, or I don't which isn't supposed to happen. I'm supposed to take damage whenever I come into contact with the cube.

26/11/2024
- Began my last tutorial, which is the Menu System.
- A lot of tutorials involve a main menu system where it includes backgrounds, but I didn't have one so I had to look for one that did not contain a background.
- I went with a tutorial that included a background, but I was able to skip the background step, and focus on the buttons for the Menu system.
- I then found one and started the tutorial. I bumped into an issue where my text wasn't appearing when I created a buttion - Text Mesh Pro, but then I figured out that I had to install the Text Mesh Pro imports and then the text appeared for my button.
- For the most part, the tutorial went smoothly and didn't bump into issues for majority of the way through, but towards the end, I bumped into 2 issues.
- One of which, was that my "back" and "quit" button were overlapping initially, but whenever I clicked some of the buttons, it resolved the issue, but never resolved the initial start.
- I solved it simply hiding then "back" button, and it fixed the overlapping issue, whilst still appearing when it needs needed.
- The second issue was that whenever I clicked the "play", it did not load my tutorial scene.
- I solved the issue, which was the "SceneManager.LoadScene" line was actually incorrect, so I changed it so that it tags the Tutorial scene and once I clicked "Play" again, it loaded into the Tutorial scene and worked.
- After I finish with the Menu system tutorial, I got back to tutorial 3, which is the tutorial where you take damage when colliding with an object.
- The issue I faced was that the damage I take when colliding with an object was really inconsistent. Sometimes I collide with an object, I take damage but sometimes I don't.
- Eventually it got to the point where I asked for help, and we noticed that whenever I take damage, it's when the object I'm colliding with, moves.
- Whenever I bumped into it, sometimes it would get knocked over and that's when I take damage.
- This is what I previously had.
```.cs
private void OnCollisionEnter(Collision collision)
 {
     if (collision.gameObject.CompareTag("Spike"))
     {      
         healthSystem.takeDamage(collisionDamage);
     }
 }
```
- Then I changed from OnCollisionEnter, to an OnTriggerEnter which looks like this:
 ```.cs
private void OnTriggerEnter(Collider other)
 {
     if (other.CompareTag("Spike"))
     {
         healthSystem.takeDamage(collisionDamage);
     }
 }
```
10/12/2024
- Working on the game prototype, I bumped into an issue where my character would take damage whenever I collided with an object on its side, but whenever I jumped on top of an object, I don't lose damage.
- It was originally an OnTriggerEnter, and I changed it into an OnCollisionEnter, but that didn't work.
- Since my player was on a Character Controller, I changed the OnCollisionEnter to an OnControllerCollisiderHit.
 ```.cs
private void OnControllerColliderHit(ControllerColliderHit hit)
{ 
    if(hit.collider.CompareTag("Spike"))
    {
        healthSystem.takeDamage(collisionDamage);
    }
}
```
- This definitely helped a lot, since now whenever I collided on top of an object, I'd lose damage.
- However, because the player constantly and lost HP extremely fast, I had to implement an invulnerability into the script.
- So I went to my health script, and added in a variable, a float invulnerability variable. I then went to void Update and made it so invulnerability isn't so fast and put in Time.Delta Time.
- Then to add to that, I went to my takeDamage command in the Health system and added in an if statement and put that if invulnerability is greater than 0, put in a return command.
- Then, I had to make a command which controls the duration of invulnerability, so underneath my health -= damage; command, which is under the if invulnerability statement, I did invulerability = 1f.

17/12/2024
- Fixing my respawn for my player. I previous had a respawn for whenever my player falls off the map, and if they pass a certain threshold, they'd respawn back at the respawn point.
- I bumped into issues where whenever my player reaches 0 HP, my player doesn't respawn. I could see that my "Die" statement was functioning with Debug.Log, but my player wasn't actually respawning whenever my player dies.
- My respawn script to when my player falls off the map was separate, so to respawn my player when he reaches 0 HP, I had to put in my respawn function in my Health script.
- I went to my "void Die()" function in my health script, and tried to reference charactercontroller. I had it disabled when my health reaches 0, then re-enable when my player respawns after he dies and goes back to full health.
- That went unsuccessful, but I needed confirmation if it was actually being picked up, so I added a Debug.Log and tested it. It turns out it wasn't picking it up so I had to try something different.
- I then tried to reference the player itself, so I referenced my PlayerMovement script. I had it so that it'll find the PlayerMovement script, then once it detects it, it'll respawn my player.
- I also had to make a public void Respawn in my PlayerMovement to help reference my health script to my PlayerMovement, and I did what I did initially, where I made it so the charactercontroller is disabled when my player dies, then my player respawns and has full HP, the charactercontroller is then re-enabled.
- This was successful and my player respawns whenever it dies as well as when it falls off the map.

