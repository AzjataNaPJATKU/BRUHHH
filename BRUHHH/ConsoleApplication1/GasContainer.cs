namespace ConsoleApplication1;

public class GasContainer : Container, IHazardNotifier
{
    private static int gasContainerNum = 1;
    private double _cisnienie;
    public GasContainer( double containerHeight, double emptyConWeight,
        double containerDepth, double maxWeight,double cisnienie) : base( containerHeight,
        emptyConWeight, containerDepth, maxWeight)
    {
        _cisnienie = cisnienie;
        name= "KON-G-" + gasContainerNum++;
    }
    
    public override void Load(double cargoWeight)
    {
        if (cargoWeight <= _maxWeight)
        {
            if (_cisnienie>1400)
            {
                     
                notifyIssue();
                     
            }
            else
            {
                _cargoWeight = cargoWeight;
            }
        }
        else
            throw new OverfillException();

        
    }

    public override void Unload()
    {
        _cargoWeight = 0.95*_cargoWeight;
    }

    public void notifyIssue()
    {
        Console.Write("problemy z kontenerem"+name);
    }
    
}