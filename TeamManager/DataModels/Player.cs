using System;

namespace Repository.DataModels
{
    public class Player
    {
        #region Properties

        public Int32 Id { get; set; }
        
        public String Name { get; set; }

        public String Surname { get; set; }

        public DateTime BirthDate { get; set; }

        #endregion
    }
}
