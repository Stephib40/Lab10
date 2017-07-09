using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
			Console.WriteLine("Welcome to the Movie List Application");
			Console.WriteLine("Please Pick One of The Following Catagories: Sci-fi, Horror, Animated, Drama.");
			String input = Console.ReadLine();//("sci-fi", "horror", "animated", "drama"))
				
			Console.WriteLine("");
			Console.WriteLine("The following movies are " + input + " movies:");
			Console.WriteLine("");
				//string d = j.getCategory(); did not work here. 
				//List<String> cat = new List<string>(); Ok could not get this to work. Removed and tried Jillane's method of &&input.Contain()
				//cat.Add("Animated");
				//cat.Add("Drama");
				//cat.Add("Horror");
				//cat.Add("Sci-fi");

				List<Movie> movies = new List<Movie>();
				Movie m = new Movie("It ", "Horror");//building movie objects//constructor
				movies.Add(m);
				Movie n = new Movie("Moana ", "Animated");
				movies.Add(n);
				Movie l = new Movie("Aliens ", "Sci-fi");
				movies.Add(l);
				Movie o = new Movie("Star Trek ", "Sci-fi");
				movies.Add(o);
				Movie p = new Movie("English Patient ", "Drama");
				movies.Add(p);
				Movie q = new Movie("Toy Story ", "Animated");
				movies.Add(q);
				Movie z = new Movie("The Omen ", "Horror");
				movies.Add(z);
				Movie x = new Movie("The Little Mermaid ", "Animated");
				movies.Add(x);
				Movie y = new Movie("Hidden Figures ", "Drama");
				movies.Add(y);
				Movie t = new Movie("The Fifth Element ", "Sci-fi");
				
				foreach (Movie j in movies)
				{
					
					string cat = j.getCategory();//j is the object getCatagory is method
											//string b = j.getCategory();
											//string k = j.getCategory();
											//string u = j.getCategory(); this does not work 

					if (cat == "Horror" && input.Contains("Horror"))
					{
						Console.WriteLine(j.getTitle() + " is a horror movie");
						//movie m & z
					}
					else if (cat == "Sci-fi" && input.Contains("Sci-fi"))
					{
						Console.WriteLine(j.getTitle() + " is a sci-fi movie");
						//movie l, o, t
					}
					else if (cat == "Drama" && input.Contains("Drama"))
					{
						Console.WriteLine(j.getTitle() + " is a drama");
						//movie p, y
					}
					else if (cat == "Animated" && input.Contains("Animated"))
					{
						Console.WriteLine(j.getTitle() + " is an animated movie");
						//movie n, q, x
					}
				}
			}

			while (Continue() == true);
		}
			public static Boolean Continue()
			{
				Boolean run;
				Console.WriteLine("Continue: y/n?");
				string answer = Console.ReadLine();

				if ((answer == "Y") || (answer == "y"))
				{
					run = true;
				}
				else if ((answer == "N") || (answer == "n"))
				{
					run = false;
					Console.WriteLine("Adios.");
				}
				else
				{
					Console.WriteLine("Yadda Yadda");
					run = Continue();
				}
				return run;
			}
		}
	}

