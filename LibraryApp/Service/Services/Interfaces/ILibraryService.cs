using Domain.Models;
using System.Collections.Generic;

namespace Service.Services.Interfaces
{
    public interface ILibraryService
    {
        Library Create(Library library);

        Library Update(int id, Library library);
        void Delete(int id);
        Library GetById(int id);

        List<Library> GetAll();
        List<Library> Search(string search);

    }
}
