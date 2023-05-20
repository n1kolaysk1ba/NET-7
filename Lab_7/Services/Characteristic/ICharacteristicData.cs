namespace PPPI.Services.Characteristic
{
    public interface ICharacteristicData
    {
        Task<String> Get(int id);
        Task<String> GetAll();
        Task Post(string torque, string engineCapacity, string hp);
        Task Put(int id, string torque, string engineCapacity, string hp);
        Task Delete(int id);
        string forAllList();
    }
}
