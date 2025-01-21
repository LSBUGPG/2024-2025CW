# 3D First Person Camera POV 
## In this tutorial, we will be demonstrating how you create a First Person View Point of View in 3D Unity. The player will be in First Person and the camera will move according to the Player's mouse movements.

1. Create a scene in Unity, and then create a Game Object that will be used as your player and attach the Main Camera of the scene into the Player, becoming a child object to the Player Object.
2. Reset the Camera's Transform position, then change the Y axis Transform to 1. X and Z axis Transform Positions should be on 0.

### Now it's time to code, if you haven't already, Click on your assets folder, right click inside the folder, click Create -> Folder.

1. Create a C# Script inside the Script folder, by opening the Script folder, right clicking inside the folder, click Create -> C# Script and we'll call it FirstPersonCamera.
2. Open the script by double clicking and Visual Studios should open up.
3. We're first going to start off with Variables, so create some space above the void Start() statement by click above it and pressing Spacebar.
```.cs
public class FirstPersonCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0;

    bool lockedCursor = true;
```
The "public Transform player;" variable is to reference the player.
The "public float mouseSensitivity = 2f;" is to provide a value to the mouseSensitity, the value determines how strong the Mouse Sensitivity is.
The "float cameraVerticalRotation = 0;" is to simply make sure the camera is in its default position, straight, when pressing play in Unity.

4. Next, we go down to void Update(), and then we're going to collect the mouse input. 
```.cs
void Update()
{
  
    float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
    float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;
```
This collects the Mouse Inputs, allowing you to move the camera with your mouse through both the X and Y axis. 
The "* mouseSensitivity* part is so that the inputs of your X and Y axis mouse movements have a value, and we previously put the value as 2, which determines how strong the mouse sensitivity is when moving your mouse.

5. We're now going to write out another line, which will have the Camera rotate in its local X Axis. This means that the camera will move vertically, up and down.
```.cs
cameraVerticalRotation -= inputY;
cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
transform.localEulerAngles = Vector3.right * cameraVerticalRotation;
```
We first have to make sure that this line is specific to vertical movements, so we started off with making the Camera's vertical rotation to be inputY. We put a negative for the input because the mouse moving up is a positive value, but for the camera to move up, it needs to be a negative value.
We then put a limit to how far we go look up and down so the camera doesn't go beyond a certain point so we place a 90 degree limit to both looking up and down, hence the "-90f, 90f" part of the statement.
Then for the last line, we need this so that the camera can actually rotate/move whenever we move the mouse.

![image](https://github.com/user-attachments/assets/b94190a1-d187-41b0-ace2-8cee11ef2ad6)

Then back on Unity, click on the Main Camera which should be inside your player and add in the First Person Camera script into the Main Camera as a component.

![image](https://github.com/user-attachments/assets/e99129e9-6617-4d89-872a-ee3a105c93b6)

Then where it says Player, click and hold your player gameobject and drag it into the Player section inside the First Personn Camera script component.

6. Now we come back into the First Person Camera Script and underneath the Vertical Rotation line, we're going to work on the horizontal rotation. So what we type is:
```.cs
player.Rotate(Vector3.up * inputX);
```
This will make it so the camera rotates horizontally when the player moves the mouse horizontally.

### That's it for the First Persona Camera, however, you'll notice that the mouse is still visible when you press play in Unity, so let's remove that.

7. We go back into the First Person Camera script, and we're going to add a new varibale:
```.cs
 bool lockedCursor = true;

 void Start()
 {
     Cursor.visible = false;
     Cursor.lockState = CursorLockMode.Locked;
 }
```

This will help to hide the cursor and lock it so that when you click play and just click anywhere, the cursor disappears and is locked, but you are still able to move the mouse around and control the First Person Camera.

This is how it should look and function in the end.




https://github.com/user-attachments/assets/d5ebcd2f-ad87-4159-abf6-6e45ad83480b



