namespace ConsoleApplication1;

public abstract class Container : Interfaces
{
    protected double _cargoWeight;
    protected double _containerHeight;
    protected double _emptyConWeight;
    protected double _containerDepth;
    protected String name;
    protected double _maxWeight;

    protected Container(double containerHeight,
        double emptyConWeight, double containerDepth, double maxWeight)
    {
        _cargoWeight = 0;
        _containerHeight = containerHeight;
        _emptyConWeight = emptyConWeight;
        _containerDepth = containerDepth;
        _maxWeight = maxWeight;
    }

    public double CargoWeight { get; set; }

    public virtual void Unload()
    {
        throw new NotImplementedException();
        
    }
    public virtual void Load(double cargoWeight)
    {
        throw new NotImplementedException();
        
    }

    public override string ToString()
    {
        return "_cargoWeight: "+ _cargoWeight +
               ", name: "+ name;
    }
}