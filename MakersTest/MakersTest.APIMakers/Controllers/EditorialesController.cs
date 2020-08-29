using MakersTest.APIMakers.Data;
using MakersTest.APIMakers.Data.Entities;
using MakersTest.APIMakers.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace MakersTest.APIMakers.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EditorialesController : ControllerBase
    {
        private readonly IEditorialesRepository editorialesRepository;

        //private readonly DataContext dataContext;

        //public EditorialesController(DataContext dataContext)
        //{
        //    this.dataContext = dataContext;
        //}

        public EditorialesController(IEditorialesRepository editorialesRepository)
        {
            this.editorialesRepository = editorialesRepository;
        }

        //public   Task<ActionResult<IEnumerable<Editorial>>> GetEditoriales()
        //{
        //    return   editorialesRepository.GetAll();
        //}

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var user = new UserKey
        //    {
        //        FullName = "Daniel Ramirez",
        //        Key = Guid.NewGuid().ToString()
        //    };

        //    return Ok(user);
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        [HttpGet]
        public IActionResult GetEditoriales()
        {
            //Como tiene Get, el controlador infiere que es un método GET. De todas formas colocamos el [HttpGet]
            //Ok: Envuelve el resultado en un json

            IEnumerable<Editorial> lst = editorialesRepository.GetAll();
            return Ok(editorialesRepository.GetAll());
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<Editorial>> GetEditoriales()
        //{
        //    return editorialesRepository.GetAll();
        //}

        //// GET: api/Editoriales
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Editorial>>> GetEditorials()
        //{
        //    return await editorialesRepository.GetAll().ToListAsync();
        //}
    }
}
