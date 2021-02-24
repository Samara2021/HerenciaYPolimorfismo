using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
   public  class CLIENTE:PERSONA
    {
        //ATRIBUTOS
        private String CATEGORIA;
        private String CODIGODEPEDIDO;
        private String CEDULA;
        //PROPIEDADES
        public string CATEGORIA1
        {
            get => CATEGORIA;
            set => CATEGORIA = value;
        }
        public string CODIGODEPEDIDO1
        {
            get => CODIGODEPEDIDO;
            set => CODIGODEPEDIDO = value;
        }
        public string CEDULA1
        {
            get => CEDULA;
            set => CEDULA = value;
        }
        //PROCEDIMIENTOS, OPERACIONES O METODOS
        public void GENERARCODIGODEPEDIDO()
        {
            this.CODIGODEPEDIDO1 = "C" + this.APPATERNO1.Substring(0, 3);
        }
   }
}
