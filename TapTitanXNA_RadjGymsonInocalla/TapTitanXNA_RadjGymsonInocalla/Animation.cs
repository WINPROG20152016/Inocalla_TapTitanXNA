using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace TapTitanXNA_RadjGymsonInocalla
{
    public class Animation
    {
        public Texture2D texture;
        public float frametime;
        public bool isLooping;

        public int FrameCounter;

        public int FrameCount
        {
            get { return texture.Width / FrameWidth; }
        }

        public int FrameWidth { get { return texture.Width/FrameCounter; } }
        public int FrameHeight { get { return texture.Height; } }

        public Animation(Texture2D texture, float frametime, bool isLooping, int FrameCounter)
        {
            this.texture = texture;
            this.frametime = frametime;
            this.isLooping = isLooping;
            this.FrameCounter = FrameCounter;
        }
    }
}
