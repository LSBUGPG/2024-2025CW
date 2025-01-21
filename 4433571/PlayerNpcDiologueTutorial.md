# Welcome to the npc tutorial.
today, you will learn how to make NPC dialogue
this can be a hard one to do, we're going to explore the art of crafting dialogue for non-playable characters (NPCs) in games and storytelling. Writing engaging NPC dialogue can be quite challenging, as it requires a great deal of creativity and patience. 

First, consider the personality and background of each NPC. What are their motivations, fears, and goals? Understanding these aspects will help you create authentic interactions that feel natural within the game's world.
you would need to think behind the ideas of what your character is going to do if it's just a simple chat that is the reason behind the tutorial.

Next, think about the context in which the dialogue occurs. Is the NPC providing information, giving a quest, or simply engaging in small talk? Tailoring the dialogue to fit the situation will enhance the player's experience.

i use this video to help me learn the code in the tutorial its up to you if you would like to use it.
////https://www.youtube.com/watch?v=1nFNOyCalzo//
# intro
The NPC dialogue system is a versatile tool that serves several important functions in game development. Primarily, it facilitates the creation of conversations between non-player characters (NPCs), enhancing the storytelling aspect of a game. This system allows developers to simulate interactions, bringing the game world to life through meaningful dialogue.

One of the key features of this system is the ability to test conversations quickly and efficiently. For example, you can assign a specific key, such as the "E" key or the spacebar, to trigger the dialogue user interface. This setup makes it easy for you to progress to the next line of dialogue or question, streamlining the testing process. 

Additionally, the NPC dialogue system enables an automatic flow of conversation based on the text you input into a designated file. This means that once the system is set up, the dialogues can change dynamically according to the player’s choices or inputs, creating a more immersive experience.

The main goal of this tutorial is to help you understand how the NPC dialogue system works and how you can implement it in your games. You will learn how to create interactive dialogues that allow multiple characters to engage in conversations, enhancing the overall gameplay experience.

