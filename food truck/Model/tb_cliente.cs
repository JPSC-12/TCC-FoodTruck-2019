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
    
    public partial class tb_cliente
    {
        public tb_cliente()
        {
            this.tb_pedido_venda = new HashSet<tb_pedido_venda>();
        }
    
        public int id_cliente { get; set; }
        public Nullable<int> id_prodvenda { get; set; }
        public string nm_cliente { get; set; }
        public string tl_celular { get; set; }
        public string CPF { get; set; }
    
        public virtual ICollection<tb_pedido_venda> tb_pedido_venda { get; set; }
    }
}
