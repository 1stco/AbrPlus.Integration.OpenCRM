namespace AbrPlus.Integration.OpenCRM.Client
{
    public interface ICallStoreApiClient : ICallStoreApi
    {
        string CallStoreId { get; }
        string CallStoreName { get; }
    }
}
