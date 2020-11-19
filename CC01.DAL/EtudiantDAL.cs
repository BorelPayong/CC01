using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC01.BO;

namespace CC01.DAL
{
    public class EtudiantDAL
    {
        private static List<EtudiantBO> etudiants;

        private const string FILE_NAME = @"etudiants.json";

        private readonly string dbFolder;

        private FileInfo file; 

        public EtudiantDAL(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if(file.Length > 0)
            {
                using(StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    etudiants = JsonConvert.DeserializeObject<List<EtudiantBO>>(json);
                }
            }
            if(etudiants == null)
            {
                etudiants = new List<EtudiantBO>();
            }
        }

        public void Add(EtudiantBO etudiant)
        {
            var index = etudiants.IndexOf(etudiant);
            if (index >= 0)
                throw new DuplicateNameException("Cet identifiant existe déja !");
            etudiants.Add(etudiant);
            Save();
        }

        private void Save()
        {
            using(StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(etudiants);
                sw.WriteLine(json);
            }
        }

        public void Remove(EtudiantBO etudiant)
        {
            etudiants.Remove(etudiant);
            Save();
        }

        public IEnumerable<EtudiantBO> Find()
        {
            return new List<EtudiantBO>(etudiants);
        }

        public IEnumerable<EtudiantBO> Find(Func<EtudiantBO, bool> predicate)
        {
            return new List<EtudiantBO>(etudiants.Where(predicate).ToArray());
        }
    }
}
