namespace Alcohol.Domain.Interface
{
    public interface Datos
    {
        void AlcoholIngerido(string bebida, int cantidad);
        void CantidadAlcoholSangre(int peso);
        string Validar();
    }
}