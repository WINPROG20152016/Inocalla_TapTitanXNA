using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TapTitanXNA_RadjGymsonInocalla.TapTitanXNA_RadjGymsonInocalla;

namespace TapTitanXNA_RadjGymsonInocalla
{
    public class Level
    {

        public static int windowWidth = 400;
        public static int windowHeight = 500;

        #region Properties
        ContentManager content;

        Texture2D background;

        public MouseState oldMouseState;
        public MouseState mouseState;

        bool mpressed, prev_mpressed = false;
        int mouseX, mouseY;

        Hero hero;

        Button playButton;
        Button attackButton;

        SpriteFont damageStringFont;
        int damageNumber;

        #endregion

        public Level(ContentManager content)
        {
            this.content = content;
            hero = new Hero(content, this);
            //hero1 = new Hero1(content, this);
        }

        public void LoadContent()
        {
            background = content.Load<Texture2D>("HeroSprite/bg");
            damageStringFont = content.Load<SpriteFont>("Font");

            playButton = new Button(content, "Button/button_play", Vector2.Zero);
            attackButton = new Button(content, "Button/button_attack", new Vector2(125,40));
           
            hero.LoadContent();
        }

        public void Update(GameTime gameTime)
        {
            mouseState = Mouse.GetState();

            mouseX = mouseState.X;
            mouseY = mouseState.Y;

            prev_mpressed = mpressed;
            mpressed = mouseState.LeftButton == ButtonState.Pressed;

            hero.Update(gameTime);

            oldMouseState = mouseState;

            if (attackButton.Update(gameTime, mouseX, mouseY,
                mpressed, prev_mpressed))
            {
                damageNumber += 1;
            }

        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, Vector2.Zero, null, Color.Pink, 0.0f, Vector2.Zero, 1.0f, SpriteEffects.None, 0.4f);
            hero.Draw(gameTime, spriteBatch);

            spriteBatch.DrawString(damageStringFont, damageNumber + "Damage", Vector2.Zero, Color.Pink);
            attackButton.Draw(gameTime, spriteBatch);
        }
    }
}