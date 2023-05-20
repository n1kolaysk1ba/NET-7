namespace PPPI.Services.Owner
{
    public interface IOwnerData
    {
        Task<String> Get(int id);
        Task<String> GetAll();
        Task Post(string name, string surname, string age);
        Task Put(int id, string name, string surname, string age);
        Task Delete(int id);
        string forAllList();
    }
}
