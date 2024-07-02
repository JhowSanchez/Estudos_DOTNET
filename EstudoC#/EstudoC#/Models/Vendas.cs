using Newtonsoft.Json;

namespace EstudoC_.Models
{
    public class Vendas
    {
        
        /*public Vendas(int id, string produto, decimal preco) {
            Id = id;
            Produto = produto; 
            Preco = preco;
        }
        public Vendas(int id, string produto, decimal preco,DateTime data) {
            Id = id;
            Produto = produto; 
            Preco = preco;
            DataVenda = data;
        }
        */
        public int Id { get; set; }
        //[JsonProperty("Nome_Produto")]
        [JsonProperty("Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}
