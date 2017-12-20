using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandomWalk
{
    public partial class RandomWalk : Form
    {
        Graphics g = null;
        private PixelGrid Grid;
        private Random rand = new Random();
        private SimSettings settings = new SimSettings();
        public RandomWalk()
        {
            InitializeComponent();
            //TODO Load in settings.
            OutSettings();
            BeginAnimation();

        }

        #region Property Validation
        private void ValidateInterval()
        {
            int interval;
            if (int.TryParse(tb_Interval.Text, out interval))
            {
                if (interval < 0)
                {
                    MessageBox.Show("The interval must be a positive value.");
                }
                else
                {
                    settings.TickInterval = interval;
                    mainTimer.Interval = interval;
                }
            }
            else
            {
                MessageBox.Show("The interval must be an integer value.");
            }

        }
        private void ValidateUpdate()
        {
            int update;
            if (int.TryParse(tb_Updates.Text, out update))
            {
                if (update < 0)
                {
                    MessageBox.Show("The updates per tick must be a positive value.");
                }
                else
                {
                    settings.IterationsPerUpdate = update;
                }
            }
            else
            {
                MessageBox.Show("The amount of updates must be an integer value.");
            }
        }
        #endregion
        private bool ReadChanges()
        {
            int maxGridSize = Math.Min(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width,
                System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height)-100;
            int gridsize;
            double density;
            int updates;
            int tickinterval;
            double probSpawn;
            if (int.TryParse(tb_gridsize.Text, out gridsize) && 
                double.TryParse(tb_spawn.Text, out probSpawn) &&
                int.TryParse(tb_Interval.Text, out tickinterval) &&
                double.TryParse(tb_Density.Text, out density) &&
                int.TryParse(tb_Updates.Text, out updates))
            {
                #region Grid Size
                if (gridsize > 0 && gridsize <= maxGridSize)
                {
                    settings.GridSize = gridsize;
                    settings.PixelSize = (int)Math.Floor(maxGridSize / (double)gridsize);
                }
                else
                {
                    MessageBox.Show($"Grid size must be between 1 and {maxGridSize}.");
                    return false;
                }
                #endregion
                #region Spawn Rate
                if (probSpawn >= 0)
                {
                    settings.SpawnRate = probSpawn;
                }
                else
                {
                    MessageBox.Show("Spawn Rate must be positive.");
                    return false;
                }
                #endregion
                #region Updates
                if (updates > 0)
                {
                    settings.IterationsPerUpdate = updates;
                }
                else
                {
                    MessageBox.Show("The amount of updates per tick must be greater than 0.");
                    return false;
                }
                #endregion
                #region Tick Interval
                if (tickinterval > 0)
                {
                    settings.TickInterval = tickinterval;
                }
                else
                {
                    MessageBox.Show("The tick interval must be greater than 0.");
                    return false;
                }
                #endregion
                #region Density
                if (density >= 0 && density <= 1)
                {
                    settings.ParticleProbability = density;
                }
                else
                {
                    MessageBox.Show("The density must be between 0 and 1.");
                }
                #endregion

            }
            else
            {
                MessageBox.Show("Some of your inputs are not valid.");
                return false;
            }

            return true;
        }
        private void OutSettings()
        {
            tb_gridsize.Text = settings.GridSize.ToString();
            tb_spawn.Text = settings.SpawnRate.ToString();
            tb_Density.Text = settings.ParticleProbability.ToString();
            tb_Interval.Text = settings.TickInterval.ToString();
            tb_Updates.Text = settings.IterationsPerUpdate.ToString();
        }
        private void BeginAnimation()
        {
            if (ReadChanges())
            {
                canvas.Width = settings.GridSize * settings.PixelSize;
                canvas.Height = settings.GridSize * settings.PixelSize;
                mainTimer.Interval = settings.TickInterval;
                Size = new Size(settings.GridSize * settings.PixelSize, settings.GridSize * settings.PixelSize + 30);
                Grid = new PixelGrid(settings);
               
                mainTimer.Stop();

                canvas.Invalidate();
                this.Invalidate();
                btn_Pause.Visible = false;
                btn_Play.Visible = true;
                OutSettings();
                mainTimer.Stop();
                
            }
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int x = 0; x < Grid.grid.GetLength(0); x++)
            {
                for (int y = 0; y < Grid.grid.GetLength(0); y++)
                {
                    if (Grid.grid[x,y] > 0)
                        DrawPixel((int)(x * settings.PixelSize), (int)(y * settings.PixelSize), (int)settings.PixelSize, Brushes.Black);
                    else if (Grid.grid[x,y] == -1)
                        DrawPixel((int)(x * settings.PixelSize), (int)(y * settings.PixelSize), (int)settings.PixelSize, Brushes.Blue);
                    
                }
            }
        }

        private void DrawPixel(int x, int y, int size, Brush colour)
        {
            g.FillRectangle(colour, new Rectangle(x, y, size, size));
            
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            #region UpdateClicks
            if (isMouseDown)
            {
                
            }

            #endregion
            Grid.UpdateGrid();
            canvas.Invalidate();

        }
        
        
        
        bool isMouseDown = false;
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            button = e.Button;

            int posx = Math.Min(Math.Max(e.X / settings.PixelSize, 0), settings.GridSize-1);
            int posy = Math.Min(Math.Max(e.Y / settings.PixelSize, 0), settings.GridSize-1);

            if (button == MouseButtons.Left)
            {
                Grid.grid[posx, posy] += 1;
            }
            else if (button == MouseButtons.Right)
            {
                Grid.grid[posx, posy] = -1;
            }
            else if (button == MouseButtons.Middle)
            {
                Grid.grid[posx, posy] = 0;
            }
            canvas.Invalidate();

        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == button)
                isMouseDown = false;
        }
        private Point cursorPosition = new Point(0, 0);
        MouseButtons button = MouseButtons.Left;
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int posx = Math.Min(Math.Max(e.X / settings.PixelSize, 0), settings.GridSize-1);
                int posy = Math.Min(Math.Max(e.Y / settings.PixelSize, 0), settings.GridSize-1);

                if (button == MouseButtons.Left)
                {
                    Grid.grid[posx, posy] = 1;
                }
                else if (button == MouseButtons.Right)
                {
                    Grid.grid[posx, posy] = 2;
                }
                else if (button == MouseButtons.Middle)
                {
                    Grid.grid[posx, posy] = 0;
                }
                if (!mainTimer.Enabled)
                {
                    canvas.Invalidate();
                }
            }
        }


        #region Toolbar Button Clicks
        private void btn_Pause_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            btn_Play.Visible = true;
            btn_Pause.Visible = false;
        }
        private void btn_Play_click(object sender, EventArgs e)
        {
            mainTimer.Start();
            btn_Play.Visible = false;
            btn_Pause.Visible = true;
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            settings.StartWithBlue = true;
            BeginAnimation();
        }
        private void btn_RandomWalk_Click(object sender, EventArgs e)
        {
            settings.StartWithBlue = false;
            BeginAnimation();
        }
        #endregion

        #region Textboxes
        private void tb_Interval_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInterval();
            }
        }

        private void tb_Updates_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateUpdate();
            }
        }
        #endregion

        private void btn_Advanced_Click(object sender, EventArgs e)
        {
            AdvancedWalk adWalk = new AdvancedWalk();
            adWalk.Show();
        }

        
    }
}
