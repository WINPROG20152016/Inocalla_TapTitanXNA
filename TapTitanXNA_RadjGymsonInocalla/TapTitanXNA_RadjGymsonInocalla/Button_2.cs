

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace TapTitanXNA_RadjGymsonInocalla
{
    enum BState
    {
        UP,
        HOVER,
        DOWN,
        RELEASED,
    }

    public class Button
    {
        ContentManager content;
        string buttonName;
        Vector2 buttonPosition;

        Texture2D buttonTexture;
        Rectangle buttonRectangle;
        Color buttonColor;
        BState bState;
        double timer;
        double frameTime;

        public Button(ContentManager content,
                        string buttonName,
                        Vector2 buttonPosition)
        {
            this.content = content;
            this.buttonName = buttonName;
            this.buttonPosition = buttonPosition;

            LoadContent();
        }

        public void LoadContent()
        {
            buttonTexture = content.Load<Texture2D>(buttonName);
            buttonRectangle = new Rectangle(
                                (int)buttonPosition.X,
                                (int)buttonPosition.Y,
                                buttonTexture.Width,
                                buttonTexture.Height
            );
            buttonColor = Color.White;
            bState = BState.UP;
            timer = 0.0f;
        }

        public bool Update(GameTime gameTime,
            int mx, int my, bool mpressed, bool prev_mpressed)
        {
            return false;
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(buttonTexture, buttonRectangle, buttonColor);
        }

        public bool hitImage(float tx,
            float ty,
            Texture2D texture,
            int x, int y)
        {
            return(
                x >= tx &&
                x <= tx + texture.Width &&
                y >= ty &&
                y <= ty + texture.Height);
    }
        public bool hitImageAlpha(
            Rectangle rect,
            Texture2D texture, int x, int y)
        {
            return hitImageAlpha(
                0,
                0,
                texture,
                texture.Width * (x - rect.X) / rect.Width,
                texture.Height * (y - rect.Y) / rect.Height);
}
        public bool hitImageAlpha(float tx,
            float ty, Texture2D texture,
            int x, int y)
        {
            return false;
        }

