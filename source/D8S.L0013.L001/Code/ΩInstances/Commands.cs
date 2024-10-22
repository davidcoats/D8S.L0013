using System;


namespace D8S.L0013.L001
{
    public class Commands : ICommands
    {
        #region Infrastructure

        public static ICommands Instance { get; } = new Commands();


        private Commands()
        {
        }

        #endregion
    }
}
