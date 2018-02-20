  public class Car
  {
      private string modelCar;
      private Engine engineCar;
      private string weightCar;
      private string colorCar;

      public Car(string modelCar, Engine engineCar)
      {
          this.modelCar = modelCar;
          this.engineCar = engineCar;
          this.weightCar = "n/a";
          this.colorCar = "n/a";
      }

      public string ModelCar
      {
          get => modelCar;
          set => modelCar = value;
      }

      public Engine EngineCar
      {
          get => engineCar;
          set => engineCar = value;
      }

      public string WeightCar
      {
          get => weightCar;
          set => weightCar = value;
      }

      public string ColorCar
      {
          get => colorCar;
          set => colorCar = value;
      }

      public override string ToString()
      {
          return $"{this.ModelCar}:\n" +
                 $"  {this.EngineCar.EngineModel}:\n" +
                 $"    Power: {this.EngineCar.EnginePower}\n" +
                 $"    Displacement: {this.EngineCar.EngineDisplacement}\n" +
                 $"    Efficiency: {this.EngineCar.EngineEfficiency}\n" +
                 $"  Weight: {this.WeightCar}\n" +
                 $"  Color: {this.ColorCar}";
      }
  }

