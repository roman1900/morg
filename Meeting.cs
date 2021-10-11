using System;
using System.Collections.Generic;
namespace morg
{
    public class Meeting 
	{
		public List<Action> Actions = new List<Action>();
		public List<Person> Attendees = new List<Person>();
		public List<Person> Apologies = new List<Person>();

	}
}