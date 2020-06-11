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
    class FlyHero: SuperHero
    {
        //VARS
        private int flySpeed = 3;
        

        //METHODS

        public FlyHero(string name) :base(name)
        {

        }

        public override void Move()
        {
            rec.Y += flySpeed;
            if (rec.Y < 100 || rec.Y > 600)
                flySpeed *= -1;
            base.Move();
        }
    }
}
