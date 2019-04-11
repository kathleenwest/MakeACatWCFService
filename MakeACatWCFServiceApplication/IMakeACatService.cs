using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MakeACatWCFServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMakeACatService" in both code and config file together.
    [ServiceContract]
    public interface IMakeACatService
    {
        /// <summary>
        /// Make One Cat
        /// Factory Implementation where the service creates a
        /// cat object from the specified parameters and returns
        /// a cat
        /// </summary>
        /// <param name="name">Name (string) of your cat</param>
        /// <param name="breed">Breed (CatBreed) of your cat</param>
        /// <param name="gender">Gender (GenderType) of your cat</param>
        /// <param name="age">Age (int) of your cat</param>
        /// <returns>A Cat object</returns>
        [OperationContract]
        Cat MakeACat(string name, CatBreed breed, GenderType gender, int age);

        /// <summary>
        /// Make A List of Cats
        /// Returns a full list of five random cats
        /// </summary>
        /// <returns>CatList (List<Cat>) object</returns>
        [OperationContract]
        CatList MakeCats();

    } // end of interface

} // end of namespace
