using System;


namespace D8S.L0013.F001
{
    public static class Instances
    {
        public static IProcessOperator ProcessOperator => F001.ProcessOperator.Instance;
        public static L0002.L001.IProcessStartInfos ProcessStartInfos => L0002.L001.ProcessStartInfos.Instance;
        public static R5T.L0066.IStringOperator StringOperator => R5T.L0066.StringOperator.Instance;
        public static R5T.L0066.IStrings Strings => R5T.L0066.Strings.Instance;
        public static R5T.F0103.ITimingOperator TimingOperator => R5T.F0103.TimingOperator.Instance;
    }
}