using System.ComponentModel;

namespace Arthes_2022.Models.Entities
{
    public enum Mes : int
    {
        JANEIRO = 1,
        FEVEREIRO,
        [Description("MARÇO")]
        MARCO,
        ABRIL,
        MAIO,
        JUNHO,
        JULHO,
        AGOSTO,
        SETEMBRO,
        OUTBRO,
        NOVEMBRO,
        DEZEMBRO
    }
}
