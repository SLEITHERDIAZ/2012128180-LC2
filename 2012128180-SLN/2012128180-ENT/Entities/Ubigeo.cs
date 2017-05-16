using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_ENT
{
   public class Ubigeo
    {
        public int UbigeoId { get; set; }

       public class Distrito
            {
                public Distrito _Distrito;


                public Distrito(Distrito DistritoId)
                {
                    _Distrito = DistritoId;


                }



                public Distrito DistritoId { get { return _Distrito; } }



            }

           public class Provincia
            {
                public Provincia _Provincia;


                public Provincia(Provincia ProvinciaId)
                {
                    _Provincia = ProvinciaId;


                }
                public Provincia ProvinciaId { get { return _Provincia; } }
            }
           public class Departamento
            {
                public Departamento _Departamento;

                public Departamento(Departamento DepartamentoId)
                {
                    _Departamento = DepartamentoId;
                }

                public Departamento DepartamentoId { get { return _Departamento; } }
            }
            public Ubigeo()
            { }

        public int _Ubigeo { get; set; }
    }
    }
