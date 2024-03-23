using ConvertHandler;
using static System.Net.Mime.MediaTypeNames;

namespace Eulerian_path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many nodes does this graph have? ");
            int length = Handle.Int32(Console.ReadLine());
            Node[] graph = new Node[length];

            for(int i = 0; i < graph.Length; i++)
            {
                Console.Write("How many edges does node " + (i+1) + " have? ");
                int edgeNum = Handle.Int32(Console.ReadLine());
                graph[i] = new Node(i + 1, edgeNum);
            }

            int oddNum = 0;

            for(int i = 0; i < graph.Length; ++i)
            {
                if (graph[i].AskEven() == false)
                {
                    oddNum++;
                }
            }

            Console.Clear();
            Console.WriteLine("If a graph is built like this:");
            WriteArray(graph);

            if (oddNum == 0)
            {
                Console.WriteLine("\nAn Eulerian ciciut exists");
            }
            else if (oddNum == 2)
            {
                Console.WriteLine("\nAn Eulerian path exists");
            }
            else
            {
                Console.WriteLine("\nNo Eulerian path exists");
            }

            Task.Delay(5000).Wait();
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        static void WriteArray(Node[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Node: " + array[i].name + "\t Edges: " + array[i].num);
            }
        }
    }
}
