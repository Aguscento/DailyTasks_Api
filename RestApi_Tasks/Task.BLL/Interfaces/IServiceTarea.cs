using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DTO;

namespace Task.BLL.Interfaces
{
    public interface IServiceTarea
    {
        Task<List<TareaDTO>> GetAll();
    }
}
