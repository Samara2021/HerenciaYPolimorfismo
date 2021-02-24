using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
   public class EMPLEADO:PERSONA
    {
        //ATRIBUTOS
        private String TIPO;
        private String TIPOCONTRATO;
        private double SUELDO;
        private String CEDULA;
        private String LISTACEDULA;
        //PROPIEDADES
        public string TIPO1
        {
            get => TIPO;
            set => TIPO = value;
        }
        public string TIPOCONTRATO1
        {
            get => TIPOCONTRATO;
            set => TIPOCONTRATO = value;
        }
        public double SUELDO1
        {
            get => SUELDO;
            set => SUELDO = value;
        }
        public string CEDULA2
        {
            get => CEDULA;
            set => CEDULA = value;
        }
        public string LISTACEDULA1 
        {
            get => LISTACEDULA; 
            set => LISTACEDULA = value; 
        }

        //PROCEDIMIENTOOS, OPERACIONES O METODOS
        public void CALCULARSUELDO(Double SUELDOBASE)
        {
            if (this.TIPO1 == "GERENTE")
            {
                if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = 2 * +SUELDOBASE + 1500;
                }
            }
            else if (this.TIPO1 == "VENDEDOR")
            {
                if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = SUELDOBASE + 1500;
                }
            }
            else
            {
                this.SUELDO1 = 0;
            }
        }
        public void GENERARLISTACEDULA()
        {
            this.LISTACEDULA1 = this.CEDULA2.Substring(0, 9);
        }
    }
}
