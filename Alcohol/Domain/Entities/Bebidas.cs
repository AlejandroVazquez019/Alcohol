/* 
    Nombre de la escuela: Universidad Tecnologica Metropolitana

    Asignatura: Aplicaciones Web Orientadas a Servicios

    Nombre del Maestro: Joel Ivan Chuc Uc

    Nombre de la actividad: Actividad 2 (Unidad ll)

    Nombre del alumno: José Alejandro Vázquez Suaste

    Cuatrimestre: 4    Grupo: A    Parcial: 2
*/
namespace Alcohol.Domain.Entities
{
    public class Bebidas
    {
        private int _cantidad;
        private int _LCantidad;
        private int _peso;
        private double TotalC;
        private double SangreD;
        private double MasaE = 0.789;
        private double ESangre;
        private double volSangre;
        private double SangreA;
        private double GAlcohol;
        private string _bebida;
        public void AlcoholIngerido(string bebida, int cantidad)
        {
            _cantidad = cantidad;
            _bebida = bebida.ToLower();
            switch (_bebida)
            {
                    case "cerveza":
                    _LCantidad = 330;
                    _cantidad = _cantidad * _LCantidad;
                    GAlcohol = 5;
                    TotalC = GAlcohol / 100 * _cantidad;
                    break;
                    case "vino": 
                    _LCantidad = 100;
                    _cantidad = _cantidad * _LCantidad;
                    GAlcohol = 12;
                    TotalC = GAlcohol / 100 * _cantidad;
                    break;
                    case "cava": 
                    _LCantidad = 100;
                    _cantidad = _cantidad * _LCantidad;
                    GAlcohol = 12;
                    TotalC = GAlcohol / 100 * _cantidad;
                    break;
                    case "vermu":
                    _LCantidad = 70;
                    _cantidad = _cantidad * _LCantidad;
                    GAlcohol = 17;
                    TotalC = GAlcohol / 100 * _cantidad;
                    break;
                    case "licor":
                    _LCantidad = 45;
                    _cantidad = _cantidad * _LCantidad;
                    GAlcohol = 23;
                    TotalC = GAlcohol / 100 * _cantidad;
                    break;
                    case "brandy":
                    _LCantidad = 45;
                    _cantidad = _cantidad * _LCantidad;
                    GAlcohol = 38;
                    TotalC = GAlcohol / 100 * _cantidad;
                    break;
                    case "combinado":
                    _LCantidad = 50;
                    _cantidad = _cantidad * _LCantidad;
                    GAlcohol = 38;
                    TotalC = GAlcohol / 100 * _cantidad;
                    break;
        }
        }
        public void CantidadAlcoholSangre(int peso)
        {
           _peso = peso;
            SangreD = 0.15 * TotalC;
            ESangre = MasaE * SangreD;
            volSangre = 0.8 * _peso;
            SangreA = ESangre / volSangre;
        
        }
        
        public string Validar()
        {
                if (SangreA >  0.8)
                {
                    return $" El nivel de Alcohol en Sangre es: {SangreA} El Nivel de Alcohol es Mayor al Limite reglamentario, no es apto para manejar";
                }
                    return $" Su nivel de alcohol en la sangre es  de: {SangreA}  El Nivel de Alcohol Comple con el Limite reglamentario,  es apto para manejar, que tenga un buen viaje";
               
        }
    }
}