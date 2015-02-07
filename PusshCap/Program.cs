using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace PusshCap
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "cap.png";
            if (args.Length != 0)
            {
                name = args[0];
            }

            Rectangle bounds = Screen.GetBounds(Cursor.Position);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
                }
                bitmap.Save(name, ImageFormat.Png);
            }

            string output = bounds.X.ToString() + ",";
            output += bounds.Y.ToString() + ",";
            output += bounds.Width.ToString() + ",";
            output += bounds.Height.ToString() + ",";
            output += Cursor.Position.X.ToString() + ",";
            output += Cursor.Position.Y.ToString() + ",";
            output += name;

            System.Console.WriteLine(output);
        }
    }
}
