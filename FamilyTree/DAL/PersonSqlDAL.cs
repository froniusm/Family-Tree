using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using FamilyTree.Models;
using Dapper;

namespace FamilyTree.DAL
{
    public class PersonSqlDAL : IPersonDAL
    {
        private readonly string connectionString;
        private const string SQL_SavePerson = "INSERT INTO person (firstName, middleInitial, lastName, birthDate, deathDate, isAlive, gender)" +
            "VALUES (@firstName, @middleInitial, @lastName, @birthDate, @deathDate, @isAlive, @gender);";

        public PersonSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SavePerson(Person person)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    conn.Query(SQL_SavePerson, new
                    {
                        firstName = person.FirstName,
                        middleInitial = person.MiddleInitial,
                        lastName = person.LastName,
                        birthDate = person.BirthDate,
                        deathDate = person.DeathDate,
                        isAlive = person.IsAlive,
                        gender = person.Gender,
                    });
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}