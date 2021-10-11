using System;
namespace morg
{
	public class Person
	{
		private string _initials;
		private string _fn;
		private string _ln;
		public string First_Name 
		{
			get => _fn;
			set {_fn = value; _initials=_fn[0].ToString()+(_ln == null ? "" :_ln[0].ToString());}
		}
		public string Last_Name 
		{
			get => _ln;
			set {_ln = value; _initials = (_fn == null ? "" : _fn[0].ToString())+_ln[0].ToString();}
		}
		public string Initials 
		{
			get => _initials;
		}
		public bool Active {get; set;}

	}
}