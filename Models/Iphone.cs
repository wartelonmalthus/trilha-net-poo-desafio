namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando o app {nomeApp} num celular Iphone");
        }
    }
}