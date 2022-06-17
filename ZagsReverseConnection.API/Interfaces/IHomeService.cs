using Microsoft.AspNetCore.Mvc;
using ZagsReverseConnection.API.Models;

namespace ZagsReverseConnection.API.Interfaces
{
    public interface IHomeService
    {
        Task<string> PostFamilyAsync(object family);
        GetFamilyModel GetFamily(string PinFL);

    }
}
