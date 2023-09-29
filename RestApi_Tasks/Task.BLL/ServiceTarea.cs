using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BLL.Interfaces;
using Task.DAL;
using Task.DAL.Interfaces;
using Task.DTO;
using Task.Models;
using AutoMapper;


namespace Task.BLL
{
    public class ServiceTarea : IServiceTarea
    {
        private readonly IRepository<Tarea> _repository;
        private readonly IMapper _mapper;

        public ServiceTarea(IRepository<Tarea> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TareaDTO>> GetAll()
        {
                List<Tarea> listaTareas = (List<Tarea>)await _repository.Query();
                return _mapper.Map<List<TareaDTO>>(listaTareas);

        }
    }
}
