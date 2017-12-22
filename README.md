# RandomWalk
A project to simulate fractal formation using a random walk in C#.

This was just a quick short project aimed at quickly getting some simulations of DLA (Diffusion-limited aggregation), you can combine the frames in MATLAB as I wasn't able to implement a method to stitch a load of frames into a video with C# (I'm sure there's a way to do it) but instead I just used a MATLAB script. Current bugs that I've noticed at the moment is that the advanced menu for creating simulations behind the scenes and just giving you the result will crash if you try to create an image AFTER you've clicked one of the buttons already, something to do with the progress bar not resetting properly. It'll most likely be an easy fix but I am probably not going to update this project. Feel free to use any of this code in any of your project if you provide a link to this repository.

NOTE: If you only care about the algorithm that creates the simulation, look in the PixelGrid.cs file and the UpdateGrid method.
