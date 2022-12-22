using HospitalSystem.Models;
using HospitalSystem.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionRepository _prescriptionRepository;
        public PrescriptionController(IPrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
           var prescription = _prescriptionRepository.GetAll();

            if(prescription == null)
            {
                return NotFound();
            }

            return Ok(prescription);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var desc = _prescriptionRepository.GetById(id);

            if(desc == null)
            {
                return NotFound();
            }

            return Ok(desc);
        }

        [HttpPost]

        public ActionResult CreateDescription(Prescription prescription)
        {

            _prescriptionRepository.CreateDescription(prescription);
            return Ok();
        }

        [HttpDelete("{id}")]

        public ActionResult DeleteDescription(int id)
        {
            _prescriptionRepository.DeleteDescription(id);

            return Ok("Deleted Item successfully");
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdateDescription(Prescription prescription, [FromRoute] int id)
        {
            _prescriptionRepository.UpdateDescription(prescription, id);
            return Ok();
        }
    }
}
