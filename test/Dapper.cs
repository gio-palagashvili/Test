// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml;
using Dapper;
using MySql.Data.MySqlClient;

namespace test
{
    public class Dapper
    {
        private class Customer
        {
            public int CustomerId { get; set; }
            public string FirstName { get; set; }
        }
        public Dapper()
        {
            //SELECT in dapper
            using var db = new MySqlConnection("server=localhost;database=test;uid=root;pwd=''");
            const string sqlQuery = "SELECT * FROM customers";
            var items = db.Query<Customer>(sqlQuery);
        }
    }
}