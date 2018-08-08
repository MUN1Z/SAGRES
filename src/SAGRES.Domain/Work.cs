namespace SAGRES.Domain
{
    public class Work
    {
        public int WorkId { get; set; }
        public int JurisdictionId { get; set; }
        public string ContractNumber { get; set; }
        public string WorkNumber { get; set; }
        public string WorkDescription { get; set; }
        public int LocalityId { get; set; }
        public string LocalityDescription { get; set; }
        public int WorkTypeId { get; set; }
        public int TypeExecutionId { get; set; }
        public double WorkValue { get; set; }
        public string ContractedWorksheet { get; set; }
        public string IncorporableProperty { get; set; }
        public double Dimension { get; set; }
        public string NumberProtocolTramit { get; set; }
        public int WorkComplexId { get; set; }
        public bool HasCancelled { get; set; } 
    }
}
