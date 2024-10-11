using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStoreManagementSytem.DTO
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Client()
        {

        }

        public Client(int iD, string name, string email, string phone, string address)
        {
            ID = iD;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public Client(DataRow row) 
        {
            ID = (int)row["ID"];
            Name = (string)row["Name"];
            Email = (string)row["Email"];
            Phone = (string)row["Phone"];
            Address = (string)row["Address"];
        }
    }
}
