using System;


namespace D8S.L0013.L001
{
    public class Verbs : IVerbs
    {
        #region Infrastructure

        public static IVerbs Instance { get; } = new Verbs();


        private Verbs()
        {
        }

        #endregion
    }
}
