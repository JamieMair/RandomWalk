using System;

namespace RandomWalk
{
    public class PixelGrid
    {
        #region Properties
        /// <summary>
        /// A grid of integers where a value of -1 represents a static particle and any other value represents the amount of free particles.
        /// </summary>
        public int[,] grid;
        /// <summary>
        /// A placeholder for grid during the new update.
        /// </summary>
        private int[,] newGrid;
        private Random rand = new Random();
        public SimSettings settings;


        /// <summary>
        /// The maximum amount of particles allowed before spawning new particles is blocked.
        /// </summary>
        private int maxParticles = 25000000;
        #endregion
        #region Constructor
        public PixelGrid(SimSettings settings)
        {
            //Gets the initial settings for the simulation.
            this.settings = settings;
            //Create an empty grid.
            grid = new int[settings.GridSize, settings.GridSize];
            newGrid = new int[settings.GridSize, settings.GridSize];
            maxParticles = settings.GridSize * settings.GridSize*10;
            #region Populate Grid
            if (settings.ParticleProbability != 0 && settings.StartWithBlue)
            {
                //Use the ParticleProbability as the fraction of black particles.
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    for (int y = 0; y < grid.GetLength(1); y++)
                    {
                        if (rand.Next(0, (int)(100.0 / settings.ParticleProbability)) < 100)
                        {
                            grid[x, y] = 2; // Start each position with 2 particles to speed up.
                        }
                    }
                }
            }
            #endregion
            #region Begin Formation
            int midx;
            int midy;
            if (grid.GetLength(0) % 2 == 0)
                midx = grid.GetLength(0) / 2;
            else
                midx = (grid.GetLength(0) - 1) / 2;
            if (grid.GetLength(1) % 2 == 0)
                midy = grid.GetLength(1) / 2;
            else
                midy = (grid.GetLength(1) - 1) / 2;
            if (settings.StartWithBlue) //Starts with a static center particle.
                grid[midx, midy] = -1;
            else //Or a single particle.
                grid[midx, midy] = 1;
            #endregion
        }
        #endregion
        #region Methods
        private void SpawnRandomParticle()
        {
            int xP, yP;
            //Random choice between left and right or top and bottom.
            if (rand.Next(0, 10) < 5) //Left and Right
            {
                xP = (rand.Next(0, 10) < 5 ? 0 : grid.GetLength(0) - 1);
                yP = rand.Next(0, grid.GetLength(0));
            }
            else //Top and bottom.
            {
                yP = (rand.Next(0, 10) < 5 ? 0 : grid.GetLength(0) - 1);
                xP = rand.Next(0, grid.GetLength(0));
            }

            if (grid[xP, yP] != -1) //Only add the particle if it isn't already a fixed particle.
                grid[xP, yP] += 1;
        }

