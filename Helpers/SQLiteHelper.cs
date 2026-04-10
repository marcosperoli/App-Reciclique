using AppReciclique.Models;
using SQLite;

namespace AppReciclique.Helpers
{
    public class SQLiteHelper
    {
        private SQLiteAsyncConnection database;

        public SQLiteHelper(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Agendamento>().Wait();
        }

        public async Task<int> SalvarAgendamento(Agendamento agendamento)
        {
            return await database.InsertAsync(agendamento);
        }

        public async Task<Agendamento> ObterUltimoAgendamento()
        {
            return await database.Table<Agendamento>()
                           .OrderByDescending(x => x.Id)
                           .FirstOrDefaultAsync();
        }

        public async Task<List<Agendamento>> ListarAgendamentos()
        {
            return await database.Table<Agendamento>()
                           .OrderByDescending(x => x.Id)
                           .ToListAsync();
        }
    }
}
