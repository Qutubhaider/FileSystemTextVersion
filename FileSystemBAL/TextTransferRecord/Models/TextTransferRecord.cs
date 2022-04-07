using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemBAL.TextTransferRecord.Models
{
    public class TextTransferRecord
    {
  public int inTextTransferRecordId  { get; set; }
  public Guid unTextTransferRecordId { get; set; }
  public DateTime dtLastTransferDate { get; set; }
  public int inFromUser { get; set; }			   
  public int inToUser { get; set; }		
  public int inTextId { get; set; }		
  public int inStatus { get; set; }		
  public int inDeskAdminId { get; set; }
  public string stComment { get; set; }
    }
}
