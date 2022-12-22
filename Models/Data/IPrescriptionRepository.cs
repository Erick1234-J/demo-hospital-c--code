namespace HospitalSystem.Models.Data
{
    public interface IPrescriptionRepository
    {
        IEnumerable<Prescription> GetAll();

        Prescription GetById(int id);

        void CreateDescription(Prescription description);

        void UpdateDescription(Prescription description, int id);

        void DeleteDescription(int id);
    }
}
