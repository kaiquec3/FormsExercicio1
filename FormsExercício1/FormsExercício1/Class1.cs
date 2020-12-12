using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsExercício1
{
    class Retangulo
    {
        #region Atributos
        double @base;
        double altura;
        double area;
        #endregion

        #region Construtores
        public Retangulo()
        {
            this.@base = 0;
            this.altura = 0;
            
        }

        public Retangulo(double @base, double altura)
        {
            this.@base = @base;
            this.altura = altura;
        
        }
        #endregion

        #region Setters e getters
        public void SetBase(double @base)
        {
            this.@base = @base;
        }

        public void SetAltura(double altura)
        {
            this.altura = altura;
        }

        public double GetBase()
        {
            return this.@base;
        }

        public double GetAltura()
        {
            return this.altura;
        }

        public double GetArea()
        {
            return this.area;
        }
        #endregion

        #region Métodos funcionais
        public double CalcularArea()
        {
            this.area = this.@base * this.altura;
            return this.area;

        }
        #endregion
    }
}
