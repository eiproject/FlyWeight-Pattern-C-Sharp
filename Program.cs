using FlyWeightPattern.Business;
using System;

namespace FlyWeightPattern {
  class Program {
    static void Main(string[] args) {
      CircleGenerator gen = new CircleGenerator();
      gen.Generate();
    }
  }
}
