using Domain.Models;
using Repository.Data;
using Repository.Exceptions;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;


namespace Repository.Repositories
{
    public class LibraryRepository : IRepository<Library>
    {

        public void Create(Library data)
        {
            try
            {
                if (data is null) throw new NotFoundException("Data not found");

                AddDbContext<Library>.datas.Add(data);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }  
        }

        public void Delete(Library data)
        {
            AddDbContext<Library>.datas.Remove(data);
        }

        public Library Get(Predicate<Library> predicate)
        {
            return predicate != null ? AddDbContext<Library>.datas.Find(predicate) : null;
        }

        public List<Library> GetAll(Predicate<Library> predicate = null)
        {
            return predicate != null ? AddDbContext<Library>.datas.FindAll(predicate) : AddDbContext<Library>.datas;
        }

        public void Update(Library data)
        {
            Library library = Get(m => m.Id == data.Id);
            if(!string.IsNullOrEmpty(data.Name))
                library.Name = data.Name;

            if (data.SeatCount != null)
                library.SeatCount = data.SeatCount;


        }
    }
}
