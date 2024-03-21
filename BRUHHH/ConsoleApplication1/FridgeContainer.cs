namespace ConsoleApplication1;

public class FridgeContainer : Container
{
    private String rodzaj;
    private double _temperature;
    Dictionary<String,double> menu;
    
    private static int fridgeContainerNum = 1;
    public FridgeContainer( double containerHeight, double emptyConWeight,
        double containerDepth, double maxWeight, double temperature, String type) : base( containerHeight,
        emptyConWeight, containerDepth, maxWeight)
    {
        name= "KON-C-" + fridgeContainerNum++;
        _temperature = temperature;
        menu = new Dictionary<string, double>();
        menu["bananas"] = 13;
        menu["fish"] = 2;
        menu["frozen pizza"] = -30;
        menu["ice cream"] = -18;
        menu["eggs"] = 19;
        rodzaj = type;

    }
    public virtual void Unload()
    {
        _cargoWeight=0;
        
    }
    public virtual void Load(double cargoWeight)
    {
        if (!menu.ContainsKey(rodzaj))
        {
            Console.Write("nie ma tego produltu na liscie");
        }else if (_temperature>menu[rodzaj])
        {
            Console.Write("za zimno");
        }
        else
        {
            _cargoWeight = cargoWeight;
        }
        
    }
}