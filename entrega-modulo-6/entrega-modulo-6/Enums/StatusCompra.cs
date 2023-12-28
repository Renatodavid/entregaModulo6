using System.ComponentModel;

namespace entrega_modulo6.Enums
{
   
        public enum StatusCompra
        {
            [Description("Compra não Realizada")]
            AFazer = 1,
            [Description("Compra em Andamento")]
            EmAndamento = 2,
            [Description("Compra Finalizada")]
            Concluido = 3
        }
    }