Furthermore, if you are interested in taking on an enjoyable challenge, working with this dialogue system can be a rewarding project that hones your skills in game design. Before we dive into the tutorial, please ensure you have downloaded all necessary applications and tools required for this process. This preparation will help you fully engage with the material and get the most out of the learning experience.* the npc diologue is used in many ways it helps to create converstions between two npc characters
# you will need these items to start:
* unity- is used by most programmers universibly and a simple app to use 
* github- is very popular and you are able to add files into different sets of folders including names of each scenes you made and will show up
* just a quick reminder you may get some errors but should be fine if you get stuck ill put a video at the end of the tutorial.
* github desktop app
* visual studio
# next section 
to import the files and the importance of this is so we know where our files and main sections can be located and protected in the future.
so if you have unity installed please open up a 3d project file how you do this right follow the image down below 
![image](https://github.com/user-attachments/assets/ffe63c4e-3526-437f-a24a-d395af2b016c)
so follow the arrow if need help i will put a video also at the end 
So create a uv file it will be found in the assets 
once you have a uv text document this will apply a conversation or a background for the code to work as this enables the functions to work moving on forward you will need to add text file to find this ill add an example from earlier. 
the example will show the code and teaches you how to create a file or the ui 
what does the ui do i allows you to work on text mesh pro and creates a canvas for the npc to chat and includes the balance needed
step by step benefits a simple process.

![image](https://github.com/user-attachments/assets/0efd9c23-07b5-4c13-8a4f-a5045a960168)
before we start the code im going to show the finished product so you know what to expect from the code lesson and the tutorial itself as a simple thing to do.
![image](https://github.com/user-attachments/assets/740099bf-7917-43d5-b25a-9a35352152f0)
i used a youtube video to help with any errors i may of found when doing this myself
//https://www.youtube.com/watch?v=1nFNOyCalzo//
If you want a advance version for extra reading try this tutorial if you like a challange
//https://www.youtube.com/watch?v=vY0Sk93YUhA//
 Lets get into the codeing parts So please create a c# script 
 How do you do this so go into create you do this by right clicking the mouse check the image below as an example.
 ![image](https://github.com/user-attachments/assets/096173a5-7098-4055-8850-873498f12690)
Please doubleclick the script but call it the npc chat to shorten the name to save time 
![image](https://github.com/user-attachments/assets/ace42129-e723-44d5-92ce-f2de33a836dd)
This will then take you into the visual studio

This should pop up when clicking on the script.
so before we do anything just yet make sure you have a text file on the npc dialogue how you do this its a pretty simple
so open the create option go into the ui and get to the legacy option and pick text this is here to remind you and so it works going forward.
![image](https://github.com/user-attachments/assets/0377b739-6280-49ac-b914-94fdb681aecc)
also you will need to create a npc character that can be a simple cube since just a sample as it would have more functionality as you would have multiple codes that would align in the idea so they work together
so create a ui document this would give you a gray block text file name it anything you like 
and then after that add another text file but leave this blank you will need also a canvas which will include a button and the ui needed for these tasks this may feel random it must look like this.
![image](https://github.com/user-attachments/assets/706aae83-b9e8-4bf2-84c4-1beb6e037532)
![image](https://github.com/user-attachments/assets/4a1806e1-c5b6-4f7d-a00a-f7a8362a6d6b)
in the second screenshot follow the gameobject mode and create the ui types each one being different.
![image](https://github.com/user-attachments/assets/06dad15d-4116-446d-a48e-44a79ece7935)

in this screenshot create the eventsystem and the canvas as these are needed for this to work also select the text for the functions and naming of each part of the dialouge.
# back to the coding part after taking a detour
Continuing the coding so you have the visual studio open please go back into this app as you will need this to do the vital part of the npc chat so starting of simple please follow this screenshot of the first part please make sure you label the objects you made these are !IMPORTANT! it could mess up your files and the whole thing if not careful so please copy the names.
# code part 1
public GameObject dialoguePanel;
public Text dialogueText;
public string[] dialogue;
private int index;

public GameObject contButton;
public float wordSpeed;
public bool playerIsClose;
screenshot
![image](https://github.com/user-attachments/assets/62eb80b3-c693-467b-8137-c027b9d2f8c8)
![image](https://github.com/user-attachments/assets/91ec8d33-3a04-4958-8018-b639e9086906)
Then after that please put the next step of code this is an important one as this will help enter text which has a keycode when pressed will show up
so please enter this code
![image](https://github.com/user-attachments/assets/d0594950-4dd4-4fbe-b155-22f7d6c08632)
 if (Input.GetKeyDown(KeyCode.E) && !playerIsClose)
 {
     if (dialoguePanel.activeInHierarchy)
     {
         zeroText();
     }
     else
     {
         dialoguePanel.SetActive(true);
         StartCoroutine(Typing());


     }
 }
 if(dialogueText.text == dialogue[index])
 {
     contButton.SetActive(true);
 }    
it wants to check for any text or functions you have applied to make sure its fine to use.
here is the full code for time reasons so you can learn but also the finished product as this will enable the code and the functions 
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;
    private int index;

    public GameObject contButton;
    public float wordSpeed;
    public bool playerIsClose;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !playerIsClose)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());


            }
        }
        if(dialogueText.text == dialogue[index])
        {
            contButton.SetActive(true);
        }    

    }



    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        contButton.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());

        }

        
        
        else
        {
            zeroText() ;
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }

}     
after doing this you will need to add the objects to the npc game object we created later 
for this code to work in general so here is a screenshot of how to do this its pretty simple.
![image](https://github.com/user-attachments/assets/e2dd6c99-1e47-4582-ac7c-031d6a74f148)
thank you for listening i wanted to create a fun project/tutorial that you can follow during
here is some links i mention i will put in 
for github
https://www.youtube.com/watch?v=-RZ03WHqkaY


     


















