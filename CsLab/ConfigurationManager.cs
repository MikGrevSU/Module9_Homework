using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public sealed class ConfigurationManager
{
    private static ConfigurationManager instance = null;
    private static readonly object lockObj = new object();

    private Dictionary<string, string> settings = new Dictionary<string, string>();
    private string filePath = "config.txt";

    private ConfigurationManager() { }

    public static ConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            lock (lockObj)
            {
                if (instance == null)
                    instance = new ConfigurationManager();
            }
        }
        return instance;
    }

    public void Set(string key, string value)
    {
        lock (lockObj)
        {
            settings[key] = value;
        }
    }

    public string Get(string key)
    {
        lock (lockObj)
        {
            if (settings.ContainsKey(key))
                return settings[key];
            else
                throw new KeyNotFoundException($"Настройка '{key}' не найдена");
        }
    }

    public void SaveToFile()
    {
        lock (lockObj)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var pair in settings)
                    sw.WriteLine($"{pair.Key}={pair.Value}");
            }
        }
    }

    public void LoadFromFile()
    {
        lock (lockObj)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл конфигурации не найден, создаётся новый.");
                File.Create(filePath).Close();
                return;
            }

            settings.Clear();
            foreach (var line in File.ReadAllLines(filePath))
            {
                if (line.Contains("="))
                {
                    var parts = line.Split('=');
                    settings[parts[0]] = parts[1];
                }
            }
        }
    }
}
