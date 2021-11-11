using System.Collections.Generic;

namespace OopExamples
{
    class Program_IConnection
    {
        static void MainProgram(string[] args)
        {
            
            

            //connection.GetUsers();


        }

        public interface IConnection
        {
            string ConnectionString { get; set; }
            void Connect();
            List<string> GetUsers();
        }

        public class ConnectionMySql : IConnection
        {
            public string ConnectionString { get; set; }
            public void Connect()
            {
                throw new System.NotImplementedException();
            }

            public List<string> GetUsers()
            {
                throw new System.NotImplementedException();
            }
        }


        public class ConnectionMsSql : IConnection
        {
            public string ConnectionString { get; set; }
            public void Connect()
            {
                throw new System.NotImplementedException();
            }

            public List<string> GetUsers()
            {
                throw new System.NotImplementedException();
            }
        }

    }

}
