using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EndlessRunner
{
    public class Obstacles
    {
        public Image obstacleImg { get; set; }
        public int obstacleSpeed { get; set; }

        public Obstacles()
        {

        }
        public Obstacles(Image _obstacleImg,int _obstacleSpeed)
        {
            obstacleImg = _obstacleImg;
            obstacleSpeed = _obstacleSpeed;
        }
    }
}