        public void UpdateGrid()
        {
            newGrid = new int[GetWidth(), GetHeight()];
            #region Paste in all of the static particles into the new grid.
            for (int x = 0; x < GetWidth(); x++)
            {
                for (int y = 0; y < GetHeight(); y++)
                {
                    if (grid[x, y] == -1)
                        newGrid[x, y] = -1;
                }

            }
            #endregion

            int countToStatic = 0;
            int particleCount = 0;
            #region Move all the particles

            //Loop through all the x values in the grid.
            for (int x = 0; x < GetWidth(); x++)
            {
                //Loops through all the y values in the grid.
                for (int y = 0; y < GetHeight(); y++)
                {
                    //For every particle stored at a given point, create a new one
                    //in a random location in a diamond around the current point and
                    //convert the particle to a static one if necessary.
                    while (grid[x, y] > 0)
                    {
                        int[] newPoint = GetRandomPoint(x, y, GetWidth() - 1, GetHeight() - 1);
                        int xPrime = newPoint[0];
                        int yPrime = newPoint[1];
                        //If the particle is about to move into a static particle it becomes a static particle.
                        if (grid[xPrime, yPrime] == -1)
                        {
                            newGrid[x, y] = -1;
                            countToStatic++;
                        }
                        else //Otherwise just move the particle into that space.
                        {
                            newGrid[xPrime, yPrime] += 1;
                        }

                        //Remove that particle from the ones to update.
                        grid[x, y] -= 1;
                        particleCount++;
                    }
                }
            }
            #endregion

            #region Spawn new particles
            //Spawn a new particle for each one which is made static.
            if (particleCount < maxParticles) //Only spawn particles if you dont have too many already.
            {
                while (countToStatic != 0)
                {
                    int[] newPoint = GetRandomEdgePoint(GetWidth() - 1, GetHeight() - 1);
                    if (grid[newPoint[0], newPoint[1]] != -1)
                        grid[newPoint[0], newPoint[1]]++;

                    countToStatic--;
                }

                //Spawn a new particle based on the spawn rate.
                for (int i = 0; i < settings.SpawnRate; i++)
                {
                    SpawnRandomParticle();
                }
                if (settings.SpawnRate % 1 != 0)
                {
                    const int range = 1000000;
                    if (rand.Next(1, range + 1) <= (settings.SpawnRate % 1) * range)
                        SpawnRandomParticle();
                }
            }
            #endregion
            grid = newGrid;
        }
        /// <summary>
        /// Gets a random point somewhere along the edge of a grid.
        /// </summary>
        /// <param name="maxx">The maximum value that x can take in the grid.</param>
        /// <param name="maxy">The maximum value that y can take in the grid.</param>
        /// <returns>Returns a length 2 array with the x as the 1st term and the y as the 2nd term.</returns>
        public int[] GetRandomEdgePoint(int maxx, int maxy)
        {
            UInt16 r = (UInt16)rand.Next(1, 5 + 1);
            int xPrime = 0;
            int yPrime = 0;
            switch (r)
            {
                case 1: //Left
                    xPrime = 0;
                    yPrime = rand.Next(0,maxy + 1);
                    break;
                case 2: //Right
                    xPrime = maxx;
                    yPrime = rand.Next(0, maxy + 1);
                    break;
                case 3: //Top
                    yPrime = 0;
                    xPrime = rand.Next(0, maxx + 1);
                    break;
                case 4: //Bottom
                    yPrime = maxy;
                    xPrime = rand.Next(0, maxx + 1);
                    break;
            }
            return new int[] { xPrime, yPrime };
        }
        /// <summary>
        /// Gets a random point for a particle at x,y to move to, restricted to a square grid around x,y.
        /// </summary>
        /// <param name="x">The current x in the grid.</param>
        /// <param name="y">The current y in the grid.</param>
        /// <param name="maxx">The maximum value that x can take.</param>
        /// <param name="maxy">The maximum value that y can take.</param>
        /// <returns>Returns a length 2 array with the x as the 1st term and the y as the 2nd term.</returns>
        public int[] GetRandomPoint(int x, int y, int maxx, int maxy)
        {
            //Gets a random number from 1 to 8 to specify direction.
            UInt16 r = (UInt16)rand.Next(1, 8+1);
            int xPrime = x;
            int yPrime = y;
            switch (r)
            {
                case 1: //Left
                    xPrime = Math.Max(0, xPrime-1);
                    break;
                case 2: //Right
                    xPrime = Math.Min(maxx, xPrime + 1);
                    break;
                case 3: //Down
                    yPrime = Math.Min(maxy, yPrime + 1);
                    break;
                case 4: //Up
                    yPrime = Math.Max(0, yPrime - 1);
                    break;
                case 5: //Top Left
                    xPrime = Math.Max(0, xPrime - 1);
                    yPrime = Math.Max(0, yPrime - 1);
                    break;
                case 6: //Top Right
                    xPrime = Math.Min(maxx, xPrime + 1);
                    yPrime = Math.Max(0, yPrime - 1);
                    break;
                case 7: //Bottom Left
                    xPrime = Math.Max(0, xPrime - 1);
                    yPrime = Math.Min(maxy, yPrime + 1);
                    break;
                case 8: //Bottom Right
                    xPrime = Math.Min(maxx, xPrime + 1);
                    yPrime = Math.Min(maxy, yPrime + 1);
                    break;
            }
            return new int[] { xPrime, yPrime };
        }

        /// <summary>
        /// Gets the width of the current grid.
        /// </summary>
        public int GetWidth()
        {
            return grid.GetLength(0);
        }
        /// <summary>
        /// Gets the height of the current grid.
        /// </summary>
        public int GetHeight()
        {
            return grid.GetLength(1);
        }
        /// <summary>
        /// Updates the grid multiple times in a row.
        /// </summary>
        /// <param name="count">The amount of times you want to update the grid.</param>
        public void ManyUpdates(int count)
        {
            for (int i = 0; i < count; i++)
            {
                UpdateGrid();
            }
        }
        #endregion

