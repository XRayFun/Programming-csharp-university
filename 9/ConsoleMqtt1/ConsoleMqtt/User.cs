using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMqtt
{
	class User
	{
		public string fio;
		public int id;
		public string numberGroup;

		public User()
		{
		}

		public User(string fio, int id, string numberGroup)
		{
			this.fio = fio;
			this.id = id;
			this.numberGroup = numberGroup;
		}
		public override string ToString()
		{
			return String.Format("ФИО: {0}, номер:{1}", fio, id);
		}

	}
}
