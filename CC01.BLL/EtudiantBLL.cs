using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC01.BO;
using CC01.DAL;

namespace CC01.BLL
{
    public class EtudiantBLL
    {
        EtudiantDAL etudiantRepo;

        public EtudiantBLL(string dbFolder)
        {
            etudiantRepo = new EtudiantDAL(dbFolder);
        }

        public void CreateEtudiant(EtudiantBO etudiantBO)
        {
            etudiantRepo.Add(etudiantBO);
        }

        public void DeleteEtudiant(EtudiantBO etudiantBO)
        {
            etudiantRepo.Remove(etudiantBO);
        }

        public IEnumerable<EtudiantBO> .......
        {
            return etudiantRepo.Find();
        }

        public IEnumerable<EtudiantBO> 
    }
}
