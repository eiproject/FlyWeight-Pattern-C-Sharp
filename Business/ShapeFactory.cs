using FlyWeightPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern.Business {
  class ShapeFactory {
    private Dictionary<string, IShape> _shapeDict;
    internal ShapeFactory() {
      _shapeDict = new Dictionary<string, IShape>();
    }
    public IShape GetCircle(string color) {
      IShape circle;
      _shapeDict.TryGetValue(color, out circle);

      if (circle == null) {
        circle = new Circle(color);
        _shapeDict.Add(color, circle);
        Console.WriteLine($"Creating new Circle with color {color}, OK");
      }
      return circle;
    }
  }
}
