using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWalk
{
    [Serializable]
    public class SimSettings
    {
        #region Settings
        public double ParticleProbability { get; set; } = 0.05;
        public double SpawnRate { get; set; } = 0.4;
        public bool StartWithBlue { get; set; } = true;
        public int TickInterval { get; set; } = 50;
        public int IterationsPerUpdate { get; set; } = 1;
        public int GridSize { get; set; } = 300;
        public int PixelSize { get; set; } = 1;
        #endregion
    }
}
