using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    struct CustomColor
    {
        public int r;
        public int g;
        public int b;

        public CustomColor(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }

    public class GradientController
    {
        double darknessBound = -0.4;
        double lightnessBound = 0.8;

        List<CustomColor> colors;

        public GradientController()
        {
            colors = new List<CustomColor>();
        }

        bool initializeColor(int delta)
        {
            int id = delta / 256;
            int integral = delta % 256;
            CustomColor color;
            switch (id)
            {
                case 0: // [255,0,0] --> [255,255,0]
                    {
                        color = new CustomColor(255, 0 + integral, 0);
                        break;
                    }
                case 1: // [255,255,0] --> [0,255,0]
                    {
                        color = new CustomColor(255 - integral, 255, 0);
                        break;
                    }
                case 2: // [0,255,0] --> [0,255,255]
                    {
                        color = new CustomColor(0, 255, 0 + integral);
                        break;
                    }
                case 3: // [0,255,255] --> [0,0,255]
                    {
                        color = new CustomColor(0, 255 - integral, 255);
                        break;
                    }
                case 4: // [0,0,255] --> [255,0,255]
                    {
                        color = new CustomColor(0 + integral, 0, 255);
                        break;
                    }
                case 5: // [255,0,255] --> [255,0,0]
                    {
                        color = new CustomColor(255, 0, 255 - integral);
                        break;
                    }
                default:
                    {
                        return false;
                    }
            }

            this.colors.Add(color);
            return true;
        }

        private bool initializeColorsWithDelta(double delta)
        {
            double incrementedDelta = 0;
            while (incrementedDelta < 1524)
            {
                bool isCorrect = initializeColor((int)Math.Round(incrementedDelta));
                if (!isCorrect)
                    return false;

                incrementedDelta += delta;
            }

            return true;
        }

        public Color[] calculateColors(int colors)
        {
            int maxColors = Math.Min((int)Math.Floor(16777215.0 * (Math.Abs(darknessBound) + Math.Abs(lightnessBound)) / 2.0), 16777215);
            if (colors < 1 || colors > maxColors)
                return null;

            // due to the circle palette (254 * 6) = 1524 = 508 * 3
            int maxRange = Math.Min(colors, 1524);
            double delta = 1524 / maxRange;

            bool isCorrect = this.initializeColorsWithDelta(delta);
            if (!isCorrect)
                return null;

            double spreadRange = Math.Max(0.01, 1.0 - (double)colors / maxColors);
            return this.spreadColors(spreadRange, colors);
        }

        private Color[] spreadColors(double spreadRange, int colorsLength)
        {
            double lowerBound = Math.Min(Math.Max(-1.0, darknessBound), 0);
            double upperBound = Math.Max(Math.Min(1.0, lightnessBound), 0);

            double deltaRange = spreadRange * (Math.Abs(lowerBound) + Math.Abs(upperBound));
            int colorStep = Math.Max((int)(1.0 / spreadRange), 2);

            Color[] colors = new Color[colorsLength];
            int i = 0;
            while (i < colors.Length)
            {
                double offset;
                    offset = Math.Min(lowerBound + deltaRange * (i % colorStep), upperBound);
                var customColor = this.colors[i % 1524];

                colors[i] = getGraphicsColor(customColor, offset);

                i++;
            }

            return colors;
        }

        private Color getGraphicsColor(CustomColor customColor, double offset)
        {
            if (offset > 0)
            {
                // brightness
                int r = customColor.r + (int)((double)(255 - customColor.r) * offset);
                int g = customColor.g + (int)((double)(255 - customColor.g) * offset);
                int b = customColor.b + (int)((double)(255 - customColor.b) * offset);
                return Color.FromArgb(r, g, b);
            }
            else if (offset < 0)
            {
                // darkness
                int r = customColor.r - (int)((double)customColor.r * Math.Abs(offset));
                int g = customColor.g - (int)((double)customColor.g * Math.Abs(offset));
                int b = customColor.b - (int)((double)customColor.b * Math.Abs(offset));
                return Color.FromArgb(r, g, b);
            }
            else
            {
                return Color.FromArgb(customColor.r, customColor.g, customColor.b);
            }
        }
    }
}
