using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Movie
	{
		//movie constructor 
			private string title1;
			private string category;

			public Movie(string title, string category)
			{
				this.title1 = title;
				//making a promise we are going to give it a title. 
				this.category = category;
			}

			public string getCategory()
			{
				return category;//gotta pull out catagory from here since private protects it above. get info from catagory above
			}

			public string getTitle()
			{
				return title1;
			}

		}
	}
