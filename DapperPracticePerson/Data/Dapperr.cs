using Dapper;
using DapperPracticePerson.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPracticePerson.Data
{
    internal class Dapperr : IDapper
    {
        public  async Task<int> CreateAsync<T>(string query, DynamicParameters pars, CommandType cmdType = CommandType.StoredProcedure)
        {
            IDbConnection db = GetConnection();

           return await db.ExecuteAsync(query,param:  pars, commandType: cmdType);

        }

        public Task<T> DeleteAsync<T>(string query, DynamicParameters pars, CommandType cmdType = CommandType.StoredProcedure)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(string query, DynamicParameters pars, CommandType cmdType = CommandType.StoredProcedure)
        {
            IDbConnection db = GetConnection();

            IEnumerable<T> results = await db.QueryAsync<T>(query, param: pars, commandType: cmdType);

            return results;
        }

        public async Task<T> GetAsync<T>(string query, DynamicParameters pars, CommandType cmdType = CommandType.StoredProcedure)
        {
            IDbConnection db = GetConnection();

           T result = (await db.QueryAsync<T>(query, param: pars, commandType: cmdType)).FirstOrDefault();

            return result;
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(Constants.DATAPATH);
        }

        public Task<T> UpdateAsync<T>(string query, DynamicParameters pars, CommandType cmdType = CommandType.StoredProcedure)
        {
            throw new NotImplementedException();
        }
    }
}
