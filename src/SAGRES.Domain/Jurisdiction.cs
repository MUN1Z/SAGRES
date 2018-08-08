namespace SAGRES.Domain
{
    public class Jurisdiction
    {
        public int JurisdictionId { get; set; }
        public int PJ { get; set; }
        public int Power { get; set; }
        public int IdTipoJurisdicionado { get; set; }
        public int IdLocalidade { get; set; }
        public string Nome { get; set; }
        public string CodigoSagres { get; set; }
        public bool Previdenciario { get; set; }
        public string MunicipioImportacao { get; set; }
        public int IdTramita { get; set; }
        public bool HasCancelled { get; set; }
    }
}
