using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace ConsoleApplicationMqttStar
{
    class Program
    {
        static int nomer = 0;
        static MqttClient client;
        static void Subscribe()
        {
            client = new MqttClient("broker.mqttdashboard.com");
            client.MqttMsgPublishReceived += Client_MqttMsgReceived;
            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);
            client.Subscribe(new string[] { "IE_45_20/" + nomer.ToString() }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

        }

        private static void Client_MqttMsgReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Console.WriteLine("Received: {0}, topic:{1}", Encoding.UTF8.GetString(e.Message), e.Topic);
        }

        static string makeMessage(int x)
        {
            String str = "!CHECK," + nomer.ToString() + ","
            + x.ToString();
            return str;
        }
        static void Main(string[] args)
        {
            Subscribe();

            Console.WriteLine("Введите число от 1 до 100?");
            int x = Int32.Parse(Console.ReadLine());
            string strVal = makeMessage(x);
            client.Publish("/IE_45_20/All", Encoding.UTF8.GetBytes(strVal));
            Console.ReadLine();

        }
    }
}