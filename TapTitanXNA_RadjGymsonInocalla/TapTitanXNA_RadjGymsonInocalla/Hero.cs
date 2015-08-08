using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using TapTitanXNA_RadjGymsonInocalla;

namespace TapTitanXNA_RadjGymsonInocalla
{
    public class Hero
    {
        #region Properties
        Vector2 playerPosition;
        Texture2D player;
        ContentManager content;
        Level level;

        Animation idleAnimation;
        AnimationPlayer spritePlayer;
        #endregion

        public Hero(ContentManager content, Level level)
        {
            this.content = content;
            this.level = level;
        }
        public void LoadContent()
        {

            player = content.Load<Texture2D>("HeroSprite/hero");

            idleAnimation = new Animation(player, 0.1f, true, 16);

            int positionX = (Level.windowWidth / 2) - (player.Width / 4);
            int positionY = (Level.windowHeight / 2) - (player.Height / 4);
            playerPosition = new Vector2((float)positionX, (float)positionY);

            spritePlayer.PlayAnimation(idleAnimation);
        }

        public void Update(GameTime gameTime)
        {
            if (level.mouseState.LeftButton == ButtonState.Pressed && level.oldMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                player = content.Load<Texture2D>("HeroSprite/hero22");

                idleAnimation = new Animation(player, 0.1f, false, 15);

                int positionX = (Level.windowWidth / 2) - (player.Width / 4);
                int positionY = (Level.windowHeight / 2) - (player.Height / 4);
                playerPosition = new Vector2((float)positionX, (float)positionY);

                spritePlayer.PlayAnimation(idleAnimation);
            }
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(player, playerPosition, null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.0f);
            playerPosition = new Vector2(200, 300);;
            spritePlayer.Draw(gameTime, spriteBatch, playerPosition, SpriteEffects.None);
        }
    }
}