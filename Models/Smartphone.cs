namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
		// [x]: Implementar as propriedades faltantes de acordo com o diagrama
		protected string Modelo { get; }
		protected string IMEI { get; }
		protected int Memoria { get; }

		public Smartphone(string numero, string modelo, string imei, int memoria)
		{
			Numero = numero;
			// [x]: Passar os parâmetros do construtor para as propriedades
			Modelo = modelo;
			IMEI = imei;
			Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}