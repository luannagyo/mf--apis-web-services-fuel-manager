using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf__apis_web_services_fuel_manager.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {    //Key = chave primaria
        //required = obrigatorio ter

        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public int AnoFabricacao { get; set; }
        [Required]
        public int AnoModelo { get; set; }
        [Required]
        public ICollection<Consumo> Consumos { get; set; }
    }
}


                        

