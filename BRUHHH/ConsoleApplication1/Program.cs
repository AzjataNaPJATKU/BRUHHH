// See https://aka.ms/new-console-template for more information


using ConsoleApplication1;



List<ContainerShip> containerShips = new List<ContainerShip>();
List<Container> containers = new List<Container>();
int choose;
while (true)
{
    
    if (containerShips.Count==0)
    {
        Console.Write("1.add containerShip \n 2.quit");
        choose=Convert.ToInt32(Console.ReadLine());
        if (choose==1)
        {
            Console.Write("podaj parametry");
            containerShips.Add(new ContainerShip(Convert.ToInt32(Console.ReadLine())
                ,Convert.ToInt32(Console.ReadLine())
                ,Convert.ToInt32(Console.ReadLine())));
        }
        else
        {
            break;
        }
    }
    else
    {
        Console.Write("1.add containerShip \n 2.delete containerShip \n3.add container" +
                      "\n4.add weight to containerShip\n5.add weight to container \n6.remove weight from container" +
                      " \n7.remove container \n8.print ships \n9.print containers \n else. quit");
        choose=Convert.ToInt32(Console.ReadLine());
        if (choose==1)
        {
            Console.Write("podaj parametry");
            containerShips.Add(new ContainerShip(Convert.ToInt32(Console.ReadLine())
                ,Convert.ToInt32(Console.ReadLine())
                ,Convert.ToInt32(Console.ReadLine())));
        }else if (choose == 2)
        {
            Console.WriteLine("podaj index do usuniecia");
            printcontainerShips();

            containerShips.RemoveAt(Convert.ToInt32(Console.ReadLine()));

        }else if (choose == 3)
        {
            
            Console.WriteLine("1.LiquidContainer\n2.GasContainer\n3.FridgeContainer");

            if ( (choose=Convert.ToInt32(Console.ReadLine()))==1)
            {
                 containers.Add (new LiquidContainer(Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToBoolean(Console.ReadLine())
                ));
            }else if (choose==2)
            {
                containers.Add(new GasContainer(Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine())
                ));
            }
            else
            {
                containers.Add(new GasContainer(Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine())
                ));
            }
            
        }
        else if(choose==4)
        {
            Console.Write("podaj index statku");
            printcontainerShips();
            int ship = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj index kontenera");
            printcontainers();
            int content = Convert.ToInt32(Console.ReadLine());
            containerShips[ship].addContainer(containers[content]);
            containers.RemoveAt(content);
        }
        else if (choose==5)
        {
            Console.Write("podaj index kontenera");
            printcontainers();
            containers[Convert.ToInt32(Console.ReadLine())].Load(Convert.ToDouble(Console.ReadLine()));
        }
        else if(choose==6)
        {
            Console.Write("podaj index kontenera");
            printcontainers();
            int content = Convert.ToInt32(Console.ReadLine());
            containers[content].Unload();
        }
        else if (choose==7)
        {
            Console.Write("podaj index statku");
            printcontainerShips();
            int ship = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj index kontenera");
            containerShips[ship].print();
            containerShips[ship].remove(Convert.ToInt32(Console.ReadLine()));
        }else if (choose==8)
        {
            printcontainerShips();
        }else if (choose==9)
        {
            printcontainers();
        }
        else
        {
            break;
        }
    }
}

void printcontainerShips()
     {
         for (int i = 0; i < containerShips.Count; i++)
         {
             Console.Write(i+". "+containerShips[i]);
         }
     }
void printcontainers()
{
    for (int i = 0; i < containers.Count; i++)
    {
        Console.Write(i+". "+containers[i]);
    }
}
//Dictionary<PossibleProducts,double> dictionary = new Dictionary<PossibleProducts, double>();
