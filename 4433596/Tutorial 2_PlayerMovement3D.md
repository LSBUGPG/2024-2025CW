# Player Movement 3D Unity (First Person) Tutorial
## In this tutorial, we will be showing how Player Movement is done in a 3d environment in Unity. 

## Prerequisite: This tutorial requires a camera, so you must have a camera for this tutorial to work as this player movement directional controll is from the camera. It's advised that you already have a Camera system, preferably a first person camera, and if not, my first tutorial covers how to create a first person camera.

### Firstly, you want create or open up a scene in Unity 3D.

1. For my tutorial, I simply used a Capsule as a temporary object to be used as my player, so I created it by going to GameObject at the top of Unity -> 3D Object and selected Capsule.
2. We'll click our Player then on right side, click add component, and add Character Controller.
3. If you haven't already, create a scripts folder by clicking your assets folder in Unity, right click and select Create -> Folder and call it Scripts.
4. Now create a script by right clicking in the Scripts folder, click "create" then select Create "C# script".
5. Double click on the script and Visual Studios should pop-up. 
```.cs
public class PlayerMovement : MonoBehaviour
{
    public Camera playerCamera;
    public float walkSpeed = 3f;
    public float runSpeed = 7f;
    public float jumpPower = 7f;
    public float gravity = 12f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    public float defaultHeight = 2f;


    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0;
    private CharacterController characterController;

    private bool canMove = true;
```
These are the variables we're going to be using for our player movement. Firstly the public variables: the playerCamera is simply to reference the First Person Camera for our first tutorial, for our mouse controlled look-direction. The walkSpeed, runSpeed, jumpPower and gravity variables defines the movement parameters for those exact actions, running, walking, jumping and the gravity. lookSpeed and lookXLimit variables are to controll how fast the player can look around with the mouse movements and the verticle angle limits for looking up and down. And finally for default height, it's simply just to set the default height of the player (used when player is grounded).

For our private variables: moveDirection is about the player's movement direction (including gravity and jumping). rotationX is about tracking the camera's vertical rotation (looking up and down). characterController is a reference to Unity's character controller component which is used for player movement And last, canMove is a flag to toggle whether if the player is allowed to move or not.

6. We now begin coding the other parts of the script. We're going to lock and hide the cursor in our void start placement which locks the cursor to the centre of the screen for first person movement, as well as reference our character controller component. 
```.cs
void Start()
{
    characterController = GetComponent<CharacterController>();
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
}
```
### Now we begin the actual coding for the movement in void Update() part.
```.cs
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }
        else
        {
            characterController.height = defaultHeight;
            walkSpeed = 6f;
            runSpeed = 12f;
        }

        characterController.Move(moveDirection * Time.deltaTime);

        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
    }
}
```
Explanation: 
Firstly we'll talk about the movement aspect of the script. Our Forward/Right movement is based on the player's input, specifically the horizonal and vertical axes. It checks if the player is running (holding shift), adjusting the speed accordingly. If the player presses jump (spacebar), and the character is grounded, the y component of moveDirection is set to jumpPower, making the player jump and if the player isn't grounded, gravity is applied by decreasing the y component of moveDirection. The CharacterController.Move() method moves the player based on the calculated moveDirection. 

Camera/Look Movement: Mouse input is what's used to control the camera's rotation, both vertical and horizontally. The vertical rotation is clamped using Mathf.Clamp() to avoid the camera flipping, constrained by lookXLimit, so the player can't go beyond 90 degrees when looking up and down. The horizontal rotation rotates the player's body left and right based on mouse movement, so however you move your mouse, is mirrored to the players look movement.

### That's it for the coding, now we save the script (Control + S) and go back into our Unity scene with our player.

7. Right click on the hierarchy and create an Empty object, calling it GroundCheck. Now we make sure that the local Positions for this empty gameobject to be 0, -1, 0 (XYZ order), which places it at the bottom of the player.

8. Now we select our Player, and on the right, add in the PlayerMovement C# component onto the player.

![image](https://github.com/user-attachments/assets/b5fd68cc-b25b-47cd-96b8-b9485d2c5fa5)

I added in the camera into the camera variable (from first tutorial) and then set the values of the other variables to my liking. This is how it should look in the end.




https://github.com/user-attachments/assets/4a81b9fa-eece-4f56-b235-b47cc0dbfdb3

