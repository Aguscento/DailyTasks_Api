using Microsoft.AspNetCore.Mvc;
using Task.BLL.Interfaces;
using Task.DTO;
using Task.DAL;
using Task.Models;

namespace Task.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly DbtaskContext _btaskContext;

        public TareaController(DbtaskContext btaskContext)
        {
            _btaskContext = btaskContext;
        }

        //private readonly IServiceTarea _serviceTarea;
        //public TareaController(IServiceTarea serviceTarea)
        //{
        //    _serviceTarea = serviceTarea;
        //}
        [HttpGet]
        public List<Tarea> GetTareaName()
        {
            List<Tarea> listaTareas = _btaskContext.Tareas.ToList();
            return listaTareas;
        }
    }
}
