namespace ConsoleApplication1;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool _isSafe;
    private static int liquidContainerNum = 1;
    public LiquidContainer( double containerHeight, double emptyConWeight,
            double containerDepth, double maxWeight, bool isSafe) : base( containerHeight, 
            emptyConWeight, containerDepth, maxWeight)
    {
        _isSafe = isSafe;
        name = "KON-L-" + liquidContainerNum++;
    }
    public override void Load(double cargoWeight)
    {
        if (cargoWeight <= _maxWeight)
        {
            if (_isSafe)
            {
                if (cargoWeight <= 0.9 * _maxWeight)
                {
                    _cargoWeight = cargoWeight;
                }
                else
                {
                    notifyIssue();
                }
            }
            else
            {
                if (cargoWeight <= 0.5 * _maxWeight)
                {
                    _cargoWeight = cargoWeight;
                }
                else
                {
                    notifyIssue();
                }
            }
        }
        else
            throw new OverfillException();

    }

    public override void Unload()
    {
        _cargoWeight = 0;
    }

    public void notifyIssue()
    {
        Console.Write("problemy z kontenerem"+name);
    }
}