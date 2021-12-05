using MySqlConnector;
using System;



namespace sqlconnection
{
    class Emprepo
    {
        public static string connection = "server=localhost; uid=root;pwd=route;database=vishal;";
        MySqlConnection connect = new MySqlConnection(connection);

        public void repo()
        {
            EmployeeMode model = new EmployeeMode();

            using (this.connect)
            {

                string print = @"SELECT * FROM vishal.emp;";
                MySqlCommand cmd = new MySqlCommand(print, this.connect);
                this.connect.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model.id = dr.GetInt32(0);
                        model.empname = dr.GetString(1);
                        model.empcity = dr.GetString(2);
                        Console.WriteLine(model.id + " " + model.empname + " " + model.empcity);
                    }
                }
                else
                {
                    Console.WriteLine("no row");
                }
                dr.Close();
                this.connect.Close();

            }

        }


        public void insert()
        {
            EmployeeMode model2 = new EmployeeMode();
            using (this.connect)
            {
                string insertDetails = @"insert into vishal.emp(empname, empcity) value('vishi', 'rajeshtan');";

                MySqlCommand cmd = new MySqlCommand(insertDetails, this.connect);
                this.connect.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Close();
                this.connect.Close();

            }
        }
        public void update()
        {
            EmployeeMode model2 = new EmployeeMode();
            using (this.connect)
            {
                string insertDetails = @"set sql_safe_updates=0;
update vishal.emp set empcity='assam' where empname='raj';
set sql_safe_updates = 1; ";

                MySqlCommand cmd = new MySqlCommand(insertDetails, this.connect);
                this.connect.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Close();
                this.connect.Close();

            }
        }
        public void delete()
        {
            EmployeeMode model = new EmployeeMode();
            using (this.connect)
            {
                string deleteDetails = @"DELETE FROM vishal.emp WHERE id = 5;";

                MySqlCommand cmd = new MySqlCommand(deleteDetails, this.connect);
                this.connect.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Close();

                this.connect.Close();


            }
        }

        public void SelectName()
        {
            EmployeeMode model3 = new EmployeeMode();
            using (this.connect)
            {
                string deleteDetails = @"select * FROM vishal.EMP WHERE empname='raj';";

                MySqlCommand cmd1 = new MySqlCommand(deleteDetails, this.connect);
                this.connect.Open();
                MySqlDataReader dr = cmd1.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        model3.id = dr.GetInt32(0);
                        model3.empname = dr.GetString(1);
                        model3.empcity = dr.GetString(2);
                        Console.WriteLine(model3.id + " " + model3.empname + " " + model3.empcity);
                    }
                }
                else
                {
                    Console.WriteLine("row not found");
                }
                dr.Close();

                this.connect.Close();


            }
        }
    }


}
