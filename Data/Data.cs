using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

public class Data : IDataLayer
{
    private readonly string filePath = "tasks.json";
    public void SaveToFile(List<Job> jobList)
    {
        var json = JsonSerializer.Serialize(jobList, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public List<Job> LoadFromFile()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                return new List<Job>();
            }

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Job>>(json) ?? new List<Job>();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
            return new List<Job>();
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access to the file is denied.");
            return new List<Job>();
        }
        catch (JsonException)
        {
            Console.WriteLine("Error parsing JSON data.");
            return new List<Job>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
            return new List<Job>();
        }
    }
}