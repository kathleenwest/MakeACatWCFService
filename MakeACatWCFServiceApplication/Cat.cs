using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Web;

namespace MakeACatWCFServiceApplication
{
    /// <summary>
    /// Cat
    /// Represents a Cat Object
    /// </summary>
    [DataContract]
    public class Cat
    {
        #region Properties

        /// <summary>
        /// Name of Cat
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Breed of Cat
        /// </summary>
        [DataMember]
        public CatBreed Breed { get; set; }

        /// <summary>
        /// Gender of Cat
        /// </summary>
        [DataMember]
        public GenderType Gender { get; set; }

        /// <summary>
        /// Age of Cat
        /// </summary>
        [DataMember]
        public int Age { get; set; }

        /// <summary>
        /// Photo of the Cat
        /// </summary>
        [DataMember]
        public Bitmap Photo { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Cat()
        {

        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public Cat(string name, CatBreed breed, GenderType gender, int age)
        {
            Name = name;
            Breed = breed;
            Gender = gender;
            Age = age;

            // Photo
            Assembly asm = Assembly.GetExecutingAssembly();
            string path1 = "MakeACatWCFServiceApplication.App_Data.photos.";
            string path2 = Breed.ToString();
            string filepath = path1 + path2 + ".jpg";
            Photo = new Bitmap(asm.GetManifestResourceStream(filepath));
        } // end of constructor

        #endregion Constructors

    } // end of Cat class

    /// <summary>
    /// Collection of Cat Objects
    /// </summary>
    [CollectionDataContract]
    public class CatList : List<Cat>
    {

    }

    #region enums

    /// <summary>
    /// List of Cat Breeds
    /// </summary>
    public enum CatBreed
    {
        Abyssinian = 0,
        American_Shorthair,
        Bengal,
        British_Longhair,
        Maine_Coon
    } // end of enum

    /// <summary>
    /// List of Gender Types
    /// </summary>
    public enum GenderType
    {
        Male,
        Female
    } // end of enum

    #endregion enums

} // end of namespace