using FileSystemBAL.Data;
using FileSystemBAL.Repository.IRepository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemBAL.Repository
{
    public class TextTranserferRepository : ITextTranferRepository
    {
        private readonly DatabaseContext moDatabaseContext;
        public TextTranserferRepository(DatabaseContext foDatabaseContext)
        {
            moDatabaseContext = foDatabaseContext;
        }
        public List<TextTransferRecord.Models.TextTransferRecord> GetTextTransferRecords(int inDeskAdminId)
        {
            return moDatabaseContext.Set<TextTransferRecord.Models.TextTransferRecord>().FromSqlInterpolated($"EXEC getTextTransferRecords @inDeskAdminId ={inDeskAdminId}").AsEnumerable().ToList();
        }

        public void saveRecord(TextTransferRecord.Models.TextTransferRecord textTransferRecord, out int inSuccess)
        {
            SqlParameter loSuccess = new SqlParameter("@inSuccess", SqlDbType.Int) { Direction = ParameterDirection.Output };
            moDatabaseContext.Database.ExecuteSqlInterpolated($"EXEC saveTextTransferRecord @inFromUser={textTransferRecord.inFromUser},@inToUser={textTransferRecord.inToUser},@inTextId={textTransferRecord.inTextId},@inStatus={textTransferRecord.inStatus},@inDeskAdminId={textTransferRecord.inDeskAdminId},@stComment={textTransferRecord.stComment},@inSuccess={loSuccess} OUT");
            inSuccess = Convert.ToInt32(loSuccess.Value);
        }
    }
}
