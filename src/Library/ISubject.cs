namespace Observer
{
    /// <summary>
    /// Interfaz ICharacter donde están las firmas de los metodos que tienen en común los personajes. Esta cumple con el patrón
    /// Polimorfismo ya que es implementada por varios objetos de diferentes tipos.
    /// </summary>
    public interface ISubject
    {
        public void Subscribe(IObserver observer);

        public void Unsubscribe(IObserver observer);
    }

}