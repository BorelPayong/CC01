using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC01.BO;
using CC01.DAL;

namespace CC01.BLL
{
    public class EtudiantBLO
    {
        EtudiantDAO etudiantRepo;

        public EtudiantBLO(string dbFolder)
        {
            etudiantRepo = new EtudiantDAO(dbFolder);
        }

        public void CreateEtudiant(BO.Etudiant etudiantBO)
        {
            etudiantRepo.Add(etudiantBO);
        }

        public void DeleteEtudiant(BO.Etudiant etudiantBO)
        {
            etudiantRepo.Remove(etudiantBO);
        }

        public IEnumerable<BO.Etudiant> GetAllEtudiants()
        {
            return etudiantRepo.Find();
        }

        public IEnumerable<BO.Etudiant> GetByIdentifiant(string identifiant)
        {
            return etudiantRepo.Find(x => x.Identifiant == identifiant);
        }

        public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
        {
            return etudiantRepo.Find(predicate);
        }

        public void EditEtudiant(Etudiant oldEtudiant, Etudiant newEtudiant)
        {
            etudiantRepo.Set(oldEtudiant, newEtudiant);
        }

    }
}
