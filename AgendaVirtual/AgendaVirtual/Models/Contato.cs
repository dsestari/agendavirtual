using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace AgendaVirtual.Models
{
    public class Contato
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idContato { get; set; }

        [Required(ErrorMessage = "Favor digite um nome.")]
        [DisplayName("Nome Completo:")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Favor informe um e-mail.")]
        [DisplayName("E-mail:")]
        [DataType(DataType.EmailAddress)]
        public string email {get; set;}

        [Required(ErrorMessage = "Favor informar um número de telefone.")]
        [DisplayName("Telefone (ddd + número):")]
        [RegularExpression(@"^.{13,}$", ErrorMessage = "Campo inválido.")]
        public string telefone {get; set;}

        [Required(ErrorMessage = "Campo celular é obrigatório.")]
        [DisplayName("Celular (ddd + 9 + número):")]
        [RegularExpression(@"^.{14,}$", ErrorMessage = "Campo celular inválido.")]
        public string celular {get; set;}

        [Required(ErrorMessage = "Selecione uma foto.")]
        [DisplayName("Foto:")]
        public string foto { get; set; }
    }
}