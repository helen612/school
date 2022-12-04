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
        //public static string connectionString = @"Data Source=ALENA-PC\SQLEXPRESS;Initial Catalog=1;Integrated Security=True";
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
                

            }
            catch (Exception ex)
            {
                somePerson.username = ex.Message;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
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
                

            }
            catch (Exception ex)
            {
                classOfPeople = ex.Message;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
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
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlDataReader.Close();
            sqlConnection.Close(); 
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
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlDataReader.Close();
            sqlConnection.Close(); 
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
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
                

            }
            catch (Exception ex)
            {
                ListTables.Add(ex.Message);
            }

            sqlDataReader.Close();
            sqlConnection.Close();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();

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

            }
            catch (Exception ex)
            {
                peopleFIO = ex.Message;
            }
            sqlDataReader.Close();
            sqlConnection.Close();

            return peopleFIO;
        }
        public DataSet getEmployers(string id, string fio, string pos, DateTime date, int ProfM)
        {
            SqlCommand command = new SqlCommand("getEmploers", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter
            {
                ParameterName = "@id",
                Value = (id == "") ? "%" : id
            };
            SqlParameter par2 = new SqlParameter
            {
                ParameterName = "@fio",
                Value = "%" + fio + "%"
            };
            SqlParameter par3 = new SqlParameter
            {
                ParameterName = "@pos",
                Value = "%" + pos + "%"
            };
            SqlParameter par4 = new SqlParameter
            {
                ParameterName = "@date",
                Value = date
            };
            SqlParameter par6 = new SqlParameter
            {
                ParameterName = "@ProfS",
                Value = (ProfM == 2) ? "%" : ProfM
            };
            command.Parameters.Add(par1);
            command.Parameters.Add(par2);
            command.Parameters.Add(par3);
            command.Parameters.Add(par4);
            command.Parameters.Add(par6);
            DataSet result = new DataSet();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();

            return result;
        }
        public DataSet GetExpEmpl()
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("BigExp", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
            return result;
        }
        public DataSet GetMonfeeders()
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getMonfeeders", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
            return result;
        }
        public DataSet getCLassRuk()
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getCLassRuk", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
            return result;
        }
        public DataSet getClasses()
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getClasses", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
            return result;
        }
        public int addStudier(RegStudier studier)
        {
            SqlCommand command = new SqlCommand("addStudier", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            
            int result = -1;
            try
            {
                SqlParameter p1 = new SqlParameter("@username", studier.username);
                SqlParameter p2 = new SqlParameter("@password", studier.password);
                SqlParameter p3 = new SqlParameter("@level", "1");
                SqlParameter p4 = new SqlParameter("@lastName", studier.LastName);
                SqlParameter p5 = new SqlParameter("@name", studier.Name);
                SqlParameter p6 = new SqlParameter("@FatherName", studier.FatherName);
                SqlParameter p7 = new SqlParameter("@sex", studier.Sex);
                SqlParameter p8 = new SqlParameter("@birthday", studier.Birthday);
                SqlParameter p9 = new SqlParameter("@number", studier.Number);
                SqlParameter p10 = new SqlParameter("@mail", studier.Mail);
                SqlParameter p11 = new SqlParameter("@position", studier.Position);
                SqlParameter p12 = new SqlParameter("@secretword", studier.SecretWord);
                SqlParameter p13 = new SqlParameter("@idclass", studier.idclass);
                SqlParameter p14 = new SqlParameter("@adress", studier.adress);
                SqlParameter p15 = new SqlParameter("@starosta", Convert.ToInt32(studier.starosta));
                SqlParameter p16 = new SqlParameter("@SOP", Convert.ToInt32(studier.SOP));
                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output // параметр выходной
                };

                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);
                command.Parameters.Add(p6);
                command.Parameters.Add(p7);
                command.Parameters.Add(p8);
                command.Parameters.Add(p9);
                command.Parameters.Add(p10);
                command.Parameters.Add(p11);
                command.Parameters.Add(p12);
                command.Parameters.Add(p13);
                command.Parameters.Add(p14);
                command.Parameters.Add(p15);
                command.Parameters.Add(p16);
                command.Parameters.Add(id);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = Convert.ToInt32(command.Parameters["@id"].Value);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = -1;
            }
            sqlConnection.Close();
            return result;
        }
        public void removeUser(int id)
        {
            SqlCommand command = new SqlCommand($"delete from LogIn where id = {id}", workWithDB.sqlConnection);

            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
        public void removeSomethink(int id, string tableName, string columnName)
        {
            SqlCommand command = new SqlCommand($"delete from [{tableName}] where [{columnName}] = {id}", workWithDB.sqlConnection);

            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
        public bool addRelationships(string idParent, string idPeople)
        {
            bool result = false;
            SqlCommand command = new SqlCommand($"AddRelationship", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@idPeople", idPeople);
                SqlParameter p2 = new SqlParameter("@idParent", idParent);
                command.Parameters.Add(p1);
                command.Parameters.Add(p2);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
            return result;
        }
        public bool editStudent(People p)
        {
            bool result = false;
            SqlCommand command = new SqlCommand($"editStudent", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@id", p.id);
                SqlParameter p2 = new SqlParameter("@nameClass", p.nameClass );
                SqlParameter p3 = new SqlParameter("@Lname", p.LastName);
                SqlParameter p4 = new SqlParameter("@Name", p.Name);
                SqlParameter p5 = new SqlParameter("@FatherName", p.FatherName);
                SqlParameter p6 = new SqlParameter("@adress", p.address);
                SqlParameter p7 = new SqlParameter("@starosta", p.starosta);
                SqlParameter p8 = new SqlParameter("@sop", p.SOP);
                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);
                command.Parameters.Add(p6);
                command.Parameters.Add(p7);
                command.Parameters.Add(p8);

                sqlConnection.Open();
                command.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
            return result;
        }
        public DataSet getParents(string id, string work, string clas, string  People, string parent)
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getParents", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter
            {
                ParameterName = "@id",
                Value = (id == "") ? "%" : id
            };
            SqlParameter par2 = new SqlParameter
            {
                ParameterName = "@work",
                Value = "%" + work + "%"
            };
            SqlParameter par3 = new SqlParameter
            {
                ParameterName = "@nameClass",
                Value = "%" + clas + "%"
            };
            SqlParameter par4 = new SqlParameter
            {
                ParameterName = "@FIOStudier",
                Value = "%" + People + "%"
            };
            SqlParameter par6 = new SqlParameter
            {
                ParameterName = "@FIOParent",
                Value = "%" + parent + "%"
            };
            command.Parameters.Add(par1);
            command.Parameters.Add(par2);
            command.Parameters.Add(par3);
            command.Parameters.Add(par4);
            command.Parameters.Add(par6);
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
            return result;
        }
        public DataSet getParentsWitoutConnection()
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getParentsWitoutConnection", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
            return result;
        }
        public DataSet getLargeFamily()
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getLargeFamily", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();
            return result;
        }
        public int addParent(Parents parent)
        {
            SqlCommand command = new SqlCommand("addParent", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            int result = -1;
            try
            {
                SqlParameter p1 = new SqlParameter("@username", parent.username);
                SqlParameter p2 = new SqlParameter("@password", parent.password);
                SqlParameter p3 = new SqlParameter("@level", "2");
                SqlParameter p4 = new SqlParameter("@lastName", parent.LastName);
                SqlParameter p5 = new SqlParameter("@name", parent.Name);
                SqlParameter p6 = new SqlParameter("@FatherName", parent.FatherName);
                SqlParameter p7 = new SqlParameter("@sex", parent.Sex);
                SqlParameter p8 = new SqlParameter("@birthday", parent.Birthday);
                SqlParameter p9 = new SqlParameter("@number", parent.Number);
                SqlParameter p10 = new SqlParameter("@mail", parent.Mail);
                SqlParameter p11 = new SqlParameter("@position", "Родитель");
                SqlParameter p12 = new SqlParameter("@secretword", parent.SecretWord);
                SqlParameter p13 = new SqlParameter("@work", parent.work);
                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output // параметр выходной
                };

                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);
                command.Parameters.Add(p6);
                command.Parameters.Add(p7);
                command.Parameters.Add(p8);
                command.Parameters.Add(p9);
                command.Parameters.Add(p10);
                command.Parameters.Add(p11);
                command.Parameters.Add(p12);
                command.Parameters.Add(p13);
                command.Parameters.Add(id);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = Convert.ToInt32(command.Parameters["@id"].Value);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = -1;
            }
            sqlConnection.Close();
            return result;
        }
        public void removeConnection(string idParent, string idPeople)
        {
            SqlCommand command = new SqlCommand("removeConnection", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@idParent", idParent);
            SqlParameter p2 = new SqlParameter("@idPeople", idPeople);
            command.Parameters.Add(p1);
            command.Parameters.Add(p2);
            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
        public bool editParent(Parents p)
        {
            bool result = false;
            SqlCommand command = new SqlCommand($"editParent", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@id", p.id);
                SqlParameter p2 = new SqlParameter("@LastName", p.LastName);
                SqlParameter p3 = new SqlParameter("@name", p.Name);
                SqlParameter p4 = new SqlParameter("@fatherName", p.FatherName);
                SqlParameter p5 = new SqlParameter("@work", p.work);
                SqlParameter p6 = new SqlParameter("@number", p.Number);
                SqlParameter p7 = new SqlParameter("@mail", p.Mail);
                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);
                command.Parameters.Add(p6);
                command.Parameters.Add(p7);

                sqlConnection.Open();
                command.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
            return result;
        }
        public bool EditSomethink(string tableName, string keyvalue, string value, Dictionary<string, string> cols)
        {
            bool result = false;

            string sqlcommand = $"Update {tableName} ";
            foreach(var d in cols)
            {
                sqlcommand += $"set {d.Key} = {d.Value} ";
            }
            sqlcommand += $"where {keyvalue} = {value}";



            SqlCommand command = new SqlCommand(sqlcommand, workWithDB.sqlConnection);
            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
            return result;
        }
        public Dictionary<string, string> getPosts()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"getPosts", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    d.Add(sqlDataReader["наименование"].ToString(), sqlDataReader["id"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return d;
        }
        public bool addPost(string idEmployer, string idPost)
        {
            bool result = false;
            SqlCommand command = new SqlCommand($"addPost", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@idEmp", idEmployer);
                SqlParameter p2 = new SqlParameter("@idPost", idPost);
                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                sqlConnection.Open();
                command.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
            return result;
        }
        public bool removePost(string idEmployer, string idPost)
        {
            bool result = false;
            SqlCommand command = new SqlCommand($"removePost", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@idEmp", idEmployer);
                SqlParameter p2 = new SqlParameter("@idPost", idPost);
                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                sqlConnection.Open();
                command.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
            return result;
        }
        public bool addClassRuk(string idClass, string idEmp)
        {
            bool result = false;
            SqlCommand command = new SqlCommand("addClassRuk", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@idclass", idClass);
            SqlParameter p2 = new SqlParameter("@idEmp", idEmp);
            command.Parameters.Add(p1);
            command.Parameters.Add(p2);
            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        public int addEmployer(Employer employer)
        {
            SqlCommand command = new SqlCommand("addEmployer", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            int result = -1;
            try
            {
                SqlParameter p1 = new SqlParameter("@username", employer.username);
                SqlParameter p2 = new SqlParameter("@password", employer.password);
                SqlParameter p3 = new SqlParameter("@level", "3");
                SqlParameter p4 = new SqlParameter("@lastName", employer.LastName);
                SqlParameter p5 = new SqlParameter("@name", employer.Name);
                SqlParameter p6 = new SqlParameter("@FatherName", employer.FatherName);
                SqlParameter p7 = new SqlParameter("@sex", employer.Sex);
                SqlParameter p8 = new SqlParameter("@birthday", employer.Birthday);
                SqlParameter p9 = new SqlParameter("@number", employer.Number);
                SqlParameter p10 = new SqlParameter("@mail", employer.Mail);
                SqlParameter p11 = new SqlParameter("@position", "Сотрудник");
                SqlParameter p12 = new SqlParameter("@secretword", employer.SecretWord);
                SqlParameter p13 = new SqlParameter("@profS", employer.profs);
                SqlParameter p14 = new SqlParameter("@dateofEmp", employer.dateOfEmpl);
                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output // параметр выходной
                };

                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);
                command.Parameters.Add(p6);
                command.Parameters.Add(p7);
                command.Parameters.Add(p8);
                command.Parameters.Add(p9);
                command.Parameters.Add(p10);
                command.Parameters.Add(p11);
                command.Parameters.Add(p12);
                command.Parameters.Add(p13);
                command.Parameters.Add(p14);
                command.Parameters.Add(id);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = Convert.ToInt32(command.Parameters["@id"].Value);
                sqlConnection.Close();
                if (employer.idclass != -1)
                {
                    addClassRuk(employer.idclass.ToString(), result.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = -1;
                sqlConnection.Close();
            }
            
            return result;
        }
        public DataSet getEvents(string name, string place, string id, string timefrom, string timeTo, DateTime dateFrom, DateTime dateTo)
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getEvents", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@name", "%" + name + "%");
            SqlParameter p2 = new SqlParameter("@place", "%" + place + "%");
            SqlParameter p3 = new SqlParameter("@id", (id == "") ? "%" : id);
            SqlParameter p4 = new SqlParameter("@timeFrom", timefrom);
            SqlParameter p5 = new SqlParameter("@timeTo", timeTo);
            SqlParameter p6 = new SqlParameter("@dateFrom", dateFrom);
            SqlParameter p7 = new SqlParameter("@dateTo", dateTo);
            command.Parameters.Add(p1);
            command.Parameters.Add(p2);
            command.Parameters.Add(p3);
            command.Parameters.Add(p4);
            command.Parameters.Add(p5);
            command.Parameters.Add(p6);
            command.Parameters.Add(p7);
            try
            {
                sqlConnection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Заполняем Dataset
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            return result;
        }
        public DataSet getMembersEvent(string id)
        {
            DataSet result = new DataSet();
            SqlCommand command = new SqlCommand("getMembersEvent", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@id", id.ToString());
            command.Parameters.Add(p1);

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

        public Dictionary<string, string> getDays()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"getDays", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    d.Add(sqlDataReader["название"].ToString(), sqlDataReader["Код дня"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return d;
        }
        public Dictionary<string, string> getRings()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"getRings", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    d.Add(sqlDataReader["Номер урока"].ToString(), sqlDataReader["Код звонка"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return d;
        }
        public Dictionary<string, string> getScObjects()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"getScObjects", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    d.Add(sqlDataReader["название предмета"].ToString(), sqlDataReader["Код предмета"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return d;
        }
        public Dictionary<string, string> getCabinets()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand($"getCabinet", workWithDB.sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    d.Add(sqlDataReader["Номер"].ToString(), sqlDataReader["Код кабинета"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return d;
        }
        public bool addTimeTable(string day, string ring, string classname, string Scobject, string idteacher, string cabinet)
        {
            bool result = false;
            SqlCommand command = new SqlCommand("addTimeTable", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@day", day);
                SqlParameter p2 = new SqlParameter("@ring", ring);
                SqlParameter p3 = new SqlParameter("@clas", classname);
                SqlParameter p4 = new SqlParameter("@ScObj", Scobject);
                SqlParameter p5 = new SqlParameter("@idTeach", idteacher);
                SqlParameter p6 = new SqlParameter("@cabinet", cabinet);


                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);
                command.Parameters.Add(p6);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlConnection.Close();
            return result;
        }
        public bool updateTimeTable(string id, string day, string ring, string classname, string Scobject, string idteacher, string cabinet)
        {
            bool result = false;
            SqlCommand command = new SqlCommand("updateTimeTable", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@idDay", day);
                SqlParameter p2 = new SqlParameter("@idRing", ring);
                SqlParameter p3 = new SqlParameter("@idClass", classname);
                SqlParameter p4 = new SqlParameter("@idScObj", Scobject);
                SqlParameter p5 = new SqlParameter("@idTeacher", idteacher);
                SqlParameter p6 = new SqlParameter("@idClassRoom", cabinet);
                SqlParameter p7 = new SqlParameter("@id", id);


                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);
                command.Parameters.Add(p6);
                command.Parameters.Add(p7);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlConnection.Close();
            return result;
        }
        public bool updateMark(string idMark, string newMark)
        {
            bool result = false;

            SqlCommand command = new SqlCommand("updateMark", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@idMark", idMark);
                SqlParameter p2 = new SqlParameter("@newMark", newMark);


                command.Parameters.Add(p1);
                command.Parameters.Add(p2);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlConnection.Close();

            return result;
        }
        public bool addMark(string idStudier, string idScobj, string mark, string idTeacher)
        {
            bool result = false;

            SqlCommand command = new SqlCommand("addMark", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@idStudier", idStudier);
                SqlParameter p2 = new SqlParameter("@idScobj", idScobj);
                SqlParameter p3 = new SqlParameter("@mark", mark);
                SqlParameter p4 = new SqlParameter("@idTeacher", idTeacher);
                SqlParameter p5 = new SqlParameter("@date", DateTime.Now);

                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlConnection.Close();

            return result;
        }
        public bool addEvent(string name, DateTime dt, string time, string len, string place)
        {
            bool result = false;

            SqlCommand command = new SqlCommand("addEvent", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@name", name);
                SqlParameter p2 = new SqlParameter("@dt", dt);
                SqlParameter p3 = new SqlParameter("@time", time);
                SqlParameter p4 = new SqlParameter("@len", len);
                SqlParameter p5 = new SqlParameter("@place", place);


                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlConnection.Close();

            return result;
        }
        public bool updateEvent(string id, string name, string dt, string time, string len, string place)
        {
            bool result = false;

            SqlCommand command = new SqlCommand("updateEvent", workWithDB.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@name", name);
                SqlParameter p2 = new SqlParameter("@dt", dt);
                SqlParameter p3 = new SqlParameter("@time", time);
                SqlParameter p4 = new SqlParameter("@len", len);
                SqlParameter p5 = new SqlParameter("@place", place);
                SqlParameter p6 = new SqlParameter("@id", id);


                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);
                command.Parameters.Add(p4);
                command.Parameters.Add(p5);
                command.Parameters.Add(p6);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlConnection.Close();

            return result;
        }

        public string getFIOPerson(string id)
        {
            string result = "";
            string getFio = $"select Person.LastName + ' ' + SUBSTRING(Person.Name, 1, 1) + '. ' + SUBSTRING(Person.Patronymic, 1,1) as ФИО, " +
                "Person.position as Статус " +
                "from Person " +
                $"where Person.id like {id}";
            SqlCommand command = new SqlCommand(getFio, workWithDB.sqlConnection);
            SqlDataReader sqlDataReader = null;

            try
            {

                sqlConnection.Open();
                sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    result = sqlDataReader["ФИО"].ToString() + " " + sqlDataReader["Статус"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();

            return result;
        }
        public string getNameEvent(string id)
        {
            string result = "";
            string getFio = $"select Мероприятия.название as Мероприятие " +
                "from Мероприятия " +
                $"where Мероприятия.[Код мероприятия] like {id} ";
            SqlCommand command = new SqlCommand(getFio, workWithDB.sqlConnection);
            SqlDataReader sqlDataReader = null;

            try
            {

                sqlConnection.Open();
                sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    result = sqlDataReader["Мероприятие"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = null;
            }
            sqlConnection.Close();

            return result;
        }
        public bool addMemberEvent(int idMember, int idEvent)
        {
            bool result = false;
            SqlCommand command = new SqlCommand($"insert into [Участиники мероприятия] values ({idMember}, {idEvent})", workWithDB.sqlConnection);
            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlConnection.Close();
            return result;
        }
        public bool delMemberEvent(int idMember, int idEvent)
        {
            bool result = false;
            SqlCommand command = new SqlCommand($"delete from [Участиники мероприятия] where [Участиники мероприятия].[Код мероприятия] = {idEvent} and [Участиники мероприятия].[код участника] = {idMember}", workWithDB.sqlConnection);
            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

            sqlConnection.Close();
            return result;
        }
    }

}
