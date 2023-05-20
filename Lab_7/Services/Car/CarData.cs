namespace PPPI.Services.Car
{
    using PPPI.Models;
    using System;

    public class CarData : ICarData
    {
        public List<Car> carList = new List<Car>()
        {
            new Car() {Mark = "Toyota", Model = "Camry", Serie = "XV70"},
            new Car() {Mark = "Ford", Model = "Mustang", Serie = "GT"},
            new Car() {Mark = "BMW", Model = "3 Series", Serie = "G20"},
            new Car() {Mark = "Mercedes", Model = "C-Class", Serie = "W205"},
            new Car() {Mark = "Audi", Model = "A4", Serie = "B9"},
            new Car() {Mark = "Honda", Model = "Civic", Serie = "FC"},
            new Car() {Mark = "Volkswagen", Model = "Golf", Serie = "Mk7"},
            new Car() {Mark = "Chevrolet", Model = "Corvette", Serie = "C8"},
            new Car() {Mark = "Subaru", Model = "Impreza", Serie = "XV"},
            new Car() {Mark = "Porsche", Model = "911", Serie = "992"}
        };

        async public Task Delete(int id)
        {
            try{
                await Task.Run(() => carList.RemoveAt(id));
            }
            catch(IndexOutOfRangeException)
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
                value = await Task.Run(() => carList[id].ToString()); 
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
            foreach(Car car in carList)
            {
                value += car.ToString() + "\n";
            }
            return value;
        }

        async public Task Post(string mark, string model, string serie)
        {
            try
            {
                await Task.Run(() => carList.Add(new Car()
                {
                    Mark = mark, Model = model, Serie = serie
                })
                );
            }
            catch (Exception)
            {
                //await Task.Run(() => Results.StatusCode(400));
            }
        }

        async public Task Put(int id, string mark, string model, string serie)
        {
            try
            {
                await Task.Run(() => carList[id] = new Car()
                {
                    Mark = mark, Model = model, Serie = serie
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
