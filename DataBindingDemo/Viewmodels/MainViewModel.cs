using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBindingDemo.Models;
using MySql.Data.MySqlClient;


namespace DataBindingDemo.Viewmodels
{
    class MainViewModel 

    {

        
        private ObservableCollection<cPerson> _Persons = new ObservableCollection<cPerson> { };

        public MainViewModel()
        {
            string sConnect = "Server=localhost;Database=bindingdemo;Uid = bindingdemo; Pwd = bindingdemo;";
            MySqlConnection conn = new MySqlConnection(sConnect);
            conn.Open();

            string query = "SELECT `firstname`,`lastname` FROM `person`";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            
            while(reader.HasRows)
            {
                while(reader.Read())
                {
                    cPerson Person = new cPerson(reader.GetString(0), reader.GetString(1));
                    _Persons.Add(Person);

                }
                reader.NextResult();
            }

                                    
        }

        public ObservableCollection<cPerson> Persons {
            get 
            {
                return _Persons;
            }
        }

    

    }
}
