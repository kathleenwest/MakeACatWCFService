using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MakeACatWCFServiceApplication
{
    public class MakeACatService : IMakeACatService
    {
        private static Random m_Random = new Random();
        private static List<string> m_CatNames = new List<string>();

        /// <summary>
        /// Loads Cat Names from a File
        /// </summary>
        private static void LoadNames()
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (StreamReader sr = new StreamReader(asm.GetManifestResourceStream("MakeACatWCFServiceApplication.App_Data.catnames.txt")))
            {
                while (!sr.EndOfStream)
                {
                    string name = sr.ReadLine().Trim().ToLower();
                    if (!string.IsNullOrEmpty(name))
                    {
                        m_CatNames.Add(string.Format("{0}{1}", char.ToUpper(name[0]), name.Substring(1)));
                    }
                }
            }
        } // end of load names

        /// <summary>
        /// Makes a Cat
        /// </summary>
        /// <param name="name">Name (string) of the cat</param>
        /// <param name="breed">Breed (CatBreed) of the cat</param>
        /// <param name="gender">Gender (GenderType) of the cat</param>
        /// <param name="age">Age (int) of the cat</param>
        /// <returns></returns>
        public Cat MakeACat(string name, CatBreed breed, GenderType gender, int age)
        {
            Cat cat = new Cat(name, breed, gender, age);
            return cat;
        }

        /// <summary>
        /// Returns a List of 5 Cats 
        /// Random Names
        /// One from each cat breed
        /// </summary>
        /// <returns>CatList a List of Cat type objects</returns>
        public CatList MakeCats()
        {
            // If no cat names, load the list
            if (m_CatNames.Count == 0)
            {
                LoadNames();
            }

            CatList cats = new CatList();
            //int myCatBreedMemberCount = Enum.GetNames(typeof(CatBreed)).Length;
            //int myGenderTypeMemberCount = Enum.GetNames(typeof(GenderType)).Length;
            cats.Add(new Cat(m_CatNames[m_Random.Next(0, m_CatNames.Count)], CatBreed.Abyssinian, GenderType.Male, m_Random.Next(1, 18)));
            cats.Add(new Cat(m_CatNames[m_Random.Next(0, m_CatNames.Count)], CatBreed.American_Shorthair, GenderType.Female, m_Random.Next(1, 18)));
            cats.Add(new Cat(m_CatNames[m_Random.Next(0, m_CatNames.Count)], CatBreed.Bengal, GenderType.Male, m_Random.Next(1, 18)));
            cats.Add(new Cat(m_CatNames[m_Random.Next(0, m_CatNames.Count)], CatBreed.British_Longhair, GenderType.Female, m_Random.Next(1, 18)));
            cats.Add(new Cat(m_CatNames[m_Random.Next(0, m_CatNames.Count)], CatBreed.Maine_Coon, GenderType.Female, m_Random.Next(1, 18)));

            return cats;

        } // end of method

    } // end of class
} // end of namespace
