# drag and drop 
welcome to this tutorial
Aims
* to understand what drag and drop is 
* to get better at following tutorials
* to use the code in your own time
* you need to understand unity and how to code in general.
# what you will need to know in
* Github
* know basic code
* be able to access unity 
* have a laptop or computer.
# Welcome to the tutorial
this tutorial, you will learn how to use drag and drop to move an object.
* 1st step
* open unity
* # you will need these applications to begin the drag-and-drop system in Unity as a reminder:
* Unity
* Visual Studio 
Github-only if you would want to wrightup anything about the code you have done or general progress.
its a simple one to do with simple steps. Please open unity
![9a58ef0b0a39424aaf70dd4c30539b477ae54697-1200x630](https://github.com/user-attachments/assets/f06d5a02-bab6-49e4-8313-e0b10064ea6e)
please create a new project. Please call this drag-and-drop 
![image](https://github.com/user-attachments/assets/4374aa45-5891-4280-8f9d-66fd1eae3ee1)
# how to create a script for this tutorial.
![image](https://github.com/user-attachments/assets/3e42edf3-db9b-4a49-8790-b0969ee37a90)
# how to create a game object in unity.
![image](https://github.com/user-attachments/assets/72ad6942-aa25-4342-8343-2ddd8cbd1bde)
* This is a normal step to create assets, so please open up unity
**Step 2:** Create a new file and give it the title "Drag and Drop."

You can open your game development software and navigate to the main menu to start this process. Look for the option labelled "New Project," which will typically allow you to initiate a new game. Once you find it, double-click on this option to proceed.

Next, when prompted, enter the name of your project as "Drag and Drop." This name will help to identify your project later on. After naming the project, you should see a blank workspace or an empty screen. This is where you will begin constructing your game.

The next step is to create a game object, a fundamental part of any game. In this instance, you will create a simple cube, which will serve as a basic demonstration of object creation and manipulation within the game.

To create the cube, look for the "Game Object" menu at the top of the screen. Click on it, and a drop-down list will appear, showcasing various objects you can add to your scene. Select "3D Object" from this list and click "Cube." Once you do this, a cube should be generated and appear in your workspace.

Now that the cube is visible, the next goal is to make it move. Understanding how to manipulate objects is crucial for game development, as this allows for interactive gameplay. You can find more options to control the cube and other objects under the "Game Object" menu, where you can further explore different shapes and properties.

Please create the cube to test your setup and familiarise yourself with the object creation process. By doing this, you'll gain hands-on experience that will be valuable as you develop more complex game elements.


I will outline the code rules to enable your mouse to effectively move and position objects on the map. In the initial section, we will define a variable that facilitates dragging. This variable instructs Unity to permit the object and a specific keycode that you will assign later to be moved and dragged around the screen easily. Essentially, it's a straightforward process that allows you to interact with objects dynamically within your scene.
# the actual code And extra explanation with examples down below
    bool canMove;
    bool dragging;

    Collider2D collider2D;
    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<Collider2D>();
        canMove = false;
        dragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (collider2D != null && collider2D == Physics2D.OverlapPoint(mousePos))
            {
                canMove = true;
            }
            else
            {
                canMove = false;
            }
            if (canMove)
            {
                dragging = true;
            }


        }
        if (dragging)
        {
            this.transform.position = mousePos;
        }
        if (Input.GetMouseButtonUp(0))
        {
            canMove = false;
            dragging = false;

        }
    }
} 
![image](https://github.com/user-attachments/assets/7fd0f4d2-eca7-400e-a3fc-ababc6057665)
what the get the component does is you tell Unity what you would like to add 
without this, you wouldn't be able to identify the type of core section
that it is you will assign a keycode to the script. This would let you move or drag the object.




the purpose of the two above you need the basics to do anything in unity and this would give a good example of how to do it.
how does it work in game mode you should be able to move the object or drag and drop anything wilst moving.
now that it should work you can add a floor you will need a box clollider just in case
* go to game object
* press create 3d object
* create plane 
![image](https://github.com/user-attachments/assets/0d077d41-5bac-4d61-a284-aea26539e419)
the point of this is understanding how you create a background for this scene
for the possiblity that the object will fall so by having it flat on the ground will be able  to move
for fun you can add a new material for the game object being a new colour 
  ![image](https://github.com/user-attachments/assets/cf9e494d-7daa-4d05-b942-68e6a95dab76)




Please then follow the video of the basic set-up and copy so we have all we need to start as this is an important step for any programmer to have to learn when doing this.
//I could'nt add a video to the tutorial due to size of the file so here is a screenshot//
the purpose of the tutorial is to do something fun but its a general simple one to do and takes up not a lot of time 
drag and drop is used mainly in balloon tower defense games dragging in different turrets at a time 
here is a finished product of the code.
![image](https://github.com/user-attachments/assets/4ad62059-3331-4af9-b7e0-002dbfab8af9)
the finished product will allow movement so to perfect this you need to add a keycode being the mouse how do you do this so you need to stay on the same code that you have created add a new line and we will go through step by step 
here is a screenshot.
![392043731-4ad62059-3331-4af9-b7e0-002dbfab8af9](https://github.com/user-attachments/assets/1a8bb8f9-fb4a-41b1-b656-2edfde593eed)
Please follow this screenshot what does the getmousebutton do it allows the mouse to control the cube or gameobject in the game scene this allows the function to work going forward and it enables you to check if the code actualy works.
![image](https://github.com/user-attachments/assets/cfb65fc2-c097-426c-8738-efe1802bbb0f)
once you have the code done we will move on to the next section so we will focus on an area that adds more purpose check down below.




once you have the c# file open please start typing this code 
 bool canMove;
 bool dragging;
 this enables you to move the object you chose allowing the functionalilty to work 
 next step
 ![image](https://github.com/user-attachments/assets/23966cf6-20a1-40a2-99cc-3d32a85ac6c6)
 so put this code in the void start section as this would not loop so please put this code in here for the functions.
 # Next step
 the next line of code is important as it builds up on the main functions as these will enable you to add core parts of the code as this will allow proper functions 
   Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

   if (Input.GetMouseButtonDown(0))
   {
       if (collider2D != null && collider2D == Physics2D.OverlapPoint(mousePos))
       {
           canMove = true;
       }
       else
       {
           canMove = false;
       }
       if (canMove)
       {
           dragging = true;
       }
 
please follow by adding this text in the script attaching a screenshot of what to put in what section to make it easier for you to follow.
![image](https://github.com/user-attachments/assets/80ac5fed-6c22-449d-bf16-d853ba403ec0)
The idea behind this code is to create a function that allows the GameObject to perform specific actions. This will ensure that the code you enter will not result in any errors. 

I will now add the final code, which will complete the functionality. Once implemented, when you enter game mode and click on the screen, you will be able to move the item around. As an extra challenge, you can test this out and try to drop the item anywhere.

Here is the code; please add it to the bottom of your existing code.
![image](https://github.com/user-attachments/assets/408cd4d6-71ac-427d-8f1a-de1da82266ee)
make sure you put it below the {
in the code.
![image](https://github.com/user-attachments/assets/2828f1cc-fd2d-44e2-b299-518511116075)

thank you for following a silly code.
#
# summary 
* you have learnt to drag and drop
* the basics of creating objects
* adding functions
* how to open/create scripts.
purpose of the tutorial is to learn something fun and simple to do

conclusion 
The drag-and-drop system provides significant advantages, particularly in gaming contexts such as tower defence games. This mechanic allows players to easily manoeuvre characters or objects on the screen, enhancing their ability to strategize and respond to dynamic gameplay situations. For instance, when players need to reposition a character or a tower to maximize its effectiveness against enemies, the drag-and-drop functionality enables quick and intuitive movement. This streamlined interaction not only improves the overall gaming experience but also encourages players to engage more deeply with the game's tactical elements, as they can swiftly adapt their strategies in response to enemy actions.










