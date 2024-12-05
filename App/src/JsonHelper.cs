﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using domain.entities;

namespace App
{
    internal class JsonHelper
    {
        private static readonly string filePath = "C:\\Users\\romai\\Desktop\\CsharpProjet\\App\\articles.json";

        public static void SaveArticles(List<Article> articles)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(articles, options);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Articles saved to JSON file.");
        }

        public static List<Article> LoadArticles()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("JSON file not found, returning empty list.");
                return new List<Article>();
            }

            string jsonString = File.ReadAllText(filePath);
            Console.WriteLine("Articles loaded from JSON file.");
            return JsonSerializer.Deserialize<List<Article>>(jsonString);
        }
    }
}
