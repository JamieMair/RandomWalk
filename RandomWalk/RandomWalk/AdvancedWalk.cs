using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWalk
{
    public partial class AdvancedWalk : Form
    {
        PixelGrid Grid;
        SimSettings settings = new SimSettings();
        private int Iterations = 1000;
        private string Path = "";
        private int Images = 1;
        private int FrameStep = 1;
        public AdvancedWalk()
        {
            InitializeComponent();
            settings.IterationsPerUpdate = 1;
            settings.StartWithBlue = true;
            settings.TickInterval = 50;
            
            //TODO: Add video rendering
        }
        private void ValidateGrid()
        {
            int gridsize;
            if (int.TryParse(tb_GridSize.Text, out gridsize))
            {
                if (gridsize < 0)
                {
                    MessageBox.Show("The grid size must be a positive integer value.");
                }
                else
                {
                    settings.GridSize = gridsize;
                }
            }
            else
            {
                MessageBox.Show("The grid size must be an integer.");
            }
        }
        private void ValidateSpawnRate()
        {
            double spawnrate;
            if (double.TryParse(tb_SpawnRate.Text, out spawnrate))
            {
                if (spawnrate < 0)
                {
                    MessageBox.Show("The spawn rate must be a positive value.");
                }
                else
                {
                    settings.SpawnRate = spawnrate;
                }
            }
            else
            {
                MessageBox.Show("The spawn rate must be a numerical value.");
            }
        }
        private void ValidateDensity()
        {
            double density;
            if (double.TryParse(tb_Density.Text, out density))
            {
                if (density < 0)
                {
                    MessageBox.Show("The density must be a positive value.");
                }
                else
                {
                    settings.ParticleProbability = density;
                }
            }
            else
            {
                MessageBox.Show("The density must be a numerical value.");
            }
        }
        private void ValidateIterations()
        {
            int iterations;
            if (int.TryParse(tb_Interations.Text, out iterations))
            {
                if (iterations < 0)
                {
                    MessageBox.Show("The amount of iterations must be above 0.");
                }
                else
                {
                    this.Iterations = iterations;
                }
            }
            else
            {
                MessageBox.Show("You must have a numerical value for the amount of interations.");
            }
        }
        private void ValidatePixelSize()
        {
            int pixelSize;
            if (int.TryParse(tb_PixelSize.Text, out pixelSize))
            {
                if (pixelSize < 0)
                {
                    MessageBox.Show("The pixel size must be above 0.");
                }
                else
                {
                    settings.PixelSize = pixelSize;
                }
            }
            else
            {
                MessageBox.Show("You must have a numerical value for the pixel size.");
            }
        }
        private void ValidateImages()
        {
            int images;
            if (int.TryParse(tb_Images.Text, out images))
            {
                if (images < 0)
                {
                    MessageBox.Show("The number of images must be above 0.");
                }
                else
                {
                    Images = images;
                }
            }
            else
            {
                MessageBox.Show("The number of images must be a positive integer.");
            }
        }
        private void ValidateFrameStep()
        {
            int framestep;
            if (int.TryParse(tb_FrameStep.Text, out framestep))
            {
                if (framestep < 0)
                {
                    MessageBox.Show("The frame step should be a positive value.");
                }
                else
                {
                    FrameStep = framestep;
                }
            }
            else
            {
                MessageBox.Show("The frame step should be an integer value.");
            }
        }
        private void ValidatePath()
        {
            if (tb_FolderName.Text.Contains(':'))
                MessageBox.Show("Folder path cannot contain a ':'.");
            else if (tb_FolderName.Text.Contains('/'))
                MessageBox.Show("Folder path cannot contain a '/'.");
            else
            {
                Path = tb_FolderName.Text;
            }
        }
        private void GetSettings()
        {
            ValidateGrid();
            ValidateSpawnRate();
            ValidatePixelSize();
            ValidateIterations();
            ValidateDensity();
            ValidateImages();
            ValidateFrameStep();
            ValidatePath();
            settings.StartWithBlue = !cb_RandomWalk.Checked;
        }
        private void SetGrid()
        {
            Grid = new PixelGrid(settings);
        }

        private async void btn_Image_Click(object sender, EventArgs e)
        {
            GetSettings();
            btn_Image.Enabled = false;
            btn_CreateFrames.Enabled = false;
            progressBar.Visible = true;
            
            var progress = new Progress<int>(percent =>
            {
                progressBar.PerformStep();
            });

            await Task.Run(() => MakeImage(progress));
            
            progressBar.Visible = false;
            btn_Image.Enabled = true;
            btn_CreateFrames.Enabled = true;
        }
        private async void btn_CreateFrames_Click(object sender, EventArgs e)
        {
            GetSettings();
            btn_CreateFrames.Enabled = false;
            btn_Image.Enabled = false;

            progressBar.Visible = true;
            progressBar.Value = 0;
            var progress = new Progress<int>(percent =>
            {
                    progressBar.Value = percent;
                    progressBar.Invalidate();
            });
            await Task.Run(() => MakeFrames(progress));
            
            progressBar.Visible = false;

            btn_Image.Enabled = true;
            btn_CreateFrames.Enabled = true;
            

        }
        private void MakeImage(IProgress<int> progress)
        {
            for (int i = 0; i < Images; i++)
            {
                SetGrid();
                progressBar.Value = 0;
                PerformSimulation(progress);
                CreateImage(i + 1);
            }
        }
        private void MakeFrames(IProgress<int> progress)
        {
            SetGrid();
            string path = Environment.CurrentDirectory + "/" + Path;
            Directory.CreateDirectory(path);
            
            for (int i = 0; i < Math.Ceiling((double)Iterations/(double)FrameStep); i++)
            {
                PerformPartSimulation(progress);
                CreateImage(path + $"/{i+1}.bmp");
                progress.Report((int)((double)FrameStep / (double)Iterations * 100.0 * i));
            }

            if (StitchVideo(path, (int)Math.Ceiling((double)Iterations / (double)FrameStep))) //Successful
            {
                //Delete all the images

                for (int i = 0; i < Math.Ceiling((double)Iterations / (double)FrameStep); i++)
                {
                    File.Delete(path + $"/{i + 1}.bmp");
                }
            }
            Process.Start(path);
        }
        private void PerformPartSimulation(IProgress<int> progress)
        {
            for (int i = 0; i < FrameStep; i++)
            {
                Grid.UpdateGrid();
            }
        }
        private void PerformSimulation(IProgress<int> progress)
        {
            int lastI = 0;
            int onePercent = Iterations / 100;
            for (int i = 0; i < Iterations; i++)
            {
                Grid.UpdateGrid();
                if ((i - lastI) >= onePercent)
                {
                    lastI = i;
                    progress.Report(i);
                }
            }
        }
        private void CreateImage(int index = 0)
        {
            Bitmap image = new Bitmap(settings.GridSize * settings.PixelSize, settings.GridSize * settings.PixelSize);

            for (int x = 0; x < settings.GridSize; x++)
            {
                for (int y = 0; y < settings.GridSize; y++)
                {
                    Color colour;
                    #region Get Colour
                    if (Grid.grid[x, y] == -1)
                        colour = pb_FixedParticle.BackColor;
                    else if (Grid.grid[x, y] == 0)
                        colour = pb_Background.BackColor;
                    else
                    {
                        if (cb_Fractal.Checked)
                            colour = pb_Background.BackColor;
                        else
                            colour = pb_FreeParticle.BackColor;
                    }

                    #endregion
                    #region Set Pixel
                    if (settings.PixelSize == 1)
                    {
                        image.SetPixel(x, y, colour);
                    }
                    else
                    {
                        for (int u = 0; u < settings.PixelSize; u++)
                        {
                            for (int v = 0; v < settings.PixelSize; v++)
                            {
                                image.SetPixel(x*settings.PixelSize+u, y*settings.PixelSize+v, colour);
                            }
                        }
                    }
                    #endregion
                }
            }
            string path;
            if (Images == 1)
            {
                path = Environment.CurrentDirectory + $"\\{DateTime.Now.ToString().Replace('/', '-').Replace(':', '-')}.bmp";

            }
            else
            {
                path = Environment.CurrentDirectory + 
                    $"\\{DateTime.Now.Date.ToShortDateString().Replace('/', '-').Replace(':', '-')}" +
            $"\\{DateTime.Now.ToString().Replace('/', '-').Replace(':', '-')}" + $"_{index}.bmp";
                if (!Directory.Exists(Environment.CurrentDirectory +
                   $"\\{DateTime.Now.Date.ToShortDateString().Replace('/', '-').Replace(':', '-')}"))
                {
                    Directory.CreateDirectory(path = Environment.CurrentDirectory +
                        $"\\{DateTime.Now.Date.ToShortDateString().Replace('/', '-').Replace(':', '-')}");
                }
            }
           
            image.Save(path);
            image.Dispose();
            if (Images == 1)
            {
                Process.Start(path);
            }
        }
        private void CreateImage(string path)
        {
            Bitmap image = new Bitmap(settings.GridSize * settings.PixelSize, settings.GridSize * settings.PixelSize);

            for (int x = 0; x < settings.GridSize; x++)
            {
                for (int y = 0; y < settings.GridSize; y++)
                {
                    Color colour;
                    #region Get Colour
                    if (Grid.grid[x, y] == -1)
                        colour = pb_FixedParticle.BackColor;
                    else if (Grid.grid[x,y] == 0)
                        colour = pb_Background.BackColor;
                    else
                    {
                        if (cb_Fractal.Checked)
                            colour = pb_Background.BackColor;
                        else
                            colour = pb_FreeParticle.BackColor;
                    }
                    
                    #endregion
                    #region Set Pixel
                    if (settings.PixelSize == 1)
                    {
                        image.SetPixel(x, y, colour);
                    }
                    else
                    {
                        for (int u = 0; u < settings.PixelSize; u++)
                        {
                            for (int v = 0; v < settings.PixelSize; v++)
                            {
                                image.SetPixel(x * settings.PixelSize + u, y * settings.PixelSize + v, colour);
                            }
                        }
                    }
                    #endregion
                }
            }

            image.Save(path);

            image.Dispose();
        }

        private void btn_BgEdit_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = pb_Background.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pb_Background.BackColor = dialog.Color;
            }
        }

        private void btn_FpEdit_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = pb_FreeParticle.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pb_FreeParticle.BackColor = dialog.Color;
            }
        }

        private void btn_FixPEdit_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = pb_FixedParticle.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pb_FixedParticle.BackColor = dialog.Color;
            }
        }

        private bool StitchVideo(string folderpath, int numberofimages)
        {
            //Doesnt work :(
            return false;
            //try
            //{
            //    MLApp.MLApp app = new MLApp.MLApp();
            //    app.Execute($"cd '{Environment.CurrentDirectory+@"\MatlabCode"}'");
            //    object res = null;
            //    app.Feval("createmoviefrombmp", 0, out res, folderpath, "movie", "Uncompressed Avi", ".bmp", 60, numberofimages);
            //    app.Quit();
                

            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Could not stich the video together. \n" + ex.Message);
            //    return false;
            //}



        }
        
    }
}
