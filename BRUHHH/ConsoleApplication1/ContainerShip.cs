namespace ConsoleApplication1;

public class ContainerShip
{
    private static int numerStatku=1;
    private String name;
    private int speed;
    private int maxContainerNum;
    private int maxWeight;
    private List<Container> _list;

    public ContainerShip(int speed, int maxContainerNum, int maxWeight)
    {
        name = "Statek " + numerStatku++;
        this.speed = speed;
        this.maxContainerNum = maxContainerNum;
        this.maxWeight = maxWeight;
        this._list = new List<Container>();
    }

    public void addContainer(Container container)
    {
        double sum = 0;
        for (int i = 0; i < _list.Count; i++)
        {
            sum = sum + _list[i].CargoWeight;
        }

        if (sum+container.CargoWeight>maxWeight)
        {
            Console.Write("przekroczono maks wage");
        }else if (_list.Count>=maxContainerNum)
        {
            Console.Write("za duzo kontenerow");
        }
        else
        {
            _list.Add(container);
        }
    }
    public void remove(int a)
    {
        _list.RemoveAt(a);
    }

    public void print()
    {
        for (int i = 0; i < _list.Count; i++)
        {
            Console.Write(i+". "+_list[i]);
        }
    }
    public override string ToString()
    {
        return name +"(speed="+speed+", maxContainerNum="+maxContainerNum+", MaxWeight="+maxWeight+")";
    }
}