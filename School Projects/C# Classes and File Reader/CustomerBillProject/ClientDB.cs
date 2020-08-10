using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBillProject
{
    public static class ClientDB
    {
        const string path = "clients.txt"; // located in bin/Debug folder

        public static List<Client> ReadClients()
        {
            List<Client> clientList = new List<Client>(); //create an empty list
            Client c; // for reading clients
            string line; // next line from the file
            string[] fields; // line broken into fields
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)// while there is still unread data
                    {
                        line = sr.ReadLine();
                        fields = line.Split(',');//split where the comma's are
                        string Name = fields[0];
                        int AccountNumber = Convert.ToInt32(fields[1]);
                        string ClientType = fields[2];
                        decimal ChargeAmount = Convert.ToDecimal(fields[3]);
                        //create class based on client type
                        if (fields[2] == "r")
                        {
                            c = new Residential(Name, AccountNumber,ClientType,ChargeAmount);
                        }
                        else if(fields[2] == "c")
                        {
                        c = new Commercial(Name, AccountNumber, ClientType, ChargeAmount);
                        }
                        else
                        {
                        c = new Industrial(Name, AccountNumber, ClientType, ChargeAmount);
                        }
                        clientList.Add(c);
                    }
                }// closes stream reader and recycles
            } // closes file stream and recycles
            return clientList;
        }
        public static void SaveClients(List<Client> clientList)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Client c in clientList)
                    {
                        sw.WriteLine(c.ToCSV());
                    }
                } //closes the sw and recycles
            } // closes the fs and recycles
        }
    }
}
