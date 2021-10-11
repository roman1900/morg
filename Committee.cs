using System;
using System.IO;
using System.Collections.Generic;
namespace morg
{
	class Committee
	{
		public List<Person> Active_Members = new List<Person>();
		public List<Person> Inactive_Members = new List<Person>();
		public string Title {get;set;}
		public List<Meeting> Meetings = new List<Meeting>();
		public List<Action> Outstanding_Actions = new List<Action>();

		public Committee(string filename)
		{
			//TODO: load committee from conf file
		}
	}
}