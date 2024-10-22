using System;


namespace D8S.L0013.L001
{
    public class SubCommands : ISubCommands
    {
        #region Infrastructure

        public static ISubCommands Instance { get; } = new SubCommands();


        private SubCommands()
        {
        }

        #endregion
    }
}
