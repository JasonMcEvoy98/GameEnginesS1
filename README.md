# GameEnginesS1

My plan for this assignment is to create an automatic generating terain the camera will travel through as the music plays and reacts to it as the song progreesses. This will be a two feature project the first is getting the terrain to auto create and dissapear once out of view to reduce rendering on the system and project to increase efficiency. The second feature of music fluxing the terrain or objects in the project will be the harder as it may interfere with the terrain. I took inspiartion from two different vidoes; the first being from the old playstation 3 audio visualizer forming a terrain and travelling it. The second is the pulsating items or objects to the beat or RBM of the song being played. 

Other resources ill be using are the unity tutorials and the Github Resources
https://learn.unity.com/ - Unity Learn
https://resources.github.com/ github Resources


https://www.youtube.com/watch?v=aLusQuZ_mr8  - Playstation Audio Visualizer
https://www.youtube.com/watch?v=3JgUH7SuoBY  - Pulsating Cube Matrix





FINAL SUBMISSION 18TH DECEMBER 2019

My assignment consists of three different uses of effects and code to creat its current form; Perlin Noise, Particle systems and an Audio Spectrum. I used all three of these items to create a centre ring pulsating to the audio of the music and light flickering background, a floating moving world made up of Perlin Noise randomizing each time the build is played, while all of this is happening timed particles with different effects and lighting. All of this is backed to the song Jungle by Tash Sultana ( all rights to the artist and company producing ) ( https://www.youtube.com/watch?v=CHxbKBvogSg ) reflecting the song in its harmony throught the artists voice and instrumental. My visula creation i reached for was a space rider close to a planets surface experince the stars at light speed simultaneously.

The project works using the aboved mention items in scripts and a particle system put in place. The ring works through the cameras eyes and only spawns upon play. this was done by using 2 arrays holding the max and min values of the songs pitch in tone and contained them, i also then used a deltatime with a visualscale to smooten out any sikes in the song to give it a nicer flow rather than shrap spikes and finallly i used quaternion to manipulate the spikes to go outwards from the circles spawn location. The background also used in this script used the same pitch max and min dbValues to change colours upon the noise levels of the song, low pitch created a bright blue while high pitched a deep blue/navy night sky. I created the ground (or planet) using the terrian generator script to set the dimensions of the terrian and implement procedural generation through perlin noise which would give me a different and random "world" spawning and ground each play through of the song givening a sloghtly difference experince each playthrough, i then used the same script to roll the surface towards the X axis and the camera to give it a moving sensation of the camera or "user" moving at high speeds. Finally i installed and creates particles systems that were timed to certian parts within the song to reflect its ever changing mood, bubbles for embers and voice notes while stars to create the sensation of speeding further along the planets surface. 

This Project is made up of both things learn in class and my own coding knowledge with use of some unity forums when i was stuck on certain bugs. Class references includes Perlin Noise class (Week 10) and Audio (Week 9). Unity forums helped me create the spectrum with bugs and scripting problems ( https://docs.unity3d.com/ScriptReference/AudioSource.GetSpectrumData.html & https://forum.unity.com/threads/audio-visualization-tutorial-unity-c-q-a.432461/ ). A major component i knew all too well was the particle system so i used it in conjunction with audio visualizer. 

What i am most proud of in this project is the overall timed experince that comes from the song and the scripted effects and events creating a beutiful blend of immersion and vision into whatever the viewer holds to the visual representation of the song, but i am most proud of the spectrum ring with took me some time to acheive as it went through so many stages from it working in a line to converting to a circle then conflicts with the circle hitting each other. But seeing it run for the first time with no bugs or problem filled me with so much pride andf joy.

To run the project simply press play and have the settings Maximise on Play and make sure youa re unmuted to enjoy.
Below is a YouTube link to the project in action:
https://youtu.be/0UZrhHvU91g
