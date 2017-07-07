using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace testInterfaces.Design_Patterns.Behavioral
{
    #region Sample code
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    public abstract class AbstractClassTemplate
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        // The "Template method"
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class ConcreteClassA : AbstractClassTemplate
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class ConcreteClassB : AbstractClassTemplate
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }
    #endregion

    #region Implementation code
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;
        protected SQLiteConnection m_dbConnection;

        public virtual void Connect()
        {
            // Switched to sqlite
            //connectionString ="provider=Microsoft.JET.OLEDB.4.0; data source=..\\..\\..\\db1.sqlite";
            if (!File.Exists("db1.sqlite"))
            {
                SQLiteConnection.CreateFile("db1.sqlite");
                m_dbConnection = new SQLiteConnection("Data Source=db1.sqlite;Version=3;");
                m_dbConnection.Open();
                var sql = "create table Categories (CategoryName varchar(20))";
                var sql2 = "create table Products (ProductName varchar(20))";
                var command = new SQLiteCommand(sql, m_dbConnection);
                var command2 = new SQLiteCommand(sql2, m_dbConnection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                var sqlLines = "INSERT INTO Categories (CategoryName) VALUES ('testCat1'),('testCat2'),('testCat3');";
                var sqlLines2 = "INSERT INTO Products (ProductName) VALUES ('testProd1'),('testProd2'),('testProd2');";
                var lcommand = new SQLiteCommand(sqlLines, m_dbConnection);
                var lcommand2 = new SQLiteCommand(sqlLines2, m_dbConnection);
                lcommand.ExecuteNonQuery();
                lcommand2.ExecuteNonQuery();
            }
            m_dbConnection = new SQLiteConnection("Data Source=db1.sqlite;Version=3;");
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method'
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Categories : DataAccessObject
    {
        public override void Select()
        {
            const string sql = "select CategoryName from Categories";
            dataSet = new DataSet();
            var dap = new SQLiteDataAdapter(sql, m_dbConnection);
            dap.Fill(dataSet, "Categories");
        }

        public override void Process()
        {
            Console.WriteLine("Categories ---- ");

            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }
    }
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Products : DataAccessObject
    {
        public override void Select()
        {
            const string sql = "select ProductName from Products";
            dataSet = new DataSet();
            var dap = new SQLiteDataAdapter(sql, m_dbConnection);
            dap.Fill(dataSet, "Products");
        }

        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            DataTable dataTable = dataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }
            Console.WriteLine();
        }
    }
    #endregion
}

