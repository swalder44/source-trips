using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models;

namespace Client
{
	public class Program
	{
        public static string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
        public static void Main(string[] args)
		{
            Console.WriteLine("Press enter to start");
            Console.ReadKey();
            var binding = new BasicHttpBinding();
			var endpoint = new EndpointAddress(new Uri(string.Format("http://{0}:5050/Service.svc", Environment.MachineName)));
			var channelFactory = new ChannelFactory<ISampleService>(binding, endpoint);
			var serviceClient = channelFactory.CreateChannel();
			//var result = serviceClient.Ping(1);
			//Console.WriteLine("Ping method result: {0}", result);

            XmlSerializer deserializer = new XmlSerializer(typeof(VehicleContainer));
            FileStream stream = new FileStream(@"C:\tmp\20180502_193107_830020_4503599629427280.xml", FileMode.Open);
            VehicleContainer movies;
            movies = (VehicleContainer)deserializer.Deserialize(stream);
            ///*textReader*/.Close();
            
            

            var complexResult = serviceClient.CheckRequestData(movies);
			Console.WriteLine("Answer");
            //XmlSerializer formatterAnswer = new XmlSerializer(typeof(CheckResultData));
            //MemoryStream memoryStreamAnswer = new MemoryStream();
            //formatterAnswer.Serialize(memoryStreamAnswer, complexResult);
            //Console.WriteLine(StreamToString(memoryStreamAnswer));

   //         serviceClient.VoidMethod(out var stringValue);
			//Console.WriteLine("Void method result: {0}", stringValue);

			//var asyncMethodResult = serviceClient.AsyncMethod().Result;
			//Console.WriteLine("Async method result: {0}", asyncMethodResult);

			Console.ReadKey();
		}
	}
}
