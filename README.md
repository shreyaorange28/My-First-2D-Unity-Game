# My-First-2D-Unity-Game
 
 I am currently learning how to create a Unity 2d platformer game from scratch. I'm working on a tile-based platformer game using the pixel adventure tile pack and following multiple tutorials listed below. Currently I've implemented 
 * a moveable sprite (a ninja frog) that can interact with the main platform
 * a camera that follows the sprite

### My Journey
1. I first began to learn how to create my platformer by following this tutorial on [How to Make a 2D Game in Unity](https://www.youtube.com/watch?v=on9nwbZngyw&list=PLPV2KyIb3jR6TFcFuzI2bB7TMNIIBpKMQ). I found it helpful to set up the project and to learn some of the basics. In following this tutorial,
   - I found my asset pack ([Pixel Adventure 1 by Pixel Frog](https://assetstore.unity.com/packages/2d/characters/pixel-adventure-1-155360)) and I learned how to add the tileset and create a tile palette. It taught me how to scale the tilemap and each of the tiles to make sure that everything fit properly.
   - I learned how to add the animations for my frog sprite and fruit objects using the Animator and adjust the speeds of the animation.
   - I learned how to add colliders and gravity to my components and adjust the gravity of the games to make my objects fall and collide into each other.
  2. I then learned how to add my sprite from the [How to Import a 2D Character Sprite Sheet and Use in a GameObject in Unity (2021) tutorial](https://www.youtube.com/watch?v=FXXc0hTWIMs) and added the idle animation as well as basic movement for the ninja frog sprite. I added the colliders and the  However, I did not add the transition between animations (ex. idle to running) when the sprite moved or fell. I added the Rigidbody 2D component to allow my sprite to fall and the Box Collider 2D to allow it to interact with the platform.
  3. I now wanted to make the camera follow the sprite as it moved so I followed the [Smooth Camera Follow in Unity tutorial](https://www.youtube.com/watch?v=ZBj3LBA2vUY) to add a script to my main camera to have it follow my ninja frog.
  4. At this point, I wanted to make the sprite swap to the running or jumping animations while moving using the Animation tab so I moved on to the [Idle, Run and Jump Animations - Platformer Unity 2D tutorial ](https://www.youtube.com/watch?v=Sg_w8hIbp4Y) In following this tutorial, I not only learned how to simplify my code from the previous tutorials by getting the components instead of inputting them as variables in Unity, but I also learned how to use the Animation tab to swap between animation depending on the player's movement using Blend Trees. I ran into some issues with detecting the ground when jumping but I found that it was due to some of the remnant Capsule Colliders of the first tutorial as well as an unchecked IsTrigger box on the correct capsule collider but a quick rewatch of the part of the video where she set up the colliders allowed me to figure it out quickly.
5. This is also the point where I decided to learn how to upload Unity projects to github. After running into some issues where the project was too big, [this tutorial](https://www.youtube.com/watch?v=qpXxcvS-g3g) taught me to remove the slashes at the beginning of the files in the git ignore and that allowed me to push my unity project to github. Here are some progress pics of my project and a video of me moving around.
![image](https://github.com/user-attachments/assets/dd72acf2-1a13-4446-bf0f-a44e5d382bf2)
<video src="https://github.com/user-attachments/assets/c4603f09-b601-465f-b9c4-108514ac7119"/>



### Next Steps
Next, I hope to add more interactable platforms (as the current ones have a lot of friction and are a bit glitchy) and a way to collect fruits as the player. I also want to add levels (probably basic ones just to keep learning how to use Unity). After that I want to focus on how to add more functionality to the sprite (ex. double jumps, wall jumps, etc.) or even learn how to add a second player.
