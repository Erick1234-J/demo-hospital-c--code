using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace HospitalSystem.Models.Data
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly HospitalDbContext _context;
        public PrescriptionRepository(HospitalDbContext context)
        {
            _context = context;
        }
        public void  CreateDescription(Prescription description)
        {
           _context.Prescriptions.Add(description);
            _context.SaveChanges();
           
        }

        public void DeleteDescription(int id)
        {
           var deleteItem = _context.Prescriptions.Find(id);

            _context.Prescriptions.Remove(deleteItem);
            _context.SaveChanges();
        }

        public IEnumerable<Prescription> GetAll()
        {
            var prescription = _context.Prescriptions.ToList();
            return prescription;
        }

        public Prescription GetById(int id)
        {
            return _context.Prescriptions.Find(id);

            
        }

        public void UpdateDescription(Prescription prescription, int id)
        {
            var find = _context.Prescriptions.Find(id);

            if (find != null)
            {
                find.PatientName = prescription.PatientName;
                find.Amount = prescription.Amount;
                find.Frequency =  prescription.Frequency;

                _context.SaveChanges();
                
            }

        }
    }
}
