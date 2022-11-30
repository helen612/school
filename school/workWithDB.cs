using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web;
using System.Data;
using school.Tables;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace school
{
    class workWithDB
    {
        public static string connectionString = @"Data Source=ALENA-PC\SQLEXPRESS;Initial Catalog=1;Integrated Security=True";
        public static SqlConnection sqlConnection;
        public workWithDB()
        {
            sqlConnection = new SqlConnection(connectionString);
            
        }
        public LogIn getLogIn(string username, string password)
        {
            LogIn somePerson = new LogIn();
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"select * from LogIn where Username = '{username}' and Password = '{password}'", workWithDB.sqlConnection);
            try
            {
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    somePerson.id = Convert.ToInt32(sqlDataReader["Id"]);
                    somePerson.username = sqlDataReader["Username"].ToString();
                    somePerson.password = sqlDataReader["Password"].ToString();
                    somePerson.lvl = Convert.ToInt32(sqlDataReader["level"]);
                }
                sqlDataReader.Close();
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                somePerson.username = ex.Message;
            }

            return somePerson;
        }
        public string getClassOfStudent(int id)
        {
            string classOfPeople = "";
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"select Название from Классы " +
                                                $"join Учащийся on Учащийся.[Код класса] = Классы.[Код класса] " +
                                                $"where id = '{id}'", workWithDB.sqlConnection);
            try
            {
                sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    classOfPeople = sqlDataReader["Название"].ToString();
                }
                sqlDataReader.Close();
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                classOfPeople = ex.Message;
            }

            return classOfPeople;
        }
        public List<People> getClassForParrent(int id)
        {
            List<People> classes = new List<People>();
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            

            SqlCommand command = new SqlCommand("getClassesForParrent", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "@id",
                Value = id
            };
            command.Parameters.Add(sqlParameter);
            try
            {
                sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        People p = new People();
                        p.nameClass = (sqlDataReader["Название"].ToString());
                        p.LastName = (sqlDataReader["фамилия"].ToString());
                        p.Name = (sqlDataReader["имя"].ToString());
                        p.FatherName = (sqlDataReader["отчество"].ToString());
                        p.id = Convert.ToInt32((sqlDataReader["id"].ToString()));
                        p.idClass = Convert.ToInt32((sqlDataReader["idClass"].ToString()));

                        classes.Add(p);

                    }
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return classes;
        }
        public List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();

            sqlConnection.Open();
            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"select * from Person", workWithDB.sqlConnection);

            try
            {
                sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        Person person = new Person();
                        person.Avatar = sqlDataReader["avatar"].ToString();
                        person.Birthday = Convert.ToDateTime(sqlDataReader["Birthday"]);
                        person.FatherName = sqlDataReader["Patronymic"].ToString();
                        person.id = Convert.ToInt32(sqlDataReader["id"]);
                        person.LastName = sqlDataReader["LastName"].ToString();
                        person.Mail = sqlDataReader["[E-mail]"].ToString();
                        person.Name = sqlDataReader["Name"].ToString();
                        person.Number = sqlDataReader["Number"].ToString();
                        person.Position = sqlDataReader["position"].ToString();
                        person.SecretWord = sqlDataReader["[Secret word]"].ToString();
                        person.Sex = sqlDataReader["Sex"].ToString();
                        persons.Add(person);
                    }
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return persons;
        }
        public DataSet GetPeoples(string id, string clas, string fio, int stateS, int stateSOP)
        {
            SqlCommand command = new SqlCommand("GetPeoples", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter
            {
                ParameterName = "@id",
                Value = "%" + id + "%"
            };
            SqlParameter par2 = new SqlParameter
            {
                ParameterName = "@class",
                Value = "%" + clas + "%"
            };
            SqlParameter par3 = new SqlParameter
            {
                ParameterName = "@LastName",
                Value = "%" + fio + "%"
            };
            SqlParameter par4 = new SqlParameter();
            par4.ParameterName = "@Starosta";
            if (stateS == 2) par4.Value = "%";
            else par4.Value = stateS;
            SqlParameter par5 = new SqlParameter();
            par5.ParameterName = "@SOP";
            if (stateSOP == 2) par5.Value = "%";
            else par5.Value = stateS;
            command.Parameters.Add(par1);
            command.Parameters.Add(par2);
            command.Parameters.Add(par3);
            command.Parameters.Add(par4);
            command.Parameters.Add(par5);

            DataSet result = new DataSet();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
               
                adapter.Fill(result);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            return result;
        }
        public DataSet getTable(string tableName)
        {
            DataSet result = new DataSet();
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter($"select * from {tableName}", sqlConnection);
                // Заполняем Dataset
                adapter.Fill(result);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            return result;
        }
        public List<string> getListTables()
        {
            List<string> ListTables = new List<string>();
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"SELECT name FROM sys.objects WHERE type in (N'U') and name != 'sysdiagrams' order by name", workWithDB.sqlConnection);
            try
            {
                sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                   ListTables.Add(sqlDataReader["name"].ToString());
                }
                sqlDataReader.Close();
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                ListTables.Add(ex.Message);
            }


            return ListTables;
        }
        public DataSet getSQLReauest(string sql)
        {
            DataSet result = new DataSet();
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter($"{sql}", sqlConnection);
                // Заполняем Dataset
                    adapter.Fill(result);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            return result;
        }
        public DataSet getActivist()
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("Activist", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            return result;
        }

        public DataSet getBestPeoples()
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getBestPeoples", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            return result;
        }
        public DataSet getLaggingPeoples(DateTime from, DateTime to)
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getLaggingPeoples", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter
            {
                ParameterName = "@dateFrom",
                Value = from
            };
            SqlParameter par2 = new SqlParameter
            {
                ParameterName = "@dateTo",
                Value = to
            };
            command.Parameters.Add(par1);
            command.Parameters.Add(par2);
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            return result;
        }
        public DataSet getTimeTable(string id, string clas, string kab, string day, string from, string to, string subj, string teacher)
        {
            SqlCommand command = new SqlCommand("getTimeTable", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter
            {
                ParameterName = "@id",
                Value = (id == "") ? "%" : id 
            };
            SqlParameter par2 = new SqlParameter
            {
                ParameterName = "@class",
                Value = "%" + clas + "%"
            };
            SqlParameter par3 = new SqlParameter
            {
                ParameterName = "@kabinet",
                Value = "%" + kab + "%"
            };
            SqlParameter par4 = new SqlParameter
            {
                ParameterName = "@day",
                Value = "%" + day + "%"
            };
            SqlParameter par5 = new SqlParameter();
            par5.ParameterName = "@from";
            if (from == "") par5.Value = "1";
            else par5.Value = from;
            SqlParameter par6 = new SqlParameter();
            par6.ParameterName = "@to";
            if (to == "") par6.Value = "7";
            else par6.Value = to;
            SqlParameter par7 = new SqlParameter
            {
                ParameterName = "@subject",
                Value = "%" + subj + "%"
            };
            SqlParameter par8 = new SqlParameter
            {
                ParameterName = "@teacher",
                Value = "%" + teacher + "%"
            };
            command.Parameters.Add(par1);
            command.Parameters.Add(par2);
            command.Parameters.Add(par3);
            command.Parameters.Add(par4);
            command.Parameters.Add(par5);
            command.Parameters.Add(par6);
            command.Parameters.Add(par7);
            command.Parameters.Add(par8);
            DataSet result = new DataSet();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(result);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            return result;
        }
        public DataSet getJournal(string id, string clas, string sub, string people, string teacher, DateTime timeFrom, DateTime timeTo, 
            string markFrom, string markTo, string idOfPeople)
        {
            SqlCommand command = new SqlCommand("getMarkForPeople", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter
            {
                ParameterName = "@id",
                Value = (id == "") ? "%" : id
            };
            SqlParameter par2 = new SqlParameter
            {
                ParameterName = "@idClass",
                Value = "%" + clas + "%"
            };
            SqlParameter par3 = new SqlParameter
            {
                ParameterName = "@idScObj",
                Value = "%" + sub + "%"
            };
            SqlParameter par4 = new SqlParameter
            {
                ParameterName = "@LnameStudier",
                Value = "%" + people + "%"
            };
            SqlParameter par5 = new SqlParameter
            {
                ParameterName = "@LnameTeacher",
                Value = "%" + teacher + "%"
            };
            SqlParameter par6 = new SqlParameter
            {
                ParameterName = "@dateFrom",
                Value = timeFrom
            };
            SqlParameter par7 = new SqlParameter
            {
                ParameterName = "@dateTo",
                Value = timeTo
            };
            SqlParameter par8 = new SqlParameter
            {
                ParameterName = "@markFron",
                Value = (markFrom == "") ? "1" : markFrom
            };
            SqlParameter par9 = new SqlParameter
            {
                ParameterName = "@markTo",
                Value = (markTo == "") ? "10" : markTo
            };
            SqlParameter par10 = new SqlParameter
            {
                ParameterName = "@idOfPeople",
                Value = (idOfPeople == "") ? "%" : idOfPeople
            };
            command.Parameters.Add(par1);
            command.Parameters.Add(par2);
            command.Parameters.Add(par3);
            command.Parameters.Add(par4);
            command.Parameters.Add(par5);
            command.Parameters.Add(par6);
            command.Parameters.Add(par7);
            command.Parameters.Add(par8);
            command.Parameters.Add(par9);
            command.Parameters.Add(par10);
            DataSet result = new DataSet();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(result);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }

            return result;
        }
        public string getStudent(int id)
        {
            string peopleFIO = "";
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"select Person.LastName + ' ' + SUBSTRING(Person.Name, 1, 1) + '. ' + SUBSTRING(Person.Patronymic, 1, 1)  + '.' as FIO from Журнал " +
                                                $"inner join Person on Person.id = Журнал.[Код ученика] " +
                                                $"where id = '{id}'", workWithDB.sqlConnection);
            try
            {
                sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    peopleFIO = sqlDataReader["FIO"].ToString();
                }
                sqlDataReader.Close();
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                peopleFIO = ex.Message;
            }

            return peopleFIO;
        }
    }
}
