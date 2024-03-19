namespace ConsoleApplication1;

public abstract class Container : Interfaces
{
    private double _cargoWeight;

    protected Container(double cargoWeight)
    {
        _cargoWeight = cargoWeight;
    }

    public double CargoWeight { get; set; }

    public void Unload()
    {
        throw new NotImplementedException();
        
    }
    public virtual void Load(double cargoWeight)
    {
        throw new OverfillException("BRUHHHHHHH");
        
    }
}