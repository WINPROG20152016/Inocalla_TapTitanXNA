using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TapTitanXNA_RadjGymsonInocalla
{
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
        public class Hero1
        {
            #region Properties
            Vector2 playerPosition2;
            Texture2D player2;
            ContentManager content;
            Level level;

            Animation idleAnimation2;
            AnimationPlayer spritePlayer2;
            #endregion

            public Hero1(ContentManager content, Level level)
            {
                this.content = content;
                this.level = level;
            }
            public void LoadContent()
            {

                player2 = content.Load<Texture2D>("HeroSprite/support");

                idleAnimation2 = new Animation(player2, 0.1f, true, 3);

                int positionX2 = (Level.windowWidth / 2) - (player2.Width / 4);
                int positionY2 = (Level.windowHeight / 2) - (player2.Height / 4);
                playerPosition2 = new Vector2((float)positionX2, (float)positionY2);

                spritePlayer2.PlayAnimation(idleAnimation2);
            }

            public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
            {
                //spriteBatch.Draw(player, playerPosition, null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.0f);
                playerPosition2 = new Vector2(200, 150);
                spritePlayer2.Draw(gameTime, spriteBatch, playerPosition2, SpriteEffects.None);
            }
        }
    }
}
