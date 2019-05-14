using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BotanicalsWebAPI.Services;
using BotanicalsWebAPI.Models;
using Newtonsoft.Json.Linq;


namespace OCPCalendarRestAPI.Controllers
{
    [Route("api/botanicals")]
    [ApiController]
    public class BotanicalsController : ControllerBase
    {

        private readonly BotanicalService _service;

        public BotanicalsController(BotanicalService service)
        {
            this._service = service;
        }

        [HttpGet]
        public ActionResult<List<Botanical>> getBotanicals()
        {
            var items = this._service.getAll();

            return items;
        }

        [HttpGet("{id}", Name = nameof(getBotanicalById))]
        public ActionResult<Botanical> getBotanicalById(String id)
        {

            var botanical = this._service.getBotanical(id);

            if (botanical == null) {

                return NotFound(createErrorMessage("Botanical Not Found for Id" + id));
            }

            return botanical;
        }

        [HttpPut("{id}")]
        public ActionResult<Botanical> Put(String id, [FromBody] Botanical request)
        {
            var botanical = this._service.getBotanical(id);

            if (botanical == null) {

                return NotFound(createErrorMessage("Botanical does not exist for ID=" + id));
            }

            var result = this._service.updateBotanical(id, request);

            return result;
        }

        [HttpPost]
        public ActionResult<Botanical> Create([FromBody] Botanical request)
        {
            var botanical = this._service.getBotanical(request.Id);

            if (botanical != null) {

                return Conflict(createErrorMessage("Id already exists id=" + request.Id));
            }

            var result = this._service.addBotanical(request);

            return result;
        }

        private ErrorObject createErrorMessage(string msg) {

            return new ErrorObject(msg);
        }
    }
}