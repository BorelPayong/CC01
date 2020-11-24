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
        EtudiantDAL etudiantRepo;

        public EtudiantBLO(string dbFolder)
        {
            etudiantRepo = new EtudiantDAL(dbFolder);
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

        public IEnumerable<EtudiantBLO> GetBy(Func<EtudiantBLO, bool> predicate)
        {
            return etudiantRepo.Find(predicate);
        }

        public void EditEtudiant(EtudiantBLO oldetudiant, EtudiantBLO newetudiant)
        {
            etudiantRepo.Set(oldetudiant, newetudiant);
        }

    }
}
