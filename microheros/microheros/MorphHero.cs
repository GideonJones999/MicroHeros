using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace microheros
{
    class MorphHero: SuperHero
    {
        //VARS
        private int counter;
        private Rectangle sourceRec;
        private int direction = 200;

        //METHODS


        public MorphHero(string name) :base(name)
        {
            //rec = new Rectangle(Position, 600, 400, 400);
            sourceRec = new Rectangle(200, 0, 200, 200);
            counter = 0;
            
        }

        public override void Draw(SpriteBatch sB)
        {
            if (counter % 11 == 10)
            {
                if(sourceRec.X >= 1999 || sourceRec.X <= 0)
                {
                    direction *= -1;
                }
                    sourceRec.X += direction;
                //sourceRec.X = sourceRec.X == 2000 || sourceRec.X == 0 ? direction *= -1 : sourceRec.X + direction;
            }
            counter++;

            sB.Draw(pic, rec, sourceRec, Color.White);
            base.Move();
        }
    }
}
