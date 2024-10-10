namespace ConsoleApp1;

public class Solver
{
    // v1.
    // public IEnumerable FindDistinctVersions(Device rootDevice)
    
    // v2.
    // public IEnumerable FindDistinctVersions(Device rootDevice, Func<Device, string> func)

    // v3.
    public IEnumerable<T> FindDistinctVersions<T>(Device rootDevice, Func<Device, T> func)
    {
        var result = new HashSet<T>();

        var queue = new Queue<Device>();
        queue.Enqueue(rootDevice);

        while (queue.Count > 0)
        {
            Device device = queue.Dequeue();
            result.Add(func(device));

            foreach (Device d in device.Children)
            {
                queue.Enqueue(d);
            }
        }

        return result;
    }
}