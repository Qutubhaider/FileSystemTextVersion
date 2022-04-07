using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemBAL.Repository.IRepository
{
    public interface ITextTranferRepository
    {
        public void saveRecord(TextTransferRecord.Models.TextTransferRecord textTransferRecord, out int inSuccess);
        public List<TextTransferRecord.Models.TextTransferRecord> GetTextTransferRecords(int inDeskAdminId); 
    }
}
