//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace food_truck.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_taxa
    {
        public int id_taxa { get; set; }
        public Nullable<int> id_holerite { get; set; }
        public Nullable<int> id_funcionario { get; set; }
        public Nullable<decimal> vl_inss { get; set; }
        public Nullable<decimal> vl_fgts { get; set; }
        public Nullable<decimal> vl_VTransporte { get; set; }
        public Nullable<decimal> vl_VRefeicao { get; set; }
        public Nullable<decimal> vl_VAlimentacao { get; set; }
    
        public virtual tb_funcinario tb_funcinario { get; set; }
        public virtual tb_holerite tb_holerite { get; set; }
    }
}
