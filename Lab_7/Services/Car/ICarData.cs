namespace PPPI.Services.Car
{
    public interface ICarData
    {
        Task<String> Get(int id);
        Task<String> GetAll();
        Task Post(string mark, string model, string serie);
        Task Put(int id, string mark, string model, string serie);
        Task Delete(int id);
        string forAllList();
    }
}
