using ComsumeOSRM_backend.Data;
using ComsumeOSRM_backend.Service;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    
    public static async Task Main()
    {
        var coordinates = new List<OSRMCoordinate>
        {
            new OSRMCoordinate(-82.518771, 27.324867),
            new OSRMCoordinate(-82.532250, 27.356720),
            new OSRMCoordinate(-82.533170, 27.354575),
            new OSRMCoordinate(-82.536295, 27.355159),
            new OSRMCoordinate(-82.533912, 27.355560),
            new OSRMCoordinate(-82.512600, 27.330495),
            new OSRMCoordinate(-82.506461, 27.326643)
        };

        try
        {
            var result = await OSRMTableService.GetDistanceMatrixAsync(coordinates);

            Console.WriteLine("Durations (seconds):");
            PrintMatrix(result.Durations);

            var result2 = OSRMTableServiceG.GetDistanceMatrix(coordinates);
            Console.WriteLine(result2.ToString());

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private static void PrintMatrix(double[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write($"{matrix[i][j]:0.##}\t");
            }
            Console.WriteLine();
        }
    }
}