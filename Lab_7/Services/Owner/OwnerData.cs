namespace PPPI.Services.Owner
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using PPPI.Models;
    using System;
    using System.Xml.Linq;

    public class OwnerData : IOwnerData
    {
        public List<Owner> ownersList = new List<Owner>()
        {
            new Owner() {Name = "John", Surname = "Smith", Age = "30"},
            new Owner() {Name = "Emma", Surname = "Johnson", Age = "27"},
            new Owner() {Name = "Michael", Surname = "Williams", Age = "21"},
            new Owner() {Name = "Olivia", Surname = "Brown", Age = "35"},
            new Owner() {Name = "William", Surname = "Jones", Age = "25"},
            new Owner() {Name = "Ava", Surname = "Davis", Age = "45"},
            new Owner() {Name = "James", Surname = "Miller", Age = "31"},
            new Owner() {Name = "Sophia", Surname = "Wilson", Age = "26"},
            new Owner() {Name = "Benjamin", Surname = "Anderson", Age = "42"},
            new Owner() {Name = "Mia", Surname = "Taylor", Age = "33"}
        };

        async public Task Delete(int id)
        {
            try
            {
                await Task.Run(() => ownersList.RemoveAt(id));
            }
            catch (IndexOutOfRangeException)
            {
                //await Task.Run(() => Results.StatusCode(404));
            }
            catch
            {
                //await Task.Run(() => Results.StatusCode(400));
            }
        }

        async public Task<String> Get(int id)
        {
            string value = "";
            try
            {
                value = await Task.Run(() => ownersList[id].ToString());
            }
            catch (IndexOutOfRangeException)
            {
                //await Task.Run(() => Results.StatusCode(404));
            }
            catch
            {
                //await Task.Run(() => Results.StatusCode(400));
            }
            return value;
        }

        async public Task<string> GetAll()
        {
            string value = "";
            try
            {
                value = await Task.Run(() => forAllList());
            }
            catch (IndexOutOfRangeException)
            {
                //await Task.Run(() => Results.StatusCode(404));
            }
            catch
            {
                //await Task.Run(() => Results.StatusCode(400));
            }
            return value;
        }

        public string forAllList()
        {
            string value = "";
            foreach (Owner owner in ownersList)
            {
                value += owner.ToString() + "\n";
            }
            return value;
        }

        async public Task Post(string name, string surname, string age)
        {
            try
            {
                await Task.Run(() => ownersList.Add(new Owner()
                {
                    Name = name,
                    Surname = surname,
                    Age = age
                })
                );
            }
            catch (Exception)
            {
                //await Task.Run(() => Results.StatusCode(400));
            }
        }

        async public Task Put(int id, string name, string surname, string age)
        {
            try
            {
                await Task.Run(() => ownersList[id] = new Owner()
                {
                    Name = name,
                    Surname = surname,
                    Age = age
                }
                );
            }
            catch (IndexOutOfRangeException)
            {
                //await Task.Run(() => Results.StatusCode(404));
            }
            catch
            {
                //await Task.Run(() => Results.StatusCode(400));
            }
        }
    }
}
