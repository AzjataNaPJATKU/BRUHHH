namespace ConsoleApplication1;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight) : base(cargoWeight)
    {
    }
    public override void Load(double cargoWeight)
    {
        base.CargoWeight = cargoWeight;
    }
}