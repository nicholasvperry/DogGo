using DogGo2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace DogGo2.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private readonly IConfiguration _config;

        // The constructor accepts an IConfiguration object as a parameter. This class comes from the ASP.NET framework and is useful for retrieving things out of the appsettings.json file like connection strings.
        public WalkRepository(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public List<Walks> GetAllWalks()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT Id, Date, Duration, WalkerId, DogId
                        FROM Walks
                    ";

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Walks> walks = new List<Walks>();
                    while (reader.Read())
                    {
                        Walks walk = new Walks
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                            Duration = reader.GetInt32(reader.GetOrdinal("ImageUrl")),
                            WalkerId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                            DogId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId"))
                        };

                        walks.Add(walk);
                    }

                    reader.Close();

                    return walks;
                }
            }
        }

        public Walks GetWalkById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Walks> GetWalksByWalkerId(int walkerId)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                SELECT w.Id, w.Date, w.Duration, w.WalkerId, w.DogId,
                wr.Name as WalkerName, wr.ImageUrl, wr.NeighborhoodId,
                n.Name NeighborhoodName,
                d.Id as DogId, d.Breed, d.Name as DogName,
                o.Id as OwnerID, o.Email, o.Name as OwnerName, o.Address, o.Phone
                FROM Walks w
                LEFT JOIN Walker wr on w.WalkerId = wr.Id
                LEFT JOIN Neighborhood n on wr.NeighborhoodId = n.Id
                LEFT JOIN Dog d on w.DogId = d.Id
                LEFT JOIN Owner o on d.OwnerId = o.Id
                WHERE WalkerId = @walkerId
            ";

                    cmd.Parameters.AddWithValue("@walkerId", walkerId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Walks> walks = new List<Walks>();
                    while (reader.Read())
                    {
                        Walks walk = new Walks()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                            Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                            WalkerId = reader.GetInt32(reader.GetOrdinal("WalkerId")),
                            DogId = reader.GetInt32(reader.GetOrdinal("DogId")),

                            Walker = new Walker()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("WalkerId")),
                                Name = reader.GetString(reader.GetOrdinal("WalkerName")),
                                ImageUrl = reader.GetString(reader.GetOrdinal("ImageUrl")),

                                Neighborhood = new Neighborhood()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                                    Name = reader.GetString(reader.GetOrdinal("NeighborhoodName"))
                                }
                            },
                            Dog = new Dog()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("DogId")),
                                Name = reader.GetString(reader.GetOrdinal("DogName")),
                                Breed = reader.GetString(reader.GetOrdinal("Breed")),

                                Owner = new Owner()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("OwnerId")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Name = reader.GetString(reader.GetOrdinal("OwnerName")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    NeighborhoodId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                                    Phone = reader.GetString(reader.GetOrdinal("Phone"))
                                }
                            }
                        };

                        walks.Add(walk);
                    }

                    reader.Close();
                    return walks;
                }
            }
        }
    }
}
