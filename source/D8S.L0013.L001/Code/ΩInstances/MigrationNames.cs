using System;


namespace D8S.L0013.L001
{
    public class MigrationNames : IMigrationNames
    {
        #region Infrastructure

        public static IMigrationNames Instance { get; } = new MigrationNames();


        private MigrationNames()
        {
        }

        #endregion
    }
}
