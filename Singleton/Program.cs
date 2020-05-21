﻿using System;

/// <summary>
/// The 'Singleton' class
/// </summary>

public class Singleton
{
    private static Singleton instance = null;
    private string Name { get; set; }
    private string IP { get; set; }
    private Singleton()
    {
        Console.WriteLine("Singleton Intance");
        Name = "Server1";
        IP = "192.168.1.23";
    }

    private static object syncLock = new object();
    public static Singleton Instance
    {
        get
        {
            lock (syncLock)
            {
                if (Singleton.instance == null)
                    Singleton.instance = new Singleton();
                return Singleton.instance;
            }
        }
    }

    public void Show()
    {
        Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
    }
}

/// <summary>
/// Singleton Pattern Demo
/// </summary>
/// 
class Program
{
    static void Main(string[] args)
    {
        Singleton.Instance.Show();
        Singleton.Instance.Show();
        Console.ReadKey();
    }
}