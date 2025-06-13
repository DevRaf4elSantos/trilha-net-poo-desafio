namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone 
    {
        public Nokia(String numero, String modelo, String imei, int memoria ) : base(numero, modelo, imei, memoria){

        }
        public override void InstalarAplicativo( String nomeApp){
               Console.WriteLine($"Instalando {nomeApp} no Nokia");
            }
            // TODO: Sobrescrever o método "InstalarAplicativo"
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}