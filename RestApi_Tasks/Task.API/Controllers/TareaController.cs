using Microsoft.AspNetCore.Mvc;
using Task.BLL.Interfaces;
using Task.DTO;
using Task.DAL;
using Task.Models;
using Microsoft.EntityFrameworkCore;
using Task.DAL.Interfaces;

namespace Task.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly IServiceTarea _serviceTarea;

        public TareaController(IServiceTarea serviceTarea)
        {
            _serviceTarea = serviceTarea;
        }

        [HttpGet]
        public async Task<IQueryable<Tarea>> GetTareas()
        {
            var listaTareas = await _serviceTarea.GetAll();
            return listaTareas;
        }
    }
}
