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
    
    public partial class tb_pedido_compra
    {
        public tb_pedido_compra()
        {
            this.tb_pedido_compra_item = new HashSet<tb_pedido_compra_item>();
        }
    
        public int id_pedido_compra { get; set; }
        public Nullable<int> id_Fornecedor { get; set; }
        public Nullable<System.DateTime> dt_pedido { get; set; }
        public Nullable<int> id_produto { get; set; }
    
        public virtual tb_produto tb_produto { get; set; }
        public virtual ICollection<tb_pedido_compra_item> tb_pedido_compra_item { get; set; }
        public virtual tb_fornecedor tb_fornecedor { get; set; }
    }
}
