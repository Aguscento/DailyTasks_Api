﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DTO;
using Task.Models;

namespace Task.BLL.Interfaces
{
    public interface IServiceTarea
    {
        Task<IQueryable<Tarea>> GetAll();
    }
}
