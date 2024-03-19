namespace ConsoleApplication1;

public interface Interfaces
{
    public interface IContainer
    {
        void Unload();
        void Load(double cargoWeight);
    }
}