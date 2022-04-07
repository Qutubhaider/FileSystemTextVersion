using FileSystemBAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemBAL.Repository
{
    public class TextTranserferRepository : ITextTranferRepository
    {
        public List<TextTransferRecord.Models.TextTransferRecord> GetTextTransferRecords(int inDeskAdminId)
        {
            throw new NotImplementedException();
        }

        public void saveRecord(TextTransferRecord.Models.TextTransferRecord textTransferRecord, out int inSuccess)
        {
            throw new NotImplementedException();
        }
    }
}
