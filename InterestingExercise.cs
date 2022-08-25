using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> studentsByPoints = new Dictionary<string, decimal>();

            Dictionary<string, int> coursesBySubmission = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "exam finished")
                {
                    break;
                }

                string[] parts = line.Split("-", StringSplitOptions.RemoveEmptyEntries);

                string username = parts[0];
                string language = parts[1];
              
                if (language == "banned")
                {
                    studentsByPoints.Remove(username);
                    continue;
                }

                if (!studentsByPoints.ContainsKey(username))
                {
                    decimal points = decimal.Parse(parts[2]);
                    studentsByPoints.Add(username, points);

                    if (!coursesBySubmission.ContainsKey(language))
                    {
                        coursesBySubmission.Add(language, 1);
                    }
                    else
                    {
                        coursesBySubmission[language] += 1;
                    }
                }
                else
                {
                    decimal points = decimal.Parse(parts[2]);

                    if (studentsByPoints[username] <= points)
                    {
                        studentsByPoints[username] = points;
                    }

                    coursesBySubmission[language] += 1;
                }

            }

            Dictionary<string, decimal> sortedByPoints = studentsByPoints
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");

            
            foreach (var (student, grade) in sortedByPoints)
            {              
                Console.WriteLine($"{student} | {grade}");
            }

            Dictionary<string, int> sortedBySubmissions = coursesBySubmission
                .Where(s => s.Value > 0)
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");

            foreach (var (lang, count) in sortedBySubmissions)
            {
               
                Console.WriteLine($"{lang} - {count}");
            }

        }
    }
 }