using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBirdDemo.Web.Models
{
    public class PipeModel
    {
        public int DistanceFromLeft { get; private set; } = 500;
        public int DistanceFromBottom { get; private set; } = new Random().Next(0, 60);
        public int Speed { get; private set; } = 2;
        public int Gap { get; private set; } = 130;

        public int GapBotton => DistanceFromBottom + 300;
        public int GapTop => GapBotton + Gap;
        public bool IsOffScreen()
        {
          return  DistanceFromLeft <= -60;

        }
        public void Move()
        {
            DistanceFromLeft -= Speed;
        }

        public bool IsCentered()
        {
            bool hasEnterdCenter = DistanceFromLeft <= (500 / 2) + (60 / 2);
            bool hasExitedCenter = DistanceFromLeft <= (500 / 2) - (60 / 2) - 60;

            return hasEnterdCenter && !hasExitedCenter;
        }
    }
}
