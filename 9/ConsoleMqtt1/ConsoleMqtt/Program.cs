using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace ConsoleMqtt
{
	class Program
	{
		static MqttClient client;	
		static List<User> users = new List<User>();
		static User currentUser;
		static void connect()
		{		
			client = new MqttClient("broker.mqttdashboard.com");
			client.MqttMsgPublishReceived += Client_MqttMsgReceived;
			string clientId = Guid.NewGuid().ToString();
			client.Connect(clientId);
		}
		private static void Client_MqttMsgReceived(object sender, MqttMsgPublishEventArgs e)
		{
			string msg = Encoding.UTF8.GetString(e.Message);
			if (e.Topic == "/" + currentUser.numberGroup + "/" + currentUser.id)
			{
				Console.WriteLine("Received: {0}, topic:{1}", msg, e.Topic);
			}
			if (e.Topic == "/" + currentUser.numberGroup + "/CHAT")
			{
				if (msg.IndexOf("!REG") != -1)
				{
					User user = new User();
					string[] words;
					char[] separators = new char[] {' ', ','};
					words = msg.Split(separators, StringSplitOptions.RemoveEmptyEntries);
					int rez = 0;
					if (int.TryParse(words[1], out rez))
					{
						user.id = rez;
						user.fio = words[2];
						users.Add(user);
						Console.WriteLine("Добавлен пользователь: {0}", user);
					}
					else
						return;
				}
			}	
		}
		static void RegUser()
		{
			string strReg = "!REG," + currentUser.id + "," + currentUser.fio;
			string strTopic = "/" + currentUser.numberGroup + "/CHAT";
			client.Publish(strTopic, Encoding.UTF8.GetBytes(strReg));
		}
		static void SendUser(int num, string msg)
		{
			string strTopic = "/" + currentUser.numberGroup + "/" + num;
			client.Publish(strTopic, Encoding.UTF8.GetBytes(msg));
		}
		static void AllUsers()
		{
			foreach(var item in users)
			{
				Console.WriteLine(item);
			}
		}
		static void SubscribeUser()
		{
			client.Subscribe(new string[] { "/"+ currentUser.numberGroup+"/"+ currentUser.id,
				                           "/"+currentUser.numberGroup+"/CHAT" }, 
				new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Подключение к брокеру...");
			currentUser = new User("Tretyakov", 23, "IE-45-20");
			users.Add(currentUser);
			connect();			
			Console.WriteLine("Регистрация пользователя...");
			RegUser();
			SubscribeUser();
			Console.WriteLine("1.List of user");
			Console.WriteLine("2.Send user");
			while (Console.ReadKey(true).Key != ConsoleKey.Escape)
			{
				string str1 = Console.ReadLine();
				if (str1 == "1")
					AllUsers();
				if (str1=="2")
				{
					Console.WriteLine("Кому отправить сообщение?");
					str1 = Console.ReadLine();
					int num = int.Parse(str1);
					string message = Console.ReadLine();
					SendUser(num, message);
				}
			}
		}
	}
}
