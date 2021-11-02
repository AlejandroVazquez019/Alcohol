using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Alcohol.Services
{
    //calcuar el total de alcohol
    public class AlcoholService
    {
        public double CalcularTotalAlcoholConsumido(string bebida, int Cantidad)
        {
            int totalBebidaConsumido;
            double totalAlcoholPorBebidaConsumido;
            switch(bebida)
            {
                case "cerveza":
                totalBebidaConsumido=Cantidad*330;
                totalAlcoholPorBebidaConsumido=totalBebidaConsumido*0.05;
                break;

                case "vino" or "cava":
                totalBebidaConsumido=Cantidad*100;
                totalAlcoholPorBebidaConsumido=totalBebidaConsumido*0.12;
                break;

                case "vermu":
                totalBebidaConsumido=Cantidad*70;
                totalAlcoholPorBebidaConsumido=totalBebidaConsumido*0.24;
                break;

                case "licor":
                totalBebidaConsumido=Cantidad*45;
                totalAlcoholPorBebidaConsumido=totalBebidaConsumido*0.51;
                break;

                case "brandy":
                totalBebidaConsumido=Cantidad*45;
                totalAlcoholPorBebidaConsumido=totalBebidaConsumido*0.84;
                break;

                case "combinado":
                totalBebidaConsumido=Cantidad*50;
                totalAlcoholPorBebidaConsumido=totalBebidaConsumido*0.76;
                break;
                default:
                return totalAlcoholPorBebidaConsumido=0;
            }
            return totalAlcoholPorBebidaConsumido;

            }

        internal object CalcularTotalAlcoholConsumido(string bebida, object cantidad)
        {
            throw new NotImplementedException();
        }

        //calcular la cantidad de alcohol que pasa directo a la sangre
        public double CalcularCantidadAlcoholSangre(double totalAlcoholPorBebidaConsumido)
            {
                double CantidadAlcoholSangre=(totalAlcoholPorBebidaConsumido*15)/100;
                return CantidadAlcoholSangre;
            }
            //calcular la masa del etanol en sangre
            public double CalcularMasa(double CantidadAlcoholSangre)
            {
                double masa = 0.789 * CantidadAlcoholSangre;
                return masa;
            }

            //calcular el volumen de la sangre de la persona considerando su peso
            public double CalcularVolumenSangre(double peso)
            {
                double volumenSangre= (8*peso/100);
                return volumenSangre;
            }

            //calcular el volumen de alcochol en la sangre (alcoholemia)
            public double CalcularVolumenAlcohol(double masa, double volumenSangre)
            {
                double volumenAlcohol=masa/volumenSangre;
                return volumenAlcohol;
            }

            //validar si es apto para manejar
            public string Validar(double volumenAlcohol)
            {
                string resultado;

                if (volumenAlcohol>0.8)
                {
                    resultado = $"La cantidad de alcohol que tiene es: {volumenAlcohol}. es superior a 0.8 y no es apta para manejar.";
                    return resultado;
                }
                resultado = $"La cantidad de alcohol que tiene es: {volumenAlcohol}. es inferios a 0.8 y es apta para manejar. ";
                return resultado;
            }
        }
    }
