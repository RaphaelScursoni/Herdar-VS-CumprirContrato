﻿using System;
using System.Globalization;

namespace Herdar_VS_CumprirContrato.Model.Entities {
    class Retangle : AbstractShape {

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Retangle color = "
                + Color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                 + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                 + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}