# Health System Unity 3D (Dark Souls-like) 
## This tutorial is based on how to create a health system that functions very similarly to the well-known game, Dark Souls. Whenever the player takes damage, you'll see another colour health bar which simply indicates that you've taken damage, rather than simply the health bar going down.

1. Create a new scene in Unity, or if you already have a scene, open that up. 
2. Right click the hierarchy, hover over UI, and select Canvas.
3. Select 2D at the top of your scene to get a better view of the canvas, then click Canvas in the hierachy, right click then create empty object and name it Health Bar.

![image](https://github.com/user-attachments/assets/35cf82a1-b575-4482-a8b5-29ede84bb9f6)

4. You then modify its scale and re-size it and re-shape it to how you'd like, then select Health Bar in the hierachy, right click, hover over UI and click image and re-name this to Background.
5. Then, on the right you want to adjust the anchor presets by selecting on the anchor icon in the Rect Transform component, and selecting stretch/stretch

![image](https://github.com/user-attachments/assets/3f28e73e-a873-4ed7-bba4-e8d2e455a517)

6. Then on the image component of the background object, we're going to change the colour, I chose a dark red colour for mine.
7. Next, we're going to make another UI image, so again, right click the hierarchy -> UI -> Image and name this Fill. Make sure this UI Image is above background but is still a child to the Health Bar object on the hierarchy.
8. Just like for the background, adjust the anchor preset to the same exact anchor as the one we done for Background, remember to hold the Alt key and select the stretch/stretch anchor (refer to the screenshot above)
9. In the Image Component for the Fill object, select a brighter colour than the one you chose for Background, I chose to do a brighter red this time.
10. Now select on the Health Bar game object in the hierachy, and we're going to adjust the positioning of the health bar, once again we're going to adjust the anchor preset but instead of selecting the stretch/stretch anchor, we'll be selecting the top left anchor for the health bar. Now it'll go directly to the top left, so moving it downwards and moving it outwards will make it appear better. 

![image](https://github.com/user-attachments/assets/c1b25812-6827-41b8-ba66-a16d67ce6bec)

11. Next, on the Health Bar object, add a "Slider" Component, then click and drag the Fill Object and place it in the "Fill Rect" section of the Slider component. Then below it, you'll see a slider "value" move that back and forth to test if it is working, you should see that the lighter colour increase and decreases with the darker colour still not moving behind the lighter colour.

### Now onto the code for the health system

12. Create a C# script in the scripts folder and name it Health, and open up the script. At the very top, add in "using UnityEngine.UI;" and then we're going to add in the following variables:
```.cs
public slider healthSlider;
public float maxHealth = 100f;
public float health;
```

And in void Start (), add in "health = maxHealth;

13. In void Update (), type in:

```.cs
if (healthSlider.value != health)
{
    healthSlider.value = health;
```

This is a condition where it checks if the slider value is not equal to the health value, and if it isn't, it will modify the slider value to be equal to the health value.

14. Back in Unity, create another empty object, then make sure the Health Bar is a child of the empty object. Name this Empty Object anything you like, I named it mainHealthBar. Add in the Health script into the mainHealthBar object and since we have a public slider variable, we click and drag the Health Bar object into the slider variable of the script. Make sure mainHealthBar is a parent object to both the Health Bar and Ease Health Bar.

15. Next, we now click on the Health Bar Object and duplicate it, calling it Ease Health Bar. Then selecting Health Bar, we'll delete the Background object, and for Ease Health Bar, we'll chosoe the Fill Object and change the colour to yellow (I chose Yellow, you can choose another as long as it's not the same as the first 2 colours we put initially).

16. Back in the Health Script, we're going to modify it and add more into it, for the Ease Health Bar. We're going to add to the variables, so here's what your varirables should look like after adding the new variables.
```.cs
    public Slider healthSlider;
    public Slider easeHealthSlider;
    public float maxHealth = 100f;
    public float health;
    private float lerpSpeed = 0.0095f;
```

Then, in the void Update() statement, add in this line of code:
```.cs
if (healthSlider.value != easeHealthSlider.value)
{
    easeHealthSlider.value = Mathf.Lerp(easeHealthSlider.value, health, lerpSpeed);
}
```

What this does, is that it creates the delay in HP loss when taking damage. My brighter red bar (Health Bar) will decrease first, with the yellow health bar (Ease Health Bar) being shortly after, this is what makes the health system function like dark souls since theirs has the same mechanic.

17. Now back into Unity, select mainHealthBar and add in the Ease Health Slider object to the Ease Health Bar variable in the script component that is inside the mainHealthBar object. Make sure that Ease Health Bar is above Health Bar so that the main brighter red displayer on top of both the yellow and the darker red HP bars. 

![image](https://github.com/user-attachments/assets/a77940e8-3122-4097-9bd4-e0946c73f03a)

And yout script component should look like this:

![image](https://github.com/user-attachments/assets/906f4ac9-7c35-461a-9b09-e545ad9f0deb)

### Once that is all complete, it's time to test

I added in this line of script in the health script, inside the void Update () statement:
```.cs
if (Input.GetKeyDown(KeyCode.Space))
{
    takeDamage(10);
}
```

And now this is what the health bar looks like when taking damage. 


https://github.com/user-attachments/assets/7d1a378c-2c72-486d-aa36-30fce0210450


