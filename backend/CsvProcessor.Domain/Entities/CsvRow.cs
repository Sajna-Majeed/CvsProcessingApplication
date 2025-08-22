using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProcessor.Domain.Entities
{
    public class CsvRow
    {
        public int Id { get; set; }
        public int FileProcessId { get; set; }
        public string Data { get; set; } = string.Empty;
    }
}
