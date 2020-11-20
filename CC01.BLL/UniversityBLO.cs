using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class UniversityBLO
    {
        UniversityDAO universityRepo;
        private string dbFolder;

        public UniversityBLO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            universityRepo = new UniversityDAO(dbFolder);
        }

        /*public void CreateUniversity(University oldUniversity, University newUniversity)
{
   string filename = null;
   if (!string.IsNullOrEmpty(newUniversity.Logo))
   {
       string ext = Path.GetExtension(newUniversity.Logo);
       filename = Guid.NewGuid().ToString() + ext;
       FileInfo fileSource = new FileInfo(newUniversity.Logo);
       string filePath = Path.Combine(dbFolder, "logo", filename);
       FileInfo fileDest = new FileInfo(filePath);
       if (!fileDest.Directory.Exists)
           fileDest.Directory.Create();
       fileSource.CopyTo(fileDest.FullName);
   }
   newUniversity.Logo = filename;
   universityRepo.Add(newUniversity);

   if (!string.IsNullOrEmpty(oldUniversity.Logo))
       File.Delete(oldUniversity.Logo);
}*/

        public IEnumerable<University> GetBy(Func<University, bool> predicate)
        {
            return universityRepo.Find(predicate);
        }

 /*       public University GetUniversity()
        {
            University university = universityRepo.Get();
            if (university != null)
                if (!string.IsNullOrEmpty(university.Logo))
                    university.Logo = Path.Combine(dbFolder, "logo", university.Logo);
            return university;
        }*/


        public void DeleteUniversity(University university)
        {
            universityRepo.Remove(university);
        }

        public void CreateUniversity(University newUniversity)
        {
            universityRepo.Add(newUniversity);
        }

        public void EditUniversity(University oldUniversity, University newUniversity)
        {
            universityRepo.Set(oldUniversity, newUniversity);
        }
    }
}
