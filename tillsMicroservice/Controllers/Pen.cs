using System.Security.Cryptography.X509Certificates;
using Microsoft.IdentityModel.Tokens;

namespace tillsMicroservice
{
    public enum PenColor
    {
        Red,
        Blue
    };


    public class Pen
    {
        public PenColor Color { get; set; }

        private Pen(PenColor _color)
        {
            Color = _color;
        }

        public static Pen CreateRedPen()
        {
            return new Pen(PenColor.Red);
        }

        public static Pen CreateBluePen()
        {
            return new Pen(PenColor.Blue);
        }

        public string ToJson()
        {
            string json = "{\"pen\": {\"color\": \"";
            switch (Color)
            {
                case PenColor.Red:
                    json += "red";
                    break;
                case PenColor.Blue:
                    json += "blue";
                    break;
            }

            json += "\"}}";

            return json;
        }

    };
}