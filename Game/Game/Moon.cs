using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyGame
{
    class Moon : BaseObject
    {
        public Moon(Point pos, Point dir, Size size) : base(pos, dir, size)
        {

        }
        public override void Draw()
        {
            Image newImage = Image.FromFile("C:\\Users\\aik\\OneDrive\\Документы\\C#\\C#2_HW\\Game\\Game\\Images\\moon.jpg");
            
            Game.Buffer.Graphics.DrawImage(newImage, Pos.X, Pos.Y, Size.Width, Size.Height);

        }
        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;

            if (Pos.X < 0) Pos.X = Game.Width + Size.Width;

        }
    }
}
