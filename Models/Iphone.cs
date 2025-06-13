namespace DesafioPOO.Models

{
       // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone 
    {
        public Iphone(String numero, String modelo, String imei, int memoria ) : base(numero, modelo, imei, memoria){

        }
        public override void InstalarAplicativo( String nomeApp){
           Console.WriteLine($"Instalando {nomeApp} no Iphone");
        }
        // TODO: Sobrescrever o método "InstalarApli
}