using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPracticePerson.Data
{
    public interface IDapper : IDisposable
    {
        IDbConnection GetConnection();
       Task<int> CreateAsync<T> (string query, DynamicParameters pars,CommandType cmdType = CommandType.StoredProcedure );
        Task<T> UpdateAsync<T>(string query, DynamicParameters pars, CommandType cmdType = CommandType.StoredProcedure);

        Task<T> DeleteAsync<T>(string query, DynamicParameters pars, CommandType cmdType = CommandType.StoredProcedure);

        Task<IEnumerable<T>> GetAllAsync<T>(string query, DynamicParameters pars, CommandType cmdType = CommandType.StoredProcedure);

        Task<T> GetAsync<T>(string query, DynamicParameters pars, CommandType cmdType = CommandType.StoredProcedure);






    }

}