        #region Legacy Code
        //public void UpdateGrid1()
        //{
        //    //Loops the update multiple times depending on the amount of iterations. (speeds up formation)
        //    for (int i = 0; i < settings.IterationsPerUpdate; i++)
        //    {
        //        #region Spawn Particles
        //        if (settings.SpawnRate != 0)
        //        {
        //            for (int u = 0; u < Math.Floor(settings.SpawnRate); u++)
        //            {
        //                SpawnRandomParticle();
        //            }
        //            double modSpawnRate = settings.SpawnRate % 1;
        //            if (modSpawnRate != 0)
        //            {
        //                if (rand.Next(0, (int)(100.0 / modSpawnRate)) < 100)
        //                {
        //                    SpawnRandomParticle();
        //                }
        //            }
        //        }
        //        #endregion
        //        #region Move Free Particles
        //        for (int x = 0; x < grid.GetLength(0); x++)
        //        {
        //            for (int y = 0; y < grid.GetLength(1); y++)
        //            {
        //                //Checks whether there is a black particle to be moved.
        //                if (grid[x, y] == 1)
        //                {
        //                    int xP;
        //                    int yP;


        //                    //Makes sure to only check whether the particle is surrounded once.
        //                    bool notSurrounded = true;
        //                    do
        //                    {
        //                        #region Get Other Position
        //                        xP = x + rand.Next(-1, 2);
        //                        yP = y + rand.Next(-1, 2);
        //                        #region Make sure it can leave
        //                        if (xP < 0)
        //                        {
        //                            grid[x, y] = 0;
        //                            break;
        //                        }
        //                        if (yP < 0)
        //                        {
        //                            grid[x, y] = 0;
        //                            break;
        //                        }
        //                        if (yP >= grid.GetLength(1))
        //                        {
        //                            grid[x, y] = 0;
        //                            break;
        //                        }
        //                        if (xP >= grid.GetLength(0))
        //                        {
        //                            grid[x, y] = 0;
        //                            break;
        //                        }
        //                        #endregion

        //                        if (grid[xP, yP] == 2)
        //                        {
        //                            grid[x, y] = 2;
        //                            break;
        //                        }
        //                        if (notSurrounded)
        //                        {
        //                            if (CheckAdjecentTiles(x, y))
        //                            {
        //                                break;
        //                            }
        //                            else
        //                            {
        //                                notSurrounded = false;
        //                            }
        //                        }
        //                        #endregion

        //                    }
        //                    while (grid[xP, yP] != 0);

        //                    #region Update the grid with new values
        //                    if (grid[x, y] != 2 && grid[x, y] != 0)
        //                    {
        //                        //Make the previous space empty.
        //                        grid[x, y] = 0;
        //                        //Make the next space a placeholder of 3 so it does not get moved again.
        //                        grid[xP, yP] = 3;
        //                    }
        //                    #endregion
        //                }
        //            }
        //        }
        //        #region Reset Placeholders
        //        //Reset all of the 3 placeholders to 1.
        //        for (int x = 0; x < grid.GetLength(0); x++)
        //        {
        //            for (int y = 0; y < grid.GetLength(1); y++)
        //            {
        //                if (grid[x, y] == 3)
        //                    grid[x, y] = 1;
        //            }
        //        }
        //        #endregion
        //        #endregion
        //    }
        //}


        //private bool CheckAdjecentTiles(int x, int y)
        //{
        //    //Sets up a counter to count how many particles are around the x,y particle.
        //    int count = 0;
        //    //Gets the minimum row value.
        //    int imin = (x == 0 ? 0 : -1);
        //    //Gets the maximum row value.
        //    int imax = (x == grid.GetLength(0) - 1 ? 0 : 1);
        //    //Gets the minimum column value.
        //    int jmin = (y == 0 ? 0 : -1);
        //    //Gets the maximum column value.
        //    int jmax = (y == grid.GetLength(1) - 1 ? 0 : 1);
        //    //Loops through each surrounding particle, ignoring the x,y particle.
        //    for (int i = imin; i <= imax; i++)
        //    {
        //        for (int j = jmin; j <= jmax; j++)
        //        {
        //            if (i != 0 || j != 0)
        //            {
        //                int xp = x + i;
        //                int yp = y + j;
        //                if (grid[xp, yp] == 1 || grid[xp, yp] == 3) //Adds to the count if there is a particle.
        //                    count++;
        //            }
        //        }
        //    }
        //    //If the count matches the maximum possible particles then it is surrounded.
        //    if (count == (imax - imin + 1) * (jmax - jmin + 1) - 1)
        //        return true;
        //    else
        //        return false;
        //}
        #endregion
    }
}
