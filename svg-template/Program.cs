using System;
using System.IO;

namespace svg_template
{
    class Artist
    {
        public string style = "stroke=\"black\" stroke-width=\"1px\" fill=\"#00fffb\" opacity=\"0.3\"";

        private string draw_svg(int width, int height, string shapes)
        {
            /*
            Puts svg header and footer around some svg shapes.
            Input:
            -width: int, desired width of the svg drawing in pixels
           - height: int, desired height of the svg drawing in pixels
           - shapes: string, svg code describing the contents of the drawing
            Output:
            -string, the given svg code surrounded by header and footer tags
            */
            string viewbox = "viewBox=\"0 0 " + width.ToString() + " " + height.ToString() + "\"";
            string xmlns = "xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" ";
            string header = "<svg width=\"" + width.ToString() + "\" " + xmlns + viewbox + ">";
            string footer = "</svg>";
            return header + shapes + footer;
        }

        private string draw_circle(int x, int y, double radius)
        {
            /*
             Creates svg code for drawing a circle.
            Input:
                -x: int, x-coordinate of the center of the circle in pixels
                - y: int, y-coordinate of the center of the circle in pixels
                - radius: int, radius of the circle in pixels
            Output:
                -str, svg code describing a circle
            */
            string cx = "cx=\"" + x.ToString() + "\"";
            string cy = "cy=\"" + y.ToString() + "\"";
            string rad = "r=\"" + radius.ToString() + "\"";
            return "<circle " + cx + " " + cy + " " + rad + " " + style + "/>";
        }

        private string draw_rectangle(int x, int y, int width, int height)
        {
            /*
             Creates svg code for drawing a circle.
            Input:
                -x: int, x-coordinate of the center of the circle in pixels
                - y: int, y-coordinate of the center of the circle in pixels
                - radius: int, radius of the circle in pixels
            Output:
                -str, svg code describing a circle
            */
            string rx = "x=\"" + x.ToString() + "\"";
            string ry = "y=\"" + y.ToString() + "\"";
            string rw = "width=\"" + width.ToString() + "\"";
            string rh = "height=\"" + height.ToString() + "\"";
            return "<rect " + rx + " " + ry + " " + rw + " " + rh + " " + style + "/>";
        }
        
        private void save(string svg, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(svg);
            }
        }
        static void Main(string[] args)
        {
            Artist leo = new Artist();
            string shapes = "";
            shapes += leo.draw_circle(350, 220, 200);
            shapes += leo.draw_rectangle(200, 100, 50, 150);

            string drawing = leo.draw_svg(500, 500, shapes);
            leo.save(drawing, @"test.svg");

        }
    }
}
