using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
	internal class Option
	{
		private char User_Option;

		public Option (char a_user_option)
		{
			User_Option = a_user_option;
		}

		public char getUserOption()
		{
			return User_Option;
		}
	}
}
