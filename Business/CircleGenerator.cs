using FlyWeightPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern.Business {
  class CircleGenerator {
    private ShapeFactory _factory;
    private string[] _colors;
    private const int _maxCoord = 100;
    private const int _minRadius = 10;
    private const int _maxRadius = 50;
    private Random _randGen;
    internal CircleGenerator() {
      _colors = new string[] { "red", "green", "blue" };
      _randGen = new Random();
      _factory = new ShapeFactory();
    }

    internal void Generate() {
      for (int i = 0; i < 20; i++) {
        Circle circle = (Circle)_factory.GetCircle(GetRandomColor());
        circle.SetX(GetRandomX());
        circle.SetY(GetRandomY());
        circle.SetRadius(GetRandomRadius());
        circle.Draw();
      }
    }

    private string GetRandomColor() {
      return _colors[_randGen.Next(0, _colors.Length)];
    }

    private int GetRandomX() {
      return _randGen.Next(0, _maxCoord);
    }

    private int GetRandomY() {
      return _randGen.Next(0, _maxCoord);
    }

    private int GetRandomRadius() {
      return _randGen.Next(_minRadius, _maxRadius);
    }
  }
}
