﻿using Herdar_VS_CumprirContrato.Model.Enums;


namespace Herdar_VS_CumprirContrato.Model.Entities {
    abstract class AbstractShape : IShape {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
