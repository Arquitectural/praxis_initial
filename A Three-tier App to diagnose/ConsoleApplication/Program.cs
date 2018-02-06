﻿using System;
using static System.Console;

namespace ConsoleApplication
{
  class Program
  {
    static void run()
    {
      try
      {
        var sculpture_client = new ConsoleApplication.SculptureProxy("SculptureService");
        var sculptures = sculpture_client.Proxy.GetSculptures(null);
        foreach (var sculpture in sculptures)
        {
          WriteLine($"{sculpture.ID,5} {sculpture.Name,30} {sculpture.Artist,24} {sculpture.When,20}");
        }
      }
      catch (Exception ex)
      {
        WriteLine($"{ex.GetType().FullName}: {ex.Message}");
      }
    }
    static void Main(string[] args)
    {
      for (int k = 0; k < 2049*4; ++k) run();
    }
  }
}