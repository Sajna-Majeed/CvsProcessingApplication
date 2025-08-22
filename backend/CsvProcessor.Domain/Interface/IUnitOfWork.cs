using CsvProcessor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProcessor.Domain.Interface
{

    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<CsvFile> FileProcesses { get; }
        IRepository<CsvRow> CsvRows { get; }
        Task<int> SaveChangesAsync();
    }

}
