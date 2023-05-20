namespace PPPI.Services.Characteristic
{
    using PPPI.Models;

    public class CharacteristicData : ICharacteristicData
    {
        public List<Characteristic> characteristicsList = new List<Characteristic>()
        {
           new Characteristic() {Torque = "250", EngineCapacity = "2.5", HP = "203"},
           new Characteristic() {Torque = "529", EngineCapacity = "5.0", HP = "460"},
           new Characteristic() {Torque = "400", EngineCapacity = "2.0", HP = "248"},
           new Characteristic() {Torque = "400", EngineCapacity = "2.0", HP = "255"},
           new Characteristic() {Torque = "400", EngineCapacity = "2.0", HP = "248"},
           new Characteristic() {Torque = "220", EngineCapacity = "1.5", HP = "174"},
           new Characteristic() {Torque = "250", EngineCapacity = "1.5", HP = "147"},
           new Characteristic() {Torque = "637", EngineCapacity = "6.2", HP = "490"},
           new Characteristic() {Torque = "196", EngineCapacity = "2.0", HP = "152"},
           new Characteristic() {Torque = "529", EngineCapacity = "3.0", HP = "443"}
        };

        async public Task Delete(int id)
        {
            try
            {
                await Task.Run(() => characteristicsList.RemoveAt(id));
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
                value = await Task.Run(() => characteristicsList[id].ToString());
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
            foreach (Characteristic characteristic in characteristicsList)
            {
                value += characteristic.ToString() + "\n";
            }
            return value;
        }

        async public Task Post(string torque, string engineCapacity, string hp)
        {
            try
            {
                await Task.Run(() => characteristicsList.Add(new Characteristic()
                {
                    Torque = torque,
                    EngineCapacity = engineCapacity,
                    HP = hp
                })
                );
            }
            catch (Exception)
            {
                //await Task.Run(() => Results.StatusCode(400));
            }
        }

        async public Task Put(int id, string torque, string engineCapacity, string hp)
        {
            try
            {
                await Task.Run(() => characteristicsList[id] = new Characteristic()
                {
                    Torque = torque,
                    EngineCapacity = engineCapacity,
                    HP = hp
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
