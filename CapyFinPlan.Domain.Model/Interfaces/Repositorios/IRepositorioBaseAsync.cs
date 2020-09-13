using CapyFinPlan.Domain.Model.Modelos;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapyFinPlan.Domain.Model.Interfaces.Repositorios
{
    public interface IRepositorioBaseAsync<T>
        where T : Entidade
    {
        Task<T> AddItemAsync(T item);

        Task<T> GetItemAsync(Guid id);

        Task<IEnumerable<T>> GetAllItemsAsync();

        T UpdateItem(Guid id, T item);

        void DeleteItem(T item);
    }
}