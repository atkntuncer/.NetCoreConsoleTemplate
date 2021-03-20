using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreConsoleTemplate
{
    public interface IDataAccess
    {
        bool Create(string sqlQuery, DynamicParameters param);
        Task<bool> CreateAsync(string sqlQuery, DynamicParameters param);
        bool Delete(string sqlQuery, DynamicParameters param);
        Task<bool> DeleteAsync(string sqlQuery, DynamicParameters param);
        IEnumerable<T> Read<T>(string sqlQuery);
        Task<IEnumerable<T>> ReadAsync<T>(string sqlQuery);
        IEnumerable<T> ReadWithParamater<T>(string sqlQuery, DynamicParameters param);
        Task<IEnumerable<T>> ReadWithParamaterAsync<T>(string sqlQuery, DynamicParameters param);
        bool Update(string sqlQuery, DynamicParameters param);
        Task<bool> UpdateAsync(string sqlQuery, DynamicParameters param);
    }
}