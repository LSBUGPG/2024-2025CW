# Jump tutorial
welcome to the jumping tutorial 
what  you will need to work on the tutorial
* unity
* github
* visual studio
why do you need these they are the core to the project and are key to the success to the project not failing
the point of visual studio is for any c# scripts you make or use will apear and will let you know if any problems occur and how to learn form the errors.
create a folder in google drive or onedrive as this is where your files will be contained in files
open up github as you need to have something to remind you if you forget what you are doing.
here is a screenshot of how you do this 
![image](https://github.com/user-attachments/assets/157148bc-6ded-42aa-aecc-edcabd0c098e)
pretty simple to do 

the jumping tutorial is important as it is used in most games but is a fun one to do as you can cause the boxes to interact but you also need to focus on how you don't want them to fall 
# what you will learn
the basics of coding how the jumping machanics work in a game 
how a rigid body works 
how to make a plane for a simple floor of the game.
learn more about unity 
welcome to the jumping tutorial 
today you will learn how to make a box jump up and down 
so open up unity 
create a c# script 
you will call this jumping
as you will need to attach this to a cube without the actual scripts you wouldn't do anything so just wasting pure time.
so once you have the c# script open it and you will need to put the code in a section called update this will loop meaning that its infiniate i don't know how to spell but the idea that anyhting you put in that sections you will get a code done 
put in this code in the screenShot below 
!
![Jumping](https://github.com/user-attachments/assets/7b668e8c-20ae-4290-b761-6965fa89e02b)
so please add the code in the image so you might see a change in the box you have previously created 
just incase an error appears please put C For the KeyCodeDown part like this so no errors will appear 
so should look like something like this 
![game](https://github.com/user-attachments/assets/28a05214-e1fa-4ca5-b4ea-e8271e70206b)
# nextStep
please make sure you have any ojects you have created are on the screen
so if you could add the next part of the code to add in the script created earlier as it is included as you may have some problems
including errors or more to make the code work rapidly press the spacebar as it would allow you to see an action.
![image](https://github.com/user-attachments/assets/3a56a600-9b37-4085-98bf-ffe78d2001cf)
please take a look into the picture above please just put these lines of code under the right parts the first one will be 
this  rb = GetComponent<Rigidbody>();
just this code> isJumping = false; underneath

    rb.velocity = new Vector3(0, 5, 0);
    isJumping=true;

      private void OnCollisionEnter(Collision collision)
  {
      isJumping = false;
  }
so it should end/look like this when finished.
![cube](https://github.com/user-attachments/assets/53a66a23-a196-4d3a-946e-944b2e34f578)
how it works you press the spacebar as you create the key for this this enables the function
that boosts the cube by constantly pushing the cube higher and higher nonstop but also you will need to add a rigid body so it just doesn't drop straight away.
I'll put an image down below of how to create the rigid body pretty simply.
# Make sure you put a rigid body 
![line](https://github.com/user-attachments/assets/3e15f970-b97c-4b3a-b928-23a284507bda)
this would enable you to see the game object and this would stop it from falling this would be in place automatically 
